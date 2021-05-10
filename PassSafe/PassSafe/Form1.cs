using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PassSafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            signIn1.BringToFront();
  
            signIn1.signUp = signUp1;
            signUp1.signIn = signIn1;
            signIn1.vault = vault1;
            vault1.generator = generator1;
            vault1.settings = settings1;
            generator1.vault = vault1;
            generator1.settings = settings1;
            settings1.vault = vault1;
            settings1.generator = generator1;
            settings1.signIn = signIn1;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }

}
