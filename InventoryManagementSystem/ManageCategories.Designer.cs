namespace InventoryManagementSystem
{
    partial class ManageCategories
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
            CateNameTb = new TextBox();
            CateIdTb = new TextBox();
            categoriesGV = new DataGridView();
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesGV).BeginInit();
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
            panel1.Size = new Size(802, 125);
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
            label2.Size = new Size(215, 31);
            label2.TabIndex = 1;
            label2.Text = "Manage Categories";
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
            label1.Click += label1_Click;
            // 
            // CateNameTb
            // 
            CateNameTb.ForeColor = Color.Crimson;
            CateNameTb.Location = new Point(23, 226);
            CateNameTb.Name = "CateNameTb";
            CateNameTb.Size = new Size(286, 27);
            CateNameTb.TabIndex = 6;
            CateNameTb.Text = "CategoriesName";
            // 
            // CateIdTb
            // 
            CateIdTb.ForeColor = Color.Crimson;
            CateIdTb.Location = new Point(23, 181);
            CateIdTb.Name = "CateIdTb";
            CateIdTb.Size = new Size(286, 27);
            CateIdTb.TabIndex = 5;
            CateIdTb.Text = "CategoriesId";
            // 
            // categoriesGV
            // 
            categoriesGV.BackgroundColor = Color.White;
            categoriesGV.BorderStyle = BorderStyle.None;
            categoriesGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriesGV.Location = new Point(361, 179);
            categoriesGV.Name = "categoriesGV";
            categoriesGV.RowHeadersWidth = 51;
            categoriesGV.Size = new Size(427, 259);
            categoriesGV.TabIndex = 12;
            categoriesGV.CellContentClick += categoriesGV_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 139);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 11;
            label3.Text = "CATEGORIES LIST";
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.ForeColor = Color.White;
            button4.Location = new Point(120, 320);
            button4.Name = "button4";
            button4.Size = new Size(97, 36);
            button4.TabIndex = 16;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.ForeColor = Color.White;
            button3.Location = new Point(220, 278);
            button3.Name = "button3";
            button3.Size = new Size(97, 36);
            button3.TabIndex = 15;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.ForeColor = Color.White;
            button2.Location = new Point(120, 278);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 14;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.ForeColor = Color.White;
            button1.Location = new Point(17, 278);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 449);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 10);
            panel2.TabIndex = 17;
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 459);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(categoriesGV);
            Controls.Add(label3);
            Controls.Add(CateNameTb);
            Controls.Add(CateIdTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCategories";
            Load += ManageCategories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox CateNameTb;
        private TextBox CateIdTb;
        private DataGridView categoriesGV;
        private Label label3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
    }
}