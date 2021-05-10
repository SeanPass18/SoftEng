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
    public partial class SignUp : UserControl
    {
        public SignIn signIn { get; set; }

        public SignUp()
        {
            InitializeComponent();
        }

        private void button_createaccount_Click(object sender, EventArgs e)
        {
            signIn.BringToFront();
        }
    }
}
