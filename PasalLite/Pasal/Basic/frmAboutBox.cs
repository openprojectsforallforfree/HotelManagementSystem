using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using UEMS.BLL;
using Friuts ;
using Bsoft.AppCom;

namespace UEMS
{
    public partial class frmAboutBox : Form 
    {
        #region Member variables.
        private static bool _isFirstTime = true;
        private Loader _objLoader=null;
        private bool _isSplash = true;
        #endregion
        public frmAboutBox(bool isSplash)
        {

            _isSplash = isSplash;
             
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
         

            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;

            ////  Initialize the AboutBox to display the product information from the assembly information.
            ////  Change assembly information settings for your application through either:
            ////  - Project->Properties->Application->Assembly Information
            ////  - AssemblyInfo.cs
            //this.Text = String.Format("About {0}", AssemblyTitle);
            //this.labelProductName.Text = AssemblyProduct;
            //this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            //this.labelCopyright.Text = AssemblyCopyright;
            //this.labelCompanyName.Text = AssemblyCompany;
            //this.textBoxDescription.Text = AssemblyDescription;

            //_objLoader.ProgressStatusMgr.ProgressStatusChange += new ProgressStatus.ProgressStatusChangedEventHandler(ProgressStatusMgr_ProgressStatusChange);
        }

        public frmAboutBox()
        {
            
            InitializeComponent();

            //  Initialize the AboutBox to display the product information from the assembly information.
            //  Change assembly information settings for your application through either:
            //  - Project->Properties->Application->Assembly Information
            //  - AssemblyInfo.cs
            _objLoader = new Loader();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
            ConstantValues.ProductName = AssemblyProduct;
            ConstantValues.ProductVersion = AssemblyVersion;
             _objLoader.ProgressStatusMgr.ProgressStatusChange += new ProgressStatus.ProgressStatusChangedEventHandler(ProgressStatusMgr_ProgressStatusChange);
        }


        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                // Get all Title attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // If there is at least one Title attribute
                if (attributes.Length > 0)
                {
                    // Select the first one
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // If it is not an empty string, return it
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // If there was no Title attribute, or if the Title attribute was the empty string, return the .exe name
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                // Get all Description attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // If there aren't any Description attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Description attribute, return its value
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string AssemblyProduct
        {
            get
            {
                // Get all Product attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // If there aren't any Product attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Product attribute, return its value
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                // Get all Copyright attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // If there aren't any Copyright attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Copyright attribute, return its value
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                // Get all Company attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // If there aren't any Company attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Company attribute, return its value
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void labelCopyright_Click(object sender, EventArgs e)
        {

        }

        private void frmAboutBox_Load(object sender, EventArgs e)
        {
            
        }

        void ProgressStatusMgr_ProgressStatusChange(object sender, ProgressStatusChangedEventArgs e)
        {
            RefreshProgressMessage(e);
        }

        private void RefreshProgressMessage(ProgressStatusChangedEventArgs e)
        {
            

            if (labelLoading.InvokeRequired)
            {
                SimpleDelegate dlgRefresh = delegate
                {
                    RefreshProgressMessage(e);
                };

                labelLoading.Invoke(dlgRefresh);
                return;
            }

            if (e.CompletedPercentage >= 100)
            {
                this.Close();
                return;
            }

            labelLoading.Text = string.Format("Loading : {0}=>{1}...", e.MainProcessName, e.SubProcessName);
            labelLoading.Invalidate();            
            
        }

        private void frmAboutBox_Activated(object sender, EventArgs e)
        {

            if (!_isSplash)
            {
                labelLoading.Visible = false;
                //this.FormBorderStyle = FormBorderStyle.FixedSingle;
                return;
            }
            if (_isFirstTime)
            {
                this.Refresh();
                _objLoader.LoadNecessaryObjectsAsync();
               
            }
            _isFirstTime = false;
        }
       
         


        private void loadclosebutton()
        {
            // 
            // _closeButton
            // 
              
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {
            if (!_isSplash)
            { Close(); }
        }

        private void tableLayoutPanel_Click(object sender, EventArgs e)
        {
            if (!_isSplash)
            { Close(); }
        }

        private void textBoxDescription_Click(object sender, EventArgs e)
        {
            if (!_isSplash)
            { Close(); }
        }
       

    }
}
