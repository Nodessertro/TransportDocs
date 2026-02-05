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
            label7 = new Label();
            grpDetails = new GroupBox();
            grpNumbers = new GroupBox();
            panelButtons = new Panel();
            panelHeader = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)numCost).BeginInit();
            grpDetails.SuspendLayout();
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
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(120, 104);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(220, 23);
            cbCustomers.TabIndex = 2;
            // 
            // cbCarriers
            // 
            cbCarriers.FormattingEnabled = true;
            cbCarriers.Location = new Point(120, 140);
            cbCarriers.Name = "cbCarriers";
            cbCarriers.Size = new Size(220, 23);
            cbCarriers.TabIndex = 3;
            cbCarriers.SelectedIndexChanged += cbCarriers_SelectedIndexChanged;
            // 
            // numCost
            // 
            numCost.Location = new Point(120, 176);
            numCost.Name = "numCost";
            numCost.Size = new Size(220, 23);
            numCost.TabIndex = 4;
            // 
            // txtActNumber
            // 
            txtActNumber.Location = new Point(120, 32);
            txtActNumber.Name = "txtActNumber";
            txtActNumber.Size = new Size(160, 23);
            txtActNumber.TabIndex = 5;
            // 
            // chkActWithoutNumber
            // 
            chkActWithoutNumber.AutoSize = true;
            chkActWithoutNumber.Location = new Point(300, 34);
            chkActWithoutNumber.Name = "chkActWithoutNumber";
            chkActWithoutNumber.Size = new Size(111, 19);
            chkActWithoutNumber.TabIndex = 16;
            chkActWithoutNumber.Text = "Акт без номера";
            chkActWithoutNumber.UseVisualStyleBackColor = true;
            chkActWithoutNumber.CheckedChanged += chkActWithoutNumber_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(21, 101, 192);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(10, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 28);
            btnSave.TabIndex = 7;
            btnSave.Text = "Создать";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 36);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 8;
            label1.Text = "Дата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 72);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Город";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 108);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 10;
            label3.Text = "Заказчик";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 144);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 11;
            label4.Text = "Перевозчик";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 180);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 12;
            label5.Text = "Стоимость";
            // 
            // txtTripNumber
            // 
            txtTripNumber.Location = new Point(120, 72);
            txtTripNumber.Name = "txtTripNumber";
            txtTripNumber.Size = new Size(160, 23);
            txtTripNumber.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 76);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 14;
            label6.Text = "Номер заявки";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 36);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 15;
            label7.Text = "Номер акта";
            // 
            // grpDetails
            // 
            grpDetails.BackColor = Color.White;
            grpDetails.Controls.Add(label1);
            grpDetails.Controls.Add(dtDate);
            grpDetails.Controls.Add(label2);
            grpDetails.Controls.Add(txtCity);
            grpDetails.Controls.Add(label3);
            grpDetails.Controls.Add(cbCustomers);
            grpDetails.Controls.Add(label4);
            grpDetails.Controls.Add(cbCarriers);
            grpDetails.Controls.Add(label5);
            grpDetails.Controls.Add(numCost);
            grpDetails.Location = new Point(20, 70);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(440, 230);
            grpDetails.TabIndex = 17;
            grpDetails.TabStop = false;
            grpDetails.Text = "Данные";
            // 
            // grpNumbers
            // 
            grpNumbers.BackColor = Color.White;
            grpNumbers.Controls.Add(label7);
            grpNumbers.Controls.Add(label6);
            grpNumbers.Controls.Add(txtActNumber);
            grpNumbers.Controls.Add(txtTripNumber);
            grpNumbers.Controls.Add(chkActWithoutNumber);
            grpNumbers.Location = new Point(480, 70);
            grpNumbers.Name = "grpNumbers";
            grpNumbers.Size = new Size(440, 120);
            grpNumbers.TabIndex = 18;
            grpNumbers.TabStop = false;
            grpNumbers.Text = "Номера";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(245, 245, 245);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Location = new Point(20, 320);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(900, 48);
            panelButtons.TabIndex = 19;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(33, 37, 41);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(950, 52);
            panelHeader.TabIndex = 20;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Готовые документы";
            // 
            // FinishedDocuments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(950, 390);
            Controls.Add(panelButtons);
            Controls.Add(grpNumbers);
            Controls.Add(grpDetails);
            Controls.Add(panelHeader);
            Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FinishedDocuments";
            Text = "Готовые документы";
            ((System.ComponentModel.ISupportInitialize)numCost).EndInit();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            grpNumbers.ResumeLayout(false);
            grpNumbers.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
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
        private Label label7;
        private GroupBox grpDetails;
        private GroupBox grpNumbers;
        private Panel panelButtons;
        private Panel panelHeader;
        private Label lblTitle;
    }
}
