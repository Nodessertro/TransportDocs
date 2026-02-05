namespace TransportDocs
{
    partial class Carriers
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
            gridCarriers = new DataGridView();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtOgrn = new TextBox();
            label3 = new Label();
            txtInn = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtCarNumber = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtCarModel = new TextBox();
            txtPhone = new TextBox();
            txtTonnage = new TextBox();
            grpList = new GroupBox();
            grpDetails = new GroupBox();
            panelButtons = new Panel();
            panelHeader = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)gridCarriers).BeginInit();
            grpList.SuspendLayout();
            grpDetails.SuspendLayout();
            panelButtons.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // gridCarriers
            // 
            gridCarriers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCarriers.Location = new Point(12, 26);
            gridCarriers.Name = "gridCarriers";
            gridCarriers.Size = new Size(952, 160);
            gridCarriers.TabIndex = 0;
            gridCarriers.CellClick += gridCarriers_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 72);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "ОГРН";
            // 
            // txtOgrn
            // 
            txtOgrn.Location = new Point(150, 68);
            txtOgrn.Name = "txtOgrn";
            txtOgrn.Size = new Size(280, 23);
            txtOgrn.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 108);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "ИНН";
            // 
            // txtInn
            // 
            txtInn.Location = new Point(150, 104);
            txtInn.Name = "txtInn";
            txtInn.Size = new Size(280, 23);
            txtInn.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 144);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 8;
            label4.Text = "Адрес";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 140);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(280, 23);
            txtAddress.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 36);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 10;
            label5.Text = "Номер авто";
            // 
            // txtCarNumber
            // 
            txtCarNumber.Location = new Point(590, 32);
            txtCarNumber.Name = "txtCarNumber";
            txtCarNumber.Size = new Size(280, 23);
            txtCarNumber.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(470, 72);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 12;
            label6.Text = "Модель авто";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(470, 108);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 14;
            label7.Text = "Телефон";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(470, 144);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 16;
            label8.Text = "Тонаж";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(21, 101, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 10);
            button1.Name = "button1";
            button1.Size = new Size(120, 28);
            button1.TabIndex = 13;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 121, 107);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(150, 10);
            button2.Name = "button2";
            button2.Size = new Size(120, 28);
            button2.TabIndex = 14;
            button2.Text = "Обновить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnUpdate_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(198, 40, 40);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(290, 10);
            button3.Name = "button3";
            button3.Size = new Size(120, 28);
            button3.TabIndex = 15;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnDelete_Click;
            // 
            // txtCarModel
            // 
            txtCarModel.Location = new Point(590, 68);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(280, 23);
            txtCarModel.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(590, 104);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(280, 23);
            txtPhone.TabIndex = 11;
            // 
            // txtTonnage
            // 
            txtTonnage.Location = new Point(590, 140);
            txtTonnage.Name = "txtTonnage";
            txtTonnage.Size = new Size(280, 23);
            txtTonnage.TabIndex = 12;
            // 
            // grpList
            // 
            grpList.BackColor = Color.White;
            grpList.Controls.Add(gridCarriers);
            grpList.Location = new Point(20, 70);
            grpList.Name = "grpList";
            grpList.Size = new Size(980, 200);
            grpList.TabIndex = 21;
            grpList.TabStop = false;
            grpList.Text = "Список перевозчиков";
            // 
            // grpDetails
            // 
            grpDetails.BackColor = Color.White;
            grpDetails.Controls.Add(label1);
            grpDetails.Controls.Add(txtName);
            grpDetails.Controls.Add(label2);
            grpDetails.Controls.Add(txtOgrn);
            grpDetails.Controls.Add(label3);
            grpDetails.Controls.Add(txtInn);
            grpDetails.Controls.Add(label4);
            grpDetails.Controls.Add(txtAddress);
            grpDetails.Controls.Add(label5);
            grpDetails.Controls.Add(txtCarNumber);
            grpDetails.Controls.Add(label6);
            grpDetails.Controls.Add(txtCarModel);
            grpDetails.Controls.Add(label7);
            grpDetails.Controls.Add(txtPhone);
            grpDetails.Controls.Add(label8);
            grpDetails.Controls.Add(txtTonnage);
            grpDetails.Location = new Point(20, 280);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(980, 190);
            grpDetails.TabIndex = 22;
            grpDetails.TabStop = false;
            grpDetails.Text = "Данные перевозчика";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(245, 245, 245);
            panelButtons.Controls.Add(button1);
            panelButtons.Controls.Add(button2);
            panelButtons.Controls.Add(button3);
            panelButtons.Location = new Point(20, 485);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(980, 48);
            panelButtons.TabIndex = 23;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(33, 37, 41);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1020, 52);
            panelHeader.TabIndex = 24;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(139, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Перевозчики";
            // 
            // Carriers
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1020, 550);
            Controls.Add(panelButtons);
            Controls.Add(grpDetails);
            Controls.Add(grpList);
            Controls.Add(panelHeader);
            Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Carriers";
            Text = "Перевозчики";
            ((System.ComponentModel.ISupportInitialize)gridCarriers).EndInit();
            grpList.ResumeLayout(false);
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCarriers;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtOgrn;
        private Label label3;
        private TextBox txtInn;
        private Label label4;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtCarNumber;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtCarModel;
        private TextBox txtPhone;
        private TextBox txtTonnage;
        private GroupBox grpList;
        private GroupBox grpDetails;
        private Panel panelButtons;
        private Panel panelHeader;
        private Label lblTitle;
    }
}
