namespace Pasal
{
    partial class FrmMainMdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMdi));
            this.menuStripMy = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.companyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRightsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpDatabaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weightUnitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterVendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterEditProductGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterEditCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoss = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchaseReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalesReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSales = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowReport = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damageLossReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchageReturnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaleReturnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolCompanyName = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStripMy.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMy
            // 
            this.menuStripMy.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripMy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.masterSettingToolStripMenuItem,
            this.mnuProduct,
            this.sellToolStripMenuItem2,
            this.mnuSales,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMy.Location = new System.Drawing.Point(0, 0);
            this.menuStripMy.Name = "menuStripMy";
            this.menuStripMy.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStripMy.Size = new System.Drawing.Size(1229, 44);
            this.menuStripMy.TabIndex = 0;
            this.menuStripMy.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyInformationToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.LogOnToolStripMenuItem,
            this.toolStripSeparator5,
            this.changePasswordToolStripMenuItem,
            this.backUpDatabaseToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 36);
            this.fileMenu.Text = "&File";
            // 
            // companyInformationToolStripMenuItem
            // 
            this.companyInformationToolStripMenuItem.Enabled = false;
            this.companyInformationToolStripMenuItem.Name = "companyInformationToolStripMenuItem";
            this.companyInformationToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.companyInformationToolStripMenuItem.Text = "&Company Information";
            this.companyInformationToolStripMenuItem.Visible = false;
            this.companyInformationToolStripMenuItem.Click += new System.EventHandler(this.companyInformationToolStripMenuItem_Click_1);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagementToolStripMenuItem1,
            this.menuRightsManagementToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.systemToolStripMenuItem.Text = "Sy&stem";
            // 
            // userManagementToolStripMenuItem1
            // 
            this.userManagementToolStripMenuItem1.Name = "userManagementToolStripMenuItem1";
            this.userManagementToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.userManagementToolStripMenuItem1.Text = "&User Management";
            this.userManagementToolStripMenuItem1.Click += new System.EventHandler(this.userManagementToolStripMenuItem1_Click);
            // 
            // menuRightsManagementToolStripMenuItem
            // 
            this.menuRightsManagementToolStripMenuItem.Name = "menuRightsManagementToolStripMenuItem";
            this.menuRightsManagementToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.menuRightsManagementToolStripMenuItem.Text = "Menu Rights Management";
            this.menuRightsManagementToolStripMenuItem.Click += new System.EventHandler(this.menuRightsManagementToolStripMenuItem_Click);
            // 
            // LogOnToolStripMenuItem
            // 
            this.LogOnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LogOnToolStripMenuItem.Image")));
            this.LogOnToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.LogOnToolStripMenuItem.Name = "LogOnToolStripMenuItem";
            this.LogOnToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.LogOnToolStripMenuItem.Text = "&Log Off";
            this.LogOnToolStripMenuItem.Click += new System.EventHandler(this.LogOnToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(205, 6);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::Pasal.Properties.Resources.key;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Visible = false;
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // backUpDatabaseToolStripMenuItem1
            // 
            this.backUpDatabaseToolStripMenuItem1.Image = global::Bsoft.Design.Properties.Resources.disk ;
            this.backUpDatabaseToolStripMenuItem1.Name = "backUpDatabaseToolStripMenuItem1";
            this.backUpDatabaseToolStripMenuItem1.Size = new System.Drawing.Size(208, 38);
            this.backUpDatabaseToolStripMenuItem1.Text = "BackUp Database";
            this.backUpDatabaseToolStripMenuItem1.Click += new System.EventHandler(this.backUpDatabaseToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Bsoft.Design.Properties.Resources.close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // masterSettingToolStripMenuItem
            // 
            this.masterSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weightUnitsToolStripMenuItem,
            this.enterCompanyToolStripMenuItem,
            this.enterVendorsToolStripMenuItem,
            this.enterEditProductGroupToolStripMenuItem,
            this.enterEditCustomerDetailsToolStripMenuItem});
            this.masterSettingToolStripMenuItem.Image = global::Pasal.Properties.Resources.master;
            this.masterSettingToolStripMenuItem.Name = "masterSettingToolStripMenuItem";
            this.masterSettingToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.masterSettingToolStripMenuItem.Text = "&Master Setting";
            // 
            // weightUnitsToolStripMenuItem
            // 
            this.weightUnitsToolStripMenuItem.Name = "weightUnitsToolStripMenuItem";
            this.weightUnitsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.weightUnitsToolStripMenuItem.Text = "Units Detail";
            this.weightUnitsToolStripMenuItem.Click += new System.EventHandler(this.weightUnitsToolStripMenuItem_Click);
            // 
            // enterCompanyToolStripMenuItem
            // 
            this.enterCompanyToolStripMenuItem.Name = "enterCompanyToolStripMenuItem";
            this.enterCompanyToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.enterCompanyToolStripMenuItem.Text = "Manufacturing Company";
            this.enterCompanyToolStripMenuItem.Click += new System.EventHandler(this.enterCompanyToolStripMenuItem_Click);
            // 
            // enterVendorsToolStripMenuItem
            // 
            this.enterVendorsToolStripMenuItem.Name = "enterVendorsToolStripMenuItem";
            this.enterVendorsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.enterVendorsToolStripMenuItem.Text = "Vendor Detail";
            this.enterVendorsToolStripMenuItem.Click += new System.EventHandler(this.enterVendorsToolStripMenuItem_Click);
            // 
            // enterEditProductGroupToolStripMenuItem
            // 
            this.enterEditProductGroupToolStripMenuItem.Name = "enterEditProductGroupToolStripMenuItem";
            this.enterEditProductGroupToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.enterEditProductGroupToolStripMenuItem.Text = "Product Group";
            this.enterEditProductGroupToolStripMenuItem.Click += new System.EventHandler(this.enterEditProductGroupToolStripMenuItem_Click);
            // 
            // enterEditCustomerDetailsToolStripMenuItem
            // 
            this.enterEditCustomerDetailsToolStripMenuItem.Name = "enterEditCustomerDetailsToolStripMenuItem";
            this.enterEditCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.enterEditCustomerDetailsToolStripMenuItem.Text = "Customer Details";
            this.enterEditCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.enterEditCustomerDetailsToolStripMenuItem_Click);
            // 
            // mnuProduct
            // 
            this.mnuProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProductDetail,
            this.mnuPurchase,
            this.mnuLoss,
            this.mnuPurchaseReturn,
            this.mnuSalesReturn});
            this.mnuProduct.Image = global::Pasal.Properties.Resources.purchasein;
            this.mnuProduct.Name = "mnuProduct";
            this.mnuProduct.Size = new System.Drawing.Size(93, 36);
            this.mnuProduct.Text = "Product";
            // 
            // mnuProductDetail
            // 
            this.mnuProductDetail.Image = global::Pasal.Properties.Resources.ProductDetails;
            this.mnuProductDetail.Name = "mnuProductDetail";
            this.mnuProductDetail.Size = new System.Drawing.Size(192, 38);
            this.mnuProductDetail.Text = "Product Details";
            this.mnuProductDetail.Click += new System.EventHandler(this.mnuProductDetail_Click);
            // 
            // mnuPurchase
            // 
            this.mnuPurchase.Image = global::Pasal.Properties.Resources.purchase;
            this.mnuPurchase.Name = "mnuPurchase";
            this.mnuPurchase.Size = new System.Drawing.Size(192, 38);
            this.mnuPurchase.Text = "Purchase";
            this.mnuPurchase.Click += new System.EventHandler(this.mnuPurchase_Click);
            // 
            // mnuLoss
            // 
            this.mnuLoss.Image = global::Pasal.Properties.Resources.damaged;
            this.mnuLoss.Name = "mnuLoss";
            this.mnuLoss.Size = new System.Drawing.Size(192, 38);
            this.mnuLoss.Text = "Damage/Loss Entry";
            this.mnuLoss.Click += new System.EventHandler(this.mnuLoss_Click);
            // 
            // mnuPurchaseReturn
            // 
            this.mnuPurchaseReturn.Name = "mnuPurchaseReturn";
            this.mnuPurchaseReturn.Size = new System.Drawing.Size(192, 38);
            this.mnuPurchaseReturn.Text = "Purchase Return";
            this.mnuPurchaseReturn.Click += new System.EventHandler(this.mnuPurchaseReturn_Click);
            // 
            // mnuSalesReturn
            // 
            this.mnuSalesReturn.Name = "mnuSalesReturn";
            this.mnuSalesReturn.Size = new System.Drawing.Size(192, 38);
            this.mnuSalesReturn.Text = "Sales Return";
            this.mnuSalesReturn.Click += new System.EventHandler(this.mnuSalesReturn_Click);
            // 
            // sellToolStripMenuItem2
            // 
            this.sellToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditManagementToolStripMenuItem});
            this.sellToolStripMenuItem2.Enabled = false;
            this.sellToolStripMenuItem2.Name = "sellToolStripMenuItem2";
            this.sellToolStripMenuItem2.Size = new System.Drawing.Size(40, 36);
            this.sellToolStripMenuItem2.Text = "Sale";
            this.sellToolStripMenuItem2.Visible = false;
            // 
            // creditManagementToolStripMenuItem
            // 
            this.creditManagementToolStripMenuItem.Name = "creditManagementToolStripMenuItem";
            this.creditManagementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditManagementToolStripMenuItem.Text = "Credit Management";
            this.creditManagementToolStripMenuItem.Click += new System.EventHandler(this.creditManagementToolStripMenuItem_Click);
            // 
            // mnuSales
            // 
            this.mnuSales.Image = global::Pasal.Properties.Resources.sale;
            this.mnuSales.Name = "mnuSales";
            this.mnuSales.Size = new System.Drawing.Size(77, 36);
            this.mnuSales.Text = "Sales";
            this.mnuSales.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowReport,
            this.salesReportToolStripMenuItem,
            this.correctSalesToolStripMenuItem,
            this.damageLossReportToolStripMenuItem,
            this.mnuPurchageReturnReport,
            this.mnuSaleReturnReport});
            this.reportsToolStripMenuItem.Image = global::Pasal.Properties.Resources.report;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // mnuShowReport
            // 
            this.mnuShowReport.Image = global::Pasal.Properties.Resources.ProductDetails ;
            this.mnuShowReport.Name = "mnuShowReport";
            this.mnuShowReport.Size = new System.Drawing.Size(216, 38);
            this.mnuShowReport.Text = "Products Report";
            this.mnuShowReport.Click += new System.EventHandler(this.mnuShowReport_Click);
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.Image = global::Pasal.Properties.Resources.sale;
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.salesReportToolStripMenuItem_Click);
            // 
            // correctSalesToolStripMenuItem
            // 
            this.correctSalesToolStripMenuItem.Enabled = false;
            this.correctSalesToolStripMenuItem.Name = "correctSalesToolStripMenuItem";
            this.correctSalesToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.correctSalesToolStripMenuItem.Text = "CorrectSales";
            this.correctSalesToolStripMenuItem.Visible = false;
            this.correctSalesToolStripMenuItem.Click += new System.EventHandler(this.correctSalesToolStripMenuItem_Click);
            // 
            // damageLossReportToolStripMenuItem
            // 
            this.damageLossReportToolStripMenuItem.Image = global::Pasal.Properties.Resources.damaged;
            this.damageLossReportToolStripMenuItem.Name = "damageLossReportToolStripMenuItem";
            this.damageLossReportToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.damageLossReportToolStripMenuItem.Text = "Damage Loss Report";
            this.damageLossReportToolStripMenuItem.Click += new System.EventHandler(this.damageLossReportToolStripMenuItem_Click);
            // 
            // mnuPurchageReturnReport
            // 
            this.mnuPurchageReturnReport.Name = "mnuPurchageReturnReport";
            this.mnuPurchageReturnReport.Size = new System.Drawing.Size(216, 38);
            this.mnuPurchageReturnReport.Text = "Purchase Return Report";
            this.mnuPurchageReturnReport.Click += new System.EventHandler(this.mnuPurchageReturnReport_Click);
            // 
            // mnuSaleReturnReport
            // 
            this.mnuSaleReturnReport.Name = "mnuSaleReturnReport";
            this.mnuSaleReturnReport.Size = new System.Drawing.Size(216, 38);
            this.mnuSaleReturnReport.Text = "Sales Return Report";
            this.mnuSaleReturnReport.Click += new System.EventHandler(this.mnuSaleReturnReport_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.mnuRegister});
            this.helpToolStripMenuItem.Image = global::Pasal.Properties.Resources.help;
            this.helpToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(221, 38);
            this.aboutUsToolStripMenuItem.Text = "&About Pasal System 2009";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // mnuRegister
            // 
            this.mnuRegister.Image = global::Bsoft.Design.Properties.Resources.tickRound;
            this.mnuRegister.Name = "mnuRegister";
            this.mnuRegister.Size = new System.Drawing.Size(221, 38);
            this.mnuRegister.Text = "Register";
            this.mnuRegister.Click += new System.EventHandler(this.mnuRegister_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolCompanyName,
            this.CurrentID,
            this.toolStripStatusLabel2,
            this.toolUserName});
            this.statusStrip.Location = new System.Drawing.Point(0, 754);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1229, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel.Text = "Company Name :";
            // 
            // toolCompanyName
            // 
            this.toolCompanyName.Name = "toolCompanyName";
            this.toolCompanyName.Size = new System.Drawing.Size(94, 17);
            this.toolCompanyName.Text = "Company Name";
            // 
            // CurrentID
            // 
            this.CurrentID.Name = "CurrentID";
            this.CurrentID.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel2.Text = "| User Name :";
            // 
            // toolUserName
            // 
            this.toolUserName.Name = "toolUserName";
            this.toolUserName.Size = new System.Drawing.Size(62, 17);
            this.toolUserName.Text = "UserName";
            // 
            // FrmMainMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 776);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStripMy);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Mangal", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMy;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMainMdi";
            this.Text = "Pasal System 2009";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.menuStripMy.ResumeLayout(false);
            this.menuStripMy.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        public System.Windows.Forms.MenuStrip menuStripMy;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem LogOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem masterSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolCompanyName;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem1;
        public System.Windows.Forms.ToolStripStatusLabel CurrentID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolUserName;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterVendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterEditProductGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem backUpDatabaseToolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem weightUnitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterEditCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRightsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuShowReport;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRegister;
        private System.Windows.Forms.ToolStripMenuItem mnuLoss;
        private System.Windows.Forms.ToolStripMenuItem damageLossReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSales;
        private System.Windows.Forms.ToolStripMenuItem mnuProductDetail;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchase;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchaseReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuSalesReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchageReturnReport;
        private System.Windows.Forms.ToolStripMenuItem mnuSaleReturnReport;
    }
}



