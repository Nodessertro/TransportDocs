using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TransportDocs.Models;
using TransportDocs.Repositories;

namespace TransportDocs
{
    public partial class Contractors : Form
    {
        private readonly ContractorRepository _repo = new();
        private int _selectedId;
        public Contractors()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            gridContractors.DataSource = null;
            gridContractors.DataSource = _repo.GetAll();

            gridContractors.Columns["Id"].HeaderText = "ID";
            gridContractors.Columns["Name"].HeaderText = "Имя";
            gridContractors.Columns["Inn"].HeaderText = "ИНН";
            gridContractors.Columns["Type"].HeaderText = "Тип";
            gridContractors.Columns["Address"].HeaderText = "Адрес";
        }

        private void gridContractors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = (Contractor)gridContractors.Rows[e.RowIndex].DataBoundItem;
            _selectedId = row.Id;

            txtName.Text = row.Name;
            txtInn.Text = row.Inn;
            txtType.Text = row.Type;
            txtAddress.Text = row.Address;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _repo.Add(new Contractor
            {
                Name = txtName.Text,
                Inn = txtInn.Text,
                Type = txtType.Text,
                Address = txtAddress.Text,
            });
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;

            _repo.Update(new Contractor
            {
                Id = _selectedId,
                Name = txtName.Text,
                Inn = txtInn.Text,
                Type = txtType.Text,
                Address = txtAddress.Text,
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
