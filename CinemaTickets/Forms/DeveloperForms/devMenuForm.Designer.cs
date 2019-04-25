namespace CinemaTickets.Forms.DeveloperForms
{
    partial class devMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(devMenuForm));
            this.moviesButton = new System.Windows.Forms.Button();
            this.projectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moviesButton
            // 
            this.moviesButton.Location = new System.Drawing.Point(13, 31);
            this.moviesButton.Name = "moviesButton";
            this.moviesButton.Size = new System.Drawing.Size(82, 23);
            this.moviesButton.TabIndex = 0;
            this.moviesButton.Text = "Филми";
            this.moviesButton.UseVisualStyleBackColor = true;
            this.moviesButton.Click += new System.EventHandler(this.moviesButton_Click);
            // 
            // projectionButton
            // 
            this.projectionButton.Location = new System.Drawing.Point(13, 73);
            this.projectionButton.Name = "projectionButton";
            this.projectionButton.Size = new System.Drawing.Size(82, 23);
            this.projectionButton.TabIndex = 1;
            this.projectionButton.Text = "Прожекции";
            this.projectionButton.UseVisualStyleBackColor = true;
            this.projectionButton.Click += new System.EventHandler(this.projectionButton_Click);
            // 
            // devMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(190, 133);
            this.Controls.Add(this.projectionButton);
            this.Controls.Add(this.moviesButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "devMenuForm";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moviesButton;
        private System.Windows.Forms.Button projectionButton;
    }
}