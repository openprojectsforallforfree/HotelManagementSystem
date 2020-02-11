using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Friuts
{
    /// <summary>
    /// This is simply the list of comboBoxes (For dependent cmbos)
    /// </summary>
    public class ComboLoadInfoList : ICollection<ComboLoadInfo>
    {
        private List<ComboLoadInfo> _list = new List<ComboLoadInfo>();
        #region Add
        public void Add(ComboLoadInfo item)
        {
            _list.Add(item);
        }

        public void Add(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory)
        {
            _list.Add(new ComboLoadInfo(keyColumn, displayColumn, tableName, cbo, isCompulsory));
        }
        public void Add(string keyColumn, string displayColumn, string tableName, ComboBox cbo
            , bool isCompulsory, ColumnTypes keyColumnType, string condition)
        {
            _list.Add(new ComboLoadInfo(keyColumn, displayColumn, tableName, cbo, isCompulsory, keyColumnType, condition));
        }

        public void AddDependent(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory
          , ColumnTypes keyColumnType, ComboBox dependsOnCombo, string dependsOnColumn)
        {
            _list.Add(new ComboLoadInfo(keyColumn, displayColumn, tableName, cbo, isCompulsory, keyColumnType, dependsOnCombo, dependsOnColumn));
        }

         
         
   
        

        //public void Add(string keyColumn, string displayColumn, string tableName, ComboBox cbo, bool isCompulsory
        //    , ColumnTypes keyColumnType, ComboBox dependsOnCombo, string dependsOnColumn, string condition)
        //{
        //    string keyColumn, string displayColumn, string codeColumn, string tableName, ComboBox cbo, bool isCompulsory
        //    , ColumnTypes keyColumnType, ComboBox dependsOnCombo, string dependsOnColumn, string condition)

        //    _list.Add(new ComboLoadInfo(keyColumn, displayColumn, tableName, cbo, isCompulsory, keyColumnType, dependsOnCombo, dependsOnColumn, condition));
        //}

 
        #endregion

        #region ICollection<ComboLoadInfo> Members



        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(ComboLoadInfo item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(ComboLoadInfo[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(ComboLoadInfo item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<ComboLoadInfo> Members

        public IEnumerator<ComboLoadInfo> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        #endregion
    }
}
