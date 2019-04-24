using CinemaTickets.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTickets.Forms.DeveloperForms
{
    public partial class devAllReservations : Form
    {


        public devAllReservations()
        {

            InitializeComponent();
            this.getRecords();
        }


        private void OnFormClose(object sender, EventArgs e)
        {
            this.getRecords();
        }

        private void getRecords()
        {
            using (SqlConnection con = new SqlConnection(MovieRepository.connectionString))
            {
                con.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT r.id, p.id, rr.name, m.title," +
                    "p.time, mt.name " +
                    "FROM reservations r " +
                    "LEFT JOIN projections p ON p.id = r.projection_id " +
                    "LEFT JOIN rooms rr ON p.room_id = rr.id " +
                    "LEFT JOIN movies m ON p.movie_id = m.id " +
                    "LEFT JOIN movie_types mt ON p.movie_type_id = mt.id"
                   
                   
                   
      
                    , con))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);


                    allReservationGrid.DataSource = table;

                }
            }
        }

        private void delReservations_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да изтриете записа?", "Изтриване?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int index = allReservationGrid.SelectedCells.Count > 0 ? allReservationGrid.SelectedCells[0].RowIndex : -1;
                index = index != -1 ? Int32.Parse(allReservationGrid.Rows[index].Cells[0].Value.ToString()) : 0;
               // TicketRepository.RemoveByReservation(index);
               // SeatRepository.RemoveByReservation(index);
               // ReservationRepository.Remove(index);
                this.getRecords();
            }
        }
    }
}
