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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint  += 1;
            loading.Value = startpoint;

            if(loading.Value == 100)
            {
                loading.Value = 0;
                timer1.Stop();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }


        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void loading_Click(object sender, EventArgs e)
        {

        }
    }
}
