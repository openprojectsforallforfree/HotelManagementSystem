namespace Pasal
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnuStripMy = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrgDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRightsAssign = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuChangePassWord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackUpDataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.masterSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterVendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterEditProductGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterEditCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnitDetails = new System.Windows.Forms.ToolStripMenuItem();
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
            this.damageLossReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchageReturnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaleReturnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.frameUserInfo.SuspendLayout();
            this.mnuStripMy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(990, 2);
            this._closeButton.Click += new System.EventHandler(this._closeButton_Click);
            // 
            // mnuStripMy
            // 
            this.mnuStripMy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuStripMy.AutoSize = false;
            this.mnuStripMy.BackColor = System.Drawing.Color.Transparent;
            this.mnuStripMy.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuStripMy.Font = new System.Drawing.Font("Mangal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripMy.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnuStripMy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.masterSettingToolStripMenuItem,
            this.mnuProduct,
            this.sellToolStripMenuItem2,
            this.mnuSales,
            this.reportsToolStripMenuItem,
            this.mnuHelp,
            this.tagsToolStripMenuItem});
            this.mnuStripMy.Location = new System.Drawing.Point(12, 38);
            this.mnuStripMy.Name = "mnuStripMy";
            this.mnuStripMy.Size = new System.Drawing.Size(982, 40);
            this.mnuStripMy.TabIndex = 69;
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOrgDetails,
            this.MnuRightsAssign,
            this.mnuChangeLogin,
            this.toolStripSeparator5,
            this.mnuChangePassWord,
            this.mnuRestore,
            this.mnuBackUpDataBase,
            this.toolStripSeparator1,
            this.mnuExit});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(50, 36);
            this.fileMenu.Text = "&File";
            // 
            // mnuOrgDetails
            // 
            this.mnuOrgDetails.Name = "mnuOrgDetails";
            this.mnuOrgDetails.Size = new System.Drawing.Size(260, 38);
            this.mnuOrgDetails.Text = "&Company Information";
            this.mnuOrgDetails.Click += new System.EventHandler(this.mnuOrgDetails_Click);
            // 
            // MnuRightsAssign
            // 
            this.MnuRightsAssign.Name = "MnuRightsAssign";
            this.MnuRightsAssign.Size = new System.Drawing.Size(260, 38);
            this.MnuRightsAssign.Text = "User Management";
            // 
            // mnuChangeLogin
            // 
            this.mnuChangeLogin.Image = ((System.Drawing.Image)(resources.GetObject("mnuChangeLogin.Image")));
            this.mnuChangeLogin.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuChangeLogin.Name = "mnuChangeLogin";
            this.mnuChangeLogin.Size = new System.Drawing.Size(260, 38);
            this.mnuChangeLogin.Text = "&Log Off";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(257, 6);
            // 
            // mnuChangePassWord
            // 
            this.mnuChangePassWord.Image = global::Pasal.Properties.Resources.key;
            this.mnuChangePassWord.Name = "mnuChangePassWord";
            this.mnuChangePassWord.Size = new System.Drawing.Size(260, 38);
            this.mnuChangePassWord.Text = "Change Password";
            this.mnuChangePassWord.Visible = false;
            // 
            // mnuRestore
            // 
            this.mnuRestore.Name = "mnuRestore";
            this.mnuRestore.Size = new System.Drawing.Size(260, 38);
            this.mnuRestore.Text = "Restore Database";
            // 
            // mnuBackUpDataBase
            // 
            this.mnuBackUpDataBase.Image = ((System.Drawing.Image)(resources.GetObject("mnuBackUpDataBase.Image")));
            this.mnuBackUpDataBase.Name = "mnuBackUpDataBase";
            this.mnuBackUpDataBase.Size = new System.Drawing.Size(260, 38);
            this.mnuBackUpDataBase.Text = "BackUp Database";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuExit.Image")));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(260, 38);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // masterSettingToolStripMenuItem
            // 
            this.masterSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterCompanyToolStripMenuItem,
            this.enterVendorsToolStripMenuItem,
            this.enterEditProductGroupToolStripMenuItem,
            this.enterEditCustomerDetailsToolStripMenuItem,
            this.mnuUnitDetails});
            this.masterSettingToolStripMenuItem.Image = global::Pasal.Properties.Resources.master;
            this.masterSettingToolStripMenuItem.Name = "masterSettingToolStripMenuItem";
            this.masterSettingToolStripMenuItem.Size = new System.Drawing.Size(163, 36);
            this.masterSettingToolStripMenuItem.Text = "&Master Setting";
            // 
            // enterCompanyToolStripMenuItem
            // 
            this.enterCompanyToolStripMenuItem.Name = "enterCompanyToolStripMenuItem";
            this.enterCompanyToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.enterCompanyToolStripMenuItem.Text = "Manufacturing Company";
            this.enterCompanyToolStripMenuItem.Click += new System.EventHandler(this.enterCompanyToolStripMenuItem_Click);
            // 
            // enterVendorsToolStripMenuItem
            // 
            this.enterVendorsToolStripMenuItem.Name = "enterVendorsToolStripMenuItem";
            this.enterVendorsToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.enterVendorsToolStripMenuItem.Text = "Vendor Detail";
            this.enterVendorsToolStripMenuItem.Click += new System.EventHandler(this.enterVendorsToolStripMenuItem_Click);
            // 
            // enterEditProductGroupToolStripMenuItem
            // 
            this.enterEditProductGroupToolStripMenuItem.Name = "enterEditProductGroupToolStripMenuItem";
            this.enterEditProductGroupToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.enterEditProductGroupToolStripMenuItem.Text = "Product Group";
            this.enterEditProductGroupToolStripMenuItem.Click += new System.EventHandler(this.enterEditProductGroupToolStripMenuItem_Click);
            // 
            // enterEditCustomerDetailsToolStripMenuItem
            // 
            this.enterEditCustomerDetailsToolStripMenuItem.Name = "enterEditCustomerDetailsToolStripMenuItem";
            this.enterEditCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.enterEditCustomerDetailsToolStripMenuItem.Text = "Customer Details";
            this.enterEditCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.enterEditCustomerDetailsToolStripMenuItem_Click);
            // 
            // mnuUnitDetails
            // 
            this.mnuUnitDetails.Name = "mnuUnitDetails";
            this.mnuUnitDetails.Size = new System.Drawing.Size(265, 34);
            this.mnuUnitDetails.Text = "Unit Details";
            this.mnuUnitDetails.Click += new System.EventHandler(this.mnuUnitDetails_Click);
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
            this.mnuProduct.Size = new System.Drawing.Size(113, 36);
            this.mnuProduct.Text = "Product";
            // 
            // mnuProductDetail
            // 
            this.mnuProductDetail.Image = global::Pasal.Properties.Resources.ProductDetails;
            this.mnuProductDetail.Name = "mnuProductDetail";
            this.mnuProductDetail.Size = new System.Drawing.Size(248, 38);
            this.mnuProductDetail.Text = "Product Details";
            this.mnuProductDetail.Click += new System.EventHandler(this.mnuProductDetail_Click);
            // 
            // mnuPurchase
            // 
            this.mnuPurchase.Image = global::Pasal.Properties.Resources.purchase;
            this.mnuPurchase.Name = "mnuPurchase";
            this.mnuPurchase.Size = new System.Drawing.Size(248, 38);
            this.mnuPurchase.Text = "Purchase";
            this.mnuPurchase.Click += new System.EventHandler(this.mnuPurchase_Click);
            // 
            // mnuLoss
            // 
            this.mnuLoss.Image = global::Pasal.Properties.Resources.damaged;
            this.mnuLoss.Name = "mnuLoss";
            this.mnuLoss.Size = new System.Drawing.Size(248, 38);
            this.mnuLoss.Text = "Damage/Loss Entry";
            this.mnuLoss.Click += new System.EventHandler(this.mnuLoss_Click);
            // 
            // mnuPurchaseReturn
            // 
            this.mnuPurchaseReturn.Name = "mnuPurchaseReturn";
            this.mnuPurchaseReturn.Size = new System.Drawing.Size(248, 38);
            this.mnuPurchaseReturn.Text = "Purchase Return";
            this.mnuPurchaseReturn.Click += new System.EventHandler(this.mnuPurchaseReturn_Click);
            // 
            // mnuSalesReturn
            // 
            this.mnuSalesReturn.Name = "mnuSalesReturn";
            this.mnuSalesReturn.Size = new System.Drawing.Size(248, 38);
            this.mnuSalesReturn.Text = "Sales Return";
            this.mnuSalesReturn.Click += new System.EventHandler(this.mnuSalesReturn_Click);
            // 
            // sellToolStripMenuItem2
            // 
            this.sellToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditManagementToolStripMenuItem});
            this.sellToolStripMenuItem2.Enabled = false;
            this.sellToolStripMenuItem2.Name = "sellToolStripMenuItem2";
            this.sellToolStripMenuItem2.Size = new System.Drawing.Size(57, 36);
            this.sellToolStripMenuItem2.Text = "Sale";
            this.sellToolStripMenuItem2.Visible = false;
            // 
            // creditManagementToolStripMenuItem
            // 
            this.creditManagementToolStripMenuItem.Name = "creditManagementToolStripMenuItem";
            this.creditManagementToolStripMenuItem.Size = new System.Drawing.Size(230, 34);
            this.creditManagementToolStripMenuItem.Text = "Credit Management";
            this.creditManagementToolStripMenuItem.Click += new System.EventHandler(this.creditManagementToolStripMenuItem_Click);
            // 
            // mnuSales
            // 
            this.mnuSales.Image = global::Pasal.Properties.Resources.sale;
            this.mnuSales.Name = "mnuSales";
            this.mnuSales.Size = new System.Drawing.Size(97, 36);
            this.mnuSales.Text = "Sales";
            this.mnuSales.Click += new System.EventHandler(this.mnuSales_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowReport,
            this.salesReportToolStripMenuItem,
            this.damageLossReportToolStripMenuItem,
            this.mnuPurchageReturnReport,
            this.mnuSaleReturnReport,
            this.mnuStockReport});
            this.reportsToolStripMenuItem.Image = global::Pasal.Properties.Resources.report;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // mnuShowReport
            // 
            this.mnuShowReport.Image = global::Pasal.Properties.Resources.ProductDetails;
            this.mnuShowReport.Name = "mnuShowReport";
            this.mnuShowReport.Size = new System.Drawing.Size(285, 38);
            this.mnuShowReport.Text = "Products Report";
            this.mnuShowReport.Click += new System.EventHandler(this.mnuShowReport_Click);
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.Image = global::Pasal.Properties.Resources.sale;
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(285, 38);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.salesReportToolStripMenuItem_Click);
            // 
            // damageLossReportToolStripMenuItem
            // 
            this.damageLossReportToolStripMenuItem.Image = global::Pasal.Properties.Resources.damaged;
            this.damageLossReportToolStripMenuItem.Name = "damageLossReportToolStripMenuItem";
            this.damageLossReportToolStripMenuItem.Size = new System.Drawing.Size(285, 38);
            this.damageLossReportToolStripMenuItem.Text = "Damage Loss Report";
            this.damageLossReportToolStripMenuItem.Click += new System.EventHandler(this.damageLossReportToolStripMenuItem_Click);
            // 
            // mnuPurchageReturnReport
            // 
            this.mnuPurchageReturnReport.Name = "mnuPurchageReturnReport";
            this.mnuPurchageReturnReport.Size = new System.Drawing.Size(285, 38);
            this.mnuPurchageReturnReport.Text = "Purchase Return Report";
            this.mnuPurchageReturnReport.Click += new System.EventHandler(this.mnuPurchageReturnReport_Click);
            // 
            // mnuSaleReturnReport
            // 
            this.mnuSaleReturnReport.Name = "mnuSaleReturnReport";
            this.mnuSaleReturnReport.Size = new System.Drawing.Size(285, 38);
            this.mnuSaleReturnReport.Text = "Sales Return Report";
            this.mnuSaleReturnReport.Click += new System.EventHandler(this.mnuSaleReturnReport_Click);
            // 
            // mnuStockReport
            // 
            this.mnuStockReport.Name = "mnuStockReport";
            this.mnuStockReport.Size = new System.Drawing.Size(285, 38);
            this.mnuStockReport.Text = "Stock Report";
            this.mnuStockReport.Click += new System.EventHandler(this.mnuStockReport_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Image = global::Pasal.Properties.Resources.help;
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(90, 36);
            this.mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(128, 34);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tagTypeToolStripMenuItem,
            this.tagGroupToolStripMenuItem,
            this.tagItemToolStripMenuItem});
            this.tagsToolStripMenuItem.Enabled = false;
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(61, 36);
            this.tagsToolStripMenuItem.Text = "Tags";
            this.tagsToolStripMenuItem.Visible = false;
            // 
            // tagTypeToolStripMenuItem
            // 
            this.tagTypeToolStripMenuItem.Name = "tagTypeToolStripMenuItem";
            this.tagTypeToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.tagTypeToolStripMenuItem.Text = "Tag Type";
            this.tagTypeToolStripMenuItem.Click += new System.EventHandler(this.tagTypeToolStripMenuItem_Click);
            // 
            // tagGroupToolStripMenuItem
            // 
            this.tagGroupToolStripMenuItem.Name = "tagGroupToolStripMenuItem";
            this.tagGroupToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.tagGroupToolStripMenuItem.Text = "Tag Group";
            this.tagGroupToolStripMenuItem.Click += new System.EventHandler(this.tagGroupToolStripMenuItem_Click);
            // 
            // tagItemToolStripMenuItem
            // 
            this.tagItemToolStripMenuItem.Name = "tagItemToolStripMenuItem";
            this.tagItemToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.tagItemToolStripMenuItem.Text = "Tag Item";
            this.tagItemToolStripMenuItem.Click += new System.EventHandler(this.tagItemToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pasal.Properties.Resources.full_basket_icon;
            this.pictureBox1.Location = new System.Drawing.Point(831, 570);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Pasal.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(26, 591);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 738);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuStripMy);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Mangal", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.ShowIcon = true;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.mnuStripMy, 0);
            this.Controls.SetChildIndex(this.LblTitle, 0);
            this.Controls.SetChildIndex(this.frameUserInfo, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.frameUserInfo.ResumeLayout(false);
            this.mnuStripMy.ResumeLayout(false);
            this.mnuStripMy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip mnuStripMy;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuOrgDetails;
        private System.Windows.Forms.ToolStripMenuItem MnuRightsAssign;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePassWord;
        private System.Windows.Forms.ToolStripMenuItem mnuBackUpDataBase;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem masterSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterVendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterEditProductGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterEditCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuProductDetail;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchase;
        private System.Windows.Forms.ToolStripMenuItem mnuLoss;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchaseReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuSalesReturn;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem creditManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSales;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuShowReport;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem damageLossReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchageReturnReport;
        private System.Windows.Forms.ToolStripMenuItem mnuSaleReturnReport;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuRestore;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagItemToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuStockReport;
        private System.Windows.Forms.ToolStripMenuItem mnuUnitDetails;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}
