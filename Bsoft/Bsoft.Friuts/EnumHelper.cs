using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Friuts
{
    /// <summary>
    /// Different function related to enum
    /// </summary>
    public class EnumHelper
    {
        #region Member variables.
        #endregion

        #region Constructors & Finalizers.
        public EnumHelper()
        {
        }
        #endregion

        #region Nested Enums, Structs, and Classes.
        #endregion

        #region Properties
        #endregion

        #region Methods

        /// <summary>
        /// Loads the content of enum into the string array.
        /// </summary>
        /// <typeparam name="T">The enum which is to be loaded into the comboBox.</typeparam>
        /// <returns>Returns string array which hold all the enum values</returns>
        public static string[]  LoadEnumToStringArray<T>()
        {
            string[] nameList = Enum.GetNames(typeof(T));
            return nameList;
        }

        /// <summary>
        /// Loads the content of enum into the comboBox.Items property
        /// </summary>
        /// <typeparam name="T">The enum which is to be loaded into the comboBox.</typeparam>
        /// <param name="cbo">ComboBox</param>
        /// <param name="addBlank">Adds blank as a default value.</param>
        /// <param name="defaultValue">The default value to be selected in the comobobx.</param>
        public static void LoadEnumToComboBox<T>(ComboBox cbo, bool addBlank, T defaultValue)
        {
            cbo.Items.Clear();

            string[] nameList = Enum.GetNames(typeof(T));

            //cbo.Items.AddRange(nameList);
            if (addBlank)
                cbo.Items.Add(new ComboItem(string.Empty, string.Empty, ColumnTypes.Number));

            foreach (string value in nameList)
            {
                T key = (T)Enum.Parse(typeof(T), value);
                cbo.Items.Add(new ComboItem(Convert.ToInt32(key).ToString(), value, ColumnTypes.Number));
            }

            //set the default value
            if (defaultValue != null)
                cbo.SelectedIndex = cbo.Items.IndexOf(defaultValue.ToString());
        }

        /// <summary>
        /// Loads the content of enum into the comboBox.Items property
        /// </summary>
        /// <typeparam name="T">The enum which is to be loaded into the comboBox.</typeparam>
        /// <param name="cbo">ComboBox</param>
        public static void LoadEnumToComboBox<T>(ComboBox cbo)
        {
            //converting the null value.
            T key = (T)Enum.Parse(typeof(T), null);
            
            LoadEnumToComboBox<T>(cbo, false, key);
        }

        public static T GetNullValue<T>()
        {
            return (T)Enum.Parse(typeof(T), null);
        }

        public static T GetSelectedEnumValue<T>(ComboBox cbo)
        {
            if (cbo.SelectedItem == null)
                return GetNullValue<T>();

            T val;
            ComboItem itm = (ComboItem)cbo.SelectedItem;

            val = (T)Enum.Parse(typeof(T), itm.Value);
            return val;
        }
        #endregion
    }
}
