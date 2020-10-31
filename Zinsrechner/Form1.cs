using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zinsrechner
{
    public partial class Form1 : Form
    {
        //Variablen
        int AusgewählteBerechnung;
        double Anfangskapital;
        double Endkapital;
        int Laufzeit;
        double Zinssatz;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Anfangskapitalberechnen_CheckedChanged(object sender, EventArgs e)
        {
            txt_Anfangskapital.Enabled = false;
            txt_Endkapital.Enabled = true;
            txt_Zinssatz.Enabled = true;
            txt_Laufzeit.Enabled = true;
            AusgewählteBerechnung = 1;
        }

        private void bt_Zinssatz_CheckedChanged(object sender, EventArgs e)
        {
            txt_Zinssatz.Enabled = false;
            txt_Anfangskapital.Enabled = true;
            txt_Endkapital.Enabled = true;
            txt_Laufzeit.Enabled = true;
            AusgewählteBerechnung = 2;
        }

        private void bt_Laufzeit_CheckedChanged(object sender, EventArgs e)
        {
            txt_Laufzeit.Enabled = false;
            txt_Anfangskapital.Enabled = true;
            txt_Endkapital.Enabled = true;
            txt_Zinssatz.Enabled = true;
            AusgewählteBerechnung = 3;
        }

        private void bt_Endkapital_CheckedChanged(object sender, EventArgs e)
        {
            txt_Endkapital.Enabled = false;
            txt_Anfangskapital.Enabled = true;
            txt_Laufzeit.Enabled = true;
            txt_Zinssatz.Enabled = true;
            AusgewählteBerechnung = 4;
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Text = default;
                    (item as TextBox).Enabled = true;
                }

                if (item is RadioButton)
                {
                    (item as RadioButton).Checked = default;
                }
            }
        }

        private void berechnen()
        {
            switch (AusgewählteBerechnung)
            {
                ////Anfangskapitalberechnen
                //case 1:
                //    //Eingabe
                //    Zinssatz = double.Parse(txt_Zinssatz.Text);
                //    Laufzeit = int.Parse(txt_Laufzeit.Text);
                //    Endkapital = double.Parse(txt_Endkapital.Text);

                //    //Verarbeitung
                //    Anfangskapital = Endkapital - (Zinssatz * 100 * 12)

                //    break;
                    
                
                //default:
                //    break;
            }
        }

        private void bt_Berechnen_Click(object sender, EventArgs e)
        {
            berechnen();
        }
    }
}

