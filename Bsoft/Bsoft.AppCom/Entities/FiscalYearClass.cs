using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.Common;
using Bsoft.Date;
namespace Bsoft.AppCom.Entities
{
    class FiscalYearClass
    {
        private string _FiscalYearValue;
        private int _StartYear;
        private int _EndYear;
        private int _FiscalStartMonth=4;
        private int _FiscalEndMonth = 3;
        public  Bsoft.Date.NepaliDate FiscalStartDateNep= null ;//Main var
        public Bsoft.Date.NepaliDate FiscalEndDateNep =null;//Main var
        public Bsoft.Date.NepaliDate FiscalStartDate = null;
        public Bsoft.Date.NepaliDate FiscalEndDate = null;

        #region Constructors
        public FiscalYearClass(string fiscalYearValue)
        {
            if (fiscalYearValue.Length != 9)
                throw new Exception("Fiscal year should be in format 2065/2068");
            try
            {
                string[] stend = fiscalYearValue.Split('/');
                _StartYear = stend[0].ToInt();
                _EndYear = stend[1].ToInt();
            }
            catch
            {
                throw new Exception("Fiscal year should be in format 2065/2068");
            }
            if (_EndYear < 1000 || _StartYear < 1000)
            {
                throw new Exception("Fiscal year should be in format 2065/2068");
            }

            _FiscalYearValue = fiscalYearValue;
      
            FiscalStartDateNep = new Bsoft.Date.NepaliDate(_StartYear, _FiscalStartMonth, 1);
            FiscalEndDateNep = new Bsoft.Date.NepaliDate(_EndYear, _FiscalEndMonth, Bsoft.Date.BsoftDateConverter.daysInNepaliMonth(_EndYear, _FiscalEndMonth));
        }
        /// <summary>
        /// From eng date
        /// </summary>
        /// <param name="dateTime"></param>
        public FiscalYearClass(DateTime dateTime)
        {
            Bsoft.Date.NepaliDate dt = new Bsoft.Date.NepaliDate(dateTime);
            NepaliDate fiscalStart = new NepaliDate(dt.Year, _FiscalStartMonth, 1);
            if (dateTime < fiscalStart.Englishdate)
            {
                FiscalStartDateNep = new NepaliDate(dt.Year - 1, _FiscalStartMonth, 1);
                FiscalEndDateNep = new NepaliDate(dt.Year, _FiscalEndMonth, Bsoft.Date.BsoftDateConverter.daysInNepaliMonth(dt.Year, _FiscalEndMonth));
            }
            else
            {
                FiscalStartDateNep = new NepaliDate(dt.Year, _FiscalStartMonth, 1);
                FiscalEndDateNep = new NepaliDate(dt.Year + 1, _FiscalEndMonth, Bsoft.Date.BsoftDateConverter.daysInNepaliMonth(dt.Year + 1, _FiscalEndMonth));
            }
        }
        public FiscalYearClass(Bsoft.Date.NepaliDate nepdateTime):this(nepdateTime.Englishdate)
        {
        }

       

        #endregion

        public static string GetFiscalStartDate(string SuperAdmin_FISCALYEARString)
        {
            FiscalYearClass fyc = new FiscalYearClass(SuperAdmin_FISCALYEARString);
            return fyc.FiscalStartDate.ToString();
        }

    }
}
