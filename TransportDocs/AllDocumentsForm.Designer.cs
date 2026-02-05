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
            txtWhom = new TextBox();
            txtAddress = new TextBox();
            label4 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)numCost).BeginInit();
            SuspendLayout();
            // 
            // dtDate
            // 
            dtDate.Location = new Point(63, 44);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(200, 23);
            dtDate.TabIndex = 0;
            dtDate.ValueChanged += dtDate_ValueChanged;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(107, 94);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 1;
            // 
            // numCost
            // 
            numCost.Location = new Point(63, 140);
            numCost.Name = "numCost";
            numCost.Size = new Size(120, 23);
            numCost.TabIndex = 2;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(97, 192);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(121, 23);
            cbCustomers.TabIndex = 3;
            // 
            // cbCarriers
            // 
            cbCarriers.FormattingEnabled = true;
            cbCarriers.Location = new Point(97, 238);
            cbCarriers.Name = "cbCarriers";
            cbCarriers.Size = new Size(121, 23);
            cbCarriers.TabIndex = 4;
            cbCarriers.SelectedIndexChanged += cbCarriers_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 195);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "Организация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 246);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 6;
            label2.Text = "Перевозчик";
            // 
            // chkPhysicalPerson
            // 
            chkPhysicalPerson.AutoSize = true;
            chkPhysicalPerson.Location = new Point(97, 285);
            chkPhysicalPerson.Name = "chkPhysicalPerson";
            chkPhysicalPerson.Size = new Size(78, 19);
            chkPhysicalPerson.TabIndex = 7;
            chkPhysicalPerson.Text = "Физ лицо";
            chkPhysicalPerson.UseVisualStyleBackColor = true;
            // 
            // cbContractors
            // 
            cbContractors.FormattingEnabled = true;
            cbContractors.Location = new Point(488, 47);
            cbContractors.Name = "cbContractors";
            cbContractors.Size = new Size(121, 23);
            cbContractors.TabIndex = 8;
            cbContractors.TextChanged += cbContractors_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 50);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 9;
            label3.Text = "Контрагент";
            // 
            // txtWhom
            // 
            txtWhom.Location = new Point(488, 94);
            txtWhom.Name = "txtWhom";
            txtWhom.Size = new Size(100, 23);
            txtWhom.TabIndex = 10;
            txtWhom.Text = "Физическое лицо";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(488, 140);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 102);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 12;
            label4.Text = "Кому";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 148);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 13;
            label5.Text = "Адрес";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 97);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 14;
            label6.Text = "Город";
            // 
            // txtActNumber
            // 
            txtActNumber.Location = new Point(488, 187);
            txtActNumber.Name = "txtActNumber";
            txtActNumber.Size = new Size(100, 23);
            txtActNumber.TabIndex = 15;
            // 
            // txtTripNumber
            // 
            txtTripNumber.Location = new Point(488, 238);
            txtTripNumber.Name = "txtTripNumber";
            txtTripNumber.Size = new Size(100, 23);
            txtTripNumber.TabIndex = 16;
            // 
            // chkActWithoutNumber
            // 
            chkActWithoutNumber.AutoSize = true;
            chkActWithoutNumber.Location = new Point(613, 189);
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
            label7.Location = new Point(404, 190);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 19;
            label7.Text = "Номер акта";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(398, 241);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 20;
            label8.Text = "Номер заявки";
            // 
            // btnCreateAll
            // 
            btnCreateAll.Location = new Point(532, 327);
            btnCreateAll.Name = "btnCreateAll";
            btnCreateAll.Size = new Size(75, 23);
            btnCreateAll.TabIndex = 21;
            btnCreateAll.Text = "Все";
            btnCreateAll.UseVisualStyleBackColor = true;
            btnCreateAll.Click += btnCreateAll_Click;
            // 
            // btnAct
            // 
            btnAct.Location = new Point(332, 327);
            btnAct.Name = "btnAct";
            btnAct.Size = new Size(90, 23);
            btnAct.TabIndex = 22;
            btnAct.Text = "Акт";
            btnAct.UseVisualStyleBackColor = true;
            btnAct.Click += btnAct_Click;
            // 
            // btnBill
            // 
            btnBill.Location = new Point(430, 327);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(95, 23);
            btnBill.TabIndex = 23;
            btnBill.Text = "Накладная";
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
            // 
            // AllDocumentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBill);
            Controls.Add(btnAct);
            Controls.Add(btnCreateAll);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(chkActWithoutNumber);
            Controls.Add(txtTripNumber);
            Controls.Add(txtActNumber);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(txtWhom);
            Controls.Add(label3);
            Controls.Add(cbContractors);
            Controls.Add(chkPhysicalPerson);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbCarriers);
            Controls.Add(cbCustomers);
            Controls.Add(numCost);
            Controls.Add(txtCity);
            Controls.Add(dtDate);
            Name = "AllDocumentsForm";
            Text = "AllDocumentsForm";
            ((System.ComponentModel.ISupportInitialize)numCost).EndInit();
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
        private TextBox txtWhom;
        private TextBox txtAddress;
        private Label label4;
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
    }
}
