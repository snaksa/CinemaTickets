namespace CinemaTickets.Forms.DeveloperForms
{
    partial class devAllReservations
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
            this.allReservationGrid = new System.Windows.Forms.DataGridView();
            this.delReservations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allReservationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // allReservationGrid
            // 
            this.allReservationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allReservationGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.allReservationGrid.Location = new System.Drawing.Point(0, 57);
            this.allReservationGrid.Name = "allReservationGrid";
            this.allReservationGrid.Size = new System.Drawing.Size(800, 393);
            this.allReservationGrid.TabIndex = 0;
            // 
            // delReservations
            // 
            this.delReservations.Location = new System.Drawing.Point(12, 12);
            this.delReservations.Name = "delReservations";
            this.delReservations.Size = new System.Drawing.Size(75, 23);
            this.delReservations.TabIndex = 1;
            this.delReservations.Text = "Изтриване";
            this.delReservations.UseVisualStyleBackColor = true;
            this.delReservations.Click += new System.EventHandler(this.delReservations_Click);
            // 
            // devAllReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delReservations);
            this.Controls.Add(this.allReservationGrid);
            this.Name = "devAllReservations";
            this.Text = "devAllReservations";
            ((System.ComponentModel.ISupportInitialize)(this.allReservationGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allReservationGrid;
        private System.Windows.Forms.Button delReservations;
    }
}