namespace UEMS 
{
    partial class hotel_sales_View_Lst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hotel_sales_View_Lst));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolAccountDetails = new System.Windows.Forms.ToolStripButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_master_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbookingstaus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colservicecharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnetamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldueamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltablename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelSearchPanel1 = new RestoSys.Reports.HotelSearchPanel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(1089, 2);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.ExportToolbar,
            this.toolAccountDetails});
            this.toolStrip1.Location = new System.Drawing.Point(877, 115);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(87, 60);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.TabStop = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // ExportToolbar
            // 
            this.ExportToolbar.AutoSize = false;
            this.ExportToolbar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportToolbar.Image = ((System.Drawing.Image)(resources.GetObject("ExportToolbar.Image")));
            this.ExportToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToolbar.Name = "ExportToolbar";
            this.ExportToolbar.Size = new System.Drawing.Size(60, 60);
            this.ExportToolbar.Text = "E&xport";
            this.ExportToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExportToolbar.Click += new System.EventHandler(this.ExportToolbar_Click);
            // 
            // toolAccountDetails
            // 
            this.toolAccountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolAccountDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolAccountDetails.Image = global::RestoSys.Properties.Resources.cash;
            this.toolAccountDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAccountDetails.Name = "toolAccountDetails";
            this.toolAccountDetails.Size = new System.Drawing.Size(60, 60);
            this.toolAccountDetails.Text = "Detail";
            this.toolAccountDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolAccountDetails.Visible = false;
            this.toolAccountDetails.Click += new System.EventHandler(this.toolAccountDetails_Click);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerName,
            this.colProductName,
            this.colid,
            this.colAccID,
            this.colfk_master_customer,
            this.colfk_Product,
            this.colbookingstaus,
            this.colrate,
            this.colQuantity,
            this.colamount,
            this.coldiscount,
            this.colvat,
            this.colservicecharge,
            this.colnetamount,
            this.coldueamt,
            this.coldate,
            this.coluser,
            this.coltablename});
            this.grid.Location = new System.Drawing.Point(1, 191);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1120, 473);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 4;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCustomerName.HeaderText = "Customer Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Width = 134;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.Width = 123;
            // 
            // colid
            // 
            this.colid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colid.HeaderText = "id";
            this.colid.Name = "colid";
            this.colid.Visible = false;
            // 
            // colAccID
            // 
            this.colAccID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAccID.HeaderText = "AccID";
            this.colAccID.Name = "colAccID";
            this.colAccID.Visible = false;
            // 
            // colfk_master_customer
            // 
            this.colfk_master_customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colfk_master_customer.HeaderText = "fk_master_customer";
            this.colfk_master_customer.Name = "colfk_master_customer";
            this.colfk_master_customer.Visible = false;
            // 
            // colfk_Product
            // 
            this.colfk_Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colfk_Product.HeaderText = "fk_Product  ";
            this.colfk_Product.Name = "colfk_Product";
            this.colfk_Product.Visible = false;
            // 
            // colbookingstaus
            // 
            this.colbookingstaus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colbookingstaus.HeaderText = "Bookingstaus ";
            this.colbookingstaus.Name = "colbookingstaus";
            this.colbookingstaus.Visible = false;
            // 
            // colrate
            // 
            this.colrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colrate.HeaderText = "Rate";
            this.colrate.Name = "colrate";
            this.colrate.Width = 63;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colQuantity.HeaderText = "Quantity ";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 90;
            // 
            // colamount
            // 
            this.colamount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colamount.HeaderText = "Amount";
            this.colamount.Name = "colamount";
            this.colamount.Width = 81;
            // 
            // coldiscount
            // 
            this.coldiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coldiscount.HeaderText = "Discount";
            this.coldiscount.Name = "coldiscount";
            this.coldiscount.Width = 88;
            // 
            // colvat
            // 
            this.colvat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colvat.HeaderText = "VAT";
            this.colvat.Name = "colvat";
            this.colvat.Width = 60;
            // 
            // colservicecharge
            // 
            this.colservicecharge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colservicecharge.HeaderText = "Servicecharge ";
            this.colservicecharge.Name = "colservicecharge";
            this.colservicecharge.Width = 128;
            // 
            // colnetamount
            // 
            this.colnetamount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colnetamount.HeaderText = "Netamount";
            this.colnetamount.Name = "colnetamount";
            this.colnetamount.Width = 102;
            // 
            // coldueamt
            // 
            this.coldueamt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coldueamt.HeaderText = "Dueamt";
            this.coldueamt.Name = "coldueamt";
            this.coldueamt.Width = 82;
            // 
            // coldate
            // 
            this.coldate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coldate.HeaderText = "Date";
            this.coldate.Name = "coldate";
            this.coldate.Width = 63;
            // 
            // coluser
            // 
            this.coluser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coluser.HeaderText = "User";
            this.coluser.Name = "coluser";
            this.coluser.Width = 63;
            // 
            // coltablename
            // 
            this.coltablename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coltablename.HeaderText = "tablename";
            this.coltablename.Name = "coltablename";
            this.coltablename.Visible = false;
            // 
            // hotelSearchPanel1
            // 
            this.hotelSearchPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hotelSearchPanel1.BackColor = System.Drawing.Color.Transparent;
            this.hotelSearchPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelSearchPanel1.Location = new System.Drawing.Point(9, 41);
            this.hotelSearchPanel1.Name = "hotelSearchPanel1";
            this.hotelSearchPanel1.Size = new System.Drawing.Size(1102, 144);
            this.hotelSearchPanel1.TabIndex = 6;
            this.hotelSearchPanel1.searchnow += new RestoSys.Reports.HotelSearchPanel.serchNow(this.hotelSearchPanel1_searchnow);
            // 
            // hotel_sales_View_Lst
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 666);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.hotelSearchPanel1);
            this.Name = "hotel_sales_View_Lst";
            this.Text = "Hotel Sales Report";
            this.Load += new System.EventHandler(this.List_Load);
            this.Controls.SetChildIndex(this.hotelSearchPanel1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        } 



        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ExportToolbar;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_master_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbookingstaus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colservicecharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnetamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldueamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldate;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluser;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltablename;
        private System.Windows.Forms.ToolStripButton toolAccountDetails;
        private RestoSys.Reports.HotelSearchPanel hotelSearchPanel1;
 
    }
}
