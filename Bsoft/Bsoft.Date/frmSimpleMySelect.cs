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
    public partial class frmSimpleMySelect : Form
    {
        #region "Constructor"

        public frmSimpleMySelect()
        {
            InitializeComponent();
        }
        public frmSimpleMySelect(int syear, int smonth, bool senglish, bool monthfirst)
        {
            InitializeComponent();
            loadFormat();
            English = senglish;

            DateTime dt =new  Bsoft.Date.NepaliDate(syear, smonth, 1).Englishdate ;
            if (English)
            {
                syear = dt.Year ;
               smonth = dt.Month;
               smonth +=9;
               if (smonth > 12)
                   smonth -= 12;
            
            }

            if (monthfirst)
            {
                year = syear;
                month = smonth;
                isYear = false;
            }
            else
            {
                isYear = true;
                month = smonth;
                year = syear;
            }


        }
        #endregion
        #region "Variables"
        private bool isYear = true;
        Button[] LableAtoms = new Button[12];
        private bool English_;

        public bool English
        {
            get
            {
                return English_;
            }
            set
            {
                English_ = value;
                if (English_)
                {
                    lblMonth.Text = "Month";
                    lblYear.Text = "Year";
                    numYear.Maximum = Bsoft.Date.BsoftDateConverter.Max_Eng_year;
                    numYear.Minimum = Bsoft.Date.BsoftDateConverter.Min_Eng_year;

                }
                else
                {

                    lblMonth.Text = "महिना";
                    lblYear.Text = "वर्ष";
                    numYear.Maximum = Bsoft.Date.BsoftDateConverter.Max_Nep_year;
                    numYear.Minimum = Bsoft.Date.BsoftDateConverter.Min_Nep_year;
                }

            }
        }
        private int _year;
        public int year
        {
            get
            {
                return Convert.ToInt16(numYear.Value);
            }
            set
            {

                if (numYear.Minimum <= value & numYear.Maximum >= value)
                {
                    numYear.Value = value;
                    _year = value;
                }
            }
        }

        public int month
        {
            get
            {
                return Convert.ToInt16(numMonth.Value);
            }
            set
            {
                numMonth.Value = value;
            }
        }
        #endregion
        #region "functions"

        private void loadMonths()
        {
            string[] months = new string[12];
            if (English)
            {
                //months[0] = "Apr/May";
                //months[1] = "May/Jun";
                //months[2] = "Jun/Jul";
                //months[3] = "Jul/Aug";
                //months[4] = "Aug/Sep";
                //months[5] = "Sep/Oct";
                //months[6] = "Oct/Nov";
                //months[7] = "Nov/Dec";
                //months[8] = "Dec/Jan";
                //months[9] = "Jan/Feb";
                //months[10] = "Feb/Mar";
                //months[11] = "Mar/Apr";
                months[0] = "Apr";
                months[1] = "May";
                months[2] = "June";
                months[3] = "July";
                months[4] = "Aug";
                months[5] = "Sep";
                months[6] = "Oct";
                months[7] = "Nov";
                months[8] = "Dec";
                months[9] = "Jan";
                months[10] = "Feb";
                months[11] = "Mar";
            }
            else
            {
                for (int i = 1; i <= 12; i++)
                {
                    months[i - 1] = generalNepaliFunctions.getFullMonthName(i, generalNepaliFunctions.NeplaiMonthFormat.Nepali);
                }
            }
            isYear = false;
            loadLables(months);

        }

        private void loadYears(int topleft)
        {
            isYear = true;
            string[] years = new string[12];
            for (int i = 1; i <= 12; i++)
            {
                if (English)
                { years[i - 1] = (topleft + i - 1).ToString(); }
                else
                {
                    years[i - 1] = generalNepaliFunctions.getUnicodeNepali((topleft + i - 1).ToString());
                }
                LableAtoms[i-1].BackColor = Color.Transparent;
            }
            loadLables(years);
            LableAtoms[0].BackColor = Color.SkyBlue;//Always the selected year is topleft one
        }


        private void loadFormat()
        {
            tableLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 12; i++)
            {
                LableAtoms[i] = new Button();
                LableAtoms[i].Text = "-";
                LableAtoms[i].Show();
                LableAtoms[i].Visible = true;
                LableAtoms[i].Dock = DockStyle.Fill;
                LableAtoms[i].Parent = tableLayoutPanel1;
                LableAtoms[i].AutoSize = true;
                LableAtoms[i].FlatStyle = FlatStyle.Flat;
                LableAtoms[i].BackColor = Color.Transparent;
                LableAtoms[i].AutoEllipsis = true;
                LableAtoms[i].FlatAppearance.MouseOverBackColor = Color.LemonChiffon;
                LableAtoms[i].FlatAppearance.MouseDownBackColor = Color.LightBlue;
                LableAtoms[i].TextAlign = ContentAlignment.MiddleCenter;

                LableAtoms[i].MouseClick += atomMouse_Click;
            }
        }
        private void loadLables(string[] values)
        {
           
            if (values.Length <= 12)
                for (int i = 1; i <= values.Length; i++)
                {   
                    LableAtoms[i - 1].BackColor = Color.Transparent; 
                    LableAtoms[i - 1].Text = values[i - 1];
                    LableAtoms[i - 1].Tag = i;
                    LableAtoms[i - 1].Visible = true;
                    if (isYear)
                    {
                        
                        if (i + _year - 1 < numYear.Minimum | numYear.Maximum < i + _year - 1)
                        { LableAtoms[i - 1].Visible = false; }
                    }
                    else
                    {
                        if (i == month)
                        { LableAtoms[i - 1].BackColor = Color.SkyBlue; }
                    
                    }
                }

            if (isYear)
            {
                LableAtoms[0].BackColor = Color.SkyBlue;
            }
        }
        #endregion
        #region "Events"
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void atomMouse_Click(object sender, EventArgs e)
        {
            if (isYear)
            {
                try
                {
                    Button nl = new Button();
                    nl = (Button)sender;
                    year = Convert.ToInt16(nl.Tag) + _year - 1;
                }
                catch { }
                loadMonths();
                isYear = false;
            }
            else
            {
                Button nl = new Button();
                nl = (Button)sender;
                int mont_ = 0;
                mont_ = Convert.ToInt16(nl.Tag);
                if (English)
                {
                    mont_ = mont_ + 3;
                    if (mont_ > 12)
                        mont_ -= 12;

                }
                month = mont_;
                DialogResult = DialogResult.OK;
            }



        }




        private void numYear_ValueChanged(object sender, EventArgs e)
        {
            _year = Convert.ToInt16(numYear.Value);
            loadYears(_year);
        }

        private void numMonth_ValueChanged(object sender, EventArgs e)
        {
            loadMonths();
        }

        private void lalyears_Click(object sender, EventArgs e)
        {
            loadYears(_year);
        }

        private void lblMonth_Click(object sender, EventArgs e)
        {
            loadMonths();
        }

        #endregion
        #region " visibility"

        public int topmargin = 30;
        private bool isinside(Point pt)
        {

            if (pt.X > Left & pt.X < Right)
            {
                if (pt.Y > Top - topmargin & pt.Y < Bottom)
                {
                    return true;
                }
            }
            return false;
        }

        public bool fromCommand;

        public string file;
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern short GetAsyncKeyState(int vkey);

        private const int MC_LBUTTON = 0x1;
        private const int MC_RBUTTON = 0x2;
        private void TimerVisibility_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(MC_LBUTTON) != 0 | GetAsyncKeyState(MC_RBUTTON) != 0)
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

        private void frmMYSelection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        #endregion


        private Color ForeColor_;
        [Category("Nepali Calendar")]
        public Color calForeColor
        {
            get { return ForeColor_; }
            set
            {
                ForeColor_ = value;
                ForeColor = value;
                numMonth.ForeColor = value;
                numYear.ForeColor = value;
            }
        }
        private void lblRight_MouseDown(object sender, MouseEventArgs e)
        {
            if (_year + 12 <= numYear .Maximum )
            {
                _year += 12;
                numYear.Value = _year;
            }
            else
            {
                _year = (int)numYear .Maximum ;
                numYear.Value = _year;
            }
        }

        private void lblLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (_year - 12 >= numYear .Minimum )
            {
                _year -= 12;
                numYear.Value = _year;
            }
            else
            {
                _year = (int)numYear .Minimum ;
                numYear.Value = _year;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }



    }
}
