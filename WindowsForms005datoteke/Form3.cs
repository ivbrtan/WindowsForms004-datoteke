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

namespace WindowsForms005datoteke
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        void UcitajSve()
        {
            listBox1.Items.Clear();

            if (File.Exists("ucenici.txt") == false)
                return;

            StreamReader sr = new StreamReader("ucenici.txt");
            while (sr.EndOfStream == false)
            {
                string linija = sr.ReadLine();
                string[] podaci = linija.Split('|');

                ucenik u = new ucenik();
                u.Ime = podaci[0];
                u.Prezime = podaci[1];
                u.Razred = podaci[2];
                u.Uspjeh = podaci[3];

                listBox1.Items.Add(u);
            }
            sr.Close();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            listBox1.Items.Clear();

            StreamReader sr = new StreamReader("ucenici.txt");
            while (!sr.EndOfStream)
            {
                string linija = sr.ReadLine();
                string[] podaci = linija.Split('|');

                if (podaci[2] == comboBox1.Text)
                {
                    ucenik u = new ucenik();
                    u.Ime = podaci[0];
                    u.Prezime = podaci[1];
                    u.Razred = podaci[2];
                    u.Uspjeh = podaci[3];

                    listBox1.Items.Add(u);
                }
            }
            sr.Close();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
                return;

            List<string> noveLinije = new List<string>();
            string odabrani = listBox1.SelectedItem.ToString();

            StreamReader sr = new StreamReader("ucenici.txt");
            while (!sr.EndOfStream)
            {
                string linija = sr.ReadLine();

                if (linija.Contains(odabrani))
                {

                }
                else
                {
                    noveLinije.Add(linija);
                }
            }
            sr.Close();

            File.WriteAllLines("ucenici.txt", noveLinije);
            UcitajSve();
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Click(object sender, EventArgs e)
        {
            UcitajSve();
        }
    }
    
}
