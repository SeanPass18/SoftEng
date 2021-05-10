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
    public partial class SignIn : UserControl
    {
        public SignUp signUp { get; set; }
        public Vault vault { get; set; }

        public SignIn()
        {
            InitializeComponent();
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            signUp.BringToFront();
        }

        

        private void button_login_Click(object sender, EventArgs e)
        {
            vault.BringToFront();
        }
    }
}
