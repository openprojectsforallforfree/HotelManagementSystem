namespace RestoSys.Reports
{
    partial class frmStockrpt
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
            this.btnSearch = new bsoftcontrols.fsButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.lblStockCost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStockSP = new System.Windows.Forms.Label();
            this.lblStockMRP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchCriterion1 = new RestoSys.UserControls.SearchCriterion();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalQuantityPurchaged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchageReturns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalesReturns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDamaged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalStockCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotlStockMRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(1085, 2);
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
            this.colCode,
            this.colProductName,
            this.colCompany,
            this.colGroup,
            this.colTotalQuantityPurchaged,
            this.colPurchageReturns,
            this.colSold,
            this.colSalesReturns,
            this.colDamaged,
            this.colLost,
            this.colstock,
            this.colTotalStockCost,
            this.colTotlStockMRP});
            this.grid.Location = new System.Drawing.Point(9, 197);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1094, 353);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 121;
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
            // lblStockCost
            // 
            this.lblStockCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStockCost.BackColor = System.Drawing.Color.Transparent;
            this.lblStockCost.Location = new System.Drawing.Point(662, 560);
            this.lblStockCost.Name = "lblStockCost";
            this.lblStockCost.Size = new System.Drawing.Size(149, 22);
            this.lblStockCost.TabIndex = 125;
            this.lblStockCost.Text = "---";
            this.lblStockCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(462, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 22);
            this.label5.TabIndex = 124;
            this.label5.Text = "Total Stock Cost Price :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStockSP
            // 
            this.lblStockSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStockSP.BackColor = System.Drawing.Color.Transparent;
            this.lblStockSP.Location = new System.Drawing.Point(461, 584);
            this.lblStockSP.Name = "lblStockSP";
            this.lblStockSP.Size = new System.Drawing.Size(193, 22);
            this.lblStockSP.TabIndex = 124;
            this.lblStockSP.Text = "Total Stock Selling Price :";
            this.lblStockSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStockMRP
            // 
            this.lblStockMRP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStockMRP.BackColor = System.Drawing.Color.Transparent;
            this.lblStockMRP.Location = new System.Drawing.Point(661, 584);
            this.lblStockMRP.Name = "lblStockMRP";
            this.lblStockMRP.Size = new System.Drawing.Size(149, 22);
            this.lblStockMRP.TabIndex = 125;
            this.lblStockMRP.Text = "---";
            this.lblStockMRP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.searchCriterion1);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(9, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 148);
            this.groupBox1.TabIndex = 0;
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
            // colCode
            // 
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProductName.HeaderText = "Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.Width = 70;
            // 
            // colCompany
            // 
            this.colCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCompany.HeaderText = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.Width = 92;
            // 
            // colGroup
            // 
            this.colGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGroup.HeaderText = "Group";
            this.colGroup.Name = "colGroup";
            this.colGroup.Width = 73;
            // 
            // colTotalQuantityPurchaged
            // 
            this.colTotalQuantityPurchaged.HeaderText = "Purchase Qty";
            this.colTotalQuantityPurchaged.Name = "colTotalQuantityPurchaged";
            // 
            // colPurchageReturns
            // 
            this.colPurchageReturns.HeaderText = "Purchase Return Qty";
            this.colPurchageReturns.Name = "colPurchageReturns";
            // 
            // colSold
            // 
            this.colSold.HeaderText = "Sold Qty";
            this.colSold.Name = "colSold";
            // 
            // colSalesReturns
            // 
            this.colSalesReturns.HeaderText = "Sales Return Qty";
            this.colSalesReturns.Name = "colSalesReturns";
            // 
            // colDamaged
            // 
            this.colDamaged.HeaderText = "Damaged Qty";
            this.colDamaged.Name = "colDamaged";
            // 
            // colLost
            // 
            this.colLost.HeaderText = "Lost Qty";
            this.colLost.Name = "colLost";
            // 
            // colstock
            // 
            this.colstock.HeaderText = "Stock Qty";
            this.colstock.Name = "colstock";
            // 
            // colTotalStockCost
            // 
            this.colTotalStockCost.HeaderText = "Stock Cost";
            this.colTotalStockCost.Name = "colTotalStockCost";
            this.colTotalStockCost.Visible = false;
            // 
            // colTotlStockMRP
            // 
            this.colTotlStockMRP.HeaderText = "Total MRP";
            this.colTotlStockMRP.Name = "colTotlStockMRP";
            this.colTotlStockMRP.Visible = false;
            // 
            // frmStockrpt
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 648);
            this.Controls.Add(this.lblStockMRP);
            this.Controls.Add(this.lblStockSP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStockCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grid);
            this.Name = "frmStockrpt";
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.frmproductSumrpt_Load);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblStockCost, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblStockSP, 0);
            this.Controls.SetChildIndex(this.lblStockMRP, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public bsoftcontrols.fsButton btnSearch;
        private System.Windows.Forms.DataGridView grid;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExportToolbar;
        private System.Windows.Forms.Label lblStockCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStockSP;
        private System.Windows.Forms.Label lblStockMRP;
        private RestoSys.UserControls.SearchCriterion searchCriterion1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalQuantityPurchaged;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchageReturns;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalesReturns;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDamaged;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalStockCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotlStockMRP;












    }
}
