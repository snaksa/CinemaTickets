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
using System.Globalization;

namespace CinemaTickets.Forms.DeveloperForms
{
    public partial class devSingleProjection : Form
    {
        int id = 0;
        List<Movie> movies;
        List<MovieType> mvtypes;
        List<Room> rooms;
        public devSingleProjection(int id = 0)
        {
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "d-MM-yyyy HH:mm";
            Projection projection = null;
            if (id != 0)
            {
                this.id = id;
                projection = ProjectionRepository.Get(id);
            }

            movies = MovieRepository.GetAll();
            foreach (Movie m in movies)
               moviesComboBox.Items.Add(m.Title);


            mvtypes = MovieTypeRepository.GetAll();
            foreach (MovieType mv in mvtypes)
                MovieTypesComboBox.Items.Add(mv.Name);

            rooms = RoomRepository.GetAll();
            foreach (Room r in rooms)
                RoomComboBox.Items.Add(r.Name);



            if (projection != null)
            {
                dateTimePicker.Text = projection.Time.ToString();

                moviesComboBox.Text = projection.Movie != null ? projection.Movie.Title : "";
                MovieTypesComboBox.Text = projection.MovieType != null ? projection.MovieType.Name : "";
                RoomComboBox.Text = projection.Room != null ? projection.Room.Name : "";
            }
            else
            {
                moviesComboBox.Text = this.movies.Count > 0 ? this.movies[0].Title : "";
                MovieTypesComboBox.Text = this.mvtypes.Count > 0 ? this.mvtypes[0].Name : "";
                RoomComboBox.Text = this.rooms.Count > 0 ? this.rooms[0].Name : "";
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            

            Projection p = new Projection(this.id,this.movies[moviesComboBox.SelectedIndex],
                    this.mvtypes[MovieTypesComboBox.SelectedIndex],
                    this.rooms[RoomComboBox.SelectedIndex],dateTimePicker.Value);

                if (p.Id == 0) ProjectionRepository.Add(p);
                else ProjectionRepository.Update(p);

                this.Close();
            
        }
    }
}
