namespace CinemaTickets.Forms
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.moviePicture = new System.Windows.Forms.PictureBox();
            this.movieTitle = new System.Windows.Forms.Label();
            this.TicketTypes = new System.Windows.Forms.Label();
            this.Standart = new System.Windows.Forms.Label();
            this.Invalid = new System.Windows.Forms.Label();
            this.seats = new System.Windows.Forms.Button();
            this.Scholars = new System.Windows.Forms.Label();
            this.ticketStandard = new System.Windows.Forms.NumericUpDown();
            this.ticketElder = new System.Windows.Forms.NumericUpDown();
            this.ticketStudent = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.moviePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketStandard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketElder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // moviePicture
            // 
            this.moviePicture.Location = new System.Drawing.Point(12, 50);
            this.moviePicture.Name = "moviePicture";
            this.moviePicture.Size = new System.Drawing.Size(115, 163);
            this.moviePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePicture.TabIndex = 0;
            this.moviePicture.TabStop = false;
            // 
            // movieTitle
            // 
            this.movieTitle.ForeColor = System.Drawing.Color.White;
            this.movieTitle.Location = new System.Drawing.Point(12, 7);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(115, 40);
            this.movieTitle.TabIndex = 1;
            this.movieTitle.Text = "label1";
            this.movieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicketTypes
            // 
            this.TicketTypes.AutoSize = true;
            this.TicketTypes.ForeColor = System.Drawing.Color.White;
            this.TicketTypes.Location = new System.Drawing.Point(238, 50);
            this.TicketTypes.Name = "TicketTypes";
            this.TicketTypes.Size = new System.Drawing.Size(58, 13);
            this.TicketTypes.TabIndex = 2;
            this.TicketTypes.Text = "Вид билет";
            // 
            // Standart
            // 
            this.Standart.AutoSize = true;
            this.Standart.ForeColor = System.Drawing.Color.White;
            this.Standart.Location = new System.Drawing.Point(144, 75);
            this.Standart.Name = "Standart";
            this.Standart.Size = new System.Drawing.Size(66, 13);
            this.Standart.TabIndex = 3;
            this.Standart.Text = "Стандартен";
            // 
            // Invalid
            // 
            this.Invalid.AutoSize = true;
            this.Invalid.ForeColor = System.Drawing.Color.White;
            this.Invalid.Location = new System.Drawing.Point(144, 107);
            this.Invalid.Name = "Invalid";
            this.Invalid.Size = new System.Drawing.Size(63, 13);
            this.Invalid.TabIndex = 4;
            this.Invalid.Text = "Инвалиден";
            // 
            // seats
            // 
            this.seats.Location = new System.Drawing.Point(221, 191);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(75, 23);
            this.seats.TabIndex = 7;
            this.seats.Text = "Места";
            this.seats.UseVisualStyleBackColor = true;
            this.seats.Click += new System.EventHandler(this.seats_Click);
            // 
            // Scholars
            // 
            this.Scholars.AutoSize = true;
            this.Scholars.ForeColor = System.Drawing.Color.White;
            this.Scholars.Location = new System.Drawing.Point(145, 140);
            this.Scholars.Name = "Scholars";
            this.Scholars.Size = new System.Drawing.Size(35, 13);
            this.Scholars.TabIndex = 8;
            this.Scholars.Text = "Учащ";
            // 
            // ticketStandard
            // 
            this.ticketStandard.Location = new System.Drawing.Point(241, 75);
            this.ticketStandard.Name = "ticketStandard";
            this.ticketStandard.Size = new System.Drawing.Size(31, 20);
            this.ticketStandard.TabIndex = 9;
            // 
            // ticketElder
            // 
            this.ticketElder.Location = new System.Drawing.Point(241, 105);
            this.ticketElder.Name = "ticketElder";
            this.ticketElder.Size = new System.Drawing.Size(31, 20);
            this.ticketElder.TabIndex = 10;
            // 
            // ticketStudent
            // 
            this.ticketStudent.Location = new System.Drawing.Point(241, 140);
            this.ticketStudent.Name = "ticketStudent";
            this.ticketStudent.Size = new System.Drawing.Size(31, 20);
            this.ticketStudent.TabIndex = 12;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(381, 225);
            this.Controls.Add(this.ticketStudent);
            this.Controls.Add(this.ticketElder);
            this.Controls.Add(this.ticketStandard);
            this.Controls.Add(this.Scholars);
            this.Controls.Add(this.seats);
            this.Controls.Add(this.Invalid);
            this.Controls.Add(this.Standart);
            this.Controls.Add(this.TicketTypes);
            this.Controls.Add(this.movieTitle);
            this.Controls.Add(this.moviePicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Book";
            this.Text = "Резервация";
            ((System.ComponentModel.ISupportInitialize)(this.moviePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketStandard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketElder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox moviePicture;
        private System.Windows.Forms.Label movieTitle;
        private System.Windows.Forms.Label TicketTypes;
        private System.Windows.Forms.Label Standart;
        private System.Windows.Forms.Label Invalid;
        private System.Windows.Forms.Button seats;
        private System.Windows.Forms.Label Scholars;
        private System.Windows.Forms.NumericUpDown ticketStandard;
        private System.Windows.Forms.NumericUpDown ticketElder;
        private System.Windows.Forms.NumericUpDown ticketStudent;
    }
}