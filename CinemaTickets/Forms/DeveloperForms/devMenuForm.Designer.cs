﻿namespace CinemaTickets.Forms.DeveloperForms
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
            this.moviesButton = new System.Windows.Forms.Button();
            this.projectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moviesButton
            // 
            this.moviesButton.Location = new System.Drawing.Point(13, 31);
            this.moviesButton.Name = "moviesButton";
            this.moviesButton.Size = new System.Drawing.Size(75, 23);
            this.moviesButton.TabIndex = 0;
            this.moviesButton.Text = "Филми";
            this.moviesButton.UseVisualStyleBackColor = true;
            this.moviesButton.Click += new System.EventHandler(this.moviesButton_Click);
            // 
            // projectionButton
            // 
            this.projectionButton.Location = new System.Drawing.Point(13, 73);
            this.projectionButton.Name = "projectionButton";
            this.projectionButton.Size = new System.Drawing.Size(75, 23);
            this.projectionButton.TabIndex = 1;
            this.projectionButton.Text = "Прожекции";
            this.projectionButton.UseVisualStyleBackColor = true;
            // 
            // devMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 154);
            this.Controls.Add(this.projectionButton);
            this.Controls.Add(this.moviesButton);
            this.Name = "devMenuForm";
            this.Text = "devMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moviesButton;
        private System.Windows.Forms.Button projectionButton;
    }
}