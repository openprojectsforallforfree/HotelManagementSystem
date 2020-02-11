namespace RestoSys.Forms
{
    partial class frmCustomer
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaster_CustomerType = new System.Windows.Forms.ComboBox();
            this.lblCtype = new System.Windows.Forms.Label();
            this.txtPhone = new Bsoft.Controls.VtextBox();
            this.txtEmail = new Bsoft.Controls.VtextBox();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdNumber = new Bsoft.Controls.VtextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(534, 2);
            this._closeButton.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(324, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 23);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(228, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(228, 61);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(185, 23);
            this.txtLastName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(228, 207);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(185, 23);
            this.txtAddress.TabIndex = 5;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(228, 236);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(259, 51);
            this.txtRemarks.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(56, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "First Name :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Location = new System.Drawing.Point(56, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(160, 22);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name :";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(56, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(160, 22);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail :";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Location = new System.Drawing.Point(56, 151);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(160, 22);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone Number :";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Location = new System.Drawing.Point(56, 211);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(160, 22);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address :";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Location = new System.Drawing.Point(56, 241);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(160, 22);
            this.lblRemarks.TabIndex = 0;
            this.lblRemarks.Text = "Remarks :";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboMaster_CustomerType);
            this.groupBox1.Controls.Add(this.lblCtype);
            this.groupBox1.Controls.Add(this.txtIdNumber);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lblRemarks);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboMaster_CustomerType
            // 
            this.cboMaster_CustomerType.FormattingEnabled = true;
            this.cboMaster_CustomerType.Location = new System.Drawing.Point(228, 90);
            this.cboMaster_CustomerType.Name = "cboMaster_CustomerType";
            this.cboMaster_CustomerType.Size = new System.Drawing.Size(185, 24);
            this.cboMaster_CustomerType.TabIndex = 2;
            // 
            // lblCtype
            // 
            this.lblCtype.BackColor = System.Drawing.Color.Transparent;
            this.lblCtype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCtype.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCtype.Location = new System.Drawing.Point(50, 92);
            this.lblCtype.Name = "lblCtype";
            this.lblCtype.Size = new System.Drawing.Size(166, 22);
            this.lblCtype.TabIndex = 10;
            this.lblCtype.Text = "Customer Type :";
            this.lblCtype.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCtype.Click += new System.EventHandler(this.lblCtype_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(228, 149);
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
            this.txtPhone.Size = new System.Drawing.Size(185, 23);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.PhoneFax;
            this.txtPhone.Value = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(228, 178);
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
            this.txtEmail.Size = new System.Drawing.Size(185, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Email;
            this.txtEmail.Value = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(290, 400);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeColor = System.Drawing.Color.Blue;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(200, 400);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.ThemeColor = System.Drawing.Color.Blue;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(56, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Number :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(228, 120);
            this.txtIdNumber.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIdNumber.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(185, 23);
            this.txtIdNumber.TabIndex = 3;
            this.txtIdNumber.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtIdNumber.Value = "";
            // 
            // frmCustomer
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 438);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "frmCustomer";
            this.Text = "Customers Entry";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Label lblName;

        private System.Windows.Forms.Label lblLastName;

        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.Label lblPhone;

        private System.Windows.Forms.Label lblAddress;

        private System.Windows.Forms.Label lblRemarks; 


        private System.Windows.Forms.TextBox txtId;


        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.TextBox txtLastName;

        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.TextBox txtRemarks; 



        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public bsoftcontrols.fsButton btnCancel;
        public bsoftcontrols.fsButton btnOk;
        private Bsoft.Controls.VtextBox txtPhone;
        private Bsoft.Controls.VtextBox txtEmail;
        private System.Windows.Forms.ComboBox cboMaster_CustomerType;
        private System.Windows.Forms.Label lblCtype;
        private Bsoft.Controls.VtextBox txtIdNumber;
        private System.Windows.Forms.Label label1;
    }
}
