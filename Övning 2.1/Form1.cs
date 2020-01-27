using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._1
{
    public partial class Form1 : Form
    {
        List<Media> media = new List<Media>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int antalsidor;
            string titel = tbxtitelbok.Text;
            foreach (Media b in media)
            {
                if (titel == b.titel)
                {
                    MessageBox.Show("Titeln finns redan", Text); return;
                }
            }
            if (!int.TryParse(tbxsidorbok.Text, out antalsidor))
            {
                MessageBox.Show("Parse failed");
                return;
            }
            Bok nybok = new Bok(titel, antalsidor);
            media.Add(nybok);
            listBox1.Items.Add(nybok);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string titel = tbxtitelljud.Text;
            double speltid;
            foreach (Media l in media)
            {
                if (titel == l.titel)
                {
                    MessageBox.Show("Titeln finns redan", Text); return;
                }
            }
            if (!double.TryParse(tbxspeltid.Text, out speltid))
            {
                MessageBox.Show("Parse failed");
                return;
            }
            Ljud nyttljud = new Ljud(titel, speltid);
            media.Add(nyttljud);
            listBox1.Items.Add(nyttljud);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string titel = tbxtitelfilm.Text;
            double speltid;
            string upplösning = tbxupplösning.Text;
            foreach (Media f in media)
            {
                if (titel == f.titel)
                {
                    MessageBox.Show("Titeln finns redan", Text); return;
                }
            }
            if (!double.TryParse(tbxspeltidfilm.Text, out speltid))
            {
                MessageBox.Show("Parse failed");
                return;
            }
            Film nyfilm = new Film(titel, speltid, upplösning);
            media.Add(nyfilm);
            listBox1.Items.Add(nyfilm);
        }
    }
}
