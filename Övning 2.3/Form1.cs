using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._3
{
    public partial class Form1 : Form
    {
        List<BankKonto> bankkonton = new List<BankKonto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Uppdatera()
        {
            listBox1.Items.Clear();
            foreach(BankKonto k in bankkonton)
            {
                listBox1.Items.Add(k);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                double belopp;
                if (!double.TryParse(tbxbelopp.Text, out belopp))
                {
                    MessageBox.Show("Felaktigt belopp");
                }
                (listBox1.SelectedItem as BankKonto).Insättning(belopp);
                Uppdatera();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string personNr = tbxPn.Text;
            double räntestats = double.Parse(tbxränta.Text);
            double kredit;

            if (!double.TryParse(tbxkredit.Text, out kredit))
            {
                MessageBox.Show("Kredit måste vara >= 0", Text);
            }
            else if (kredit == 0)
            {
                SparKonto nyttspar = new SparKonto(personNr, räntestats);
                listBox1.Items.Add(nyttspar);
                bankkonton.Add(nyttspar);
            }
            else
            {
                Lånekonto nyttlåne = new Lånekonto(personNr, räntestats, kredit);
                listBox1.Items.Add(nyttlåne);
                bankkonton.Add(nyttlåne);
            }


            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                double belopp;
                if (!double.TryParse(tbxbelopp.Text, out belopp))
                {
                    MessageBox.Show("Felaktigt belopp", Text);
                }
                if ((listBox1.SelectedItem as BankKonto).Uttag(belopp) == false){
                    MessageBox.Show("Medges ej");
                }
                (listBox1.SelectedItem as BankKonto).Uttag(belopp);
                Uppdatera();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(BankKonto k in bankkonton)
            {
                k.BeräknaRänta();
            }
            Uppdatera();
        }
    }
}
