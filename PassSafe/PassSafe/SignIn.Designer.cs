
namespace PassSafe
{
    partial class SignIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_signup = new System.Windows.Forms.Button();
            this.label_email = new System.Windows.Forms.Label();
            this.label_masterpw = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_masterpw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(252)))));
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.MinimumSize = new System.Drawing.Size(418, 150);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(418, 150);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "PassSafe";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(39, 432);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(340, 50);
            this.button_login.TabIndex = 1;
            this.button_login.Text = "LOG IN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_signup
            // 
            this.button_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.button_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signup.ForeColor = System.Drawing.Color.White;
            this.button_signup.Location = new System.Drawing.Point(39, 587);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(340, 50);
            this.button_signup.TabIndex = 2;
            this.button_signup.Text = "SIGN UP";
            this.button_signup.UseVisualStyleBackColor = false;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.White;
            this.label_email.Location = new System.Drawing.Point(34, 213);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(150, 25);
            this.label_email.TabIndex = 3;
            this.label_email.Text = "Email Address";
            // 
            // label_masterpw
            // 
            this.label_masterpw.AutoSize = true;
            this.label_masterpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_masterpw.ForeColor = System.Drawing.Color.White;
            this.label_masterpw.Location = new System.Drawing.Point(34, 296);
            this.label_masterpw.Name = "label_masterpw";
            this.label_masterpw.Size = new System.Drawing.Size(178, 25);
            this.label_masterpw.TabIndex = 4;
            this.label_masterpw.Text = "Master Password";
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.textBox_email.Location = new System.Drawing.Point(39, 241);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(340, 30);
            this.textBox_email.TabIndex = 5;
            // 
            // textBox_masterpw
            // 
            this.textBox_masterpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_masterpw.Location = new System.Drawing.Point(39, 324);
            this.textBox_masterpw.Multiline = true;
            this.textBox_masterpw.Name = "textBox_masterpw";
            this.textBox_masterpw.Size = new System.Drawing.Size(340, 30);
            this.textBox_masterpw.TabIndex = 6;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.Controls.Add(this.textBox_masterpw);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_masterpw);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_title);
            this.Name = "SignIn";
            this.Size = new System.Drawing.Size(418, 824);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_masterpw;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_masterpw;
    }
}
