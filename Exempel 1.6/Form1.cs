using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exempel_1._6
{
    public partial class Form1 : Form
    {
        Konto konto;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string epost = tbxuser.Text;
            string lösen = tbxpw.Text;

            try
            {
                konto = new Konto(epost, lösen);
            }
            catch (EpostAdressFormatException felepost)
            {
                MessageBox.Show(felepost.ToString());
                return;
            }
            catch (LösenFormatException fellösen)
            {
                MessageBox.Show(fellösen.ToString());
                return;
            } 

            MessageBox.Show("Konto skapat");
        }
    }
}
