using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Friuts
{
    /// <summary>
    /// Holds the common function that are used to work with comboBoxe
    /// </summary>
    public static class ComboUtilities
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static ComboItem SelectComboBoxItemUsingValue(ComboBox cbo, string value)
        {
            ComboItem itm = null;
            foreach (object obj in cbo.Items)
            {
                itm = (ComboItem)obj;
                if (itm.Value.ToString().Trim().Equals(value.Trim()))
                {
                    cbo.SelectedItem = itm;
                    return itm;
                }
            }
            //MsgBoxNepali.Show(fruitFx.Messeges.INVALID_CODE_MSG, MessageBoxButtons.OK);
            // MessageBox.Show(fruitFx.Messeges.INVALID_CODE_MSG,"Message");//, MessageBoxButtons.OK); 
            return null;
        }

        public static void SelectComboBoxItemUsingValue(ComboBox cbo, string value,bool useComboItem)
        {
            if (useComboItem)
            {
                ComboItem itm = null;
                foreach (object obj in cbo.Items)
                {
                    itm = (ComboItem)obj;
                    if (itm.Value.ToString().Trim().Equals(value.Trim()))
                    {
                        cbo.SelectedItem = itm;
                    }
                }
            }
            else
            {
                foreach (object obj in cbo.Items )
                {
                    if (obj.ToString().Trim().Equals(value.Trim()))
                    {
                        cbo.SelectedItem = obj;
                    }
                }
            }
             
        }

        /// <summary>
        /// Select item using key
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static ComboItem SelectComboBoxItemUsingKey(ComboBox cbo, string key)
        {
            ComboItem itm = null;
            foreach (object obj in cbo.Items)
            {
                itm = (ComboItem)obj;
                if (itm.Key.Equals(key.Trim()))
                {
                    cbo.SelectedItem = itm;
                    return itm;
                }
            }
            //MsgBoxNepali.Show(fruitFx.Messeges.INVALID_CODE_MSG, MessageBoxButtons.OK);
           //  MessageBox.Show(fruitFx.Messeges.INVALID_CODE_MSG,"Message");//, MessageBoxButtons.OK); 
            return null;
        }
        /// <summary>
        /// Select item using code
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static ComboItem SelectComboBoxItemUsingCode(ComboBox cbo, string code)
        {
            if (cbo.Items == null || cbo.Items.Count == 0)
                return null;

            ComboItem itm = null;
            foreach (object obj in cbo.Items)
            {
                itm = (ComboItem)obj;
                if (itm.Code.Equals(code.Trim()))
                {
                    cbo.SelectedItem = itm;
                    return itm;
                }
            }

            // MsgBoxNepali.Show(fruitFx.Messeges.INVALID_CODE_MSG, MessageBoxButtons.OK);
          //  MessageBox.Show(Friuts.Messeges.INVALID_CODE_MSG, "Message");//, MessageBoxButtons.OK); 
            return null;
        }

        public static ComboItem SelectComboBoxItemUsingIndex(ComboBox cbo, int Index)
        {
            try {
                cbo.SelectedItem = cbo.Items[Index];
            }
            catch { }
            return (ComboItem) cbo.SelectedItem;
        }
        #region Static functions

        /// <summary>
        /// Uses SQL QUERRY FOR LOADING DATA
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="Query">eg SELECT id as key ,TITLE as value FROM Course </param>
        /// <param name="iscompulsary"></param>
        /// <returns></returns>
        public static bool LoadData(ComboBox cbo, string Query, bool iscompulsary)
        {
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("vv", "kk", "tt", cbo, iscompulsary);
            return loader.LoadData(Query.ToString());
        }
        public static bool LoadData(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory, string condition)
        {
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add(keyColumn, displayColumn, tableName, cbo, isCompulsory,ColumnTypes .String,condition);
            return loader.LoadData();
        }
        public static bool LoadData(ComboBox cbo, string Query, bool iscompulsary, Form frm)
        {
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.FormName = frm;
            loader.ComboLoadinfoItems.Add("vv", "kk", "tt", cbo, iscompulsary);
            return loader.LoadData(Query.ToString());
        }
        public static bool LoadData(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory
           , ColumnTypes keyColumnType, string condition)
        {
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add(keyColumn, displayColumn, tableName, cbo, isCompulsory, keyColumnType, condition);
            return loader.LoadData();
        }
        
        /// <summary>
        /// Single combo box
        /// </summary>
        /// <param name="keyColumn">Key</param>
        /// <param name="displayColumn">Display col</param>
        /// <param name="tableName">table Name</param>
        /// <param name="cbo">combo</param>
        /// <param name="isCompulsory">true false </isCompulsory>
        /// <returns></returns>
        //public static bool LoadData(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory)
        //{
        //    return LoadData(keyColumn, displayColumn, tableName, cbo, isCompulsory, string.Empty);
        //}

        /// <summary>
        /// Single combo box with Condition
        /// </summary>
        /// <param name="keyColumn">Key</param>
        /// <param name="displayColumn">Display col</param>
        /// <param name="tableName">table Name</param>
        /// <param name="cbo">combo</param>
        /// <param name="isCompulsory">true false </isCompulsory>
        /// <param name="condition">The part atfter where in a SQL</param>
        /// <returns></returns>
        //public static bool LoadData(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory, string condition)
        //{
        //    ComboBoxDataLoader loader = new ComboBoxDataLoader();
        //    loader.ComboLoadinfoItems.Add(keyColumn, displayColumn, tableName, cbo, isCompulsory, condition);
        //    return loader.LoadData();
        //}

        /// <summary>
        /// Single combo box with Condition and resizes the combo 
        /// </summary>
        /// <param name="keyColumn">Key</param>
        /// <param name="displayColumn">Display col</param>
        /// <param name="tableName">table Name</param>
        /// <param name="cbo">combo</param>
        /// <param name="isCompulsory">true false </isCompulsory>
        /// <param name="condition">The part atfter where in a SQL</param>
        /// <param name="frm">The form </frm>
        /// <returns></returns>
        //public static bool LoadData(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory, string condition, Form frm)
        //{
        //    ComboBoxDataLoader loader = new ComboBoxDataLoader();
        //    loader.ComboLoadinfoItems.Add(keyColumn, displayColumn, tableName, cbo, isCompulsory, condition);
        //    loader.FormName = frm;
        //    return loader.LoadData();
        //}

        ///loads data in a single combobox.
        //public static bool LoadData(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory
        //    , ColumnTypes keyColumnType)
        //{
        //    return LoadData(keyColumn, displayColumn, tableName, cbo, isCompulsory, keyColumnType, string.Empty);
        //}

        ///loads data in a single combobox.
        //public static bool LoadData(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory
        //    , ColumnTypes keyColumnType, string condition)
        //{
        //    ComboBoxDataLoader loader = new ComboBoxDataLoader();
        //    loader.ComboLoadinfoItems.Add(keyColumn, displayColumn, tableName, cbo, isCompulsory, keyColumnType, condition);
        //    return loader.LoadData();
        //}

        //and must pass the forms name list
        public static bool LoadData(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory
        , ColumnTypes keyColumnType, string condition, Form Frm)
        {
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add(keyColumn, displayColumn, tableName, cbo, isCompulsory, keyColumnType, condition);
            loader.FormName = Frm;
            return loader.LoadData();
        }


        //with codeColumn
        //public static bool LoadDatacodeColumn(string keyColumn, string displayColumn, string codeColumn, string tableName, ComboBox cbo)
        //{
        //    return LoadDatacodeColumn(keyColumn, displayColumn, codeColumn, tableName, cbo, string.Empty);
        //}

        //public static bool LoadDatacodeColumn(string keyColumn, string displayColumn, string codeColumn, string tableName, ComboBox cbo, string condition)
        //{
        //    ComboBoxDataLoader loader = new ComboBoxDataLoader();
        //    loader.ComboLoadinfoItems.AddCodeColumn(keyColumn, displayColumn, codeColumn, tableName, cbo, condition);
        //    return loader.LoadData();
        //}

        /// <summary>
        /// Must Pass the Forms compulsory required for combo box auto text resize..
        /// </summary>
        /// <param name="keyColumn"></param>
        /// <param name="displayColumn"></param>
        /// <param name="codeColumn"></param>
        /// <param name="tableName"></param>
        /// <param name="cbo"></param>
        /// <param name="condition"></param>
        /// <param name="frm"></param>
        /// <returns></returns>
        ///loads data in a single combobox.
        //public static bool LoadDatacodeColumn(string keyColumn, string displayColumn, string codeColumn, string tableName, ComboBox cbo, string condition, Form frm)
        //{
        //    ComboBoxDataLoader loader = new ComboBoxDataLoader();
        //    loader.ComboLoadinfoItems.AddCodeColumn(keyColumn, displayColumn, codeColumn, tableName, cbo, condition);
        //    loader.FormName = frm;
        //    return loader.LoadData();
        //}

        //public static bool LoadDatacodeColumn(string keyColumn, string displayColumn, string codeColumn, string tableName, ComboBox cbo, bool isCompulsory)
        //{
        //    return LoadDatacodeColumn(keyColumn, displayColumn, codeColumn, tableName, cbo, isCompulsory, string.Empty);
        //}


       
        //public static bool LoadDatacodeColumn(string keyColumn, string displayColumn, string codeColumn, string tableName, ComboBox cbo, bool isCompulsory
        //    , ColumnTypes keyColumnType)
        //{
        //    return LoadDatacodeColumn(keyColumn, displayColumn, codeColumn, tableName, cbo, isCompulsory, keyColumnType, string.Empty);
        //}

        //public static bool LoadDatacodeColumn(string keyColumn, string displayColumn, string codeColumn, string tableName, ComboBox cbo, bool isCompulsory, string condition)
        //{
        //    ComboBoxDataLoader loader = new ComboBoxDataLoader();
        //    loader.ComboLoadinfoItems.AddCodeColumn(keyColumn, displayColumn, codeColumn, tableName, cbo, isCompulsory, condition);
        //    return loader.LoadData();
        //}

        //public static bool LoadDatacodeColumn(string keyColumn, string displayColumn, string codeColumn, string tableName, ComboBox cbo, bool isCompulsory
        //    , ColumnTypes keyColumnType, string condition)
        //{
        //    ComboBoxDataLoader loader = new ComboBoxDataLoader();
        //    loader.ComboLoadinfoItems.AddCodeColumn(keyColumn, displayColumn, codeColumn, tableName, cbo, isCompulsory, keyColumnType, condition);
        //    return loader.LoadData();
        //}

        //public static bool LoadDatacodeColumn(string keyColumn, string displayColumn, string codeColumn, string tableName, ComboBox cbo, bool isCompulsory
        //, ColumnTypes keyColumnType, string condition, Form frm)
        //{
        //    ComboBoxDataLoader loader = new ComboBoxDataLoader();
        //    loader.ComboLoadinfoItems.AddCodeColumn(keyColumn, displayColumn, codeColumn, tableName, cbo, isCompulsory, keyColumnType, condition);
        //    loader.FormName = frm;
        //    return loader.LoadData();
        //}
        #endregion

        public static bool LoadDataWithAdd(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory)
        {
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add (keyColumn, displayColumn, tableName, cbo, isCompulsory);
            return loader.LoadData();
        }

    }
}
