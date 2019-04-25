using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTickets.Forms.DeveloperForms
{
    public partial class devMenuForm : Form
    {
        public devMenuForm()
        {
            InitializeComponent();
        }

        private void moviesButton_Click(object sender, EventArgs e)
        {
            devAllMovies dallm = new devAllMovies();
            dallm.Show();
        }

        private void projectionButton_Click(object sender, EventArgs e)
        {
            devAllProjections devAll = new devAllProjections();
            devAll.Show();
        }


    }
}

