
namespace PassSafe
{
    partial class Form1
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
            this.generator1 = new PassSafe.Generator();
            this.notes1 = new PassSafe.Notes();
            this.settings1 = new PassSafe.Settings();
            this.signIn1 = new PassSafe.SignIn();
            this.signUp1 = new PassSafe.SignUp();
            this.vault1 = new PassSafe.Vault();
            this.SuspendLayout();
            // 
            // generator1
            // 
            this.generator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.generator1.Location = new System.Drawing.Point(0, 0);
            this.generator1.Name = "generator1";
            this.generator1.notes = null;
            this.generator1.settings = null;
            this.generator1.Size = new System.Drawing.Size(418, 824);
            this.generator1.TabIndex = 0;
            this.generator1.vault = null;
            // 
            // notes1
            // 
            this.notes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.notes1.generator = null;
            this.notes1.Location = new System.Drawing.Point(0, 0);
            this.notes1.Name = "notes1";
            this.notes1.settings = null;
            this.notes1.Size = new System.Drawing.Size(418, 824);
            this.notes1.TabIndex = 21;
            this.notes1.vault = null;
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.settings1.generator = null;
            this.settings1.Location = new System.Drawing.Point(0, 0);
            this.settings1.Name = "settings1";
            this.settings1.notes = null;
            this.settings1.signIn = null;
            this.settings1.Size = new System.Drawing.Size(418, 824);
            this.settings1.TabIndex = 12;
            this.settings1.vault = null;
            // 
            // signIn1
            // 
            this.signIn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.signIn1.Location = new System.Drawing.Point(0, 0);
            this.signIn1.Name = "signIn1";
            this.signIn1.signUp = null;
            this.signIn1.Size = new System.Drawing.Size(418, 824);
            this.signIn1.TabIndex = 16;
            this.signIn1.vault = null;
            // 
            // signUp1
            // 
            this.signUp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.signUp1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.signUp1.Location = new System.Drawing.Point(0, 0);
            this.signUp1.Name = "signUp1";
            this.signUp1.signIn = null;
            this.signUp1.Size = new System.Drawing.Size(418, 824);
            this.signUp1.TabIndex = 7;
            // 
            // vault1
            // 
            this.vault1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.vault1.generator = null;
            this.vault1.Location = new System.Drawing.Point(0, 0);
            this.vault1.Name = "vault1";
            this.vault1.notes = null;
            this.vault1.settings = null;
            this.vault1.Size = new System.Drawing.Size(418, 824);
            this.vault1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 785);
            this.Controls.Add(this.signIn1);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.signUp1);
            this.Controls.Add(this.notes1);
            this.Controls.Add(this.vault1);
            this.Controls.Add(this.generator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Generator generator1;
        private Notes notes1;
        private Settings settings1;
        private SignIn signIn1;
        private SignUp signUp1;
        private Vault vault1;
    }
}

