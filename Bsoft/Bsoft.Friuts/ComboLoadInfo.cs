using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Friuts
{
    /// <summary>
    /// This represents a single Combo box
    /// </summary>
    public class ComboLoadInfo
    {
        #region Member variables.
        public static string AddItemString = "Add";
        private string _keyColumn = string.Empty;
        private string _codeColumn = string.Empty;
        private string _displayColumn = string.Empty;
        private ColumnTypes _keyColumnType = ColumnTypes.Number;
        private string _tableName = string.Empty;
        private ComboBox _comboBox = null;
        private bool _isCompulsory = false;
        private string _condition = string.Empty;
        private Form _thisFormName = null;
        private bool _AddItem;
        //information about the control on which the base control depends on.
        private ComboBox _dependentOnCombo = null;

        public ComboBox DependentOnCombo
        {
            get { return _dependentOnCombo; }
            set { _dependentOnCombo = value; }
        }
        private string _dependentOnColumn = string.Empty;

        public string DependentOnColumn
        {
            get { return _dependentOnColumn; }
            set { _dependentOnColumn = value; }
        }
        #endregion

        #region Constructors & Finalizers.
        public ComboLoadInfo(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory
           , ColumnTypes keyColumnType, ComboBox dependsOnCombo, string dependsOnColumn)
        {
            ValidateDependsOnCombo(dependsOnCombo, dependsOnColumn);

            initialize(keyColumn, displayColumn, string.Empty, tableName, cbo, isCompulsory, keyColumnType, string.Empty, dependsOnCombo, dependsOnColumn);
        }
        public ComboLoadInfo(string keyColumn, string displayColumn, string tableName, ComboBox cbo
           , bool isCompulsory, ColumnTypes keyColumnType, string condition)
        {
            initialize(keyColumn, displayColumn, string.Empty, tableName, cbo, isCompulsory, keyColumnType, condition, null, string.Empty);
        }
        public ComboLoadInfo(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory)
        {
            initialize(keyColumn, displayColumn, string.Empty, tableName, cbo, isCompulsory, ColumnTypes.Number, string.Empty, null, string.Empty);
        }

        public ComboLoadInfo(string keyColumn, string displayColumn, string codeColumn, string tableName, ComboBox cbo, bool isCompulsory
            , ColumnTypes keyColumnType, ComboBox dependsOnCombo, string dependsOnColumn, string condition)
        {
            ValidateDependsOnCombo(dependsOnCombo, dependsOnColumn);
            initialize(keyColumn, displayColumn, codeColumn, tableName, cbo, isCompulsory, keyColumnType, condition, dependsOnCombo, dependsOnColumn);
        }



        private void initialize(string keyColumn, string displayColumn, string codeColumn, string tableName, ComboBox cbo
            , bool isCompulsory, ColumnTypes keyColumnType, string condition, ComboBox dependsOnCombo, string dependsOnColumn)
        {
            _keyColumn = keyColumn;
            _displayColumn = displayColumn;
            _keyColumnType = keyColumnType;
            _tableName = tableName;
            _comboBox = cbo;
            _isCompulsory = isCompulsory;
            _comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _dependentOnCombo = dependsOnCombo;
            _dependentOnColumn = dependsOnColumn;
            _condition = condition;
            _codeColumn = codeColumn;
            //adding combobox properties
            //autocomplete properties.
            try
            {
                _comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                _comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
            catch { }
        }

        private void initialize(string keyColumn, string displayColumn, string codeColumn, string tableName, ComboBox cbo
            , bool isCompulsory, ColumnTypes keyColumnType, string condition, ComboBox dependsOnCombo, string dependsOnColumn, bool AddItem)
        {
            _keyColumn = keyColumn;
            _displayColumn = displayColumn;
            _keyColumnType = keyColumnType;
            _tableName = tableName;
            _comboBox = cbo;
            _isCompulsory = isCompulsory;
            _comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _dependentOnCombo = dependsOnCombo;
            _dependentOnColumn = dependsOnColumn;
            _condition = condition;
            _codeColumn = codeColumn;
            //adding combobox properties
            //autocomplete properties.
            _comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            _comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _AddItem = AddItem;
        }

        private void initialize(string keyColumn, string displayColumn, string codeColumn, string tableName, ComboBox cbo
        , bool isCompulsory, ColumnTypes keyColumnType, string condition, ComboBox dependsOnCombo, string dependsOnColumn, Form Frm)
        {
            _keyColumn = keyColumn;
            _displayColumn = displayColumn;
            _keyColumnType = keyColumnType;
            _tableName = tableName;
            _comboBox = cbo;
            _isCompulsory = isCompulsory;
            _comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _dependentOnCombo = dependsOnCombo;
            _dependentOnColumn = dependsOnColumn;
            _condition = condition;
            _codeColumn = codeColumn;

            thisFormName = Frm; //FORm name assing..

            //adding combobox properties
            //autocomplete properties.
            _comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            _comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }


        #endregion

        #region Nested Enums, Structs, and Classes.
        #endregion

        #region Properties

        public string CodeColumn
        {
            get { return _codeColumn; }
            set { _codeColumn = value; }
        }

        public string KeyColumn
        {
            get { return _keyColumn; }
            set { _keyColumn = value; }
        }

        public string DisplayColumn
        {
            get { return _displayColumn; }
            set { _displayColumn = value; }
        }


        public ColumnTypes KeyColumnType
        {
            get { return _keyColumnType; }
            set { _keyColumnType = value; }
        }


        public ComboBox ComboBox
        {
            get { return _comboBox; }
            set { _comboBox = value; }
        }


        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }


        public bool IsCompulsory
        {
            get { return _isCompulsory; }
            set { _isCompulsory = value; }
        }


        public string Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        public Form thisFormName
        {
            get { return _thisFormName; }
            set { _thisFormName = value; }
        }
        public bool AddItem
        {
            get { return _AddItem; }
            set
            {
                _AddItem = value;
                if (_AddItem)
                {
                    AddSelectChangeEvent();
                }
            }
        }

        #endregion

        #region Methods
        public string KeyColumnForSelect()
        {
            switch (_keyColumnType)
            {
                case ColumnTypes.Number:
                    //return string.Format(" CAST({0} as varchar2(20))", _keyColumn);
                    return string.Format(" CAST({0} as nvarchar(25))", _keyColumn);
                case ColumnTypes.String:
                case ColumnTypes.Guid:
                    return _keyColumn;
                default:
                    throw new Exception("Invalid keyColumn type");
            }
        }

        public delegate void AddNewHandler(Object sender, string message);
        public event AddNewHandler AddNew;

        private void AddSelectChangeEvent()
        {
            _comboBox.SelectedIndexChanged += cmb_SelectedIndexChanged;
        }
        void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the selected item.
            ComboItem itm = (ComboItem)((ComboBox)sender).SelectedItem;

            if (itm != null && itm.Value == AddItemString)
            {
                AddNew(this, itm.Key);
            }
        }
        private bool ValidateDependsOnCombo(ComboBox dependsOnCombo, string dependsOnColumn)
        {
            if (dependsOnCombo == null) //|| dependsOnColumn.Trim().Length == 0)
            {
                throw new NullReferenceException("DependsOnCombo control must be passed.");
            }

            if (dependsOnColumn.Trim().Length == 0)
            {
                throw new Exception("dependsOnColumn control must be passed.");
            }
            _dependentOnCombo = dependsOnCombo;
            //attaching the event handler which will load the data on combobox based on [_dependentOnCombo]
            //_dependentOnCombo.SelectionChangeCommitted += new EventHandler(dependentOnCombo_SelectionChangeCommitted);
            _dependentOnCombo.SelectedIndexChanged += new EventHandler(dependentOnCombo_SelectedIndexChanged);
            return true;
        }

        void dependentOnCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dependentOnCombo_SelectionChangeCommitted(sender, e);
        }

        private string GetAliasedColumn(string tableName, string tableAlias)
        {
            if (tableAlias.Trim().Length > 0)
            {
                if (_dependentOnColumn.IndexOf(".") > -1)
                {
                    return _dependentOnColumn.Replace(tableName, tableAlias);
                }
                else
                {
                    return string.Format("{0}.{1}", tableAlias, _dependentOnColumn);
                }
            }
            return _dependentOnColumn;
        }

        void dependentOnCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //get the selected item.
            ComboItem itm = (ComboItem)_dependentOnCombo.SelectedItem;
            //Form frm =  (Form)_dependentOnCombo.Parent.Parent.Name;
            //if (frm is Form)
            //{
            //}

            if (itm != null)
            {

                string condition = string.Format("{0} = {1}", _dependentOnColumn, ComboItem.GetDBValue(itm));
                if (_condition.Trim().Length > 0)
                    condition += " AND " + _condition;

                if (thisFormName != null)
                {
                    ComboUtilities.LoadData(_keyColumn, _displayColumn, _tableName, _comboBox, _isCompulsory
                    , _keyColumnType, condition, thisFormName);
                }
                else
                {
                    ComboUtilities.LoadData(_keyColumn, _displayColumn, _tableName, _comboBox, _isCompulsory
                        , _keyColumnType, condition);
                }
                //}
            }
        }
        #endregion

    }


}
