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
    }
}
