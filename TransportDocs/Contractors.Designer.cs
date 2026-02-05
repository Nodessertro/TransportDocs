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
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            grpList = new GroupBox();
            grpDetails = new GroupBox();
            panelButtons = new Panel();
            panelHeader = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)gridContractors).BeginInit();
            grpList.SuspendLayout();
            grpDetails.SuspendLayout();
            panelButtons.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // gridContractors
            // 
            gridContractors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridContractors.Location = new Point(12, 26);
            gridContractors.Name = "gridContractors";
            gridContractors.Size = new Size(752, 140);
            gridContractors.TabIndex = 0;
            gridContractors.CellClick += gridContractors_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 23);
            txtName.TabIndex = 1;
            // 
            // txtInn
            // 
            txtInn.Location = new Point(130, 72);
            txtInn.Name = "txtInn";
            txtInn.Size = new Size(197, 23);
            txtInn.TabIndex = 2;
            // 
            // txtType
            // 
            txtType.Location = new Point(520, 32);
            txtType.Name = "txtType";
            txtType.Size = new Size(197, 23);
            txtType.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(520, 72);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(197, 23);
            txtAddress.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 76);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 6;
            label2.Text = "Инн";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 36);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 7;
            label3.Text = "Тип";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 76);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 8;
            label4.Text = "Адрес";
            // 
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(21, 101, 192);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(10, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 28);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 121, 107);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(150, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 28);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(198, 40, 40);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(290, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 28);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // grpList
            // 
            grpList.BackColor = Color.White;
            grpList.Controls.Add(gridContractors);
            grpList.Location = new Point(20, 70);
            grpList.Name = "grpList";
            grpList.Size = new Size(776, 190);
            grpList.TabIndex = 13;
            grpList.TabStop = false;
            grpList.Text = "Список контрагентов";
            // 
            // grpDetails
            // 
            grpDetails.BackColor = Color.White;
            grpDetails.Controls.Add(label1);
            grpDetails.Controls.Add(txtName);
            grpDetails.Controls.Add(label2);
            grpDetails.Controls.Add(txtInn);
            grpDetails.Controls.Add(label3);
            grpDetails.Controls.Add(txtType);
            grpDetails.Controls.Add(label4);
            grpDetails.Controls.Add(txtAddress);
            grpDetails.Location = new Point(20, 270);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(776, 120);
            grpDetails.TabIndex = 14;
            grpDetails.TabStop = false;
            grpDetails.Text = "Данные контрагента";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(245, 245, 245);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Location = new Point(20, 400);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(776, 48);
            panelButtons.TabIndex = 15;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(33, 37, 41);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(816, 52);
            panelHeader.TabIndex = 16;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(120, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Контрагенты";
            // 
            // Contractors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(816, 470);
            Controls.Add(panelButtons);
            Controls.Add(grpDetails);
            Controls.Add(grpList);
            Controls.Add(panelHeader);
            Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Contractors";
            Text = "Контрагенты";
            ((System.ComponentModel.ISupportInitialize)gridContractors).EndInit();
            grpList.ResumeLayout(false);
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
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
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox grpList;
        private GroupBox grpDetails;
        private Panel panelButtons;
        private Panel panelHeader;
        private Label lblTitle;
    }
}
