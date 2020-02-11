using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

using Friuts;
using Bsoft.Controls;

using Bsoft.Data;
using System.IO;
using Bsoft.Common;
//Consist of all global variables 
//No access to db 
//For db access use constantvalues

namespace Bsoft.AppCom
{
    public delegate void SimpleDelegate();
    public static class GlobalValues
    {
        

        #region Member variables.
        /// <summary>
        /// Gets and sets the variables that is used globally
        /// </summary>
        public static string LoginUserIDPk;
        public static string UserFullNepName;
        public static string UserFullEngName;
        public static string LoginUserName;
        public static string LoginRoleGroup;
        public static string DbUserPassword;
      
        public static string DbServerName;
        public static string DbUserName;
        public static string DbPath;

        public static bool UseOrder;
       
        public static bool DiscountInTotal;

       public static UserInfo UserInfo;
        /// <summary>
        /// Gets or sets the user info which is currently logged in through this application.
        /// </summary>
       

        // private static OrganizationDetail _orgDetail = new OrganizationDetail();
        // private static TPPIMS.Forms.frmCommonResources _commonFormControl = new TPPIMS.Forms.frmCommonResources();
        /// <summary>
        /// Gets or Sets form that will return common controls of the form.
        /// </summary>
        //  public static TPPIMS.Forms.frmCommonResources CommonFormControl
        //  {
        //      get { return GlobalResources._commonFormControl; }
        //     set { GlobalResources._commonFormControl = value; }
        //  }

        #endregion

        #region Constructors & Finalizers.
        //static GlobalValues()
        //{
         
        //}


        #endregion

      

     

        #region Properties
     
       
      
        public static string LoginRoleGroupName
        {
            get
            {
                string grpname = "";
                 
                    grpname =GlobalResources . SelectDBConnection.ExecuteScalar("SELECT title from  SuperAdmin_Rights_Group  where id= " + LoginRoleGroup).ToString();
                 
                return grpname;
            }
        }

      
        public static string dbEngine
        {
            set
            {
                switch (value.ToLower())
                {
                    case "sqlite":
                        // _dbStruct.dbengine = DataBaseEngine.SQLite;
                        ConversionSql.dbKind = databaseKind.SQLite;
                        break;
                    case "oracle":
                        //  _dbStruct.dbengine = DataBaseEngine.Oracle;
                        ConversionSql.dbKind = databaseKind.Oracle;
                        break;
                    case "sqlserver":
                        // _dbStruct.dbengine = DataBaseEngine.SQLServer;
                        ConversionSql.dbKind = databaseKind.SQLServer;
                        break;
                    case "msaccess":
                        // _dbStruct.dbengine = DataBaseEngine.MsAccess;
                        ConversionSql.dbKind = databaseKind.MsAccess;
                        break;
                }
            }
        }

        #endregion

      
    }
}
