namespace RestoSys.Reports
{
    partial class frmPurchaseReport
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchageDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_rackno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colquantity_sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colquantity_damage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpurchaseReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalesReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConsumed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new bsoftcontrols.fsButton();
            this.searchCriterion1 = new RestoSys.UserControls.SearchCriterion();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.colPurchageDate,
            this.colGroup,
            this.colCompany,
            this.colcost,
            this.colmrp,
            this.colfk_rackno,
            this.colstock,
            this.colQuantity,
            this.colquantity_sold,
            this.colquantity_damage,
            this.colpurchaseReturn,
            this.colSalesReturn,
            this.colConsumed,
            this.colVendorName});
            this.grid.Location = new System.Drawing.Point(12, 190);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1094, 405);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 121;
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
            // colPurchageDate
            // 
            this.colPurchageDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPurchageDate.HeaderText = "Purchase Date";
            this.colPurchageDate.Name = "colPurchageDate";
            this.colPurchageDate.Width = 116;
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
            // colcost
            // 
            this.colcost.HeaderText = "Cost";
            this.colcost.Name = "colcost";
            // 
            // colmrp
            // 
            this.colmrp.HeaderText = "MRP";
            this.colmrp.Name = "colmrp";
            // 
            // colfk_rackno
            // 
            this.colfk_rackno.HeaderText = "Rack No";
            this.colfk_rackno.Name = "colfk_rackno";
            this.colfk_rackno.Visible = false;
            // 
            // colstock
            // 
            this.colstock.HeaderText = "Stock";
            this.colstock.Name = "colstock";
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Qty Purchased";
            this.colQuantity.Name = "colQuantity";
            // 
            // colquantity_sold
            // 
            this.colquantity_sold.HeaderText = "Qty Sold";
            this.colquantity_sold.Name = "colquantity_sold";
            // 
            // colquantity_damage
            // 
            this.colquantity_damage.HeaderText = "Damage Quantity";
            this.colquantity_damage.Name = "colquantity_damage";
            // 
            // colpurchaseReturn
            // 
            this.colpurchaseReturn.HeaderText = "Purchase Return";
            this.colpurchaseReturn.Name = "colpurchaseReturn";
            // 
            // colSalesReturn
            // 
            this.colSalesReturn.HeaderText = "Sales Return";
            this.colSalesReturn.Name = "colSalesReturn";
            // 
            // colConsumed
            // 
            this.colConsumed.HeaderText = "Consumed";
            this.colConsumed.Name = "colConsumed";
            // 
            // colVendorName
            // 
            this.colVendorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colVendorName.HeaderText = "Vendor Name";
            this.colVendorName.Name = "colVendorName";
            this.colVendorName.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.searchCriterion1);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 148);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Generation Search Conditions";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportToolbar});
            this.toolStrip1.Location = new System.Drawing.Point(968, 22);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(71, 63);
            this.toolStrip1.TabIndex = 123;
            this.toolStrip1.TabStop = true;
            // 
            // ExportToolbar
            // 
            this.ExportToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportToolbar.Image = global::RestoSys.Properties.Resources.MS_Excel1;
            this.ExportToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToolbar.Name = "ExportToolbar";
            this.ExportToolbar.Size = new System.Drawing.Size(69, 60);
            this.ExportToolbar.Text = "E&xport";
            this.ExportToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExportToolbar.Click += new System.EventHandler(this.ExportToolbar_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Location = new System.Drawing.Point(968, 102);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 33);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.ThemeColor = System.Drawing.Color.Blue;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchCriterion1
            // 
            this.searchCriterion1.BackColor = System.Drawing.Color.Transparent;
            this.searchCriterion1.Location = new System.Drawing.Point(6, 22);
            this.searchCriterion1.Name = "searchCriterion1";
            this.searchCriterion1.Size = new System.Drawing.Size(941, 129);
            this.searchCriterion1.TabIndex = 0;
            // 
            // frmPurchaseReport
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid);
            this.Name = "frmPurchaseReport";
            this.Text = "Product Report";
            this.Load += new System.EventHandler(this.frmproductrpt_Load);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private RestoSys.UserControls.SearchCriterion searchCriterion1;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExportToolbar;
        public bsoftcontrols.fsButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchageDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_rackno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colquantity_sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colquantity_damage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpurchaseReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalesReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConsumed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendorName;
    }
}
