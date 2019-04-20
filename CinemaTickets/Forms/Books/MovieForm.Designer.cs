namespace CinemaTickets.Forms
{
    partial class MovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieForm));
            this.imgMovie = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.length = new System.Windows.Forms.Label();
            this.producer = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.actors = new System.Windows.Forms.Label();
            this.actorsText = new System.Windows.Forms.RichTextBox();
            this.book = new System.Windows.Forms.Button();
            this.s = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMovie
            // 
            this.imgMovie.Location = new System.Drawing.Point(13, 13);
            this.imgMovie.Name = "imgMovie";
            this.imgMovie.Size = new System.Drawing.Size(139, 145);
            this.imgMovie.TabIndex = 0;
            this.imgMovie.TabStop = false;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 164);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(140, 143);
            this.description.TabIndex = 1;
            this.description.Text = "";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(170, 44);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(78, 13);
            this.length.TabIndex = 2;
            this.length.Text = "Времетраене:";
            // 
            // producer
            // 
            this.producer.AutoSize = true;
            this.producer.Location = new System.Drawing.Point(170, 72);
            this.producer.Name = "producer";
            this.producer.Size = new System.Drawing.Size(64, 13);
            this.producer.TabIndex = 3;
            this.producer.Text = "Продуцент:";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(171, 102);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(39, 13);
            this.genre.TabIndex = 4;
            this.genre.Text = "Жанр:";
            // 
            // actors
            // 
            this.actors.AutoSize = true;
            this.actors.Location = new System.Drawing.Point(171, 148);
            this.actors.Name = "actors";
            this.actors.Size = new System.Drawing.Size(52, 13);
            this.actors.TabIndex = 5;
            this.actors.Text = "Актьори:";
            // 
            // actorsText
            // 
            this.actorsText.Location = new System.Drawing.Point(173, 164);
            this.actorsText.Name = "actorsText";
            this.actorsText.Size = new System.Drawing.Size(184, 96);
            this.actorsText.TabIndex = 6;
            this.actorsText.Text = "";
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(174, 284);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(75, 23);
            this.book.TabIndex = 7;
            this.book.Text = "Book Now";
            this.book.UseVisualStyleBackColor = true;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // s
            // 
            this.s.Enabled = true;
            this.s.Location = new System.Drawing.Point(392, 21);
            this.s.Name = "s";
            this.s.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("s.OcxState")));
            this.s.Size = new System.Drawing.Size(391, 297);
            this.s.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(255, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 330);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.s);
            this.Controls.Add(this.book);
            this.Controls.Add(this.actorsText);
            this.Controls.Add(this.actors);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.producer);
            this.Controls.Add(this.length);
            this.Controls.Add(this.description);
            this.Controls.Add(this.imgMovie);
            this.Name = "Movie";
            this.Text = "Movie";
            ((System.ComponentModel.ISupportInitialize)(this.imgMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMovie;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label producer;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label actors;
        private System.Windows.Forms.RichTextBox actorsText;
        private System.Windows.Forms.Button book;
        private AxShockwaveFlashObjects.AxShockwaveFlash s;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}