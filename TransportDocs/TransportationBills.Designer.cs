namespace TransportDocs
{
    partial class TransportationBills
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
            gridBills = new DataGridView();
            dtDate = new DateTimePicker();
            cbCustomers = new ComboBox();
            cbCarriers = new ComboBox();
            cbContractors = new ComboBox();
            txtActNumber = new TextBox();
            txtTripNumber = new TextBox();
            txtResponsible = new TextBox();
            txtDocs = new TextBox();
            txtAddress = new TextBox();
            txtWhom = new TextBox();
            numCost = new NumericUpDown();
            Add = new Button();
            Update = new Button();
            Delete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblInvoiceNumber = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblWhom = new Label();
            lblAdres = new Label();
            label12 = new Label();
            chkActWithoutNumber = new CheckBox();
            chkPhysicalPerson = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)gridBills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCost).BeginInit();
            SuspendLayout();
            // 
            // gridBills
            // 
            gridBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBills.Location = new Point(12, 61);
            gridBills.Name = "gridBills";
            gridBills.ReadOnly = true;
            gridBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridBills.Size = new Size(883, 150);
            gridBills.TabIndex = 0;
            gridBills.CellContentClick += gridBills_CellClick;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(100, 248);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(200, 23);
            dtDate.TabIndex = 1;
            dtDate.ValueChanged += dtDate_ValueChanged;
            // 
            // cbCustomers
            // 
            cbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(100, 287);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(200, 23);
            cbCustomers.TabIndex = 2;
            // 
            // cbCarriers
            // 
            cbCarriers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCarriers.FormattingEnabled = true;
            cbCarriers.Location = new Point(100, 328);
            cbCarriers.Name = "cbCarriers";
            cbCarriers.Size = new Size(200, 23);
            cbCarriers.TabIndex = 3;
            cbCarriers.SelectedIndexChanged += cbCarriers_SelectedIndexChanged;
            // 
            // cbContractors
            // 
            cbContractors.FormattingEnabled = true;
            cbContractors.Location = new Point(100, 372);
            cbContractors.Name = "cbContractors";
            cbContractors.Size = new Size(200, 23);
            cbContractors.TabIndex = 4;
            cbContractors.SelectedIndexChanged += cbContractors_SelectedIndexChanged;
            cbContractors.SelectionChangeCommitted += cbContractors_SelectionChangeCommitted;
            cbContractors.TextChanged += cbContractors_TextChanged;
            // 
            // txtActNumber
            // 
            txtActNumber.Location = new Point(450, 248);
            txtActNumber.Name = "txtActNumber";
            txtActNumber.Size = new Size(171, 23);
            txtActNumber.TabIndex = 6;
            // 
            // txtTripNumber
            // 
            txtTripNumber.Location = new Point(450, 290);
            txtTripNumber.Name = "txtTripNumber";
            txtTripNumber.Size = new Size(171, 23);
            txtTripNumber.TabIndex = 7;
            // 
            // txtResponsible
            // 
            txtResponsible.Location = new Point(724, 328);
            txtResponsible.Name = "txtResponsible";
            txtResponsible.Size = new Size(171, 23);
            txtResponsible.TabIndex = 12;
            // 
            // txtDocs
            // 
            txtDocs.Location = new Point(724, 294);
            txtDocs.Name = "txtDocs";
            txtDocs.Size = new Size(171, 23);
            txtDocs.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(450, 326);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(171, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtWhom
            // 
            txtWhom.Location = new Point(450, 372);
            txtWhom.Name = "txtWhom";
            txtWhom.Size = new Size(171, 23);
            txtWhom.TabIndex = 9;
            // 
            // numCost
            // 
            numCost.DecimalPlaces = 2;
            numCost.Location = new Point(724, 372);
            numCost.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numCost.Name = "numCost";
            numCost.Size = new Size(171, 23);
            numCost.TabIndex = 13;
            // 
            // Add
            // 
            Add.Location = new Point(147, 456);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 12;
            Add.Text = "Создать";
            Add.UseVisualStyleBackColor = true;
            Add.Click += btnAdd_Click;
            // 
            // Update
            // 
            Update.Location = new Point(498, 456);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 13;
            Update.Text = "Обновить";
            Update.UseVisualStyleBackColor = true;
            Update.Click += btnUpdate_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(738, 456);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 14;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 254);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 15;
            label1.Text = "Дата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 290);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 16;
            label2.Text = "Организация";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(324, 9);
            label3.Name = "label3";
            label3.Size = new Size(297, 26);
            label3.TabIndex = 17;
            label3.Text = "Транспортные накладные";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 334);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 18;
            label4.Text = "Перевозчик";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 375);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 19;
            label5.Text = "Контрагент";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Location = new Point(398, 254);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(46, 15);
            lblInvoiceNumber.TabIndex = 20;
            lblInvoiceNumber.Text = "№ акта";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(385, 298);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 21;
            label7.Text = "№ заявки";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(627, 333);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 22;
            label8.Text = "Ответственный";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(683, 377);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 23;
            label9.Text = "Цена";
            // 
            // lblWhom
            // 
            lblWhom.AutoSize = true;
            lblWhom.Location = new Point(408, 377);
            lblWhom.Name = "lblWhom";
            lblWhom.Size = new Size(36, 15);
            lblWhom.TabIndex = 24;
            lblWhom.Text = "Кому";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Location = new Point(404, 334);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(40, 15);
            lblAdres.TabIndex = 25;
            lblAdres.Text = "Адрес";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(636, 300);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 26;
            label12.Text = "№ накладной";
            // 
            // chkActWithoutNumber
            // 
            chkActWithoutNumber.AutoSize = true;
            chkActWithoutNumber.Location = new Point(724, 248);
            chkActWithoutNumber.Name = "chkActWithoutNumber";
            chkActWithoutNumber.Size = new Size(111, 19);
            chkActWithoutNumber.TabIndex = 10;
            chkActWithoutNumber.Text = "Акт без номера";
            chkActWithoutNumber.UseVisualStyleBackColor = true;
            chkActWithoutNumber.CheckedChanged += chkWithoutNumber_CheckedChanged;
            // 
            // chkPhysicalPerson
            // 
            chkPhysicalPerson.AutoSize = true;
            chkPhysicalPerson.Location = new Point(100, 413);
            chkPhysicalPerson.Name = "chkPhysicalPerson";
            chkPhysicalPerson.Size = new Size(123, 19);
            chkPhysicalPerson.TabIndex = 5;
            chkPhysicalPerson.Text = "Физическое лицо";
            chkPhysicalPerson.UseVisualStyleBackColor = true;
            chkPhysicalPerson.CheckedChanged += chkPhysicalPerson_CheckedChanged;
            // 
            // TransportationBills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 512);
            Controls.Add(chkPhysicalPerson);
            Controls.Add(chkActWithoutNumber);
            Controls.Add(label12);
            Controls.Add(lblAdres);
            Controls.Add(lblWhom);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblInvoiceNumber);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Add);
            Controls.Add(numCost);
            Controls.Add(txtWhom);
            Controls.Add(txtAddress);
            Controls.Add(txtDocs);
            Controls.Add(txtResponsible);
            Controls.Add(txtTripNumber);
            Controls.Add(txtActNumber);
            Controls.Add(cbContractors);
            Controls.Add(cbCarriers);
            Controls.Add(cbCustomers);
            Controls.Add(dtDate);
            Controls.Add(gridBills);
            Name = "TransportationBills";
            Text = "Транспортные накладые";
            ((System.ComponentModel.ISupportInitialize)gridBills).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridBills;
        private DateTimePicker dtDate;
        private ComboBox cbCustomers;
        private ComboBox cbCarriers;
        private ComboBox cbContractors;
        private TextBox txtActNumber;
        private TextBox txtTripNumber;
        private TextBox txtResponsible;
        private TextBox txtDocs;
        private TextBox txtAddress;
        private TextBox txtWhom;
        private NumericUpDown numCost;
        private Button Add;
        private Button Update;
        private Button Delete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblInvoiceNumber;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblWhom;
        private Label lblAdres;
        private Label label12;
        private CheckBox chkActWithoutNumber;
        private CheckBox chkPhysicalPerson;
    }
}