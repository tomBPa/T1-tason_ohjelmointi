using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paivakirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TallennaTB_Click(object sender, EventArgs e)
        {
            string teksti = System.IO.File.ReadAllText("C:\\Users\\Omistaja\\source\\repos\\T1-tason_ohjelmointi\\Paivakirja\\demo.txt");
            teksti += syottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter txt = new StreamWriter("C:\\Users\\Omistaja\\source\\repos\\T1-tason_ohjelmointi\\Paivakirja\\demo.txt");
            txt.Write(teksti);
            txt.Close();
            Application.Exit();
        }
    }
}
