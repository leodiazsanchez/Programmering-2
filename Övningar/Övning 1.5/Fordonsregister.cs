using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Övning_1._5
{
    public partial class Fordonsregister : Form
    {
        List<Fordon> fordon = new List<Fordon>();
        public Fordonsregister()
        {
            InitializeComponent();
            cbxTyp.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regNr = Fordon.GodkännRegNr(tbxreg.Text);
            if (regNr == null)
            {
                MessageBox.Show("Ange reg enligt ABC123", Text);
                return;
            }

            foreach (Fordon f in fordon)
            {
                if(regNr == f.RegNr)
                {
                    MessageBox.Show("Regnr finns redan", Text); return;
                }
            }

            string märke = tbxmärke.Text;
            if (märke == "")
            {
                MessageBox.Show("Ange märke", Text); return;
            }

            string modell = tbxmodell.Text;
            if (modell == "")
            {
                MessageBox.Show("Ange modell", Text); return;
            }

            Fordon nyttfordon = new Fordon(regNr, tbxmärke.Text, tbxmodell.Text,(Fordon.Typ)cbxTyp.SelectedIndex);

            fordon.Add(nyttfordon);
            lbxRegister.Items.Add(nyttfordon);
            tbxreg.Clear();
            tbxmodell.Clear();
            tbxmärke.Clear();

        }

        private void rbtnAlla_CheckedChanged(object sender, EventArgs e)
        {
            lbxRegister.Items.Clear();

            foreach (Fordon f in fordon)
            {
                lbxRegister.Items.Add(f);
            }
        }

        private void rbtnBilar_CheckedChanged (object sender, EventArgs e)
        {
            lbxRegister.Items.Clear();

            foreach (Fordon f in fordon)
            {
                if (f.FordonsTyp == Fordon.Typ.Bil) 

                lbxRegister.Items.Add(f);
            }
        }

        private void rbtnMC_CheckedChanged(object sender, EventArgs e)
        {
            lbxRegister.Items.Clear();

            foreach (Fordon f in fordon)
            {
                if (f.FordonsTyp == Fordon.Typ.MC)

                    lbxRegister.Items.Add(f);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
