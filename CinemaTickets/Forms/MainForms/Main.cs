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

        private void comboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            GenreOption genre = (GenreOption)comboBox.SelectedItem;
            setMovies(MovieRepository.GetAll(true, genre.Id));

        }

        private void setMovies(List<Movie> movies)
        {
            foreach (Label label in this.movieLabels)
                this.Controls.Remove(label);

            foreach (PictureBox pb in this.moviePictues)
                this.Controls.Remove(pb);
            
            this.allMovies = movies;

            for (int i = 0; i < movies.Count; i++)
            {
                //Label lb = new Label();
                //lb.AutoSize = false;
                //lb.Location = new System.Drawing.Point(16 + i * 150, 206);
                //lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                //lb.Size = new System.Drawing.Size(46, 17);
                //lb.TabIndex = 13;
                //lb.Text = movies[i].Title;
                //lb.Tag = i;
                //lb.Cursor = Cursors.Hand;
                //lb.Click += (object sender, EventArgs e) => this.handlePictureClick(sender, e);

                PictureBox pb = new PictureBox();
                pb.Location = new System.Drawing.Point(16 + i * 150, 225);
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
                pb.MouseEnter += (object sender, EventArgs e) => this.handlePictureHover(sender, e);
                pb.MouseLeave += (object sender, EventArgs e) => this.handlePictureHover(sender, e);
                pb.Click += (object sender, EventArgs e) => this.handlePictureClick(sender, e);

                Label lbMore = new Label();
                lbMore.AutoSize = false;
                lbMore.Location = new System.Drawing.Point(35 + i * 150, 310);
                lbMore.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
                lbMore.Size = new System.Drawing.Size(98, 20);
                lbMore.TabIndex = 13;
                lbMore.Visible = false;
                lbMore.Text = "Подробности";
                lbMore.BorderStyle = BorderStyle.FixedSingle;
                lbMore.Tag = i;
                lbMore.Click += (object sender, EventArgs e) => this.handlePictureClick(sender, e);

                //this.Controls.Add(lb);
                this.Controls.Add(lbMore);
                this.Controls.Add(pb);

                //this.movieLabels.Add(lb);
                this.movieLabelsMore.Add(lbMore);
                this.moviePictues.Add(pb);
            }
        }

        private void handlePictureHover(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Label lb = this.movieLabelsMore[Int32.Parse(pb.Tag.ToString())];
            lb.Visible = !lb.Visible;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void devMode_Click(object sender, EventArgs e)
        {

            dlogin = new devLogIn();
            dlogin.Show();

        }
    }
    }
