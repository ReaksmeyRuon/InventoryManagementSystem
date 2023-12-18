namespace InventoryManagementSystem
{
    partial class ManageProducts
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
            panel2 = new Panel();
            ProductPriceTb = new TextBox();
            ProductQtyTb = new TextBox();
            ProductNameTb = new TextBox();
            ProductIdTb = new TextBox();
            DescriptionTb = new TextBox();
            CatCombo = new ComboBox();
            panel3 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ProductsGV = new DataGridView();
            label3 = new Label();
            SearchCombo = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).BeginInit();
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
            panel1.TabIndex = 1;
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
            label2.Size = new Size(193, 31);
            label2.TabIndex = 1;
            label2.Text = "Manage Products";
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
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 554);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 10);
            panel2.TabIndex = 12;
            // 
            // ProductPriceTb
            // 
            ProductPriceTb.ForeColor = Color.Crimson;
            ProductPriceTb.Location = new Point(10, 272);
            ProductPriceTb.Name = "ProductPriceTb";
            ProductPriceTb.Size = new Size(204, 27);
            ProductPriceTb.TabIndex = 16;
            ProductPriceTb.Text = "ProductPrice";
            // 
            // ProductQtyTb
            // 
            ProductQtyTb.ForeColor = Color.Crimson;
            ProductQtyTb.Location = new Point(10, 239);
            ProductQtyTb.Name = "ProductQtyTb";
            ProductQtyTb.Size = new Size(204, 27);
            ProductQtyTb.TabIndex = 15;
            ProductQtyTb.Text = "ProductQty";
            // 
            // ProductNameTb
            // 
            ProductNameTb.ForeColor = Color.Crimson;
            ProductNameTb.Location = new Point(12, 206);
            ProductNameTb.Name = "ProductNameTb";
            ProductNameTb.Size = new Size(202, 27);
            ProductNameTb.TabIndex = 14;
            ProductNameTb.Text = "ProductName";
            // 
            // ProductIdTb
            // 
            ProductIdTb.ForeColor = Color.Crimson;
            ProductIdTb.Location = new Point(12, 173);
            ProductIdTb.Name = "ProductIdTb";
            ProductIdTb.Size = new Size(202, 27);
            ProductIdTb.TabIndex = 13;
            ProductIdTb.Tag = "";
            ProductIdTb.Text = "ProductId";
            ProductIdTb.TextChanged += ProductIdTb_TextChanged;
            // 
            // DescriptionTb
            // 
            DescriptionTb.ForeColor = Color.Crimson;
            DescriptionTb.Location = new Point(12, 305);
            DescriptionTb.Name = "DescriptionTb";
            DescriptionTb.Size = new Size(202, 27);
            DescriptionTb.TabIndex = 17;
            DescriptionTb.Text = "Description";
            // 
            // CatCombo
            // 
            CatCombo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CatCombo.ForeColor = Color.Crimson;
            CatCombo.FormattingEnabled = true;
            CatCombo.Location = new Point(10, 346);
            CatCombo.Name = "CatCombo";
            CatCombo.Size = new Size(204, 28);
            CatCombo.TabIndex = 18;
            CatCombo.Text = "Product Category";
            CatCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Crimson;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 544);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 10);
            panel3.TabIndex = 23;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.ForeColor = Color.White;
            button4.Location = new Point(88, 436);
            button4.Name = "button4";
            button4.Size = new Size(68, 36);
            button4.TabIndex = 22;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.ForeColor = Color.White;
            button3.Location = new Point(162, 394);
            button3.Name = "button3";
            button3.Size = new Size(68, 36);
            button3.TabIndex = 21;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.ForeColor = Color.White;
            button2.Location = new Point(88, 394);
            button2.Name = "button2";
            button2.Size = new Size(68, 36);
            button2.TabIndex = 20;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.ForeColor = Color.White;
            button1.Location = new Point(14, 394);
            button1.Name = "button1";
            button1.Size = new Size(68, 36);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProductsGV
            // 
            ProductsGV.BackgroundColor = Color.White;
            ProductsGV.BorderStyle = BorderStyle.None;
            ProductsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGV.Location = new Point(247, 197);
            ProductsGV.Name = "ProductsGV";
            ProductsGV.RowHeadersWidth = 51;
            ProductsGV.Size = new Size(541, 341);
            ProductsGV.TabIndex = 25;
            ProductsGV.CellContentClick += ProductsGV_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(460, 138);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 24;
            label3.Text = "PRODUCTS LIST";
            // 
            // SearchCombo
            // 
            SearchCombo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchCombo.ForeColor = Color.Crimson;
            SearchCombo.FormattingEnabled = true;
            SearchCombo.Location = new Point(348, 164);
            SearchCombo.Name = "SearchCombo";
            SearchCombo.Size = new Size(173, 28);
            SearchCombo.TabIndex = 26;
            SearchCombo.Text = "Search Category";
            SearchCombo.SelectedIndexChanged += SearchCombo_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.ForeColor = Color.White;
            button5.Location = new Point(527, 160);
            button5.Name = "button5";
            button5.Size = new Size(80, 35);
            button5.TabIndex = 27;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Crimson;
            button6.ForeColor = Color.White;
            button6.Location = new Point(613, 160);
            button6.Name = "button6";
            button6.Size = new Size(80, 35);
            button6.TabIndex = 28;
            button6.Text = "Refresh";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(SearchCombo);
            Controls.Add(ProductsGV);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CatCombo);
            Controls.Add(DescriptionTb);
            Controls.Add(ProductPriceTb);
            Controls.Add(ProductQtyTb);
            Controls.Add(ProductNameTb);
            Controls.Add(ProductIdTb);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox ProductPriceTb;
        private TextBox ProductQtyTb;
        private TextBox ProductNameTb;
        private TextBox ProductIdTb;
        private TextBox DescriptionTb;
        private ComboBox CatCombo;
        private Panel panel3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView ProductsGV;
        private Label label3;
        private ComboBox SearchCombo;
        private Button button5;
        private Button button6;
    }
}