using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Login
{
    public partial class EDIT_FILM : Form
    {
         
       

        public EDIT_FILM(string title)
        {
            InitializeComponent();
       
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            // Create a Film object (e.g., Spiderman film)
            Film guardianFilm = new Film
            {
                Title = "Guardian of the Galaxy",
                Genre = "Action/Adventure",
                Director = "James Gunn",
                Duration = "2h 2m",
                Poster = pictureBoxGuardian.Image // Set initial poster image
            };

            // Pass the Film object to the EDIT_FILM_1 form
            EDIT_FLM_2 edit1 = new EDIT_FLM_2(guardianFilm);
            edit1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a Film object (e.g., Spiderman film)
            Film northmanFilm = new Film
            {
                Title = "The Northman",
                Genre = "Action/Adventure",
                Director = "James Gunn",
                Duration = "2h 2m",
                Poster = pictureBoxNorthman.Image // Set initial poster image
            };

            // Pass the Film object to the EDIT_FILM_1 form
            EDIT_FILM_3 edit1 = new EDIT_FILM_3(northmanFilm);
            edit1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a Film object (e.g., Spiderman film)
            Film artemisFilm = new Film
            {
                Title = "The Northman",
                Genre = "Action/Adventure",
                Director = "James Gunn",
                Duration = "2h 2m",
                Poster = pictureBoxNorthman.Image // Set initial poster image
            };

            // Pass the Film object to the EDIT_FILM_1 form
            EDIT_FILM4 edit1 = new EDIT_FILM4(artemisFilm);
            edit1.Show();
            this.Hide();
        }

        private void btnFilm1_Click(object sender, EventArgs e)
        {
            // Create a Film object (e.g., Spiderman film)
            Film spidermanFilm = new Film
            {
                Title = "Spiderman",
                Genre = "Action",
                Director = "Jon Watts",
                Duration = "2h 30m",
                Poster = pictureBoxSpiderman.Image // Set initial poster image
            };

            // Pass the Film object to the EDIT_FILM_1 form
            EDIT_FILM_1 edit1 = new EDIT_FILM_1(spidermanFilm);
            edit1.Show();
            this.Hide();
        }

        private void pictureBoxFowl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PictureBox Clicked!"); // Untuk memastikan event ini dipanggil
            // Pastikan bahwa ini adalah form Menu yang memanggil
            Menu parentMenuForm = this.Owner as Menu; // Mendapatkan referensi form Menu (Owner)
            if (parentMenuForm != null)
            {
                // Kirim referensi form Menu ke konstruktor EDIT_FILM_1
                EDIT_FILM4 editFilm4Form = new EDIT_FILM4(parentMenuForm);
                editFilm4Form.Show();
                this.Hide(); // Sembunyikan form EDIT_FILM setelah membuka form baru
            }
        }

        private void EDIT_FILM_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxSpiderman_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PictureBox Clicked!"); // Untuk memastikan event ini dipanggil
            // Pastikan bahwa ini adalah form Menu yang memanggil
            Menu parentMenuForm = this.Owner as Menu; // Mendapatkan referensi form Menu (Owner)
            if (parentMenuForm != null)
            {
                // Kirim referensi form Menu ke konstruktor EDIT_FILM_1
                EDIT_FILM_1 editFilm1Form = new EDIT_FILM_1(parentMenuForm);
                editFilm1Form.Show();
                this.Hide(); // Sembunyikan form EDIT_FILM setelah membuka form baru
            }
        }

        private void pictureBoxGuardian_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PictureBox Clicked!"); // Untuk memastikan event ini dipanggil
            // Pastikan bahwa ini adalah form Menu yang memanggil
            Menu parentMenuForm = this.Owner as Menu; // Mendapatkan referensi form Menu (Owner)
            if (parentMenuForm != null)
            {
                // Kirim referensi form Menu ke konstruktor EDIT_FILM_1
                EDIT_FLM_2 editFilm2Form = new EDIT_FLM_2(parentMenuForm);
                editFilm2Form.Show();
                this.Hide(); // Sembunyikan form EDIT_FILM setelah membuka form baru
            }
        }

        private void pictureBoxNorthman_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PictureBox Clicked!"); // Untuk memastikan event ini dipanggil
            // Pastikan bahwa ini adalah form Menu yang memanggil
            Menu parentMenuForm = this.Owner as Menu; // Mendapatkan referensi form Menu (Owner)
            if (parentMenuForm != null)
            {
                // Kirim referensi form Menu ke konstruktor EDIT_FILM_1
                EDIT_FILM_3 editFilm3Form = new EDIT_FILM_3(parentMenuForm);
                editFilm3Form.Show();
                this.Hide(); // Sembunyikan form EDIT_FILM setelah membuka form baru
            }
        }
    }
}
