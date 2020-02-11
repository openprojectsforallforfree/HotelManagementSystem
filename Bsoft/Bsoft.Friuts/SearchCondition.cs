using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using Bsoft .Controls ;
using Bsoft;
 
using Bsoft.Common;
using CrudeFx.NepaliDate;
namespace Friuts
{
    public enum ComparisionTypes
    { 
        EQUAL = 0,
        GREATER,                             //num & date
        GREATER_AND_EQUAL,     //num & date
        SMALLER,                              //num & date
        SMALLER_AND_EQUAL,      //num & date
        BETWEEN,                             //num & date
        STARTS_WITH,  // string
        ENDS_WITH,      // string
        EXISTS,              // string
        NOT_EQUAL,
        NOT_EXISTS              // string
    }

    public class SearchCondition
    {
        #region Member variables.
        private ColumnTypes _dBColumnType = ColumnTypes.String;
        private Control _valueControl = null;
        private Control _toValueControl = null;
        private ComparisionTypes _comparisionType = ComparisionTypes.STARTS_WITH;
        private string _dbColumnName = string.Empty;
        private bool _isCaseSensetive = true;
        
        private object _value = null;
        //private object _fromValue = null;
        private object _toValue = null;
        #endregion

        #region Constructors & Finalizers.
        public SearchCondition(ColumnTypes dBColumnType, string dbColumnName, ComparisionTypes comparisionType, Control valueControl)
        {
            if (comparisionType == ComparisionTypes.BETWEEN)
                throw new Exception("FromValue and ToValue has to be passed for BETWEEN comparision type");

            Initialize(dBColumnType, dbColumnName, comparisionType, valueControl, null);
        }

        public SearchCondition(ColumnTypes dBColumnType, string dbColumnName, ComparisionTypes comparisionType, Control fromValueControl, Control toValueControl)
        {
            if (comparisionType != ComparisionTypes.BETWEEN)
                throw new Exception("FromValue and ToValue is allowed only for the comparisionType BETWEEN");

            Initialize(dBColumnType, dbColumnName, comparisionType, fromValueControl, toValueControl);
        }

        private void Initialize(ColumnTypes dBColumnType, string dbColumnName, ComparisionTypes comparisionType, Control fromValueControl, Control toValueControl)
        {
            _dBColumnType = dBColumnType;
            _dbColumnName = dbColumnName;            
            _comparisionType = comparisionType;

            _valueControl = fromValueControl;
            _toValueControl = toValueControl;
        }

        public SearchCondition(ColumnTypes dBColumnType, string dbColumnName, ComparisionTypes comparisionType, object value)
        {
            if (comparisionType == ComparisionTypes.BETWEEN)
                throw new Exception("FromValue and ToValue has to be passed for BETWEEN comparision type");

            Initialize(dBColumnType, dbColumnName, comparisionType, value, null);
        }

        public SearchCondition(ColumnTypes dBColumnType, string dbColumnName, ComparisionTypes comparisionType, object fromValue, object toValue)
        {
            if (comparisionType != ComparisionTypes.BETWEEN)
                throw new Exception("FromValue and ToValue is allowed only for the comparisionType BETWEEN");

            Initialize(dBColumnType, dbColumnName, comparisionType, fromValue, toValue);
        }
        private void Initialize(ColumnTypes dBColumnType, string dbColumnName, ComparisionTypes comparisionType, object fromValue, object toValue)
        {
            _dBColumnType = dBColumnType;
            _dbColumnName = dbColumnName;
            _comparisionType = comparisionType;

            _value = fromValue;
            _toValue = toValue;
        }

        #endregion

        #region Nested Enums, Structs, and Classes.
        #endregion

        #region Properties

        public ColumnTypes DBColumnType
        {
            get { return _dBColumnType; }
            set { _dBColumnType = value; }
        }


        public Control ValueControl
        {
            get { return _valueControl; }
            set { _valueControl = value; }
        }


        public ComparisionTypes ComparisionType
        {
            get { return _comparisionType; }
            set { _comparisionType = value; }
        }


        public string DbColumnName
        {
            get { return _dbColumnName; }
            set { _dbColumnName = value; }
        }

        private string GetAliasedColumn(string tableName, string tableAlias)
        {
            return GetAliasedColumn(tableName, tableAlias, false);
        }
        private string GetAliasedColumn(string tableName, string tableAlias, bool forCrystalReport)
        {
            if(tableAlias.Trim().Length > 0
                || forCrystalReport)
            {
                if (_dbColumnName.IndexOf(".") > -1)
                {
                    if (forCrystalReport)
                        return "{" + string.Format("{0}", _dbColumnName) + "}";
                    else
                        return _dbColumnName.Replace(tableName, tableAlias);
                }
                else
                {
                    if(forCrystalReport)
                        return "{" + string.Format("{0}.{1}", tableName, _dbColumnName) + "}";
                    else
                        return string.Format("{0}.{1}", tableAlias, _dbColumnName);
                }
            }
            return _dbColumnName;
        }

        public string GetDBValue(Control ctrl)
        {
            return GetDBValue(ctrl, false);
        }

        public bool SetControlValuesToObject(bool forCrystalReport)
        {
            //Comment as first time Initialize time set the single quote.. problme
            //check by Dhiraj
            if (_valueControl != null)
                _value = TableColumn.GetValue(_valueControl);
                //_value = GetDBValue(_valueControl, forCrystalReport);
                //_value = _valueControl.Text.Trim();

            if (_toValueControl != null)
                _toValue = TableColumn.GetValue(_toValueControl);
                //_toValue = GetDBValue(_toValueControl, forCrystalReport);
                //_toValue = _toValueControl.Text.Trim();
            return true;
        }

        public string GetDBValue(object value)
        {
            return GetDBValue(value, false);
        }
        
        public string GetDBValue(object value, bool forCrystalReport)
        {
            return TableColumn.GetDBValue(_dBColumnType, value, forCrystalReport);
        }

        public string GetDBValue(Control ctrl, bool forCrystalReport)
        {
            string val = string.Empty;
            if (ctrl is VtextBox)
            {
                val = TableColumn.GetDBValue(_dBColumnType, ((VtextBox)ctrl).Value);
            }
            else if (ctrl is TextBox || ctrl is Label || ctrl is Bsoft .Controls .lblTextBox)
            {
                if (ctrl.Text.Trim().Length > 0)
                {
                    val = TableColumn.GetDBValue(_dBColumnType, _isCaseSensetive ? ctrl.Text.Trim() : ctrl.Text.Trim().ToLower());
                }
            }

            
            else if (ctrl is ComboBox)
            {
                val = ComboItem.GetDBValue((ComboBox)ctrl);
            }
            else if (ctrl is Bsoft .Controls .lblComboBox )
            {
                val = ComboItem.GetDBValue(((Bsoft.Controls.lblComboBox)ctrl).cmbBox );
            }
          
            else if (ctrl is NepaliDatePicker)
            {
                val = TableColumn.GetDBValue(_dBColumnType, ctrl.Text);
            }
            else if (ctrl is DateTimePicker)
            {
                val = TableColumn.GetDBValue(_dBColumnType, ctrl.Text, forCrystalReport);
            }


            if (val == null || val.ToUpper().Equals("NULL"))
                val = string.Empty;

            return val;
        }

        private string GetColumnName()
        {
            int indx = _dbColumnName.IndexOf(".");
            if ( indx > -1)
            {
                return _dbColumnName.Substring(indx, _dbColumnName.Length - (indx + 1));
            }
            else
                return _dbColumnName;
        }

        public string GetSearchCondition(string tableName, string tableAlias)
        {
            return GetSearchCondition(tableName, tableAlias, false);
        }

        public string GetSearchCondition(string tableName, string tableAlias, bool forCrystalReport)
        {
            //if (_valueControl == null)
            //    return string.Empty; 

            if (_value == null && _valueControl == null)  
                return string.Empty;
            
            string tmpValue = string.Empty;

            SetControlValuesToObject(forCrystalReport);
            if (_comparisionType == ComparisionTypes.BETWEEN)
            {
                //old metod copy and past in tppims searchcondion
                //if (GetDBValue(_valueControl).Trim().Length == 0 ||
                //    GetDBValue(_toValueControl).Trim().Length == 0)
                //    return string.Empty;
                if (GetDBValue(_value).Trim().Length == 0 || 
                        GetDBValue(_toValue).Trim().Length == 0)
                    return string.Empty;
            }
            else
            {
                //if (GetDBValue(_valueControl).Trim().Length == 0)
                //    return string.Empty;
                if (_value == null)
                {
                    return string.Empty;
                }
                 if (GetDBValue(_value).Trim().Length == 0 )
                     return string.Empty;
            }

            //if (_dBColumnType == ColumnTypes.Number //27-Jun- 2009 comment below line changed..
            //    && GetDBValue(_valueControl).Trim().Length==0)
            //{
            //    return string.Empty;
            //}
            if (_dBColumnType == ColumnTypes.Number
                    && GetDBValue(_value).Trim().Length == 0)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            //add column
            switch(_dBColumnType)
            {
                case ColumnTypes.String:
                case ColumnTypes.Guid :
                    if (_isCaseSensetive)
                    {
                        sb.Append(GetAliasedColumn(tableName, tableAlias, forCrystalReport));
                    }
                    else
                        sb.AppendFormat("Lower({0})", GetAliasedColumn(tableName, tableAlias, forCrystalReport));

                    //add operator and operand.
                    switch (_comparisionType)
                    {                        
                        case ComparisionTypes.STARTS_WITH:
                            //sb.AppendFormat(" LIKE '{0}%' ", GetDBValue(_valueControl, forCrystalReport).Replace("'", string.Empty));
                            ////sb.AppendFormat(" LIKE '{0}%' ", GetDBValue(_value, forCrystalReport).Replace("'", string.Empty));
                            sb.AppendFormat(" LIKE '{0}%'", TableColumn.GetDisplayValue(_dBColumnType, _value).Replace("'","''"));

                            break;
                        case ComparisionTypes.ENDS_WITH:
                            //sb.AppendFormat(" LIKE '%{0}' ", GetDBValue(_valueControl, forCrystalReport).Replace("'", string.Empty));
                            ///sb.AppendFormat(" LIKE '%{0}' ", GetDBValue(_value, forCrystalReport).Replace("'", string.Empty));
                           
                            sb.AppendFormat(" LIKE '%{0}'", TableColumn.GetDisplayValue(_dBColumnType, _value).Replace("'", "''"));
                            break;
                        case ComparisionTypes.EXISTS:
                            //sb.AppendFormat(" LIKE '%{0}%' ", GetDBValue(_valueControl, forCrystalReport).Replace("'", string.Empty));
                            ////sb.AppendFormat(" LIKE '%{0}%' ", GetDBValue(_value, forCrystalReport).Replace("'", string.Empty));
                   
                            sb.AppendFormat(" LIKE '%{0}%' ", TableColumn.GetDisplayValue(_dBColumnType, _value).Replace("'", "''"));
                            break;
                        case ComparisionTypes.NOT_EXISTS:
                            //sb.AppendFormat(" NOT LIKE '%{0}%' ", GetDBValue(_valueControl, forCrystalReport).Replace("'", string.Empty));
                            //sb.AppendFormat(" NOT LIKE '%{0}%' ", GetDBValue(_value, forCrystalReport).Replace("'", string.Empty));
                 
                            sb.AppendFormat(" NOT LIKE '%{0}%' ", TableColumn.GetDisplayValue(_dBColumnType, _value).Replace("'", "''"));
                            break;
                        case ComparisionTypes.EQUAL:
                        case ComparisionTypes.NOT_EQUAL:
                            //sb.AppendFormat(" {0} {1} ", GetOperator(_comparisionType), GetDBValue(_valueControl, forCrystalReport));
                            sb.AppendFormat(" {0} {1} ", GetOperator(_comparisionType), GetDBValue(_value, forCrystalReport));
                            break;
                        default:
                            throw new Exception(string.Format("ComparisionType [{0}] not supported by the ColumnTypes [{1}]"
                                , _comparisionType.ToString(), _dBColumnType.ToString()));
                            //break;
                    }
                    break;
                case ColumnTypes.NepaliDate:                
                case ColumnTypes.Number:
                case ColumnTypes.Integer :
                case ColumnTypes.EnglishDate:
                case ColumnTypes.EnglishDateTime:
                    if (_dBColumnType == ColumnTypes.EnglishDate)
                    {
                        sb.AppendFormat(" TRUNC{0}", GetAliasedColumn(tableName, tableAlias, forCrystalReport));                        
                    }
                    else
                    {
                        sb.Append(GetAliasedColumn(tableName, tableAlias, forCrystalReport));
                    }
                    
                    //add operator and operand.
                    switch (_comparisionType)
                    {
                        case ComparisionTypes.BETWEEN:
                            //tmpValue = GetDBValue(_valueControl, forCrystalReport);
                            tmpValue = GetDBValue(_value, forCrystalReport);
                            if(forCrystalReport)
                            {
                                //tmpValue = string.Format("
                            }
                            //sb.AppendFormat(" BETWEEN {0} AND {1} ", GetDBValue(_valueControl, forCrystalReport), GetDBValue(_toValueControl, forCrystalReport));
                            sb.AppendFormat(" BETWEEN {0} AND {1} ", GetDBValue(_value, forCrystalReport), GetDBValue(_toValue, forCrystalReport));
                            break;
                        case ComparisionTypes.STARTS_WITH:
                        case ComparisionTypes.ENDS_WITH:
                        case ComparisionTypes.EXISTS:
                        case ComparisionTypes.NOT_EXISTS:
                            throw new Exception(string.Format("ComparisionType [{0}] not supported by the ColumnTypes [{1}]"
                                , _comparisionType.ToString(), _dBColumnType.ToString()));
                        default:
                            //sb.AppendFormat(" {0} {1} ", GetOperator(_comparisionType), GetDBValue(_valueControl, forCrystalReport));
                            sb.AppendFormat(" {0} {1} ", GetOperator(_comparisionType), GetDBValue(_value, forCrystalReport));
                            break;
                    }
                    break;
                case ColumnTypes.Boolean:
                    sb.Append(GetAliasedColumn(tableName, tableAlias, forCrystalReport));
                    //add operator and operand.
                    switch (_comparisionType)
                    {                       
                        case ComparisionTypes.EQUAL:
                        case ComparisionTypes.NOT_EQUAL:
                            //sb.AppendFormat(" {0} {1} ", GetOperator(_comparisionType), GetDBValue(_valueControl, forCrystalReport));
                            sb.AppendFormat(" {0} {1} ", GetOperator(_comparisionType), GetDBValue(_value, forCrystalReport));
                            break;
                        default:
                            throw new Exception(string.Format("ComparisionType [{0}] not supported by the ColumnTypes [{1}]"
                                , _comparisionType.ToString(), _dBColumnType.ToString()));
                    }
                    break;
            }

            return sb.ToString();
        }

        private string GetOperator(ComparisionTypes type)
        {
            string op = string.Empty;
            switch (type)
            { 
                case ComparisionTypes.EQUAL:
                    op = "=";
                    break;
                case ComparisionTypes.GREATER:
                    op = ">";
                    break;
                case ComparisionTypes.GREATER_AND_EQUAL:
                    op = ">=";
                    break;
                case ComparisionTypes.NOT_EQUAL:
                    op = "!=";
                    break;
                case ComparisionTypes.SMALLER:
                    op = "<";
                    break;
                case ComparisionTypes.SMALLER_AND_EQUAL:
                    op = "<=";
                    break;
                default:
                    throw new Exception(string.Format("Operator can't be generated for the ComparisionTypes =>{0}", type.ToString()));
            }
            return op;
        }

        public object Value
        {
            get { return null; }
            //set { _value = value; }
        }


        public object FromValue
        {
            get { return null; }
            //set { _fromValue = value; }
        }


        public object ToValue
        {
            get { return null; }
            //set { _toValue = value; }
        }

        #endregion

        #region Methods
        //public string GetSearchCriteria()
        //{
            
        //}
        #endregion
    }

    public class SearchConditionCollection : ICollection<SearchCondition>
    {
        #region Member variables.
        private List<SearchCondition> _conditionList = new List<SearchCondition>();
        private ComparisionTypes _defaultComparisionType = ComparisionTypes.EQUAL;
        private Hashtable _tableAliasHash = null;
        private string _defaultMasterTable = string.Empty;

        #endregion

        #region Constructors & Finalizers.
        #endregion

        #region Nested Enums, Structs, and Classes.
        #endregion

        #region Properties

        public Hashtable TableAliasHash
        {
            get { return _tableAliasHash; }
            set { _tableAliasHash = value; }
        }


        public ComparisionTypes DefaultComparisionType
        {
            get { return _defaultComparisionType; }
            set { _defaultComparisionType = value; }
        }


        public List<SearchCondition> ConditionList
        {
            get { return _conditionList; }
            set { _conditionList = value; }
        }


        public string DefaultMasterTable
        {
            get { return _defaultMasterTable; }
            set { _defaultMasterTable = value; }
        }

        #endregion

        #region Methods

        public void AddCriteria(ColumnTypes dBColumnType, string dbColumnName, Control valueControl)
        {
            _conditionList.Add(new SearchCondition(dBColumnType, dbColumnName, _defaultComparisionType, valueControl));
        }

        /// <summary>
        /// Adds a search criteria into the criteria list. This funtion wil allow non-between comparision types only..
        /// </summary>
        /// <param name="dBColumnType">DB column type.</param>
        /// <param name="dbColumnName">DB column name in which searching will be done.</param>
        /// <param name="comparisionType">Comparision type.</param>
        /// <param name="valueControl"></param>
        public void AddCriteria(ColumnTypes dBColumnType, string dbColumnName, ComparisionTypes comparisionType, Control valueControl)
        {
            _conditionList.Add(new SearchCondition(dBColumnType, dbColumnName, comparisionType, valueControl));
        }

        public void AddCriteria(ColumnTypes dBColumnType, string dbColumnName, ComparisionTypes comparisionType, Control fromValueControl, Control toValueControl)
        {
            _conditionList.Add(new SearchCondition(dBColumnType, dbColumnName, comparisionType, fromValueControl, toValueControl));
        }

        public void AddBetweenCriteria(ColumnTypes dBColumnType, string dbColumnName, Control fromValueControl, Control toValueControl)
        {
            _conditionList.Add(new SearchCondition(dBColumnType, dbColumnName, ComparisionTypes.BETWEEN, fromValueControl, toValueControl));
        }

        public void AddCriteria(ColumnTypes dBColumnType, string dbColumnName, object value)
        {
            _conditionList.Add(new SearchCondition(dBColumnType, dbColumnName, _defaultComparisionType, value));
        }

        /// <summary>
        /// Adds a search criteria into the criteria list. This funtion wil allow non-between comparision types only..
        /// </summary>
        /// <param name="dBColumnType">DB column type.</param>
        /// <param name="dbColumnName">DB column name in which searching will be done.</param>
        /// <param name="comparisionType">Comparision type.</param>
        /// <param name="valueControl"></param>
        public void AddCriteria(ColumnTypes dBColumnType, string dbColumnName, ComparisionTypes comparisionType, object value)
        {
            _conditionList.Add(new SearchCondition(dBColumnType, dbColumnName, comparisionType, value));
        }

        public void AddCriteria(ColumnTypes dBColumnType, string dbColumnName, ComparisionTypes comparisionType, object fromValue, object toValue)
        {
            _conditionList.Add(new SearchCondition(dBColumnType, dbColumnName, comparisionType, fromValue, toValue));
        }

        public void AddBetweenCriteria(ColumnTypes dBColumnType, string dbColumnName, Control fromValue, object toValue)
        {
            _conditionList.Add(new SearchCondition(dBColumnType, dbColumnName, ComparisionTypes.BETWEEN, fromValue, toValue));
        }
        public void AddBetweenCriteria(ColumnTypes dBColumnType, string dbColumnName, object fromValue, object toValue)
        {
            _conditionList.Add(new SearchCondition(dBColumnType, dbColumnName, ComparisionTypes.BETWEEN, fromValue, toValue));
        }
        public string GetSearchCriteria()
        {
            return GetSearchCriteria(false);
        }
        public string GetSearchCriteria(bool forCrystalReport)
        {
            StringBuilder sb = new StringBuilder();
            string tableName = string.Empty;
            string searchCondition = string.Empty;            
            foreach (SearchCondition condition in _conditionList)
            {
                tableName = GetTableName(condition.DbColumnName);
                searchCondition = condition.GetSearchCondition(tableName, GetTableAlias(tableName), forCrystalReport);

                if (searchCondition.Trim().Length > 0)
                {
                    sb.AppendFormat("\n\t{0} AND", searchCondition);                    
                }
            }

            if (sb.Length > 4)
            {
                sb.Remove(sb.Length - 4, 4); // length of " AND" = 4.
            }
            return sb.ToString();
        }        

        /// <summary>
        /// Returns the tableAlias to be used in the SELECT query.
        /// </summary>
        /// <param name="dbColumnNameExpress">dbColumnNameExpress with column name and table name. eg. employees.employee_id</param>
        /// <returns>Returns the the table alias.</returns>
        private string GetTableName(string dbColumnNameExpress)
        {
            if (_tableAliasHash.Count == 0)
                return string.Empty;

            string tableName = string.Empty;
            if (dbColumnNameExpress.Contains("."))
            {
                string[] arr = dbColumnNameExpress.Split(new char[] { '.' });
                tableName = arr[0].Trim();
            }

            if (tableName.Trim().Length == 0)
                tableName = _defaultMasterTable;
            return tableName;
        }
        
        /// <summary>
        /// Returns the tableAlias to be used in the SELECT query.
        /// </summary>
        /// <param name="tableName">Table name</param>
        /// <returns>Returns the the table alias.</returns>
        public string GetTableAlias(string tableName)
        {
            if (_tableAliasHash.Count <= 1)
                return string.Empty;

            tableName = tableName.Trim();
            if (tableName.Length == 0)
                return string.Empty;


            ////if the tableName does not exists in the alias list then push the tableName in the alias list and then return the table Alias.
            //if (!_tableAliasHash.ContainsKey(tableName))
            //{
            //    //push the tableName in the alias list and set alias in the format of (t1, t2,...tn where n is the table number)
            //    _tableAliasHash.Add(tableName, "t" + (_tableAliasHash.Count + 1));
            //}

            return _tableAliasHash[tableName].ToString();
        }

        #endregion

        #region ICollection<SearchCondition> Members

        public void Add(SearchCondition item)
        {
            _conditionList.Add(item);
        }

        public void Clear()
        {
            _conditionList.Clear();
        }

        public bool Contains(SearchCondition item)
        {
            return _conditionList.Contains(item);
        }

        public void CopyTo(SearchCondition[] array, int arrayIndex)
        {
            _conditionList.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _conditionList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(SearchCondition item)
        {
            return _conditionList.Remove(item);
        }

        #endregion

        #region IEnumerable<SearchCondition> Members

        public IEnumerator<SearchCondition> GetEnumerator()
        {
            return _conditionList.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _conditionList.GetEnumerator();
        }

        #endregion
    }
}
