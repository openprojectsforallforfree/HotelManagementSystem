namespace UEMS 
{
    partial class Room_Lst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_Lst));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolbar = new System.Windows.Forms.ToolStripButton();
            this.EditToolbar = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDormitory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerPersonRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerRoomRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfacilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmaxnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblfk_Group = new System.Windows.Forms.Label();
            this.cboroomType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOccupiedRoom = new System.Windows.Forms.Label();
            this.lblBookedRoom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnOk = new bsoftcontrols.fsButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(905, 2);
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
            this.toolStrip1.Size = new System.Drawing.Size(933, 60);
            this.toolStrip1.TabIndex = 5;
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
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // ExportToolbar
            // 
            this.ExportToolbar.AutoSize = false;
            this.ExportToolbar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportToolbar.Image = ((System.Drawing.Image)(resources.GetObject("ExportToolbar.Image")));
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
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.colRoomType,
            this.colName,
            this.colDormitory,
            this.colPerPersonRate,
            this.colPerRoomRate,
            this.colfacilities,
            this.colmaxnos,
            this.colremarks});
            this.grid.Location = new System.Drawing.Point(6, 68);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(906, 434);
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
            // colRoomType
            // 
            this.colRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRoomType.HeaderText = "Type";
            this.colRoomType.Name = "colRoomType";
            this.colRoomType.Width = 65;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 70;
            // 
            // colDormitory
            // 
            this.colDormitory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDormitory.HeaderText = "Dormitory";
            this.colDormitory.Name = "colDormitory";
            this.colDormitory.Width = 94;
            // 
            // colPerPersonRate
            // 
            this.colPerPersonRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPerPersonRate.HeaderText = "Person Rate";
            this.colPerPersonRate.Name = "colPerPersonRate";
            this.colPerPersonRate.Width = 112;
            // 
            // colPerRoomRate
            // 
            this.colPerRoomRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPerRoomRate.HeaderText = "Room Rate";
            this.colPerRoomRate.Name = "colPerRoomRate";
            this.colPerRoomRate.Width = 104;
            // 
            // colfacilities
            // 
            this.colfacilities.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colfacilities.HeaderText = "Facilities";
            this.colfacilities.Name = "colfacilities";
            this.colfacilities.Visible = false;
            // 
            // colmaxnos
            // 
            this.colmaxnos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colmaxnos.HeaderText = "Max Nos";
            this.colmaxnos.Name = "colmaxnos";
            this.colmaxnos.Width = 87;
            // 
            // colremarks
            // 
            this.colremarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colremarks.HeaderText = "Remarks";
            this.colremarks.Name = "colremarks";
            this.colremarks.Width = 89;
            // 
            // lblfk_Group
            // 
            this.lblfk_Group.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Group.Location = new System.Drawing.Point(17, 22);
            this.lblfk_Group.Name = "lblfk_Group";
            this.lblfk_Group.Size = new System.Drawing.Size(89, 22);
            this.lblfk_Group.TabIndex = 119;
            this.lblfk_Group.Text = "Room type:";
            this.lblfk_Group.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboroomType
            // 
            this.cboroomType.FormattingEnabled = true;
            this.cboroomType.Location = new System.Drawing.Point(127, 22);
            this.cboroomType.Name = "cboroomType";
            this.cboroomType.Size = new System.Drawing.Size(160, 24);
            this.cboroomType.TabIndex = 120;
            this.cboroomType.SelectedIndexChanged += new System.EventHandler(this.cboroomType_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(393, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 23);
            this.txtName.TabIndex = 124;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(304, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 123;
            this.label6.Text = "Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cboroomType);
            this.groupBox1.Controls.Add(this.lblOccupiedRoom);
            this.groupBox1.Controls.Add(this.lblBookedRoom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblfk_Group);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 59);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // lblOccupiedRoom
            // 
            this.lblOccupiedRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblOccupiedRoom.Location = new System.Drawing.Point(695, 34);
            this.lblOccupiedRoom.Name = "lblOccupiedRoom";
            this.lblOccupiedRoom.Size = new System.Drawing.Size(159, 22);
            this.lblOccupiedRoom.TabIndex = 123;
            this.lblOccupiedRoom.Text = "Occupied Rooms";
            this.lblOccupiedRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBookedRoom
            // 
            this.lblBookedRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblBookedRoom.Location = new System.Drawing.Point(695, 13);
            this.lblBookedRoom.Name = "lblBookedRoom";
            this.lblBookedRoom.Size = new System.Drawing.Size(159, 22);
            this.lblBookedRoom.TabIndex = 123;
            this.lblBookedRoom.Text = "Booked Rooms";
            this.lblBookedRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(617, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 123;
            this.label1.Text = "Colors:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.btnOk);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.grid);
            this.panel.Location = new System.Drawing.Point(12, 101);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(915, 546);
            this.panel.TabIndex = 122;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(418, 505);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 122;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Room_Lst
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 659);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Room_Lst";
            this.Text = "Room List";
            this.Load += new System.EventHandler(this.List_Load);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.panel, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblfk_Group;
        private System.Windows.Forms.ComboBox cboroomType;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblOccupiedRoom;
        private System.Windows.Forms.Label lblBookedRoom;
        private System.Windows.Forms.Label label1;
        private bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDormitory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerPersonRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerRoomRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfacilities;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmaxnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colremarks;
 
    }
}
