using System;
using System.Collections.Generic;
using System.Text;
 
///This name space defines connection string , con and dbstrunct
///never need to declare these any where else in entire application scope.
namespace Bsoft.Data
{
    public static class GlobalResources
    {
        public static string ConnectionString
        {
            set 
            {
                _dbcon = new DBConnect(value);
                _DbStruct = new DBStructure(value);
            }
        }
        private static DBConnect _dbcon;
        private static DBStructure _DbStruct;
        /// <summary>
        /// <summary>
        /// Gets or Sets common database connection that will be used for executing select queries.
        /// </summary>
        public static DBConnect SelectDBConnection
        {
            get { return _dbcon; }
        }
        public static DBStructure  DbStruct
        {
            get { return _DbStruct; }
        }
    }
}
