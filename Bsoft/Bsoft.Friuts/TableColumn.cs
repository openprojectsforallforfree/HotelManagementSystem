using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Bsoft.Controls;
using Bsoft;
using System.Linq;
using Bsoft.Common;

using Bsoft.Data;
using CrudeFx.NepaliDate;

// 2011 june 16 Added guid
namespace Friuts
{
   

    public class TableColumn : IComparable<TableColumn>, IEqualityComparer<TableColumn>
    {
        #region Member variables.
        private string _dbColumnName = string.Empty;
        //private object _value = string.Empty;
        private ColumnTypes _type = ColumnTypes.String;
        private Control ctrl = null;
        private bool _isCumpulsory = false;
        private string _displayFieldName = string.Empty;
        private string _customErrorMsg = string.Empty;
        private Control _existingValueDisplayControl = null;
        private bool _isUniqueValueColumn = false;
        private bool _isPrimaryKeyColumn = false;
        private string _dataTableColumn = string.Empty;
        private string _errMessage = string.Empty;
        private string _sequenceName = string.Empty;
        private bool _useMaxValue = false;
        private string _displayColumnAlias = string.Empty;
        private string _dbColumnSearchAlias = string.Empty;  
        private object _customValue = null;
        private bool _isSortable = false;
        private bool _IsCaseStatement = false;
        private string _CaseStatementColumnAlias = string.Empty;

        #endregion

        #region Constructors & Finalizers.

        public TableColumn(string dbColumnName, ColumnTypes type, Control control)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            ctrl = control;
        }

        public TableColumn(string dbColumnName, ColumnTypes type, string dataTableColumn)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            _dataTableColumn = dataTableColumn;
        }

        public TableColumn(string dbColumnName, ColumnTypes type, string dataTableColumn, bool isPrimaryKeyColumn)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            _dataTableColumn = dataTableColumn;
            _isPrimaryKeyColumn = isPrimaryKeyColumn;
        }

        //use For String colun Sorting..       
        public TableColumn(string dbColumnName, ColumnTypes type, string dataTableColumn, bool isPrimaryKeyColumn, bool isSortable)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            _dataTableColumn = dataTableColumn;
            _isPrimaryKeyColumn = isPrimaryKeyColumn;
            _isSortable = isSortable;
        }

        //use for Case Statement....
        public TableColumn(string dbColumnName, ColumnTypes type, string dataTableColumn, bool isPrimaryKeyColumn, bool isSortable, bool IsCaseStatement)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            _dataTableColumn = dataTableColumn;
            _isPrimaryKeyColumn = isPrimaryKeyColumn;
            _isSortable = isSortable;
            _IsCaseStatement = IsCaseStatement;
        }

        //use For case Statement's Alias Db Column Names
        public TableColumn(string dbColumnName, ColumnTypes type, string dataTableColumn, bool isPrimaryKeyColumn, bool isSortable, bool IsCaseStatement, string CaseStatementColumnAlias)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            _dataTableColumn = dataTableColumn;
            _isPrimaryKeyColumn = isPrimaryKeyColumn;
            _isSortable = isSortable;
            _IsCaseStatement = IsCaseStatement;
            _CaseStatementColumnAlias = CaseStatementColumnAlias;
        }


        public TableColumn(string dbColumnName, ColumnTypes type, Control control, bool isPrimaryKeyColumn, string sequenceName)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            ctrl = control;
            _isPrimaryKeyColumn = isPrimaryKeyColumn;
            _sequenceName = sequenceName.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbColumnName"></param>
        /// <param name="type"></param>
        /// <param name="control"></param>
        /// <param name="isPrimaryKeyColumn"></param>
        /// <param name="useMaxValue">It will use (MAX value of the ID column + 1) as the new ID.</param>
        public TableColumn(string dbColumnName, ColumnTypes type, Control control, bool isPrimaryKeyColumn, bool useMaxValue)
        {
            if (_useMaxValue)
            {
                if (type != ColumnTypes.Number)
                    throw new Exception("To set useMaxValue as true the column type must be Number");
            }

            _dbColumnName = dbColumnName;
            _type = type;
            ctrl = control;
            _isPrimaryKeyColumn = isPrimaryKeyColumn;
            _useMaxValue = useMaxValue;

        }

        public TableColumn(string dbColumnName, ColumnTypes type, Control control, Control existingValueDisplayControl)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            ctrl = control;
            _existingValueDisplayControl = existingValueDisplayControl;
        }

        public TableColumn(string dbColumnName, ColumnTypes type, Control control, string displayFieldName)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            ctrl = control;
            _isCumpulsory = false;
            _displayFieldName = displayFieldName;
        }

        public TableColumn(string dbColumnName, ColumnTypes type, object customValue)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            _isCumpulsory = false;
            _customValue = customValue;
        }

        public TableColumn(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, string customErrorMsg)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            ctrl = control;
            _displayFieldName = displayFieldName;
            _isCumpulsory = isCompulsory;
            _customErrorMsg = customErrorMsg;
        }

        public TableColumn(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, string customErrorMsg, Control existingValueDisplayControl)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            ctrl = control;
            _isCumpulsory = isCompulsory;
            _displayFieldName = displayFieldName;
            _customErrorMsg = customErrorMsg;
            _existingValueDisplayControl = existingValueDisplayControl;
        }

        public TableColumn(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, Control existingValueDisplayControl)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            ctrl = control;
            _isCumpulsory = isCompulsory;
            _displayFieldName = displayFieldName;
            _isUniqueValueColumn = false;
            _existingValueDisplayControl = existingValueDisplayControl;
        }

        public TableColumn(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, bool isUniqueValueColumn, Control existingValueDisplayControl)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            ctrl = control;
            _isCumpulsory = isCompulsory;
            _displayFieldName = displayFieldName;
            _isUniqueValueColumn = isUniqueValueColumn;
            _existingValueDisplayControl = existingValueDisplayControl;
        }

        public TableColumn(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, string customErrorMsg, bool isUniqueValueColumn, Control existingValueDisplayControl)
        {
            _dbColumnName = dbColumnName;
            _type = type;
            ctrl = control;
            _isCumpulsory = isCompulsory;
            _displayFieldName = displayFieldName;
            _isUniqueValueColumn = isUniqueValueColumn;
            _customErrorMsg = customErrorMsg;
            _existingValueDisplayControl = existingValueDisplayControl;
        }

        #endregion

        #region Nested Enums, Structs, and Classes.

        #endregion

        #region Properties

        public string DbColumnName
        {
            get { return _dbColumnName; }
            set { _dbColumnName = value; }
        }


        public ColumnTypes Type
        {
            get { return _type; }
            set { _type = value; }
        }


        public Control Control
        {
            get { return ctrl; }
            set { ctrl = value; }
        }


        public bool IsCumpulsory
        {
            get { return _isCumpulsory; }
            set { _isCumpulsory = value; }
        }


        public string DisplayFieldName
        {
            get { return _displayFieldName; }
            set { _displayFieldName = value; }
        }


        public string CustomErrorMsg
        {
            get { return _customErrorMsg; }
            set { _customErrorMsg = value; }
        }


        public Control ExistingValueDisplayControl
        {
            get { return _existingValueDisplayControl; }
            set { _existingValueDisplayControl = value; }
        }


        public bool IsUniqueValueColumn
        {
            get { return _isUniqueValueColumn; }
            set { _isUniqueValueColumn = value; }
        }

        public object Value
        {
            get
            {
                return TableColumn.GetValue(ctrl, _customValue);
            }
        }


        public string ErrMessage
        {
            get { return _errMessage; }
            set { _errMessage = value; }
        }

        public string DBValue
        {
            get
            {
                return GetDBValue(_type, Value);
            }
        }

        public bool IsPrimaryKeyColumn
        {
            get { return _isPrimaryKeyColumn; }
            set { _isPrimaryKeyColumn = value; }
        }


        public string DataTableColumn
        {
            get { return _dataTableColumn; }
            set { _dataTableColumn = value; }
        }


        public string SequenceName
        {
            get { return _sequenceName; }
            set { _sequenceName = value; }
        }


        public bool UseMaxValue
        {
            get { return _useMaxValue; }
            set { _useMaxValue = value; }
        }


        public string DisplayColumnAlias
        {
            get { return _displayColumnAlias; }
            set { _displayColumnAlias = value; }
        }

        public string DbColumnSearchAlias
        {
            get { return _dbColumnSearchAlias; }
            set { _dbColumnSearchAlias = value; }
        }

        public object CustomValue
        {
            get { return _customValue; }
            set { _customValue = value; }
        }

         public bool isSortable
        {
            get { return _isSortable; }
            set { _isSortable = value; }
        }

        public bool IsCaseStatement
        {
            get { return _IsCaseStatement; }
            set { _IsCaseStatement = value; }
        }

        public string CaseStatementColumnAlias
        {
            get { return _CaseStatementColumnAlias; }
            set { _CaseStatementColumnAlias = value; }
        }

        #endregion

        #region Methods

        public static object GetValue(Control ctrl)
        {
            return TableColumn.GetValue(ctrl, null);
        }
        public static object GetValue(Control ctrl, object customValue)
        {
            if (ctrl == null)
            {
                return customValue != null ? customValue.ToString() : string.Empty;
            }
            
            else if (ctrl is VtextBox)
            {
                return ((VtextBox)ctrl).Value;
            }
            else if (ctrl is Label )
            {
                return ((Label)ctrl).Text ;
            }
            else if (ctrl is TextBox | ctrl is Bsoft.Controls.lblTextBox)
            {
                //return ctrl.Text; //Do not allow the space
                return ctrl.Text.Trim();
            }

            else if (ctrl is NumericUpDown)
            {
                return ctrl.Text.Trim();
            }

            else if (ctrl is DateTimePicker)
            {
                 
                string val = ((DateTimePicker)ctrl).Value.ToString(Configuration.DB_DATE_FORMAT);
                return val;
                //return ctrl.Text;
            }
            else if (ctrl is NepaliDatePicker)
            {
                if (ctrl.Enabled)
                {
                    string Nval = ((CrudeFx.NepaliDate.NepaliDatePicker)ctrl).Value.ToString (DateFormatTypes.yyyyMMdd );
                    Nval = Nval.Replace("/","");
                    return Nval;
                    // return ctrl.Text;
                }
                else
                    return string.Empty;
            }
            else if (ctrl is RadioButton)
            {
                return ((RadioButton)ctrl).Checked;
            }
            else if (ctrl is ComboBox)
            {
                ComboItem itm = (ComboItem)((ComboBox)ctrl).SelectedItem;
                if (itm != null)
                    return itm.Key;
                else
                    return null;
            }
            else if (ctrl is Bsoft.Controls.lblComboBox)
            {
                ComboItem itm = (ComboItem)(((Bsoft.Controls.lblComboBox)ctrl).cmbBox).SelectedItem;
                if (itm != null)
                    return itm.Key;
                else
                    return null;
            }

            else if (ctrl is CheckBox)
            {
                if (((CheckBox)ctrl).Checked)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }

            }
            else
                return null;

        }
        public string GetDisplayValue()
        {
            return TableColumn.GetDisplayValue(this._type, Value);
        }

        public string GetDisplayValue(object value)
        {
            return TableColumn.GetDisplayValue(this._type, value);
        }

        public static string GetDisplayValue(ColumnTypes columnType, object value)
        {
            string val = string.Empty; ;
            if (value == null)
                return string.Empty;
            switch (columnType)
            {
                case ColumnTypes.String:
                case ColumnTypes.Guid:
                    val = value.ToString();
                    break;
                case ColumnTypes.Number:
                    //val = string.Format("{0}", value.ToString());
                    val = value.ToString();
                    break;
                case ColumnTypes.Integer:
                    val = string.Format("{0}", Math.Round(Conversion.ToDouble(value.ToString().Replace(",", string.Empty)), 0));
                    break;
                case ColumnTypes.Amount:
                    if (Configuration.UseRoundedValue )
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
                    if (Validation.IsValidGregorianDate(value.ToString(),Configuration .DB_DATE_FORMAT ))
                    {
                        ////val = ((DateTime)value).ToString(ConfigFx.DATE_FORMAT);
                        //val = Convert.ToDateTime(value).ToString(Configuration.DISPLAY_DATE_FORMAT);
                        val = Bsoft.Data .Validation .GetGregorianDate (value.ToString (),Configuration.DB_DATE_FORMAT ).ToString (Configuration .DISPLAY_DATE_FORMAT ).ToString ();
                    }
                    break;
                case ColumnTypes.EnglishDateTime:
                    val = ((DateTime)value).ToString(Configuration.DATETIME_FORMAT);
                    break;
                case ColumnTypes.NepaliDate:
                    val = value.ToString();
                    if (val.Length ==8 )
                    {
                        val = val.Substring(0, 4) + "/" + val.Substring(4, 2) + "/" + val.Substring(6, 2);
                    }
                    if (CrudeFx.NepaliDate.NepaliDate.IsValidDate(val))
                    {
                      //  val = value.ToString();
                    }
                    else
                    {
                        val = value.ToString();
                    }
                    break;
                case ColumnTypes.Boolean:
                    val = string.Format("{0}", (bool)value);
                    break;
                case ColumnTypes.SysDate: 
                    val = string.Format("{0}", "SysDate"); //directly store the sysdate in englis date time columns
                    break;
                default:
                    throw new Exception(string.Format("Invalid DB type used for the column."));// {0}.", _dbColumnName));
                //throw new Exception(string.Format("Invalid DB type used for the column {0}.", _dbColumnName));
            }

            return val;
        }

        public static string GetDBStringValue(object value)
        {
            return GetDBValue(ColumnTypes.String, value);
        }

        public static string GetDBValue(ColumnTypes columnType, object value)
        {
            return GetDBValue(columnType, value, false);
        }

        public static string GetDBValue(ColumnTypes columnType, object value, bool forCrystalReport)
        {
            string val;
            //if ( value ==null)
            //{
            //return "";
            //}
            switch (columnType)
            {
                case ColumnTypes.String:
                case ColumnTypes.Guid:
                    val = string.Format("'{0}'", value.ToString().Replace("'", "''"));
                    break;
                case ColumnTypes.Number:

                    val = string.Format("{0}", value.ToString());

                    break;
                case ColumnTypes.Integer:
                    val = string.Format("{0}", Math.Round(Conversion.ToDouble(value.ToString().Replace(",", string.Empty)), 0));
                    break;
                case ColumnTypes.Amount:
                    if (Configuration.UseRoundedValue)
                        val = string.Format("{0}", Math.Round(Conversion.ToDouble(value.ToString().Replace(",", string.Empty)), 0));
                    else
                        val = string.Format("{0}", Math.Round(Conversion.ToDouble(value.ToString().Replace(",", string.Empty)), 2));
                    break;
                case ColumnTypes.AmountRound2:
                    val = string.Format("{0}", Math.Round(Conversion.ToDouble(value.ToString().Replace(",", string.Empty)), 2));
                    break;
                case ColumnTypes.AmountRound:
                    val = string.Format("{0}", Math.Round(Conversion.ToDouble(value.ToString().Replace(",", string.Empty)), 0));
                    break;
                case ColumnTypes.EnglishDate:
                    if (forCrystalReport)
                        val = string.Format("#{0}#", ((DateTime)value).ToString(Configuration.DATE_DISPLAY_FORMAT));
                    else
                        val = string.Format("'{0}'", ((DateTime)value).ToString(Configuration.DB_DATE_FORMAT));
                    break;
                case ColumnTypes.EnglishDateTime:
                    if (forCrystalReport)
                        val = string.Format("#{0}#", ((DateTime)value).ToString(Configuration.DATETIME_FORMAT));
                    else
                        val = string.Format(" TO_DATE('{0}', '{1}')", ((DateTime)value).ToString(Configuration.DB_DATETIME_FORMAT), Configuration.DB_DATETIME_FORMAT_STRING);
                    break;
                case ColumnTypes.NepaliDate:
                    val = string.Format("'{0}'", value.ToString());
                    break;
                case ColumnTypes.Boolean:
                    val = string.Format("{0}", (bool)value);
                    break;
                case ColumnTypes.SysDate:
                    val = string.Format("{0}", "SysDate"); //Directly Store SysDate in Entry form only..
                    break;
                default:
                    throw new Exception(string.Format("Invalid DB type used for the column."));// {0}.", _dbColumnName));
                //throw new Exception(string.Format("Invalid DB type used for the column {0}.", _dbColumnName));
            }

            return val;
        }

        /// <summary>
        /// Validates the value in the control and return if 
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            bool valid = true;
            string val = Value == null ? string.Empty : Value.ToString();
            switch (_type)
            {
                case ColumnTypes.String:
                case ColumnTypes.Guid:
                    if (_isCumpulsory && val.Length == 0)
                    {
                        valid = false;
                        //set the errMessage to be displayed.
                        SetErrorMsg(string.Format(Messeges.EMPTY_FIELD_ERR_MSG, _displayFieldName));
                    }
                    break;
                case ColumnTypes.Number:
                case ColumnTypes.Integer:
                case ColumnTypes.Amount:
                case ColumnTypes.AmountRound2:
                case ColumnTypes.AmountRound:
                    if (_type == ColumnTypes.Amount
                        || _type == ColumnTypes.AmountRound2
                        || _type == ColumnTypes.AmountRound)
                    {
                        val = val.Replace(",", string.Empty);
                    }

                    if (!Validation.IsNumeric(val))
                    {
                        if (_isCumpulsory)
                        {
                            valid = false;
                            //set the errMessage to be displayed.
                            SetErrorMsg(string.Format(Messeges.INVALID_NUMBER_ERR_MSG, _displayFieldName));
                        }
                        //else
                        //{
                        //    ctrl.Text = "0";
                        //}
                    }
                    break;
                case ColumnTypes.EnglishDate:
                    if (_isCumpulsory || val.Length > 0)
                    {
                        if (!Validation.IsValidGregorianDate(val,Configuration .DB_DATE_FORMAT ))
                        {
                            valid = false;
                            //set the errMessage to be displayed.
                            SetErrorMsg(string.Format(Messeges.INVALID_DATE_ERR_MSG, _displayFieldName));
                        }
                    }
                    break;
                case ColumnTypes.EnglishDateTime:
                    if (_isCumpulsory || val.Length > 0)
                    {
                        if (!Validation.IsValidGregorianDate(val,Configuration .DB_DATE_FORMAT ))
                        {
                            valid = false;
                            //set the errMessage to be displayed. [27-April-2009]
                            SetErrorMsg(string.Format(Messeges.INVALID_DATE_ERR_MSG, _displayFieldName));
                        }
                    }
                    break;

                case ColumnTypes.NepaliDate:
                    if (_isCumpulsory || val.Length > 0)
                    {
                        val = val.Substring(0, 4) + "/" + val.Substring(4, 2) + "/" + val.Substring(6, 2);
                        if (!CrudeFx.NepaliDate.NepaliDate.IsValidDate(val.Trim()))
                        {
                            valid = false;
                            //set the errMessage to be displayed.
                            SetErrorMsg(string.Format(Messeges.INVALID_DATE_ERR_MSG, _displayFieldName));
                        }
                    }
                    break;
                case ColumnTypes.Boolean:
                    break;
                case ColumnTypes.SysDate:
                    break;
                default:
                    throw new Exception(string.Format("Invalid DB type used for the column {0}.", _dbColumnName));
            }
            return valid;
        }


        private void SetErrorMsg(string errMsg)
        {
            if (_customErrorMsg.Trim().Length > 0)
                _errMessage = _customErrorMsg;
            else
                _errMessage = errMsg;
        }
        #endregion


        #region IComparable<TableColumn> Members

        int IComparable<TableColumn>.CompareTo(TableColumn other)
        {
            if (this.DbColumnName.Equals(other.DbColumnName))
                return 0;
            else
                return 1;
        }

        #endregion

        #region IEqualityComparer<TableColumn> Members

        bool IEqualityComparer<TableColumn>.Equals(TableColumn x, TableColumn y)
        {
            if (x.DbColumnName == y.DbColumnName)
                return true;
            else
                return false;
        }

        int IEqualityComparer<TableColumn>.GetHashCode(TableColumn obj)
        {
            return ((string)(obj.DbColumnName + obj.DataTableColumn)).ToLowerInvariant().GetHashCode();
            //throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }

    public class TableColumnCollection : ICollection<TableColumn>
    {
        #region MemberVariables
        private List<TableColumn> _columnList = new List<TableColumn>();
        private string _errMsg = string.Empty;
        #region Properties


        public string ErrorMsg
        {
            get { return _errMsg; }
            set { _errMsg = value; }
        }

        #endregion



        #endregion

        #region ICollection<TableColumn> Members

        public TableColumn this[int index]
        {
            get { return _columnList[index]; }
        }

        public TableColumn this[string columnName]
        {
            get
            {
                foreach (TableColumn col in _columnList)
                {
                    if (col.DbColumnName.Equals(columnName))
                        return col;
                }
                return null;
            }
        }

        #region Add Item region
        public void Add(TableColumn item)
        {
            _columnList.Add(item);
        }

        public void Add(string dbColumnName, ColumnTypes type, Control control)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control));
        }

        public void Add(string dbColumnName, ColumnTypes type, string dataTableColumn)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, dataTableColumn));
        }
        public void Add(string dbColumnName, ColumnTypes type, DataGridViewTextBoxColumn dataTableColumn)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, dataTableColumn.Name.ToString()));
        }

        public void Add(string dbColumnName, ColumnTypes type, string dataTableColumn, bool isPrimaryKeyColumn)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, dataTableColumn, isPrimaryKeyColumn));
        }

        //use for Sorting TODO:18-Jun-2009
        public void Add(string dbColumnName, ColumnTypes type, string dataTableColumn, bool isPrimaryKeyColumn, bool isSortable)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, dataTableColumn, isPrimaryKeyColumn, isSortable));
        }
        public void Add(string dbColumnName, ColumnTypes type, DataGridViewTextBoxColumn dataTableColumn, bool isPrimaryKeyColumn, bool isSortable)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, dataTableColumn.Name.ToString(), isPrimaryKeyColumn, isSortable));
        }
        //Use FOR SQL _IsCaseStatement
        public void Add(string dbColumnName, ColumnTypes type, string dataTableColumn, bool isPrimaryKeyColumn, bool isSortable, bool IsCaseStatement)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, dataTableColumn, isPrimaryKeyColumn, isSortable, IsCaseStatement));
        }

        //Use for  Case Statement Column Alias
        public void Add(string dbColumnName, ColumnTypes type, string dataTableColumn, bool isPrimaryKeyColumn, bool isSortable, bool IsCaseStatement, string CaseStatementColumnAlias)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, dataTableColumn, isPrimaryKeyColumn, isSortable, IsCaseStatement, CaseStatementColumnAlias));
        }

        public void Add(string dbColumnName, ColumnTypes type, Control control, bool isPrimaryKeyColumn, string sequenceName)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isPrimaryKeyColumn, sequenceName));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbColumnName"></param>
        /// <param name="type"></param>
        /// <param name="control"></param>
        /// <param name="isPrimaryKeyColumn"></param>
        /// <param name="useMaxValue">It will use (MAX value of the ID column + 1) as the new ID.</param>
        public void Add(string dbColumnName, ColumnTypes type, Control control, bool isPrimaryKeyColumn, bool useMaxValue)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isPrimaryKeyColumn, useMaxValue));
        }

        public void Add(string dbColumnName, ColumnTypes type, Control control, Control existingValueDisplayControl)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, existingValueDisplayControl));
        }

        public void Add(string dbColumnName, ColumnTypes type, Control control, string displayFieldName)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, displayFieldName));
        }

        //public void Add(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName)
        //{
        //    _columnList.Add(new TableColumn(dbColumnName, type, control, isCompulsory, displayFieldName));
        //}

        public void Add(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, string customErrorMsg)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isCompulsory, displayFieldName, customErrorMsg));
        }

        public void Add(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, string customErrorMsg, Control existingValueDisplayControl)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isCompulsory, displayFieldName, customErrorMsg, existingValueDisplayControl));
        }

        public void Add(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, Control existingValueDisplayControl)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isCompulsory, displayFieldName, existingValueDisplayControl));
        }

        public void Add(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, bool isUniqueValueColumn, Control existingValueDisplayControl)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isCompulsory, displayFieldName, isUniqueValueColumn, existingValueDisplayControl));
        }

        public void Add(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, string customErrorMsg, bool isUniqueValueColumn, Control existingValueDisplayControl)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isCompulsory, displayFieldName, customErrorMsg, isUniqueValueColumn, existingValueDisplayControl));
        }

        #endregion

        #region "Add New Edit Columns"

        public void AddNewEditColumn(string dbColumnName, ColumnTypes type, object customValue)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, customValue));
        }

        public void AddNewEditColumn(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, string customErrorMsg, bool isUniqueValueColumn, Control existingValueDisplayControl)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isCompulsory, displayFieldName, customErrorMsg, isUniqueValueColumn, existingValueDisplayControl));
        }

        public void AddNewEditColumn(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, bool isUniqueValueColumn, Control existingValueDisplayControl)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isCompulsory, displayFieldName, isUniqueValueColumn, existingValueDisplayControl));
        }

        public void AddNewEditColumn(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, Control existingValueDisplayControl)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isCompulsory, displayFieldName, existingValueDisplayControl));
        }

        public void AddNewEditColumn(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, string customErrorMsg, Control existingValueDisplayControl)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isCompulsory, displayFieldName, customErrorMsg, existingValueDisplayControl));
        }

        public void AddNewEditColumn(string dbColumnName, ColumnTypes type, Control control, bool isCompulsory, string displayFieldName, string customErrorMsg)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isCompulsory, displayFieldName, customErrorMsg));
        }

        public void AddNewEditColumn(string dbColumnName, ColumnTypes type, Control control, Control existingValueDisplayControl)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, existingValueDisplayControl));
        }

        public void AddNewEditColumn(string dbColumnName, ColumnTypes type, Control control, bool isPrimaryKeyColumn, string sequenceName)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isPrimaryKeyColumn, sequenceName));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbColumnName"></param>
        /// <param name="type"></param>
        /// <param name="control"></param>
        /// <param name="isPrimaryKeyColumn"></param>
        /// <param name="useMaxValue">It will use (MAX value of the ID column + 1) as the new ID.</param>
        public void AddNewEditColumn(string dbColumnName, ColumnTypes type, Control control, bool isPrimaryKeyColumn, bool useMaxValue)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, control, isPrimaryKeyColumn, useMaxValue));
        }

        public void AddNewEditColumn(string dbColumnName, ColumnTypes type, Control control)
        {
            Add(dbColumnName, type, control);
        }

        //public void AddNewEditColumn(string dbColumnName, ColumnTypes type, string custom)
        //{
        //    Add(dbColumnName, type, control);
        //}
        #endregion

        #region "Add List Columns"

        public void AddListColumn(string dbColumnName, ColumnTypes type, string dataTableColumn, bool isPrimaryKeyColumn)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, dataTableColumn, isPrimaryKeyColumn));
        }

        //useing String Value Soring 18-jun-2009
        public void AddListColumn(string dbColumnName, ColumnTypes type, string dataTableColumn, bool isPrimaryKeyColumn, bool isSortable)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, dataTableColumn, isPrimaryKeyColumn, isSortable));
        }

        //Use For SQL Case Statement.. _IsCaseStatement
        public void AddListColumn(string dbColumnName, ColumnTypes type, string dataTableColumn, bool isPrimaryKeyColumn, bool isSortable, bool IsCaseStatement)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, dataTableColumn, isPrimaryKeyColumn, isSortable, IsCaseStatement));
        }

        //  Use For SQL Case Statement ColumnAlias
        public void AddListColumn(string dbColumnName, ColumnTypes type, string dataTableColumn, bool isPrimaryKeyColumn, bool isSortable, bool IsCaseStatement, string CaseStatementColumnAlias)
        {
            _columnList.Add(new TableColumn(dbColumnName, type, dataTableColumn, isPrimaryKeyColumn, isSortable, IsCaseStatement, CaseStatementColumnAlias));
        }

        public void AddListColumn(string dbColumnName, ColumnTypes type, string dataTableColumn)
        {
            Add(dbColumnName, type, dataTableColumn);
        }
        #endregion
        //Dhiraj
        /// <summary>
        /// Following columns should exist in Db
        /// UserIDEntry
        /// DT_DataEntry
        /// UserIDEdit
        /// DT_DataEdit
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="FormType"></param>
        public void AddEntryTrack(string userId, FormTypes FormType)
        {

 //UserIDEntry varchar, 
 // DT_DataEntry varchar, 
 // UserIDEdit varchar, 

 // DT_DataEdit varchar 
            //later using linq remove all above entries other wise there will be multiple entries 
            //// _columnList .Remove ( 
            //try {//Remove the cols UserIDEntry  }
            //catch { }
            //remove preadded ones

            removeUnwanted("UserIDEntry");
            removeUnwanted("DT_DataEntry");
            removeUnwanted("UserIDEdit");
            removeUnwanted("DT_DataEdit");
            if (FormType == FormTypes.EntryForm)
            {
                AddNewEditColumn("UserIDEntry", ColumnTypes.String, userId);
                AddNewEditColumn("DT_DataEntry", ColumnTypes.String, DateTime.Now.ToString());
            }
            else if (FormType == FormTypes.EditForm)
            {
                AddNewEditColumn("UserIDEdit", ColumnTypes.String, userId);
                AddNewEditColumn("DT_DataEdit", ColumnTypes.String, DateTime.Now.ToString());
            }
            else if (FormType == FormTypes.ListingForm)
            {
                AddNewEditColumn("UserIDEntry", ColumnTypes.String, "ColUserIDEntry");
                AddNewEditColumn("DT_DataEntry", ColumnTypes.String, "ColDT_DataEntry");
                AddNewEditColumn("UserIDEdit", ColumnTypes.String, "ColUserIDEdit");
                AddNewEditColumn("DT_DataEdit", ColumnTypes.String, "ColDT_DataEdit");
            }
        }


        private void removeUnwanted(string DbColumn)
        {
            var query = from e in _columnList
                        where e.DbColumnName == DbColumn
                        select e;
            TableColumn[] result = query.ToArray<TableColumn>();
            foreach (TableColumn item in result)
            {
                _columnList.Remove(item);
            }
        }

        public void Clear()
        {
            _columnList.Clear();
        }

        public bool Contains(TableColumn item)
        {
            return _columnList.Contains(item);
        }

        public void CopyTo(TableColumn[] array, int arrayIndex)
        {
            _columnList.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _columnList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(TableColumn item)
        {
            return _columnList.Remove(item);
        }

        #endregion

        #region IEnumerable<TableColumn> Members

        IEnumerator<TableColumn> IEnumerable<TableColumn>.GetEnumerator()
        {
            return _columnList.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _columnList.GetEnumerator();
        }

        #endregion

        #region Methods
        /// <summary>
        /// Check for the validity of all the messages and return status.
        /// If false set the error message in the ErrorMsg property.
        /// </summary>
        /// <returns>Returns ture if all fields are valid else false.</returns>
        public bool AreAllFieldsValid()
        {
            foreach (TableColumn col in _columnList)
            {
                if (!col.IsValid())
                {
                    _errMsg = col.ErrMessage;
                    col.Control.Focus();
                    return false;
                }
            }
            return true;
        }
        #endregion

    }
}
