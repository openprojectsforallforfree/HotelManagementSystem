using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Bsoft.Common;
namespace Bsoft.Controls
{
    public partial class VtextBox : TextBox
    {
        // string _value=" ";
        private decimal _minValue = 0;
        private decimal _maxValue = 0;
        public decimal MinValue
        {
            get
            {
                return _minValue;
            }
            set
            {
                if (value > _maxValue)
                {
                    _minValue = _maxValue;
                }
                else
                {
                    _minValue = value;
                }
            }
        }
        public decimal MaxValue
        {
            get
            {
                return _maxValue;
            }
            set
            {
                if (value < _minValue)
                {
                    _maxValue = _minValue;
                }
                else
                {
                    _maxValue = value;
                }
            }
        }
        public enum NumEditType
        {
            Currency = 0,
            Decimal = 1,
            Single = 2,
            Double = 3,
            SmallInteger = 4,
            Integer = 5,
            LargeInteger = 6,
        }

        public enum ThousandSeparaterTypes
        {
            NONE = 0,
            English = 1,
            Nepali = 2,
        }
        public VtextBox()
        {
            InitializeComponent();
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            this.ResumeLayout(false);
        }

        protected override void OnLeave(EventArgs e)
        {
            switch (ValidationType)
            {
                case ValidationTypeEnum.MoneyNepali:
                    Value = Text;
                    break;
                case ValidationTypeEnum.MoneyEnglish:
                    Value = Text;
                    break;
            }
            base.OnLeave(e);
        }

        public string Value
        {
            get
            {
                string val = Text.Replace(",", "");
                return val;
            }

            set
            {

                System.Globalization.CultureInfo ci;
                decimal dd = 0;
                try
                { dd = Convert.ToDecimal(value); }
                catch { }

                string tempText = "";

                switch (ValidationType)
                {
                    case ValidationTypeEnum.MoneyNepali:
                        ci = System.Globalization.CultureInfo.CreateSpecificCulture("hi-IN");
                        tempText = dd.ToString("N", ci);

                        break;
                    case ValidationTypeEnum.MoneyEnglish:
                        ci = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                        tempText = dd.ToString("N", ci);
                        break;
                    default:
                        tempText = value;
                        break;
                }

                Text = tempText;

            }
        }
        // public ValidationTypeEnum _ValidationType;


        public enum ValidationTypeEnum
        {
            No_Validation = 0,
            Integer = 1,
            Alphabets = 2,
            Decimal = 3,
            AlphaNumeric = 4,
            MoneyNepali = 5,
            MoneyEnglish = 6,
            Email = 7,
            WebSite = 8,
            PhoneFax = 9,
            SignedDecimal = 10
        }


        ValidationTypeEnum _ValidationType;
        // If type is Enum Puts Combo Box in the property window
        [Category("User")]
        [Description("The Validation Type")]
        public virtual ValidationTypeEnum ValidationType
        {
            get
            {
                return _ValidationType;

            }

            set
            {

                _ValidationType = value;
                switch (_ValidationType)
                {
                    case ValidationTypeEnum.MoneyEnglish:
                    case ValidationTypeEnum.Integer:
                    case ValidationTypeEnum.Decimal:
                    case ValidationTypeEnum.MoneyNepali:
                        TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

                        break;
                }
            }
        }

        private bool ValidateInput(char keyC)
        {
            //Function to validate the input character entered by the user depending upon the validation type selected.

            //Following line Accepts the Keys like Backspace, else wont accept
            if (char.IsControl(keyC)) return true;


            switch (ValidationType)
            {
                case ValidationTypeEnum.PhoneFax:
                    if (char.IsNumber(keyC) == true)
                    {
                        return true;
                    }
                    if (keyC == ',' || keyC == '-')
                    {
                        return true;
                    }
                    break;
                case ValidationTypeEnum.Integer:
                    //Validating for Integers
                    if (char.IsNumber(keyC) == true)
                    {
                        return true;
                    }

                    break;
                case ValidationTypeEnum.SignedDecimal:
                    if (char.IsNumber(keyC) == true)
                    {
                        return true;
                    }
                    if (Text != null)
                    {
                        if (keyC.ToString() == "." & Text.IndexOf(".") <= 1)
                        {
                            return true;
                        }
                        if (keyC.ToString() == "-" & Text.IndexOf("-") <= 1)
                        {
                            return true;
                        }
                    }
                    break;
                case ValidationTypeEnum.Decimal:
                case ValidationTypeEnum.MoneyEnglish:
                case ValidationTypeEnum.MoneyNepali:
                    //Validates for Number & accepts the Decimal Key as well. Split function will check for if Decimal is entered only once.
                    if (char.IsNumber(keyC) == true)
                    {
                        return true;
                    }
                    if (Text != null)
                    {

                        if (keyC.ToString() == "." & Text.IndexOf(".") <= 1)
                        {
                            return true;
                        }
                    }
                    break;

                case ValidationTypeEnum.Alphabets:
                    //Validating to accept only alphabets & space
                    if (char.IsLetter(keyC) == true | char.IsWhiteSpace(keyC))
                    {
                        return true;
                    }

                    break;

                case ValidationTypeEnum.AlphaNumeric:
                    //Validating to accept only Alphabets & Numbers
                    if (char.IsLetterOrDigit(keyC) == true | char.IsWhiteSpace(keyC))
                    {
                        return true;
                    }

                    break;
                case ValidationTypeEnum.WebSite:
                case ValidationTypeEnum.Email:
                case ValidationTypeEnum.No_Validation:
                    //No Validations, which is also a Default
                    return true;
            }

            return false;
        }



        private bool showError()
        {
            switch (ValidationType)
            {
                case ValidationTypeEnum.Integer:
                    toolErrorMessage.Show("Only Integer Numbers", this, 0, 0, 500);
                    break;

                case ValidationTypeEnum.Decimal:
                    toolErrorMessage.Show("Only Positive Numbers", this, 0, 0, 500);
                    break;
                case ValidationTypeEnum.SignedDecimal:
                    toolErrorMessage.Show("Only Positive and Negative Numbers", this, 0, 0, 500);
                    break;
                case ValidationTypeEnum.Alphabets:
                    toolErrorMessage.Show("Only Alphabets", this, 0, 0, 500);
                    break;

                case ValidationTypeEnum.AlphaNumeric:
                    toolErrorMessage.Show("Only Alpha-numeric", this, 0, 0, 500);
                    break;
                case ValidationTypeEnum.MoneyNepali:
                    toolErrorMessage.Show("Only Numbers", this, 0, 0, 500);
                    break;
                case ValidationTypeEnum.MoneyEnglish:
                    toolErrorMessage.Show("Only Numbers", this, 0, 0, 500);
                    break;
                case ValidationTypeEnum.Email:
                    toolErrorMessage.Show("Email only", this, 0, 0, 500);
                    break;
                case ValidationTypeEnum.WebSite:
                    toolErrorMessage.Show("Web Site only", this, 0, 0, 500);
                    break;
                case ValidationTypeEnum.PhoneFax:
                    toolErrorMessage.Show("Invalid Entry", this, 0, 0, 500);
                    break;
                case ValidationTypeEnum.No_Validation:
                    //No Validations, which is also a Default
                    break;
            }

            switch (ValidationType)
            {
                case ValidationTypeEnum.Integer:
                case ValidationTypeEnum.Decimal:
                case ValidationTypeEnum.SignedDecimal:
                case ValidationTypeEnum.MoneyNepali:
                case ValidationTypeEnum.MoneyEnglish:
                    if (MinValue != 0 || MaxValue != 0)
                    {
                        if (!Text.IsInRange(MinValue, MaxValue))
                        {
                            toolErrorMessage.Show("Invalid Entry: Range from {0} to {1} only.".With(MinValue, MaxValue), this, 0, 0, 500);
                        }
                    }
                    break;
            }


            return false;
        }
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidateInput(e.KeyChar) == false)
            {
                showError();

                e.Handled = true;
            }
            //_value = Text;
        }


        private static bool isEmail(string inputEmail)
        {
            if (inputEmail == null)
            {
                return false;
            }
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public static bool isURL(string url)
        {
            string pattern = @"[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?";
            Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return reg.IsMatch(url);
        }


        private static bool sisURL(string inputURL)
        {
            Regex RgxUrl = new Regex(@"([\d\w-.]+?\.(a[cdefgilmnoqrstuwz]|b[abdefghijmnorstvwyz]|c[acdfghiklmnoruvxyz]|d[ejkmnoz]|e[ceghrst]|f[ijkmnor]|g[abdefghilmnpqrstuwy]|h[kmnrtu]|i[delmnoqrst]|j[emop]|k[eghimnprwyz]|l[abcikrstuvy]|m[acdghklmnopqrstuvwxyz]|n[acefgilopruz]|om|p[aefghklmnrstwy]|qa|r[eouw]|s[abcdeghijklmnortuvyz]|t[cdfghjkmnoprtvwz]|u[augkmsyz]|v[aceginu]|w[fs]|y[etu]|z[amw]|aero|arpa|biz|com|coop|edu|info|int|gov|mil|museum|name|net|org|pro)(\b|\W(?<!&|=)(?!\.\s|\.{3}).*?))(\s|$)");
            if (RgxUrl.IsMatch(inputURL))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void VtextBox_Leave(object sender, EventArgs e)
        {
            switch (ValidationType)
            {
                case ValidationTypeEnum.SignedDecimal:
                    if (Text.Trim() != "")
                    {
                        if (!Text.IsNumericSigned())
                        {
                            showError();
                            this.Focus();
                        }
                    }
                    break;
                case ValidationTypeEnum.Email:
                    if (Text.Trim() != "")
                    {
                        if (!isEmail(Text))
                        {
                            showError();
                            this.Focus();
                        }
                    }
                    break;
                case ValidationTypeEnum.WebSite:
                    if (Text.Trim() != "")
                    {
                        if (!isURL(Text))
                        {
                            showError();
                            this.Focus();
                        }
                    }
                    break;
                case ValidationTypeEnum.PhoneFax:
                    break;
                default:
                    break;
            }

            switch (ValidationType)
            {
                case ValidationTypeEnum.Integer:
                case ValidationTypeEnum.Decimal:
                case ValidationTypeEnum.SignedDecimal:
                case ValidationTypeEnum.MoneyNepali:
                case ValidationTypeEnum.MoneyEnglish:
                    if (MinValue != 0 || MaxValue != 0)
                    {
                        if (!Text.IsInRange(MinValue, MaxValue))
                        {
                            showError();
                            this.Focus();
                        }
                    }
                    break;
            }
        }
    }
}
