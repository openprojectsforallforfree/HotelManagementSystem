namespace UEMS 
{
    partial class Hotel_Sales_Lst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel_Sales_Lst));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolbar = new System.Windows.Forms.ToolStripButton();
            this.EditToolbar = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Master_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbookingstaus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldueamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_purchage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcanceldate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colindate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBooking = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panelBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(1011, 2);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolbar,
            this.EditToolbar,
            this.DeleteToolbar,
            this.toolStripSeparator1,
            this.ExportToolbar});
            this.toolStrip1.Location = new System.Drawing.Point(4, 11);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(893, 60);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.TabStop = true;
            // 
            // newToolbar
            // 
            this.newToolbar.AutoSize = false;
            this.newToolbar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newToolbar.Image = ((System.Drawing.Image)(resources.GetObject("newToolbar.Image")));
            this.newToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolbar.Name = "newToolbar";
            this.newToolbar.Size = new System.Drawing.Size(60, 60);
            this.newToolbar.Text = "&New";
            this.newToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newToolbar.Click += new System.EventHandler(this.newToolbar_Click);
            // 
            // EditToolbar
            // 
            this.EditToolbar.AutoSize = false;
            this.EditToolbar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditToolbar.Image = ((System.Drawing.Image)(resources.GetObject("EditToolbar.Image")));
            this.EditToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolbar.Name = "EditToolbar";
            this.EditToolbar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.EditToolbar.Size = new System.Drawing.Size(60, 60);
            this.EditToolbar.Text = "&Edit";
            this.EditToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditToolbar.Click += new System.EventHandler(this.EditToolbar_Click);
            // 
            // DeleteToolbar
            // 
            this.DeleteToolbar.AutoSize = false;
            this.DeleteToolbar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteToolbar.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolbar.Image")));
            this.DeleteToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolbar.Name = "DeleteToolbar";
            this.DeleteToolbar.Size = new System.Drawing.Size(60, 60);
            this.DeleteToolbar.Text = "&Delete";
            this.DeleteToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteToolbar.Visible = false;
            this.DeleteToolbar.Click += new System.EventHandler(this.DeleteToolbar_Click);
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
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colfk_Master_Customer,
            this.colProductName,
            this.colfk_Product,
            this.colbookingstaus,
            this.colRate,
            this.colQuantity,
            this.colAmount,
            this.colDiscount,
            this.colServiceCharge,
            this.colVAT,
            this.colNetAmount,
            this.coldueamt,
            this.colRemarks,
            this.colDate,
            this.colUser,
            this.colfk_purchage,
            this.colCostPrice,
            this.colcanceldate,
            this.colindate,
            this.coloutDate});
            this.grid.Location = new System.Drawing.Point(4, 74);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(893, 245);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 4;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colfk_Master_Customer
            // 
            this.colfk_Master_Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colfk_Master_Customer.HeaderText = "Customer";
            this.colfk_Master_Customer.Name = "colfk_Master_Customer";
            this.colfk_Master_Customer.Visible = false;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "Description";
            this.colProductName.Name = "colProductName";
            this.colProductName.Width = 104;
            // 
            // colfk_Product
            // 
            this.colfk_Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colfk_Product.HeaderText = "fk_Product";
            this.colfk_Product.Name = "colfk_Product";
            this.colfk_Product.Visible = false;
            // 
            // colbookingstaus
            // 
            this.colbookingstaus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colbookingstaus.HeaderText = "Booking Staus";
            this.colbookingstaus.Name = "colbookingstaus";
            this.colbookingstaus.Visible = false;
            // 
            // colRate
            // 
            this.colRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRate.HeaderText = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.Width = 63;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 86;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 81;
            // 
            // colDiscount
            // 
            this.colDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Width = 88;
            // 
            // colServiceCharge
            // 
            this.colServiceCharge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colServiceCharge.HeaderText = "ServiceCharge";
            this.colServiceCharge.Name = "colServiceCharge";
            this.colServiceCharge.Width = 126;
            // 
            // colVAT
            // 
            this.colVAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colVAT.HeaderText = "VAT";
            this.colVAT.Name = "colVAT";
            this.colVAT.Width = 60;
            // 
            // colNetAmount
            // 
            this.colNetAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNetAmount.HeaderText = "NetAmount";
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.Width = 103;
            // 
            // coldueamt
            // 
            this.coldueamt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coldueamt.HeaderText = "Due Amount";
            this.coldueamt.Name = "coldueamt";
            this.coldueamt.Width = 111;
            // 
            // colRemarks
            // 
            this.colRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRemarks.HeaderText = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Width = 89;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Width = 63;
            // 
            // colUser
            // 
            this.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUser.HeaderText = "User";
            this.colUser.Name = "colUser";
            this.colUser.Width = 63;
            // 
            // colfk_purchage
            // 
            this.colfk_purchage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colfk_purchage.HeaderText = "fk_purchage";
            this.colfk_purchage.Name = "colfk_purchage";
            this.colfk_purchage.Visible = false;
            // 
            // colCostPrice
            // 
            this.colCostPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCostPrice.HeaderText = "CostPrice";
            this.colCostPrice.Name = "colCostPrice";
            this.colCostPrice.Visible = false;
            // 
            // colcanceldate
            // 
            this.colcanceldate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colcanceldate.HeaderText = "canceldate";
            this.colcanceldate.Name = "colcanceldate";
            this.colcanceldate.Visible = false;
            // 
            // colindate
            // 
            this.colindate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colindate.HeaderText = "In Date";
            this.colindate.Name = "colindate";
            this.colindate.Visible = false;
            // 
            // coloutDate
            // 
            this.coloutDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coloutDate.HeaderText = "Out Date";
            this.coloutDate.Name = "coloutDate";
            this.coloutDate.Visible = false;
            // 
            // panelBooking
            // 
            this.panelBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBooking.BackColor = System.Drawing.Color.Transparent;
            this.panelBooking.Controls.Add(this.toolStrip1);
            this.panelBooking.Controls.Add(this.grid);
            this.panelBooking.Location = new System.Drawing.Point(2, 2);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(900, 322);
            this.panelBooking.TabIndex = 6;
            // 
            // Hotel_Sales_Lst
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 601);
            this.Controls.Add(this.panelBooking);
            this.Name = "Hotel_Sales_Lst";
            this.Text = " List";
            this.Load += new System.EventHandler(this.List_Load);
            this.Controls.SetChildIndex(this.panelBooking, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panelBooking.ResumeLayout(false);
            this.ResumeLayout(false);

        } 



        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolbar;
        private System.Windows.Forms.ToolStripButton EditToolbar;
        private System.Windows.Forms.ToolStripButton DeleteToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ExportToolbar;
        public System.Windows.Forms.Panel panelBooking;
        public System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_Master_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbookingstaus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldueamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_purchage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcanceldate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colindate;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloutDate;
 
    }
}
