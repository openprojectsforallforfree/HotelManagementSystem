using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Bsoft.Date
{
    public partial class frmCalendar : Form
    {
        public frmCalendar()
        {
            InitializeComponent();
            
        }
        public frmCalendar(string _nepalidate,string format)
        {
            Nepalidate = new Bsoft.Date.NepaliDate(_nepalidate, format, false);

            InitializeComponent();
            try
            {
                calendar1.year = (short)Nepalidate.Year;
                calendar1.month = (short)Nepalidate.Month;
                calendar1.cal1.SelectedNepaliDate = Nepalidate;
                calendar1.Refresh();
            }
            catch { }
        }
        //public frmCalendar(NepaliDate _nepalidate)
        //{
        //    Nepalidate = _nepalidate;
        //    InitializeComponent();
        //    try
        //    {
        //        calendar1.year = (short)_nepalidate.Year;
        //        calendar1.month = (short)_nepalidate.Month;
        //        Nepalidate = _nepalidate;
        //        calendar1.Refresh();
        //    }
        //    catch { }
        //}
        public NepaliDate Nepalidate
        { get; set; }
        private void calendar1_Alarms(object sender, DateEventArgs e)
        {
            Nepalidate = new NepaliDate(e.year, e.month, e.day);
            DialogResult = DialogResult.OK;
        }

        private void frmCalendar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode  == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        public int topmargin = 30;
        private bool isinside(Point pt)
        {
            
            if (pt.X > Left & pt.X < Right)
            {
                if (pt.Y > Top - topmargin & pt.Y < Bottom)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public bool fromCommand;

        public string file;
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern short GetAsyncKeyState(int vkey);

        private const  int MC_LBUTTON = 0x1;
        private const  int MC_RBUTTON = 0x2;

        private void timer1_Tick(object sender, EventArgs e)
        {

            //MessageBox.Show(GetAsyncKeyState(MC_LBUTTON).ToString ());
            //Function by Dhiraj
            if (GetAsyncKeyState(MC_LBUTTON) !=0 | GetAsyncKeyState(MC_RBUTTON)!=0)
            {
                if (isinside(Cursor.Position))
                {
                }
                else
                {
                        TimerVisibility.Enabled = false;
                        DialogResult = DialogResult.Cancel;
                }
            }
        }

        
    }
}
