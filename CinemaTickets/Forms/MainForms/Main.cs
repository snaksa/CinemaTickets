using System;
using CinemaTickets.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CinemaTickets.Forms
{
    public partial class Main : Form
    {
        private Programa prog;
        private allMovies allm;
        List<Movie> movies;
        public Main()
        {
            InitializeComponent();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.get6Records();

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

        
        private void get6Records()
        {

            Image img = Image.FromFile("C:\\Users\\umruk\\Documents\\GitHub\\CinemaTickets\\CinemaTickets\\Recources\\icons8-unavailable-filled-50.png");
            movies = MovieRepository.GetLast6();

            if(movies[0].Title == "" )
            {
                movie1picture.Image = img;
            } 
            else
            {
                movie1picture.ImageLocation = movies[0].imgurl;
                movie1name.Text = movies[0].Title;
            }

            if (movies[1].Title == "")
            {
                movie2picture.Image = img;
            }
            else
            {
                movie2picture.ImageLocation = movies[1].imgurl;
                movie2name.Text = movies[1].Title;
            }

            if (movies[2].Title == "")
            {
                movie3picture.Image = img;
            }
            else
            {
                movie3picture.ImageLocation = movies[2].imgurl;
                movie3name.Text = movies[2].Title;
            }

            /*
            if (movies[3].Title == "")
            {
                movie4picture.Image = img;
            }
            else
            {
                movie4picture.ImageLocation = movies[3].imgurl;
                movie4name.Text = movies[3].Title;
            }
            
            if (movies[4].Title == "")
            {
                movie5picture.Image = img;
            }
            else
            {
                movie5picture.ImageLocation = movies[4].imgurl;
                movie5name.Text = movies[4].Title;
            }
            if (movies[5].Title == "")
            {
                movie6picture.Image = img;
            }
            else
            {
                movie6picture.ImageLocation = movies[5].imgurl;
                movie6name.Text = movies[5].Title;
            }
            */

        }
    }
}
