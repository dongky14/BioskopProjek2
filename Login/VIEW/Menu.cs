using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{

    public partial class Menu : Form
    {
        private Film spidermanFilm;
        private Film guardianFilm;
        private Film northmanFilm;
        private Film artemisFilm;
        bool sidebarexpand;

     
        private bool isAdmin; // Variabel untuk menyimpan status admin

        public Menu(bool isAdmin = true) // Tambahkan nilai default
        {
            InitializeComponent();
            this.isAdmin = isAdmin; // Tetapkan status admin

            // Initialize the Spiderman film data
            spidermanFilm = new Film
            {
                Title = "Spiderman",
                Genre = "Action",
                Director = "Jon Watts",
                Duration = "2h 30m",
                Poster = pictureBoxSpiderman.Image // Set initial poster image
            };
            guardianFilm = new Film
            {
                Title = "Guardian of the Galaxy",
                Genre = "Action/Adventure",
                Director = "James Gunn",
                Duration = "2h 2m",
                Poster = pictureBoxGuardian.Image // Set initial poster image
            };
            northmanFilm = new Film
            {
                Title = "THE NORTHMAN",
                Genre = "Action/Adventure",
                Director = "James Gunn",
                Duration = "2h 2m",
                Poster = pictureBoxNorthman.Image // Set initial poster image
            };
            artemisFilm = new Film
            {
                Title = "Artemis Fowl",
                Genre = "Action/Adventure",
                Director = "James Gunn",
                Duration = "2h 2m",
                Poster = pictureBoxFowl.Image // Set initial poster image
            };
        }

       

        // In EDIT_FILM.cs
        


        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarexpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarexpand = true;
                    sidebarTimer.Stop();
                }
            }

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.TabStop = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnEditFilm.FlatStyle = FlatStyle.Flat;
            btnEditFilm.FlatAppearance.BorderSize = 0;
            btnEditFilm.TabStop = false;
            EDIT_FILM editFilmForm = new EDIT_FILM(); // Kirim referensi form Menu
            editFilmForm.Show();


        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
          
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.TabStop = false;

            ListViewItem listItem = new ListViewItem(OrderData.MovieTitle);
            listItem.SubItems.Add(OrderData.Studio);
            listItem.SubItems.Add(OrderData.ShowTime);
            listItem.SubItems.Add(OrderData.Date);
            listItem.SubItems.Add(OrderData.SeatNumber);
            listItem.SubItems.Add(OrderData.TicketCount.ToString());
            listItem.SubItems.Add(OrderData.TotalPrice);

            // Buka Form History dan kirim data ke ListView
            History historyForm = new History();
            historyForm.AddItemToListView(listItem);
            historyForm.Show();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Sembunyikan tombol jika bukan admin
            if (!isAdmin)
            {
                btnHistory.Visible = false; // Sembunyikan tombol History
                btnEditFilm.Visible = false; // Sembunyikan tombol Edit Film
            }
        }

        private void pictureBoxSpiderman_Click(object sender, EventArgs e)
        {
            FILM1 detailSpider = new FILM1();
            detailSpider.Show();
            this.Hide(); // 
        }
        public void UpdateSpidermanFilmDetails(Film updatedFilm)
        {
             // Update the Spiderman film data with the new values
                spidermanFilm = updatedFilm;

                // Update the picture box with the new poster image
                pictureBoxSpiderman.Image = updatedFilm.Poster;

                // Update any labels or other UI elements with the updated film data
                lblFilmTitle.Text = updatedFilm.Title;
                lblFilmGenre.Text = updatedFilm.Genre;
                lblFilmDuration.Text = updatedFilm.Duration;
                lblSutradara.Text = updatedFilm.Director;

            // Update the Spiderman film data with the new values
            spidermanFilm = updatedFilm;

           
        }
        public void UpdateGuardianFilmDetails(Film updatedFilm)
        {
            lblJudulGuardian.Text = updatedFilm.Title;
            lblGenreGuardian.Text = updatedFilm.Genre;
            lblDurasiGuardian.Text = updatedFilm.Duration;
            lblSutradaraGuardian.Text = updatedFilm.Director;

            if (updatedFilm.Poster != null)
            {
                pictureBoxGuardian.Image = updatedFilm.Poster;
            }
        }
        public void UpdateNorthmanFilmDetails(Film updatedFilm)
        {
            lblJudulNorthman.Text = updatedFilm.Title;
            lblGenreNorthman.Text = updatedFilm.Genre;
            lblDurasiNorthman.Text = updatedFilm.Duration;
            lblSutradaraNorthman.Text = updatedFilm.Director;

            if (updatedFilm.Poster != null)
            {
                pictureBoxNorthman.Image = updatedFilm.Poster;
            }
        }
        public void UpdateArtemisFilmDetails(Film updatedFilm)
        {
            lblJudulFowl.Text = updatedFilm.Title;
            lblGenreFowl.Text = updatedFilm.Genre;
            lblDurasiFowl.Text = updatedFilm.Duration;
            lblSutradaraFowl.Text = updatedFilm.Director;

            if (updatedFilm.Poster != null)
            {
                pictureBoxFowl.Image = updatedFilm.Poster;
            }
        }

        private void pictureBoxNorthman_Click(object sender, EventArgs e)
        {
            // Buka Form4 (Detail Film Spiderman)
            Form7 detailNorthman = new Form7();
            detailNorthman.Show();
            this.Hide(); // Sembunyikan Form3
        }

        private void pictureBoxGuardian_Click(object sender, EventArgs e)
        {
            Form5 detailSpider = new Form5();
            detailSpider.Show();
            this.Hide(); 
        }

        private void pictureBoxFowl_Click(object sender, EventArgs e)
        {
            Form6 detailAF = new Form6();
            detailAF.Show();
            this.Hide(); // 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
           UserData.SaveUserData(); // Simpan data pengguna sebelum logout
    LoginAdmin.IsAdmin = false;
    Login loginForm = new Login();
    loginForm.Show();
    this.Close();
        }
    }

}
