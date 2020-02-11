using System;
using System.Collections.Generic;
using System.Text;
using Bsoft.Data;

namespace Friuts
{
    public enum DataBaseEngine
    {
        SQLServer,
        SQLite,
        Oracle,
        MsAccess
    }
    public static class GlobalResourcesFx
    {
        #region Member variables.
        private static DBConnect _con = new DBConnect();        
        #endregion

        #region Constructors & Finalizers.
        static GlobalResourcesFx()
        { 
        
        }
        #endregion

        #region Nested Enums, Structs, and Classes.
       
        #endregion

        #region Properties
        /// <summary>
        /// Gets or Sets common database connection that will be used for executing select queries.
        /// </summary>
        public static DBConnect SelectDBConnection
        {
            get { return _con; }
            set { _con = value; }
        }
        private static DataBaseEngine _databaseEngine = new DataBaseEngine();        
        public static DataBaseEngine databaseEngine
        {
            get { return _databaseEngine; }
            set { _databaseEngine = value; }
        }
        #endregion

        #region Methods
        #endregion
    }
}
