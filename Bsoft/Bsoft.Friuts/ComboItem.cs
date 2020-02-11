using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Friuts
{
    /// <summary>
    /// This represents a single item in a combo box
    /// Combo Item consisting of Key Value Code and keyType
    /// </summary>
    public class ComboItem
    {
        #region Member variables.
        private string _key = string.Empty;
        private string _value = string.Empty;
        private string _code = string.Empty;
        private ColumnTypes _keyType = ColumnTypes.Number;
        #endregion

        #region Constructors & Finalizers.
        /// <summary>
        /// Construtor. 
        /// Default value for keyType is number
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public ComboItem(string key, string value)
        {
            _key = key;
            _value = value;
        }

        public ComboItem(string key, string value, ColumnTypes keyType)
        {
            _key = key;
            _value = value;
            _keyType = keyType;
        }

        public ComboItem(string key, string value, string code, ColumnTypes keyType)
        {
            _key = key;
            _value = value;
            _keyType = keyType;
            _code = code;
        }
        #endregion

        #region Properties

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }


        public ColumnTypes KeyType
        {
            get { return _keyType; }
            set { _keyType = value; }
        }



        #endregion

        #region Methods
        public override string ToString()
        {
            return _value;// base.ToString();
            //return string.Format("[{0}] => {1}", _key, _value);// base.ToString();
        }
        /// <summary>
        /// Returns the key value
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string GetDBValue(ComboItem item)
        {
            if (item == null)
                return "NULL";

            //if (item.Value.Trim().Length == 0
            //    && (item.Key.Trim().Length == 0 || item.Key.Trim().Equals("-9999")))
            if (item.Value.Trim().Length == 0 ||
         item.Key.Trim().Length == 0 || item.Key.Trim().Equals("-9999"))
            {
                return "NULL";
            }

            return TableColumn.GetDBValue(item.KeyType, item.Key);

        }
        /// <summary>
        /// Returns the key value
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string GetDBValue(ComboBox cbo)
        {
            if (cbo == null)
                throw new NullReferenceException("Must pass a valid comboBox.");

            if (cbo.SelectedItem is ComboItem)
            {
                return GetDBValue((ComboItem)cbo.SelectedItem);
            }
            else if (cbo.SelectedItem == null)
            {
                return "NULL";
            }
            else
            {
                throw new InvalidCastException("The items in the combobox must be an object of ComboItem class.");
            }
        }
        #endregion

    }

}
