using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);

            int ab = a.CompareTo(b);
            int bc = b.CompareTo(c);
            int ca = c.CompareTo(a);

            if (ab != 0 && bc != 0 && ca != 0)
            {
                tbxSvar.Text = "Inga tal är lika";
            }
            else if (ab == 0 && bc == 0 && ca == 0)
            {
                tbxSvar.Text = "Alla tal är lika";
            }
            else if (ab == 0)
            {
                tbxSvar.Text = "Tal 1 och 2 är lika";
            }
            else if (bc == 0)
            {
                tbxSvar.Text = "Tal 2 och 3 är lika";
            }
            else if (ca == 0)
            {
                tbxSvar.Text = "Tal 3 och 1 är lika";
            }
            else
            {
                tbxSvar.Text = "Error";
            }


        }
    }
}
