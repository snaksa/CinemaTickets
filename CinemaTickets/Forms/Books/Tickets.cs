using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CinemaTickets.Models;

namespace CinemaTickets.Forms.Books
{
    public partial class Tickets : Form
    {
        private List<int> seats;
        private SelectedSeats selectedCount;
        private Projection projection;
        public Tickets(List<int> seats, SelectedSeats sCount, int projectionId)
        {
            InitializeComponent();

            Projection projection = ProjectionRepository.Get(projectionId);
            this.projection = projection;
            this.seats = seats;
            this.selectedCount = sCount;

            moviePicture.ImageLocation = projection.Movie.ImgUrl;
            moviePicture.BorderStyle = BorderStyle.FixedSingle;
            moviePicture.Image = Image.FromFile(@"Images\loader.gif");

            movieTitle.Text = projection.Movie.Title;
            projectionDate.Text = projection.Time.ToShortDateString() + " " + projection.Time.ToShortTimeString();
            projectionType.Text = projection.MovieType.Name;
            projectionRoom.Text = projection.Room.Name;
            string seatsText = "";
            for(int i = 0; i < seats.Count; i++)
                seatsText += seats[i] + (i != seats.Count - 1 ? ", " : "");

            projectionSeats.Text = seatsText;
            
            int typePrice = projection.MovieType.Price;
            int sum = sCount.Standard * typePrice;
            sum += sCount.Student * (typePrice - 3);
            sum += sCount.Elder * (typePrice - 2);

            projectionTotal.Text = sum.ToString() + "лв.";
        }

        private void projectionReserve_Click(object sender, EventArgs e)
        {
            ReservationRepository.Add(this.projection.Id);
            int resId = ReservationRepository.GetLatest();

            for(int i = 0; i < this.selectedCount.Standard; i++)
            {
                TicketRepository.Add(resId);
                int ticketId = TicketRepository.GetLatest();
                SeatRepository.Add(ticketId, seats[0]);
                seats.RemoveAt(0);
            }

            for (int i = 0; i < this.selectedCount.Student; i++)
            {
                TicketRepository.Add(resId);
                int ticketId = TicketRepository.GetLatest();
                SeatRepository.Add(ticketId, seats[0]);
                seats.RemoveAt(0);
            }

            for (int i = 0; i < this.selectedCount.Elder; i++)
            {
                TicketRepository.Add(resId);
                int ticketId = TicketRepository.GetLatest();
                SeatRepository.Add(ticketId, seats[0]);
                seats.RemoveAt(0);
            }

            MessageBox.Show("Резервацията е направена!", "Честито!");
            this.Hide();

        }
    }
}
