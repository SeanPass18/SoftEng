
namespace PassSafe
{
    partial class Settings
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
            this.button_logout = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.button_export = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_vault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(39, 630);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(340, 50);
            this.button_logout.TabIndex = 16;
            this.button_logout.Text = "LOG OUT";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(252)))));
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.MinimumSize = new System.Drawing.Size(418, 40);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(418, 40);
            this.label_title.TabIndex = 17;
            this.label_title.Text = "Settings";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_export
            // 
            this.button_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.button_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_export.ForeColor = System.Drawing.Color.White;
            this.button_export.Location = new System.Drawing.Point(39, 531);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(340, 50);
            this.button_export.TabIndex = 18;
            this.button_export.Text = "EXPORT VAULT";
            this.button_export.UseVisualStyleBackColor = false;
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.ForeColor = System.Drawing.Color.White;
            this.button_settings.Location = new System.Drawing.Point(279, 724);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(139, 100);
            this.button_settings.TabIndex = 21;
            this.button_settings.Text = "SETTINGS";
            this.button_settings.UseVisualStyleBackColor = false;
            // 
            // button_generate
            // 
            this.button_generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.button_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generate.ForeColor = System.Drawing.Color.White;
            this.button_generate.Location = new System.Drawing.Point(140, 724);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(139, 100);
            this.button_generate.TabIndex = 20;
            this.button_generate.Text = "PASSWORD GENERATOR";
            this.button_generate.UseVisualStyleBackColor = false;
            // 
            // button_vault
            // 
            this.button_vault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.button_vault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_vault.ForeColor = System.Drawing.Color.White;
            this.button_vault.Location = new System.Drawing.Point(0, 724);
            this.button_vault.Name = "button_vault";
            this.button_vault.Size = new System.Drawing.Size(139, 100);
            this.button_vault.TabIndex = 19;
            this.button_vault.Text = "VAULT";
            this.button_vault.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.button_vault);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_logout);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(418, 824);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button button_vault;
    }
}
