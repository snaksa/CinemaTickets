namespace CinemaTickets.Forms.DeveloperForms
{
    partial class devAllProjections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(devAllProjections));
            this.reservationDataGrid = new System.Windows.Forms.DataGridView();
            this.remReservation = new System.Windows.Forms.Button();
            this.editReservation = new System.Windows.Forms.Button();
            this.addReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationDataGrid
            // 
            this.reservationDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.reservationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reservationDataGrid.Location = new System.Drawing.Point(0, 141);
            this.reservationDataGrid.Name = "reservationDataGrid";
            this.reservationDataGrid.Size = new System.Drawing.Size(800, 309);
            this.reservationDataGrid.TabIndex = 0;
            // 
            // remReservation
            // 
            this.remReservation.Location = new System.Drawing.Point(12, 90);
            this.remReservation.Name = "remReservation";
            this.remReservation.Size = new System.Drawing.Size(167, 23);
            this.remReservation.TabIndex = 7;
            this.remReservation.Text = "Изтриване на прожекция";
            this.remReservation.UseVisualStyleBackColor = true;
            this.remReservation.Click += new System.EventHandler(this.remReservation_Click);
            // 
            // editReservation
            // 
            this.editReservation.Location = new System.Drawing.Point(12, 61);
            this.editReservation.Name = "editReservation";
            this.editReservation.Size = new System.Drawing.Size(167, 23);
            this.editReservation.TabIndex = 6;
            this.editReservation.Text = "Промяна на прожекция";
            this.editReservation.UseVisualStyleBackColor = true;
            this.editReservation.Click += new System.EventHandler(this.editReservation_Click);
            // 
            // addReservation
            // 
            this.addReservation.Location = new System.Drawing.Point(12, 32);
            this.addReservation.Name = "addReservation";
            this.addReservation.Size = new System.Drawing.Size(167, 23);
            this.addReservation.TabIndex = 5;
            this.addReservation.Text = "Добавяне на прожекция";
            this.addReservation.UseVisualStyleBackColor = true;
            this.addReservation.Click += new System.EventHandler(this.addReservation_Click);
            // 
            // devAllProjections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.remReservation);
            this.Controls.Add(this.editReservation);
            this.Controls.Add(this.addReservation);
            this.Controls.Add(this.reservationDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "devAllProjections";
            this.Text = "Всички прожекция";
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reservationDataGrid;
        private System.Windows.Forms.Button remReservation;
        private System.Windows.Forms.Button editReservation;
        private System.Windows.Forms.Button addReservation;
    }
}