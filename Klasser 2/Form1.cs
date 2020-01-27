using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasser_2
{
    public partial class Form1 : Form
    {
        private List<Elev> elever = new List<Elev>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            int points;

            if (!int.TryParse(tbxPoints.Text, out points))
            {
                MessageBox.Show("Parse failed");
                return;
            }

            Elev elev = new Elev(name, points);
            elever.Add(elev);
            listOut.Items.Add(elev).ToString();
            tbxName.Text = "";
            tbxPoints.Text = "";

        }

        private void btnremove_Click(object sender, EventArgs e)

        {
            //listOut.Items.Clear();
            if (listOut.Items.Count == 0){
                MessageBox.Show("Det finns inga elever att ta bort");
            }
            else
            {
                listOut.Items.RemoveAt(listOut.Items.Count - 1);
            }


            /*foreach (Elev elev in elever)
            {
                listOut.Items.Add(elev);
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int min = int.Parse(tbxmin.Text);
            int count = 0;

            foreach (Elev elev in elever)
            {
                if (elev.ÄrGodkänd(min))
                count++;
            }
            tbxabove.Text = count.ToString();
        }

        //public static bool TryParse(string s, out int result);

    }
}
