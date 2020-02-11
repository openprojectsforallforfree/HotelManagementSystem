namespace Bsoft.AppCom.UserMgtWithRole
{
    partial class frmMnuRights
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.cboRightGroups = new System.Windows.Forms.ComboBox();
            this.treeMenuRights = new Bsoft.Controls.TriStateTreeView();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.btnReset = new bsoftcontrols.fsButton();
            this.btnApply = new bsoftcontrols.fsButton();
            this.fsButton1 = new bsoftcontrols.fsButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(590, 2);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.cboRightGroups);
            this.groupBox1.Controls.Add(this.treeMenuRights);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 578);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDate.ForeColor = System.Drawing.Color.Green;
            this.lblDate.Location = new System.Drawing.Point(77, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(160, 22);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "User Role :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // cboRightGroups
            // 
            this.cboRightGroups.FormattingEnabled = true;
            this.cboRightGroups.Location = new System.Drawing.Point(243, 17);
            this.cboRightGroups.Name = "cboRightGroups";
            this.cboRightGroups.Size = new System.Drawing.Size(283, 24);
            this.cboRightGroups.TabIndex = 14;
            this.cboRightGroups.SelectedIndexChanged += new System.EventHandler(this.cboRightGroups_SelectedIndexChanged);
            // 
            // treeMenuRights
            // 
            this.treeMenuRights.ImageIndex = 0;
            this.treeMenuRights.Location = new System.Drawing.Point(66, 47);
            this.treeMenuRights.Name = "treeMenuRights";
            this.treeMenuRights.SelectedImageIndex = 0;
            this.treeMenuRights.Size = new System.Drawing.Size(460, 520);
            this.treeMenuRights.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(534, 646);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(444, 646);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnReset
            // 
            this.btnReset.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReset.Location = new System.Drawing.Point(264, 646);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 29);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "ResestAll";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnApply
            // 
            this.btnApply.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnApply.Location = new System.Drawing.Point(354, 646);
            this.btnApply.Margin = new System.Windows.Forms.Padding(0);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(78, 29);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Apply";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // fsButton1
            // 
            this.fsButton1.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.fsButton1.FlatAppearance.BorderSize = 0;
            this.fsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fsButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fsButton1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fsButton1.Location = new System.Drawing.Point(92, 646);
            this.fsButton1.Margin = new System.Windows.Forms.Padding(0);
            this.fsButton1.Name = "fsButton1";
            this.fsButton1.Size = new System.Drawing.Size(157, 29);
            this.fsButton1.TabIndex = 14;
            this.fsButton1.Text = "Select Basic Rights";
            this.fsButton1.Click += new System.EventHandler(this.btnBasicRights_Click);
            // 
            // frmMnuRights
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 695);
            this.Controls.Add(this.fsButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnReset);
            this.DoubleBuffered = true;
            this.Name = "frmMnuRights";
            this.Text = "Menu Right";
            this.Load += new System.EventHandler(this.frmMnuRights_Load);
            this.Controls.SetChildIndex(this.btnReset, 0);
            this.Controls.SetChildIndex(this.btnApply, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.fsButton1, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public bsoftcontrols.fsButton btnCancel;
        public bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.ComboBox cboRightGroups;
        private Bsoft.Controls.TriStateTreeView treeMenuRights;
        private System.Windows.Forms.Label lblDate;
        public bsoftcontrols.fsButton btnReset;
        public bsoftcontrols.fsButton btnApply;
        public bsoftcontrols.fsButton fsButton1;
    }
}
