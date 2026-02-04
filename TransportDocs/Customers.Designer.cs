namespace TransportDocs
{
    partial class Customers
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
            gridCustomers = new DataGridView();
            txtName = new TextBox();
            txtInn = new TextBox();
            txtDirector = new TextBox();
            txtAddress = new TextBox();
            txtOgrn = new TextBox();
            txtKpp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridCustomers).BeginInit();
            SuspendLayout();
            // 
            // gridCustomers
            // 
            gridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCustomers.Location = new Point(12, 69);
            gridCustomers.Name = "gridCustomers";
            gridCustomers.Size = new Size(776, 182);
            gridCustomers.TabIndex = 0;
            gridCustomers.CellClick += gridCustomers_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(311, 286);
            txtName.Name = "txtName";
            txtName.Size = new Size(336, 25);
            txtName.TabIndex = 1;
            // 
            // txtInn
            // 
            txtInn.Location = new Point(311, 319);
            txtInn.Name = "txtInn";
            txtInn.Size = new Size(336, 25);
            txtInn.TabIndex = 2;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(311, 451);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(336, 25);
            txtDirector.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(311, 418);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(336, 25);
            txtAddress.TabIndex = 5;
            // 
            // txtOgrn
            // 
            txtOgrn.Location = new Point(311, 385);
            txtOgrn.Name = "txtOgrn";
            txtOgrn.Size = new Size(336, 25);
            txtOgrn.TabIndex = 4;
            // 
            // txtKpp
            // 
            txtKpp.Location = new Point(311, 352);
            txtKpp.Name = "txtKpp";
            txtKpp.Size = new Size(336, 25);
            txtKpp.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 295);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 7;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 328);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 8;
            label2.Text = "ИНН";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 362);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 9;
            label3.Text = "КПП";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 394);
            label4.Name = "label4";
            label4.Size = new Size(40, 17);
            label4.TabIndex = 10;
            label4.Text = "ОГРН";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 427);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 11;
            label5.Text = "Адрес";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(142, 454);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 12;
            label6.Text = "Директор";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(142, 522);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 26);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(375, 522);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 26);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(572, 522);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 26);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(355, 17);
            label7.Name = "label7";
            label7.Size = new Size(159, 26);
            label7.TabIndex = 16;
            label7.Text = "Организации";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 598);
            Controls.Add(label7);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKpp);
            Controls.Add(txtOgrn);
            Controls.Add(txtAddress);
            Controls.Add(txtDirector);
            Controls.Add(txtInn);
            Controls.Add(txtName);
            Controls.Add(gridCustomers);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Customers";
            Text = "Организации";
            ((System.ComponentModel.ISupportInitialize)gridCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridCustomers;
        private TextBox txtName;
        private TextBox txtInn;
        private TextBox txtDirector;
        private TextBox txtAddress;
        private TextBox txtOgrn;
        private TextBox txtKpp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label7;
    }
}