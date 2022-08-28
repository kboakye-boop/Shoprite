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

namespace shoprite_Inventory_App
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\erica selasie\Documents\shopritedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void categoryDropdown()
        {
            //connecting the dropdown to the database
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoriesTable1", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(reader);
            ProductDropdown.ValueMember = "CatName";
            ProductDropdown.DataSource = dt;
            ProductCat.ValueMember = "CatName";
            ProductCat.DataSource = dt;
            Con.Close();

        }
        private void productDropdownDisplay()
        {
            //connecting the dropdown to the database
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoriesTable1", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(reader);
            ProductDropdown.ValueMember = "CatName";
            ProductDropdown.DataSource = dt;
            Con.Close();

        }


        private void productDropdown()
        {
            Con.Open();
            String query = "select * from ProductTables1 where ProductCat = '" + ProductDropdown.SelectedValue.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            var Data = new DataSet();
            adapter.Fill(Data);
            productDisplay.DataSource = Data.Tables[0];
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            String query = "select * from ProductTables1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            productDisplay.DataSource = data.Tables[0];

            Con.Close();

        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            
            categoryDropdown();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductId.Text == "" || ProductName.Text == "" || ProductQty.Text == "" || ProductPrice.Text == "" || ProductCat.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    String query = "update ProductTables1 set ProductName = '" + ProductName.Text + "',ProductQty = '" + ProductQty.Text + "',ProductPrice = '"+ProductPrice.Text+"',ProductCat = '"+ProductCat.SelectedValue.ToString()+"' where ProductId = '" + ProductId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("category successfully updated");
                    Con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private void CatDispaly_Click(object sender, EventArgs e)
        {

        }
        */
        private void button5_Click(object sender, EventArgs e)
        {
            CategoriesForm cat = new CategoriesForm();
            cat.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                String query = "insert into ProductTables1  values(" + ProductId.Text + ",'" + ProductName.Text + "','" + ProductQty.Text + "','"+ProductPrice.Text+"','"+ProductCat.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("category added successfully");
                Con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductId.Text == "")
                {
                    MessageBox.Show("Please select the product to be deleted");
                }
                else
                {
                    Con.Open();
                    String query = "delete from ProductTables1 where ProductId = " + ProductId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("product deleted successfully");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductId.Text = productDisplay.SelectedRows[0].Cells[0].Value.ToString();
            ProductName.Text = productDisplay.SelectedRows[0].Cells[1].Value.ToString();
            ProductQty.Text = productDisplay.SelectedRows[0].Cells[2].Value.ToString();
            ProductPrice.Text = productDisplay.SelectedRows[0].Cells[3].Value.ToString();
            ProductCat.SelectedValue = productDisplay.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SHOPRITE SALES LIST",new Font("Century Gothic",25,FontStyle.Bold),Brushes.Red,new Point(230));
        }

        private void ProductCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductId_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            productDropdown();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            populate();

        }

        private void ProductDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AttendantForm attendant = new AttendantForm();
            attendant.Show();
            this.Hide();
        }
    }
}
