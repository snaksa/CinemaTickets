using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using CinemaTickets.Models;

namespace CinemaTickets.Forms.MainForms
{
    public partial class SingleMovie : Form
    {
        public SingleMovie(int id)
        {
            InitializeComponent();
            int mvID = id;
            Movie movie = MovieRepository.Get(id);
            List<Projection> projections = ProjectionRepository.GetAll(id);

            movieTitle.Text = movie.Title;
            movieSubtitle.Text = movie.Subtitle;
            movieDescription.Text = movie.Description;
            movieProducer.Text = movie.Producer;
            movieDuration.Text = movie.Duration.ToString() + " минути";
            movieActors.Text = movie.Actors;
            movieGenre.Text = movie.Genre.Name;
            string url = movie.TrailerUrl;
             
            moviePicture.ImageLocation = movie.ImgUrl;
            moviePicture.BorderStyle = BorderStyle.FixedSingle;
            moviePicture.Image = Image.FromFile(@"Images\loader.gif");
            moviePicture.MouseClick += new MouseEventHandler((o, a) => Process.Start("chrome.exe", url));


            int currentDate = 0;
            int projCount = 0;
            int dateCount = -1;
            int d2Count = 0;
            int d3Count = 0;
            foreach (Projection projection in projections)
            {
                if (currentDate == 0 || currentDate != projection.Time.Day)
                {
                    currentDate = projection.Time.Day;
                    projCount = 0;
                    dateCount++;
                    d2Count = 0;
                    d3Count = 0;

                    Label header = new Label();
                    header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    header.Location = new System.Drawing.Point(176, 345 + dateCount * 120);
                    header.ForeColor = System.Drawing.Color.White;
                    header.Padding = new System.Windows.Forms.Padding(5);
                    header.Size = new System.Drawing.Size(622, 32);
                    header.Text = this.getDayName(projection.Time) + " (" + projection.Time.ToShortDateString() + ")";
                    this.Controls.Add(header);

                    Label type2 = new Label();
                    type2.AutoSize = false;
                    type2.BackColor = System.Drawing.Color.Black;
                
                    type2.ForeColor = System.Drawing.Color.White;
                    type2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    type2.Location = new System.Drawing.Point(176, 380 + dateCount * 125);
                    type2.Padding = new System.Windows.Forms.Padding(5);
                    type2.Size = new System.Drawing.Size(40, 29);
                    type2.Text = "2D";
                    type2.Tag = projection.Id;

                    Label type3 = new Label();
                    type3.AutoSize = false;
                    type3.BackColor = System.Drawing.Color.Black;
                    type3.ForeColor = System.Drawing.Color.White;
                    type3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    type3.Location = new System.Drawing.Point(176, 380 + dateCount * 125 + 35);
                    type3.Padding = new System.Windows.Forms.Padding(5);
                    type3.Size = new System.Drawing.Size(40, 29);
                    type3.Text = "3D";
                    type3.Tag = projection.Id;

                    this.Controls.Add(type2);
                    this.Controls.Add(type3);
                    
                }

               

                bool d2 = projection.MovieType.Name == "2D" ? true : false;
                int c = projection.MovieType.Name == "2D" ? d2Count : d3Count;
                if (d2) d2Count++;
                else d3Count++;

                Label time = new Label();
                time.AutoSize = false;
                time.Cursor = Cursors.Hand;
                time.BackColor = System.Drawing.Color.DarkCyan;
                time.ForeColor = System.Drawing.Color.White;
                time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                time.Location = new System.Drawing.Point(220 + c * 60, 380 + dateCount * 125 + (d2 ? 0 : 35));
                time.Padding = new System.Windows.Forms.Padding(5);
                time.Size = new System.Drawing.Size(56, 29);
                time.Text = projection.Time.ToShortTimeString();
                time.Tag = projection.Id;
                time.Click += (object sender, EventArgs e) => this.handleClickProjection(sender, e);

                this.Controls.Add(time);
                projCount++;
            }
        }

        private void handleClickProjection(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            int index = Int32.Parse(lb.Tag.ToString());
            Book book = new Book(index);
            book.Show();
            this.Hide();
        }

        private string getDayName(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Monday) return "Понеделник";
            if (date.DayOfWeek == DayOfWeek.Tuesday) return "Вторник";
            if (date.DayOfWeek == DayOfWeek.Wednesday) return "Сряда";
            if (date.DayOfWeek == DayOfWeek.Thursday) return "Четвъртък";
            if (date.DayOfWeek == DayOfWeek.Friday) return "Петък";
            if (date.DayOfWeek == DayOfWeek.Saturday) return "Събота";
            if (date.DayOfWeek == DayOfWeek.Sunday) return "Неделя";

            return date.DayOfWeek.ToString();
        }

        
    }
}
