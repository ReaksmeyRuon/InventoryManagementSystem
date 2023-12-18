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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=VICHIT\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True;Encrypt=False");
        void fillcategory()
        {
            string query = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CateName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                // CatCombo.ValueMember = "CateName";
                // CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CateName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
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
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        void populateProducts()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductsTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        int num = 0;
        int uprice, totalprice, qty;
        string product;

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateProducts();
            fillcategory();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CustomersGV.Rows.Count)
            {
                DataGridViewRow selectedRow = CustomersGV.Rows[e.RowIndex];

                customerIdTb.Text = selectedRow?.Cells[0].Value?.ToString();
            }

            // customerIdTb.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CustomersGV.Rows.Count)
            {
                DataGridViewRow selectedRow = CustomersGV.Rows[e.RowIndex];

                uprice = Convert.ToInt32(selectedRow?.Cells[1].Value?.ToString());
            }

            product = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
          //  qty = Convert.ToInt32(QtyTb.Text);
          //  uprice = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            //  totalprice = qty * uprice;
            flag = 1;
        }

        int flag = 0;
        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductsTbl where ProdCat = '" + SearchCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        private DataTable table;

        private void InitializeTable()
        {
            table = new DataTable();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Qty", typeof(int));
            table.Columns.Add("UnitPrice", typeof(decimal));
            table.Columns.Add("TotalPrice", typeof(decimal));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
                MessageBox.Show("Enter The Quantity of Products");
            else if (flag == 0)
                MessageBox.Show("Select The Product");
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                totalprice = qty * uprice;
                table.Rows.Add(num, qty, uprice, totalprice);
                OrderGv.DataSource = table;
                flag = 0;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
