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
    public partial class Main : Form
    {
        private Programa prog;
        private allMovies allm;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void programa_Click(object sender, EventArgs e)
        {
            prog = new Programa();
            //prog.MdiParent = this;
            prog.Show();
            
        }

        private void allmovies_Click(object sender, EventArgs e)
        {
            allm = new allMovies();
            allm.Show();
        }
    }
}
