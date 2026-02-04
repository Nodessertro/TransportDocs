namespace TransportDocs
{
    partial class FinishedDocuments
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
            cbCustomers = new ComboBox();
            cbCarriers = new ComboBox();
            numCost = new NumericUpDown();
            txtActNumber = new TextBox();
            chkActWithoutNumber = new CheckBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTripNumber = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numCost).BeginInit();
            SuspendLayout();
            // 
            // dtDate
            // 
            dtDate.Location = new Point(305, 196);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(200, 23);
            dtDate.TabIndex = 0;
            dtDate.ValueChanged += dtDate_ValueChanged;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(89, 109);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 1;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(89, 150);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(121, 23);
            cbCustomers.TabIndex = 2;
            // 
            // cbCarriers
            // 
            cbCarriers.FormattingEnabled = true;
            cbCarriers.Location = new Point(89, 196);
            cbCarriers.Name = "cbCarriers";
            cbCarriers.Size = new Size(121, 23);
            cbCarriers.TabIndex = 3;
            cbCarriers.SelectedIndexChanged += cbCarriers_SelectedIndexChanged;
            // 
            // numCost
            // 
            numCost.Location = new Point(89, 239);
            numCost.Name = "numCost";
            numCost.Size = new Size(120, 23);
            numCost.TabIndex = 4;
            // 
            // txtActNumber
            // 
            txtActNumber.Location = new Point(89, 292);
            txtActNumber.Name = "txtActNumber";
            txtActNumber.Size = new Size(100, 23);
            txtActNumber.TabIndex = 5;
            // 
            // chkActWithoutNumber
            // 
            chkActWithoutNumber.AutoSize = true;
            chkActWithoutNumber.Location = new Point(222, 294);
            chkActWithoutNumber.Name = "chkActWithoutNumber";
            chkActWithoutNumber.Size = new Size(111, 19);
            chkActWithoutNumber.TabIndex = 16;
            chkActWithoutNumber.Text = "Акт без номера";
            chkActWithoutNumber.UseVisualStyleBackColor = true;
            chkActWithoutNumber.CheckedChanged += chkActWithoutNumber_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(89, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Создать";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 112);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 8;
            label1.Text = "Город";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 153);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 9;
            label2.Text = "Клиент";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 202);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 10;
            label3.Text = "Перевозчик";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 241);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 11;
            label4.Text = "Стоимость";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 298);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 12;
            label5.Text = "Номер акта";
            // 
            // txtTripNumber
            // 
            txtTripNumber.Location = new Point(89, 332);
            txtTripNumber.Name = "txtTripNumber";
            txtTripNumber.Size = new Size(100, 23);
            txtTripNumber.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-1, 335);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 14;
            label6.Text = "Номер заявки";
            // 
            // FinishedDocuments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtTripNumber);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(chkActWithoutNumber);
            Controls.Add(txtActNumber);
            Controls.Add(numCost);
            Controls.Add(cbCarriers);
            Controls.Add(cbCustomers);
            Controls.Add(txtCity);
            Controls.Add(dtDate);
            Name = "FinishedDocuments";
            Text = "FinishedDocument";
            ((System.ComponentModel.ISupportInitialize)numCost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtDate;
        private TextBox txtCity;
        private ComboBox cbCustomers;
        private ComboBox cbCarriers;
        private NumericUpDown numCost;
        private TextBox txtActNumber;
        private CheckBox chkActWithoutNumber;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTripNumber;
        private Label label6;
    }
}