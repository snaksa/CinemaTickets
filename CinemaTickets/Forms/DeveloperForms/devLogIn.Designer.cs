namespace CinemaTickets.Forms
{
    partial class devLogIn
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
            this.usnLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.devLogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usnLabel
            // 
            this.usnLabel.AutoSize = true;
            this.usnLabel.Location = new System.Drawing.Point(27, 100);
            this.usnLabel.Name = "usnLabel";
            this.usnLabel.Size = new System.Drawing.Size(35, 13);
            this.usnLabel.TabIndex = 0;
            this.usnLabel.Text = "label1";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(27, 129);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(35, 13);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "label2";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(69, 100);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(69, 129);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            // 
            // devLogInButton
            // 
            this.devLogInButton.Location = new System.Drawing.Point(69, 174);
            this.devLogInButton.Name = "devLogInButton";
            this.devLogInButton.Size = new System.Drawing.Size(75, 23);
            this.devLogInButton.TabIndex = 4;
            this.devLogInButton.Text = "button1";
            this.devLogInButton.UseVisualStyleBackColor = true;
            // 
            // devLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 209);
            this.Controls.Add(this.devLogInButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.usnLabel);
            this.Name = "devLogIn";
            this.Text = "devLogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usnLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button devLogInButton;
    }
}