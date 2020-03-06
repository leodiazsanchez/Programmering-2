using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetoderEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            char gemen = char.Parse(tbxIn.Text);
            //Metodanrop
            char v = Omvandla(gemen);

            tbxUt.Text = v.ToString();

        }

        //Metodeffiniton
        char Omvandla (char v)
        {
            int kod = v - 32;
            char versal = (char) kod;
            return versal;
        }
    }
}
