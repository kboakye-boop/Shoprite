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
    public partial class SalesForm : Form
    {
        
        public SalesForm()
        {
            InitializeComponent();
        }
        public static string attendantname = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\erica selasie\Documents\shopritedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            String query = "select ProductName,ProductQty from ProductTables1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            salesDisplay.DataSource = data.Tables[0];
            Con.Close();


        }
        private void salesDropdown()
        {
            //connecting the dropdown to the database
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoriesTable1", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(reader);
            ProductCat.ValueMember = "CatName";
            ProductCat.DataSource = dt;
            Con.Close();

        }
        private void populateBill()
        {
            Con.Open();
            String query = "select * from BillTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            salesListDisplay.DataSource = data.Tables[0];
            Con.Close();


        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            populate();
            populateBill();
            salesDropdown();
            attendantNameLable.Text = attendantname;
        }
        int flag = 0;
        private void salesDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductName.Text =salesDisplay.SelectedRows[0].Cells[0].Value.ToString();
            ProductPrice.Text = salesDisplay.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            datelabel.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        int GrdTotal = 0;
        int n = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "" || ProductQty.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                
                int total = Convert.ToInt32(ProductQty.Text) * Convert.ToInt32(ProductPrice.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(orderDisplay);
                newRow.Cells[0].Value = n+1;
                newRow.Cells[1].Value = ProductName.Text;
                newRow.Cells[2].Value = ProductPrice.Text;
                newRow.Cells[3].Value = ProductQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProductQty.Text) * Convert.ToInt32(ProductPrice.Text);
                orderDisplay.Rows.Add(newRow);
                n++;
                GrdTotal = GrdTotal + total;
                amountLabel.Text = ""+ GrdTotal;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BillId.Text == "") 
            {
                MessageBox.Show("Missing Bill Id");
            }
            else {
                try
                {


                    Con.Open();
                    String query = "insert into BillTable  values(" + BillId.Text + ",'" + attendantNameLable.Text + "','" + datelabel.Text + "','" + amountLabel.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order added successfully");
                    Con.Close();
                    populateBill();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("please add product to calculate total");
                }
               
            }
        }

        private void ProductId_TextChanged(object sender, EventArgs e)
        {

        }

        private void amountLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void salesListDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1; 
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SALES RECEIPT", new Font("century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(250));
            e.Graphics.DrawString("Bill Id:"+salesListDisplay.SelectedRows[0].Cells[0].Value.ToString(), new Font("century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100,70));
            e.Graphics.DrawString("Attendant Name:" + attendantNameLable.Text, new Font("century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100,100));
            e.Graphics.DrawString("Date:" + salesListDisplay.SelectedRows[0].Cells[2].Value.ToString(), new Font("century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount:" + salesListDisplay.SelectedRows[0].Cells[3].Value.ToString(), new Font("century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("CodeSpace", new Font("century Gothic", 20, FontStyle.Italic), Brushes.Red, new Point(270,220));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void ProductCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
                Con.Open();
                String query = "select ProductName,ProductPrice from ProductTables1 where ProductCat = '" + ProductCat.SelectedValue.ToString() + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                var Data = new DataSet();
                adapter.Fill(Data);
                salesDisplay.DataSource = Data.Tables[0];
                Con.Close();
           
        }

       

        private void label8_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void attendantNameLable_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
