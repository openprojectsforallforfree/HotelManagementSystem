namespace UEMS 
{
    partial class frmProductTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductTag));
            this.flwControls = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTagGrp = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTagGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolbar = new System.Windows.Forms.ToolStripButton();
            this.EditToolbar = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.flwControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(712, 2);
            this._closeButton.Size = new System.Drawing.Size(43, 39);
            // 
            // flwControls
            // 
            this.flwControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.flwControls.BackColor = System.Drawing.Color.Transparent;
            this.flwControls.Controls.Add(this.btnTagGrp);
            this.flwControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwControls.Location = new System.Drawing.Point(12, 112);
            this.flwControls.Margin = new System.Windows.Forms.Padding(4);
            this.flwControls.Name = "flwControls";
            this.flwControls.Size = new System.Drawing.Size(193, 320);
            this.flwControls.TabIndex = 10;
            this.flwControls.WrapContents = false;
            // 
            // btnTagGrp
            // 
            this.btnTagGrp.FlatAppearance.BorderSize = 0;
            this.btnTagGrp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTagGrp.Location = new System.Drawing.Point(4, 4);
            this.btnTagGrp.Margin = new System.Windows.Forms.Padding(4);
            this.btnTagGrp.Name = "btnTagGrp";
            this.btnTagGrp.Size = new System.Drawing.Size(185, 36);
            this.btnTagGrp.TabIndex = 0;
            this.btnTagGrp.Text = "btnTagGrps";
            this.btnTagGrp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTagGrp.UseVisualStyleBackColor = true;
            this.btnTagGrp.Click += new System.EventHandler(this.btnTagGrp_Click);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTagGroupId,
            this.colValue});
            this.grid.Location = new System.Drawing.Point(213, 112);
            this.grid.Margin = new System.Windows.Forms.Padding(4);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(531, 320);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 12;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colTagGroupId
            // 
            this.colTagGroupId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTagGroupId.HeaderText = "Group";
            this.colTagGroupId.Name = "colTagGroupId";
            this.colTagGroupId.Visible = false;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValue.HeaderText = "Descriptive Text";
            this.colValue.Name = "colValue";
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
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(213, 43);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(524, 63);
            this.toolStrip1.TabIndex = 13;
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
            this.newToolbar.Text = "&New";
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
            this.DeleteToolbar.Click += new System.EventHandler(this.DeleteToolbar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 63);
            // 
            // frmProductTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 449);
            this.Controls.Add(this.flwControls);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductTag";
            this.Text = "frmProductTag";
            this.Load += new System.EventHandler(this.frmProductTag_Load);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.flwControls, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.flwControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwControls;
        private System.Windows.Forms.Button btnTagGrp;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTagGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolbar;
        private System.Windows.Forms.ToolStripButton EditToolbar;
        private System.Windows.Forms.ToolStripButton DeleteToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;



    }
}