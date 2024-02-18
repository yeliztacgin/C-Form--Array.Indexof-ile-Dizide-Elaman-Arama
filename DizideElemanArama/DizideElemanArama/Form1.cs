using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizideElemanArama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sehirler = {"Konya","Ankara","Eskisehir","Adana" };
            int sira = Array.IndexOf(sehirler, textBox1.Text);


            if (sira==-1)
            {
                label1.Text = "Sehir ismi bulunamadı";
            }
            else
            {
                label1.Text = "Aranılan sehir" + (sira + 1) + ".siradadir";
            }
        
        }
    }
}
