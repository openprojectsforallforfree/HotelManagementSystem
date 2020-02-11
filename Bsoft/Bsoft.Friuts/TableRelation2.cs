using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace tempFriuts
{
   

    public class TableRelation2
    {
        #region Member variables.
        private string _masterTableName = string.Empty;
        private string _foreignKeyColumn = string.Empty;
        private string _referenceTableName = string.Empty;
        private string _referenceColumn = string.Empty;
        private string _displayColumn = string.Empty;
        private string _displayColumnAlias = string.Empty;
        private string _gridColumn = string.Empty;
        private  bool _isInnerJoin = false;
        #endregion

        #region Constructors & Finalizers.
        public TableRelation2(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
            , string displayColumn, string gridColumn)
        {
            Initialize(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, displayColumn, gridColumn, false);
        }

        public TableRelation2(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
            , string expression, string displayColumnAlias, string gridColumn)
        {
            Initialize(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, expression, displayColumnAlias, gridColumn, false);
        }

        public TableRelation2(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
            , string displayColumn, string gridColumn, bool isInnerJoin)
        {
            Initialize(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, displayColumn, gridColumn, isInnerJoin);
        }

        public TableRelation2(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
             , string expression, string displayColumnAlias, string gridColumn, bool isInnerJoin)
        {
            Initialize(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, expression, displayColumnAlias, gridColumn, isInnerJoin);
        }

        private void Initialize(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
            , string displayColumn, string gridColumn, bool isInnerJoin)
        {
            string alias = string.Empty;
            //check for "as" keyword which is used for separataing the column and alias.

            //checking for cases like . t2.first_name || ' ' || t2.last_name as employeeName
            int startIndex = displayColumn.ToLower().IndexOf(" as ");
            if (startIndex > -1)
            {
                alias = displayColumn.Substring(startIndex + 4 + 1); //length(" as ") = 4.
                displayColumn =displayColumn.Substring(0, startIndex);
            }

            if (alias.Length == 0)
            {
                //checking for cases like  t2.first_name || ' ' || t2.last_name employeeName
                startIndex = displayColumn.LastIndexOf(" ");
                if (startIndex > -1)
                {
                    alias = displayColumn.Substring(startIndex + 1);
                    displayColumn = displayColumn.Substring(0, startIndex);
                }
            }

            if (alias.Length == 0)
            {
                //checking for cases like t2.first_name.
                startIndex = displayColumn.IndexOf(".");
                if (startIndex > -1)
                {
                    alias = displayColumn.Substring(startIndex + 1);
                    displayColumn = displayColumn.Substring(0, startIndex);
                }
            }
            //alias = displayColumn.Substring(1

            Initialize(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, displayColumn, alias, gridColumn, isInnerJoin);
        }
        
        private void Initialize(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
            , string expression, string displayColumnAlias, string gridColumn, bool isInnerJoin)
        {
            _masterTableName = masterTableName;
            _foreignKeyColumn = foreignKeyColumn;
            _referenceTableName = referenceTableName;
            _referenceColumn = referenceColumn;
            _displayColumn = expression;
            _gridColumn = gridColumn;
            _isInnerJoin = isInnerJoin;
            _displayColumnAlias = displayColumnAlias;
        }

        #region "IDisposable Implementation"
        private bool isAppClosing = false;
        // Pointer to an external unmanaged resource.
        private IntPtr handle;
        // Track whether Dispose has been called.
        private bool disposed = false;
        // Use interop to call the method necessary
        // to clean up the unmanaged resource.
        [System.Runtime.InteropServices.DllImport("Kernel32")]
        private extern static Boolean CloseHandle(IntPtr handle);

        private void AddAppExitHandler()
        {
            System.Windows.Forms.Application.ApplicationExit += OnApplicationExit;
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            this.isAppClosing = true;
        }

        public bool IsApplicationClosing
        {
            get { return this.isAppClosing; }
        }

        // Implement IDisposable.
        // Do not make this method virtual.
        // A derived class should not be able to override this method.
        public void Dispose()
        {
            this.Dispose(true);
            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SupressFinalize to
            // take this object off the finalization queue
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        // Dispose(bool disposing) executes in two distinct scenarios.
        // If disposing equals true, the method has been called directly
        // or indirectly by a user's code. Managed and unmanaged resources
        // can be disposed.
        // If disposing equals false, the method has been called by the
        // runtime from inside the finalizer and you should not reference
        // other objects. Only unmanaged resources can be disposed.
        private void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this.disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {
                    // Dispose managed resources.
                    //if ((this._connection != null))
                    //{
                    //    this._connection.Dispose();
                    //}
                }

                // Call the appropriate methods to clean up
                // unmanaged resources here.
                // If disposing is false,
                // only the following code is executed.
                CloseHandle(handle);
                handle = IntPtr.Zero;
            }
            disposed = true;

        }

        // This finalizer will run only if the Dispose method
        // does not get called.
        // It gives your base class the opportunity to finalize.
        // Do not provide finalize methods in types derived from this class.
        ~TableRelation2()
        {
            // Do not re-create Dispose clean-up code here.
            // Calling Dispose(false) is optimal in terms of
            // readability and maintainability.
            this.Dispose(true);

            GC.SuppressFinalize(this);
        }

        #endregion
        #endregion

        #region Nested Enums, Structs, and Classes.
        #endregion

        #region Properties

        public string MasterTableName
        {
            get { return _masterTableName; }
            set { _masterTableName = value; }
        }


        public string ForeignKeyColumn
        {
            get { return _foreignKeyColumn; }
            set { _foreignKeyColumn = value; }
        }


        public string ReferenceTableName
        {
            get { return _referenceTableName; }
            set { _referenceTableName = value; }
        }

        public string ReferenceColumn
        {
            get { return _referenceColumn; }
            set { _referenceColumn = value; }
        }

        public string DisplayColumn
        {
            get { return _displayColumn; }
            set { _displayColumn = value; }
        }

        public bool IsInnerJoin
        {
            get { return _isInnerJoin; }
            set { _isInnerJoin = value; }
        }

        public string DisplayColumnAlias
        {
            get { return _displayColumnAlias; }
            set { _displayColumnAlias = value; }
        }

        public string GridColumn
        {
            get { return _gridColumn; }
            set { _gridColumn = value; }
        }

        #endregion

        #region Methods
        //public string GetSelectList()
        //{ 
        //    //return string.Format(
        //    return string.Empty;
        //}
        #endregion
    }

    public class TableRelationCollection : ICollection<TableRelation2>
    {
        #region Member variables.
        private List<TableRelation2> _relationList = new List<TableRelation2>();
        private string _defaultMasterTable = string.Empty;

        //store the alias to be used while generating the query.
        private Hashtable _tableAliasHash = new Hashtable();
        private Hashtable _relationColumnList = new Hashtable();
        #endregion

        #region Constructors & Finalizers
        public TableRelationCollection(string defaultMasterTable)
        {
            _defaultMasterTable = defaultMasterTable;

            PushTableAlias(_defaultMasterTable);
        }

        #region "IDisposable Implementation"
        private bool isAppClosing = false;
        // Pointer to an external unmanaged resource.
        private IntPtr handle;
        // Track whether Dispose has been called.
        private bool disposed = false;
        // Use interop to call the method necessary
        // to clean up the unmanaged resource.
        [System.Runtime.InteropServices.DllImport("Kernel32")]
        private extern static Boolean CloseHandle(IntPtr handle);

        private void AddAppExitHandler()
        {
            System.Windows.Forms.Application.ApplicationExit += OnApplicationExit;
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            this.isAppClosing = true;
        }

        public bool IsApplicationClosing
        {
            get { return this.isAppClosing; }
        }

        // Implement IDisposable.
        // Do not make this method virtual.
        // A derived class should not be able to override this method.
        public void Dispose()
        {
            this.Dispose(true);
            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SupressFinalize to
            // take this object off the finalization queue
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        // Dispose(bool disposing) executes in two distinct scenarios.
        // If disposing equals true, the method has been called directly
        // or indirectly by a user's code. Managed and unmanaged resources
        // can be disposed.
        // If disposing equals false, the method has been called by the
        // runtime from inside the finalizer and you should not reference
        // other objects. Only unmanaged resources can be disposed.
        private void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this.disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {
                    // Dispose managed resources.
                    //if ((this._connection != null))
                    //{
                    //    this._connection.Dispose();
                    //}
                    
                }

                if (_relationList != null)
                {
                    _relationList.Clear();
                    _relationList = null;
                }


                // Call the appropriate methods to clean up
                // unmanaged resources here.
                // If disposing is false,
                // only the following code is executed.
                CloseHandle(handle);
                handle = IntPtr.Zero;
            }
            disposed = true;

        }

        // This finalizer will run only if the Dispose method
        // does not get called.
        // It gives your base class the opportunity to finalize.
        // Do not provide finalize methods in types derived from this class.
        ~TableRelationCollection()
        {
            // Do not re-create Dispose clean-up code here.
            // Calling Dispose(false) is optimal in terms of
            // readability and maintainability.
            this.Dispose(true);

            GC.SuppressFinalize(this);
        }

        #endregion
        #endregion

        #region Nested Enums, Structs, and Classes.
        #endregion

        #region Properties

        public string DefaultMasterTable
        {
            get { return _defaultMasterTable; }
            set { _defaultMasterTable = value; }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Adds new table relation into the collection.
        /// Use this function if the relation is estabished between the 2 tables using the same column.        
        /// It will establish the relation as Non-inner joign (may be right join or left join)
        /// </summary>
        public void Add(string foreignKeyColumn, string referenceTableName, string referenceColumn, string displayColumn, string gridColumn)
        {            
            Add(foreignKeyColumn, referenceTableName, referenceColumn, displayColumn, gridColumn, false);
        }

        public void Add(string foreignKeyColumn, string referenceTableName, string referenceColumn, string expression, object displayColumnAlias, string gridColumn)
        {
            Add(foreignKeyColumn, referenceTableName, referenceColumn, expression, displayColumnAlias.ToString(), gridColumn, false);
        }

        /// <summary>
        /// Adds new table relation into the collection.
        /// Use this function if masterTableName is same as DefaultMasterTable which is passed through the constructor.
        /// It will establish the relation as Non-inner joign (may be right join or left join)
        /// </summary>
        /// <param name="foreignKeyColumn"></param>
        /// <param name="referenceTableName"></param>
        /// <param name="displayColumn"></param>
        public void Add(string foreignKeyColumn, string referenceTableName, string displayColumn, string gridColumn)
        {            
            Add(foreignKeyColumn, referenceTableName, foreignKeyColumn, displayColumn, gridColumn, false);
        }

        public void Add(string foreignKeyColumn, string referenceTableName, string expression, object displayColumnAlias, string gridColumn)
        {
            Add(foreignKeyColumn, referenceTableName, foreignKeyColumn, expression, displayColumnAlias.ToString(), gridColumn, false);
        }
        
        public void Add(string foreignKeyColumn, string referenceTableName, string referenceColumn, string displayColumn, string gridColumn, bool isInnerJoin)
        {
            if (_defaultMasterTable.Trim().Length == 0)
                throw new Exception("Default master table is not provided");

            Add(_defaultMasterTable, foreignKeyColumn, referenceTableName, referenceColumn, displayColumn, (object)gridColumn, isInnerJoin);
        }

        public void Add(string foreignKeyColumn, string referenceTableName, string referenceColumn, string expression, string displayColumnAlias, string gridColumn, bool isInnerJoin)
        {
            if (_defaultMasterTable.Trim().Length == 0)
                throw new Exception("Default master table is not provided");

            Add(_defaultMasterTable, foreignKeyColumn, referenceTableName, referenceColumn, expression, displayColumnAlias, gridColumn, isInnerJoin);
        }

        /// <summary>
        /// Adds new table relation into the collection.
        /// It will establish the relation as Non-inner joign (may be right join or left join)
        /// </summary>
        /// <param name="masterTableName"></param>
        /// <param name="foreignKeyColumn"></param>
        /// <param name="referenceTableName"></param>
        /// <param name="referenceColumn"></param>
        /// <param name="displayColumn"></param>
        public void Add(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn, string displayColumn, string gridColumn)
        {
            Add(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, displayColumn, gridColumn, false);
        }

        public void Add(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn, string expression, string displayColumnAlias, string gridColumn)
        {
            Add(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, expression, displayColumnAlias, gridColumn, false);
        }

        /// <summary>
        /// Adds new table relation into the collection.
        /// </summary>
        /// <param name="masterTableName"></param>
        /// <param name="foreignKeyColumn"></param>
        /// <param name="referenceTableName"></param>
        /// <param name="referenceColumn"></param>
        /// <param name="displayColumn"></param>
        /// <param name="isInnerJoin"></param>
        public void Add(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn, string displayColumn, object gridColumn, bool isInnerJoin)
        {
            Add(new TableRelation2(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, displayColumn, gridColumn.ToString(), isInnerJoin));
        }

        public void Add(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn, string expression, string displayColumnAlias, string gridColumn, bool isInnerJoin)
        {
            Add(new TableRelation2(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, expression, displayColumnAlias, gridColumn, isInnerJoin));
        }

        /// <summary>
        /// Generates the column list to be displayed in the SELECT query and return it.
        /// </summary>
        /// <returns>Returns the select list.</returns>
        public string GetSelectList()
        {
            StringBuilder list = new StringBuilder();
            foreach (TableRelation2 relation in _relationList)
            {
                //adding the master table and foreign key column (ID)
                list.AppendFormat("\n\t{0}.{1},", GetTableAlias(relation.MasterTableName), relation.ForeignKeyColumn);
                //adding the reference table's display column
                if (relation.DisplayColumn.Split(new char[]{' '}).Length > 2 || relation.DisplayColumn.Split(new char[]{'.'}).Length > 2)
                {
                    list.AppendFormat("\n\t{1} {2}," 
                        , relation.DisplayColumn.Replace(relation.ReferenceTableName, GetTableAlias(relation.ReferenceTableName)), relation.DisplayColumnAlias) ;
                }
                else
                {
                    list.AppendFormat("\n\t{0}.{1} {2},", GetTableAlias(relation.ReferenceTableName)
                        , relation.DisplayColumn.Replace(relation.ReferenceTableName, GetTableAlias(relation.ReferenceTableName)), relation.DisplayColumnAlias);
                }
            }

            if (list.Length > 0)
            {
                list.Replace(",", " ", list.Length - 1, 1);
            }

            return list.ToString();
        }

        /// <summary>
        /// Generates the table source and returns it.
        /// </summary>
        /// <returns>Returns the table source.</returns>
        public string GetTableSource()
        {
            StringBuilder tableList = new StringBuilder();
            IDictionaryEnumerator e= _tableAliasHash.GetEnumerator();
            tableList.Append("\nFROM");
            while (e.MoveNext())
            {
                tableList.AppendFormat("\n\t{0} as {1},", e.Key, e.Value);
            }

            //remove the last comma.
            if (tableList.Length > 0)
            {
                tableList.Replace(",", " ", tableList.Length - 1, 1);
            }

            return tableList.ToString();
        }

        /// <summary>
        /// Generate the where condition that will be used as the join clause.
        /// </summary>
        /// <returns></returns>
        public string GetJoinCriteria()
        {
            StringBuilder joinCriteria = new StringBuilder();
            joinCriteria.Append("\nWHERE");
            foreach (TableRelation2 rel in _relationList)
            {
                joinCriteria.AppendFormat("\n\t{0}.{1}{4} = {2}.{3} AND", GetTableAlias(rel.MasterTableName), rel.ForeignKeyColumn
                    , GetTableAlias(rel.ReferenceTableName), rel.ReferenceColumn, (rel.IsInnerJoin ? string.Empty : "(+)"));
            }

            //remove the last AND .
            if (joinCriteria.Length > 0)
            {
                joinCriteria.Replace("AND", " ", joinCriteria.Length - 3, 1);
            }
            return joinCriteria.ToString();
        }

        /// <summary>
        /// Pushes the tableName in the alias list.
        /// </summary>
        /// <param name="tableName"></param>
        private void PushTableAlias(string tableName)
        {
            
            tableName = tableName.Trim();
            if (tableName.Trim().Length == 0)
                return;
            //check the the table already exists or not.
            if (!_tableAliasHash.ContainsKey(tableName))
            {
                //push the tableName in the alias list and set alias in the format of (t1, t2,...tn where n is the table number)
                _tableAliasHash.Add(tableName, "t" + (_tableAliasHash.Count + 1));
            }
        }

        /// <summary>
        /// Returns the tableAlias to be used in the SELECT query.
        /// </summary>
        /// <param name="tableName">Table name</param>
        /// <returns>Returns the the table alias.</returns>
        public string GetTableAlias(string tableName)
        {
            tableName = tableName.Trim();
            if (tableName.Trim().Length == 0)
                return string.Empty;
            //if the tableName does not exists in the alias list then push the tableName in the alias list and then return the table Alias.
            if (!_tableAliasHash.ContainsKey(tableName))
            {
                //push the tableName in the alias list and set alias in the format of (t1, t2,...tn where n is the table number)
                _tableAliasHash.Add(tableName, "t" + (_tableAliasHash.Count + 1));
            }

            return _tableAliasHash[tableName].ToString();
        }

        /// <summary>
        /// Pushes the tableName in the alias list.
        /// </summary>
        /// <param name="tableName"></param>
        private void PushColumn(TableRelation2 relation)
        {
            if (relation == null)
                return;
            //check the the column already exists or not.
            if (!_relationColumnList.ContainsKey(relation.ForeignKeyColumn))
            {
                _relationColumnList.Add(relation.ForeignKeyColumn, relation.ForeignKeyColumn);
            }

            //if (!_relationColumnList.ContainsKey(relation.ReferenceColumn))
            //{
            //    _relationColumnList.Add(relation.ReferenceColumn, relation.ReferenceColumn);
            //}

            if (!_relationColumnList.ContainsKey(relation.DisplayColumn))
            {
                _relationColumnList.Add(relation.DisplayColumn, relation.DisplayColumn);
            }
        }

        public bool DoesColumnExists(string columnName)
        {
            return _relationColumnList.ContainsKey(columnName);
        }
        #endregion

        #region ICollection<TableRelation> Members

        public void Add(TableRelation2 item)
        {
            //generate alias for the table.

            PushTableAlias(item.MasterTableName);
            PushTableAlias(item.ReferenceTableName);

            PushColumn(item);

            _relationList.Add(item);
        }

        public void Clear()
        {
            _relationList.Clear();
        }

        public bool Contains(TableRelation2 item)
        {
            return _relationList.Contains(item);
        }

        public void CopyTo(TableRelation2[] array, int arrayIndex)
        {
            _relationList.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _relationList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false ; }
        }

        public bool Remove(TableRelation2 item)
        {
            return _relationList.Remove(item);
        }

        #endregion

        #region IEnumerable<TableRelation> Members

        public IEnumerator<TableRelation2> GetEnumerator()
        {
            return _relationList.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _relationList.GetEnumerator();
        }

        #endregion
    }
}
