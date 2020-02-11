namespace UEMS
{
    partial class Customer_Master_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Master_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.flwLayout = new Bsoft.Controls.LableFlowLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(817, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(433, 472);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(339, 472);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // flwLayout
            // 
            this.flwLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flwLayout.AutoScroll = true;
            this.flwLayout.BackColor = System.Drawing.Color.Transparent;
            this.flwLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwLayout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flwLayout.lable = "";
            this.flwLayout.Location = new System.Drawing.Point(6, 50);
            this.flwLayout.Name = "flwLayout";
            this.flwLayout.Size = new System.Drawing.Size(837, 409);
            this.flwLayout.TabIndex = 11;
            this.flwLayout.WrapContents = false;
            // 
            // Customer_Master_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 510);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flwLayout);
            this.Controls.Add(this.btnOk);
            this.Name = "Customer_Master_Ent";
            this.Text = "";
            this.Load += new System.EventHandler(this.Customer_Master_Ent_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.flwLayout, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.ResumeLayout(false);

        // 
// lblId
// 
this.pnlId = new System.Windows.Forms.Panel();
this.pnlId.BackColor = System.Drawing.Color.Transparent;
this.pnlId.Location =new System.Drawing.Point(100, 72);
this.pnlId.Name ="pnlId";
this.pnlId.Size = new System.Drawing.Size(400, 45);
this.pnlId.TabIndex = 0;
this.pnlId.Margin = new System.Windows.Forms.Padding(1);
this.pnlId .AutoSize = true;
 this.pnlId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
 this.pnlId .Text = "Id";
 this.Controls.Add(this.pnlId);
// 
// lblName
// 
this.pnlName = new System.Windows.Forms.Panel();
this.pnlName.BackColor = System.Drawing.Color.Transparent;
this.pnlName.Location =new System.Drawing.Point(100, 122);
this.pnlName.Name ="pnlName";
this.pnlName.Size = new System.Drawing.Size(400, 45);
this.pnlName.TabIndex = 0;
this.pnlName.Margin = new System.Windows.Forms.Padding(1);
this.pnlName .AutoSize = true;
 this.pnlName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
 this.pnlName .Text = "Name";
 this.Controls.Add(this.pnlName);
// 
// lblLastName
// 
this.pnlLastName = new System.Windows.Forms.Panel();
this.pnlLastName.BackColor = System.Drawing.Color.Transparent;
this.pnlLastName.Location =new System.Drawing.Point(100, 172);
this.pnlLastName.Name ="pnlLastName";
this.pnlLastName.Size = new System.Drawing.Size(400, 45);
this.pnlLastName.TabIndex = 0;
this.pnlLastName.Margin = new System.Windows.Forms.Padding(1);
this.pnlLastName .AutoSize = true;
 this.pnlLastName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
 this.pnlLastName .Text = "LastName";
 this.Controls.Add(this.pnlLastName);
// 
// lblUserid
// 
this.pnlUserid = new System.Windows.Forms.Panel();
this.pnlUserid.BackColor = System.Drawing.Color.Transparent;
this.pnlUserid.Location =new System.Drawing.Point(100, 222);
this.pnlUserid.Name ="pnlUserid";
this.pnlUserid.Size = new System.Drawing.Size(400, 45);
this.pnlUserid.TabIndex = 0;
this.pnlUserid.Margin = new System.Windows.Forms.Padding(1);
this.pnlUserid .AutoSize = true;
 this.pnlUserid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
 this.pnlUserid .Text = "Userid";
 this.Controls.Add(this.pnlUserid);
// 
// lblEmail
// 
this.pnlEmail = new System.Windows.Forms.Panel();
this.pnlEmail.BackColor = System.Drawing.Color.Transparent;
this.pnlEmail.Location =new System.Drawing.Point(100, 272);
this.pnlEmail.Name ="pnlEmail";
this.pnlEmail.Size = new System.Drawing.Size(400, 45);
this.pnlEmail.TabIndex = 0;
this.pnlEmail.Margin = new System.Windows.Forms.Padding(1);
this.pnlEmail .AutoSize = true;
 this.pnlEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
 this.pnlEmail .Text = "Email";
 this.Controls.Add(this.pnlEmail);
// 
// lblPhone
// 
this.pnlPhone = new System.Windows.Forms.Panel();
this.pnlPhone.BackColor = System.Drawing.Color.Transparent;
this.pnlPhone.Location =new System.Drawing.Point(100, 322);
this.pnlPhone.Name ="pnlPhone";
this.pnlPhone.Size = new System.Drawing.Size(400, 45);
this.pnlPhone.TabIndex = 0;
this.pnlPhone.Margin = new System.Windows.Forms.Padding(1);
this.pnlPhone .AutoSize = true;
 this.pnlPhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
 this.pnlPhone .Text = "Phone";
 this.Controls.Add(this.pnlPhone);
// 
// lblAddress
// 
this.pnlAddress = new System.Windows.Forms.Panel();
this.pnlAddress.BackColor = System.Drawing.Color.Transparent;
this.pnlAddress.Location =new System.Drawing.Point(100, 372);
this.pnlAddress.Name ="pnlAddress";
this.pnlAddress.Size = new System.Drawing.Size(400, 45);
this.pnlAddress.TabIndex = 0;
this.pnlAddress.Margin = new System.Windows.Forms.Padding(1);
this.pnlAddress .AutoSize = true;
 this.pnlAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
 this.pnlAddress .Text = "Address";
 this.Controls.Add(this.pnlAddress);
// 
// lblRemarks
// 
this.pnlRemarks = new System.Windows.Forms.Panel();
this.pnlRemarks.BackColor = System.Drawing.Color.Transparent;
this.pnlRemarks.Location =new System.Drawing.Point(100, 422);
this.pnlRemarks.Name ="pnlRemarks";
this.pnlRemarks.Size = new System.Drawing.Size(400, 45);
this.pnlRemarks.TabIndex = 0;
this.pnlRemarks.Margin = new System.Windows.Forms.Padding(1);
this.pnlRemarks .AutoSize = true;
 this.pnlRemarks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
 this.pnlRemarks .Text = "Remarks";
 this.Controls.Add(this.pnlRemarks);
// 
// lblfk_CustomerType
// 
this.pnlfk_CustomerType = new System.Windows.Forms.Panel();
this.pnlfk_CustomerType.BackColor = System.Drawing.Color.Transparent;
this.pnlfk_CustomerType.Location =new System.Drawing.Point(100, 472);
this.pnlfk_CustomerType.Name ="pnlfk_CustomerType";
this.pnlfk_CustomerType.Size = new System.Drawing.Size(400, 45);
this.pnlfk_CustomerType.TabIndex = 0;
this.pnlfk_CustomerType.Margin = new System.Windows.Forms.Padding(1);
this.pnlfk_CustomerType .AutoSize = true;
 this.pnlfk_CustomerType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
 this.pnlfk_CustomerType .Text = "fk_CustomerType";
 this.Controls.Add(this.pnlfk_CustomerType);

// 
//txtId
// 
 this.txtId = new System.Windows.Forms.TextBox();
 this.txtId .Location = new System.Drawing.Point(172, 1);
 this.txtId .Name = "txtId";
 this.txtId .Size = new System.Drawing.Size(160, 20);
 this.txtId .TabIndex = 0;
 this.pnlId.Controls.Add(this.txtId);
// 
//txtName
// 
 this.txtName = new System.Windows.Forms.TextBox();
 this.txtName .Location = new System.Drawing.Point(172, 1);
 this.txtName .Name = "txtName";
 this.txtName .MaxLength = 50;
 this.txtName .Size = new System.Drawing.Size(160, 20);
 this.txtName .TabIndex = 0;
 this.pnlName.Controls.Add(this.txtName);
// 
//txtLastName
// 
 this.txtLastName = new System.Windows.Forms.TextBox();
 this.txtLastName .Location = new System.Drawing.Point(172, 1);
 this.txtLastName .Name = "txtLastName";
 this.txtLastName .MaxLength = 50;
 this.txtLastName .Size = new System.Drawing.Size(160, 20);
 this.txtLastName .TabIndex = 0;
 this.pnlLastName.Controls.Add(this.txtLastName);
// 
//txtUserid
// 
 this.txtUserid = new System.Windows.Forms.TextBox();
 this.txtUserid .Location = new System.Drawing.Point(172, 1);
 this.txtUserid .Name = "txtUserid";
 this.txtUserid .MaxLength = 50;
 this.txtUserid .Size = new System.Drawing.Size(160, 20);
 this.txtUserid .TabIndex = 0;
 this.pnlUserid.Controls.Add(this.txtUserid);
// 
//txtEmail
// 
 this.txtEmail = new System.Windows.Forms.TextBox();
 this.txtEmail .Location = new System.Drawing.Point(172, 1);
 this.txtEmail .Name = "txtEmail";
 this.txtEmail .MaxLength = 50;
 this.txtEmail .Size = new System.Drawing.Size(160, 20);
 this.txtEmail .TabIndex = 0;
 this.pnlEmail.Controls.Add(this.txtEmail);
// 
//txtPhone
// 
 this.txtPhone = new System.Windows.Forms.TextBox();
 this.txtPhone .Location = new System.Drawing.Point(172, 1);
 this.txtPhone .Name = "txtPhone";
 this.txtPhone .MaxLength = 50;
 this.txtPhone .Size = new System.Drawing.Size(160, 20);
 this.txtPhone .TabIndex = 0;
 this.pnlPhone.Controls.Add(this.txtPhone);
// 
//txtAddress
// 
 this.txtAddress = new System.Windows.Forms.TextBox();
 this.txtAddress .Location = new System.Drawing.Point(172, 1);
 this.txtAddress .Name = "txtAddress";
 this.txtAddress .MaxLength = 150;
 this.txtAddress .Size = new System.Drawing.Size(400, 50);
 this.txtAddress .Multiline = true;
 this.txtAddress .TabIndex = 0;
 this.pnlAddress.Controls.Add(this.txtAddress);
// 
//txtRemarks
// 
 this.txtRemarks = new System.Windows.Forms.TextBox();
 this.txtRemarks .Location = new System.Drawing.Point(172, 1);
 this.txtRemarks .Name = "txtRemarks";
 this.txtRemarks .MaxLength = 150;
 this.txtRemarks .Size = new System.Drawing.Size(400, 50);
 this.txtRemarks .Multiline = true;
 this.txtRemarks .TabIndex = 0;
 this.pnlRemarks.Controls.Add(this.txtRemarks);
// 
//txtfk_CustomerType
// 
 this.txtfk_CustomerType = new System.Windows.Forms.TextBox();
 this.txtfk_CustomerType .Location = new System.Drawing.Point(172, 1);
 this.txtfk_CustomerType .Name = "txtfk_CustomerType";
 this.txtfk_CustomerType .Size = new System.Drawing.Size(160, 20);
 this.txtfk_CustomerType .TabIndex = 0;
 this.pnlfk_CustomerType.Controls.Add(this.txtfk_CustomerType);

// 
// lblId
// 
this.lblId = new System.Windows.Forms.Label();
this.lblId.BackColor = System.Drawing.Color.Transparent;
this.lblId.Location =new System.Drawing.Point(10, 1);
this.lblId.Name ="lblId";
this.lblId.Size = new System.Drawing.Size(160, 22);
this.lblId.TabIndex = 0;
 this.lblId .Text = "Id:";
this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlId.Controls.Add(this.lblId);
// 
// lblName
// 
this.lblName = new System.Windows.Forms.Label();
this.lblName.BackColor = System.Drawing.Color.Transparent;
this.lblName.Location =new System.Drawing.Point(10, 1);
this.lblName.Name ="lblName";
this.lblName.Size = new System.Drawing.Size(160, 22);
this.lblName.TabIndex = 0;
 this.lblName .Text = "Name:";
this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlName.Controls.Add(this.lblName);
// 
// lblLastName
// 
this.lblLastName = new System.Windows.Forms.Label();
this.lblLastName.BackColor = System.Drawing.Color.Transparent;
this.lblLastName.Location =new System.Drawing.Point(10, 1);
this.lblLastName.Name ="lblLastName";
this.lblLastName.Size = new System.Drawing.Size(160, 22);
this.lblLastName.TabIndex = 0;
 this.lblLastName .Text = "LastName:";
this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlLastName.Controls.Add(this.lblLastName);
// 
// lblUserid
// 
this.lblUserid = new System.Windows.Forms.Label();
this.lblUserid.BackColor = System.Drawing.Color.Transparent;
this.lblUserid.Location =new System.Drawing.Point(10, 1);
this.lblUserid.Name ="lblUserid";
this.lblUserid.Size = new System.Drawing.Size(160, 22);
this.lblUserid.TabIndex = 0;
 this.lblUserid .Text = "Userid:";
this.lblUserid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlUserid.Controls.Add(this.lblUserid);
// 
// lblEmail
// 
this.lblEmail = new System.Windows.Forms.Label();
this.lblEmail.BackColor = System.Drawing.Color.Transparent;
this.lblEmail.Location =new System.Drawing.Point(10, 1);
this.lblEmail.Name ="lblEmail";
this.lblEmail.Size = new System.Drawing.Size(160, 22);
this.lblEmail.TabIndex = 0;
 this.lblEmail .Text = "Email:";
this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlEmail.Controls.Add(this.lblEmail);
// 
// lblPhone
// 
this.lblPhone = new System.Windows.Forms.Label();
this.lblPhone.BackColor = System.Drawing.Color.Transparent;
this.lblPhone.Location =new System.Drawing.Point(10, 1);
this.lblPhone.Name ="lblPhone";
this.lblPhone.Size = new System.Drawing.Size(160, 22);
this.lblPhone.TabIndex = 0;
 this.lblPhone .Text = "Phone:";
this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlPhone.Controls.Add(this.lblPhone);
// 
// lblAddress
// 
this.lblAddress = new System.Windows.Forms.Label();
this.lblAddress.BackColor = System.Drawing.Color.Transparent;
this.lblAddress.Location =new System.Drawing.Point(10, 1);
this.lblAddress.Name ="lblAddress";
this.lblAddress.Size = new System.Drawing.Size(160, 22);
this.lblAddress.TabIndex = 0;
 this.lblAddress .Text = "Address:";
this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlAddress.Controls.Add(this.lblAddress);
// 
// lblRemarks
// 
this.lblRemarks = new System.Windows.Forms.Label();
this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
this.lblRemarks.Location =new System.Drawing.Point(10, 1);
this.lblRemarks.Name ="lblRemarks";
this.lblRemarks.Size = new System.Drawing.Size(160, 22);
this.lblRemarks.TabIndex = 0;
 this.lblRemarks .Text = "Remarks:";
this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlRemarks.Controls.Add(this.lblRemarks);
// 
// lblfk_CustomerType
// 
this.lblfk_CustomerType = new System.Windows.Forms.Label();
this.lblfk_CustomerType.BackColor = System.Drawing.Color.Transparent;
this.lblfk_CustomerType.Location =new System.Drawing.Point(10, 1);
this.lblfk_CustomerType.Name ="lblfk_CustomerType";
this.lblfk_CustomerType.Size = new System.Drawing.Size(160, 22);
this.lblfk_CustomerType.TabIndex = 0;
 this.lblfk_CustomerType .Text = "fk_CustomerType:";
this.lblfk_CustomerType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlfk_CustomerType.Controls.Add(this.lblfk_CustomerType);

}//<Control>
 private System.Windows.Forms.Panel pnlId; 
 private System.Windows.Forms.Panel pnlName; 
 private System.Windows.Forms.Panel pnlLastName; 
 private System.Windows.Forms.Panel pnlUserid; 
 private System.Windows.Forms.Panel pnlEmail; 
 private System.Windows.Forms.Panel pnlPhone; 
 private System.Windows.Forms.Panel pnlAddress; 
 private System.Windows.Forms.Panel pnlRemarks; 
 private System.Windows.Forms.Panel pnlfk_CustomerType; 

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtName; 
 private System.Windows.Forms.TextBox txtLastName; 
 private System.Windows.Forms.TextBox txtUserid; 
 private System.Windows.Forms.TextBox txtEmail; 
 private System.Windows.Forms.TextBox txtPhone; 
 private System.Windows.Forms.TextBox txtAddress; 
 private System.Windows.Forms.TextBox txtRemarks; 
 private System.Windows.Forms.TextBox txtfk_CustomerType; 

 private System.Windows.Forms.Label  lblId; 
 private System.Windows.Forms.Label  lblName; 
 private System.Windows.Forms.Label  lblLastName; 
 private System.Windows.Forms.Label  lblUserid; 
 private System.Windows.Forms.Label  lblEmail; 
 private System.Windows.Forms.Label  lblPhone; 
 private System.Windows.Forms.Label  lblAddress; 
 private System.Windows.Forms.Label  lblRemarks; 
 private System.Windows.Forms.Label  lblfk_CustomerType; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private Bsoft.Controls.LableFlowLayout flwLayout;
    }
}
