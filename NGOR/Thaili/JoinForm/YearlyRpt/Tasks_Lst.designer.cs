namespace UEMS 
{
    partial class Tasks_Lst
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks_Lst));
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_WorkDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpensedBudget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMale_Adv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFemale_Adv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTG_Adv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDalit_Adv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJanjati_Adv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOther_Adv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolbar = new System.Windows.Forms.ToolStripButton();
            this.EditToolbar = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolbar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(826, 2);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colfk_WorkDone,
            this.colTitle,
            this.colExpensedBudget,
            this.colMale_Adv,
            this.colFemale_Adv,
            this.colTG_Adv,
            this.colDalit_Adv,
            this.colJanjati_Adv,
            this.colOther_Adv});
            this.grid.Location = new System.Drawing.Point(72, 19);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(749, 175);
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
            // colfk_WorkDone
            // 
            this.colfk_WorkDone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_WorkDone.HeaderText = "fk_WorkDone";
            this.colfk_WorkDone.Name = "colfk_WorkDone";
            this.colfk_WorkDone.Visible = false;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTitle.HeaderText = "क्रियाकलापहरु";
            this.colTitle.Name = "colTitle";
            this.colTitle.Width = 114;
            // 
            // colExpensedBudget
            // 
            this.colExpensedBudget.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Shangrila Numeric", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colExpensedBudget.DefaultCellStyle = dataGridViewCellStyle1;
            this.colExpensedBudget.HeaderText = "खर्च भएको बजेट";
            this.colExpensedBudget.Name = "colExpensedBudget";
            this.colExpensedBudget.Width = 133;
            // 
            // colMale_Adv
            // 
            this.colMale_Adv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Shangrila Numeric", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMale_Adv.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMale_Adv.HeaderText = "पुरुष ";
            this.colMale_Adv.Name = "colMale_Adv";
            this.colMale_Adv.Width = 68;
            // 
            // colFemale_Adv
            // 
            this.colFemale_Adv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Shangrila Numeric", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFemale_Adv.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFemale_Adv.HeaderText = "महिला";
            this.colFemale_Adv.Name = "colFemale_Adv";
            this.colFemale_Adv.Width = 73;
            // 
            // colTG_Adv
            // 
            this.colTG_Adv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Shangrila Numeric", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTG_Adv.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTG_Adv.HeaderText = "ते.लि";
            this.colTG_Adv.Name = "colTG_Adv";
            this.colTG_Adv.Width = 64;
            // 
            // colDalit_Adv
            // 
            this.colDalit_Adv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Shangrila Numeric", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDalit_Adv.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDalit_Adv.HeaderText = "दलित";
            this.colDalit_Adv.Name = "colDalit_Adv";
            this.colDalit_Adv.Width = 68;
            // 
            // colJanjati_Adv
            // 
            this.colJanjati_Adv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Shangrila Numeric", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colJanjati_Adv.DefaultCellStyle = dataGridViewCellStyle6;
            this.colJanjati_Adv.HeaderText = "जनजाती";
            this.colJanjati_Adv.Name = "colJanjati_Adv";
            this.colJanjati_Adv.Width = 85;
            // 
            // colOther_Adv
            // 
            this.colOther_Adv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Shangrila Numeric", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colOther_Adv.DefaultCellStyle = dataGridViewCellStyle7;
            this.colOther_Adv.HeaderText = "अन्य";
            this.colOther_Adv.Name = "colOther_Adv";
            this.colOther_Adv.Width = 64;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.grid);
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 205);
            this.panel2.TabIndex = 10;
            // 
            // toolStrip1
            // 
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
            this.DeleteToolbar});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(9, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(60, 216);
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
            this.EditToolbar.Font = new System.Drawing.Font("Mangal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditToolbar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.EditToolbar.Image = global::UEMS.Properties.Resources.Edit;
            this.EditToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolbar.Name = "EditToolbar";
            this.EditToolbar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.EditToolbar.Size = new System.Drawing.Size(60, 57);
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
            // Tasks_Lst
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 601);
            this.Controls.Add(this.panel2);
            this.Name = "Tasks_Lst";
            this.Text = "क्रियाकलापहरु List";
            this.Load += new System.EventHandler(this.List_Load);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        } 



        #endregion

 private System.Windows.Forms.DataGridView grid;
 public System.Windows.Forms.Panel panel2;
 private System.Windows.Forms.ToolStrip toolStrip1;
 private System.Windows.Forms.ToolStripButton newToolbar;
 private System.Windows.Forms.ToolStripButton DeleteToolbar;
 private System.Windows.Forms.ToolStripButton EditToolbar;
 private System.Windows.Forms.DataGridViewTextBoxColumn colId;
 private System.Windows.Forms.DataGridViewTextBoxColumn colfk_WorkDone;
 private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
 private System.Windows.Forms.DataGridViewTextBoxColumn colExpensedBudget;
 private System.Windows.Forms.DataGridViewTextBoxColumn colMale_Adv;
 private System.Windows.Forms.DataGridViewTextBoxColumn colFemale_Adv;
 private System.Windows.Forms.DataGridViewTextBoxColumn colTG_Adv;
 private System.Windows.Forms.DataGridViewTextBoxColumn colDalit_Adv;
 private System.Windows.Forms.DataGridViewTextBoxColumn colJanjati_Adv;
 private System.Windows.Forms.DataGridViewTextBoxColumn colOther_Adv;
 
    }
}
