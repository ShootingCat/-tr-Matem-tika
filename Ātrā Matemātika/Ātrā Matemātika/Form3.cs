using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ātrā_Matemātika
{
    public partial class Form3 : Form
    {
        float procenti = 0;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label4.Text = "Pareizi: " + Form2.punkti.ToString();
            label5.Text = "Izteiksmes: " + Form2.izteiksmes.ToString();
            procenti = ((float)Form2.punkti / Form2.izteiksmes) * 100;
            procenti = (float)Math.Round(procenti);
            label2.Text = procenti.ToString() + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sakums = new Form1();
            sakums.Show();
        }
    }
}
