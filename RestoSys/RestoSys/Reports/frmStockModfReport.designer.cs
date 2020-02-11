namespace RestoSys.Reports
{
    partial class frmStockModfReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockModfReport));
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchCriterion1 = new RestoSys.UserControls.SearchCriterion();
            this.btnSearch = new bsoftcontrols.fsButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.newToolbar = new System.Windows.Forms.ToolStripButton();
            this.EditToolbar = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExcelExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(1085, 2);
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
            this.colEntryDate,
            this.colGroup,
            this.colCompany,
            this.colquantity,
            this.colUser,
            this.colRemarks});
            this.grid.Location = new System.Drawing.Point(12, 256);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1094, 339);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 121;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 100;
            this.colName.Name = "colName";
            // 
            // colEntryDate
            // 
            this.colEntryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEntryDate.HeaderText = "Entry Date";
            this.colEntryDate.Name = "colEntryDate";
            // 
            // colGroup
            // 
            this.colGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGroup.FillWeight = 200F;
            this.colGroup.HeaderText = "Group";
            this.colGroup.MinimumWidth = 100;
            this.colGroup.Name = "colGroup";
            // 
            // colCompany
            // 
            this.colCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCompany.HeaderText = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.Width = 92;
            // 
            // colquantity
            // 
            this.colquantity.HeaderText = "Quantity";
            this.colquantity.Name = "colquantity";
            // 
            // colUser
            // 
            this.colUser.HeaderText = "User";
            this.colUser.Name = "colUser";
            // 
            // colRemarks
            // 
            this.colRemarks.HeaderText = "Remarks";
            this.colRemarks.Name = "colRemarks";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.searchCriterion1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 148);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Generation Search Conditions";
            // 
            // searchCriterion1
            // 
            this.searchCriterion1.BackColor = System.Drawing.Color.Transparent;
            this.searchCriterion1.Location = new System.Drawing.Point(6, 22);
            this.searchCriterion1.Name = "searchCriterion1";
            this.searchCriterion1.Size = new System.Drawing.Size(941, 129);
            this.searchCriterion1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Location = new System.Drawing.Point(968, 91);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 33);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.ThemeColor = System.Drawing.Color.Blue;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolbar,
            this.EditToolbar,
            this.DeleteToolbar,
            this.toolStripSeparator1,
            this.toolExcelExport,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(18, 39);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.ShowItemToolTips = false;
            this.toolStrip2.Size = new System.Drawing.Size(1093, 60);
            this.toolStrip2.TabIndex = 129;
            this.toolStrip2.TabStop = true;
            // 
            // newToolbar
            // 
            this.newToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newToolbar.Image = ((System.Drawing.Image)(resources.GetObject("newToolbar.Image")));
            this.newToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolbar.Name = "newToolbar";
            this.newToolbar.Size = new System.Drawing.Size(53, 57);
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
            this.EditToolbar.Size = new System.Drawing.Size(46, 57);
            this.EditToolbar.Text = "&Edit";
            this.EditToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditToolbar.Visible = false;
            // 
            // DeleteToolbar
            // 
            this.DeleteToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteToolbar.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolbar.Image")));
            this.DeleteToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolbar.Name = "DeleteToolbar";
            this.DeleteToolbar.Size = new System.Drawing.Size(68, 57);
            this.DeleteToolbar.Text = "&Delete";
            this.DeleteToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteToolbar.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // toolExcelExport
            // 
            this.toolExcelExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolExcelExport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolExcelExport.Image = global::RestoSys.Properties.Resources.MS_Excel1;
            this.toolExcelExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExcelExport.Name = "toolExcelExport";
            this.toolExcelExport.Size = new System.Drawing.Size(69, 57);
            this.toolExcelExport.Text = "E&xport";
            this.toolExcelExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolExcelExport.Click += new System.EventHandler(this.toolExcelExport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            this.toolStripSeparator2.Visible = false;
            // 
            // frmStockModfReport
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 604);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid);
            this.Name = "frmStockModfReport";
            this.Text = "Product Report";
            this.Load += new System.EventHandler(this.frmproductrpt_Load);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.toolStrip2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private RestoSys.UserControls.SearchCriterion searchCriterion1;
        public bsoftcontrols.fsButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        public System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton newToolbar;
        private System.Windows.Forms.ToolStripButton EditToolbar;
        private System.Windows.Forms.ToolStripButton DeleteToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolExcelExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
