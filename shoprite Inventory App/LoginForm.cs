using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoprite_Inventory_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void emailLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameTb.Text == "" || passwordTb.Text == "")
            {
                MessageBox.Show("Enter the username and password");
            }
            else
            {   if (selectRole.SelectedIndex > -1)
                {

                    if (selectRole.SelectedItem.ToString() == "ADMIN")
                    {
                        if(usernameTb.Text == "ADMIN" && passwordTb.Text == "ADMIN")
                        {
                            ProductsForm productsForm = new ProductsForm();
                            productsForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username and Password do not match");
                        }
                    }
                    else if (selectRole.SelectedItem.ToString() == "ATTENDANT")
                    {
                        MessageBox.Show("you are a seller");
                    }
                }
                else
                {
                    MessageBox.Show("Select a role");
                }
            }
        }

        private void signupLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
