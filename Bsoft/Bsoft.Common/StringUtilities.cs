using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Friuts;
using Bsoft.Data;

namespace Bsoft.Common
{
    public static class StringUtilities
    {
        public static String With(this string str, params object[] args)
        {
            return String.Format(str, args);
        }
        
        public static bool isInt(this string Value)
        {
            try
            { int a = int.Parse(Value); }
            catch { return false; }
            return true;
        }
        /// <summary>
        /// -ve number retruns false
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static bool isIntAbs(this string Value)
        {
            try
            {
                int a = int.Parse(Value);
                if (a < 0)
                {
                    return false;
                }
            }
            catch { return false; }
            return true;
        }
        /// <summary>
        /// Eg A1=>A2,Abc1=>Abc2, 100=>101 , 0=>1 ,-2 => -3 ,3-2=>3-3 ,abc=>abc1 etc
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetIncreamentedValue(string str)
        {
            string number = "";
            string substr = "";
            for (int i = 1; i <= str.Length; i++)
            {
                substr = str.Substring(str.Length - i, i);
                if (substr.isIntAbs())
                {
                    number = substr;
                }
                else
                {
                    break;
                }
            }
            if (number == str)
            {
                return (str.ToInt() + 1).ToString();
            }
            string fin = str.Substring(0, str.Length - number.Length) + (number.ToInt() + 1).ToString();


            return fin;
        }

        public static string GetDisplayValue(ColumnTypes columnType, object value)
        {
            string val = string.Empty; ;
            if (value == null)
                return string.Empty;
            switch (columnType)
            {

                case ColumnTypes.Integer:
                    val = string.Format("{0}", Math.Round(Conversion.ToDouble(value.ToString().Replace(",", string.Empty)), 0));
                    break;
                case ColumnTypes.Amount:
                    if (Configuration.UseRoundedValue)
                    {
                        val = string.Format("{0}", Math.Round(Conversion.ToDouble(value.ToString().Replace(",", string.Empty)), 0));
                        val = WinFormHelper.GetFormattedNumber(val, ThousandSeparaterTypes.Nepali);
                    }
                    else
                    {
                        val = string.Format("{0}", Math.Round(Conversion.ToDouble(value.ToString().Replace(",", string.Empty)), 2));
                        val = WinFormHelper.GetFormattedNumber(val, ThousandSeparaterTypes.Nepali, 2);
                    }
                    break;
                case ColumnTypes.AmountRound2:
                    val = string.Format("{0}", Math.Round(Conversion.ToDouble(value.ToString().Replace(",", string.Empty)), 2));
                    val = WinFormHelper.GetFormattedNumber(val, ThousandSeparaterTypes.Nepali, 2);
                    break;
                case ColumnTypes.AmountRound:
                    val = string.Format("{0}", Math.Round(Conversion.ToDouble(value.ToString().Replace(",", string.Empty)), 0));
                    val = WinFormHelper.GetFormattedNumber(val, ThousandSeparaterTypes.Nepali);
                    break;
                case ColumnTypes.EnglishDate:
                    if (Validation.IsValidGregorianDate(value.ToString(), Configuration.DB_DATE_FORMAT))
                    {
                        val = Bsoft.Data.Validation.GetGregorianDate(value.ToString(), Configuration.DB_DATE_FORMAT).ToString(Configuration.DISPLAY_DATE_FORMAT).ToString();
                    }
                    break;
                case ColumnTypes.EnglishDateTime:
                    val = ((DateTime)value).ToString(Configuration.DATETIME_FORMAT);
                    break;
                case ColumnTypes.NepaliDate:
                    val = value.ToString();
                    if (val.Length == 8)
                    {
                        val = val.Substring(0, 4) + "/" + val.Substring(4, 2) + "/" + val.Substring(6, 2);
                    }

                    break;

                default:
                    throw new Exception(string.Format("Invalid DB type used for the column."));// {0}.", _dbColumnName));
                //throw new Exception(string.Format("Invalid DB type used for the column {0}.", _dbColumnName));
            }

            return val;
        }


        #region String utilities
        public static bool IsInteger(this string value)
        {
            if (IsNumeric(value))
            {
                if (value.Contains("."))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// supports numeric check for very long numbers as well eg 
        /// 1216465464764649764876487648764.1654764654897646547
        public static bool IsNumeric(this string value)
        {
            if (value == null || value == "")
            {
                return false;
            }
            System.Text.RegularExpressions.Regex alphaNumRegEx = new System.Text.RegularExpressions.Regex("^([0-9]*)\\.?([0-9]*)$");
            return alphaNumRegEx.IsMatch(value);
        }

        /// Negative number also taken as numeric
        public static bool IsNumericSigned(this string value)
        {
            if (value == null || value == "")
            {
                return false;
            }
            System.Text.RegularExpressions.Regex alphaNumRegEx = new System.Text.RegularExpressions.Regex("^(-?[0-9]*)\\.?([0-9]*)$");
            return alphaNumRegEx.IsMatch(value);
        }

      

        /// <summary>
        /// Find Range for integer
        /// </summary>
        /// <param name="value"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static bool IsInRange(this string value, decimal  start, decimal  end)
        {
            try
            {
                decimal  val = 0;
                decimal.TryParse(value, out val);
                if (val >= start && val <= end)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool IsIn(this string value, params string[] ranges)
        {
            foreach (string range in ranges)
            {
                if (value == range)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsIn(this string value, params int[] ranges)
        {
            int intValue = Conversion.ToInt(value);
            foreach (int range in ranges)
            {
                if (intValue == range)
                {
                    return true;
                }
            }
            return false;
        }

        public static string GetMoneyFromat(object value)
        {
            string val = string.Format("{0}", Math.Round(Conversion.ToDouble(value.ToString().Replace(",", string.Empty)), 2));
            val = WinFormHelper.GetFormattedNumber(val, ThousandSeparaterTypes.Nepali, 2);
            return val;
        }

        public static string ReplaceCaseInsensitive(this string value, string findString, string replaceString)
        {
            return Microsoft.VisualBasic.Strings.Replace(value, findString, replaceString, 1, -1, Microsoft.VisualBasic.CompareMethod.Text);
        }
        #endregion

    }
}
