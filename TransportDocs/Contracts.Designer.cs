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
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridContracts).BeginInit();
            SuspendLayout();
            // 
            // gridContracts
            // 
            gridContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridContracts.Location = new Point(12, 80);
            gridContracts.Margin = new Padding(3, 4, 3, 4);
            gridContracts.Name = "gridContracts";
            gridContracts.Size = new Size(776, 171);
            gridContracts.TabIndex = 0;
            gridContracts.CellClick += gridContracts_CellClick;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(142, 302);
            txtNumber.Margin = new Padding(3, 4, 3, 4);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(204, 25);
            txtNumber.TabIndex = 1;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(528, 302);
            dtDate.Margin = new Padding(3, 4, 3, 4);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(204, 25);
            dtDate.TabIndex = 2;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(142, 384);
            cbCustomers.Margin = new Padding(3, 4, 3, 4);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(204, 25);
            cbCustomers.TabIndex = 3;
            // 
            // cbCarriers
            // 
            cbCarriers.FormattingEnabled = true;
            cbCarriers.Location = new Point(528, 384);
            cbCarriers.Margin = new Padding(3, 4, 3, 4);
            cbCarriers.Name = "cbCarriers";
            cbCarriers.Size = new Size(204, 25);
            cbCarriers.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(142, 438);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 26);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(371, 438);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 26);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(571, 438);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 26);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 305);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 8;
            label1.Text = "Номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 387);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 9;
            label2.Text = "Заказчик";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 310);
            label3.Name = "label3";
            label3.Size = new Size(36, 17);
            label3.TabIndex = 10;
            label3.Text = "Дата";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 387);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 11;
            label4.Text = "Перевозчик";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(348, 23);
            label5.Name = "label5";
            label5.Size = new Size(112, 26);
            label5.TabIndex = 12;
            label5.Text = "Договора";
            // 
            // Contracts
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbCarriers);
            Controls.Add(cbCustomers);
            Controls.Add(dtDate);
            Controls.Add(txtNumber);
            Controls.Add(gridContracts);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Contracts";
            Text = "Договора";
            ((System.ComponentModel.ISupportInitialize)gridContracts).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label5;
    }
}