using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Date
{
    public partial class CAL : UserControl
    {
        public CAL()
        {
            InitializeComponent();
            calBackColor = Color.Transparent;
            showBorder = true;

            //SelectedColor = Color.Teal;
            //ShadowBackColor = Color.Transparent ;
            //NormalBackColor = Color.Transparent ;
            //weekNameFormat = WeekNameFormat.Short ;
        }



        #region "Properties"
        public Color ShadowBackColor { get; set; }
        public Color NormalBackColor { get; set; }
        public Color SelectedColor { get; set; }


        private Color BackColor_;
        private bool showBorder_;
        public Color calBackColor
        {
            get
            {
                return BackColor_;
            }
            set
            {
                BackColor = value;
                BackColor_ = value;
            }
        }
        public bool showBorder
        {
            get
            {
                return showBorder_;
            }
            set
            {
                showBorder_ = value;
                if (showBorder_)
                {
                   tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                    BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                    BorderStyle = BorderStyle.None;
                }

            }
        }

        public WeekNameFormat weekNameFormat
        {
            get { return weekNameFormat_; }
            set
            {
                weekNameFormat_ = value;
            }
        }

        #endregion

        short month_;
        short year_;
        Bsoft.Date.NepaliDate Ndate = new Bsoft.Date.NepaliDate();
      public   Bsoft.Date.NepaliDate SelectedNepaliDate = new Bsoft.Date.NepaliDate();
        public void loadcalendar(short year, short month)
        {
            //if (year > 2099 & year < 2001)
            //{
            //    MessageBox.Show("Sorry the Year Range is 2001 to 2099 Only");
            //}
            //returns weeknumber sunday is 1
            month_ = month;
            year_ = year;

            Bsoft.Date.NepaliDate ndt = new NepaliDate(year, month, 1);
            System.DateTime firtdayofmonthEng = Bsoft.Date.BsoftDateConverter.EnglishDate(ndt);
            DayOfWeek d = firtdayofmonthEng.DayOfWeek;
            int dow = 0;
            switch (d)
            {
                case DayOfWeek.Sunday:
                    dow = 1;
                    break;
                case DayOfWeek.Monday:
                    dow = 2;
                    break;
                case DayOfWeek.Tuesday:
                    dow = 3;
                    break;
                case DayOfWeek.Wednesday:
                    dow = 4;
                    break;
                case DayOfWeek.Thursday:
                    dow = 5;
                    break;
                case DayOfWeek.Friday:
                    dow = 6;
                    break;
                case DayOfWeek.Saturday:
                    dow = 7;
                    break;
            }
            System.DateTime topleft = firtdayofmonthEng.AddDays(-1 * dow + 1);
            loadcalendar(topleft);
            Refresh();
        }

        public delegate void DateEventHandler(object sender, DateEventArgs e);
        public event DateEventHandler Alarm;
        private void Atom_MouseClick(object sender, MouseEventArgs e)
        {
            ATOM npdate = (ATOM)sender;
            if (npdate.isShadow & ATOM.showShadow)
                return;
            SelectedNepaliDate = npdate.Nepalidate;

            loadcalendarColor();
            npdate.isSelected = true;
            //for event
            if (Alarm != null)
            {
                DateEventArgs de = new DateEventArgs();
                de.year = SelectedNepaliDate.Year;
                de.month = SelectedNepaliDate.Month;
                de.day = SelectedNepaliDate.Day;
                //Invokes the delegates.
                Alarm(this, de);
            }
        }





        private void loadcalendarColor()
        {

            for (int i = 1; i <= 42; i++)
            {
                atoms[i].isSelected = false;

                if (atoms[i].npmonth != month_)
                {
                    atoms[i].isShadow = true;
                    atoms[i].BackColor = ShadowBackColor;
                }
                else
                {
                    atoms[i].isShadow = false;
                    atoms[i].BackColor = NormalBackColor;
                }
                if (SelectedNepaliDate.Equals(atoms[i].Nepalidate))
                {
                    atoms[i].BackColor = SelectedColor;
                    atoms[i].isSelected = true;
                }


            }
        }


        private void loadcalendar(System.DateTime topleft)
        {

            for (int i = 1; i <= 42; i++)
            {
                atoms[i].engdate = topleft;
                topleft = topleft.AddDays(1);
            }
            loadcalendarColor();
        }

        ATOM[] atoms = new ATOM[43];

        WeekAtom[] WeekAtoms = new WeekAtom[8];


        WeekNameFormat weekNameFormat_ = WeekNameFormat.Short;




        private void loadformat()
        {


            int i = 0;

            for (i = 1; i <= 7; i++)
            {
                WeekAtoms[i] = new WeekAtom();
                switch (weekNameFormat)
                {
                    case WeekNameFormat.Short:
                        WeekAtoms[i].PrintString = generalNepaliFunctions.getShortWeekName(i);
                        break;
                    case WeekNameFormat.Long:
                        WeekAtoms[i].PrintString = generalNepaliFunctions.getFullWeekName(i);
                        break;
                    case WeekNameFormat.Number:
                        WeekAtoms[i].PrintString = i.ToString("00");
                        break;
                }

                WeekAtoms[i].Show();
                WeekAtoms[i].Visible = true;
                WeekAtoms[i].Dock = DockStyle.Fill;
                WeekAtoms[i].Parent = tableLayoutPanel1;
            }
            for (i = 1; i <= 42; i++)
            {
                atoms[i] = new ATOM();
                atoms[i].MouseClick += Atom_MouseClick;
                //atoms[i].MouseEnter += Atom_MouseEnter;
                //atoms[i].MouseEnter += Atom_MouseLeave;
                atoms[i].Show();
                atoms[i].Visible = true;
                atoms[i].Dock = DockStyle.Fill;
                atoms[i].Cursor  = Cursors .Hand ;
                atoms[i].Parent = tableLayoutPanel1;



            }
        }

        private void CAL_Load(object sender, EventArgs e)
        {

            loadformat();
            loadcalendar(2066, 2);
        }

        private void CAL_Leave(object sender, EventArgs e)
        {
            loadcalendarColor();
        }

        private void CAL_MouseLeave(object sender, EventArgs e)
        {
            loadcalendarColor();
        }

 











    }

    public class DateEventArgs : EventArgs
    {

        // Properties.
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }


    }
}
