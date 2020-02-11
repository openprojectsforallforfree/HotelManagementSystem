namespace UEMS
{
    partial class frmAccountGroupList
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolbar = new System.Windows.Forms.ToolStripButton();
            this.EditToolbar = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolbar = new System.Windows.Forms.ToolStripButton();
            this.tlbTreeView = new System.Windows.Forms.ToolStripButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBehavesLikeSubLedger = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDebitcreditBalanceforReporting = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUsedforCalculations = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(873, 2);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
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
            this.ExportToolbar,
            this.toolStripSeparator2,
            this.ExitToolbar,
            this.tlbTreeView});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(907, 58);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.TabStop = true;
            // 
            // newToolbar
            // 
            this.newToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolbar.Name = "newToolbar";
            this.newToolbar.Size = new System.Drawing.Size(53, 55);
            this.newToolbar.Text = "&New";
            this.newToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newToolbar.Click += new System.EventHandler(this.newToolbar_Click);
            // 
            // EditToolbar
            // 
            this.EditToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolbar.Name = "EditToolbar";
            this.EditToolbar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.EditToolbar.Size = new System.Drawing.Size(46, 55);
            this.EditToolbar.Text = "&Edit";
            this.EditToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditToolbar.Click += new System.EventHandler(this.EditToolbar_Click);
            // 
            // DeleteToolbar
            // 
            this.DeleteToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolbar.Name = "DeleteToolbar";
            this.DeleteToolbar.Size = new System.Drawing.Size(68, 55);
            this.DeleteToolbar.Text = "&Delete";
            this.DeleteToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteToolbar.Click += new System.EventHandler(this.DeleteToolbar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // ExportToolbar
            // 
            this.ExportToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToolbar.Name = "ExportToolbar";
            this.ExportToolbar.Size = new System.Drawing.Size(69, 55);
            this.ExportToolbar.Text = "E&xport";
            this.ExportToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExportToolbar.Click += new System.EventHandler(this.ExportToolbar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // ExitToolbar
            // 
            this.ExitToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitToolbar.Image = global::UEMS.Properties.Resources.close;
            this.ExitToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitToolbar.Name = "ExitToolbar";
            this.ExitToolbar.Size = new System.Drawing.Size(62, 55);
            this.ExitToolbar.Text = "&Close";
            this.ExitToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitToolbar.Click += new System.EventHandler(this.ExitToolbar_Click);
            // 
            // tlbTreeView
            // 
            this.tlbTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlbTreeView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlbTreeView.Image = global::UEMS.Properties.Resources.tick;
            this.tlbTreeView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbTreeView.Name = "tlbTreeView";
            this.tlbTreeView.Size = new System.Drawing.Size(54, 55);
            this.tlbTreeView.Text = "&Tree";
            this.tlbTreeView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlbTreeView.Click += new System.EventHandler(this.tlbTreeView_Click);
            // 
            // grid
            // 
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colParentId,
            this.colName,
            this.colDescription,
            this.colBehavesLikeSubLedger,
            this.colDebitcreditBalanceforReporting,
            this.colUsedforCalculations,
            this.colAlias});
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 98);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(907, 429);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 4;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 49;
            // 
            // colParentId
            // 
            this.colParentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colParentId.HeaderText = "ParentAccount";
            this.colParentId.Name = "colParentId";
            this.colParentId.Width = 130;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colName.HeaderText = "Account Name";
            this.colName.Name = "colName";
            this.colName.Width = 133;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 107;
            // 
            // colBehavesLikeSubLedger
            // 
            this.colBehavesLikeSubLedger.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colBehavesLikeSubLedger.DefaultCellStyle = dataGridViewCellStyle1;
            this.colBehavesLikeSubLedger.HeaderText = "Behaves Like Sub Ledger";
            this.colBehavesLikeSubLedger.Name = "colBehavesLikeSubLedger";
            this.colBehavesLikeSubLedger.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBehavesLikeSubLedger.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colBehavesLikeSubLedger.Width = 80;
            // 
            // colDebitcreditBalanceforReporting
            // 
            this.colDebitcreditBalanceforReporting.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDebitcreditBalanceforReporting.HeaderText = "Debit credit Balance for Reporting";
            this.colDebitcreditBalanceforReporting.Name = "colDebitcreditBalanceforReporting";
            this.colDebitcreditBalanceforReporting.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDebitcreditBalanceforReporting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDebitcreditBalanceforReporting.Width = 261;
            // 
            // colUsedforCalculations
            // 
            this.colUsedforCalculations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colUsedforCalculations.HeaderText = "Used for Calculations";
            this.colUsedforCalculations.Name = "colUsedforCalculations";
            this.colUsedforCalculations.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUsedforCalculations.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colUsedforCalculations.Width = 177;
            // 
            // colAlias
            // 
            this.colAlias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAlias.HeaderText = "Alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.Width = 68;
            // 
            // frmAccountGroupList
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 527);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmAccountGroupList";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.Load += new System.EventHandler(this.Listing_Load);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolbar;
        private System.Windows.Forms.ToolStripButton EditToolbar;
        private System.Windows.Forms.ToolStripButton DeleteToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ExportToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ExitToolbar;
        private  System.Windows.Forms.DataGridView  grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colBehavesLikeSubLedger;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDebitcreditBalanceforReporting;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUsedforCalculations;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlias;
        private System.Windows.Forms.ToolStripButton tlbTreeView;

    }
}