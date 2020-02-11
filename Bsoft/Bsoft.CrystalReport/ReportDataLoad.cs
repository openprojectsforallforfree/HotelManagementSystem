using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using Shangrila.Convertor;


namespace Bsoft.CrystalReport
{
    public partial  class ReportBase
    {
        #region Member Variables

        Shangrila.Convertor.TrueTypeToUnicode uc = new TrueTypeToUnicode();
        #endregion
        public void SetFieldValue(DataRow dr, string colValue, string FieldName, FieldTypes FldType)
        {
            SetFieldValue(dr, colValue, FieldName, FldType, "");
        }

        public void SetFieldValue(DataRow dr, string colName, string FieldName, FieldTypes FldType, string SubReportName)
        {
            //If Type of Formula Field In Crystal Report 
            string ColVal = string.Empty;
            if (dr[colName].ToString().Trim().Length > 0)
            {
                ColVal = dr[colName].ToString();
            }
           // ColVal = CommonReportClass.SQuote(ColVal.Replace("'", "''"));
            ColVal = getValue(ColVal, FldType);
            if (SubReportName.Trim().Length > 0)
            {
                _reportDocument.Subreports[SubReportName].DataDefinition.FormulaFields[FieldName].Text = ColVal;
            }
            else
            {
                _reportDocument.DataDefinition.FormulaFields[FieldName].Text = ColVal;
            }

        }


        //public void SetDataToFormulaFields(DataTable dt,
        public void SetFieldValue(DataGridView grid, string colValue, string FieldName, FieldTypes FldType)
        {
            SetFieldValue(grid, colValue, FieldName, FldType, "");
        }

        public void SetFieldValue(DataGridView grid, string colName, string FieldName, FieldTypes FldType, string SubReportName)
        {
            //If Type of Formula Field In Crystal Report 
            string ColVal = string.Empty;
            if (grid.CurrentRow.Cells[colName].Value.ToString().Trim().Length > 0)
            {
                ColVal = grid.CurrentRow.Cells[colName].Value.ToString();
            }
            ColVal = CommonReportClass.SQuote(ColVal.Replace("'", "''"));
            ColVal = getValue(ColVal, FldType);
            if (SubReportName.Trim().Length > 0)
            {
                _reportDocument.Subreports[SubReportName].DataDefinition.FormulaFields[FieldName].Text = ColVal;
            }
            else
            {
                _reportDocument.DataDefinition.FormulaFields[FieldName].Text = ColVal;
            }

        }

        public void SetFieldValue(string Value, string FieldName, FieldTypes FldType)
        {
            SetFieldValue(Value, FieldName, FldType, "");
        }
        public void SetFieldValue(string Value, string FieldName, FieldTypes FldType, string SubReportName)
        {
            Value = getValue(Value,FldType );
            if (Value.Trim().Length > 0)
            {
                if (SubReportName.Trim().Length > 0)
                {
                    _reportDocument.Subreports[SubReportName].DataDefinition.FormulaFields[FieldName].Text = CommonReportClass.SQuote(Value.Replace("'", "''"));
                }
                else
                {
                    _reportDocument.DataDefinition.FormulaFields[FieldName].Text = CommonReportClass.SQuote(Value.Replace("'", "''"));
                }
            }
        }
        public void SetParameterValue(string Value, string FieldName, FieldTypes FldType)
        {
            SetParameterValue(Value, FieldName, FldType, "");
        }

        private void SetParameterValue(string Value, string FieldName, FieldTypes FldType, string p)
        {
            throw new NotImplementedException();
        }
        public void ValuesInParameter(string Value, string FieldName, FieldTypes FldType, string SubReportName)
        {
            getValue(Value, FldType);
            if (SubReportName.Trim().Length > 0)
            {
                _reportDocument.SetParameterValue(FieldName, Value, SubReportName);
            }
            else
            {
                _reportDocument.SetParameterValue(0, Value);
            }
        }

        private string getValue(string Value, FieldTypes FldType)
        {
            if (FldType == FieldTypes.String)
            {
                Value = CommonReportClass.SQuote(Value.Replace("'", "''"));
            }
            else if (FldType == FieldTypes.NepaliDate)
            {
                Value = CommonReportClass.SQuote(uc.ConvertToUnicode(Value));
            }
            else if (FldType == FieldTypes.Numeric)
            {
                Value = CommonReportClass.CrNumber(uc.ConvertToUnicode(Value));
            }
            return Value;
        }

        public bool LoadDataTableInReport(DataTable dt)
        {
            bool status = false;
            _reportDocument.SetDataSource(dt);
            return status;
        }
        public bool LoadDataTableInReport(string SubReportName, DataTable dt)
        {
            bool status = false;
            _reportDocument.Subreports[SubReportName].SetDataSource(dt);
            return status;
        }
    }
}
