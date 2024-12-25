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
    public partial class EDIT_FILM_1 : Form
    {
        private Menu edit1; // Menyimpan referensi form Menu
        // Konstruktor dengan parameter Menu
        public EDIT_FILM_1(Menu edit1)
        {
            InitializeComponent();
            this.edit1 = edit1; // Menyimpan referensi form Menu
        }

        private void txtJudul_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGenre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDurasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSutradara_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Ambil data dari form EDIT_FILM_1
            string judul = txtJudul.Text;
            string genre = txtGenre.Text;
            string durasi = txtDurasi.Text;
            string sutradara = txtSutradara.Text;
            Image gambar = pictureBox1.Image;
            // Kirim data ke form Menu untuk diupdate
            edit1.UpdateSpidermanFilmDetails(judul, durasi, sutradara, genre, gambar);
            edit1.UpdateSpidermanPicture(gambar);
            // Tampilkan pesan sukses
            MessageBox.Show("Data film berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Tutup form EDIT_FILM_1 setelah update
            this.Close();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EDIT_FILM_1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
