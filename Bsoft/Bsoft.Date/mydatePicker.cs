using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Date
{
    public partial class mydatePicker : UserControl
    {
        #region "For movability"
        public mydatePicker()
        {
            //to initialize the variables
            BackColor = Color.White;
             
            InitializeComponent();
            mxtDate.HideSelection = true;
            mxtDate.Enabled = chk.Checked;
            btnDown.Enabled = chk.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmCalendar c = new frmCalendar(mxtDate .Text ,Format  );
            c.topmargin = Height - 2;
            c.Location = this.PointToScreen(new Point(0, Height));
            if (c.ShowDialog() == DialogResult.OK)
            {
                mxtDate.changenow = true;
                mxtDate.Text = c.Nepalidate.ToString(Format);
            }
        }

        private void datePicker_Resize(object sender, EventArgs e)
        {
            Height = mxtDate.Height + 4;
            chk.Top = (Height - chk.Height) / 2;
            chk.Left = 2;
            mxtDate.Font = Font;
            mxtDate.Top = 1;
            if (chk.Visible)
            { mxtDate.Left = chk.Width; }
            else
            { mxtDate.Left = 0; }
            
            mxtDate.Width = Width - btnDown .Width -chk .Width;
            btnDown.Top = (Height - btnDown.Height) / 2;
            btnDown.Left = Width - btnDown .Width ;
        }
        [Category("Nepali Calendar")]
        public bool showCheckBox
        {
            get { return chk.Visible; }
            set { chk.Visible = value; }
        }
        [Category("Nepali Calendar")]
        public bool Checked
        {
            get { return chk.Checked; }
            set { chk.Checked = value; }
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            mxtDate.Enabled = chk.Checked;
            btnDown.Enabled = chk.Checked;
         
        }

        private void chk_VisibleChanged(object sender, EventArgs e)
        {
            if (!chk.Visible)
            {
                chk.Checked = true;
            }

            if (chk.Visible)
            { mxtDate.Left = chk.Width; }
            else
            { mxtDate.Left = 0; }
        }
        #endregion

        #region "For Calculation"
       
        //int yearindex = 0;
        //int monthindex = 0;
        //int dayindex = 0;
        [Category("Nepali Calendar")]
        public string Format
        {
            get { return mxtDate .Format ; }
            set
            {
                mxtDate.Format = value;
            }
        }

 
        
        public Bsoft.Date.NepaliDate gValue()
        {
           
                return new Bsoft .Date .NepaliDate ( mxtDate .Text ,Format ,false );
           
        }
        public void sValue(NepaliDate value)
        {
            
                try
                {
                    if (value != null)
                    {
                         
                        mxtDate.Text = value.ToString(Format);
                        mxtDate.Refresh();
                    }
                }
                catch { }
            
        }
        [Category("Nepali Calendar")]
        public override string Text
        {
            get
            {
                return mxtDate.Text;
            }
            set
            {
                mxtDate.Text = value;
            }
        }
       
      

        #endregion

        #region "For cursor"


     
       
        //private void IncreamentValue(bool increase)
        //{
        //    int Cursorlocation = mxtDate.SelectionStart;
        //    int inc = -1;
        //    if (increase)
        //        inc = 1;
        //    int newValue;
        //    switch (CurrentPosition)
        //    {
        //        case CursorPosition.Year:
        //            newValue = Year + inc;
        //            if (newValue <= Bsoft.Date.BsoftDateConverter.Min_Nep_year)
        //            {
        //                mxtDate.SelectedText = Bsoft.Date.BsoftDateConverter.Min_Nep_year.ToString();
        //                return;
        //            }
        //            if (newValue >= Bsoft.Date.BsoftDateConverter.Max_Nep_year)
        //            {
        //                mxtDate.SelectedText = Bsoft.Date.BsoftDateConverter.Max_Nep_year.ToString();
        //                return;
        //            }
        //            Year = newValue;
        //            break;
        //        case CursorPosition.Month:
        //            newValue = Month + inc;
        //            newValue = newValue > 0 ? newValue : 12;
        //            newValue = newValue > 12 ? 1 : newValue;
        //            Month = newValue;
        //            break;
        //        case CursorPosition.Day:
        //            newValue = Day + inc;
        //            newValue = newValue > 0 ? newValue : Bsoft.Date.BsoftDateConverter.daysInNepaliMonth(Convert.ToInt16(Year), Convert.ToInt16(Month));
        //            newValue = newValue > Bsoft.Date.BsoftDateConverter.daysInNepaliMonth(Convert.ToInt16(Year), Convert.ToInt16(Month)) ? 1 : newValue;
        //            Day = newValue;
        //            break;
        //    }
        //    mxtDate.SelectionStart = Cursorlocation;

        //}

     

       
 

 

        //private void mxtDate_Validating(object sender, CancelEventArgs e)
        //{
        //    if (Bsoft.Date.BsoftDateConverter.isValidDate(mxtDate.Text, Format, true ))
        //    {
        //        Value = new Bsoft.Date.NepaliDate(mxtDate.Text, Format, true);
        //    //    e.Cancel = false;
        //    }
        //    else
        //    {
        //      //  e.Cancel = true;
        //    }

        //}

        //private void mxtDate_Validated(object sender, EventArgs e)
        //{
        //    if (Bsoft.Date.BsoftDateConverter.isValidDate(mxtDate.Text, Format, false))
        //    {
        //        mxtDate.Text = Bsoft.Date.NepaliDate.Today.ToString(Format);
        //    }

        //}


        private void mxtDate_Enter(object sender, EventArgs e)
        {
            //mxtDate.HideSelection = false;
            //BorderStyle = BorderStyle.Fixed3D;
           // mxtDate.BorderStyle = BorderStyle.FixedSingle;
            BackColor = Color.Transparent ;
        }

        private void mxtDate_Leave(object sender, EventArgs e)
        {
            //mxtDate.HideSelection = true ;
            //BorderStyle = BorderStyle.FixedSingle;
          //  mxtDate.BorderStyle = BorderStyle.None ;
            BackColor = Color.White ;
        }
        #endregion

        private void mxtDate_Validating(object sender, CancelEventArgs e)
        {

        }

        

       
      

    }

}
