namespace InventoryManagementSystem
{
    partial class ManageCustomers
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
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            CustIdTb = new TextBox();
            CustNameTb = new TextBox();
            CustPhoneTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            customersGV = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            label9 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customersGV).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(772, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 31);
            label4.TabIndex = 12;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(337, 66);
            label2.Name = "label2";
            label2.Size = new Size(213, 31);
            label2.TabIndex = 1;
            label2.Text = "Manage Customers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(247, 23);
            label1.Name = "label1";
            label1.Size = new Size(391, 31);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 138);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 2;
            label3.Text = "CUSTOMER LIST";
            // 
            // CustIdTb
            // 
            CustIdTb.ForeColor = Color.Crimson;
            CustIdTb.Location = new Point(25, 180);
            CustIdTb.Name = "CustIdTb";
            CustIdTb.Size = new Size(286, 27);
            CustIdTb.TabIndex = 3;
            CustIdTb.Text = "CustomerId";
            CustIdTb.TextChanged += CustIdTb_TextChanged;
            // 
            // CustNameTb
            // 
            CustNameTb.ForeColor = Color.Crimson;
            CustNameTb.Location = new Point(25, 225);
            CustNameTb.Name = "CustNameTb";
            CustNameTb.Size = new Size(286, 27);
            CustNameTb.TabIndex = 4;
            CustNameTb.Text = "CustomerName";
            // 
            // CustPhoneTb
            // 
            CustPhoneTb.ForeColor = Color.Crimson;
            CustPhoneTb.Location = new Point(25, 277);
            CustPhoneTb.Name = "CustPhoneTb";
            CustPhoneTb.Size = new Size(286, 27);
            CustPhoneTb.TabIndex = 5;
            CustPhoneTb.Text = "CustomerPhone";
            CustPhoneTb.TextChanged += CustPhoneTb_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 325);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.ForeColor = Color.White;
            button2.Location = new Point(119, 325);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 7;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.ForeColor = Color.White;
            button3.Location = new Point(219, 325);
            button3.Name = "button3";
            button3.Size = new Size(97, 36);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.ForeColor = Color.White;
            button4.Location = new Point(119, 367);
            button4.Name = "button4";
            button4.Size = new Size(97, 36);
            button4.TabIndex = 9;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // customersGV
            // 
            customersGV.BackgroundColor = Color.White;
            customersGV.BorderStyle = BorderStyle.None;
            customersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersGV.Location = new Point(361, 178);
            customersGV.Name = "customersGV";
            customersGV.RowHeadersWidth = 51;
            customersGV.Size = new Size(427, 259);
            customersGV.TabIndex = 10;
            customersGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 585);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 10);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Purple;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.ForeColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(42, 468);
            panel3.Name = "panel3";
            panel3.Size = new Size(161, 69);
            panel3.TabIndex = 12;
            panel3.Paint += panel3_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 23);
            label6.Name = "label6";
            label6.Size = new Size(76, 31);
            label6.TabIndex = 14;
            label6.Text = "Count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 13;
            label5.Text = "Orders Count";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(40, 23);
            label7.Name = "label7";
            label7.Size = new Size(97, 31);
            label7.TabIndex = 14;
            label7.Text = "Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(14, 0);
            label8.Name = "label8";
            label8.Size = new Size(131, 23);
            label8.TabIndex = 13;
            label8.Text = "Orders Amount";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Blue;
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.ForeColor = SystemColors.ControlLightLight;
            panel4.Location = new Point(337, 468);
            panel4.Name = "panel4";
            panel4.Size = new Size(161, 69);
            panel4.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(40, 23);
            label9.Name = "label9";
            label9.Size = new Size(63, 31);
            label9.TabIndex = 14;
            label9.Text = "Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(13, 0);
            label10.Name = "label10";
            label10.Size = new Size(136, 23);
            label10.TabIndex = 13;
            label10.Text = "Last Order Date";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Green;
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.ForeColor = SystemColors.ControlLightLight;
            panel5.Location = new Point(614, 468);
            panel5.Name = "panel5";
            panel5.Size = new Size(161, 69);
            panel5.TabIndex = 14;
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 595);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(customersGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CustPhoneTb);
            Controls.Add(CustNameTb);
            Controls.Add(CustIdTb);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomers";
            RightToLeft = RightToLeft.No;
            Text = "ManageCustomers";
            Load += ManageCustomers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customersGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox CustIdTb;
        private TextBox CustNameTb;
        private TextBox CustPhoneTb;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView customersGV;
        private Panel panel2;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel4;
        private Label label9;
        private Label label10;
        private Panel panel5;
    }
}