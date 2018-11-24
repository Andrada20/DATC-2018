using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace Generare_date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int min = 40;
            int max = 101;
            Umiditate senzor1 = new Umiditate(0);
            Umiditate senzor2 = new Umiditate(0);
            Umiditate senzor3 = new Umiditate(0);
            //timer
            
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Start();
            
            textBox1.Text = Convert.ToString(senzor1.GetUmiditateValoare(min, max));
            textBox2.Text = Convert.ToString(senzor2.GetUmiditateValoare(min, max));
            textBox3.Text = Convert.ToString(senzor3.GetUmiditateValoare(min, max));
            timer.Stop();
            
        }
     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //Timer.Interval = 5000; 
            //timer.Tick += new EventHandler(timer_Tick);
         
            //void timer_Tick(object sender, EventArgs e)
            //{
            //    //Call method
               
            //}
        }
    }
}
