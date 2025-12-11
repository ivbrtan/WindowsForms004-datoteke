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

namespace WindowsForms005datoteke
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string linija;
            linija=textBox1.Text+"|"+textBox2.Text+"|"+comboBox1.Text+"|"+comboBox2.Text;
            StreamWriter sw = new StreamWriter("ucenici.txt", true);
            sw.WriteLine(linija);
            sw.Close();
            textBox2.Text="";
            textBox1.Text="";
            comboBox1.Text="";
            comboBox2.Text="";
            MessageBox.Show("Podaci su spremljeni!");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
