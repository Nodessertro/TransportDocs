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
            grpList = new GroupBox();
            grpMain = new GroupBox();
            grpNumbers = new GroupBox();
            grpReceiver = new GroupBox();
            grpDocs = new GroupBox();
            panelButtons = new Panel();
            panelHeader = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)gridBills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCost).BeginInit();
            grpList.SuspendLayout();
            grpMain.SuspendLayout();
            grpNumbers.SuspendLayout();
            grpReceiver.SuspendLayout();
            grpDocs.SuspendLayout();
            panelButtons.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // gridBills
            // 
            gridBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBills.Location = new Point(12, 26);
            gridBills.Name = "gridBills";
            gridBills.ReadOnly = true;
            gridBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridBills.Size = new Size(916, 160);
            gridBills.TabIndex = 0;
            gridBills.CellContentClick += gridBills_CellClick;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(120, 32);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(200, 23);
            dtDate.TabIndex = 1;
            dtDate.ValueChanged += dtDate_ValueChanged;
            // 
            // cbCustomers
            // 
            cbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(120, 68);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(200, 23);
            cbCustomers.TabIndex = 2;
            // 
            // cbCarriers
            // 
            cbCarriers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCarriers.FormattingEnabled = true;
            cbCarriers.Location = new Point(120, 104);
            cbCarriers.Name = "cbCarriers";
            cbCarriers.Size = new Size(200, 23);
            cbCarriers.TabIndex = 3;
            cbCarriers.SelectedIndexChanged += cbCarriers_SelectedIndexChanged;
            // 
            // cbContractors
            // 
            cbContractors.FormattingEnabled = true;
            cbContractors.Location = new Point(120, 140);
            cbContractors.Name = "cbContractors";
            cbContractors.Size = new Size(200, 23);
            cbContractors.TabIndex = 4;
            cbContractors.SelectedIndexChanged += cbContractors_SelectedIndexChanged;
            cbContractors.SelectionChangeCommitted += cbContractors_SelectionChangeCommitted;
            cbContractors.TextChanged += cbContractors_TextChanged;
            // 
            // txtActNumber
            // 
            txtActNumber.Location = new Point(120, 32);
            txtActNumber.Name = "txtActNumber";
            txtActNumber.Size = new Size(160, 23);
            txtActNumber.TabIndex = 6;
            // 
            // txtTripNumber
            // 
            txtTripNumber.Location = new Point(120, 68);
            txtTripNumber.Name = "txtTripNumber";
            txtTripNumber.Size = new Size(160, 23);
            txtTripNumber.TabIndex = 7;
            // 
            // txtResponsible
            // 
            txtResponsible.Location = new Point(140, 70);
            txtResponsible.Name = "txtResponsible";
            txtResponsible.Size = new Size(200, 23);
            txtResponsible.TabIndex = 12;
            // 
            // txtDocs
            // 
            txtDocs.Location = new Point(140, 32);
            txtDocs.Name = "txtDocs";
            txtDocs.Size = new Size(200, 23);
            txtDocs.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(120, 32);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtWhom
            // 
            txtWhom.Location = new Point(120, 68);
            txtWhom.Name = "txtWhom";
            txtWhom.Size = new Size(300, 23);
            txtWhom.TabIndex = 9;
            // 
            // numCost
            // 
            numCost.DecimalPlaces = 2;
            numCost.Location = new Point(140, 108);
            numCost.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numCost.Name = "numCost";
            numCost.Size = new Size(200, 23);
            numCost.TabIndex = 13;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(21, 101, 192);
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.ForeColor = Color.White;
            Add.Location = new Point(10, 10);
            Add.Name = "Add";
            Add.Size = new Size(120, 28);
            Add.TabIndex = 12;
            Add.Text = "Создать";
            Add.UseVisualStyleBackColor = false;
            Add.Click += btnAdd_Click;
            // 
            // Update
            // 
            Update.BackColor = Color.FromArgb(0, 121, 107);
            Update.FlatAppearance.BorderSize = 0;
            Update.FlatStyle = FlatStyle.Flat;
            Update.ForeColor = Color.White;
            Update.Location = new Point(150, 10);
            Update.Name = "Update";
            Update.Size = new Size(120, 28);
            Update.TabIndex = 13;
            Update.Text = "Обновить";
            Update.UseVisualStyleBackColor = false;
            Update.Click += btnUpdate_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(198, 40, 40);
            Delete.FlatAppearance.BorderSize = 0;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.ForeColor = Color.White;
            Delete.Location = new Point(290, 10);
            Delete.Name = "Delete";
            Delete.Size = new Size(120, 28);
            Delete.TabIndex = 14;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 36);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 15;
            label1.Text = "Дата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 72);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 16;
            label2.Text = "Организация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 108);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 18;
            label4.Text = "Перевозчик";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 144);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 19;
            label5.Text = "Контрагент";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Location = new Point(20, 36);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(46, 15);
            lblInvoiceNumber.TabIndex = 20;
            lblInvoiceNumber.Text = "№ акта";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 72);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 21;
            label7.Text = "№ заявки";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 74);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 22;
            label8.Text = "Ответственный";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 112);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 23;
            label9.Text = "Цена";
            // 
            // lblWhom
            // 
            lblWhom.AutoSize = true;
            lblWhom.Location = new Point(20, 72);
            lblWhom.Name = "lblWhom";
            lblWhom.Size = new Size(36, 15);
            lblWhom.TabIndex = 24;
            lblWhom.Text = "Кому";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Location = new Point(20, 36);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(40, 15);
            lblAdres.TabIndex = 25;
            lblAdres.Text = "Адрес";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 36);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 26;
            label12.Text = "№ накладной";
            // 
            // chkActWithoutNumber
            // 
            chkActWithoutNumber.AutoSize = true;
            chkActWithoutNumber.Location = new Point(300, 34);
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
            chkPhysicalPerson.Location = new Point(120, 170);
            chkPhysicalPerson.Name = "chkPhysicalPerson";
            chkPhysicalPerson.Size = new Size(123, 19);
            chkPhysicalPerson.TabIndex = 5;
            chkPhysicalPerson.Text = "Физическое лицо";
            chkPhysicalPerson.UseVisualStyleBackColor = true;
            chkPhysicalPerson.CheckedChanged += chkPhysicalPerson_CheckedChanged;
            // 
            // grpList
            // 
            grpList.BackColor = Color.White;
            grpList.Controls.Add(gridBills);
            grpList.Location = new Point(20, 70);
            grpList.Name = "grpList";
            grpList.Size = new Size(940, 200);
            grpList.TabIndex = 27;
            grpList.TabStop = false;
            grpList.Text = "Список накладных";
            // 
            // grpMain
            // 
            grpMain.BackColor = Color.White;
            grpMain.Controls.Add(label1);
            grpMain.Controls.Add(dtDate);
            grpMain.Controls.Add(label2);
            grpMain.Controls.Add(cbCustomers);
            grpMain.Controls.Add(label4);
            grpMain.Controls.Add(cbCarriers);
            grpMain.Controls.Add(label5);
            grpMain.Controls.Add(cbContractors);
            grpMain.Controls.Add(chkPhysicalPerson);
            grpMain.Location = new Point(20, 280);
            grpMain.Name = "grpMain";
            grpMain.Size = new Size(450, 200);
            grpMain.TabIndex = 28;
            grpMain.TabStop = false;
            grpMain.Text = "Основные данные";
            // 
            // grpNumbers
            // 
            grpNumbers.BackColor = Color.White;
            grpNumbers.Controls.Add(lblInvoiceNumber);
            grpNumbers.Controls.Add(txtActNumber);
            grpNumbers.Controls.Add(chkActWithoutNumber);
            grpNumbers.Controls.Add(label7);
            grpNumbers.Controls.Add(txtTripNumber);
            grpNumbers.Location = new Point(500, 280);
            grpNumbers.Name = "grpNumbers";
            grpNumbers.Size = new Size(460, 120);
            grpNumbers.TabIndex = 29;
            grpNumbers.TabStop = false;
            grpNumbers.Text = "Номера";
            // 
            // grpReceiver
            // 
            grpReceiver.BackColor = Color.White;
            grpReceiver.Controls.Add(lblAdres);
            grpReceiver.Controls.Add(txtAddress);
            grpReceiver.Controls.Add(lblWhom);
            grpReceiver.Controls.Add(txtWhom);
            grpReceiver.Location = new Point(500, 410);
            grpReceiver.Name = "grpReceiver";
            grpReceiver.Size = new Size(460, 120);
            grpReceiver.TabIndex = 30;
            grpReceiver.TabStop = false;
            grpReceiver.Text = "Получатель";
            // 
            // grpDocs
            // 
            grpDocs.BackColor = Color.White;
            grpDocs.Controls.Add(label12);
            grpDocs.Controls.Add(txtDocs);
            grpDocs.Controls.Add(label8);
            grpDocs.Controls.Add(txtResponsible);
            grpDocs.Controls.Add(label9);
            grpDocs.Controls.Add(numCost);
            grpDocs.Location = new Point(20, 490);
            grpDocs.Name = "grpDocs";
            grpDocs.Size = new Size(450, 140);
            grpDocs.TabIndex = 31;
            grpDocs.TabStop = false;
            grpDocs.Text = "Документы и стоимость";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(245, 245, 245);
            panelButtons.Controls.Add(Add);
            panelButtons.Controls.Add(Update);
            panelButtons.Controls.Add(Delete);
            panelButtons.Location = new Point(500, 540);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(460, 48);
            panelButtons.TabIndex = 32;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(33, 37, 41);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(980, 52);
            panelHeader.TabIndex = 33;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Транспортные накладные";
            // 
            // TransportationBills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(980, 650);
            Controls.Add(panelButtons);
            Controls.Add(grpDocs);
            Controls.Add(grpReceiver);
            Controls.Add(grpNumbers);
            Controls.Add(grpMain);
            Controls.Add(grpList);
            Controls.Add(panelHeader);
            Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "TransportationBills";
            Text = "Транспортные накладные";
            ((System.ComponentModel.ISupportInitialize)gridBills).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCost).EndInit();
            grpList.ResumeLayout(false);
            grpMain.ResumeLayout(false);
            grpMain.PerformLayout();
            grpNumbers.ResumeLayout(false);
            grpNumbers.PerformLayout();
            grpReceiver.ResumeLayout(false);
            grpReceiver.PerformLayout();
            grpDocs.ResumeLayout(false);
            grpDocs.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox grpList;
        private GroupBox grpMain;
        private GroupBox grpNumbers;
        private GroupBox grpReceiver;
        private GroupBox grpDocs;
        private Panel panelButtons;
        private Panel panelHeader;
        private Label lblTitle;
    }
}
