using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ātrā_Matemātika
{
    public partial class Form2 : Form
    {
        int sk1, sk2, sk3, zime, time;
        public static int izteiksmes = 0;
        private Timer timer;
        private int taimeraIlgums = 60;
        Random rand1 = new Random();
        Random rand2 = new Random();
        
        public static int punkti = 0;
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            taimeraIlgums--;
            taimeris.Text = time.ToString();            
            if (taimeraIlgums >= 0)
            {
                UpdateLabel();
            }
            else
            {
                timer.Stop();
                Form3 rezultats = new Form3();
                this.Hide();
                rezultats.Show();
            }
        }
        private void UpdateLabel()
        {
            TimeSpan timeRemaining = TimeSpan.FromSeconds(taimeraIlgums);
            taimeris.Text = string.Format("{0:D2}:{1:D2}", timeRemaining.Minutes, timeRemaining.Seconds);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            sk1 = rand1.Next(19) + 1;
            sk2 = rand1.Next(19) + 1;
            zime = rand2.Next(2);
            if (zime == 1)
            {
                label2.Text = sk1.ToString() + " " + zime.ToString("+") + " " + sk2.ToString() + " = ";
            }
            if (zime == 0)
            {
                label2.Text = sk1.ToString() + " " + zime.ToString("-") + " " + sk2.ToString() + " = ";
            }
            label7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool irSk = false;
            irSk = int.TryParse(textBox1.Text, out sk3);

            if (zime == 1)
            {
                if (sk1 + sk2 == sk3)
                {
                    label7.Visible = true;
                    label7.Text = "Pareizi";
                    label7.ForeColor = Color.PaleGreen;
                    punkti++;
                    Console.WriteLine("1+");
                }
                else
                {
                    label7.Visible = true;
                    label7.Text = "Nepareizi";
                    label7.ForeColor = Color.LightCoral;
                    Console.WriteLine("2+");
                }
            }
            else if (zime == 0)
            {
                if (sk1 - sk2 == sk3)
                {
                    label7.Visible = true;
                    label7.Text = "Pareizi";
                    label7.ForeColor = Color.PaleGreen;
                    punkti++;
                    Console.WriteLine("1-");
                }
                else
                {
                    label7.Visible = true;
                    label7.Text = "Nepareizi";
                    label7.ForeColor = Color.LightCoral;
                    Console.WriteLine("2-");
                }
            }

            sk1 = rand1.Next(19) + 1;
            sk2 = rand1.Next(19) + 1;
            zime = rand2.Next(2);

            label6.Text = "Punkti: " + punkti.ToString();
            izteiksmes++;

            if (zime == 1)
            {
                label2.Text = sk1.ToString() + " + " + sk2.ToString() + " = ";
            }
            else
            {
                label2.Text = sk1.ToString() + " - " + sk2.ToString() + " = ";
            }
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        public Form2()
        {
            InitializeComponent();
            InitializeTimer();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
