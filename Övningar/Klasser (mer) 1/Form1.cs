using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasser__mer__1
{
    

    public partial class Form1 : Form
    {
        Resa[] resor = new Resa[1000];
        int antalResor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoka_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            lbxOut.Items.Clear();

            string kund = tbxNamn.Text;

            for (int i = 0; i < antalResor; i++)
            {
                if (resor[i].Kund == kund)
                {
                    lbxOut.Items.Add(resor[i]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBoka_Click_1(object sender, EventArgs e)
        {
            string kund = tbxKund.Text;
            string dest = tbxDest.Text;
            int dagar = int.Parse(tbxDagar.Text);

            Resa nyResa = new Resa(kund, dest, dagar);
            resor[antalResor++] = nyResa;

            MessageBox.Show("Resan är bokad", "Bekräftelse", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tbxKund.Text = "";
            tbxDest.Text = "";
            tbxDagar.Text = "";
        }
    }

}
