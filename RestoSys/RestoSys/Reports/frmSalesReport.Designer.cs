namespace RestoSys.Reports
{
    partial class frmSalesReport
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
            this.colfk_rackno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colquantity_sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalesRetrun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collistprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colentrydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalStandardCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this._closeButton.Location = new System.Drawing.Point(1136, 2);
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
            this.colfk_rackno,
            this.colCode,
            this.colName,
            this.colquantity_sold,
            this.colSalesRetrun,
            this.colTotalCost,
            this.collistprice,
            this.colAmount,
            this.colDiscount,
            this.colNetAmount,
            this.Profit,
            this.colUserId,
            this.colentrydate});
            this.grid.Location = new System.Drawing.Point(8, 195);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1155, 391);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 122;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            this.colId.Width = 44;
            // 
            // colfk_rackno
            // 
            this.colfk_rackno.HeaderText = "Rack No";
            this.colfk_rackno.Name = "colfk_rackno";
            this.colfk_rackno.Visible = false;
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
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 100;
            this.colName.Name = "colName";
            // 
            // colquantity_sold
            // 
            this.colquantity_sold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colquantity_sold.HeaderText = "Quantity Sold";
            this.colquantity_sold.Name = "colquantity_sold";
            this.colquantity_sold.Width = 118;
            // 
            // colSalesRetrun
            // 
            this.colSalesRetrun.HeaderText = "Sales Retrun";
            this.colSalesRetrun.Name = "colSalesRetrun";
            // 
            // colTotalCost
            // 
            this.colTotalCost.HeaderText = "Total Cost";
            this.colTotalCost.Name = "colTotalCost";
            // 
            // collistprice
            // 
            this.collistprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.collistprice.HeaderText = "MRP";
            this.collistprice.Name = "collistprice";
            this.collistprice.Width = 63;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAmount.HeaderText = "Gross Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 123;
            // 
            // colDiscount
            // 
            this.colDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Width = 88;
            // 
            // colNetAmount
            // 
            this.colNetAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNetAmount.HeaderText = "NetAmount";
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.Width = 103;
            // 
            // Profit
            // 
            this.Profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.Width = 66;
            // 
            // colUserId
            // 
            this.colUserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUserId.HeaderText = "User";
            this.colUserId.Name = "colUserId";
            this.colUserId.Width = 63;
            // 
            // colentrydate
            // 
            this.colentrydate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colentrydate.HeaderText = "Entrydate";
            this.colentrydate.Name = "colentrydate";
            this.colentrydate.Width = 94;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(617, 611);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 117;
            this.label3.Text = "= Total Profit:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProfit
            // 
            this.lblProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProfit.BackColor = System.Drawing.Color.Transparent;
            this.lblProfit.Location = new System.Drawing.Point(724, 611);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(149, 22);
            this.lblProfit.TabIndex = 117;
            this.lblProfit.Text = "---";
            this.lblProfit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(257, 589);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 22);
            this.label4.TabIndex = 117;
            this.label4.Text = "Total Gross Amount:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Location = new System.Drawing.Point(452, 590);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(149, 22);
            this.lblAmount.TabIndex = 117;
            this.lblAmount.Text = "---";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(848, 589);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 22);
            this.label5.TabIndex = 117;
            this.label5.Text = "Total Discount :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Location = new System.Drawing.Point(999, 590);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(149, 22);
            this.lblDiscount.TabIndex = 117;
            this.lblDiscount.Text = "---";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalStandardCost
            // 
            this.lblTotalStandardCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalStandardCost.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalStandardCost.Location = new System.Drawing.Point(452, 612);
            this.lblTotalStandardCost.Name = "lblTotalStandardCost";
            this.lblTotalStandardCost.Size = new System.Drawing.Size(149, 22);
            this.lblTotalStandardCost.TabIndex = 126;
            this.lblTotalStandardCost.Text = "---";
            this.lblTotalStandardCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(267, 611);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 22);
            this.label6.TabIndex = 125;
            this.label6.Text = "- Total Standard Cost :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.groupBox1.TabIndex = 0;
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
            // searchCriterion1
            // 
            this.searchCriterion1.BackColor = System.Drawing.Color.Transparent;
            this.searchCriterion1.Location = new System.Drawing.Point(6, 22);
            this.searchCriterion1.Name = "searchCriterion1";
            this.searchCriterion1.Size = new System.Drawing.Size(941, 129);
            this.searchCriterion1.TabIndex = 0;
            // 
            // frmSalesReport
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 648);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotalStandardCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid);
            this.Name = "frmSalesReport";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.frmSalesReport_Load);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblProfit, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblAmount, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblDiscount, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lblTotalStandardCost, 0);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalStandardCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private RestoSys.UserControls.SearchCriterion searchCriterion1;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExportToolbar;
        public bsoftcontrols.fsButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_rackno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colquantity_sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalesRetrun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn collistprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colentrydate;
    }
}
