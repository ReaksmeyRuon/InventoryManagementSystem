namespace InventoryManagementSystem
{
    partial class ManageUser
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
            UnameTb = new TextBox();
            FullnameTb = new TextBox();
            PasswordTb = new TextBox();
            PhoneTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            UsersGV = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
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
            panel1.Size = new Size(856, 125);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(827, 0);
            label4.Name = "label4";
            label4.Size = new Size(29, 31);
            label4.TabIndex = 2;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(346, 71);
            label2.Name = "label2";
            label2.Size = new Size(160, 31);
            label2.TabIndex = 1;
            label2.Text = "Manage Users";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(231, 28);
            label1.Name = "label1";
            label1.Size = new Size(376, 31);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANGEMENT SYSTEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(556, 139);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 2;
            label3.Text = "USERS LIST";
            // 
            // UnameTb
            // 
            UnameTb.ForeColor = Color.Crimson;
            UnameTb.Location = new Point(19, 167);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(296, 27);
            UnameTb.TabIndex = 3;
            UnameTb.Text = "UserName";
            // 
            // FullnameTb
            // 
            FullnameTb.ForeColor = Color.Crimson;
            FullnameTb.Location = new Point(19, 200);
            FullnameTb.Name = "FullnameTb";
            FullnameTb.Size = new Size(296, 27);
            FullnameTb.TabIndex = 4;
            FullnameTb.Text = "FullName";
            // 
            // PasswordTb
            // 
            PasswordTb.ForeColor = Color.Crimson;
            PasswordTb.Location = new Point(17, 233);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(296, 27);
            PasswordTb.TabIndex = 5;
            PasswordTb.Text = "Password";
            // 
            // PhoneTb
            // 
            PhoneTb.ForeColor = Color.Crimson;
            PhoneTb.Location = new Point(17, 266);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(296, 27);
            PhoneTb.TabIndex = 6;
            PhoneTb.Text = "Telephone";
            PhoneTb.TextChanged += PhoneTb_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.ForeColor = Color.White;
            button1.Location = new Point(17, 310);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.ForeColor = Color.White;
            button2.Location = new Point(117, 310);
            button2.Name = "button2";
            button2.Size = new Size(94, 38);
            button2.TabIndex = 8;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.ForeColor = Color.White;
            button3.Location = new Point(219, 310);
            button3.Name = "button3";
            button3.Size = new Size(94, 38);
            button3.TabIndex = 9;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.ForeColor = Color.White;
            button4.Location = new Point(117, 354);
            button4.Name = "button4";
            button4.Size = new Size(94, 37);
            button4.TabIndex = 10;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // UsersGV
            // 
            UsersGV.BackgroundColor = Color.White;
            UsersGV.BorderStyle = BorderStyle.None;
            UsersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGV.Location = new Point(381, 167);
            UsersGV.Name = "UsersGV";
            UsersGV.RowHeadersWidth = 51;
            UsersGV.Size = new Size(463, 262);
            UsersGV.TabIndex = 11;
            UsersGV.CellContentClick += UsersGV_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 470);
            panel2.Name = "panel2";
            panel2.Size = new Size(856, 10);
            panel2.TabIndex = 12;
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 480);
            Controls.Add(panel2);
            Controls.Add(UsersGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PhoneTb);
            Controls.Add(PasswordTb);
            Controls.Add(FullnameTb);
            Controls.Add(UnameTb);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUser";
            Load += ManageUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox UnameTb;
        private TextBox FullnameTb;
        private TextBox PasswordTb;
        private TextBox PhoneTb;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView UsersGV;
        private Panel panel2;
        private Label label4;
    }
}