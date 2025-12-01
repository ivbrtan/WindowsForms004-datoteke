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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms004_datoteke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
           string linija;
            linija = txtIme.Text + "|" + txtPrezime.Text + "|" + txtIndeks.Text;
            StreamWriter sw = new StreamWriter("studenti.txt", true);
            sw.WriteLine(linija);
            sw.Close();
            txtPrezime.Text = "";
            txtIme.Text = "";
            txtIndeks.Text = "";
            MessageBox.Show("Podaci su spremljeni!");

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {

            string linija;
            StreamReader sr = new StreamReader("studenti.txt");
            linija = sr.ReadLine();
            List<string> lstStr = new List<string>();
            while (linija != null)
            {
                linija = linija.Replace("|", " ");
                lstStr.Add(linija);
                linija = sr.ReadLine();
            }
            lstStudenti.DataSource = lstStr;

            sr.Close();

        }
    }
}
