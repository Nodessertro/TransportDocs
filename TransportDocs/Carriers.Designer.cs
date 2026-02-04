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
            label9 = new Label();
            txtCarModel = new TextBox();
            txtPhone = new TextBox();
            txtTonnage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridCarriers).BeginInit();
            SuspendLayout();
            // 
            // gridCarriers
            // 
            gridCarriers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCarriers.Location = new Point(12, 68);
            gridCarriers.Name = "gridCarriers";
            gridCarriers.Size = new Size(966, 170);
            gridCarriers.TabIndex = 0;
            gridCarriers.CellClick += gridCarriers_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 272);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 25);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 275);
            label1.Name = "label1";
            label1.Size = new Size(34, 17);
            label1.TabIndex = 2;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 318);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 4;
            label2.Text = "ОГРН";
            // 
            // txtOgrn
            // 
            txtOgrn.Location = new Point(218, 315);
            txtOgrn.Name = "txtOgrn";
            txtOgrn.Size = new Size(270, 25);
            txtOgrn.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 364);
            label3.Name = "label3";
            label3.Size = new Size(36, 17);
            label3.TabIndex = 6;
            label3.Text = "ИНН";
            // 
            // txtInn
            // 
            txtInn.Location = new Point(218, 361);
            txtInn.Name = "txtInn";
            txtInn.Size = new Size(270, 25);
            txtInn.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 406);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 8;
            label4.Text = "Адрес";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(218, 403);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(270, 25);
            txtAddress.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(546, 275);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 10;
            label5.Text = "Номер авто";
            // 
            // txtCarNumber
            // 
            txtCarNumber.Location = new Point(664, 272);
            txtCarNumber.Name = "txtCarNumber";
            txtCarNumber.Size = new Size(270, 25);
            txtCarNumber.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(546, 321);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 12;
            label6.Text = "Модель авто";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(546, 364);
            label7.Name = "label7";
            label7.Size = new Size(60, 17);
            label7.TabIndex = 14;
            label7.Text = "Телефон";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(546, 406);
            label8.Name = "label8";
            label8.Size = new Size(46, 17);
            label8.TabIndex = 16;
            label8.Text = "Тонаж";
            // 
            // button1
            // 
            button1.Location = new Point(100, 456);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(479, 456);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Обновить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnUpdate_Click;
            // 
            // button3
            // 
            button3.Location = new Point(859, 456);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDelete_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(447, 21);
            label9.Name = "label9";
            label9.Size = new Size(124, 22);
            label9.TabIndex = 20;
            label9.Text = "Перевозчики";
            // 
            // txtCarModel
            // 
            txtCarModel.Location = new Point(664, 315);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(270, 25);
            txtCarModel.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(664, 361);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(270, 25);
            txtPhone.TabIndex = 11;
            // 
            // txtTonnage
            // 
            txtTonnage.Location = new Point(664, 403);
            txtTonnage.Name = "txtTonnage";
            txtTonnage.Size = new Size(270, 25);
            txtTonnage.TabIndex = 12;
            // 
            // Carriers
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 510);
            Controls.Add(txtTonnage);
            Controls.Add(txtPhone);
            Controls.Add(txtCarModel);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCarNumber);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtInn);
            Controls.Add(label2);
            Controls.Add(txtOgrn);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(gridCarriers);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Carriers";
            Text = "Перевозчики";
            ((System.ComponentModel.ISupportInitialize)gridCarriers).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label9;
        private TextBox txtCarModel;
        private TextBox txtPhone;
        private TextBox txtTonnage;
    }
}