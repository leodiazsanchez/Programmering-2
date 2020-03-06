using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyttetävling2
{
    public partial class Form1 : Form
    {
        private List<Skytt> skyttar = new List<Skytt>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            string name = tbxnamn.Text;
            int points;

            foreach (Skytt s in skyttar)
            {
                if (name == s.Namn)
                {
                    MessageBox.Show("Personen är redan registerad", Text); return;
                }
            }

            if (!int.TryParse(tbxpoängreg.Text, out points))
            {
                MessageBox.Show("Parse failed");
                return;
            } else if (points < 0 || points > 50)
            {
                MessageBox.Show("Poängen ligger utanför intervallet");
                return;
            }

            Skytt skytt = new Skytt(name, points);
            skyttar.Add(skytt);
            listOut.Items.Add(skytt).ToString();
            tbxnamn.Text = "";
            tbxpoängreg.Text = "";

            MessageBox.Show("Resulatet är registerat");
        }

        private void btnurval_Click(object sender, EventArgs e)
        {
            int points;

            if (!int.TryParse(tbxpoängsök.Text, out points))
            {
                MessageBox.Show("Parse failed");
                return;
            }
            else if (points < 0 || points > 50)
            {
                MessageBox.Show("Poängen ligger utanför intervallet");
                return;
            }

            listOut.Items.Clear();

            foreach (Skytt s in skyttar)
            {
                if (s.Poäng >= points)

                    listOut.Items.Add(s);
            }
        }
    }
}
