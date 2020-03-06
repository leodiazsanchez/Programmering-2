using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._4
{
    public partial class Form1 : Form
    {
        List<Figur> Figurer = new List<Figur>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bredd;
            double höjd;

            if (!double.TryParse(tbxbredd.Text, out bredd))
            {
                MessageBox.Show("Endast siffror", Text);
                return;
            } else if(bredd <= 0)
            {
                MessageBox.Show("Bredden måste vara större än 0", Text);
                return;
            }

            if (!double.TryParse(tbxhöjd.Text, out höjd))
            {
                MessageBox.Show("Endast siffror", Text);
                return;
            }
            else if (höjd <= 0)
            {
                MessageBox.Show("Höjden måste vara större än 0", Text);
                return;
            }

            Triangel figur = new Triangel(bredd,höjd);
            listBox1.Items.Add(figur);
            Figurer.Add(figur);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double bredd;
            double höjd;

            if (!double.TryParse(tbxbredd.Text, out bredd))
            {
                MessageBox.Show("Endast siffror", Text);
                return;
            }
            else if (bredd <= 0)
            {
                MessageBox.Show("Bredden måste vara större än 0", Text);
                return;
            }

            if (!double.TryParse(tbxhöjd.Text, out höjd))
            {
                MessageBox.Show("Endast siffror", Text);
                return;
            }
            else if (höjd <= 0)
            {
                MessageBox.Show("Höjden måste vara större än 0", Text);
                return;
            }

            Cirkel figur = new Cirkel(bredd, höjd);
            listBox1.Items.Add(figur);
            Figurer.Add(figur);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double bredd;
            double höjd;

            if (!double.TryParse(tbxbredd.Text, out bredd))
            {
                MessageBox.Show("Endast siffror", Text);
                return;
            }

            if (!double.TryParse(tbxhöjd.Text, out höjd))
            {
                MessageBox.Show("Endast siffror", Text);
                return;
            }

            Linje figur = new Linje(bredd, höjd);
            listBox1.Items.Add(figur);
            Figurer.Add(figur);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double tot = 0;
            foreach(Figur f in Figurer)
            {
                if(f is IArea)
                {
                    tot += (f as IArea).Area();
                }
            }

            tbxarea.Text = tot.ToString() + " cm\u00b2";
        }
    }
}
