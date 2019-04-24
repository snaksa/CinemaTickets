using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaTickets.Models;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CinemaTickets.Forms.DeveloperForms
{
    public partial class devAllProjections : Form
    {

        public devAllProjections()
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

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT p.id as 'Номер', m.imgurl as 'Постер', m.title as 'Заглавие'," +
                    "c.name as 'Подзаглавие', g.name as 'Жанр', m.duration as 'Времетраене', " +
                    "t.name as 'Тип', r.name as 'Зала', p.time as 'Време' " +
                    "FROM projections p " +
                    "LEFT JOIN movies m ON m.id = p.movie_id " +
                    "LEFT JOIN movie_types t ON t.id = p.movie_type_id " +
                    "LEFT JOIN rooms r ON r.id = p.room_id " +
                    "LEFT JOIN categories c ON c.id = m.category_id " +
                    "LEFT JOIN genres g ON g.id = m.genre_id "
                    , con))
                {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                       
                        reservationDataGrid.DataSource = table;
                   
                }
            }
        }

        private void addReservation_Click(object sender, EventArgs e)
        {
            devSingleProjection form = new devSingleProjection();
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void editReservation_Click(object sender, EventArgs e)
        {
            int index = reservationDataGrid.SelectedCells.Count > 0 ? reservationDataGrid.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(reservationDataGrid.Rows[index].Cells[0].Value.ToString()) : 0;
            devSingleProjection form = new devSingleProjection(index);
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void remReservation_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да изтриете записа?", "Изтриване?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int index = reservationDataGrid.SelectedCells.Count > 0 ? reservationDataGrid.SelectedCells[0].RowIndex : -1;
                index = index != -1 ? Int32.Parse(reservationDataGrid.Rows[index].Cells[0].Value.ToString()) : 0;
                ProjectionRepository.Remove(index);
                this.getRecords();
            }
        }
    }
}
