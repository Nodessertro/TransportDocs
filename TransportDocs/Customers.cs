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
    public partial class Customers : Form
    {
        private readonly CustomerRepository _repo = new();
        private int _selectedId;
        public Customers()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            gridCustomers.DataSource = null;
            gridCustomers.DataSource = _repo.GetAll();

            gridCustomers.Columns["Id"].HeaderText = "ID";
            gridCustomers.Columns["Name"].HeaderText = "Название организации";
            gridCustomers.Columns["Inn"].HeaderText = "ИНН";
            gridCustomers.Columns["Kpp"].HeaderText = "КПП";
            gridCustomers.Columns["Ogrn"].HeaderText = "ОГРН";
            gridCustomers.Columns["Address"].HeaderText = "Адрес";
            gridCustomers.Columns["DirectorName"].HeaderText = "Директор";
        }

        private void gridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = (Customer)gridCustomers.Rows[e.RowIndex].DataBoundItem;
            _selectedId = row.Id;

            txtName.Text = row.Name;
            txtInn.Text = row.Inn;
            txtKpp.Text = row.Kpp;
            txtOgrn.Text = row.Ogrn;
            txtAddress.Text = row.Address;
            txtDirector.Text = row.DirectorName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _repo.Add(new Customer
            {
                Name = txtName.Text,
                Inn = txtInn.Text,
                Kpp = txtKpp.Text,
                Ogrn = txtOgrn.Text,
                Address = txtAddress.Text,
                DirectorName = txtDirector.Text
            });

            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;

            _repo.Update(new Customer
            {
                Id = _selectedId,
                Name = txtName.Text,
                Inn = txtInn.Text,
                Kpp = txtKpp.Text,
                Ogrn = txtOgrn.Text,
                Address = txtAddress.Text,
                DirectorName = txtDirector.Text
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
