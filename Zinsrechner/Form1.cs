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
        }

        private void bt_Zinssatz_CheckedChanged(object sender, EventArgs e)
        {
            txt_Zinssatz.Enabled = false;
            txt_Anfangskapital.Enabled = true;
            txt_Endkapital.Enabled = true;
            txt_Laufzeit.Enabled = true;
        }

        private void bt_Laufzeit_CheckedChanged(object sender, EventArgs e)
        {
            txt_Laufzeit.Enabled = false;
            txt_Anfangskapital.Enabled = true;
            txt_Endkapital.Enabled = true;
            txt_Zinssatz.Enabled = true;
        }

        private void bt_Endkapital_CheckedChanged(object sender, EventArgs e)
        {
            txt_Endkapital.Enabled = false;
            txt_Anfangskapital.Enabled = true;
            txt_Laufzeit.Enabled = true;
            txt_Zinssatz.Enabled = true;
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            //foreach (var item in this.Controls)
            //{
            //    if ()
            //    {

            //    }
            //}
        }
    }
}

