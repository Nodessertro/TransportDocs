using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using TransportDocs.Models;
using TransportDocs.Repositories;
using TransportDocs.Services;

namespace TransportDocs
{
    public partial class AllDocumentsForm : Form
    {
        private List<Contractor> _allContractors;

        public AllDocumentsForm()
        {
            InitializeComponent();
            LoadLookups();
            UpdateNumberPreview();
            ToggleRecipientFields();
            UpdateContractorSelection();
        }

        private void LoadLookups()
        {
            cbCustomers.DataSource = new CustomerRepository().GetAll();
            cbCustomers.DisplayMember = "Name";
            cbCustomers.ValueMember = "Id";

            cbCarriers.DataSource = new CarrierRepository().GetAll();
            cbCarriers.DisplayMember = "Name";
            cbCarriers.ValueMember = "Id";

            _allContractors = new ContractorRepository().GetAll();
            cbContractors.DataSource = _allContractors;
            cbContractors.DisplayMember = "Name";
            cbContractors.ValueMember = "Id";
        }

        private void chkPhysicalPerson_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumberPreview();
            ToggleRecipientFields();
            UpdateContractorSelection();
        }

        private void ToggleRecipientFields()
        {
            bool isPhysical = chkPhysicalPerson.Checked;

            cbContractors.Visible = !isPhysical;

            txtAddress.Visible = isPhysical;
            label5.Visible = isPhysical;
        }

        private void UpdateContractorSelection()
        {
            if (!chkPhysicalPerson.Checked) return;

            var target = _allContractors
                ?.FirstOrDefault(c => c.Name == "Физическое лицо");

            if (target != null)
            {
                cbContractors.SelectedItem = target;
            }
        }

        private void cbContractors_TextChanged(object sender, EventArgs e)
        {
            if (cbContractors.SelectedItem != null)
                return;

            string text = cbContractors.Text;

            if (string.IsNullOrWhiteSpace(text))
            {
                cbContractors.DataSource = _allContractors;
                return;
            }

            cbContractors.DataSource = _allContractors
                .Where(c => c.Name.Contains(text, StringComparison.OrdinalIgnoreCase))
                .ToList();

            cbContractors.DroppedDown = true;
            cbContractors.SelectionStart = text.Length;
        }

        private void btnCreateAll_Click(object sender, EventArgs e)
        {
            var req = BuildRequestFromForm();

            var service = new AllDocumentsService();
            var result = service.CreateAll(req);

            var generator = new DocumentGenerator();
            generator.StartRun(req);
            string actPath = generator.GenerateActAndRequest(
                req,
                result.ActNumber,
                result.TripNumber
            );
            string billPath = generator.GenerateTransportationBill(
                req,
                result.ActNumber,
                result.TripNumber
            );
            OpenOutputFolder(generator.LastOutputDir);
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            var req = BuildRequestFromForm();

            var service = new AllDocumentsService();
            var result = service.CreateActAndRequest(req);

            var generator = new DocumentGenerator();
            generator.StartRun(req);
            string actPath = generator.GenerateActAndRequest(
                req,
                result.ActNumber,
                result.TripNumber
            );
            OpenOutputFolder(generator.LastOutputDir);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            var req = BuildRequestFromForm();

            string invoiceNumber = txtActNumber.Text;

            var billService = new TransportationBillService();
            string requestNumber = billService.CreateWithNumbering(
                req,
                invoiceNumber
            );
            txtTripNumber.Text = requestNumber;

            var generator = new DocumentGenerator();
            generator.StartRun(req);
            string billPath = generator.GenerateTransportationBill(
                req,
                invoiceNumber,
                requestNumber
            );
            OpenOutputFolder(generator.LastOutputDir);
        }

        private AllDocumentsRequest BuildRequestFromForm()
        {
            return new AllDocumentsRequest
            {
                Date = dtDate.Value,
                City = txtCity.Text,
                CustomerId = (int)cbCustomers.SelectedValue,
                CarrierId = (int)cbCarriers.SelectedValue,
                Cost = numCost.Value,

                ActWithoutNumber = chkActWithoutNumber.Checked,

                IsPhysicalPerson = chkPhysicalPerson.Checked,
                ContractorId = chkPhysicalPerson.Checked
                        ? null
                        : (int?)cbContractors.SelectedValue,
                Whom = chkPhysicalPerson.Checked
                        ? "Физическое лицо"
                        : ((Contractor)cbContractors.SelectedItem).Name,
                Address = chkPhysicalPerson.Checked
                        ? txtAddress.Text
                        : ((Contractor)cbContractors.SelectedItem).Address
            };
        }

        private void UpdateNumberPreview()
        {
            if (cbCarriers.SelectedItem is not Carrier carrier)
                return;

            int carrierId = carrier.Id;

            var preview = new NumberPreviewService();

            txtTripNumber.Text = preview.PreviewTripNumber(
                carrierId,
                dtDate.Value
            );

            txtActNumber.Text = chkActWithoutNumber.Checked
                ? "б/н"
                : preview.PreviewActNumber(carrierId);
        }

        private void cbCarriers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNumberPreview();
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateNumberPreview();
        }

        private static void OpenOutputFolder(string? folderPath)
        {
            if (string.IsNullOrWhiteSpace(folderPath))
                return;

            Process.Start(new ProcessStartInfo
            {
                FileName = folderPath,
                UseShellExecute = true
            });
        }
    }
}
