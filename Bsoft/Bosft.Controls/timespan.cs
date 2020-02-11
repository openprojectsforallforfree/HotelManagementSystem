using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class timespan : UserControl        
    {
        public delegate void spanChanged(int days);
        public event spanChanged SpanChanged;
        public timespan()
        {
            InitializeComponent();
            DateTime nextday = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtTo.Value = nextday.AddDays(1);
            dtFrom.MaxDate = dtTo.Value;
            dtTo.MinDate = dtFrom.Value;
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            dtTo.MinDate = dtFrom.Value;
            lblSpan.Text = DaysSpan.ToString() + " Days";
            if (SpanChanged != null)
            {
                SpanChanged(DaysSpan);
            }

        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            dtFrom.MaxDate = dtTo.Value;
            lblSpan.Text = DaysSpan.ToString() + " Days";
            if (SpanChanged != null)
            {
                SpanChanged(DaysSpan);
            }
        }

        public int DaysSpan
        {
            get { return (dtTo.Value - dtFrom.Value).Days; }
        }
    }
}
