namespace TransportDocs
{
    partial class Contracts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridContracts = new DataGridView();
            txtNumber = new TextBox();
            dtDate = new DateTimePicker();
            cbCustomers = new ComboBox();
            cbCarriers = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            grpList = new GroupBox();
            grpDetails = new GroupBox();
            panelButtons = new Panel();
            panelHeader = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)gridContracts).BeginInit();
            grpList.SuspendLayout();
            grpDetails.SuspendLayout();
            panelButtons.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // gridContracts
            // 
            gridContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridContracts.Location = new Point(12, 26);
            gridContracts.Name = "gridContracts";
            gridContracts.Size = new Size(752, 160);
            gridContracts.TabIndex = 0;
            gridContracts.CellClick += gridContracts_CellClick;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(120, 32);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(200, 23);
            txtNumber.TabIndex = 1;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(520, 32);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(220, 23);
            dtDate.TabIndex = 2;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(120, 72);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(200, 23);
            cbCustomers.TabIndex = 3;
            // 
            // cbCarriers
            // 
            cbCarriers.FormattingEnabled = true;
            cbCarriers.Location = new Point(520, 72);
            cbCarriers.Name = "cbCarriers";
            cbCarriers.Size = new Size(220, 23);
            cbCarriers.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(21, 101, 192);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(10, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 28);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 121, 107);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(150, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 28);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(198, 40, 40);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(290, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 28);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 36);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 8;
            label1.Text = "Номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 76);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 9;
            label2.Text = "Заказчик";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 36);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 10;
            label3.Text = "Дата";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 76);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 11;
            label4.Text = "Перевозчик";
            // 
            // grpList
            // 
            grpList.BackColor = Color.White;
            grpList.Controls.Add(gridContracts);
            grpList.Location = new Point(20, 70);
            grpList.Name = "grpList";
            grpList.Size = new Size(776, 200);
            grpList.TabIndex = 12;
            grpList.TabStop = false;
            grpList.Text = "Список договоров";
            // 
            // grpDetails
            // 
            grpDetails.BackColor = Color.White;
            grpDetails.Controls.Add(label1);
            grpDetails.Controls.Add(txtNumber);
            grpDetails.Controls.Add(label3);
            grpDetails.Controls.Add(dtDate);
            grpDetails.Controls.Add(label2);
            grpDetails.Controls.Add(cbCustomers);
            grpDetails.Controls.Add(label4);
            grpDetails.Controls.Add(cbCarriers);
            grpDetails.Location = new Point(20, 280);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(776, 120);
            grpDetails.TabIndex = 13;
            grpDetails.TabStop = false;
            grpDetails.Text = "Данные договора";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(245, 245, 245);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Location = new Point(20, 410);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(776, 48);
            panelButtons.TabIndex = 14;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(33, 37, 41);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(816, 52);
            panelHeader.TabIndex = 15;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(96, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Договоры";
            // 
            // Contracts
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(816, 480);
            Controls.Add(panelButtons);
            Controls.Add(grpDetails);
            Controls.Add(grpList);
            Controls.Add(panelHeader);
            Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Contracts";
            Text = "Договоры";
            ((System.ComponentModel.ISupportInitialize)gridContracts).EndInit();
            grpList.ResumeLayout(false);
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridContracts;
        private TextBox txtNumber;
        private DateTimePicker dtDate;
        private ComboBox cbCustomers;
        private ComboBox cbCarriers;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox grpList;
        private GroupBox grpDetails;
        private Panel panelButtons;
        private Panel panelHeader;
        private Label lblTitle;
    }
}
