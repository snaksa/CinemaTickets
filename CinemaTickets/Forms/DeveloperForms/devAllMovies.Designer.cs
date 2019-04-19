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
            this.s = new System.Windows.Forms.DataGridView();
            this.addMovie = new System.Windows.Forms.Button();
            this.editMovie = new System.Windows.Forms.Button();
            this.remMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.s)).BeginInit();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.AllowUserToDeleteRows = false;
            this.s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.s.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.s.Location = new System.Drawing.Point(0, 95);
            this.s.Name = "s";
            this.s.ReadOnly = true;
            this.s.Size = new System.Drawing.Size(878, 450);
            this.s.TabIndex = 1;
            // 
            // addMovie
            // 
            this.addMovie.Location = new System.Drawing.Point(12, 35);
            this.addMovie.Name = "addMovie";
            this.addMovie.Size = new System.Drawing.Size(125, 23);
            this.addMovie.TabIndex = 2;
            this.addMovie.Text = "Добавяне на филм";
            this.addMovie.UseVisualStyleBackColor = true;
            // 
            // editMovie
            // 
            this.editMovie.Location = new System.Drawing.Point(143, 35);
            this.editMovie.Name = "editMovie";
            this.editMovie.Size = new System.Drawing.Size(109, 23);
            this.editMovie.TabIndex = 3;
            this.editMovie.Text = "Промяна на филм";
            this.editMovie.UseVisualStyleBackColor = true;
            // 
            // remMovie
            // 
            this.remMovie.Location = new System.Drawing.Point(258, 35);
            this.remMovie.Name = "remMovie";
            this.remMovie.Size = new System.Drawing.Size(129, 23);
            this.remMovie.TabIndex = 4;
            this.remMovie.Text = "Изтриване на филм";
            this.remMovie.UseVisualStyleBackColor = true;
            // 
            // devAllMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 545);
            this.Controls.Add(this.remMovie);
            this.Controls.Add(this.editMovie);
            this.Controls.Add(this.addMovie);
            this.Controls.Add(this.s);
            this.Name = "devAllMovies";
            this.Text = "devAllMovies";
            ((System.ComponentModel.ISupportInitialize)(this.s)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView s;
        private System.Windows.Forms.Button addMovie;
        private System.Windows.Forms.Button editMovie;
        private System.Windows.Forms.Button remMovie;
    }
}