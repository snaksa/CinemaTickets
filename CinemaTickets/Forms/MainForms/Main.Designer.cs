namespace CinemaTickets.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.comboBoxGenres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aMovies = new System.Windows.Forms.Button();
            this.devMode = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.about)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGenres
            // 
            this.comboBoxGenres.FormattingEnabled = true;
            this.comboBoxGenres.Location = new System.Drawing.Point(239, 216);
            this.comboBoxGenres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxGenres.Name = "comboBoxGenres";
            this.comboBoxGenres.Size = new System.Drawing.Size(116, 24);
            this.comboBoxGenres.TabIndex = 1;
            this.comboBoxGenres.Text = "Всички";
            this.comboBoxGenres.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenres_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Жанр";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CinemaTickets.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(187, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // aMovies
            // 
            this.aMovies.Location = new System.Drawing.Point(336, 475);
            this.aMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aMovies.Name = "aMovies";
            this.aMovies.Size = new System.Drawing.Size(163, 23);
            this.aMovies.TabIndex = 0;
            this.aMovies.Text = "Виж всички";
            this.aMovies.UseVisualStyleBackColor = true;
            this.aMovies.Click += new System.EventHandler(this.aMovies_Click);
            // 
            // devMode
            // 
            this.devMode.BackColor = System.Drawing.Color.Transparent;
            this.devMode.Image = ((System.Drawing.Image)(resources.GetObject("devMode.Image")));
            this.devMode.Location = new System.Drawing.Point(762, 23);
            this.devMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devMode.Name = "devMode";
            this.devMode.Size = new System.Drawing.Size(96, 62);
            this.devMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.devMode.TabIndex = 24;
            this.devMode.TabStop = false;
            this.devMode.Click += new System.EventHandler(this.devMode_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(363, 217);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(159, 22);
            this.searchTextBox.TabIndex = 25;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(529, 209);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 39);
            this.searchButton.TabIndex = 26;
            this.searchButton.Text = "Търси";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.Transparent;
            this.about.Image = ((System.Drawing.Image)(resources.GetObject("about.Image")));
            this.about.Location = new System.Drawing.Point(658, 23);
            this.about.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(96, 62);
            this.about.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.about.TabIndex = 27;
            this.about.TabStop = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 519);
            this.Controls.Add(this.about);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.devMode);
            this.Controls.Add(this.aMovies);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGenres);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "КИНО";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.about)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGenres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button aMovies;
        private System.Windows.Forms.PictureBox devMode;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.PictureBox about;
    }
}