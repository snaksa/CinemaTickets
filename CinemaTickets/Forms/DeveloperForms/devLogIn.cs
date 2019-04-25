using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaTickets.Forms;
using CinemaTickets.Forms.DeveloperForms;
using System.Windows.Forms;

namespace CinemaTickets.Forms
{
    public partial class devLogIn : Form
    {
        

        public devLogIn()
        {
            InitializeComponent();
        }

        private void devLogInButton_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "pass")

            {
                devMenuForm dmf = new devMenuForm();
                dmf.Show();
            this.Hide();
            }
            else
           {
                MessageBox.Show("Въведени са грешни данни");
            }

        }
    }
}
