using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaTickets.Models;
using CinemaTickets.Forms;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace CinemaTickets.Forms
{
    public partial class devAllMovies : Form
    {
        public devAllMovies()
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
               
                using (SqlDataAdapter adapter = new SqlDataAdapter(
                     "SELECT  m.id as 'Номер',m.imgurl as 'Постер ', m.title as 'Заглавие ', m.subtitle as 'Подзаглавие', m.description as 'Описание', m.trailer_url as 'Трейлър'," +
                    "g.name as 'Жанр', c.name as 'Категория', m.duration as 'Времетраене', m.producer as 'Продуцент', m.actors as 'Актьори' " +
                    "FROM movies m " +
                    "LEFT JOIN categories c ON c.id = m.category_id " +
                    "LEFT JOIN genres g ON g.id = m.genre_id ",con))
                
                    {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    
                   
                    dataGridAllMovies.DataSource = table;
                    
                    
                    
                }
            }
        }

        private void addMovie_Click(object sender, EventArgs e)
        {
           DeveloperForms.devSingleMovie form = new DeveloperForms.devSingleMovie();
           form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
           form.Show();
        }

        private void editMovie_Click(object sender, EventArgs e)
        {
            int index = dataGridAllMovies.SelectedCells.Count > 0 ? dataGridAllMovies.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(dataGridAllMovies.Rows[index].Cells[0].Value.ToString()) : 0;
            DeveloperForms.devSingleMovie form = new DeveloperForms.devSingleMovie(index);
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void remMovie_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да изтриете записа?", "Изтриване?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int index = dataGridAllMovies.SelectedCells.Count > 0 ? dataGridAllMovies.SelectedCells[0].RowIndex : -1;
                index = index != -1 ? Int32.Parse(dataGridAllMovies.Rows[index].Cells[0].Value.ToString()) : 0;
                MovieRepository.Remove(index);
                this.getRecords();
            }
        }
        public static Image GetImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            // if you have proxy server, you may need to set proxy details like below 
            //httpWebRequest.Proxy = new WebProxy("proxyserver",port){ Credentials = new NetworkCredential(){ UserName ="uname", Password = "pw"}};

            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }

        private void dataGridAllMovies_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
