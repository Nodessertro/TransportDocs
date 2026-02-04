using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportDocs.Repositories;
using TransportDocs.Models;

namespace TransportDocs
{
    public partial class Contracts : Form
    {
        private readonly ContractRepository _repo = new();
        private int _selectedId;
        public Contracts()
        {
            InitializeComponent();
            LoadData();
            LoadLookups();
        }

        private void LoadData()
        {
            gridContracts.DataSource = null;
            gridContracts.DataSource = _repo.GetAll();
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

        private void gridContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = (Contract)gridContracts.Rows[e.RowIndex].DataBoundItem;
            _selectedId = row.Id;

            txtNumber.Text = row.Number;
            dtDate.Value = row.Date;

            cbCustomers.SelectedValue = row.CustomerId;
            cbCarriers.SelectedValue = row.CarrierId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _repo.Add(new Contract
            {
                Number = txtNumber.Text,
                Date = dtDate.Value,
                CustomerId = (int)cbCustomers.SelectedValue,
                CarrierId = (int)cbCarriers.SelectedValue
            });

            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;

            _repo.Update(new Contract
            {
                Id = _selectedId,
                Number = txtNumber.Text,
                Date = dtDate.Value,
                CustomerId = (int)cbCustomers.SelectedValue,
                CarrierId = (int)cbCarriers.SelectedValue
            });

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;

            _repo.Delete(_selectedId);
            LoadData();
        }
    }
}
