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
    public partial class FinishedDocuments : Form
    {
        private readonly FinishedDocumentRepository _repo = new();

        public FinishedDocuments()
        {
            InitializeComponent();
            LoadLookups();
        }

        private void LoadLookups()
        {
            cbCustomers.DataSource = new CustomerRepository().GetAll();
            cbCustomers.DisplayMember = "Name";
            cbCustomers.ValueMember = "Id";

            cbCarriers.DataSource = new CarrierRepository().GetAll();
            cbCarriers.DisplayMember = "Name";
            cbCarriers.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var doc = new FinishedDocument
            {
                Date = dtDate.Value,
                City = txtCity.Text,
                CustomerId = (int)cbCustomers.SelectedValue,
                CarrierId = (int)cbCarriers.SelectedValue,
                Cost = numCost.Value,
                TripNumber = txtTripNumber.Text,
            };

            using var con = Db.GetConnection();
            con.Open();

            using var tx = con.BeginTransaction();

            var numbering = new NumberingService(con, tx);

            doc.ActNumber = numbering.GetNextSimpleNumber(
                doc.CarrierId,
                dtDate.Value.Year
            );

            tx.Commit();

            _repo.Add(doc);

            txtActNumber.Text = doc.ActNumber;

            MessageBox.Show("Документ сохранён");
        }

        private void chkActWithoutNumber_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumberPreview();

            txtActNumber.Text = chkActWithoutNumber.Checked
                ? "б/н"
                : string.Empty;
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
    }
}
