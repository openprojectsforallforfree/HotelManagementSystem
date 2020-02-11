namespace RestoSys.MasterEntry
{
    partial class frmProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolbar = new System.Windows.Forms.ToolStripButton();
            this.EditToolbar = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.ExitToolbar = new System.Windows.Forms.ToolStripButton();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.lblfk_Company = new System.Windows.Forms.Label();
            this.lblfk_Group = new System.Windows.Forms.Label();
            this.btnSearch = new bsoftcontrols.fsButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnOk = new bsoftcontrols.fsButton();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsizeunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colweightunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colreorderpoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLatestCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLatestSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colquantity_instore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colquantity_sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colquantity_damage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colquantity_lost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colentrydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(1017, 2);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 59);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolbar,
            this.EditToolbar,
            this.DeleteToolbar,
            this.toolStripSeparator1,
            this.ExportToolbar,
            this.toolStripSeparator2,
            this.ExitToolbar});
            this.toolStrip1.Location = new System.Drawing.Point(13, 34);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(1022, 59);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.TabStop = true;
            // 
            // newToolbar
            // 
            this.newToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newToolbar.Image = ((System.Drawing.Image)(resources.GetObject("newToolbar.Image")));
            this.newToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolbar.Name = "newToolbar";
            this.newToolbar.Size = new System.Drawing.Size(53, 56);
            this.newToolbar.Text = "&New";
            this.newToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newToolbar.Click += new System.EventHandler(this.newToolbar_Click);
            // 
            // EditToolbar
            // 
            this.EditToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditToolbar.Image = ((System.Drawing.Image)(resources.GetObject("EditToolbar.Image")));
            this.EditToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolbar.Name = "EditToolbar";
            this.EditToolbar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.EditToolbar.Size = new System.Drawing.Size(46, 56);
            this.EditToolbar.Text = "&Edit";
            this.EditToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditToolbar.Click += new System.EventHandler(this.EditToolbar_Click);
            // 
            // DeleteToolbar
            // 
            this.DeleteToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteToolbar.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolbar.Image")));
            this.DeleteToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolbar.Name = "DeleteToolbar";
            this.DeleteToolbar.Size = new System.Drawing.Size(68, 56);
            this.DeleteToolbar.Text = "&Delete";
            this.DeleteToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteToolbar.Click += new System.EventHandler(this.DeleteToolbar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 59);
            // 
            // ExportToolbar
            // 
            this.ExportToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportToolbar.Image = global::RestoSys.Properties.Resources.MS_Excel1;
            this.ExportToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToolbar.Name = "ExportToolbar";
            this.ExportToolbar.Size = new System.Drawing.Size(69, 56);
            this.ExportToolbar.Text = "E&xport";
            this.ExportToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExportToolbar.Click += new System.EventHandler(this.ExportToolbar_Click);
            // 
            // ExitToolbar
            // 
            this.ExitToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitToolbar.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolbar.Image")));
            this.ExitToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitToolbar.Name = "ExitToolbar";
            this.ExitToolbar.Size = new System.Drawing.Size(62, 56);
            this.ExitToolbar.Text = "&Close";
            this.ExitToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitToolbar.Click += new System.EventHandler(this.ExitToolbar_Click_1);
            // 
            // cboCompany
            // 
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(724, 21);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(160, 24);
            this.cboCompany.TabIndex = 119;
            this.cboCompany.Visible = false;
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(443, 20);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(160, 24);
            this.cboGroup.TabIndex = 118;
            // 
            // lblfk_Company
            // 
            this.lblfk_Company.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Company.Location = new System.Drawing.Point(614, 22);
            this.lblfk_Company.Name = "lblfk_Company";
            this.lblfk_Company.Size = new System.Drawing.Size(89, 22);
            this.lblfk_Company.TabIndex = 116;
            this.lblfk_Company.Text = "Company:";
            this.lblfk_Company.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblfk_Company.Visible = false;
            // 
            // lblfk_Group
            // 
            this.lblfk_Group.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Group.Location = new System.Drawing.Point(333, 20);
            this.lblfk_Group.Name = "lblfk_Group";
            this.lblfk_Group.Size = new System.Drawing.Size(89, 22);
            this.lblfk_Group.TabIndex = 117;
            this.lblfk_Group.Text = "Group:";
            this.lblfk_Group.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Location = new System.Drawing.Point(927, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 33);
            this.btnSearch.TabIndex = 115;
            this.btnSearch.Text = "Search";
            this.btnSearch.ThemeColor = System.Drawing.Color.Blue;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblfk_Group);
            this.groupBox1.Controls.Add(this.cboCompany);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboGroup);
            this.groupBox1.Controls.Add(this.lblfk_Company);
            this.groupBox1.Location = new System.Drawing.Point(13, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 65);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 23);
            this.txtName.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(15, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 116;
            this.label6.Text = "Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCode,
            this.colName,
            this.colfk_Group,
            this.colfk_Company,
            this.colsizeunit,
            this.colweightunit,
            this.colcolour,
            this.colweight,
            this.colsize,
            this.colreorderpoint,
            this.colLatestCP,
            this.colLatestSP,
            this.colRemarks,
            this.colquantity_instore,
            this.colquantity_sold,
            this.colquantity_damage,
            this.colquantity_lost,
            this.colUserId,
            this.colentrydate});
            this.grid.Location = new System.Drawing.Point(7, 167);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1034, 441);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(502, 611);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(63, 33);
            this.btnOk.TabIndex = 122;
            this.btnOk.Text = "Ok";
            this.btnOk.ThemeColor = System.Drawing.Color.Blue;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            this.colId.Width = 44;
            // 
            // colCode
            // 
            this.colCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Width = 66;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 70;
            // 
            // colfk_Group
            // 
            this.colfk_Group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colfk_Group.HeaderText = "Group";
            this.colfk_Group.Name = "colfk_Group";
            this.colfk_Group.Width = 73;
            // 
            // colfk_Company
            // 
            this.colfk_Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colfk_Company.HeaderText = "Company";
            this.colfk_Company.Name = "colfk_Company";
            this.colfk_Company.Visible = false;
            this.colfk_Company.Width = 92;
            // 
            // colsizeunit
            // 
            this.colsizeunit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colsizeunit.HeaderText = "Size Unit";
            this.colsizeunit.Name = "colsizeunit";
            this.colsizeunit.Visible = false;
            this.colsizeunit.Width = 89;
            // 
            // colweightunit
            // 
            this.colweightunit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colweightunit.HeaderText = "Weight Unit";
            this.colweightunit.Name = "colweightunit";
            this.colweightunit.Visible = false;
            this.colweightunit.Width = 106;
            // 
            // colcolour
            // 
            this.colcolour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colcolour.HeaderText = "Colour";
            this.colcolour.Name = "colcolour";
            this.colcolour.Width = 74;
            // 
            // colweight
            // 
            this.colweight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colweight.HeaderText = "Weight";
            this.colweight.Name = "colweight";
            this.colweight.Width = 77;
            // 
            // colsize
            // 
            this.colsize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colsize.HeaderText = "Size";
            this.colsize.Name = "colsize";
            this.colsize.Width = 60;
            // 
            // colreorderpoint
            // 
            this.colreorderpoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colreorderpoint.HeaderText = "Reorderpoint";
            this.colreorderpoint.Name = "colreorderpoint";
            this.colreorderpoint.Visible = false;
            this.colreorderpoint.Width = 116;
            // 
            // colLatestCP
            // 
            this.colLatestCP.HeaderText = "Latest CP";
            this.colLatestCP.Name = "colLatestCP";
            // 
            // colLatestSP
            // 
            this.colLatestSP.HeaderText = "Latest SP";
            this.colLatestSP.Name = "colLatestSP";
            // 
            // colRemarks
            // 
            this.colRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemarks.HeaderText = "Remarks";
            this.colRemarks.Name = "colRemarks";
            // 
            // colquantity_instore
            // 
            this.colquantity_instore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colquantity_instore.HeaderText = "Quantity In Store";
            this.colquantity_instore.Name = "colquantity_instore";
            this.colquantity_instore.Visible = false;
            this.colquantity_instore.Width = 139;
            // 
            // colquantity_sold
            // 
            this.colquantity_sold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colquantity_sold.HeaderText = "Quantity Sold";
            this.colquantity_sold.Name = "colquantity_sold";
            this.colquantity_sold.Visible = false;
            this.colquantity_sold.Width = 118;
            // 
            // colquantity_damage
            // 
            this.colquantity_damage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colquantity_damage.HeaderText = "Damage Quantity";
            this.colquantity_damage.Name = "colquantity_damage";
            this.colquantity_damage.Visible = false;
            this.colquantity_damage.Width = 143;
            // 
            // colquantity_lost
            // 
            this.colquantity_lost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colquantity_lost.HeaderText = "Lost Quantity";
            this.colquantity_lost.Name = "colquantity_lost";
            this.colquantity_lost.Visible = false;
            this.colquantity_lost.Width = 117;
            // 
            // colUserId
            // 
            this.colUserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUserId.HeaderText = "User";
            this.colUserId.Name = "colUserId";
            this.colUserId.Visible = false;
            this.colUserId.Width = 63;
            // 
            // colentrydate
            // 
            this.colentrydate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colentrydate.HeaderText = "Entrydate";
            this.colentrydate.Name = "colentrydate";
            this.colentrydate.Visible = false;
            this.colentrydate.Width = 94;
            // 
            // frmProductList
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 649);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnOk);
            this.Name = "frmProductList";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.frmProductList_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton newToolbar;
        private System.Windows.Forms.ToolStripButton EditToolbar;
        private System.Windows.Forms.ToolStripButton DeleteToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ExportToolbar;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Label lblfk_Company;
        private System.Windows.Forms.Label lblfk_Group;
        public bsoftcontrols.fsButton btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label6;
        public bsoftcontrols.fsButton btnOk;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStripButton ExitToolbar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsizeunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colweightunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colreorderpoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLatestCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLatestSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colquantity_instore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colquantity_sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colquantity_damage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colquantity_lost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colentrydate;
      

    }
}
