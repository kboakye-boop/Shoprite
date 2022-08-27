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
    public partial class AttendantForm : Form
    {
        public AttendantForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\erica selasie\Documents\shopritedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            String query = "select * from AttendantTable1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            AttendantDisplay.DataSource = data.Tables[0];
            Con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                String query = "insert into AttendantTable1 values('"+AttendantId.Text+"','"+AttendantUsername.Text+"','"+AttendantPassword.Text+"') ";
                SqlCommand command = new SqlCommand(query, Con);
                command.ExecuteNonQuery();
                MessageBox.Show("Attendant Successfully added");
                Con.Close();
                populate();
                AttendantId.Text = "";
                AttendantUsername.Text = "";
                AttendantPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CategoriesForm catForm = new CategoriesForm();
            catForm.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
            productsForm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void AttendantDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AttendantId.Text = AttendantDisplay.SelectedRows[0].Cells[0].Value.ToString();
            AttendantUsername.Text = AttendantDisplay.SelectedRows[0].Cells[1].Value.ToString();
            AttendantPassword.Text = AttendantDisplay.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                String query = "delete from AttendantTable1 where AttendantId = '"+AttendantId.Text+"'";
                SqlCommand command = new SqlCommand(query,Con);
                command.ExecuteNonQuery();
                MessageBox.Show("Attendand successfully deleted");
                Con.Close();
                populate();
                AttendantId.Text = "";
                AttendantUsername.Text = "";
                AttendantPassword.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AttendantForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (AttendantPassword.Text == "" )
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    String query = "update AttendantTable1 set AttendantPassword = '" + AttendantPassword.Text + "' where AttendantID = " + AttendantId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password successfully updated");
                    Con.Close();
                    populate();
                    AttendantId.Text = "";
                    AttendantUsername.Text = "";
                    AttendantPassword.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
