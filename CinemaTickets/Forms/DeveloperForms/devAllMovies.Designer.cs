namespace CinemaTickets.Forms
{
    partial class devAllMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(devAllMovies));
            this.dataGridAllMovies = new System.Windows.Forms.DataGridView();
            this.addMovie = new System.Windows.Forms.Button();
            this.editMovie = new System.Windows.Forms.Button();
            this.remMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAllMovies
            // 
            this.dataGridAllMovies.AllowUserToAddRows = false;
            this.dataGridAllMovies.AllowUserToDeleteRows = false;
            this.dataGridAllMovies.AllowUserToResizeColumns = false;
            this.dataGridAllMovies.AllowUserToResizeRows = false;
            this.dataGridAllMovies.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridAllMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllMovies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridAllMovies.Location = new System.Drawing.Point(0, 95);
            this.dataGridAllMovies.MultiSelect = false;
            this.dataGridAllMovies.Name = "dataGridAllMovies";
            this.dataGridAllMovies.ReadOnly = true;
            this.dataGridAllMovies.Size = new System.Drawing.Size(878, 450);
            this.dataGridAllMovies.TabIndex = 1;
            this.dataGridAllMovies.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridAllMovies_CellFormatting);
            // 
            // addMovie
            // 
            this.addMovie.Location = new System.Drawing.Point(12, 35);
            this.addMovie.Name = "addMovie";
            this.addMovie.Size = new System.Drawing.Size(125, 23);
            this.addMovie.TabIndex = 2;
            this.addMovie.Text = "Добавяне на филм";
            this.addMovie.UseVisualStyleBackColor = true;
            this.addMovie.Click += new System.EventHandler(this.addMovie_Click);
            // 
            // editMovie
            // 
            this.editMovie.Location = new System.Drawing.Point(143, 35);
            this.editMovie.Name = "editMovie";
            this.editMovie.Size = new System.Drawing.Size(109, 23);
            this.editMovie.TabIndex = 3;
            this.editMovie.Text = "Промяна на филм";
            this.editMovie.UseVisualStyleBackColor = true;
            this.editMovie.Click += new System.EventHandler(this.editMovie_Click);
            // 
            // remMovie
            // 
            this.remMovie.Location = new System.Drawing.Point(258, 35);
            this.remMovie.Name = "remMovie";
            this.remMovie.Size = new System.Drawing.Size(129, 23);
            this.remMovie.TabIndex = 4;
            this.remMovie.Text = "Изтриване на филм";
            this.remMovie.UseVisualStyleBackColor = true;
            this.remMovie.Click += new System.EventHandler(this.remMovie_Click);
            // 
            // devAllMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 545);
            this.Controls.Add(this.remMovie);
            this.Controls.Add(this.editMovie);
            this.Controls.Add(this.addMovie);
            this.Controls.Add(this.dataGridAllMovies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "devAllMovies";
            this.Text = "Всички филми";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAllMovies;
        private System.Windows.Forms.Button addMovie;
        private System.Windows.Forms.Button editMovie;
        private System.Windows.Forms.Button remMovie;
    }
}