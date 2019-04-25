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

namespace CinemaTickets.Forms.DeveloperForms
{
    public partial class devSingleMovie : Form
    {
        int id = 0;
        List<Genre> genres;
        List<Category> categories;
        public devSingleMovie(int id = 0)
        {

            InitializeComponent();
            //this.hideErrors();

            Movie movie = null;
            if (id != 0)
            {
                this.id = id;
                movie = MovieRepository.Get(id);
            }

            categories = CategoryRepository.GetAll();
            foreach (Category c in categories)
                categoriesComboBox.Items.Add(c.Name);


            genres = GenreRepository.GetAll();
            foreach (Genre g in genres)
                genresComboBox.Items.Add(g.Name);



            if (movie != null)
            {
                titleTextBox.Text = movie.Title;
                subTitleTextBox.Text = movie.Subtitle;
                descriptionTextBox.Text = movie.Description;
                producerTextBox.Text = movie.Producer;
                durationTextBox.Text = movie.Duration.ToString();
                actorsTextBox.Text = movie.Actors;
                posterUrlTextBox.Text = movie.ImgUrl;
                trailerUrlTextBox.Text = movie.TrailerUrl;

                categoriesComboBox.Text = movie.Category != null ? movie.Category.Name : "";
                genresComboBox.Text = movie.Genre != null ? movie.Genre.Name : "";
            }
            else
            {

                categoriesComboBox.Text = this.categories.Count > 0 ? this.categories[0].Name : "";
                genresComboBox.Text = this.genres.Count > 0 ? this.genres[0].Name : "";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            if(titleTextBox.Text.Length <= 0)
            {
                error = true;
            }       
             if(subTitleTextBox.Text.Length <= 0)
            {
                error = true;
            }
            
              if(subTitleTextBox.Text.Length <=0)
            {
                error = true;
            }
              if(descriptionTextBox.Text.Length <= 0)
            {
                error = true;
            }
            if (durationTextBox.Text.Length <= 0)
            {
                error = true;
            }
            if (actorsTextBox.Text.Length <= 0)
            {
                error = true;
            }
            if (posterUrlTextBox.Text.Length <= 0)
            {
                error = true;
            }
            if (trailerUrlTextBox.Text.Length <= 0)
            {
                error = true;
            }
            if(error == true)
            {
                MessageBox.Show("Въведете данни", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Movie m = new Movie(this.id, posterUrlTextBox.Text, titleTextBox.Text,
                    subTitleTextBox.Text, descriptionTextBox.Text, trailerUrlTextBox.Text,
                    this.categories[categoriesComboBox.SelectedIndex],
                    this.genres[genresComboBox.SelectedIndex], Int32.Parse(durationTextBox.Text),
                    producerTextBox.Text, actorsTextBox.Text);

                if (m.Id == 0) MovieRepository.Add(m);
                else MovieRepository.Update(m);

                this.Close();
            }
        }
    }
    }
    

