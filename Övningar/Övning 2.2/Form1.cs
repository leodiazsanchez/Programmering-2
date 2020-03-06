using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._2
{
    public partial class Form1 : Form
    {
        List<Anställd> anställda = new List<Anställd>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string namn = tbxNamnSäljare.Text;
                double provision = double.Parse(tbxProvision.Text);
                double försäljning = double.Parse(tbxFörsäljning.Text);

                Säljare nyansälld = new Säljare(namn, provision, försäljning);
                lbxRegister.Items.Add(nyansälld);
                anställda.Add(nyansälld);
            }
            catch (FormatException)
            {
                MessageBox.Show("Fel");
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                string namn = tbxNamnKonslut.Text;
                double arbetadetimmmar = double.Parse(tbxTimlön.Text);
                double tid = double.Parse(tbxTid.Text);

                Konsult nyansälld = new Konsult(namn, arbetadetimmmar, tid);
                lbxRegister.Items.Add(nyansälld);
                anställda.Add(nyansälld);
            }
            catch
            {
                MessageBox.Show("Fel");
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string namn = tbxNamnKontorist.Text;
                double månadslön = double.Parse(tbxMånadslön.Text);

                Kontorist nyansälld = new Kontorist(namn, månadslön);
                lbxRegister.Items.Add(nyansälld);
                anställda.Add(nyansälld);
            }
            catch (FormatException)
            {
                MessageBox.Show("Fel");
            }
          
        }

        private void btnLöner_Click(object sender, EventArgs e)
        {
            lbxLön.Items.Clear();
            double tot = 0;
            foreach (Anställd A in anställda)
            {
                lbxLön.Items.Add(A.ToString() + A.BeräknaLön());
                tot += A.BeräknaLön();
            }

            tbxLönekostnad.Text = tot.ToString();
        }
    }
}
