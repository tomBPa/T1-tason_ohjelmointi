﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus12
{
    public partial class Form1 : Form
    {
        string[] oikeatVastaukset = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[] vastaukset = new string[10];
        int laskuri = 0;
        int oikein = 0;
        public Form1()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            VastausBRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            VastausCRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            VastausDRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                laskuri++;
                KysymysLB.Text = "Vastaus " + (laskuri) + ". kysymykseen:";
            }
            else
            {
                VastausLB.Text = "";
                VastausARB.Enabled = false;
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;
                for(int j = 0; j < 10; j++)
                {
                    if(vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if(VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--;
            }
            if (VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }
            if (VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;
                laskuri--;
            }
            if (VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;
                laskuri--;
            }
        }

    }
}
