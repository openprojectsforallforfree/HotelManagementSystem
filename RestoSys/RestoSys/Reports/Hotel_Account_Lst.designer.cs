namespace UEMS 
{
    partial class Hotel_Account_Lst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel_Account_Lst));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolAccount = new System.Windows.Forms.ToolStripButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.lblCollectionSum = new System.Windows.Forms.Label();
            this.dateFromTo21 = new Bsoft.Controls.DateFromTo2();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCollection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Master_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(887, 2);
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
            this.ExportToolbar,
            this.toolAccount});
            this.toolStrip1.Location = new System.Drawing.Point(833, 37);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(79, 60);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.TabStop = true;
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
            // toolAccount
            // 
            this.toolAccount.AutoSize = false;
            this.toolAccount.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolAccount.Image = global::RestoSys.Properties.Resources.cash;
            this.toolAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAccount.Name = "toolAccount";
            this.toolAccount.Size = new System.Drawing.Size(60, 60);
            this.toolAccount.Text = "Detail";
            this.toolAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolAccount.Visible = false;
            this.toolAccount.Click += new System.EventHandler(this.toolAccount_Click);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.colCustomer,
            this.colLastName,
            this.colAmount,
            this.colPaidAmount,
            this.colReturnAmount,
            this.colTenderAmount,
            this.colCollection,
            this.colDate,
            this.colUser,
            this.colfk_Master_Customer});
            this.grid.Location = new System.Drawing.Point(1, 129);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(918, 406);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 4;
            // 
            // lblCollectionSum
            // 
            this.lblCollectionSum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCollectionSum.BackColor = System.Drawing.Color.Transparent;
            this.lblCollectionSum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCollectionSum.Location = new System.Drawing.Point(52, 538);
            this.lblCollectionSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCollectionSum.Name = "lblCollectionSum";
            this.lblCollectionSum.Size = new System.Drawing.Size(803, 54);
            this.lblCollectionSum.TabIndex = 22;
            this.lblCollectionSum.Text = "Sum Collected  = Rs.";
            this.lblCollectionSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateFromTo21
            // 
            this.dateFromTo21.BackColor = System.Drawing.Color.Transparent;
            this.dateFromTo21.Location = new System.Drawing.Point(15, 12);
            this.dateFromTo21.Margin = new System.Windows.Forms.Padding(4);
            this.dateFromTo21.Name = "dateFromTo21";
            this.dateFromTo21.Size = new System.Drawing.Size(486, 37);
            this.dateFromTo21.TabIndex = 23;
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(671, 52);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(129, 24);
            this.cboUser.TabIndex = 25;
            this.cboUser.SelectedIndexChanged += new System.EventHandler(this.cboUser_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(619, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "User:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtBillNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateFromTo21);
            this.groupBox1.Controls.Add(this.cboUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 86);
            this.groupBox1.TabIndex = 132;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Generation Search Conditions";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(412, 52);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 23);
            this.txtCustomerName.TabIndex = 145;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(273, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 22);
            this.label6.TabIndex = 146;
            this.label6.Text = "Customer Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colid
            // 
            this.colid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colid.HeaderText = "Bill No.";
            this.colid.Name = "colid";
            this.colid.Width = 77;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer Name";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Width = 134;
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.Width = 101;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAmount.HeaderText = "Due";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 59;
            // 
            // colPaidAmount
            // 
            this.colPaidAmount.HeaderText = "Paid Amount";
            this.colPaidAmount.Name = "colPaidAmount";
            this.colPaidAmount.Width = 113;
            // 
            // colReturnAmount
            // 
            this.colReturnAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colReturnAmount.HeaderText = "Return";
            this.colReturnAmount.Name = "colReturnAmount";
            this.colReturnAmount.Visible = false;
            this.colReturnAmount.Width = 76;
            // 
            // colTenderAmount
            // 
            this.colTenderAmount.HeaderText = "Tender";
            this.colTenderAmount.Name = "colTenderAmount";
            this.colTenderAmount.Visible = false;
            this.colTenderAmount.Width = 79;
            // 
            // colCollection
            // 
            this.colCollection.HeaderText = "Collection";
            this.colCollection.Name = "colCollection";
            this.colCollection.Visible = false;
            this.colCollection.Width = 94;
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
            // colfk_Master_Customer
            // 
            this.colfk_Master_Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colfk_Master_Customer.HeaderText = "fk_Master_Customer";
            this.colfk_Master_Customer.Name = "colfk_Master_Customer";
            this.colfk_Master_Customer.Visible = false;
            this.colfk_Master_Customer.Width = 163;
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(124, 52);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(137, 23);
            this.txtBillNo.TabIndex = 147;
            this.txtBillNo.TextChanged += new System.EventHandler(this.txtBillNo_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 148;
            this.label1.Text = "Bill No.:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Hotel_Account_Lst
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCollectionSum);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grid);
            this.Name = "Hotel_Account_Lst";
            this.Text = "Day Book";
            this.Load += new System.EventHandler(this.Hotel_Account_Lst_Load);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.lblCollectionSum, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        } 



        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExportToolbar;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label lblCollectionSum;
        private Bsoft.Controls.DateFromTo2 dateFromTo21;
        public System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCollection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_Master_Customer;
        public System.Windows.Forms.TextBox txtBillNo;
        public System.Windows.Forms.Label label1;
 
    }
}
