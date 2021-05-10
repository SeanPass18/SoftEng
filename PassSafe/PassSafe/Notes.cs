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

    public partial class Notes : UserControl
    {
        public Vault vault { get; set; }
        public Generator generator { get; set; }
        public Settings settings { get; set; }

        public Notes()
        {
            InitializeComponent();
        }

        private void button_vault_Click(object sender, EventArgs e)
        {
            vault.BringToFront();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            generator.BringToFront();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            settings.BringToFront();
        }
    }
}
