namespace InventoryManagementSystem
{
    partial class ManageOrders
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
            CustomersGV = new DataGridView();
            OrderIdTb = new TextBox();
            customerIdTb = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label5 = new Label();
            ProductsGV = new DataGridView();
            label6 = new Label();
            SearchCombo = new ComboBox();
            label7 = new Label();
            QtyTb = new TextBox();
            button1 = new Button();
            OrderGv = new DataGridView();
            panel3 = new Panel();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGv).BeginInit();
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
            panel1.TabIndex = 2;
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
            label2.Size = new Size(173, 31);
            label2.TabIndex = 1;
            label2.Text = "Manage Orders";
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
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(64, 128);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 13;
            label3.Text = "CUSTOMERS LIST";
            // 
            // CustomersGV
            // 
            CustomersGV.BackgroundColor = Color.White;
            CustomersGV.BorderStyle = BorderStyle.None;
            CustomersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGV.Location = new Point(12, 162);
            CustomersGV.Name = "CustomersGV";
            CustomersGV.RowHeadersWidth = 51;
            CustomersGV.Size = new Size(296, 161);
            CustomersGV.TabIndex = 26;
            CustomersGV.CellContentClick += CustomersGV_CellContentClick;
            // 
            // OrderIdTb
            // 
            OrderIdTb.ForeColor = Color.Crimson;
            OrderIdTb.Location = new Point(12, 330);
            OrderIdTb.Name = "OrderIdTb";
            OrderIdTb.Size = new Size(250, 27);
            OrderIdTb.TabIndex = 27;
            OrderIdTb.Tag = "";
            OrderIdTb.Text = "OrderId";
            // 
            // customerIdTb
            // 
            customerIdTb.ForeColor = Color.Crimson;
            customerIdTb.Location = new Point(12, 363);
            customerIdTb.Name = "customerIdTb";
            customerIdTb.Size = new Size(250, 27);
            customerIdTb.TabIndex = 28;
            customerIdTb.Tag = "";
            customerIdTb.Text = "CustomerId";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarForeColor = Color.White;
            dateTimePicker1.CalendarMonthBackground = Color.Crimson;
            dateTimePicker1.Location = new Point(12, 455);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(64, 429);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 30;
            label5.Text = "Order Date";
            // 
            // ProductsGV
            // 
            ProductsGV.BackgroundColor = Color.White;
            ProductsGV.BorderStyle = BorderStyle.None;
            ProductsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGV.Location = new Point(314, 162);
            ProductsGV.Name = "ProductsGV";
            ProductsGV.RowHeadersWidth = 51;
            ProductsGV.Size = new Size(473, 161);
            ProductsGV.TabIndex = 32;
            ProductsGV.CellContentClick += ProductsGV_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(491, 134);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 31;
            // 
            // SearchCombo
            // 
            SearchCombo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchCombo.ForeColor = Color.Crimson;
            SearchCombo.FormattingEnabled = true;
            SearchCombo.Location = new Point(497, 128);
            SearchCombo.Name = "SearchCombo";
            SearchCombo.Size = new Size(173, 28);
            SearchCombo.TabIndex = 33;
            SearchCombo.Text = "Search Category";
            SearchCombo.SelectedIndexChanged += SearchCombo_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(387, 333);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 34;
            label7.Text = "Quantity";
            // 
            // QtyTb
            // 
            QtyTb.ForeColor = Color.Crimson;
            QtyTb.Location = new Point(458, 330);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(180, 27);
            QtyTb.TabIndex = 35;
            QtyTb.Tag = "";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.ForeColor = Color.White;
            button1.Location = new Point(644, 325);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 36;
            button1.Text = "Add To Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OrderGv
            // 
            OrderGv.BackgroundColor = Color.White;
            OrderGv.BorderStyle = BorderStyle.None;
            OrderGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGv.Location = new Point(268, 377);
            OrderGv.Name = "OrderGv";
            OrderGv.RowHeadersWidth = 51;
            OrderGv.Size = new Size(519, 161);
            OrderGv.TabIndex = 37;
            OrderGv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Crimson;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 585);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 10);
            panel3.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Crimson;
            textBox1.Location = new Point(12, 396);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 39;
            textBox1.Tag = "";
            textBox1.Text = "CustomerId";
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 595);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Controls.Add(OrderGv);
            Controls.Add(button1);
            Controls.Add(QtyTb);
            Controls.Add(label7);
            Controls.Add(SearchCombo);
            Controls.Add(ProductsGV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(customerIdTb);
            Controls.Add(OrderIdTb);
            Controls.Add(CustomersGV);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView CustomersGV;
        private TextBox OrderIdTb;
        private TextBox customerIdTb;
        private DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label5;
        private DataGridView ProductsGV;
        private Label label6;
        private ComboBox SearchCombo;
        private Label label7;
        private TextBox QtyTb;
        private Button button1;
        private DataGridView OrderGv;
        private Panel panel3;
        private TextBox textBox1;
    }
}