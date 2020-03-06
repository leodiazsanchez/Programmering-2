using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._8__2_
{
    public partial class Form1 : Form
    {
        List<Vara> varor = new List<Vara>();
       
        public Form1()
        {
            InitializeComponent();
            rbtnVikt.Checked = true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string vara = tbxItem.Text;
                double pris = double.Parse(tbxPrice.Text);
                int mängd = int.Parse(tbxAmount.Text);

                if (rbtnVikt.Checked == true)
                {
                    LösVikt nyvara = new LösVikt(vara, pris, mängd);
                    varor.Add(nyvara);
                    lbxItems.Items.Add(nyvara);
                }
                else
                {
                    StyckSak nyvara = new StyckSak(vara, pris, mängd);
                    varor.Add(nyvara);
                    lbxItems.Items.Add(nyvara);
                }

                double tot = 0;

                foreach (Vara v in varor)
                {
                    tot += v.BeräknaPris();
                }

                tbxSum.Text = tot.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Pris och mängd får endast innehålla siffror. Mängd får endast vara ett heltal.");
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lbxItems.Items.Clear();
            varor.Sort();
            foreach(Vara v in varor)
            {
                lbxItems.Items.Add(v);
            }
        }
    }
}
