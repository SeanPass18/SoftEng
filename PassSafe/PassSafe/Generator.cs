using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace PassSafe
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]

    public partial class Generator : UserControl
    {
        public Vault vault { get; set; }
        public Notes notes { get; set; }
        public Settings settings { get; set; }


        public Generator()
        {
            InitializeComponent();
        }

        private void Generator_Load(object sender, EventArgs e)
        {
            label_pwnum.Text = "8";
            trackBar_pwlength.Minimum = 8;
            trackBar_pwlength.Maximum = 25;
            trackBar_pwlength.TickStyle = TickStyle.BottomRight;
            trackBar_pwlength.TickFrequency = 1;
        }

        private void button_vault_Click(object sender, EventArgs e)
        {
            vault.BringToFront();
        }

        private void button_notes_Click(object sender, EventArgs e)
        {
            notes.BringToFront();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            settings.BringToFront();
        }

        private void trackBar_pwlength_Scroll(object sender, EventArgs e)
        {
            label_pwnum.Text = trackBar_pwlength.Value.ToString();
        }
    }
}
