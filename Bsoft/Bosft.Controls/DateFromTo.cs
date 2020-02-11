using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Controls
{
    public partial class DateFromTo : UserControl
    {
        public DateFromTo()
        {
            InitializeComponent();
        }
        TimeSpan days = new TimeSpan();
        public double Days
        {
            get { return days.TotalDays; }

        }
        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            days = dtTo.Value - dtFrom.Value;
            lblDays.Text = days.Days.ToString() + " Days";
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            days = dtTo.Value - dtFrom.Value;
            lblDays.Text = days.Days.ToString() + " Days";
        }
    }
}
