using System;
using System.Collections.Generic;
using System.Text;

namespace Bsoft.Date
{
    public enum WeekNameFormat
    {
        /// <summary>
        /// "आ"
        /// </summary>
        Short,
        /// <summary>
        /// "आईतबार"
        /// </summary>
        Long,
        /// <summary>
        /// "१"
        /// </summary>
        Number

    }

    public static class generalNepaliFunctions
    {
        public static string getShortWeekName(int weekday)
        {
            switch (weekday)
            {
                case 1:
                    return "आ";
                case 2:
                    return "सो";
                case 3:
                    return "म";
                case 4:
                    return "बु";
                case 5:
                    return "बि";
                case 6:
                    return "शु";
                case 7:
                    return "श";
            }
            return "आ";
        }
        public static string getUnicodeNepali(char ch)
        {
            switch (ch)
            {
                case '1':
                    return "१";
                case '2':
                    return "२";
                case '3':
                    return "३";
                case '4':
                    return "४";
                case '5':
                    return "५";
                case '6':
                    return "६";
                case '7':
                    return "७";
                case '8':
                    return "८";
                case '9':
                    return "९";
                case '0':
                    return "०";
            }
            return ch.ToString();
        }
        public static string getUnicodeNepali(string number)
        {
            string uni = "";
            foreach (char ch in number)
            {
                uni += getUnicodeNepali(ch);
            }
            return uni;

        }
        public static string getAsciiNepali(char ch)
        {
            switch (ch)
            {
                case '१':
                    return "1";
                case '२':
                    return "2";
                case '३':
                    return "3";
                case '४':
                    return "4";
                case '५':
                    return "5";
                case '६':
                    return "6";
                case '७':
                    return "7";
                case '८':
                    return "8";
                case '९':
                    return "9";
                case '०':
                    return "0";
            }
            return ch.ToString();
        }
        public static string getAsciiNepali(string number)
        {
            string asc = "";
            foreach (char ch in number)
            {
                asc += getAsciiNepali(ch);
            }
            return asc;

        }
        public static string getFullWeekName(int weekday)
        {
            switch (weekday)
            {
                case 1:
                    return "आईतबार";
                case 2:
                    return "सोमबार";
                case 3:
                    return "मंगलबार";
                case 4:
                    return "बुधबार";
                case 5:
                    return "बिहीबार";
                case 6:
                    return "शुक्रबार";
                case 7:
                    return "शनिबार";
            }
            return "आईतबार";
        }
        public enum NeplaiMonthFormat
        {
            /// <summary>
            /// "बैशाख","जेष्ठ","आषाढ़","श्रावण","भाद्र","आश्विन","कार्तिक","मार्ग","पौष","माघ","फाल्गुन","चैत्र"     
            /// </summary>
            Nepali,
            /// <summary>
            /// "बैशाख","जेष्ठ","असार","सावन","भादौ","असोज","कार्तिक","मंसिर","पुष/पूस","माघ","फागुन","चैत"
            /// </summary>
            //Nepali2,
            /// <summary>
            /// "Baishākh","Jeṭha","Asār","Sāun","Bhadau","Asoj","Kartik","Mangsir","Push","Magh","Falgun","Chaitra"
            /// </summary>
            Roman,
            /// <summary>
            /// "१"
            /// </summary>
            Number
        }
        public static string getFullMonthName(int MonthNo, NeplaiMonthFormat format)
        {
            MonthNo--;
            string[] monthRoman = new string[12] { "Baishākh", "Jeṭha", "Asār", "Sāun", "Bhadau", "Asoj", "Kartik", "Mangsir", "Push", "Magh", "Falgun", "Chaitra" };
            string[] monthNepali1 = new string[12] { "बैशाख", "जेष्ठ", "आषाढ़", "श्रावण", "भाद्र", "आश्विन", "कार्तिक", "मार्ग", "पौष", "माघ", "फाल्गुन", "चैत्र" };
            // string[] monthNepali2 = new string[12] { "बैशाख", "जेष्ठ", "असार", "सावन", "भादौ", "असोज", "कार्तिक", "मंसिर", "पुष/पूस", "माघ", "फागुन", "चैत" };
            switch (format)
            {
                case NeplaiMonthFormat.Roman:
                    return monthRoman[MonthNo];
                case NeplaiMonthFormat.Nepali:
                    return monthNepali1[MonthNo];
                //case NeplaiMonthFormat.Nepali2:
                //    return monthNepali2[MonthNo];
                //    break;
                case NeplaiMonthFormat.Number:
                    return getUnicodeNepali(MonthNo.ToString());
            }
            return monthNepali1[MonthNo];
        }

        public static string getFullMonthName(int MonthNo)
        {
            MonthNo--;
            string[] monthNepali1 = new string[12] { "बैशाख", "जेष्ठ", "आषाढ़", "श्रावण", "भाद्र", "आश्विन", "कार्तिक", "मार्ग", "पौष", "माघ", "फाल्गुन", "चैत्र" };
            if (MonthNo > -1)
                return monthNepali1[MonthNo];
            else
                return "";
        }
        public static int getMonthNo(string MonthName)
        {

            string[] monthNepali1 = new string[12] { "बैशाख", "जेष्ठ", "आषाढ़", "श्रावण", "भाद्र", "आश्विन", "कार्तिक", "मार्ग", "पौष", "माघ", "फाल्गुन", "चैत्र" };

            for (int i = 0; i < 12; i++)
            {
                if (MonthName.IndexOf(monthNepali1[i]) >= 0)
                {
                    return i + 1;
                }
            }

            return -1;
        }

        //public static int getMonthNo(string  MonthName)
        //{

        //    string[] monthNepali1 = new string[12] { "बैशाख", "जेष्ठ", "आषाढ़", "श्रावण", "भाद्र", "आश्विन", "कार्तिक", "मार्ग", "पौष", "माघ", "फाल्गुन", "चैत्र" };
        //    for (int i = 0; i < 12;i++ )
        //    {
        //        if (MonthName == monthNepali1 [i])
        //        {
        //            return i+1;
        //        }
        //    }
        //    return -1;
        //}
    }
}
