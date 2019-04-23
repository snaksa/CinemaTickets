using System;
using CinemaTickets.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CinemaTickets.Forms.MainForms;

namespace CinemaTickets.Forms
{
    public partial class Main : Form
    {
        private devLogIn dlogin;
        private Programa prog;
        private allMovies allm;
        private int genreId = 0;

        List<Label> movieLabels;
        List<Label> movieLabelsMore;
        List<PictureBox> moviePictues;
        List<Movie> allMovies;

        public Main()
        {
            InitializeComponent();
            movieLabels = new List<Label>();
            movieLabelsMore = new List<Label>();
            moviePictues = new List<PictureBox>();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            this.setMovies(MovieRepository.GetAll(true));

            List<Genre> genres = GenreRepository.GetAll();
            comboBoxGenres.Items.Add(new GenreOption(0, "Всички"));
            foreach (Genre genre in genres)
            {
                comboBoxGenres.Items.Add(new GenreOption(genre.Id, genre.Name));
            }

        }

        private void comboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            GenreOption genre = (GenreOption)comboBox.SelectedItem;
            this.genreId = genre.Id;
            setMovies(MovieRepository.GetAll(true, genre.Id));
            button1.Visible = true;
            this.Size = new System.Drawing.Size(1013, 526);
            searchTextBox.Text = "";
        }

        private void setMovies(List<Movie> movies)
        {
            foreach (Label label in this.movieLabels)
                this.Controls.Remove(label);

            foreach (PictureBox pb in this.moviePictues)
                this.Controls.Remove(pb);
            
            this.allMovies = movies;

            int y = 225;
            int x = -1;
            for (int i = 0; i < movies.Count; i++)
            {
                x++;
                if(i != 0 && i % 6 == 0)
                {
                    y += 210;
                    x = 0;
                }

                PictureBox pb = new PictureBox();
                pb.Location = new System.Drawing.Point(16 + x * 150, y);
                pb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                pb.Size = new System.Drawing.Size(133, 203);
                pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pb.TabIndex = 7;
                pb.TabStop = false;
                pb.Image = Image.FromFile(@"Images\loader.gif");
                pb.ImageLocation = movies[i].ImgUrl;
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.Cursor = Cursors.Hand;
                pb.Tag = i;
                pb.Click += (object sender, EventArgs e) => this.handlePictureClick(sender, e);
                
                
                this.Controls.Add(pb);
                this.moviePictues.Add(pb);
            }
        }

        private void handlePictureClick(object sender, EventArgs e)
        {
            int index = 0;

            if (sender is PictureBox)
            {
                PictureBox pb = (PictureBox)sender;
                index = Int32.Parse(pb.Tag.ToString());
            }
            else
            {
                Label lb = (Label)sender;
                index = Int32.Parse(lb.Tag.ToString());
            }

            int id = this.allMovies[index].Id;

            SingleMovie sm = new SingleMovie(id);
            sm.Show();
        }

        private void devMode_Click(object sender, EventArgs e)
        {

            dlogin = new devLogIn();
            dlogin.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            this.Size = new System.Drawing.Size(1013, 700);
            this.setMovies(MovieRepository.GetAll(false, this.genreId));
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Movie> movies =MovieRepository.GetAll(false, this.genreId, searchTextBox.Text);
            this.setMovies(movies);
            button1.Visible = false;
            if(movies.Count > 6)
            {
                this.Size = new System.Drawing.Size(1013, 700);
            }
            else
            {
                this.Size = new System.Drawing.Size(1013, 526);
            }
        }
    }
}
