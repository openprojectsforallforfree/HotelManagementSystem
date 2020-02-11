using System;
using System.Collections.Generic;
using System.Text;

using CrudeFx.NepaliDate;

namespace Bsoft.AppCom
{
    /// <summary>
    /// This class stores From and To date of specific nepali fiscal year. It also stores the English from and to date of the specific FiscalYear
    /// </summary>
    public class FiscalYear : IComparable<FiscalYear>, IEquatable<FiscalYear>
    {
        #region Member variables.
        private string _FiscalYearValue = "";
        private NepaliDate _fromNepaliDate = new NepaliDate();
        private NepaliDate _toNepaliDate = new NepaliDate();
        private DateTime _fromEnglishDate = new DateTime();
        private DateTime _toEnglishDate = new DateTime();
        #endregion

        #region Constructors & Finalizers.
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fromNepaliDate">Nepali Date from which the fiscal year starts.</param>
        /// <param name="toNepaliDate">Nepali Date in which the fiscal year ends.</param>
        public FiscalYear(NepaliDate fromNepaliDate, NepaliDate toNepaliDate)
        {
            InitializeClass(fromNepaliDate, toNepaliDate, "");
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fromNepaliDate">Nepali Date from which the fiscal year starts.</param>
        /// <param name="toNepaliDate">Nepali Date in which the fiscal year ends.</param>
        public FiscalYear(string fromNepaliDate, string toNepaliDate)
        {
            InitializeClass(new NepaliDate(fromNepaliDate), new NepaliDate(toNepaliDate), "");
        }

        

       
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="fiscalyear">Fiscal year in the format yyyy/yyyy, eg 2064/2065</param>
        public FiscalYear(string fiscalyear)
        {
            if (fiscalyear.Trim().Length != 9)
            {
                throw new Exception("Invalid fiscal year passed. passed value = " + fiscalyear);
            }
            string[] years = fiscalyear.Split(new char[] { '/' });

            if (years.Length != 2)
            {
                throw new Exception("Invalid fiscal year passed. passed value = " + fiscalyear);
            }

            NepaliDate fromNepaliDate = new NepaliDate(years[0] + "/04/01");
            NepaliDate toNepaliDate = new NepaliDate(years[1] + "/04/01");
            toNepaliDate = toNepaliDate.AddDays(-1);

           // InitializeClass(fromNepaliDate, toNepaliDate, -1);
        }

        private void InitializeClass(NepaliDate fromNepaliDate, NepaliDate toNepaliDate, string  fiscalYearValue)
        {
            _fromNepaliDate = fromNepaliDate;
            _toNepaliDate = toNepaliDate;
            _FiscalYearValue = fiscalYearValue;
            //now convert the Nepali Date to english date
            _fromEnglishDate = DateConvertor.GetEnglishDate(_fromNepaliDate.ToString());
            _toEnglishDate = DateConvertor.GetEnglishDate(_toNepaliDate.ToString());
        }
        #endregion

       

        #region Properties

        /// <summary>
        /// Gets or Sets the Nepali Date from which the fiscal year starts
        /// </summary>
        public NepaliDate FromNepaliDate
        {
            get { return _fromNepaliDate; }
            set { _fromNepaliDate = value; }
        }

        /// <summary>
        /// Gets or Sets the Nepali date to which the fiscal year.
        /// </summary>
        public NepaliDate ToNepaliDate
        {
            get { return _toNepaliDate; }
            set { _toNepaliDate = value; }
        }
        
        /// <summary>
        /// Gets or sets the English Date (A.D.) from which the Nepali fiscal year starts.
        /// </summary>
        public DateTime FromEnglishDate
        {
            get { return _fromEnglishDate; }
            set { _fromEnglishDate = value; }
        }


        /// <summary>
        /// Gets or sets the English Date to which the Nepali fiscal year runs.
        /// </summary>
        public DateTime ToEnglishDate
        {
            get { return _toEnglishDate; }
            set { _toEnglishDate = value; }
        }


        /// <summary>
        /// Gets or sets the Fiscal year ID that is stored in the DB.
        /// </summary>
        public string  FiscalYearValue
        {
            get { return _FiscalYearValue; }
            set { _FiscalYearValue = value; }
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("{0}/{1}", _fromNepaliDate.Year, _toNepaliDate.Year);            
        }

        public FiscalYear GetNextFiscalYear()
        {
            return FiscalYear.GetNextFiscalYear(this);
        }

        public FiscalYear GetPreviousFiscalYear()
        {
            return FiscalYear.GetPreviousFiscalYear(this);
        }

        public static FiscalYear GetNextFiscalYear(FiscalYear fiscalYear)
        {
            FiscalYear next = new FiscalYear(fiscalYear.ToString());
            next.FromNepaliDate = new NepaliDate(fiscalYear.FromNepaliDate.Year + 1, fiscalYear.FromNepaliDate.Month, fiscalYear.FromNepaliDate.Day);
            next.ToNepaliDate= new NepaliDate(fiscalYear.ToNepaliDate.Year + 1, 5, 1);
            next.ToNepaliDate = next.ToNepaliDate.AddDays(-1);
            return next;
        }

        public static FiscalYear GetPreviousFiscalYear(FiscalYear fiscalYear)
        {
            FiscalYear previuos = new FiscalYear(fiscalYear.ToString());
            previuos.FromNepaliDate = new NepaliDate(fiscalYear.FromNepaliDate.Year - 1, fiscalYear.FromNepaliDate.Month, fiscalYear.FromNepaliDate.Day);
            previuos.ToNepaliDate = new NepaliDate(fiscalYear.ToNepaliDate.Year - 1, 5, 1);
            previuos.ToNepaliDate = previuos.ToNepaliDate.AddDays(-1);
            return previuos;
        }
        #endregion

        #region IComparer<FiscalYear> Members

        //public int Compare(FiscalYear x, FiscalYear y)
        //{
        //    if (x.FromEnglishDate.Year > y.FromEnglishDate.Year)
        //        return 1;
        //    else if (x.FromEnglishDate.Year == y.FromEnglishDate.Year)
        //        return 0;
        //    else
        //        return -1;
        //}

        #endregion

        #region IComparable<FiscalYear> Members

        public int CompareTo(FiscalYear other)
        {
            if (_fromEnglishDate.Year > other.FromEnglishDate.Year)
                return 1;
            else if (_fromEnglishDate.Year == other.FromEnglishDate.Year)
                return 0;
            else
                return -1;
        }

        #endregion

        #region IEquatable<FiscalYear> Members

        public bool Equals(FiscalYear other)
        {
            if (_fromNepaliDate.ToString() == other.FromNepaliDate.ToString())
                return true;
            else 
                return false;            
        }

        #endregion
    }    
}
