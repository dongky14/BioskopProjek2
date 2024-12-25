using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{       
    public partial class EDIT_FILM4 : Form
    {        private Film film;

        public EDIT_FILM4(Film film)
        {
            InitializeComponent();
            this.film = film;

            // Populate the form fields with the film's data
            txtJudul.Text = film.Title;
            txtGenre.Text = film.Genre;
            txtDurasi.Text = film.Duration;
            txtSutradara.Text = film.Director;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the selected image as the film's poster
                film.Poster = Image.FromFile(openFileDialog.FileName);

                // Display the selected image in the PictureBox
                pictureBox1.Image = film.Poster;

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void EDIT_FILM4_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update the film data with the new values from the form
            film.Title = txtJudul.Text;
            film.Genre = txtGenre.Text;
            film.Duration = txtDurasi.Text;
            film.Director = txtSutradara.Text;

            // Optionally, update the film's poster if the user selects a new image
            // film.Poster = newPosterImage;

            // After updating, close the form and return to the Menu form
            Menu menuForm = new Menu(isAdmin: true);
            menuForm.UpdateArtemisFilmDetails(film); // Update the Menu form with the updated film
            menuForm.Show();
            this.Close();
        }
    }
}
