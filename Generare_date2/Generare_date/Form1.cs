using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Generare_date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bool pompa1 = false;
            bool pompa2 = false;
            bool pompa3 = false;
            int min = 40;
            int max = 101;
            Umiditate senzor1 = new Umiditate(0);
            Umiditate senzor2 = new Umiditate(0);
            Umiditate senzor3 = new Umiditate(0);
            //pompa_on &pompa_off trebuie luate din worker 
            
            textBox1.Text = Convert.ToString(senzor1.GetUmiditateValoare(min, max));
            textBox2.Text = Convert.ToString(senzor2.GetUmiditateValoare(min, max));
            textBox3.Text = Convert.ToString(senzor3.GetUmiditateValoare(min, max));

            while(pompa1 == true)
            {
                senzor1.Incrementare(Convert.ToInt32(textBox1.Text));
            }
            while (pompa1 == false)
            {
                senzor1.Decrementare(Convert.ToInt32(textBox1.Text));
            }
            while (pompa2 == true)
            {
                senzor2.Incrementare(Convert.ToInt32(textBox1.Text));
            }
            while (pompa2 == false)
            {
                senzor2.Decrementare(Convert.ToInt32(textBox1.Text));
            }
            while (pompa3 == true)
            {
                senzor3.Incrementare(Convert.ToInt32(textBox1.Text));
            }
            while (pompa3 == false)
            {
                senzor3.Decrementare(Convert.ToInt32(textBox1.Text));
            }
            
        }

        //public 
     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
