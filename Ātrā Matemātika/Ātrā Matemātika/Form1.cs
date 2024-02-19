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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tavs uzdevums ir pareizi atrisināt izteiksmes, ierakstot savu atbildi teksta lodziņā.\n\n" +
                "Kad esi ievadījis savu atbildi, nospied zaļo pogu, lai uzzinātu, vai ir pareizi atbildēts vai nē.\n" +
                "Ja atbildēsi pareizi, tad iegūsi 1 punktu.\n" +
                "Ja atbildēsi nepareizi, punktu nedabūsi.\n" +
                "Kad taimeris ir ticis līdz 0:00, tad spēle ir beigusies.\n\n" +
                "Spēli veidoja: Kristians Svika 11.klase\n" ,
                "Spēles \"Ātrā Matemātika\" instrukcija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 spele = new Form2();
            spele.Show();
        }
    }
}
