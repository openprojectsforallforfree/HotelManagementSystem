namespace Bsoft.AppCom.UserMgtSimple 
{
    partial class SuperAdmin_Rights_Users_Lst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdmin_Rights_Users_Lst));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolbar = new System.Windows.Forms.ToolStripButton();
            this.EditToolbar = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNEPNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colENGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUSERSTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLASTLOGGEDON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLASTLOGGEDOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGRANTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(826, 2);
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
            this.toolStrip1.Size = new System.Drawing.Size(854, 60);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.TabStop = true;
            // 
            // newToolbar
            // 
            this.newToolbar.AutoSize = false;
            this.newToolbar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolbar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.newToolbar.Image = global::Bsoft.AppCom.Properties.Resources.AddNew;
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
            this.EditToolbar.Image = global::Bsoft .AppCom .Properties .Resources.Edit;
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
            this.DeleteToolbar.Image = global::Bsoft.AppCom.Properties.Resources.delete;
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
            this.ExportToolbar.Image = global::Bsoft.AppCom.Properties.Resources.ExcelExport;
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
            this.colid,
            this.colUserid,
            this.colNEPNAME,
            this.colENGNAME,
            this.colUSERSTATUS,
            this.colLASTLOGGEDON,
            this.colLASTLOGGEDOUT,
            this.colGRANTS,
            this.colPersonId});
            this.grid.Location = new System.Drawing.Point(1, 100);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(857, 499);
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
            // colUserid
            // 
            this.colUserid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUserid.HeaderText = "सांकेतिक नाम ";
            this.colUserid.Name = "colUserid";
            this.colUserid.Width = 123;
            // 
            // colNEPNAME
            // 
            this.colNEPNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNEPNAME.HeaderText = "नेपाली नाम ";
            this.colNEPNAME.Name = "colNEPNAME";
            this.colNEPNAME.Width = 109;
            // 
            // colENGNAME
            // 
            this.colENGNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colENGNAME.HeaderText = "अङ्रेजी नाम ";
            this.colENGNAME.Name = "colENGNAME";
            this.colENGNAME.Width = 108;
            // 
            // colUSERSTATUS
            // 
            this.colUSERSTATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUSERSTATUS.HeaderText = "सक्रीय ";
            this.colUSERSTATUS.Name = "colUSERSTATUS";
            this.colUSERSTATUS.Width = 78;
            // 
            // colLASTLOGGEDON
            // 
            this.colLASTLOGGEDON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLASTLOGGEDON.HeaderText = "अन्तिम पटक सन्चालित मिति ";
            this.colLASTLOGGEDON.Name = "colLASTLOGGEDON";
            this.colLASTLOGGEDON.Width = 214;
            // 
            // colLASTLOGGEDOUT
            // 
            this.colLASTLOGGEDOUT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLASTLOGGEDOUT.HeaderText = "अन्तिम पटक बन्दगरेको मिति ";
            this.colLASTLOGGEDOUT.Name = "colLASTLOGGEDOUT";
            this.colLASTLOGGEDOUT.Width = 215;
            // 
            // colGRANTS
            // 
            this.colGRANTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGRANTS.HeaderText = "GRANTS";
            this.colGRANTS.Name = "colGRANTS";
            this.colGRANTS.Width = 97;
            // 
            // colPersonId
            // 
            this.colPersonId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPersonId.HeaderText = "Select Person ";
            this.colPersonId.Name = "colPersonId";
            this.colPersonId.Visible = false;
            // 
            // SuperAdmin_Rights_Users_Lst
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 601);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grid);
            this.Name = "SuperAdmin_Rights_Users_Lst";
            this.Text = " List";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNEPNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colENGNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUSERSTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLASTLOGGEDON;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLASTLOGGEDOUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGRANTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonId;
 
    }
}
