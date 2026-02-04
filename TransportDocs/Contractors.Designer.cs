namespace TransportDocs
{
    partial class Contractors
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
            gridContractors = new DataGridView();
            txtName = new TextBox();
            txtInn = new TextBox();
            txtType = new TextBox();
            txtAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)gridContractors).BeginInit();
            SuspendLayout();
            // 
            // gridContractors
            // 
            gridContractors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridContractors.Location = new Point(12, 71);
            gridContractors.Name = "gridContractors";
            gridContractors.Size = new Size(776, 150);
            gridContractors.TabIndex = 0;
            gridContractors.CellClick += gridContractors_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(151, 266);
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 23);
            txtName.TabIndex = 1;
            // 
            // txtInn
            // 
            txtInn.Location = new Point(151, 324);
            txtInn.Name = "txtInn";
            txtInn.Size = new Size(197, 23);
            txtInn.TabIndex = 2;
            // 
            // txtType
            // 
            txtType.Location = new Point(591, 266);
            txtType.Name = "txtType";
            txtType.Size = new Size(197, 23);
            txtType.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(591, 324);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(197, 23);
            txtAddress.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(324, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 26);
            label1.TabIndex = 5;
            label1.Text = "Контрагенты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 269);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 6;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 327);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 7;
            label3.Text = "Инн";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(558, 269);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 8;
            label4.Text = "Тип";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(545, 327);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Адрес";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(151, 391);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(405, 391);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(632, 391);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Contractors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(txtType);
            Controls.Add(txtInn);
            Controls.Add(txtName);
            Controls.Add(gridContractors);
            Name = "Contractors";
            Text = "Контрагенты";
            ((System.ComponentModel.ISupportInitialize)gridContractors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridContractors;
        private TextBox txtName;
        private TextBox txtInn;
        private TextBox txtType;
        private TextBox txtAddress;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}