using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTickets.Forms
{
    public partial class Movie : Form
    {
        private s bk;
        public Movie()
        {
            InitializeComponent();
        }

        private void book_Click(object sender, EventArgs e)
        {
            bk = new s();
            bk.Show();
        }
    }
}
