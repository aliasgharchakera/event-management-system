
namespace Event_Management_CS355
{
    partial class Login_form
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
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(91, 148);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(98, 13);
            this.email_label.TabIndex = 0;
            this.email_label.Text = "Email / Student ID";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(133, 172);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(56, 13);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(196, 144);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(166, 20);
            this.email_textbox.TabIndex = 2;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(196, 170);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(166, 20);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.login_label.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(53, 33);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(194, 77);
            this.login_label.TabIndex = 4;
            this.login_label.Text = "Login";
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 309);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Name = "Login_form";
            this.Text = "HU Events Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label login_label;
    }
}

