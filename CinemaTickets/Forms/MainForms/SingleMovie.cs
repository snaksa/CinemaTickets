using System;
using System.Collections.Generic;
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

            Movie movie = MovieRepository.Get(id);
            List<Projection> projections = ProjectionRepository.GetAll(id);

            movieTitle.Text = movie.Title;
            movieSubtitle.Text = movie.Subtitle;
            movieDescription.Text = movie.Description;
            movieProducer.Text = movie.Producer;
            movieDuration.Text = movie.Duration.ToString() + " минути";
            movieActors.Text = movie.Actors;
            movieGenre.Text = movie.Genre.Name;

            moviePicture.ImageLocation = movie.ImgUrl;
            moviePicture.BorderStyle = BorderStyle.FixedSingle;
            moviePicture.Image = Image.FromFile(@"Images\loader.gif");

            int currentDate = 0;
            int projCount = 0;
            int dateCount = -1;
            foreach (Projection projection in projections)
            {
                if (currentDate == 0 || currentDate != projection.Time.Day)
                {
                    currentDate = projection.Time.Day;
                    projCount = 0;
                    dateCount++;

                    Label header = new Label();
                    header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    header.Location = new System.Drawing.Point(176, 345 + dateCount * 90);
                    header.Padding = new System.Windows.Forms.Padding(5);
                    header.Size = new System.Drawing.Size(622, 32);
                    header.Text = this.getDayName(projection.Time) + " (" + projection.Time.ToShortDateString() + ")";
                    this.Controls.Add(header);
                }

                Label time = new Label();
                time.AutoSize = false;
                time.Cursor = Cursors.Hand;
                time.BackColor = System.Drawing.SystemColors.AppWorkspace;
                time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                time.Location = new System.Drawing.Point(176 + projCount * 60, 380 + dateCount * 90);
                time.Padding = new System.Windows.Forms.Padding(5);
                time.Size = new System.Drawing.Size(56, 29);
                time.Text = projection.Time.TimeOfDay.ToString();
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
