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
            this.about = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.devMode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devMode)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGenres
            // 
            this.comboBoxGenres.FormattingEnabled = true;
            this.comboBoxGenres.Location = new System.Drawing.Point(472, 165);
            this.comboBoxGenres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxGenres.Name = "comboBoxGenres";
            this.comboBoxGenres.Size = new System.Drawing.Size(116, 24);
            this.comboBoxGenres.TabIndex = 1;
            this.comboBoxGenres.Text = "Всички";
            this.comboBoxGenres.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenres_SelectedIndexChanged);
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Location = new System.Drawing.Point(691, 68);
            this.about.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(46, 17);
            this.about.TabIndex = 21;
            this.about.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Жанр";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(435, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 137);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 438);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Виж всички";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // devMode
            // 
            this.devMode.Image = ((System.Drawing.Image)(resources.GetObject("devMode.Image")));
            this.devMode.Location = new System.Drawing.Point(869, 22);
            this.devMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devMode.Name = "devMode";
            this.devMode.Size = new System.Drawing.Size(96, 62);
            this.devMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.devMode.TabIndex = 24;
            this.devMode.TabStop = false;
            this.devMode.Click += new System.EventHandler(this.devMode_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(995, 479);
            this.Controls.Add(this.devMode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.about);
            this.Controls.Add(this.comboBoxGenres);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGenres;
        private System.Windows.Forms.Label about;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox devMode;
    }
}