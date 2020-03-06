using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string namn = txtAnv.Text;
            string lösen = txtLösen.Text;
            if (namn == ""){
                lblResultat.Text = "Var god fyll i obligatoriska fält";
                txtAnv.BackColor = Color.Red;
            }
            if (lösen == "")
            {
                lblResultat.Text = "Var god fyll i obligatoriska fält";
                txtLösen.BackColor = Color.Red;
            }
            else
            {
                lblResultat.Text = "Registeringen lyckades";
                txtLösen.BackColor = Color.White;
                txtAnv.BackColor = Color.White;
            }
  
        }
    }
}
