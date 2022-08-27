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

        private void SalesForm_Load(object sender, EventArgs e)
        {
            populate();
        }

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
        private void button5_Click(object sender, EventArgs e)
        {
            int n = 0;
            int total = Convert.ToInt32(ProductQty.Text) * Convert.ToInt32(ProductPrice.Text);
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(orderDisplay);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = ProductName.Text;
            newRow.Cells[2].Value = ProductPrice.Text;
            newRow.Cells[3].Value = ProductQty.Text;
            newRow.Cells[4].Value = Convert.ToInt32(ProductQty.Text)* Convert.ToInt32(ProductPrice.Text);
            orderDisplay.Rows.Add(newRow);
            GrdTotal = GrdTotal + total;
            amountLabel.Text ="Rs"+GrdTotal;


        }
    }
}
