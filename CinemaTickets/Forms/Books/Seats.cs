using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using CinemaTickets.Models;
using CinemaTickets.Forms.Books;

namespace CinemaTickets.Forms
{
    public partial class Seats : Form
    {
        private List<Label> seats;
        private int seatsCount = 0;
        private int maxSeats = 0;
        private List<int> selectedSeats;
        private int projectionId;
        private SelectedSeats sCount;

        public Seats(int projectionId, SelectedSeats selected)
        {
            InitializeComponent();
            this.maxSeats = selected.Sum();
            this.projectionId = projectionId;
            sCount = selected;


            this.seats = new List<Label>();
            this.selectedSeats = new List<int>();

            Projection projection = ProjectionRepository.Get(projectionId);

            // screen
            Label screen = new Label();
            screen.BackColor = System.Drawing.SystemColors.ControlLight;
            screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            screen.Location = new System.Drawing.Point(20, 25);
            screen.Size = new System.Drawing.Size(560, 5);
            this.Controls.Add(screen);

            List<Seat> seats = SeatRepository.GetByProjection(projectionId);

            bool[] a = new bool[400];
            for (int i = 0; i < 400; i++) a[i] = true;
            foreach (Seat seat in seats)
            {
                a[seat.Position] = false;
            }

            // seats
            int x = 30;
            int y = 50;
            int count = 0;
            for(int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (j == 10) x += 40;

                    Label lb = new Label();
                    lb.BackColor = a[count] ? System.Drawing.SystemColors.ActiveCaption : System.Drawing.SystemColors.ControlDark;
                    lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lb.Location = new System.Drawing.Point(x + j * 25, y + i * 25);
                    lb.Size = new System.Drawing.Size(20, 20);
                    lb.Tag = count;

                    if (a[count])
                    {
                        lb.Cursor = Cursors.Hand;
                        lb.Click += (object sender, EventArgs e) => this.handleSeatClick(sender, e);
                    }

                    this.Controls.Add(lb);
                    this.seats.Add(lb);
                    count++;
                }
                x = 30;
            }
        }

        private void handleSeatClick(object sender, EventArgs e)
        {
            Label lb = (Label) sender;
            int index = Int32.Parse(lb.Tag.ToString());

            if(this.seats[index].BackColor == System.Drawing.SystemColors.Desktop)
            {
                this.seatsCount--;
                this.seats[index].BackColor = System.Drawing.SystemColors.ActiveCaption;
                this.selectedSeats.Remove(index);
            }
            else
            {
                if(this.seatsCount == this.maxSeats) return;
                else
                {
                    this.seats[index].BackColor = System.Drawing.SystemColors.Desktop;
                    this.selectedSeats.Add(index);
                    this.seatsCount++;
                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(this.seatsCount != this.maxSeats)
            {
                MessageBox.Show("Моля изберете " + this.maxSeats + " места!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Tickets tickets = new Tickets(this.selectedSeats, this.sCount, this.projectionId);
            tickets.Show();
            this.Hide();
        }
    }
}
