
namespace PassSafe
{
    partial class Vault
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
            this.button_settings = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_vault = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.button_additem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.ForeColor = System.Drawing.Color.White;
            this.button_settings.Location = new System.Drawing.Point(279, 724);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(139, 100);
            this.button_settings.TabIndex = 7;
            this.button_settings.Text = "SETTINGS";
            this.button_settings.UseVisualStyleBackColor = false;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_generate
            // 
            this.button_generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.button_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generate.ForeColor = System.Drawing.Color.White;
            this.button_generate.Location = new System.Drawing.Point(140, 724);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(139, 100);
            this.button_generate.TabIndex = 5;
            this.button_generate.Text = "PASSWORD GENERATOR";
            this.button_generate.UseVisualStyleBackColor = false;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // button_vault
            // 
            this.button_vault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.button_vault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_vault.ForeColor = System.Drawing.Color.White;
            this.button_vault.Location = new System.Drawing.Point(0, 724);
            this.button_vault.Name = "button_vault";
            this.button_vault.Size = new System.Drawing.Size(139, 100);
            this.button_vault.TabIndex = 4;
            this.button_vault.Text = "VAULT";
            this.button_vault.UseVisualStyleBackColor = false;
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
            this.label_title.TabIndex = 13;
            this.label_title.Text = "Vault";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_additem
            // 
            this.button_additem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.button_additem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_additem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_additem.ForeColor = System.Drawing.Color.White;
            this.button_additem.Location = new System.Drawing.Point(39, 646);
            this.button_additem.Name = "button_additem";
            this.button_additem.Size = new System.Drawing.Size(340, 50);
            this.button_additem.TabIndex = 14;
            this.button_additem.Text = "Add Item";
            this.button_additem.UseVisualStyleBackColor = false;
            // 
            // Vault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.Controls.Add(this.button_additem);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.button_vault);
            this.Name = "Vault";
            this.Size = new System.Drawing.Size(418, 824);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button button_vault;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_additem;
    }
}
