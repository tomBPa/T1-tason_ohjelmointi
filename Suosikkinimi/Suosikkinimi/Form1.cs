﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suosikkinimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkistaTB_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\Omistaja\\source\\repos\\T1-tason_ohjelmointi\\Suosikkinimi\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Users\\Omistaja\\source\\repos\\T1-tason_ohjelmointi\\Suosikkinimi\\tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;
            foreach (string poika in pojat)
            {
                if (nimi == poika)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi on vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta :-(";
                VastausLB.Visible = true;
            }
        }
    }
}
        
    

