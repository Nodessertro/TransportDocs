using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportDocs.Data;
using TransportDocs.Models;
using TransportDocs.Repositories;
using TransportDocs.Services;

namespace TransportDocs
{
    public partial class TransportationBills : Form
    {
        private readonly TransportationBillRepository _repo = new();
        private int _selectedId;
        private List<Contractor> _allContractors;
        private const int PHYSICAL_PERSON_CONTRACTOR_ID = 1;

        public TransportationBills()
        {
            InitializeComponent();
            LoadData();
            LoadLookups();
            UpdateNumberPreview();
        }

        private void LoadContractors()
        {
            _allContractors = new ContractorRepository().GetAll();

            cbContractors.DataSource = _allContractors;
            cbContractors.DisplayMember = "Name";
            cbContractors.ValueMember = "Id";
        }

        private void LoadData()
        {
            gridBills.DataSource = null;
            gridBills.DataSource = _repo.GetAll();
            chkPhysicalPerson_CheckedChanged(this, EventArgs.Empty);
            chkWithoutNumber_CheckedChanged(this, EventArgs.Empty);
        }

        private void LoadLookups()
        {
            cbCustomers.DataSource = new CustomerRepository().GetAll();
            cbCustomers.DisplayMember = "Name";
            cbCustomers.ValueMember = "Id";

            cbCarriers.DataSource = new CarrierRepository().GetAll();
            cbCarriers.DisplayMember = "Name";
            cbCarriers.ValueMember = "Id";

            cbContractors.DataSource = new ContractorRepository().GetAll();
            cbContractors.DisplayMember = "Name";
            cbContractors.ValueMember = "Id";

            LoadContractors();
        }

        private void gridBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var bill = (TransportationBill)gridBills.Rows[e.RowIndex].DataBoundItem;
            _selectedId = bill.Id;

            dtDate.Value = bill.Date;

            bool isPhysical = bill.ContractorId == 0;

            chkPhysicalPerson.Checked = isPhysical;

            if (isPhysical)
            {
                txtWhom.Text = bill.Whom;
                txtAddress.Text = bill.Address;
            }
            else
            {
                cbContractors.SelectedValue = bill.ContractorId;
            }

            cbCustomers.SelectedValue = bill.CustomerId;
            cbCarriers.SelectedValue = bill.CarrierId;
            cbContractors.SelectedValue = bill.ContractorId;

            txtActNumber.Text = bill.InvoiceNumber;
            txtTripNumber.Text = bill.RequestNumber;
            txtResponsible.Text = bill.Responsible;
            txtDocs.Text = bill.SupportingDocuments;

            numCost.Value = bill.Cost;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var bill = ReadForm();

            using var con = Db.GetConnection();
            con.Open();

            using var tx = con.BeginTransaction();

            var numbering = new NumberingService(con, tx);

            bill.InvoiceNumber = numbering.GetNextTripNumber(
                bill.CarrierId,
                bill.Date
            );

            tx.Commit();
            _repo.Add(bill);

            ClearForm();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;

            var bill = ReadForm();
            bill.Id = _selectedId;

            _repo.Update(bill);
            ClearForm();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;

            if (MessageBox.Show(
                "Удалить накладную?",
                "Подтверждение",
                MessageBoxButtons.YesNo
            ) != DialogResult.Yes) return;

            _repo.Delete(_selectedId);
            ClearForm();
            LoadData();
        }

        private TransportationBill ReadForm()
        {
            bool isPhysical = chkPhysicalPerson.Checked;

            return new TransportationBill
            {
                Date = dtDate.Value,
                CustomerId = (int)cbCustomers.SelectedValue,
                CarrierId = (int)cbCarriers.SelectedValue,

                ContractorId = isPhysical
                    ? 1
                    : (int)cbContractors.SelectedValue,

                Whom = isPhysical
                    ? txtWhom.Text
                    : ((Contractor)cbContractors.SelectedItem).Name,

                Address = isPhysical
                    ? txtAddress.Text
                    : ((Contractor)cbContractors.SelectedItem).Address,

                InvoiceNumber = txtActNumber.Text,
                RequestNumber = txtTripNumber.Text,
                Responsible = txtResponsible.Text,
                SupportingDocuments = txtDocs.Text,
                Cost = numCost.Value
            };
        }

        private void ClearForm()
        {
            _selectedId = 0;

            txtActNumber.Clear();
            txtTripNumber.Clear();
            txtResponsible.Clear();
            txtDocs.Clear();
            txtAddress.Clear();
            txtWhom.Clear();

            numCost.Value = 0;
            dtDate.Value = DateTime.Today;
        }

        private void chkPhysicalPerson_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumberPreview();
            bool isPhysical = chkPhysicalPerson.Checked;

            cbContractors.Visible = !isPhysical;

            if (isPhysical)
            {
                cbContractors.SelectedValue = PHYSICAL_PERSON_CONTRACTOR_ID;
            }

            txtWhom.Visible = isPhysical;
            txtAddress.Visible = isPhysical;

            lblAdres.Visible = isPhysical;
            lblWhom.Visible = isPhysical;
        }

        private void cbContractors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbContractors.SelectedItem is Contractor c)
            {
                txtWhom.Text = c.Name;
            }
        }

        private void chkWithoutNumber_CheckedChanged(object sender, EventArgs e)
        {
            bool isWhithoutNumber = !chkActWithoutNumber.Checked;

            lblInvoiceNumber.Visible = isWhithoutNumber;
            txtActNumber.Visible = isWhithoutNumber;
        }

        private void cbContractors_TextChanged(object sender, EventArgs e)
        {
            if (cbContractors.SelectedItem != null)
                return;

            string text = cbContractors.Text;

            if (string.IsNullOrWhiteSpace(text))
            {
                cbContractors.DataSource = _allContractors;
                cbContractors.DroppedDown = false;
                return;
            }

            var filtered = _allContractors
                .Where(c => c.Name.Contains(text, StringComparison.OrdinalIgnoreCase))
                .ToList();

            cbContractors.DataSource = filtered;
            cbContractors.DisplayMember = "Name";
            cbContractors.ValueMember = "Id";

            cbContractors.DroppedDown = true;
            cbContractors.SelectionStart = text.Length;
        }

        private void cbContractors_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbContractors.Text = ((Contractor)cbContractors.SelectedItem).Name;
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

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateNumberPreview();
        }

        private void cbCarriers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNumberPreview();
        }
    }
}
