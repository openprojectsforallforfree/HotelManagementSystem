using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Controls
{
    public partial class MyMask : System.Windows.Forms.TextBox
    {
        public MyMask()
        {
            calculateddmmyyyy(Text);


            Text = getformatedText();
            InitializeComponent();
            HideSelection = false;
            //Format = "dd/mm/+yyyy BS";

            SelectionStart = MinCursorLoc;
            SelectionLength = 1;
        }

        int _dd, _mm, _yyyy;
        int Min_dd = 01, Min_mm = 01, Min_yyyy = Bsoft.Date.BsoftDateConverter.Min_Nep_year;
        int Max_dd = 32, Max_mm = 12, Max_yyyy = Bsoft.Date.BsoftDateConverter.Max_Nep_year;
        private int dd
        {
            get { return _dd; }
            set
            {

                _dd = value;



            }
        }
        private int mm
        {
            get { return _mm; }
            set
            {
                _mm = value;

            }
        }
        private int yyyy
        {
            get { return _yyyy; }
            set
            {
                _yyyy = value;

            }
        }

        private void MyMask_KeyPress(object sender, KeyPressEventArgs e)
        {
            changenow = true;
            if (isKeyDown)
            {
                e.Handled = true;
                return;
            }
            isKeyDown = true;
            if (ValidateInput(e.KeyChar) == false)
            {
                e.Handled = true;
            }
            //if (isBeyondMinMax(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private bool ValidateInput(char keyC)
        {
            //Function to validate the input character entered by the user depending upon the validation type selected.
            //Following line Accepts the Keys like Backspace, else wont accept
            //if (char.IsControl(keyC)) return true;
            if (char.IsNumber(keyC) == true)
            {
                return true;
            }
            return false;
        }
        bool isKeyDown = false;

        private bool isFormat()
        {



            if (SelectionStart >= ddIndex & SelectionStart <= ddIndex + 1)
            { return false; }
            else if (SelectionStart >= mmIndex & SelectionStart <= mmIndex + lengthofMonthString())
            { return false; }
            else if (SelectionStart >= yyyyIndex & SelectionStart <= yyyyIndex + 3)
            { return false; }
            else
            {
                return true;
            }
        }
        int MinCursorLoc = 0;
        int MaxCursorLoc = 0;
        private void increaseSelection(bool left)
        {
            if (!left)
            {
                if (SelectionStart == Text.Length - 1)
                {
                    // SelectionStart = MinCursorLoc;
                    //SelectionStart = Text.Length - 1;
                    SelectionStart = MaxCursorLoc;
                }
                else
                {
                    SelectionStart += 1;
                }
            }
            else
            {
                if (SelectionStart == 0)
                {
                    // SelectionStart = Text.Length - 1;
                    SelectionStart = MinCursorLoc;
                }
                else
                {
                    SelectionStart -= 1;
                }
            }
        }
        private void getNextPosition(bool left)
        {

            if (isFormat())
            {
                if (left)
                {
                    increaseSelection(true);
                }
                else
                {
                    increaseSelection(false);
                }
                getNextPosition(left);
            }
            else
            {
                return;
            }
        }
        private string getformatedText()
        {
            string temp = Format;
            try
            {
                temp = temp.Replace("dd", dd.ToString("00"));
                temp = temp.Replace("mm", mm.ToString("00"));
                temp = temp.Replace("month", Bsoft.Date.generalNepaliFunctions.getFullMonthName(mm));
                temp = temp.Replace("yyyy", yyyy.ToString("0000"));
                temp = Bsoft.Date.generalNepaliFunctions.getUnicodeNepali(temp);
            }
            catch { }

            return temp;

        }
        private void calculateddmmyyyy(string input)
        {

            input = Bsoft.Date.generalNepaliFunctions.getAsciiNepali(input);
            if (input.Trim() == "")
            {
                input = "00000000000000000000000000000";
            }
            string dds = input.Substring(ddIndex, 2);
            string mms = input.Substring(mmIndex, lengthofMonthString() + 1);
            string yyyys = input.Substring(yyyyIndex, 4);
            int temp_dd, temp_mm, temp_yyyy = 0;
            temp_dd = getInt(dds);
            if (Format.IndexOf("month") < 0)
            {
                temp_mm = getInt(mms);
            }
            else
            {
                temp_mm = Bsoft.Date.generalNepaliFunctions.getMonthNo(mms);
            }

            temp_yyyy = getInt(yyyys);

            if (temp_yyyy == 0)
            {
                temp_yyyy = Bsoft.Date.NepaliDate.Today.Year;
            }
            if (temp_mm == 0)
            {
                temp_mm = Bsoft.Date.NepaliDate.Today.Month;
            }
            if (temp_dd == 0)
            {
                temp_dd = Bsoft.Date.NepaliDate.Today.Day;
            }


            if (temp_yyyy < Min_yyyy)
            {
                //_yyyy = Min_yyyy;
            }
            else if (temp_yyyy > Max_yyyy)
            {
                //_yyyy = Max_yyyy;
            }
            else
            {
                _yyyy = temp_yyyy;
            }

            if (temp_mm < Min_mm)
            {
                // _mm = Min_mm;
            }

            else if (temp_mm > Max_mm)
            {
                // _mm = Max_mm;
            }
            else
            {
                _mm = temp_mm;
            }
            Max_dd = Bsoft.Date.BsoftDateConverter.daysInNepaliMonth(_yyyy, _mm);

            if (temp_dd < Min_dd)
            {
                // _dd = Min_dd;
            }
            else if (temp_dd > Max_dd)
            {
                //_dd = Max_dd;
            }
            else
            {
                _dd = temp_dd;
            }


        }

        private void MyMask_KeyDown(object sender, KeyEventArgs e)
        {
            changenow = true;
            if (e.Control & e.KeyCode == Keys.C)
            {
                Clipboard.SetText(Text);

            }
            if (e.Control & e.KeyCode == Keys.V)
            {
                Text = Clipboard.GetText();

            }
            // getformatedText();
            // Text = SelectionStart.ToString();
            if (e.KeyCode == Keys.Left)
            {
                if (SelectionStart == 0)
                {
                    //SelectionStart = Text.Length -1 ;
                    SelectionStart = MinCursorLoc;
                }
                else
                {
                    SelectionStart -= 1;
                }


                getNextPosition(true);

            }
            if (e.KeyCode == Keys.Right)
            {
                if (SelectionStart == Text.Length - 1)
                {
                    // SelectionStart = MinCursorLoc;
                    //SelectionStart = Text.Length - 1;
                    SelectionStart = MaxCursorLoc;
                }
                else
                {
                    SelectionStart += 1;
                }
                getNextPosition(false);

            }

            int selectstart = 0;
            selectstart = SelectionStart;
            if (e.KeyCode == Keys.Up)
            {
                increaseValue(true);
                SelectionStart = selectstart;

            }
            if (e.KeyCode == Keys.Down)
            {
                increaseValue(false);
                SelectionStart = selectstart;

            }

            //if (validateit(e.KeyValue    ))
            //{

            //}


            e.Handled = true;
        }

        private int getInt(string s)
        {
            try
            { return Convert.ToInt16(s); }
            catch { return 0; }


        }
        private bool validateit(int cKey)
        {

            if (cKey >= 96 & cKey <= 106)
            {
                cKey -= 96;
            }
            else if (cKey >= 47 & cKey <= 57)
            {
                cKey -= 47;
            }

            string sel = "";
            int selval = 0;
            string temp = "";
            string temps = "";
            string tempe = "";


            temp = Bsoft.Date.generalNepaliFunctions.getAsciiNepali(Text);
            temps = temp.Substring(0, SelectionStart);
            tempe = temp.Substring(SelectionStart + 1, temp.Length - SelectionStart - 1);
            temp = temps + cKey.ToString() + tempe;

            bool isvalid = false;
            switch (CurrentPosition())
            {
                case "y":
                    sel = temp.Substring(yyyyIndex, 4);
                    selval = getInt(sel);
                    isvalid = Bsoft.Date.BsoftDateConverter.isValidDate(selval, mm, dd);
                    break;
                case "m":
                    sel = temp.Substring(mmIndex, 2);
                    selval = getInt(sel);
                    isvalid = Bsoft.Date.BsoftDateConverter.isValidDate(yyyy, selval, dd);
                    break;
                case "d":
                    sel = temp.Substring(ddIndex, 2);
                    selval = getInt(sel);
                    isvalid = Bsoft.Date.BsoftDateConverter.isValidDate(yyyy, mm, selval);
                    break;
            }
            return isvalid;
        }

        private void validateit(int newValue, int a)
        {
            switch (CurrentPosition())
            {
                case "y":

                    if (newValue <= Bsoft.Date.BsoftDateConverter.Min_Nep_year)
                    {
                        yyyy = Bsoft.Date.BsoftDateConverter.Min_Nep_year;

                    }
                    if (newValue >= Bsoft.Date.BsoftDateConverter.Max_Nep_year)
                    {
                        yyyy = Bsoft.Date.BsoftDateConverter.Max_Nep_year;

                    }
                    yyyy = newValue;
                    break;
                case "m":

                    newValue = newValue > 0 ? newValue : 12;
                    newValue = newValue > 12 ? 1 : newValue;
                    mm = newValue;
                    break;
                case "d":

                    newValue = newValue > 0 ? newValue : Bsoft.Date.BsoftDateConverter.daysInNepaliMonth(yyyy, mm);
                    newValue = newValue > Bsoft.Date.BsoftDateConverter.daysInNepaliMonth(yyyy, mm) ? 1 : newValue;
                    dd = newValue;
                    break;
            }

        }
        private string CurrentPosition()
        {

            if (SelectionStart >= ddIndex & SelectionStart <= ddIndex + 1)
            { return "d"; }
            else if (SelectionStart >= mmIndex & SelectionStart <= mmIndex + 1)
            { return "m"; }
            else if (SelectionStart >= yyyyIndex & SelectionStart <= yyyyIndex + 3)
            { return "y"; }
            else
            {
                return "d";
            }
        }
        private void increaseValue(bool increase)
        {
            int inc = increase ? 1 : -1;
            int newValue = 0;
            switch (CurrentPosition())
            {
                case "y":
                    newValue = yyyy + inc;
                    if (newValue <= Bsoft.Date.BsoftDateConverter.Min_Nep_year)
                    {
                        yyyy = Bsoft.Date.BsoftDateConverter.Min_Nep_year;
                        return;
                    }
                    if (newValue >= Bsoft.Date.BsoftDateConverter.Max_Nep_year)
                    {
                        yyyy = Bsoft.Date.BsoftDateConverter.Max_Nep_year;
                        return;
                    }
                    yyyy = newValue;
                    break;
                case "m":
                    newValue = mm + inc;
                    newValue = newValue > 0 ? newValue : 12;
                    newValue = newValue > 12 ? 1 : newValue;
                    mm = newValue;
                    break;
                case "d":
                    newValue = dd + inc;
                    newValue = newValue > 0 ? newValue : Bsoft.Date.BsoftDateConverter.daysInNepaliMonth(yyyy, mm);
                    newValue = newValue > Bsoft.Date.BsoftDateConverter.daysInNepaliMonth(yyyy, mm) ? 1 : newValue;
                    dd = newValue;
                    break;
            }
            changenow = false;
            Text = getformatedText();
        }


        private void calculateMinMaxValues()
        {
            //min[0] = (Min_dd / 10) % 10;//d
            //min[1] = Min_dd % 10;//d
            //min[2] = (Min_mm / 10) % 10;//m
            //min[3] = Min_mm % 10;//m
            //min[4] = (Min_yyyy / 1000) % 10;
            //min[5] = (Min_yyyy / 100) % 10;
            //min[6] = (Min_yyyy / 10) % 10;
            //min[7] = Min_yyyy % 10;//y

            //max[0] = (Max_dd / 10) % 10;//d
            //max[1] = Max_dd % 10;//d
            //max[2] = (Max_mm / 10) % 10;//m
            //max[3] = Max_mm % 10;//m
            //max[4] = (Max_yyyy / 1000) % 10;
            //max[5] = (Max_yyyy / 100) % 10;
            //max[6] = (Max_yyyy / 10) % 10;
            //max[7] = Max_yyyy % 10;//y


            min[0] = 0;//d
            min[1] = 0;//d
            min[2] = 0;//m
            min[3] = 0;//m
            min[4] = 1;
            min[5] = 0;
            min[6] = 0;
            min[7] = 0;//y

            max[0] = 9;//d
            max[1] = 9;//d
            max[2] = 9;//m
            max[3] = 9;//m
            max[4] = 9;
            max[5] = 9;
            max[6] = 9;
            max[7] = 9;//y

            min[0] = 0; min[1] = 0;//d
            max[0] = 9; max[1] = 9;//d pos[3] = mmIndex + 1;

            min[2] = 0; min[3] = 0;//m
            max[2] = 9; max[3] = 9;//m

            min[4] = 1; min[5] = 0; min[6] = 0; min[7] = 0;//y
            max[4] = 9; max[5] = 9; max[6] = 9; max[7] = 9;//y

        }
        //private bool isBeyondMinMax(char ch)
        //{
        //    int val = 0;
        //    try
        //    {
        //        val = Convert.ToInt16(ch.ToString());
        //    }
        //    catch
        //    {
        //        return true;
        //    }
        //    calculateMinMaxValues();
        //    int positionvalue = 0;
        //    //int valueatpostion = 0;
        //    //try
        //    //{
        //    //    valueatpostion = Convert.ToInt16(Text.Substring(SelectionStart , 1));
        //    //}
        //    //catch
        //    //{ }

        //    for (int i = 0; i < 8; i++)
        //    {
        //        if (SelectionStart == pos[i])
        //        {
        //            positionvalue = i;
        //            break;
        //        }
        //    }
        //    //filtervalue = min[positionvalue] > valueatpostion ? min[positionvalue] : valueatpostion;
        //    //filtervalue = max[positionvalue] < valueatpostion ? max[positionvalue] : valueatpostion;

        //    if (min[positionvalue] <= val & val <= max[positionvalue])
        //    {
        //        return false;//ok 
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //    return false;

        //}



        string _Format = "dd/mm/yyyy";
        int ddIndex = 0;
        int mmIndex = 0;
        int yyyyIndex = 0;
        int[] min = new int[8];
        int[] max = new int[8];
        //int[] pos = new int[8];//ddmmyyyy


        private int lengthofMonthString()
        {
            int len = 0;
            if (Format.IndexOf("mm") >= 0)
            { len = 1; }
            else
            {
                len = Bsoft.Date.generalNepaliFunctions.getFullMonthName(Bsoft.Date.generalNepaliFunctions.getMonthNo(Text)).Length - 1;
                if (len < 1)
                    len = 1;
            }
            return len;
        }
        public string Format
        {
            get { return _Format; }
            set
            {
                string temp = _Format;
                if (value.IndexOf("dd") > -1 & value.IndexOf("yyyy") > -1 & (value.IndexOf("mm") > -1 | value.IndexOf("month") > -1))
                {
                    ddIndex = value.IndexOf("dd");

                    if (value.IndexOf("mm") >= 0)
                    { mmIndex = value.IndexOf("mm"); }
                    else
                    { mmIndex = value.IndexOf("month"); }


                    yyyyIndex = value.IndexOf("yyyy");

                    // pos[0] = ddIndex;
                    //pos[1] = ddIndex + 1;
                    //pos[2] = mmIndex;

                    //if (value.IndexOf("mm") >= 0)
                    //{ pos[3] = mmIndex + 1; }
                    //else
                    //{ pos[3] = mmIndex + 1; }


                    //pos[4] = yyyyIndex;
                    //pos[5] = yyyyIndex + 1;
                    //pos[6] = yyyyIndex + 2;
                    //pos[7] = yyyyIndex + 3;



                    MinCursorLoc = ddIndex < mmIndex ? ddIndex : mmIndex;
                    MinCursorLoc = MinCursorLoc < yyyyIndex ? MinCursorLoc : yyyyIndex;

                    MaxCursorLoc = ddIndex > mmIndex ? ddIndex : mmIndex;
                    MaxCursorLoc = MaxCursorLoc > yyyyIndex ? MaxCursorLoc : yyyyIndex;
                    if (MaxCursorLoc == yyyyIndex)
                    {
                        MaxCursorLoc += 3;
                    }
                    else if (MaxCursorLoc == ddIndex)
                    {
                        MaxCursorLoc += 1;
                    }
                    else
                    {
                        MaxCursorLoc += lengthofMonthString();
                    }
                    _Format = value;
                    Text = getformatedText();

                }
                else
                {
                    throw new Exception("should have dd , mm and yyyy ");
                }
            }
        }

        private void MyMask_KeyUp(object sender, KeyEventArgs e)
        {
            changenow = true;
            isKeyDown = false;
            //if (Text.Length > Format.Length)
            //{
            //    Text = Text.Substring(0, Format.Length);
            //}
            if (SelectionStart == Text.Length)
            {
                //SelectionStart = MinCursorLoc;
                //SelectionStart = Text.Length - 1;
                SelectionStart = MaxCursorLoc;
            }

            getNextPosition(false);
            SelectionLength = 1;
        }

        private void MyMask_MouseUp(object sender, MouseEventArgs e)
        {
            SelectionLength = 1;

        }
        public bool changenow = true;
        private void MyMask_TextChanged(object sender, EventArgs e)
        {
            if (changenow)
            {
                int selectstart = 0;
                selectstart = SelectionStart;
                calculateddmmyyyy(Text);

                changenow = false;
                Text = getformatedText();
                SelectionStart = selectstart;
            }
        }
    }
}
