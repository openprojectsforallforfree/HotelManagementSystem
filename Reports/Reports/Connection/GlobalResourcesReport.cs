using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

 
 
using System.IO;
using Bsoft.Data;


namespace UEMS.BLL
{
    public delegate void SimpleDelegate();
    public static class GlobalResources
    {
     public static  string currentFiscalYear;

        #region Member variables.
        private static string _connectionString = string.Empty;
        private static string _dbServerName;
        private static string _dbUserName;
        private static string _dbUserPassword;
        private static string _loginUserID;
        public static string _LoginUserName = string.Empty;
        private  static string _LoginRoleGroup = string.Empty;
        private static string _UserFullName;
  
      
       
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
        static GlobalResources()
        {
            //_connectionString = ConfigurationManager.ConnectionStrings["IPTConnectionString"].ConnectionString;
            _connectionString = Reports.Properties.Settings.Default.Configstring.ToString();
            
            //ConfigurationManager.ConnectionStrings["IPTConnectionString"].
           // Friuts.ConfigFx.ConnectionString = ConfigurationManager.ConnectionStrings["IPTConnectionString"].ConnectionString;
            Friuts.ConfigFx.ConnectionString = _connectionString;
            //Takes Database specifiec informations from appsetting
            ////_dbServerName = ConfigurationManager.AppSettings["HOST"].ToString();
            ////_dbUserName = ConfigurationManager.AppSettings["UserID"].ToString();
            ////_dbUserPassword = ConfigurationManager.AppSettings["password"].ToString();

            //use For globally data execute or returen
           
            //_cnMain.Open();
        }


        #endregion

        #region Nested Enums, Structs, and Classes.
        #endregion

        #region Properties

        
        
         

        /// <summary>
        /// Gets or sets the organizationl detail. The organization detail is loaded from DB.
        /// </summary>
        //public static OrganizationDetail OrganisationDetail
        //{
        //    get { return GlobalResources._orgDetail; }
        //    set { GlobalResources._orgDetail = value; }
        //}
        
        /// <summary>
        /// Gets or sets the connection string the will be used to open the DB Connection.
        /// </summary>
        public static string ConnectionString
        {
            get { return GlobalResources._connectionString; }
            set { GlobalResources._connectionString = value; }
        }

        /// <summary>
        /// Gets or Sets the DB connection that is to be used globally for selection.
        /// It usess the connection used by the CRUDE FX Engine..
        /// </summary>
        public static DBConnect SelectDBConnection
        {
            get { return Friuts.GlobalResourcesFx.SelectDBConnection; }
            set { Friuts.GlobalResourcesFx.SelectDBConnection = value;}
        }

        /// <summary>
        /// Gets and sets the Database server name that is used globally
        /// </summary>
        public static string DbServerName
        {
            get { return GlobalResources._dbServerName; }
            set { GlobalResources._dbServerName = value; }
        }

        /// <summary>
        /// Gets and sets the Database User Name that is used globally
        /// </summary>
        public static string DbUserName
        {
            get { return GlobalResources._dbUserName; }
            set { GlobalResources._dbUserName = value; }
        }

        /// <summary>
        /// Gets and sets the User Password of Database. Which can be accessed globally
        /// </summary>
        public static string DbUserPassword
        {
            get { return GlobalResources._dbUserPassword; }
            set { GlobalResources._dbUserPassword = value; }
        }

        /// <summary>
        /// Gets and Sets the User Login Userid which can be Access Globally.
        /// </summary>
        public static string LoginUserID
        {
            get { return GlobalResources._loginUserID; }
            set { GlobalResources._loginUserID = value; }
        }
        /// <summary>
        /// Gets and Sets the Current IPT login User full Name
        /// </summary>
        public static string UserFullName
        {
            get { return GlobalResources._UserFullName; }
            set { GlobalResources._UserFullName = value; }
        }

        public static string LoginUserName
        {
            get { return GlobalResources._LoginUserName; }
            set { GlobalResources._LoginUserName = value; }
        }

        public static string LoginRoleGroup
        {
            get { return GlobalResources._LoginRoleGroup; }
            set { GlobalResources._LoginRoleGroup = value; }
        }
        public static string LoginRoleGroupName
        {
            get {
                string grpname = "";
                if (_LoginRoleGroup.Trim() != "")
                {
                    grpname = BLL.GlobalResources.SelectDBConnection.ExecuteScalar("SELECT 	title from  Rights_Group_Master  where id= " + _LoginRoleGroup ).ToString();
                }
                return grpname; 
            }
        }
#endregion

        #region Methods

        #endregion
    }
}
