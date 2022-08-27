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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\erica selasie\Documents\shopritedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                String query = "insert into CategoriesTable1 values("+CatIDTb.Text+",'"+CatNameTb.Text+"','"+CatDescTb.Text+"')";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("category added successfully");
                Con.Close();
                populate();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            Con.Open();
            String query = "select * from CategoriesTable1";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            CatDisplay.DataSource = data.Tables[0];
            Con.Close();
           

        }
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CatDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIDTb.Text = CatDisplay.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDisplay.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDisplay.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatIDTb.Text == "")
                {
                    MessageBox.Show("Please select the category to be deleted");
                }
                else
                {
                    Con.Open();
                    String query = "delete from CategoriesTable1 where CatID = " +CatIDTb.Text +"";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("category deleted successfully");
                    Con.Close();
                    populate();
                    CatNameTb.Text = "";
                    CatDescTb.Text = "";
                    CatIDTb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIDTb.Text == "" || CatNameTb.Text =="" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    String query = "update CategoriesTable1 set CatName = '" + CatNameTb.Text + "',CatDescription = '" + CatDescTb.Text + "' where CatID = " + CatIDTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("category successfully updated");
                    Con.Close();
                    populate();
                    CatNameTb.Text = "";
                    CatDescTb.Text = "";
                    CatIDTb.Text = "";
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductsForm productForm = new ProductsForm();
            productForm.Show();
            this.Hide();
        }
    }
}
