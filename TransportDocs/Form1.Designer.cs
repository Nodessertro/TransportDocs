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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(21, 12);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.Size = new Size(751, 93);
            dataGridViewCustomers.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(31, 138);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 1;
            button1.Text = "Организации";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(143, 138);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 2;
            button2.Text = "Перевозчики";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(288, 138);
            button3.Name = "button3";
            button3.Size = new Size(134, 23);
            button3.TabIndex = 3;
            button3.Text = "Договора";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(446, 138);
            button4.Name = "button4";
            button4.Size = new Size(207, 23);
            button4.TabIndex = 4;
            button4.Text = "Транспортные накладные";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(31, 192);
            button5.Name = "button5";
            button5.Size = new Size(106, 23);
            button5.TabIndex = 5;
            button5.Text = "Контрагенты";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(143, 192);
            button6.Name = "button6";
            button6.Size = new Size(123, 23);
            button6.TabIndex = 6;
            button6.Text = "Акт";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(288, 192);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 7;
            button7.Text = "All";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewCustomers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
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
    }
}
