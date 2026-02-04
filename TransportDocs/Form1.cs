using TransportDocs.Repositories;
namespace TransportDocs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var repo = new CustomerRepository();
            dataGridViewCustomers.DataSource = repo.GetAll();

            this.Load += Form1_Load;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customers customersForm = new Customers();
            customersForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Carriers carriersForm = new Carriers();
            carriersForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contracts contractsForm = new Contracts();
            contractsForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TransportationBills billsForm = new TransportationBills();
            billsForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Contractors contractorsForm = new Contractors();
            contractorsForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FinishedDocuments finishedDocumentsForm = new FinishedDocuments();
            finishedDocumentsForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AllDocumentsForm allDocumentsForm = new AllDocumentsForm(); 
            allDocumentsForm.ShowDialog();
        }
    }
}
