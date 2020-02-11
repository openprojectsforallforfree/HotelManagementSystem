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
    public partial class DateFromTo2 : UserControl
    {
        public DateFromTo2()
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
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            dtFrom.MaxDate = dtTo.Value;
        }
    }
}
