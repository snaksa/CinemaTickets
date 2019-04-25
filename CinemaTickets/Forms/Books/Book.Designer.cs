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
            this.moviePicture.Location = new System.Drawing.Point(16, 62);
            this.moviePicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moviePicture.Name = "moviePicture";
            this.moviePicture.Size = new System.Drawing.Size(153, 201);
            this.moviePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePicture.TabIndex = 0;
            this.moviePicture.TabStop = false;
            // 
            // movieTitle
            // 
            this.movieTitle.ForeColor = System.Drawing.Color.White;
            this.movieTitle.Location = new System.Drawing.Point(16, 9);
            this.movieTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(153, 49);
            this.movieTitle.TabIndex = 1;
            this.movieTitle.Text = "label1";
            this.movieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicketTypes
            // 
            this.TicketTypes.AutoSize = true;
            this.TicketTypes.ForeColor = System.Drawing.Color.White;
            this.TicketTypes.Location = new System.Drawing.Point(317, 62);
            this.TicketTypes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TicketTypes.Name = "TicketTypes";
            this.TicketTypes.Size = new System.Drawing.Size(76, 17);
            this.TicketTypes.TabIndex = 2;
            this.TicketTypes.Text = "Вид билет";
            // 
            // Standart
            // 
            this.Standart.AutoSize = true;
            this.Standart.ForeColor = System.Drawing.Color.White;
            this.Standart.Location = new System.Drawing.Point(192, 92);
            this.Standart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Standart.Name = "Standart";
            this.Standart.Size = new System.Drawing.Size(87, 17);
            this.Standart.TabIndex = 3;
            this.Standart.Text = "Стандартен";
            // 
            // Invalid
            // 
            this.Invalid.AutoSize = true;
            this.Invalid.ForeColor = System.Drawing.Color.White;
            this.Invalid.Location = new System.Drawing.Point(192, 132);
            this.Invalid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Invalid.Name = "Invalid";
            this.Invalid.Size = new System.Drawing.Size(81, 17);
            this.Invalid.TabIndex = 4;
            this.Invalid.Text = "Инвалиден";
            // 
            // seats
            // 
            this.seats.Location = new System.Drawing.Point(195, 222);
            this.seats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(167, 28);
            this.seats.TabIndex = 7;
            this.seats.Text = "Места";
            this.seats.UseVisualStyleBackColor = true;
            this.seats.Click += new System.EventHandler(this.seats_Click);
            // 
            // Scholars
            // 
            this.Scholars.AutoSize = true;
            this.Scholars.ForeColor = System.Drawing.Color.White;
            this.Scholars.Location = new System.Drawing.Point(193, 172);
            this.Scholars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Scholars.Name = "Scholars";
            this.Scholars.Size = new System.Drawing.Size(44, 17);
            this.Scholars.TabIndex = 8;
            this.Scholars.Text = "Учащ";
            // 
            // ticketStandard
            // 
            this.ticketStandard.Location = new System.Drawing.Point(321, 92);
            this.ticketStandard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ticketStandard.Name = "ticketStandard";
            this.ticketStandard.Size = new System.Drawing.Size(41, 22);
            this.ticketStandard.TabIndex = 9;
            // 
            // ticketElder
            // 
            this.ticketElder.Location = new System.Drawing.Point(321, 129);
            this.ticketElder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ticketElder.Name = "ticketElder";
            this.ticketElder.Size = new System.Drawing.Size(41, 22);
            this.ticketElder.TabIndex = 10;
            // 
            // ticketStudent
            // 
            this.ticketStudent.Location = new System.Drawing.Point(321, 172);
            this.ticketStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ticketStudent.Name = "ticketStudent";
            this.ticketStudent.Size = new System.Drawing.Size(41, 22);
            this.ticketStudent.TabIndex = 12;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(417, 277);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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