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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.remReservation = new System.Windows.Forms.Button();
            this.editReservation = new System.Windows.Forms.Button();
            this.addReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 309);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // remReservation
            // 
            this.remReservation.Location = new System.Drawing.Point(12, 90);
            this.remReservation.Name = "remReservation";
            this.remReservation.Size = new System.Drawing.Size(167, 23);
            this.remReservation.TabIndex = 7;
            this.remReservation.Text = "Изтриване на резервация";
            this.remReservation.UseVisualStyleBackColor = true;
            // 
            // editReservation
            // 
            this.editReservation.Location = new System.Drawing.Point(12, 61);
            this.editReservation.Name = "editReservation";
            this.editReservation.Size = new System.Drawing.Size(167, 23);
            this.editReservation.TabIndex = 6;
            this.editReservation.Text = "Промяна на резервация";
            this.editReservation.UseVisualStyleBackColor = true;
            // 
            // addReservation
            // 
            this.addReservation.Location = new System.Drawing.Point(12, 32);
            this.addReservation.Name = "addReservation";
            this.addReservation.Size = new System.Drawing.Size(167, 23);
            this.addReservation.TabIndex = 5;
            this.addReservation.Text = "Добавяне на резервация";
            this.addReservation.UseVisualStyleBackColor = true;
            // 
            // devAllReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.remReservation);
            this.Controls.Add(this.editReservation);
            this.Controls.Add(this.addReservation);
            this.Controls.Add(this.dataGridView1);
            this.Name = "devAllReservations";
            this.Text = "devAllReservations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button remReservation;
        private System.Windows.Forms.Button editReservation;
        private System.Windows.Forms.Button addReservation;
    }
}