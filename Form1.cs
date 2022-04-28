using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulaator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string tehing;
        public string tähed = "abcdefghijklmnopqrstuvõäöüxyz";

        private void btnArvuta_Click(object sender, EventArgs e)
        {
            Matemaatika arv = new Matemaatika();

            try
            {
                arv.number1 = Convert.ToSingle(txtArv1.Text);
                arv.number2 = Convert.ToSingle(txtArv2.Text);
                Single tulemused = arv.arvutus();


                if (chkLiida.Checked)
                {
                    arv.tehing = "+";
                    lblVastus.Text = Convert.ToString(arv.number1) + arv.tehing + Convert.ToString(arv.number2) + " = " + Convert.ToString(tulemused);
                }
                else if (chkLahuta.Checked)
                {
                    arv.tehing = "-";

                    lblVastus.Text = Convert.ToString(arv.number1) + arv.tehing + Convert.ToString(arv.number2) + " = " + Convert.ToString(tulemused);
                }
                else if (chkKorruta.Checked)
                {
                    arv.tehing = "*";
                    lblVastus.Text = Convert.ToString(arv.number1) + arv.tehing + Convert.ToString(arv.number2) + " = " + Convert.ToString(tulemused);
                }
                else if (chkJaga.Checked)
                {
                    arv.tehing = "/";
                    lblVastus.Text = Convert.ToString(arv.number1) + arv.tehing + Convert.ToString(arv.number2) + " = " + Convert.ToString(tulemused);
                }
            }
            catch
            {
                if (txtArv1.Text == "")
                {
                    MessageBox.Show("Sisesta esimene arv!");
                }
                if (txtArv2.Text == "")
                {
                    MessageBox.Show("Sisesta teine arv!");
                }
                if (arv.tehing == "")
                {
                    MessageBox.Show("Vali tehing!");
                }
                
            }
        }
    }
}
