using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=VICHIT\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True;Encrypt=False");
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                customersGV.DataSource = ds.Tables[0];
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
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl" +
                " values('" + CustIdTb.Text + "', '" + CustNameTb.Text + "'," +
                "'" + CustPhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                populate();
            }
            catch
            {
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < customersGV.Rows.Count)
            {
                DataGridViewRow selectedRow = customersGV.Rows[e.RowIndex];

                CustIdTb.Text = selectedRow.Cells[0].Value?.ToString();
                CustNameTb.Text = selectedRow.Cells[1].Value?.ToString();
                CustPhoneTb.Text = selectedRow.Cells[2].Value?.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTbl set CustId= '" + CustIdTb.Text + "', " +
                    "CustName = '" + CustNameTb.Text + "'" +
                    ",CustPhone = '" + CustPhoneTb.Text + "'where CustId= '" + CustIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CustIdTb.Text == "")
            {
                MessageBox.Show("Enter The Customer Id");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CustomerTbl where CustId ='" + CustIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CustPhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
