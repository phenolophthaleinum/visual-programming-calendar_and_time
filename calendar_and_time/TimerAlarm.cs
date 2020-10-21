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
    public partial class TimerAlarm : Form
    {
        //initialize timer
        Timer timer1 = new Timer();
        public TimerAlarm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            double time = 0; //timer time
            int ticks = 1000; //ticks count
            int seconds = 60; //seconds in minute

            //ensure box is not empty
            try
            {
                time = double.Parse(this.timeRichBox.Text);
            }
            catch(Exception)
            {
                return;
            }
            
            //convert to minutes
            timer1.Interval = (int)(ticks * seconds * time);
            //update time
            timer1.Tick += new EventHandler(showAlarmNotification);
            timer1.Start();
            this.startButton.Text = "Counting down";
            this.startButton.BackColor = Color.FromArgb(181, 40, 27);
        }

        private void showAlarmNotification(object sender, EventArgs e)
        {
            this.timer1.Stop();
            //overwrite previous timer
            timer1 = new Timer();
            this.startButton.Text = "Start";
            this.startButton.BackColor = Color.PaleGreen;
            //initialize alarm dialog window and show
            AlarmNotification alarm_window = new AlarmNotification(this);
            alarm_window.ShowDialog();
        }

        //getter to retrieve text from this window to show it in dialog window
        public string copyTopic
        {
            get
            {
                return this.topicRichBox.Text;
            }
        }
    }
}