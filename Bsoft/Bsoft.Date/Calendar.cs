using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Date
{
    public partial class Calendar : UserControl
    {
        public Calendar()
        {

            initialiseCalendar((short )Bsoft.Date.NepaliDate.Today.Year,(short ) Bsoft.Date.NepaliDate.Today.Month );
        }
        public Calendar(short year_,short month_)
        {
            initialiseCalendar(year_,month_);
        }
        public void initialiseCalendar(short year_,short month_)
        {

            year = year_;
            month = month_;
            calForeColor = Color.Black;
            InitializeComponent();



            //From cal
            calBackColor = Color.Transparent;
            showBorder = true;


            ShadowBackColor = Color.Transparent;
            NormalBackColor = Color.Transparent;
            weekNameFormat = WeekNameFormat.Short;
            //From Cal

            //From Atom
            showShadow = false;
            showToolTip = false;
            showEnglish = true;
            HoverColor = Color.Aqua;
            SelectedColor = Color.Red;
            TodayColor = Color.Green;
            EnglishForeColor = Color.Magenta;
            NepaliForeColor = Color.DarkBlue;
            //From Atom

            //From Week Atom
            weekBackColor = Color.Beige;


            //From Week Atom

            lblToday.Text = "आज : " + NepaliDate.Today.ToString(true, "dd/mm/yyyy") + "(" + DateTime.Today.Date.ToShortDateString() + ")";
        }
        #region "Properties"
        #region "Properties week atom"
        [Category("Nepali Calendar")]
        public Color weekBackColor { get { return WeekAtom.weekBackColor; } set { WeekAtom.weekBackColor = value; } }
       
        #endregion

        #region "Properties from Atom"
        [Category("Nepali Calendar")]
        public bool showShadow { get { return ATOM.showShadow; } set { ATOM.showShadow = value; } }
        [Category("Nepali Calendar")]
        public bool showToolTip { get { return ATOM.showToolTip; } set { ATOM.showToolTip = value; } }
        [Category("Nepali Calendar")]
        public bool showEnglish { get { return ATOM.showEnglish; } set { ATOM.showEnglish = value; } }

        [Category("Nepali Calendar")]
        public Color HoverColor { get { return ATOM.HoverColor; } set { ATOM.HoverColor = value; } }
        [Category("Nepali Calendar")]
        public Color TodayColor { get { return ATOM.TodayColor; } set { ATOM.TodayColor = value; } }
        [Category("Nepali Calendar")]
        public Color SelectedColor { get { return ATOM.SelectedColor; } set { ATOM.SelectedColor = value; } }

        [Category("Nepali Calendar")]
        public Color EnglishForeColor { get { return ATOM.EnglishForeColor; } set { ATOM.EnglishForeColor = value; } }
        [Category("Nepali Calendar")]
        public Color NepaliForeColor { get { return ATOM.NepaliForeColor; } set { ATOM.NepaliForeColor = value; } }

        [Category("Nepali Calendar")]
        public bool  autoSizeFont { get { return ATOM.autoSizeFont; } set { ATOM.autoSizeFont = value; } }
        [Category("Nepali Calendar")]
        public float  EnglishFontHeight { get { return ATOM.EnglishFontHeight; } set { ATOM.EnglishFontHeight = value; } }
        [Category("Nepali Calendar")]
        public float NepaliFontHeight { get { return ATOM.NepaliFontHeight; } set { ATOM.NepaliFontHeight = value; } }



        #endregion
        #region "Properties from cal"
        [Category("Nepali Calendar")]
        public Color ShadowBackColor { get { return cal1.ShadowBackColor; } set { cal1.ShadowBackColor = value; } }
        [Category("Nepali Calendar")]
        public Color NormalBackColor { get { return cal1.NormalBackColor; } set { cal1.NormalBackColor = value; } }
        //public Color SelectedColor { get { return cal1.SelectedColor; } set { cal1.SelectedColor = value; } }
        [Category("Nepali Calendar")]
        public Color calBackColor { get { return cal1.calBackColor; } set { cal1.calBackColor = value; } }
        [Category("Nepali Calendar")]
        public bool showBorder { get { return cal1.showBorder; } set { cal1.showBorder = value; } }

        [Category("Nepali Calendar")]
        public WeekNameFormat weekNameFormat { get { return cal1.weekNameFormat; } set { cal1.weekNameFormat = value; } }
        #endregion

        #region "this Properties"


        private Color ForeColor_;
        [Category ("Nepali Calendar")]
        public Color calForeColor
        {
            get { return ForeColor_; }
            set
            {
                ForeColor_ = value;
                ForeColor = value;
            }
        }


        #endregion
        #endregion


        public short month{get;set;}
        public short year { get; set; }
        /// <summary>
        /// Takes English Year and month to load the calendar.
        /// </summary>
        /// <param name="Englisyear"></param>
        /// <param name="Englishmonth"></param>
        /// <param name="day"></param>
        public void loadcalendar(short vyear, short vmonth,bool english)
        {
            if (english)
            {
                DateTime dt = new DateTime(vyear, vmonth, 1);
                NepaliDate nd = new NepaliDate(dt);
                loadcalendar((short)nd.Year, (short)nd.Month);
            }
            else
            {
                loadcalendar(vyear , vmonth);
            }
        }
        /// <summary>
        /// Takes nepali Year and Month
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public void loadcalendar(short year_, short month_)
        {
            if (year_ <= Bsoft.Date.BsoftDateConverter.Min_Nep_year)
            {
                year_ = Bsoft.Date.BsoftDateConverter.Min_Nep_year;
            }
            if (year_ == Bsoft.Date.BsoftDateConverter.Min_Nep_year)
            {
                if (month_ < Bsoft.Date.BsoftDateConverter.Min_Nep_month)
                {
                    month_ = Bsoft.Date.BsoftDateConverter.Min_Nep_month;
                }
            }
            if (year_ > Bsoft.Date.BsoftDateConverter.Max_Nep_year)
            {
                year_ = Bsoft.Date.BsoftDateConverter.Max_Nep_year;
            }
            // lblDate.Text = year.ToString() + "/" + month.ToString();

            string ndm = "";
            string ndy = "";
            ndy= generalNepaliFunctions.getUnicodeNepali(year_.ToString()) + " ";
            ndm = generalNepaliFunctions.getFullMonthName(month_, generalNepaliFunctions.NeplaiMonthFormat.Nepali);

            lblNepMonth .Text = ndm;
            lblNepYear .Text = ndy;
            NepaliDate dt = new NepaliDate(year_, month_, 1);
            NepaliDate dt2 = new NepaliDate(year_, month_, 28);
            lblEngMonth.Text = String.Format("{0:MMM}", dt.Englishdate) + "/" + String.Format("{0:MMM}", dt2.Englishdate);
            lblEngYear.Text  =  dt.Englishdate.Year.ToString("0000");
            //lblEngDate .Text =
            //  EngDate .PrintString = 
            year = year_; month = month_;
            cal1.loadcalendar(year_, month_);
        }
        private void cal1_Load(object sender, EventArgs e)
        {
            loadcalendar(year, month);
        }

        private void Left_MouseDown(object sender, MouseEventArgs e)
        {
            month -= 1;

            if (month == 0)
            {
                month = 12;
                year -= 1;
            }
     
          loadcalendar(year, month);
        }

        private void Right_MouseDown(object sender, MouseEventArgs e)
        {
            month += 1;
            if (month == 13)
            {
                month = 1;
                year += 1;
            }
       
            loadcalendar(year, month);
        }

   
       

        public delegate void DateEventHandler(object sender, DateEventArgs e);
        public event DateEventHandler Alarms;

        private void cal1_Alarm_1(object sender, DateEventArgs e)
        {
            if (Alarms != null)
            {
                //Invokes the delegates.
                Alarms(this, e);
            }
        }

        private void lblNepDate_MouseDown(object sender, MouseEventArgs e)
        {
            //selectMonthYear smy = new selectMonthYear();
            //smy.Top = Cursor.Position.Y;
            //smy.Left = Cursor.Position.X;
            //smy.loadwhat = Loadwhat.Year;
            //smy.ShowDialog();
        }


        private void showchoose(bool english,bool monthfirst)
        {
            frmSimpleMySelect c = new frmSimpleMySelect(year, month, english, monthfirst);
            c.Size = this.Size;
            c.Location = this.PointToScreen(new Point(0, 0));
            c.calForeColor = calForeColor;
            if (c.ShowDialog(this) == DialogResult.OK)
                loadcalendar((short)c.year, (short)c.month,english );
        }
        private void lblNepYear_Click(object sender, EventArgs e)
        {
            showchoose(false , false );
        }

        private void lblNepMonth_Click(object sender, EventArgs e)
        {
            showchoose(false, true );
        }

        private void lblEngMonth_Click(object sender, EventArgs e)
        {
            showchoose(true , true );
        }

        private void lblEngYear_Click(object sender, EventArgs e)
        {
            showchoose(true , false);
        }

        private void lblToday_MouseDown(object sender, MouseEventArgs e)
        {
            loadcalendar((short )NepaliDate .Today .Year ,(short ) NepaliDate .Today .Month );
        }

   

    }
}
