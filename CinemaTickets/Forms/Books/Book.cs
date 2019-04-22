using System;
using System.Collections.Generic;
using CinemaTickets.Models;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTickets.Forms
{
    public partial class Book : Form
    {
        int projectionId;
        //List<Projection> projections;
        public Book(int projectionId)
        {
            this.projectionId = projectionId;
            InitializeComponent();
            Projection projection = ProjectionRepository.Get(projectionId);

            moviePicture.ImageLocation = projection.Movie.ImgUrl;
            moviePicture.BorderStyle = BorderStyle.FixedSingle;
            moviePicture.Image = Image.FromFile(@"Images\loader.gif");

            movieTitle.Text = projection.Movie.Title;
        }

        private void seats_Click(object sender, EventArgs e)
        {
            int standard = (int) ticketStandard.Value;
            int elder = (int) ticketElder.Value;
            int student = (int) ticketStudent.Value;
            SelectedSeats selected = new SelectedSeats(standard, elder, student);
            Seats seats = new Seats(this.projectionId, selected);
            seats.Show();
        }
    }
}
