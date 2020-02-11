namespace Bsoft.AppCom.UserMgtWithRole
{
    partial class frmUserEntry
    {
        private Bsoft.Controls.VtextBox txtId;
        private Bsoft.Controls.VtextBox txtName;
        private Bsoft.Controls.VtextBox txtUserid;
        private Bsoft.Controls.VtextBox txtEmail;
        private Bsoft.Controls.VtextBox txtPhone;
        private Bsoft.Controls.VtextBox txtAddress;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserEntry));
            this.txtId = new Bsoft.Controls.VtextBox();
            this.txtName = new Bsoft.Controls.VtextBox();
            this.txtUserid = new Bsoft.Controls.VtextBox();
            this.txtEmail = new Bsoft.Controls.VtextBox();
            this.txtPhone = new Bsoft.Controls.VtextBox();
            this.txtAddress = new Bsoft.Controls.VtextBox();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUSERSTATUS = new System.Windows.Forms.Label();
            this.chkUSERSTATUS = new System.Windows.Forms.CheckBox();
            this.pnlNEPNAME = new System.Windows.Forms.Panel();
            this.txtNEPNAME = new Bsoft.Controls.VtextBox();
            this.lblNEPNAME = new System.Windows.Forms.Label();
            this.pnlUSERSTATUS = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.cboRightGroups = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserid = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlNEPNAME.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(473, 2);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(37, 11);
            this.txtId.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtId.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(56, 23);
            this.txtId.TabIndex = 0;
            this.txtId.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtId.Value = "";
            this.txtId.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(229, 23);
            this.txtName.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtName.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 23);
            this.txtName.TabIndex = 1;
            this.txtName.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtName.Value = "";
            // 
            // txtUserid
            // 
            this.txtUserid.Location = new System.Drawing.Point(229, 85);
            this.txtUserid.MaxLength = 15;
            this.txtUserid.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtUserid.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(186, 23);
            this.txtUserid.TabIndex = 3;
            this.txtUserid.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtUserid.Value = "";
            this.txtUserid.Validated += new System.EventHandler(this.txtUserid_Validated);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(229, 114);
            this.txtEmail.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtEmail.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Email;
            this.txtEmail.Value = "";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(229, 143);
            this.txtPhone.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPhone.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(186, 23);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.PhoneFax;
            this.txtPhone.Value = "";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(229, 172);
            this.txtAddress.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAddress.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(186, 64);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtAddress.Value = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(272, 406);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(165, 406);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 25);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblUSERSTATUS);
            this.groupBox1.Controls.Add(this.chkUSERSTATUS);
            this.groupBox1.Controls.Add(this.pnlNEPNAME);
            this.groupBox1.Controls.Add(this.pnlUSERSTATUS);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.cboRightGroups);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblUserid);
            this.groupBox1.Controls.Add(this.txtUserid);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblUSERSTATUS
            // 
            this.lblUSERSTATUS.BackColor = System.Drawing.Color.Transparent;
            this.lblUSERSTATUS.Location = new System.Drawing.Point(63, 277);
            this.lblUSERSTATUS.Name = "lblUSERSTATUS";
            this.lblUSERSTATUS.Size = new System.Drawing.Size(160, 22);
            this.lblUSERSTATUS.TabIndex = 0;
            this.lblUSERSTATUS.Text = "सक्रीय :";
            this.lblUSERSTATUS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkUSERSTATUS
            // 
            this.chkUSERSTATUS.AutoSize = true;
            this.chkUSERSTATUS.Location = new System.Drawing.Point(229, 282);
            this.chkUSERSTATUS.Name = "chkUSERSTATUS";
            this.chkUSERSTATUS.Size = new System.Drawing.Size(15, 14);
            this.chkUSERSTATUS.TabIndex = 0;
            this.chkUSERSTATUS.UseVisualStyleBackColor = true;
            // 
            // pnlNEPNAME
            // 
            this.pnlNEPNAME.AutoSize = true;
            this.pnlNEPNAME.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNEPNAME.BackColor = System.Drawing.Color.Transparent;
            this.pnlNEPNAME.Controls.Add(this.txtNEPNAME);
            this.pnlNEPNAME.Controls.Add(this.lblNEPNAME);
            this.pnlNEPNAME.Location = new System.Drawing.Point(20, 52);
            this.pnlNEPNAME.Margin = new System.Windows.Forms.Padding(1);
            this.pnlNEPNAME.Name = "pnlNEPNAME";
            this.pnlNEPNAME.Size = new System.Drawing.Size(406, 27);
            this.pnlNEPNAME.TabIndex = 21;
            this.pnlNEPNAME.Text = "नेपाली नाम ";
            // 
            // txtNEPNAME
            // 
            this.txtNEPNAME.Location = new System.Drawing.Point(172, 1);
            this.txtNEPNAME.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNEPNAME.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNEPNAME.Name = "txtNEPNAME";
            this.txtNEPNAME.Size = new System.Drawing.Size(231, 23);
            this.txtNEPNAME.TabIndex = 0;
            this.txtNEPNAME.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtNEPNAME.Value = "";
            // 
            // lblNEPNAME
            // 
            this.lblNEPNAME.BackColor = System.Drawing.Color.Transparent;
            this.lblNEPNAME.Location = new System.Drawing.Point(10, 1);
            this.lblNEPNAME.Name = "lblNEPNAME";
            this.lblNEPNAME.Size = new System.Drawing.Size(160, 22);
            this.lblNEPNAME.TabIndex = 0;
            this.lblNEPNAME.Text = "नेपाली नाम :";
            this.lblNEPNAME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlUSERSTATUS
            // 
            this.pnlUSERSTATUS.AutoSize = true;
            this.pnlUSERSTATUS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlUSERSTATUS.BackColor = System.Drawing.Color.Transparent;
            this.pnlUSERSTATUS.Location = new System.Drawing.Point(37, 270);
            this.pnlUSERSTATUS.Margin = new System.Windows.Forms.Padding(1);
            this.pnlUSERSTATUS.Name = "pnlUSERSTATUS";
            this.pnlUSERSTATUS.Size = new System.Drawing.Size(0, 0);
            this.pnlUSERSTATUS.TabIndex = 20;
            this.pnlUSERSTATUS.Text = "सक्रीय ";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(63, 242);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(160, 22);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Main Role:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRightGroups
            // 
            this.cboRightGroups.FormattingEnabled = true;
            this.cboRightGroups.Location = new System.Drawing.Point(229, 242);
            this.cboRightGroups.Name = "cboRightGroups";
            this.cboRightGroups.Size = new System.Drawing.Size(186, 24);
            this.cboRightGroups.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(1, 11);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblId.Visible = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(55, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserid
            // 
            this.lblUserid.BackColor = System.Drawing.Color.Transparent;
            this.lblUserid.Location = new System.Drawing.Point(55, 85);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(160, 22);
            this.lblUserid.TabIndex = 0;
            this.lblUserid.Text = "Userid:";
            this.lblUserid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(55, 114);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(160, 22);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Location = new System.Drawing.Point(55, 143);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(160, 22);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Location = new System.Drawing.Point(55, 172);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(160, 22);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmUserEntry
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 443);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Name = "frmUserEntry";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUserEntry_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlNEPNAME.ResumeLayout(false);
            this.pnlNEPNAME.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public bsoftcontrols.fsButton btnCancel;
        public bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label lblId;


        private System.Windows.Forms.Label lblName;

        private System.Windows.Forms.Label lblUserid;

        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.Label lblPhone;

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cboRightGroups;
        private System.Windows.Forms.Panel pnlUSERSTATUS;
        private System.Windows.Forms.CheckBox chkUSERSTATUS;
        private System.Windows.Forms.Label lblUSERSTATUS;
        private System.Windows.Forms.Panel pnlNEPNAME;
        private Bsoft.Controls.VtextBox txtNEPNAME;
        private System.Windows.Forms.Label lblNEPNAME;


    }
}
