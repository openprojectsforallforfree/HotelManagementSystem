namespace UEMS 
{
    partial class YearlyReport_Lst
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YearlyReport_Lst));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolbar = new System.Windows.Forms.ToolStripButton();
            this.EditToolbar = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_NGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFiscalYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorisedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecievedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSignedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colD_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(909, 2);
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
            this.toolStrip1.Location = new System.Drawing.Point(4, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(937, 60);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.TabStop = true;
            // 
            // newToolbar
            // 
            this.newToolbar.AutoSize = false;
            this.newToolbar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolbar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.newToolbar.Image = global::UEMS.Properties.Resources.AddNew;
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
            this.EditToolbar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.EditToolbar.Image = global::UEMS.Properties.Resources.Edit;
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
            this.DeleteToolbar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DeleteToolbar.Image = global::UEMS.Properties.Resources.delete;
            this.DeleteToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolbar.Name = "DeleteToolbar";
            this.DeleteToolbar.Size = new System.Drawing.Size(60, 60);
            this.DeleteToolbar.Text = "&Delete";
            this.DeleteToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.ExportToolbar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ExportToolbar.Image = global::UEMS.Properties.Resources.ExcelExport;
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
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colfk_NGO,
            this.colFiscalYearId,
            this.colAuthorisedAmount,
            this.colRecievedAmount,
            this.colSpentAmount,
            this.colSignedBy,
            this.colD_Date});
            this.grid.Location = new System.Drawing.Point(1, 100);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(940, 499);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 4;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colfk_NGO
            // 
            this.colfk_NGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_NGO.HeaderText = "fk_NGO";
            this.colfk_NGO.Name = "colfk_NGO";
            this.colfk_NGO.Visible = false;
            // 
            // colFiscalYearId
            // 
            this.colFiscalYearId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Shangrila Numeric", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFiscalYearId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colFiscalYearId.HeaderText = "आर्थिक बर्ष";
            this.colFiscalYearId.Name = "colFiscalYearId";
            // 
            // colAuthorisedAmount
            // 
            this.colAuthorisedAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Shangrila Numeric", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAuthorisedAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAuthorisedAmount.HeaderText = "समाजकल्याणबाट स्वीकृत प्रस्तावना रकम रु ";
            this.colAuthorisedAmount.Name = "colAuthorisedAmount";
            this.colAuthorisedAmount.Width = 296;
            // 
            // colRecievedAmount
            // 
            this.colRecievedAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Shangrila Numeric", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRecievedAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colRecievedAmount.HeaderText = "हालसम्म प्राप्त रकम रु";
            this.colRecievedAmount.Name = "colRecievedAmount";
            this.colRecievedAmount.Width = 165;
            // 
            // colSpentAmount
            // 
            this.colSpentAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Shangrila Numeric", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSpentAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSpentAmount.HeaderText = "खर्च भएको रकम रु ";
            this.colSpentAmount.Name = "colSpentAmount";
            this.colSpentAmount.Width = 156;
            // 
            // colSignedBy
            // 
            this.colSignedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Shangrila Numeric", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSignedBy.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSignedBy.HeaderText = "अध्यक्ष";
            this.colSignedBy.Name = "colSignedBy";
            this.colSignedBy.Width = 76;
            // 
            // colD_Date
            // 
            this.colD_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Shangrila Numeric", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colD_Date.DefaultCellStyle = dataGridViewCellStyle6;
            this.colD_Date.HeaderText = "मिति ";
            this.colD_Date.Name = "colD_Date";
            this.colD_Date.Width = 71;
            // 
            // YearlyReport_Lst
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 601);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grid);
            this.Name = "YearlyReport_Lst";
            this.Text = "बार्षिक प्रगति प्रतिवेदन";
            this.Load += new System.EventHandler(this.List_Load);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
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
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_NGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFiscalYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorisedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecievedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSignedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colD_Date;
 
    }
}
