using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Friuts
{
    //added display column aliasis to get AS key word in relation list as the column name 28 june 2011
    public enum TableJoinTypes
    {
        INNER_JOIN = 0,
        LEFT_JOIN,
        RIGHT_JOIN
    }

    public class TableRelation
    {
        #region Member variables.
        private string _masterTableName = string.Empty;
        private string _foreignKeyColumn = string.Empty;
        private string _foreignKeyColumnAlias = string.Empty;

        private string _referenceTableName = string.Empty;
        private string _referenceColumn = string.Empty;
        private string _displayColumn = string.Empty;
        private string _displayColumnAlias = string.Empty;
        private string _gridColumn = string.Empty;
        private TableJoinTypes _joinType = TableJoinTypes.INNER_JOIN;
        #endregion

        #region Constructors & Finalizers.
        public TableRelation(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
            , string displayColumn, string gridColumn)
        {
            Initialize(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, displayColumn, gridColumn, TableJoinTypes.INNER_JOIN);
        }

        //public TableRelation(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
        //    , string expression, string displayColumnAlias, string gridColumn)
        //{
        //    Initialize(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, expression, displayColumnAlias, gridColumn, TableJoinTypes.INNER_JOIN);
        //}

        public TableRelation(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
            , string displayColumn, string gridColumn, TableJoinTypes joinType)
        {
            Initialize(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, displayColumn, gridColumn, joinType);
        }

        //public TableRelation(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
        //     , string expression, string displayColumnAlias, string gridColumn, TableJoinTypes joinType)
        //{
        //    Initialize(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, expression, displayColumnAlias, gridColumn, joinType);
        //}

        private void Initialize(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
            , string displayColumn, string gridColumn, TableJoinTypes joinType)
        {
            string alias = string.Empty;
            //////////check for "as" keyword which is used for separataing the column and alias.

            //////////checking for cases like . t2.first_name || ' ' || t2.last_name as employeeName
            ////////int startIndex = displayColumn.ToLower().IndexOf(" as ");
            ////////if (startIndex > -1)
            ////////{
            ////////    alias = displayColumn.Substring(startIndex + 4 + 1); //length(" as ") = 4.
            ////////    displayColumn = displayColumn.Substring(0, startIndex);
            ////////}

            ////////if (alias.Length == 0)
            ////////{
            ////////    //checking for cases like  t2.first_name || ' ' || t2.last_name employeeName
            ////////    startIndex = displayColumn.LastIndexOf(" ");
            ////////    if (startIndex > -1)
            ////////    {
            ////////        alias = displayColumn.Substring(startIndex + 1);
            ////////        displayColumn = displayColumn.Substring(0, startIndex);
            ////////    }
            ////////}

            ////////if (alias.Length == 0)
            ////////{
            ////////    //checking for cases like t2.first_name.
            ////////    startIndex = displayColumn.IndexOf(".");
            ////////    if (startIndex > -1)
            ////////    {
            ////////        alias = displayColumn.Substring(startIndex + 1);
            ////////        displayColumn = displayColumn.Substring(0, startIndex);
            ////////    }
            ////////}
            //alias = displayColumn.Substring(1

            Initialize(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, displayColumn, alias, gridColumn, joinType);
        }

        private void Initialize(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
            , string expression, string displayColumnAlias, string gridColumn, TableJoinTypes joinType)
        {
            _masterTableName = masterTableName;
            _foreignKeyColumn = foreignKeyColumn;
            _referenceTableName = referenceTableName;
            _referenceColumn = referenceColumn;
            _displayColumn = expression;
            _gridColumn = gridColumn;
            _joinType = joinType;
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
        ~TableRelation()
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

        public TableJoinTypes TableJoinType
        {
            get { return _joinType; }
            set { _joinType = value; }
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


        public string ForeignKeyColumnAlias
        {
            get { return _foreignKeyColumnAlias; }
            set { _foreignKeyColumnAlias = value; }
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

    public class TableRelationCollection : ICollection<TableRelation>
    {
        #region Member variables.
        private List<TableRelation> _relationList = new List<TableRelation>();
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
            set { 
                _defaultMasterTable = value;
                PushTableAlias(_defaultMasterTable);
            }
        }


        public Hashtable TableAliasHash
        {
            get { return _tableAliasHash; }
            set { _tableAliasHash = value; }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Adds new table relation into the collection.
        /// Use this function if the relation is estabished between the 2 tables using the same column.        
        /// It will establish the relation as Non-inner joign (may be right join or left join)
        /// </summary>
        /// <param name="foreignKeyColumn">Of this table</param>
        /// <param name="referenceTableName">The referencing Table</param>
        /// <param name="referenceColumn">Usually Id of referencing table</param>
        /// <param name="displayColumn">What to display from the referencing Table</param>
        /// <param name="gridColumn">Where to display it</param>
        public void Add(string foreignKeyColumn, string referenceTableName, string referenceColumn, string displayColumn, string gridColumn)
        {
            Add(foreignKeyColumn, referenceTableName, referenceColumn, displayColumn, gridColumn, TableJoinTypes.INNER_JOIN);
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
            Add(foreignKeyColumn, referenceTableName, foreignKeyColumn, displayColumn, gridColumn, TableJoinTypes.INNER_JOIN);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="foreignKeyColumn">Of this table</param>
        /// <param name="referenceTableName">The referencing Table</param>
        /// <param name="referenceColumn">Usually Id of referencing table</param>
        /// <param name="displayColumn">What to display from the referencing Table</param>
        /// <param name="gridColumn">Where to display it</param>
        /// <param name="joinType">Join Type</param>
        public void Add(string foreignKeyColumn, string referenceTableName, string referenceColumn, string displayColumn, string gridColumn, TableJoinTypes joinType)
        {
            if (_defaultMasterTable.Trim().Length == 0)
                throw new Exception("Default master table is not provided");

            Add(_defaultMasterTable, foreignKeyColumn, referenceTableName, referenceColumn, displayColumn, gridColumn, joinType);
        }      

        /// <summary>
        /// Adds new table relation into the collection.
        /// </summary>
        /// <param name="masterTableName"></param>
        /// <param name="foreignKeyColumn">Of this table</param>
        /// <param name="referenceTableName">The referencing Table</param>
        /// <param name="referenceColumn">Usually Id of referencing table</param>
        /// <param name="displayColumn">What to display from the referencing Table</param>
        /// <param name="gridColumn">Where to display it</param>
        /// <param name="joinType">Join Type</param>
        private void Add(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
            , string displayColumn, string gridColumn, TableJoinTypes joinType)
        {
            Add(new TableRelation(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, displayColumn, gridColumn, joinType));
        }

        //private void Add(string masterTableName, string foreignKeyColumn, string referenceTableName, string referenceColumn
        //    , string expression, string displayColumnAlias, string gridColumn, bool isInnerJoin)
        //{
        //    Add(new TableRelation(masterTableName, foreignKeyColumn, referenceTableName, referenceColumn, expression, displayColumnAlias, gridColumn, isInnerJoin));
        //}

        /// <summary>
        /// Generates the column list to be displayed in the SELECT query and return it.
        /// </summary>
        /// <returns>Returns the select list.</returns>
        public string GetSelectList()
        {
            StringBuilder list = new StringBuilder();
            string tmp = string.Empty;   
            foreach (TableRelation relation in _relationList)
            {
                //adding the master table and foreign key column (ID)
                if (relation.ForeignKeyColumn.Contains("."))
                {
                     tmp = relation.ForeignKeyColumn.Replace(relation.MasterTableName, GetTableAlias(relation.MasterTableName));
                     relation.ForeignKeyColumnAlias = tmp.Replace(".", "_");
                     list.AppendFormat("\n\t{0} {1},", tmp, relation.ForeignKeyColumnAlias);                                        
                }
                else
                {
                   relation.ForeignKeyColumnAlias = string.Format("{0}_{1}", GetTableAlias(relation.MasterTableName), relation.ForeignKeyColumn);
                    list.AppendFormat("\n\t{0}.{1} {2},", GetTableAlias(relation.MasterTableName), relation.ForeignKeyColumn, relation.ForeignKeyColumnAlias);
                }
                tmp = string.Empty;

                
                if (relation.DisplayColumn.Contains("."))
                {
                    tmp = relation.DisplayColumn.Replace(relation.ReferenceTableName, GetTableAlias(relation.ReferenceTableName));
                    if (!tmp.Contains("||"))
                        relation.DisplayColumnAlias = tmp.Replace(".", "_");
                    list.AppendFormat("\n\t{0} {1},"
                                , tmp, relation.DisplayColumnAlias);
                }
                else
                {//Dhiraj
                    if (!relation.DisplayColumn.Contains("||"))
                    {
                        relation.DisplayColumnAlias = string.Format("{0}_{1}", GetTableAlias(relation.ReferenceTableName), relation.DisplayColumn);
                    }
                    else
                    {
                        if (relation.DisplayColumn.ToUpper().Contains(" AS "))
                        {
                            int indexOfAsEnd = relation.DisplayColumn.ToUpper().IndexOf(" AS ") + 4 ;
                          
                            string DispTemp = relation.DisplayColumn.Substring(indexOfAsEnd,  relation.DisplayColumn.Length - indexOfAsEnd);
                              int lengthofAlias = DispTemp.Length ;
                            DispTemp = DispTemp.Trim ();
                            relation.DisplayColumnAlias = DispTemp;
                            relation.DisplayColumn = relation.DisplayColumn.Remove(indexOfAsEnd - 4); 
                        }
                        else
                        {
                            if ( relation.DisplayColumnAlias.Trim ()== "")
                            {
                                relation.DisplayColumnAlias = string.Format("{0}_{1}", GetTableAlias(relation.ReferenceTableName), relation.DisplayColumn);
                            }
                            
                        }
                    }
                    list.AppendFormat("\n\t{0}.{1} {2},", GetTableAlias(relation.ReferenceTableName), relation.DisplayColumn, relation.DisplayColumnAlias);    
                }
            }

            if (list.Length > 0)
            { 
                 list.Replace(",", " ", list.Length - 1, 1);//remove last comma
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
            //IDictionaryEnumerator e = _tableAliasHash.GetEnumerator();
            //tableList.Append("\nFROM");
            //while (e.MoveNext())
            //{
            //    tableList.AppendFormat("\n\t{0} {1},", e.Key, e.Value);
            //}

            ////remove the last comma.
            //if (tableList.Length > 0)
            //{
            //    tableList.Replace(",", " ", tableList.Length - 1, 1);
            //}

            tableList.Append("\nFROM ");
              tableList.AppendLine(_defaultMasterTable + " t1");
            return tableList.ToString();
        }

        /// <summary>
        /// Generate the where condition that will be used as the join clause.
        /// </summary>
        /// <returns></returns>
        public string GetJoinCriteria()
        {

            //left join District t2 " 
            //sb.Append("\n on t1.DistrictIDofOffice = t2.DistrictID ");

            StringBuilder joinCriteria = new StringBuilder();
          //  joinCriteria.Append("\nWHERE ");
            int cnt = _relationList.Count;
            foreach (TableRelation rel in _relationList)
            {
                cnt--;
                //joinCriteria.AppendFormat("\n\t {0}.{1}{5} = {2}.{3}{4} ", GetTableAlias(rel.MasterTableName), rel.ForeignKeyColumn
                //    , GetTableAlias(rel.ReferenceTableName), rel.ReferenceColumn
                //    , (rel.TableJoinType == TableJoinTypes.LEFT_JOIN ? "(+)" : string.Empty)
                //    , (rel.TableJoinType == TableJoinTypes.RIGHT_JOIN ? "(+)" : string.Empty));
                    //, (rel.TableJoinType == TableJoinTypes.LEFT_JOIN ? "(+)" : string.Empty)
                    //, (rel.TableJoinType == TableJoinTypes.RIGHT_JOIN ? "(+)" : string.Empty));
                string joincrtemp = string.Format("\n\t left join {4} {2} on {0}.{1} = {2}.{3} ", GetTableAlias(rel.MasterTableName), rel.ForeignKeyColumn
                    , GetTableAlias(rel.ReferenceTableName), rel.ReferenceColumn, rel.ReferenceTableName);
                if (!joinCriteria .ToString ().Contains (joincrtemp .Trim () ))
                {
                    joinCriteria.AppendLine (joincrtemp);
                }
               
                    //, (rel.TableJoinType == TableJoinTypes.LEFT_JOIN ? "(+)" : string.Empty)
                    //, (rel.TableJoinType == TableJoinTypes.RIGHT_JOIN ? "(+)" : string.Empty));

                //dhiraj modified
                //if (cnt > 0)
                   // joinCriteria.Append(" AND ");
            }

            //remove the last AND .
            //if (joinCriteria.Length > 0)
            //{
            //    joinCriteria = joinCriteria.Replace("AND", "###");//, joinCriteria.Length - 6, 1);                
            //}
            return joinCriteria.ToString();
        }

        //  public string GetJoinCriteria()
        //{

        //    left join District t2 " 
        //    sb.Append("\n on t1.DistrictIDofOffice = t2.DistrictID ");

        //    StringBuilder joinCriteria = new StringBuilder();
        //    joinCriteria.Append("\nWHERE ");
        //    int cnt = _relationList.Count;
        //    foreach (TableRelation rel in _relationList)
        //    {
        //        cnt--;
        //        joinCriteria.AppendFormat("\n\t {0}.{1}{5} = {2}.{3}{4} ", GetTableAlias(rel.MasterTableName), rel.ForeignKeyColumn
        //            , GetTableAlias(rel.ReferenceTableName), rel.ReferenceColumn
        //            , (rel.TableJoinType == TableJoinTypes.LEFT_JOIN ? "(+)" : string.Empty)
        //            , (rel.TableJoinType == TableJoinTypes.RIGHT_JOIN ? "(+)" : string.Empty));
        //            //, (rel.TableJoinType == TableJoinTypes.LEFT_JOIN ? "(+)" : string.Empty)
        //            //, (rel.TableJoinType == TableJoinTypes.RIGHT_JOIN ? "(+)" : string.Empty));
                
        //        //dhiraj modified
        //        if (cnt > 0)
        //            joinCriteria.Append(" AND ");
        //    }

        //    //remove the last AND .
        //    //if (joinCriteria.Length > 0)
        //    //{
        //    //    joinCriteria = joinCriteria.Replace("AND", "###");//, joinCriteria.Length - 6, 1);                
        //    //}
        //    return joinCriteria.ToString();
        //}

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
                //_tableAliasHash.Add(tableName, "t" + (_tableAliasHash.Count + 1));
                _tableAliasHash.Add(tableName, "t" + (_tableAliasHash.Count + 1));
                //_tableAliasHash.s
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
        private void PushColumn(TableRelation relation)
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

        public void Add(TableRelation item)
        {
            //generate alias for the table.

            PushTableAlias(item.MasterTableName);
            PushTableAlias(item.ReferenceTableName);

            PushColumn(item);
            item.DisplayColumn = item.DisplayColumn.Replace(item.ReferenceTableName, GetTableAlias(item.ReferenceTableName));

            _relationList.Add(item);
        }

        public void Clear()
        {
            _relationList.Clear();
            _tableAliasHash.Clear();
            _relationColumnList.Clear();
        }

        public bool Contains(TableRelation item)
        {
            return _relationList.Contains(item);
        }

        public void CopyTo(TableRelation[] array, int arrayIndex)
        {
            _relationList.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _relationList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(TableRelation item)
        {
            return _relationList.Remove(item);
        }

        #endregion

        #region IEnumerable<TableRelation> Members

        public IEnumerator<TableRelation> GetEnumerator()
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
