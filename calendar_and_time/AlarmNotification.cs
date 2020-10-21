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
    public partial class AlarmNotification : Form
    {
        string copied_topic; //string to contain copied text from previous window
        
        //calls getter to retrieve text from previous window
        public AlarmNotification(TimerAlarm timer_window)
        {
            InitializeComponent();
            this.copied_topic = timer_window.copyTopic;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //assign copied text
        private void AlarmNotification_Load(object sender, EventArgs e)
        {
            this.topicRichBox.Text = this.copied_topic;
        }
    }
}
