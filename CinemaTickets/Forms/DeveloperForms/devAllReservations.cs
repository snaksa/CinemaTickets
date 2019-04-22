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
    public partial class devAllReservations : Form
    {
        List<Movie> movies;
        public devAllReservations()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*
        private void getRecords()
        {
            using (SqlConnection con = new SqlConnection(CinemaTickets.connectionString))
            {
                con.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(
                     "SELECT c.id as ID, c.regNumber as 'Рег. номер', b.name as 'Марка', m.name as 'Модел', "
                    + "c.year as 'Година', c.engineNumber as 'Номер на двигател', c.frameNumber as 'Номер на рама', col.name as 'Цвят', c.engineVolume as 'Обем на двигателя', "
                    + "c.description as 'Описание', c.ownerName as 'Собственик', c.contactNumber as 'Телефон' FROM cars c "
                    + "LEFT JOIN models m ON m.id = c.modelId "
                    + "LEFT JOIN brands b ON b.id = m.brandId "
                    + "LEFT JOIN colors col ON col.id = c.colorId "
                    , con))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    carsDataGridView.DataSource = table;
                }
            }
        }
        */
    }
}
