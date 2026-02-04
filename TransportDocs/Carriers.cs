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
    public partial class Carriers : Form
    {
        private readonly CarrierRepository _repo = new();
        private int _selectedId;
        public Carriers()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            gridCarriers.DataSource = null;
            gridCarriers.DataSource = _repo.GetAll();

            gridCarriers.Columns["Id"].HeaderText = "ID";
            gridCarriers.Columns["Name"].HeaderText = "Имя";
            gridCarriers.Columns["Ogrn"].HeaderText = "ОГРН";
            gridCarriers.Columns["Inn"].HeaderText = "ИНН";
            gridCarriers.Columns["Address"].HeaderText = "Адрес";
            gridCarriers.Columns["CarNumber"].HeaderText = "Номер авто";
            gridCarriers.Columns["CarModel"].HeaderText = "Модель авто";
            gridCarriers.Columns["Phone"].HeaderText = "Телефон";
            gridCarriers.Columns["Tonnage"].HeaderText = "Тонаж";
        }


        private void Carriers_Load(object sender, EventArgs e)
        {
            var repo = new Repositories.CarrierRepository();
            gridCarriers.DataSource = repo.GetAll();

        }

        private void gridCarriers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = (Carrier)gridCarriers.Rows[e.RowIndex].DataBoundItem;
            _selectedId = row.Id;

            txtName.Text = row.Name;
            txtOgrn.Text = row.Ogrn;
            txtInn.Text = row.Inn;
            txtAddress.Text = row.Address;
            txtCarNumber.Text = row.CarNumber;
            txtCarModel.Text = row.CarModel;
            txtPhone.Text = row.Phone;
            txtTonnage.Text = row.Tonnage;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _repo.Add(new Carrier
            {
                Name = txtName.Text,
                Ogrn = txtOgrn.Text,
                Inn = txtInn.Text,
                Address = txtAddress.Text,
                CarNumber = txtCarNumber.Text,
                CarModel = label6.Text,
                Phone = label7.Text,
                Tonnage = label8.Text
            });
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;

            _repo.Update(new Carrier
            {
                Id = _selectedId,
                Name = txtName.Text,
                Ogrn = txtOgrn.Text,
                Inn = txtInn.Text,
                Address = txtAddress.Text,
                CarNumber = txtCarNumber.Text,
                CarModel = txtCarModel.Text,
                Phone = txtPhone.Text,
                Tonnage = txtTonnage.Text
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
