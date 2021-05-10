
namespace PassSafe
{
    partial class Generator
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
            this.label_passworddisplay = new System.Windows.Forms.Label();
            this.checkBox_upper = new System.Windows.Forms.CheckBox();
            this.checkBox_lower = new System.Windows.Forms.CheckBox();
            this.checkBox_number = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.trackBar_pwlength = new System.Windows.Forms.TrackBar();
            this.label_pwlength = new System.Windows.Forms.Label();
            this.label_pwnum = new System.Windows.Forms.Label();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_vault = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_pwlength)).BeginInit();
            this.SuspendLayout();
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
            this.label_title.TabIndex = 12;
            this.label_title.Text = "Password Generator";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_passworddisplay
            // 
            this.label_passworddisplay.AutoSize = true;
            this.label_passworddisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(166)))), ((int)(((byte)(252)))));
            this.label_passworddisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_passworddisplay.ForeColor = System.Drawing.Color.White;
            this.label_passworddisplay.Location = new System.Drawing.Point(0, 80);
            this.label_passworddisplay.MinimumSize = new System.Drawing.Size(418, 30);
            this.label_passworddisplay.Name = "label_passworddisplay";
            this.label_passworddisplay.Size = new System.Drawing.Size(418, 30);
            this.label_passworddisplay.TabIndex = 13;
            this.label_passworddisplay.Text = "PASSWORD WILL DISPLAY HERE";
            this.label_passworddisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_upper
            // 
            this.checkBox_upper.AutoSize = true;
            this.checkBox_upper.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_upper.Checked = true;
            this.checkBox_upper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_upper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_upper.ForeColor = System.Drawing.Color.White;
            this.checkBox_upper.Location = new System.Drawing.Point(39, 352);
            this.checkBox_upper.MinimumSize = new System.Drawing.Size(340, 0);
            this.checkBox_upper.Name = "checkBox_upper";
            this.checkBox_upper.Size = new System.Drawing.Size(340, 29);
            this.checkBox_upper.TabIndex = 14;
            this.checkBox_upper.Text = "A - Z";
            this.checkBox_upper.UseVisualStyleBackColor = true;
            // 
            // checkBox_lower
            // 
            this.checkBox_lower.AutoSize = true;
            this.checkBox_lower.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_lower.Checked = true;
            this.checkBox_lower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_lower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_lower.ForeColor = System.Drawing.Color.White;
            this.checkBox_lower.Location = new System.Drawing.Point(39, 409);
            this.checkBox_lower.MinimumSize = new System.Drawing.Size(340, 0);
            this.checkBox_lower.Name = "checkBox_lower";
            this.checkBox_lower.Size = new System.Drawing.Size(340, 29);
            this.checkBox_lower.TabIndex = 15;
            this.checkBox_lower.Text = "a - z";
            this.checkBox_lower.UseVisualStyleBackColor = true;
            // 
            // checkBox_number
            // 
            this.checkBox_number.AutoSize = true;
            this.checkBox_number.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_number.Checked = true;
            this.checkBox_number.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_number.ForeColor = System.Drawing.Color.White;
            this.checkBox_number.Location = new System.Drawing.Point(39, 466);
            this.checkBox_number.MinimumSize = new System.Drawing.Size(340, 0);
            this.checkBox_number.Name = "checkBox_number";
            this.checkBox_number.Size = new System.Drawing.Size(340, 29);
            this.checkBox_number.TabIndex = 16;
            this.checkBox_number.Text = "0 - 9";
            this.checkBox_number.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(39, 523);
            this.checkBox1.MinimumSize = new System.Drawing.Size(340, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(340, 29);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Special";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // trackBar_pwlength
            // 
            this.trackBar_pwlength.Location = new System.Drawing.Point(39, 243);
            this.trackBar_pwlength.Maximum = 25;
            this.trackBar_pwlength.Minimum = 8;
            this.trackBar_pwlength.Name = "trackBar_pwlength";
            this.trackBar_pwlength.Size = new System.Drawing.Size(310, 45);
            this.trackBar_pwlength.TabIndex = 18;
            this.trackBar_pwlength.Value = 8;
            this.trackBar_pwlength.Scroll += new System.EventHandler(this.trackBar_pwlength_Scroll);
            // 
            // label_pwlength
            // 
            this.label_pwlength.AutoSize = true;
            this.label_pwlength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pwlength.ForeColor = System.Drawing.Color.White;
            this.label_pwlength.Location = new System.Drawing.Point(39, 208);
            this.label_pwlength.Name = "label_pwlength";
            this.label_pwlength.Size = new System.Drawing.Size(78, 25);
            this.label_pwlength.TabIndex = 19;
            this.label_pwlength.Text = "Length";
            // 
            // label_pwnum
            // 
            this.label_pwnum.AutoSize = true;
            this.label_pwnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pwnum.ForeColor = System.Drawing.Color.White;
            this.label_pwnum.Location = new System.Drawing.Point(354, 243);
            this.label_pwnum.MinimumSize = new System.Drawing.Size(25, 25);
            this.label_pwnum.Name = "label_pwnum";
            this.label_pwnum.Size = new System.Drawing.Size(25, 25);
            this.label_pwnum.TabIndex = 20;
            this.label_pwnum.Text = "8";
            this.label_pwnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_copy
            // 
            this.button_copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.button_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_copy.ForeColor = System.Drawing.Color.White;
            this.button_copy.Location = new System.Drawing.Point(39, 610);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(340, 50);
            this.button_copy.TabIndex = 21;
            this.button_copy.Text = "COPY PASSWORD";
            this.button_copy.UseVisualStyleBackColor = false;
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.ForeColor = System.Drawing.Color.White;
            this.button_settings.Location = new System.Drawing.Point(279, 724);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(139, 100);
            this.button_settings.TabIndex = 24;
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
            this.button_generate.TabIndex = 23;
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
            this.button_vault.TabIndex = 22;
            this.button_vault.Text = "VAULT";
            this.button_vault.UseVisualStyleBackColor = false;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.button_vault);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.label_pwnum);
            this.Controls.Add(this.label_pwlength);
            this.Controls.Add(this.trackBar_pwlength);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox_number);
            this.Controls.Add(this.checkBox_lower);
            this.Controls.Add(this.checkBox_upper);
            this.Controls.Add(this.label_passworddisplay);
            this.Controls.Add(this.label_title);
            this.Name = "Generator";
            this.Size = new System.Drawing.Size(418, 824);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_pwlength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_passworddisplay;
        private System.Windows.Forms.CheckBox checkBox_upper;
        private System.Windows.Forms.CheckBox checkBox_lower;
        private System.Windows.Forms.CheckBox checkBox_number;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar trackBar_pwlength;
        private System.Windows.Forms.Label label_pwlength;
        private System.Windows.Forms.Label label_pwnum;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button button_vault;
    }
}
