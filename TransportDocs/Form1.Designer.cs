namespace TransportDocs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewCustomers = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            grpNavigation = new GroupBox();
            grpPreview = new GroupBox();
            panelHeader = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            grpNavigation.SuspendLayout();
            grpPreview.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(12, 26);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.Size = new Size(450, 250);
            dataGridViewCustomers.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(21, 101, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 30);
            button1.Name = "button1";
            button1.Size = new Size(160, 36);
            button1.TabIndex = 1;
            button1.Text = "Организации";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 121, 107);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(200, 30);
            button2.Name = "button2";
            button2.Size = new Size(160, 36);
            button2.TabIndex = 2;
            button2.Text = "Перевозчики";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(239, 108, 0);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(20, 78);
            button3.Name = "button3";
            button3.Size = new Size(160, 36);
            button3.TabIndex = 3;
            button3.Text = "Договора";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(62, 39, 35);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(200, 78);
            button4.Name = "button4";
            button4.Size = new Size(160, 36);
            button4.TabIndex = 4;
            button4.Text = "Накладные";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(66, 66, 66);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(20, 126);
            button5.Name = "button5";
            button5.Size = new Size(160, 36);
            button5.TabIndex = 5;
            button5.Text = "Контрагенты";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(46, 125, 50);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(200, 126);
            button6.Name = "button6";
            button6.Size = new Size(160, 36);
            button6.TabIndex = 6;
            button6.Text = "Акт + заявка";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(85, 85, 85);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(20, 174);
            button7.Name = "button7";
            button7.Size = new Size(340, 36);
            button7.TabIndex = 7;
            button7.Text = "Все документы";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // grpNavigation
            // 
            grpNavigation.BackColor = Color.White;
            grpNavigation.Controls.Add(button1);
            grpNavigation.Controls.Add(button2);
            grpNavigation.Controls.Add(button3);
            grpNavigation.Controls.Add(button4);
            grpNavigation.Controls.Add(button5);
            grpNavigation.Controls.Add(button6);
            grpNavigation.Controls.Add(button7);
            grpNavigation.Location = new Point(20, 70);
            grpNavigation.Name = "grpNavigation";
            grpNavigation.Size = new Size(380, 240);
            grpNavigation.TabIndex = 8;
            grpNavigation.TabStop = false;
            grpNavigation.Text = "Разделы";
            // 
            // grpPreview
            // 
            grpPreview.BackColor = Color.White;
            grpPreview.Controls.Add(dataGridViewCustomers);
            grpPreview.Location = new Point(420, 70);
            grpPreview.Name = "grpPreview";
            grpPreview.Size = new Size(476, 300);
            grpPreview.TabIndex = 9;
            grpPreview.TabStop = false;
            grpPreview.Text = "Быстрый просмотр";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(33, 37, 41);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(920, 52);
            panelHeader.TabIndex = 10;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TransportDocs";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(920, 420);
            Controls.Add(panelHeader);
            Controls.Add(grpPreview);
            Controls.Add(grpNavigation);
            Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "TransportDocs";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            grpNavigation.ResumeLayout(false);
            grpPreview.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCustomers;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private GroupBox grpNavigation;
        private GroupBox grpPreview;
        private Panel panelHeader;
        private Label lblTitle;
    }
}
