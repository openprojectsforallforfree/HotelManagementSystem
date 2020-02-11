using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using Bsoft.Common;
//Application related references
//using SunriseSys.CommonClass;
//using SunriseSys.CommonClass.Log;
using Friuts;
using UEMS;
using Bsoft.Data;
using System.IO;
using Bsoft.AppCom;
using System.Drawing;
namespace UEMS.BLL
{
    /// <summary>
    /// Loads data related to the application which are required in order to start the application and to run the application.
    /// </summary>
    /// <example>
    /// </example>    
    public class Loader
    {
        #region Member variables.
        //private CINI m_oCINI;
        private ProgressStatus _progressStatusMgr = null;
        private Thread _loadObjectThread = null;
        public ProgressStatus.ProgressStatusChangedEventHandler ProgressStatusChanged;
        public TextBox txt = new TextBox();

        #endregion

        #region Constructors & Finalizers.
        /// <summary>
        /// Constructor
        /// </summary>
        public Loader()
        {
            //Set All application wide variables
            GlobalValues.dbEngine = RestoSys.Properties.Settings.Default.dbEngine;
            GlobalValues.DbPath = Bsoft.Data.DataGeneral.GetPathFromConnectionstring(RestoSys.Properties.Settings.Default.Configstring);

            GlobalValues.UseOrder = RestoSys.Properties.Settings.Default.UseOrder;

          

            GlobalResources.ConnectionString = RestoSys.Properties.Settings.Default.Configstring;

            string loglevel = RestoSys.Properties.Settings.Default.LogLevel.Trim();

            //DEBUG = 3
            //ERROR =  else
            //INFORMATION = 2
            //WARNING = 1

            if (loglevel == "3")
            {
                LogTraceToFile.TraceLogLevel = eTRACELEVEL.DEBUG;
            }
            else if (loglevel == "2")
            {
                LogTraceToFile.TraceLogLevel = eTRACELEVEL.INFORMATION;
            }
            else if (loglevel == "1")
            {
                LogTraceToFile.TraceLogLevel = eTRACELEVEL.WARNING;
            }
            else //(RestoSys.Properties.Settings.Default.LogLevel.Trim() == "3")
            {
                LogTraceToFile.TraceLogLevel = eTRACELEVEL.ERROR;
            }





            Bsoft.Design.FormDesginBase.DigitFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Bsoft.Design.FormDesginBase.MainFont = new Font("Verdana", 10);

            //Bsoft.Design.FormDesginBase.DigitFont = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //Bsoft.Design.FormDesginBase.MainFont = new Font("Mangal", 10);

            //m_oCINI = new CINI(GlobalResources.INIFileName, true);
            //initialize the ProgressStatus Manager.
            _progressStatusMgr = new ProgressStatus("Resources", 7);
            _progressStatusMgr.ProgressStatusChange += ProgressStatusMgr_ProgressStatusChanged;
        }
        public void ProgressStatusMgr_ProgressStatusChanged(object sender, ProgressStatusChangedEventArgs e)
        {

        }

        #endregion

        #region Nested Enums, Structs, and Classes.
        #endregion

        #region Properties

        //public ProgressStatus ProgressStatusMgr
        //{
        //    get { return _progressStatusMgr; }
        //    set { _progressStatusMgr = value; }
        //}

        #endregion

        #region Methods
        /// <summary>
        /// Performs the post login task. The task that are performed in this function are
        /// loading the user detail which have recently logged in and the company details.
        /// </summary>
        /// <param name="userID"></param>
        public static void LoadPostLoginDetails(string userID)
        {
            //loading user detail
            //first clear the SN if exist any.
            if (GlobalValues.UserInfo == null)
                GlobalValues.UserInfo = new UserInfo();
            GlobalValues.UserInfo.SN = 0;
            GlobalValues.UserInfo.UserID = userID;

            LogTrace.WriteInfoLog("LoadPostLoginDetails", MethodBase.GetCurrentMethod().Name,
                string.Format("User information of the user {0} loaded succefully ", userID));

            ////loading the company details
            //GlobalResources.OrganisationDetail.LoadData();
            //LogTrace.WriteInfoLog("LoadPostLoginDetails", MethodBase.GetCurrentMethod().Name,
            //    "Organisational details loaded succefully ");
        }


        //public void ProgressStatusMgr_ProgressStatusChanged(object sender, ProgressStatusChangedEventArgs e)
        //{ 

        //}
        public ProgressStatus ProgressStatusMgr
        {
            get { return _progressStatusMgr; }
            set { _progressStatusMgr = value; }
        }

        public void LoadNecessaryObjects()
        {


            LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Loading Necessary objects started.");

            UserSecurityRights Security = new UserSecurityRights();
            //if (!Security.isSecure())
            //{
            //    Application.Exit();
            //}

            _progressStatusMgr.RaiseProgressStatusChangedEvent(1, "Database Configuration.");
            LoadDBConfiguration();
            _progressStatusMgr.RaiseProgressStatusChangedEvent(2, "Establish DB Connection.");
            EstablishDBConnection();
            // _progressStatusMgr.RaiseProgressStatusChangedEvent(3, "Wrong Fiscal year update value.");
            //Friuts.Data.Oracle.DBStructure dbFiscalYear = new Friuts.Data.Oracle.DBStructure(GlobalResources.ConnectionString);
            //dbFiscalYear.WrongFiscalYearUpdate();

            //_progressStatusMgr.RaiseProgressStatusChangedEvent(4, "Loading Convert Data.");
            //LoadingNepaliDates();

            //_progressStatusMgr.RaiseProgressStatusChangedEvent(5, "Loading Organizationl Details.");


            _progressStatusMgr.RaiseProgressStatusChangedEvent(6, "Updating Database Structure.");
            foreach (var item in CommandsClass.Commands)
            {
                if (item.StartsWith("updatedb"))
                {
                    //From Appcom
                    (new ChangeBasicDBStructure()).UpdateStructure();
                    (new FiscalYearDML()).UpdateStructure();
                    (new DMLUserRightsSimple()).UpdateStructure((new RestoSys.MainForm()).mnuStripMy);
                    (new ChangeSpecificDBStructure()).UpdateStructure();
                }
                if (item.StartsWith("deleteviews"))
                {
                    //From Appcom
                    (new ChangeBasicDBStructure()).DeleteAllViews();
                    GlobalResources.SelectDBConnection.Close();
                }
                if (item.StartsWith("runonce"))
                {
                    string[] temp = item.Split(':');
                    if (temp.Length > 1)
                    {
                        CommandsClass.ExcuteFileOnceAndRename(temp[1]);
                    }
                    //From Appcom

                }
                if (item.StartsWith("delete"))
                {
                    string[] temp = item.Split(':');
                    if (temp.Length > 1)
                    {
                        CommandsClass.DeleteFile(temp[1]);
                    }
                    //From Appcom

                }
            }
            CommandsClass.RenameCommand();
            LoadOrganizationalDetails();
            _progressStatusMgr.RaiseProgressStatusChangedEvent(7, "All data loaded completely.");



            LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Loading Necessary objects completed successfully.");
        }

        public void LoadNecessaryObjectsAsync()
        {
            _loadObjectThread = new Thread(new ThreadStart(LoadNecessaryObjects));
            _loadObjectThread.Name = "LoadNecessaryObjectsAsync";
            _loadObjectThread.Priority = ThreadPriority.Highest;
            _loadObjectThread.IsBackground = true;
            _loadObjectThread.Start();
        }

        private void LoadDBConfiguration()
        {


            //LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "DB configuration loadded successfully.");
            //LogTrace.WriteDebugLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name,
            //    string.Format("ConnectionString = {0}", GlobalResources.ConnectionString));
        }

        /// <summary>
        /// Establishing the global db connection that will be used for SELECT query.
        /// </summary>
        private void EstablishDBConnection()
        {
            if (!GlobalResources.SelectDBConnection.Open())
            {
                MessageBox.Show("Unable to establish DB \nPlease check the Database Server status or Contact the administrator.");
                Application.Exit();
            }
            LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "DB connection opened successfully.");
        }

        private void LoadOrganizationalDetails()
        {
            // Friuts.OrganizationDetail.LoadData();

            // LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Organizational Details loadded successfully.");
        }

        private void LoadingNepaliDates()
        {


            LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "All Nepali <> English Convert data loaded successfully.");
            LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, DateTime.Today.ToString());
            //string.Format("Date today is {0} B.S.", Friuts.NepaliDate.NepaliDate.Today));
        }

        public static void LoadDrCr(ComboBox cbo, bool forSearch, bool allowEdit)
        {
            cbo.Items.Clear();
            //set the combobox default properties
            if (allowEdit)
                cbo.DropDownStyle = ComboBoxStyle.DropDown;
            else
                cbo.DropDownStyle = ComboBoxStyle.DropDownList;

            cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            //add the items into the comboboxes
            if (forSearch)
                cbo.Items.Add(new ComboItem("-999999", "Any", ColumnTypes.String));
            int i = 1;
            cbo.Items.Add(new ComboItem("Dr", "Dr", ColumnTypes.String));
            i++;
            cbo.Items.Add(new ComboItem("Cr", "Cr", ColumnTypes.String));

            if (forSearch)
                cbo.SelectedIndex = 0;
        }

        public static void LoadSex(ComboBox cbo, bool forSearch)
        {
            LoadSex(cbo, forSearch, false);
        }


        public static void LoadSex(ComboBox cbo, bool forSearch, bool allowEdit)
        {
            cbo.Items.Clear();
            //set the combobox default properties
            if (allowEdit)
                cbo.DropDownStyle = ComboBoxStyle.DropDown;
            else
                cbo.DropDownStyle = ComboBoxStyle.DropDownList;

            cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            //add the items into the comboboxes
            if (forSearch)
                cbo.Items.Add(new ComboItem("-999999", "Any Sex", ColumnTypes.String));
            int i = 1;
            cbo.Items.Add(new ComboItem(i.ToString(), "Male", ColumnTypes.Number));
            i++;
            cbo.Items.Add(new ComboItem(i.ToString(), "Female", ColumnTypes.Number));

            if (forSearch)
                cbo.SelectedIndex = 0;
        }
        /// <summary>
        /// Loads the possible ward nos in the combo box.
        /// </summary>
        /// <param name="cbo">the comboBox in which the ward no has to be loaded.</param>
        public static void LoadWardNo(ComboBox cbo, bool forSearch)
        {
            LoadWardNo(cbo, forSearch, false);
        }
        public static int MaxWardNo = 17;
        /// <summary>
        /// Loads the possible ward nos in the combo box.
        /// </summary>
        /// <param name="cbo">the comboBox in which the ward no has to be loaded.</param>
        public static void LoadWardNo(ComboBox cbo, bool forSearch, bool allowEdit)
        {
            cbo.Items.Clear();
            //set the combobox default properties
            if (allowEdit)
                cbo.DropDownStyle = ComboBoxStyle.DropDown;
            else
                cbo.DropDownStyle = ComboBoxStyle.DropDownList;

            cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            //add the items into the comboboxes
            if (forSearch)
                cbo.Items.Add(new ComboItem("-999999", "Any Wada No", ColumnTypes.String));
            int i;
            for (i = 1; i <= MaxWardNo; i++)
            {
                cbo.Items.Add(new ComboItem(i.ToString(), i.ToString(), ColumnTypes.Number));
            }
            if (forSearch)
                cbo.SelectedIndex = 0;
        }
        #endregion
    }





}
