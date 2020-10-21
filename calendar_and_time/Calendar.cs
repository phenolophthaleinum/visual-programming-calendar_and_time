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
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        //calculate interval
        private void calcButton_Click(object sender, EventArgs e)
        {
            TimeSpan interval = this.monthCalendarFrom.SelectionRange.Start -
                this.monthCalendarTo.SelectionRange.End;
            int res = Math.Abs((int)interval.TotalDays); //absolute value
            this.resultRichBox.Text = "Przedział dni: " + res.ToString(); //type interval in the box
        }
    }
}
