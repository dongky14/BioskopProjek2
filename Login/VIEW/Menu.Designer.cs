﻿namespace Login
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditFilm = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGenreFowl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblJudulFowl = new System.Windows.Forms.Label();
            this.pictureBoxFowl = new System.Windows.Forms.PictureBox();
            this.lblGenreGuardian = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblJudulGuardian = new System.Windows.Forms.Label();
            this.pictureBoxGuardian = new System.Windows.Forms.PictureBox();
            this.lblGenreNorthman = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblJudulNorthman = new System.Windows.Forms.Label();
            this.pictureBoxNorthman = new System.Windows.Forms.PictureBox();
            this.lblFilmGenre = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblFilmTitle = new System.Windows.Forms.Label();
            this.pictureBoxSpiderman = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblFilmDuration = new System.Windows.Forms.Label();
            this.lblSutradara = new System.Windows.Forms.Label();
            this.lblDurasiGuardian = new System.Windows.Forms.Label();
            this.lblSutradaraGuardian = new System.Windows.Forms.Label();
            this.lblSutradaraFowl = new System.Windows.Forms.Label();
            this.lblDurasiFowl = new System.Windows.Forms.Label();
            this.lblSutradaraNorthman = new System.Windows.Forms.Label();
            this.lblDurasiNorthman = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFowl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuardian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNorthman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpiderman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.sidebar.Controls.Add(this.pnl);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(239, 666);
            this.sidebar.MinimumSize = new System.Drawing.Size(51, 666);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(51, 666);
            this.sidebar.TabIndex = 1;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.label1);
            this.pnl.Controls.Add(this.menuButton);
            this.pnl.Location = new System.Drawing.Point(2, 2);
            this.pnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(237, 218);
            this.pnl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU";
            // 
            // menuButton
            // 
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::Login.Properties.Resources.EEE;
            this.menuButton.Location = new System.Drawing.Point(-49, 57);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(145, 39);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 3;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(2, 224);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 72);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.BackgroundImage = global::Login.Properties.Resources.pngwing2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-177, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "                                                     HOME";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEditFilm);
            this.panel3.Location = new System.Drawing.Point(2, 300);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 73);
            this.panel3.TabIndex = 2;
            // 
            // btnEditFilm
            // 
            this.btnEditFilm.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnEditFilm.BackgroundImage = global::Login.Properties.Resources.PPP;
            this.btnEditFilm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditFilm.FlatAppearance.BorderSize = 0;
            this.btnEditFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFilm.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFilm.Location = new System.Drawing.Point(-177, 2);
            this.btnEditFilm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditFilm.Name = "btnEditFilm";
            this.btnEditFilm.Size = new System.Drawing.Size(400, 34);
            this.btnEditFilm.TabIndex = 4;
            this.btnEditFilm.Text = "                                                     EDIT FILM";
            this.btnEditFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFilm.UseVisualStyleBackColor = false;
            this.btnEditFilm.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHistory);
            this.panel4.Location = new System.Drawing.Point(2, 377);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 69);
            this.panel4.TabIndex = 2;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnHistory.BackgroundImage = global::Login.Properties.Resources.pngegg;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(-175, 0);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(400, 36);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "                                                     HISTORY";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Location = new System.Drawing.Point(2, 450);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 301);
            this.panel1.TabIndex = 4;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLogOut.BackgroundImage = global::Login.Properties.Resources.pngwing_com__2_;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(-175, 98);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(400, 36);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "                                                    LOGOUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // lblGenreFowl
            // 
            this.lblGenreFowl.AutoSize = true;
            this.lblGenreFowl.BackColor = System.Drawing.Color.Transparent;
            this.lblGenreFowl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenreFowl.ForeColor = System.Drawing.Color.White;
            this.lblGenreFowl.Location = new System.Drawing.Point(1016, 489);
            this.lblGenreFowl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenreFowl.Name = "lblGenreFowl";
            this.lblGenreFowl.Size = new System.Drawing.Size(107, 63);
            this.lblGenreFowl.TabIndex = 111;
            this.lblGenreFowl.Text = "Genre: \r\nFantasy, Sci-fi\r\n\r\n";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Login.Properties.Resources._4_STAR2;
            this.pictureBox5.Location = new System.Drawing.Point(857, 536);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(161, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 110;
            this.pictureBox5.TabStop = false;
            // 
            // lblJudulFowl
            // 
            this.lblJudulFowl.AutoSize = true;
            this.lblJudulFowl.BackColor = System.Drawing.Color.Transparent;
            this.lblJudulFowl.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblJudulFowl.ForeColor = System.Drawing.Color.White;
            this.lblJudulFowl.Location = new System.Drawing.Point(1013, 336);
            this.lblJudulFowl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJudulFowl.Name = "lblJudulFowl";
            this.lblJudulFowl.Size = new System.Drawing.Size(225, 37);
            this.lblJudulFowl.TabIndex = 109;
            this.lblJudulFowl.Text = "ARTEMIS FOWL";
            // 
            // pictureBoxFowl
            // 
            this.pictureBoxFowl.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFowl.Image = global::Login.Properties.Resources.film_action_2020_artemis_fowl;
            this.pictureBoxFowl.Location = new System.Drawing.Point(857, 335);
            this.pictureBoxFowl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxFowl.Name = "pictureBoxFowl";
            this.pictureBoxFowl.Size = new System.Drawing.Size(151, 197);
            this.pictureBoxFowl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFowl.TabIndex = 107;
            this.pictureBoxFowl.TabStop = false;
            this.pictureBoxFowl.Click += new System.EventHandler(this.pictureBoxFowl_Click);
            // 
            // lblGenreGuardian
            // 
            this.lblGenreGuardian.AutoSize = true;
            this.lblGenreGuardian.BackColor = System.Drawing.Color.Transparent;
            this.lblGenreGuardian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenreGuardian.ForeColor = System.Drawing.Color.White;
            this.lblGenreGuardian.Location = new System.Drawing.Point(455, 489);
            this.lblGenreGuardian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenreGuardian.Name = "lblGenreGuardian";
            this.lblGenreGuardian.Size = new System.Drawing.Size(235, 42);
            this.lblGenreGuardian.TabIndex = 106;
            this.lblGenreGuardian.Text = "Genre: \r\nSuper Hero, Action, Adventure\r\n";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Login.Properties.Resources._5_STAR;
            this.pictureBox7.Location = new System.Drawing.Point(287, 535);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(161, 48);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 105;
            this.pictureBox7.TabStop = false;
            // 
            // lblJudulGuardian
            // 
            this.lblJudulGuardian.AutoSize = true;
            this.lblJudulGuardian.BackColor = System.Drawing.Color.Transparent;
            this.lblJudulGuardian.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblJudulGuardian.ForeColor = System.Drawing.Color.White;
            this.lblJudulGuardian.Location = new System.Drawing.Point(453, 335);
            this.lblJudulGuardian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJudulGuardian.Name = "lblJudulGuardian";
            this.lblJudulGuardian.Size = new System.Drawing.Size(330, 37);
            this.lblJudulGuardian.TabIndex = 104;
            this.lblJudulGuardian.Text = "GUARDIAN OF GALAXY";
            // 
            // pictureBoxGuardian
            // 
            this.pictureBoxGuardian.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGuardian.Image = global::Login.Properties.Resources.film_guardians_of_the_galaxy_2014foto_marvel_studios;
            this.pictureBoxGuardian.Location = new System.Drawing.Point(297, 334);
            this.pictureBoxGuardian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxGuardian.Name = "pictureBoxGuardian";
            this.pictureBoxGuardian.Size = new System.Drawing.Size(151, 197);
            this.pictureBoxGuardian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGuardian.TabIndex = 102;
            this.pictureBoxGuardian.TabStop = false;
            this.pictureBoxGuardian.Click += new System.EventHandler(this.pictureBoxGuardian_Click);
            // 
            // lblGenreNorthman
            // 
            this.lblGenreNorthman.AutoSize = true;
            this.lblGenreNorthman.BackColor = System.Drawing.Color.Transparent;
            this.lblGenreNorthman.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenreNorthman.ForeColor = System.Drawing.Color.White;
            this.lblGenreNorthman.Location = new System.Drawing.Point(1016, 158);
            this.lblGenreNorthman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenreNorthman.Name = "lblGenreNorthman";
            this.lblGenreNorthman.Size = new System.Drawing.Size(234, 63);
            this.lblGenreNorthman.TabIndex = 101;
            this.lblGenreNorthman.Text = "Genre: \r\nFilmnoir, Superhero, Romantic,\r\nComedy, Horror\r\n";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Login.Properties.Resources._4_STAR2;
            this.pictureBox3.Location = new System.Drawing.Point(859, 229);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 100;
            this.pictureBox3.TabStop = false;
            // 
            // lblJudulNorthman
            // 
            this.lblJudulNorthman.AutoSize = true;
            this.lblJudulNorthman.BackColor = System.Drawing.Color.Transparent;
            this.lblJudulNorthman.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblJudulNorthman.ForeColor = System.Drawing.Color.White;
            this.lblJudulNorthman.Location = new System.Drawing.Point(1014, 23);
            this.lblJudulNorthman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJudulNorthman.Name = "lblJudulNorthman";
            this.lblJudulNorthman.Size = new System.Drawing.Size(243, 37);
            this.lblJudulNorthman.TabIndex = 99;
            this.lblJudulNorthman.Text = "The NORTHMAN";
            // 
            // pictureBoxNorthman
            // 
            this.pictureBoxNorthman.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNorthman.Image = global::Login.Properties.Resources._527dc1f4_the_northman__sumber_imdb_1;
            this.pictureBoxNorthman.Location = new System.Drawing.Point(863, 23);
            this.pictureBoxNorthman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxNorthman.Name = "pictureBoxNorthman";
            this.pictureBoxNorthman.Size = new System.Drawing.Size(151, 197);
            this.pictureBoxNorthman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNorthman.TabIndex = 97;
            this.pictureBoxNorthman.TabStop = false;
            this.pictureBoxNorthman.Click += new System.EventHandler(this.pictureBoxNorthman_Click);
            // 
            // lblFilmGenre
            // 
            this.lblFilmGenre.AutoSize = true;
            this.lblFilmGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblFilmGenre.ForeColor = System.Drawing.Color.White;
            this.lblFilmGenre.Location = new System.Drawing.Point(479, 158);
            this.lblFilmGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilmGenre.Name = "lblFilmGenre";
            this.lblFilmGenre.Size = new System.Drawing.Size(198, 63);
            this.lblFilmGenre.TabIndex = 96;
            this.lblFilmGenre.Text = "Genre: \r\nAction, Adventure, Sci-Fi, \r\nSuper Hero\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Login.Properties.Resources._5_STAR;
            this.pictureBox2.Location = new System.Drawing.Point(297, 226);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            // 
            // lblFilmTitle
            // 
            this.lblFilmTitle.AutoSize = true;
            this.lblFilmTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmTitle.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblFilmTitle.ForeColor = System.Drawing.Color.White;
            this.lblFilmTitle.Location = new System.Drawing.Point(477, 23);
            this.lblFilmTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilmTitle.Name = "lblFilmTitle";
            this.lblFilmTitle.Size = new System.Drawing.Size(363, 37);
            this.lblFilmTitle.TabIndex = 94;
            this.lblFilmTitle.Text = "The Amazing SPIDERMAN";
            // 
            // pictureBoxSpiderman
            // 
            this.pictureBoxSpiderman.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSpiderman.Image = global::Login.Properties.Resources.The_Amazing_Spider_Man_theatrical_poster;
            this.pictureBoxSpiderman.Location = new System.Drawing.Point(305, 23);
            this.pictureBoxSpiderman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxSpiderman.Name = "pictureBoxSpiderman";
            this.pictureBoxSpiderman.Size = new System.Drawing.Size(151, 197);
            this.pictureBoxSpiderman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSpiderman.TabIndex = 92;
            this.pictureBoxSpiderman.TabStop = false;
            this.pictureBoxSpiderman.Click += new System.EventHandler(this.pictureBoxSpiderman_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblFilmDuration
            // 
            this.lblFilmDuration.AutoSize = true;
            this.lblFilmDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblFilmDuration.ForeColor = System.Drawing.Color.White;
            this.lblFilmDuration.Location = new System.Drawing.Point(479, 68);
            this.lblFilmDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilmDuration.Name = "lblFilmDuration";
            this.lblFilmDuration.Size = new System.Drawing.Size(163, 21);
            this.lblFilmDuration.TabIndex = 112;
            this.lblFilmDuration.Text = "Durasi : 2 jam 1 Menit";
            this.lblFilmDuration.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSutradara
            // 
            this.lblSutradara.AutoSize = true;
            this.lblSutradara.BackColor = System.Drawing.Color.Transparent;
            this.lblSutradara.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSutradara.ForeColor = System.Drawing.Color.White;
            this.lblSutradara.Location = new System.Drawing.Point(479, 88);
            this.lblSutradara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSutradara.Name = "lblSutradara";
            this.lblSutradara.Size = new System.Drawing.Size(88, 21);
            this.lblSutradara.TabIndex = 113;
            this.lblSutradara.Text = "Sutradara :";
            this.lblSutradara.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDurasiGuardian
            // 
            this.lblDurasiGuardian.AutoSize = true;
            this.lblDurasiGuardian.BackColor = System.Drawing.Color.Transparent;
            this.lblDurasiGuardian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDurasiGuardian.ForeColor = System.Drawing.Color.White;
            this.lblDurasiGuardian.Location = new System.Drawing.Point(455, 384);
            this.lblDurasiGuardian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDurasiGuardian.Name = "lblDurasiGuardian";
            this.lblDurasiGuardian.Size = new System.Drawing.Size(163, 21);
            this.lblDurasiGuardian.TabIndex = 114;
            this.lblDurasiGuardian.Text = "Durasi : 2 jam 1 Menit";
            this.lblDurasiGuardian.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSutradaraGuardian
            // 
            this.lblSutradaraGuardian.AutoSize = true;
            this.lblSutradaraGuardian.BackColor = System.Drawing.Color.Transparent;
            this.lblSutradaraGuardian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSutradaraGuardian.ForeColor = System.Drawing.Color.White;
            this.lblSutradaraGuardian.Location = new System.Drawing.Point(455, 405);
            this.lblSutradaraGuardian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSutradaraGuardian.Name = "lblSutradaraGuardian";
            this.lblSutradaraGuardian.Size = new System.Drawing.Size(88, 21);
            this.lblSutradaraGuardian.TabIndex = 115;
            this.lblSutradaraGuardian.Text = "Sutradara :";
            this.lblSutradaraGuardian.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSutradaraFowl
            // 
            this.lblSutradaraFowl.AutoSize = true;
            this.lblSutradaraFowl.BackColor = System.Drawing.Color.Transparent;
            this.lblSutradaraFowl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSutradaraFowl.ForeColor = System.Drawing.Color.White;
            this.lblSutradaraFowl.Location = new System.Drawing.Point(1016, 405);
            this.lblSutradaraFowl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSutradaraFowl.Name = "lblSutradaraFowl";
            this.lblSutradaraFowl.Size = new System.Drawing.Size(88, 21);
            this.lblSutradaraFowl.TabIndex = 117;
            this.lblSutradaraFowl.Text = "Sutradara :";
            this.lblSutradaraFowl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDurasiFowl
            // 
            this.lblDurasiFowl.AutoSize = true;
            this.lblDurasiFowl.BackColor = System.Drawing.Color.Transparent;
            this.lblDurasiFowl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDurasiFowl.ForeColor = System.Drawing.Color.White;
            this.lblDurasiFowl.Location = new System.Drawing.Point(1016, 384);
            this.lblDurasiFowl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDurasiFowl.Name = "lblDurasiFowl";
            this.lblDurasiFowl.Size = new System.Drawing.Size(163, 21);
            this.lblDurasiFowl.TabIndex = 116;
            this.lblDurasiFowl.Text = "Durasi : 2 jam 1 Menit";
            this.lblDurasiFowl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSutradaraNorthman
            // 
            this.lblSutradaraNorthman.AutoSize = true;
            this.lblSutradaraNorthman.BackColor = System.Drawing.Color.Transparent;
            this.lblSutradaraNorthman.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSutradaraNorthman.ForeColor = System.Drawing.Color.White;
            this.lblSutradaraNorthman.Location = new System.Drawing.Point(1015, 88);
            this.lblSutradaraNorthman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSutradaraNorthman.Name = "lblSutradaraNorthman";
            this.lblSutradaraNorthman.Size = new System.Drawing.Size(88, 21);
            this.lblSutradaraNorthman.TabIndex = 119;
            this.lblSutradaraNorthman.Text = "Sutradara :";
            this.lblSutradaraNorthman.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDurasiNorthman
            // 
            this.lblDurasiNorthman.AutoSize = true;
            this.lblDurasiNorthman.BackColor = System.Drawing.Color.Transparent;
            this.lblDurasiNorthman.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDurasiNorthman.ForeColor = System.Drawing.Color.White;
            this.lblDurasiNorthman.Location = new System.Drawing.Point(1016, 68);
            this.lblDurasiNorthman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDurasiNorthman.Name = "lblDurasiNorthman";
            this.lblDurasiNorthman.Size = new System.Drawing.Size(163, 21);
            this.lblDurasiNorthman.TabIndex = 118;
            this.lblDurasiNorthman.Text = "Durasi : 2 jam 1 Menit";
            this.lblDurasiNorthman.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.p2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.ControlBox = false;
            this.Controls.Add(this.lblSutradaraNorthman);
            this.Controls.Add(this.lblDurasiNorthman);
            this.Controls.Add(this.lblSutradaraFowl);
            this.Controls.Add(this.lblDurasiFowl);
            this.Controls.Add(this.lblSutradaraGuardian);
            this.Controls.Add(this.lblDurasiGuardian);
            this.Controls.Add(this.lblSutradara);
            this.Controls.Add(this.lblFilmDuration);
            this.Controls.Add(this.lblGenreFowl);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblJudulFowl);
            this.Controls.Add(this.pictureBoxFowl);
            this.Controls.Add(this.lblGenreGuardian);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblJudulGuardian);
            this.Controls.Add(this.pictureBoxGuardian);
            this.Controls.Add(this.lblGenreNorthman);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblJudulNorthman);
            this.Controls.Add(this.pictureBoxNorthman);
            this.Controls.Add(this.lblFilmGenre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblFilmTitle);
            this.Controls.Add(this.pictureBoxSpiderman);
            this.Controls.Add(this.sidebar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.sidebar.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFowl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuardian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNorthman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpiderman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEditFilm;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label lblGenreFowl;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblJudulFowl;
        private System.Windows.Forms.PictureBox pictureBoxFowl;
        private System.Windows.Forms.Label lblGenreGuardian;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblJudulGuardian;
        private System.Windows.Forms.PictureBox pictureBoxGuardian;
        private System.Windows.Forms.Label lblGenreNorthman;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblJudulNorthman;
        private System.Windows.Forms.PictureBox pictureBoxNorthman;
        private System.Windows.Forms.Label lblFilmGenre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFilmTitle;
        private System.Windows.Forms.PictureBox pictureBoxSpiderman;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblSutradara;
        private System.Windows.Forms.Label lblFilmDuration;
        private System.Windows.Forms.Label lblSutradaraNorthman;
        private System.Windows.Forms.Label lblDurasiNorthman;
        private System.Windows.Forms.Label lblSutradaraFowl;
        private System.Windows.Forms.Label lblDurasiFowl;
        private System.Windows.Forms.Label lblSutradaraGuardian;
        private System.Windows.Forms.Label lblDurasiGuardian;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
    }
}