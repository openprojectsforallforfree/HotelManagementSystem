namespace UEMS 
{
    partial class Bookings_Lst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookings_Lst));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolbar = new System.Windows.Forms.ToolStripButton();
            this.EditToolbar = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.gridBooking = new System.Windows.Forms.DataGridView();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHotel_RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbookingstaus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldueamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoofPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colindate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcancelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Master_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Hotel_Master_Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBooking = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooking)).BeginInit();
            this.panelBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(1075, 2);
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
            this.toolStrip1.Location = new System.Drawing.Point(5, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(892, 60);
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
            this.newToolbar.Text = "&Add";
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
            // gridBooking
            // 
            this.gridBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerName,
            this.colHotel_RoomName,
            this.colbookingstaus,
            this.colRate,
            this.colQuantity,
            this.colNetAmount,
            this.colPaid,
            this.coldueamt,
            this.colNoofPerson,
            this.colindate,
            this.coloutDate,
            this.colamount,
            this.coldiscount,
            this.colServiceCharge,
            this.colVAT,
            this.colcancelDate,
            this.colRemarks,
            this.colUser,
            this.colDate,
            this.colid,
            this.colfk_Master_Customer,
            this.colfk_Hotel_Master_Room});
            this.gridBooking.Location = new System.Drawing.Point(5, 97);
            this.gridBooking.Name = "gridBooking";
            this.gridBooking.Size = new System.Drawing.Size(892, 457);
            this.gridBooking.StandardTab = true;
            this.gridBooking.TabIndex = 4;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Frozen = true;
            this.colCustomerName.HeaderText = "Customer Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = false;
            this.colCustomerName.Width = 134;
            // 
            // colHotel_RoomName
            // 
            this.colHotel_RoomName.Frozen = true;
            this.colHotel_RoomName.HeaderText = "Room";
            this.colHotel_RoomName.Name = "colHotel_RoomName";
            this.colHotel_RoomName.Width = 70;
            // 
            // colbookingstaus
            // 
            this.colbookingstaus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colbookingstaus.HeaderText = "Booking Staus";
            this.colbookingstaus.Name = "colbookingstaus";
            this.colbookingstaus.Width = 124;
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
            this.colQuantity.HeaderText = "PAX";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 60;
            // 
            // colNetAmount
            // 
            this.colNetAmount.HeaderText = "NetAmount";
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.Width = 103;
            // 
            // colPaid
            // 
            this.colPaid.HeaderText = "Paid Amount";
            this.colPaid.Name = "colPaid";
            this.colPaid.Width = 113;
            // 
            // coldueamt
            // 
            this.coldueamt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coldueamt.HeaderText = "Due Amount";
            this.coldueamt.Name = "coldueamt";
            this.coldueamt.Width = 111;
            // 
            // colNoofPerson
            // 
            this.colNoofPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNoofPerson.HeaderText = "No of Person";
            this.colNoofPerson.Name = "colNoofPerson";
            this.colNoofPerson.Width = 116;
            // 
            // colindate
            // 
            this.colindate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colindate.HeaderText = "In Date";
            this.colindate.Name = "colindate";
            this.colindate.Width = 78;
            // 
            // coloutDate
            // 
            this.coloutDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coloutDate.HeaderText = "Out Date";
            this.coloutDate.Name = "coloutDate";
            this.coloutDate.Width = 90;
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
            // colServiceCharge
            // 
            this.colServiceCharge.HeaderText = "ServiceCharge";
            this.colServiceCharge.Name = "colServiceCharge";
            this.colServiceCharge.Width = 126;
            // 
            // colVAT
            // 
            this.colVAT.HeaderText = "VAT";
            this.colVAT.Name = "colVAT";
            this.colVAT.Width = 60;
            // 
            // colcancelDate
            // 
            this.colcancelDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colcancelDate.HeaderText = "Cancel Date";
            this.colcancelDate.Name = "colcancelDate";
            this.colcancelDate.Width = 110;
            // 
            // colRemarks
            // 
            this.colRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRemarks.HeaderText = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Width = 89;
            // 
            // colUser
            // 
            this.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUser.HeaderText = "User";
            this.colUser.Name = "colUser";
            this.colUser.Width = 63;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDate.HeaderText = "Entry Date";
            this.colDate.Name = "colDate";
            // 
            // colid
            // 
            this.colid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colid.HeaderText = "Id";
            this.colid.Name = "colid";
            this.colid.Visible = false;
            // 
            // colfk_Master_Customer
            // 
            this.colfk_Master_Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colfk_Master_Customer.HeaderText = "Customer";
            this.colfk_Master_Customer.Name = "colfk_Master_Customer";
            this.colfk_Master_Customer.Visible = false;
            // 
            // colfk_Hotel_Master_Room
            // 
            this.colfk_Hotel_Master_Room.HeaderText = "fk_Hotel_Master_Room";
            this.colfk_Hotel_Master_Room.Name = "colfk_Hotel_Master_Room";
            this.colfk_Hotel_Master_Room.Visible = false;
            this.colfk_Hotel_Master_Room.Width = 181;
            // 
            // panelBooking
            // 
            this.panelBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBooking.BackColor = System.Drawing.Color.Transparent;
            this.panelBooking.Controls.Add(this.lblCustomer);
            this.panelBooking.Controls.Add(this.gridBooking);
            this.panelBooking.Controls.Add(this.toolStrip1);
            this.panelBooking.Location = new System.Drawing.Point(5, 2);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(900, 567);
            this.panelBooking.TabIndex = 12;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(5, 65);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(68, 17);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "Customer";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Bookings_Lst
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1109, 601);
            this.Controls.Add(this.panelBooking);
            this.Name = "Bookings_Lst";
            this.Text = " List";
            this.Load += new System.EventHandler(this.List_Load);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.panelBooking, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooking)).EndInit();
            this.panelBooking.ResumeLayout(false);
            this.panelBooking.PerformLayout();
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
        private System.Windows.Forms.Label lblCustomer;
        public System.Windows.Forms.DataGridView gridBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHotel_RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbookingstaus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldueamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoofPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colindate;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcancelDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_Master_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_Hotel_Master_Room;
 
    }
}
