namespace UEMS 
{
    partial class RoomBookingView_Lst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomBookingView_Lst));
            this.grid = new System.Windows.Forms.DataGridView();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colindate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolAccountDetails = new System.Windows.Forms.ToolStripButton();
            this.hotelSearchPanel1 = new RestoSys.Reports.HotelSearchPanel();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(1089, 2);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.colAccid,
            this.colRoomName,
            this.colRoomRate,
            this.colCustomerName,
            this.colPhone,
            this.colstatus,
            this.colindate,
            this.coloutDate,
            this.colBookinDate,
            this.colUser});
            this.grid.Location = new System.Drawing.Point(1, 195);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1120, 469);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 4;
            // 
            // colid
            // 
            this.colid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colid.HeaderText = "id";
            this.colid.Name = "colid";
            this.colid.Visible = false;
            // 
            // colAccid
            // 
            this.colAccid.HeaderText = "Accid";
            this.colAccid.Name = "colAccid";
            this.colAccid.Visible = false;
            this.colAccid.Width = 59;
            // 
            // colRoomName
            // 
            this.colRoomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRoomName.HeaderText = "Room Name";
            this.colRoomName.Name = "colRoomName";
            this.colRoomName.Width = 111;
            // 
            // colRoomRate
            // 
            this.colRoomRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRoomRate.HeaderText = "Room Rate";
            this.colRoomRate.Name = "colRoomRate";
            this.colRoomRate.Width = 104;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCustomerName.HeaderText = "Customer Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Width = 134;
            // 
            // colPhone
            // 
            this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 74;
            // 
            // colstatus
            // 
            this.colstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colstatus.HeaderText = "Status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Width = 73;
            // 
            // colindate
            // 
            this.colindate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colindate.HeaderText = "Indate";
            this.colindate.Name = "colindate";
            this.colindate.Width = 72;
            // 
            // coloutDate
            // 
            this.coloutDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coloutDate.HeaderText = "OutDate";
            this.coloutDate.Name = "coloutDate";
            this.coloutDate.Width = 86;
            // 
            // colBookinDate
            // 
            this.colBookinDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBookinDate.HeaderText = "Booking Date";
            this.colBookinDate.Name = "colBookinDate";
            this.colBookinDate.Width = 118;
            // 
            // colUser
            // 
            this.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUser.HeaderText = "User";
            this.colUser.Name = "colUser";
            this.colUser.Width = 63;
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
            this.toolStrip1.Location = new System.Drawing.Point(877, 118);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(84, 62);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.TabStop = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
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
            this.ExportToolbar.Click += new System.EventHandler(this.toolExcelExport_Click);
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
            // 
            // hotelSearchPanel1
            // 
            this.hotelSearchPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hotelSearchPanel1.BackColor = System.Drawing.Color.Transparent;
            this.hotelSearchPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelSearchPanel1.Location = new System.Drawing.Point(7, 42);
            this.hotelSearchPanel1.Name = "hotelSearchPanel1";
            this.hotelSearchPanel1.Size = new System.Drawing.Size(1104, 144);
            this.hotelSearchPanel1.TabIndex = 8;
            this.hotelSearchPanel1.searchnow += new RestoSys.Reports.HotelSearchPanel.serchNow(this.hotelSearchPanel1_searchnow);
            // 
            // RoomBookingView_Lst
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 666);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.hotelSearchPanel1);
            this.Name = "RoomBookingView_Lst";
            this.Text = "Booking Status Report";
            this.Load += new System.EventHandler(this.List_Load);
            this.Controls.SetChildIndex(this.hotelSearchPanel1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        } 



        #endregion

        private System.Windows.Forms.DataGridView grid;
 private System.Windows.Forms.DataGridViewTextBoxColumn colid;
 private System.Windows.Forms.DataGridViewTextBoxColumn colAccid;
 private System.Windows.Forms.DataGridViewTextBoxColumn colRoomName;
 private System.Windows.Forms.DataGridViewTextBoxColumn colRoomRate;
 private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
 private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
 private System.Windows.Forms.DataGridViewTextBoxColumn colstatus;
 private System.Windows.Forms.DataGridViewTextBoxColumn colindate;
 private System.Windows.Forms.DataGridViewTextBoxColumn coloutDate;
 private System.Windows.Forms.DataGridViewTextBoxColumn colBookinDate;
 private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
 private System.Windows.Forms.ToolStrip toolStrip1;
 private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
 private System.Windows.Forms.ToolStripButton ExportToolbar;
 private System.Windows.Forms.ToolStripButton toolAccountDetails;
 public RestoSys.Reports.HotelSearchPanel hotelSearchPanel1;
 
    }
}
