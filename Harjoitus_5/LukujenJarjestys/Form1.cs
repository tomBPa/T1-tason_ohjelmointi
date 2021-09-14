using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukujenJarjestys
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestys()
       {
            InitializeComponent();
       }
        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] jonot = jono.ToArray();
                    Array.Sort(jonot);
                    foreach (var item in jonot)
                    {
                        VastausLB.Text += item + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(uusiLukuTB.Text));
                    uusiLukuTB.Text = "";
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }



    }
}