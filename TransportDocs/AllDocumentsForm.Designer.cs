namespace TransportDocs
{
    partial class AllDocumentsForm
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
            dtDate = new DateTimePicker();
            txtCity = new TextBox();
            numCost = new NumericUpDown();
            cbCustomers = new ComboBox();
            cbCarriers = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            chkPhysicalPerson = new CheckBox();
            cbContractors = new ComboBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtActNumber = new TextBox();
            txtTripNumber = new TextBox();
            chkActWithoutNumber = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            btnCreateAll = new Button();
            btnAct = new Button();
            btnBill = new Button();
            grpTrip = new GroupBox();
            label9 = new Label();
            label10 = new Label();
            grpParties = new GroupBox();
            grpRecipient = new GroupBox();
            grpNumbers = new GroupBox();
            panelButtons = new Panel();
            panelHeader = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)numCost).BeginInit();
            grpTrip.SuspendLayout();
            grpParties.SuspendLayout();
            grpRecipient.SuspendLayout();
            grpNumbers.SuspendLayout();
            panelButtons.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dtDate
            // 
            dtDate.Location = new Point(120, 32);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(220, 23);
            dtDate.TabIndex = 0;
            dtDate.ValueChanged += dtDate_ValueChanged;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(120, 68);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(220, 23);
            txtCity.TabIndex = 1;
            // 
            // numCost
            // 
            numCost.Location = new Point(120, 104);
            numCost.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numCost.Name = "numCost";
            numCost.Size = new Size(220, 23);
            numCost.TabIndex = 2;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(120, 32);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(260, 23);
            cbCustomers.TabIndex = 3;
            // 
            // cbCarriers
            // 
            cbCarriers.FormattingEnabled = true;
            cbCarriers.Location = new Point(120, 72);
            cbCarriers.Name = "cbCarriers";
            cbCarriers.Size = new Size(260, 23);
            cbCarriers.TabIndex = 4;
            cbCarriers.SelectedIndexChanged += cbCarriers_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 36);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "Организация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 76);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 6;
            label2.Text = "Перевозчик";
            // 
            // chkPhysicalPerson
            // 
            chkPhysicalPerson.AutoSize = true;
            chkPhysicalPerson.Checked = true;
            chkPhysicalPerson.CheckState = CheckState.Checked;
            chkPhysicalPerson.Location = new Point(120, 68);
            chkPhysicalPerson.Name = "chkPhysicalPerson";
            chkPhysicalPerson.Size = new Size(78, 19);
            chkPhysicalPerson.TabIndex = 7;
            chkPhysicalPerson.Text = "Физ лицо";
            chkPhysicalPerson.UseVisualStyleBackColor = true;
            chkPhysicalPerson.CheckedChanged += chkPhysicalPerson_CheckedChanged;
            // 
            // cbContractors
            // 
            cbContractors.FormattingEnabled = true;
            cbContractors.Location = new Point(120, 32);
            cbContractors.Name = "cbContractors";
            cbContractors.Size = new Size(300, 23);
            cbContractors.TabIndex = 8;
            cbContractors.TextChanged += cbContractors_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 36);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 9;
            label3.Text = "Контрагент";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(120, 96);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 23);
            txtAddress.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 100);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 13;
            label5.Text = "Адрес";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 72);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 14;
            label6.Text = "Город";
            // 
            // txtActNumber
            // 
            txtActNumber.Location = new Point(140, 32);
            txtActNumber.Name = "txtActNumber";
            txtActNumber.Size = new Size(140, 23);
            txtActNumber.TabIndex = 15;
            // 
            // txtTripNumber
            // 
            txtTripNumber.Location = new Point(140, 72);
            txtTripNumber.Name = "txtTripNumber";
            txtTripNumber.Size = new Size(140, 23);
            txtTripNumber.TabIndex = 16;
            // 
            // chkActWithoutNumber
            // 
            chkActWithoutNumber.AutoSize = true;
            chkActWithoutNumber.Location = new Point(300, 34);
            chkActWithoutNumber.Name = "chkActWithoutNumber";
            chkActWithoutNumber.Size = new Size(89, 19);
            chkActWithoutNumber.TabIndex = 18;
            chkActWithoutNumber.Text = "Без номера";
            chkActWithoutNumber.UseVisualStyleBackColor = true;
            chkActWithoutNumber.CheckedChanged += chkPhysicalPerson_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 36);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 19;
            label7.Text = "Номер акта";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 76);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 20;
            label8.Text = "Номер заявки";
            // 
            // btnCreateAll
            // 
            btnCreateAll.BackColor = Color.FromArgb(46, 125, 50);
            btnCreateAll.FlatAppearance.BorderSize = 0;
            btnCreateAll.FlatStyle = FlatStyle.Flat;
            btnCreateAll.ForeColor = Color.White;
            btnCreateAll.Location = new Point(250, 10);
            btnCreateAll.Name = "btnCreateAll";
            btnCreateAll.Size = new Size(90, 28);
            btnCreateAll.TabIndex = 21;
            btnCreateAll.Text = "Все";
            btnCreateAll.UseVisualStyleBackColor = false;
            btnCreateAll.Click += btnCreateAll_Click;
            // 
            // btnAct
            // 
            btnAct.BackColor = Color.FromArgb(21, 101, 192);
            btnAct.FlatAppearance.BorderSize = 0;
            btnAct.FlatStyle = FlatStyle.Flat;
            btnAct.ForeColor = Color.White;
            btnAct.Location = new Point(10, 10);
            btnAct.Name = "btnAct";
            btnAct.Size = new Size(90, 28);
            btnAct.TabIndex = 22;
            btnAct.Text = "Акт";
            btnAct.UseVisualStyleBackColor = false;
            btnAct.Click += btnAct_Click;
            // 
            // btnBill
            // 
            btnBill.BackColor = Color.FromArgb(0, 121, 107);
            btnBill.FlatAppearance.BorderSize = 0;
            btnBill.FlatStyle = FlatStyle.Flat;
            btnBill.ForeColor = Color.White;
            btnBill.Location = new Point(120, 10);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(120, 28);
            btnBill.TabIndex = 23;
            btnBill.Text = "Накладная";
            btnBill.UseVisualStyleBackColor = false;
            btnBill.Click += btnBill_Click;
            // 
            // grpTrip
            // 
            grpTrip.BackColor = Color.White;
            grpTrip.Controls.Add(label9);
            grpTrip.Controls.Add(label10);
            grpTrip.Controls.Add(dtDate);
            grpTrip.Controls.Add(txtCity);
            grpTrip.Controls.Add(numCost);
            grpTrip.Controls.Add(label6);
            grpTrip.Location = new Point(20, 70);
            grpTrip.Name = "grpTrip";
            grpTrip.Size = new Size(420, 140);
            grpTrip.TabIndex = 24;
            grpTrip.TabStop = false;
            grpTrip.Text = "Маршрут и стоимость";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 36);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 25;
            label9.Text = "Дата";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 108);
            label10.Name = "label10";
            label10.Size = new Size(100, 15);
            label10.TabIndex = 26;
            label10.Text = "Стоимость (руб.)";
            // 
            // grpParties
            // 
            grpParties.BackColor = Color.White;
            grpParties.Controls.Add(label1);
            grpParties.Controls.Add(label2);
            grpParties.Controls.Add(cbCustomers);
            grpParties.Controls.Add(cbCarriers);
            grpParties.Location = new Point(20, 220);
            grpParties.Name = "grpParties";
            grpParties.Size = new Size(420, 160);
            grpParties.TabIndex = 25;
            grpParties.TabStop = false;
            grpParties.Text = "Стороны";
            // 
            // grpRecipient
            // 
            grpRecipient.BackColor = Color.White;
            grpRecipient.Controls.Add(label3);
            grpRecipient.Controls.Add(cbContractors);
            grpRecipient.Controls.Add(chkPhysicalPerson);
            grpRecipient.Controls.Add(label5);
            grpRecipient.Controls.Add(txtAddress);
            grpRecipient.Location = new Point(460, 70);
            grpRecipient.Name = "grpRecipient";
            grpRecipient.Size = new Size(440, 130);
            grpRecipient.TabIndex = 26;
            grpRecipient.TabStop = false;
            grpRecipient.Text = "Получатель";
            // 
            // grpNumbers
            // 
            grpNumbers.BackColor = Color.White;
            grpNumbers.Controls.Add(label7);
            grpNumbers.Controls.Add(txtActNumber);
            grpNumbers.Controls.Add(chkActWithoutNumber);
            grpNumbers.Controls.Add(label8);
            grpNumbers.Controls.Add(txtTripNumber);
            grpNumbers.Location = new Point(460, 210);
            grpNumbers.Name = "grpNumbers";
            grpNumbers.Size = new Size(440, 110);
            grpNumbers.TabIndex = 27;
            grpNumbers.TabStop = false;
            grpNumbers.Text = "Номера";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(245, 245, 245);
            panelButtons.Controls.Add(btnAct);
            panelButtons.Controls.Add(btnBill);
            panelButtons.Controls.Add(btnCreateAll);
            panelButtons.Location = new Point(560, 390);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(350, 48);
            panelButtons.TabIndex = 28;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(33, 37, 41);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(950, 52);
            panelHeader.TabIndex = 29;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(214, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Создание документов";
            // 
            // AllDocumentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(950, 460);
            Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Controls.Add(panelHeader);
            Controls.Add(panelButtons);
            Controls.Add(grpNumbers);
            Controls.Add(grpRecipient);
            Controls.Add(grpParties);
            Controls.Add(grpTrip);
            Name = "AllDocumentsForm";
            Text = "Документы";
            ((System.ComponentModel.ISupportInitialize)numCost).EndInit();
            grpTrip.ResumeLayout(false);
            grpTrip.PerformLayout();
            grpParties.ResumeLayout(false);
            grpParties.PerformLayout();
            grpRecipient.ResumeLayout(false);
            grpRecipient.PerformLayout();
            grpNumbers.ResumeLayout(false);
            grpNumbers.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtDate;
        private TextBox txtCity;
        private NumericUpDown numCost;
        private ComboBox cbCustomers;
        private ComboBox cbCarriers;
        private Label label1;
        private Label label2;
        private CheckBox chkPhysicalPerson;
        private ComboBox cbContractors;
        private Label label3;
        private TextBox txtAddress;
        private Label label5;
        private Label label6;
        private TextBox txtActNumber;
        private TextBox txtTripNumber;
        private CheckBox chkActWithoutNumber;
        private Label label7;
        private Label label8;
        private Button btnCreateAll;
        private Button btnAct;
        private Button btnBill;
        private GroupBox grpTrip;
        private Label label9;
        private Label label10;
        private GroupBox grpParties;
        private GroupBox grpRecipient;
        private GroupBox grpNumbers;
        private Panel panelButtons;
        private Panel panelHeader;
        private Label lblTitle;
    }
}
