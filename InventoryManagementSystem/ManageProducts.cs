using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
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
                CatCombo.ValueMember = "CateName";
                CatCombo.DataSource = dt;
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

        void filterByCategory()
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

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductsTbl" +
                " values('" + ProductIdTb.Text + "', '" + ProductNameTb.Text + "'," +
                "'" + ProductQtyTb.Text + "', '" + ProductPriceTb.Text + "', '" + DescriptionTb.Text + "', '" + CatCombo.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Con.Close();
                populate();
            }
            catch
            {
            }
        }

        private void ProductIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductsTbl set ProductName= '" + ProductNameTb.Text + "'," +
                    "ProductQty = '" + ProductQtyTb.Text + "', ProductPrice  = '" + ProductPriceTb.Text + "'," +
                    " Description = '" + DescriptionTb.Text + "', ProdCat = '" + CatCombo.SelectedValue.ToString() + "'  " +
                    " where ProductId= '" + ProductIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
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
            if (ProductIdTb.Text == "")
            {
                MessageBox.Show("Enter The Product Id");
            }
            else
            {
                Con.Open();
                string myquery = "delete from ProductsTbl where ProductId ='" + ProductIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ProductsGV.Rows.Count)
            {
                DataGridViewRow selectedRow = ProductsGV.Rows[e.RowIndex];

                ProductIdTb.Text = selectedRow.Cells[0].Value?.ToString();
                ProductNameTb.Text = selectedRow.Cells[1].Value?.ToString();
                ProductQtyTb.Text = selectedRow.Cells[2].Value?.ToString();
                ProductPriceTb.Text = selectedRow.Cells[3].Value.ToString();
                CatCombo.SelectedValue = selectedRow.Cells[5].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
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
