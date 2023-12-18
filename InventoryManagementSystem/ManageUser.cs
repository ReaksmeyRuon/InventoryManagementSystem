using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=VICHIT\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True;Encrypt=False");

        private void ManageUser_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl" +
                " values('" + UnameTb.Text + "', '" + FullnameTb.Text + "'," +
                "'" + PasswordTb.Text + "', '" + PhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();
                populate();
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PhoneTb.Text == "")
            {
                MessageBox.Show("Enter The User Phone Number");
            }
            else
            {
                Con.Open();
                string myquery = "delete from UserTbl where Uphone ='" + PhoneTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < UsersGV.Rows.Count)
            {
                DataGridViewRow selectedRow = UsersGV.Rows[e.RowIndex];

                // Assuming the columns are in the order of Uname, Ufullname, Upassword, Uphone
                UnameTb.Text = selectedRow.Cells[0].Value?.ToString();
                FullnameTb.Text = selectedRow.Cells[1].Value?.ToString();
                PasswordTb.Text = selectedRow.Cells[2].Value?.ToString();
                PhoneTb.Text = selectedRow.Cells[3].Value?.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTbl set Uname= '" + UnameTb.Text + "', " +
                    "Ufullname = '" + FullnameTb.Text + "'" +
                    ",Upassword = '" + PasswordTb.Text + "'where Uphone= '" + PhoneTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
