using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendar_and_time
{
    public partial class Main : Form
    {
        string time_format = "HH:mm:ss"; //changing time format
        bool isBinary = false; //binary format switcher 
        public Main()
        {
            InitializeComponent();
            //labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //this runs every tick; updates displayed time
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isBinary != true)
            {
                labelTime.Text = DateTime.Now.ToString(this.time_format);
            }
            else
            {
                labelTime.Text = DateTime.Now.ToBinary().ToString();
            }
        }

        //changes format to 12h
        private void format12hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.isBinary = false;
            time_format = "hh:mm:ss tt";
        }

        //changes format to 24h
        private void format24hToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.isBinary = false;
            time_format = "HH:mm:ss";
        }

        //changes format to binary
        private void binToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.isBinary = true;
        }

        //initialise calendar window
        private void liczbaDniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendar calendar_window = new Calendar();
            calendar_window.Show();
        }

        //initialise timer window
        private void minutnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAlarm timer_window = new TimerAlarm();
            timer_window.Show();
        }
    }
}
