using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Mail;
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
            for (int i = 0; i < seats.Count; i++)
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

            for (int i = 0; i < this.selectedCount.Standard; i++)
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
            

            string ticket =
            "Дата: " + projectionDate.Text + "\n" +
            "Филм: " + projection.Movie.Title + "\n" +
            "Тип: " + projectionType.Text + "\n" +
            "Зала: " + projectionRoom.Text + "\n" +
            "Места: " + projectionSeats.Text + "\n" +
            "Общо: " + projectionTotal.Text;


            if (emailTe.Text.Length <= 0)
            {
                this.Hide();
            }
            else
            {
                MailMessage objMailMessage = new MailMessage("kinotopoli@gmail.com", emailTe.Text, "reservation", ticket);
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("kinotopoli@gmail.com", "kinotopoli123");
                smtp.EnableSsl = true;
                smtp.Send(objMailMessage);
                this.Hide();
            }
            
           

        }

        private void emailTe_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (emailTe.Text.Length > 0)

            {

                if (!rEMail.IsMatch(emailTe.Text))

                {

                    MessageBox.Show("Очаква се валиден имейл", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    emailTe.SelectAll();

                    e.Cancel = true;
                }
            }
        }
    }
}
