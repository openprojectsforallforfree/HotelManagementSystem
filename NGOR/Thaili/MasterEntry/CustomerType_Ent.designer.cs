namespace UEMS
{
    partial class CustomerType_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerType_Ent));
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
            // CustomerType_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 510);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flwLayout);
            this.Controls.Add(this.btnOk);
            this.Name = "CustomerType_Ent";
            this.Text = "";
            this.Load += new System.EventHandler(this.CustomerType_Ent_Load);
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
// lblTitle
// 
this.pnlTitle = new System.Windows.Forms.Panel();
this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
this.pnlTitle.Location =new System.Drawing.Point(100, 122);
this.pnlTitle.Name ="pnlTitle";
this.pnlTitle.Size = new System.Drawing.Size(400, 45);
this.pnlTitle.TabIndex = 0;
this.pnlTitle.Margin = new System.Windows.Forms.Padding(1);
this.pnlTitle .AutoSize = true;
 this.pnlTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
 this.pnlTitle .Text = "Name";
 this.Controls.Add(this.pnlTitle);
// 
// lblDiscountPercent
// 
this.pnlDiscountPercent = new System.Windows.Forms.Panel();
this.pnlDiscountPercent.BackColor = System.Drawing.Color.Transparent;
this.pnlDiscountPercent.Location =new System.Drawing.Point(100, 172);
this.pnlDiscountPercent.Name ="pnlDiscountPercent";
this.pnlDiscountPercent.Size = new System.Drawing.Size(400, 45);
this.pnlDiscountPercent.TabIndex = 0;
this.pnlDiscountPercent.Margin = new System.Windows.Forms.Padding(1);
this.pnlDiscountPercent .AutoSize = true;
 this.pnlDiscountPercent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
 this.pnlDiscountPercent .Text = "Discount Percent";
 this.Controls.Add(this.pnlDiscountPercent);
// 
// lblRemarks
// 
this.pnlRemarks = new System.Windows.Forms.Panel();
this.pnlRemarks.BackColor = System.Drawing.Color.Transparent;
this.pnlRemarks.Location =new System.Drawing.Point(100, 222);
this.pnlRemarks.Name ="pnlRemarks";
this.pnlRemarks.Size = new System.Drawing.Size(400, 45);
this.pnlRemarks.TabIndex = 0;
this.pnlRemarks.Margin = new System.Windows.Forms.Padding(1);
this.pnlRemarks .AutoSize = true;
 this.pnlRemarks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
 this.pnlRemarks .Text = "Remarks";
 this.Controls.Add(this.pnlRemarks);

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
//txtTitle
// 
 this.txtTitle = new System.Windows.Forms.TextBox();
 this.txtTitle .Location = new System.Drawing.Point(172, 1);
 this.txtTitle .Name = "txtTitle";
 this.txtTitle .MaxLength = 50;
 this.txtTitle .Size = new System.Drawing.Size(160, 20);
 this.txtTitle .TabIndex = 0;
 this.pnlTitle.Controls.Add(this.txtTitle);
// 
//txtDiscountPercent
// 
 this.txtDiscountPercent = new System.Windows.Forms.TextBox();
 this.txtDiscountPercent .Location = new System.Drawing.Point(172, 1);
 this.txtDiscountPercent .Name = "txtDiscountPercent";
 this.txtDiscountPercent .MaxLength = 20;
 this.txtDiscountPercent .Size = new System.Drawing.Size(160, 20);
 this.txtDiscountPercent .TabIndex = 0;
 this.pnlDiscountPercent.Controls.Add(this.txtDiscountPercent);
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
// lblTitle
// 
this.lblTitle = new System.Windows.Forms.Label();
this.lblTitle.BackColor = System.Drawing.Color.Transparent;
this.lblTitle.Location =new System.Drawing.Point(10, 1);
this.lblTitle.Name ="lblTitle";
this.lblTitle.Size = new System.Drawing.Size(160, 22);
this.lblTitle.TabIndex = 0;
 this.lblTitle .Text = "Name:";
this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlTitle.Controls.Add(this.lblTitle);
// 
// lblDiscountPercent
// 
this.lblDiscountPercent = new System.Windows.Forms.Label();
this.lblDiscountPercent.BackColor = System.Drawing.Color.Transparent;
this.lblDiscountPercent.Location =new System.Drawing.Point(10, 1);
this.lblDiscountPercent.Name ="lblDiscountPercent";
this.lblDiscountPercent.Size = new System.Drawing.Size(160, 22);
this.lblDiscountPercent.TabIndex = 0;
 this.lblDiscountPercent .Text = "Discount Percent:";
this.lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlDiscountPercent.Controls.Add(this.lblDiscountPercent);
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

}//<Control>
 private System.Windows.Forms.Panel pnlId; 
 private System.Windows.Forms.Panel pnlTitle; 
 private System.Windows.Forms.Panel pnlDiscountPercent; 
 private System.Windows.Forms.Panel pnlRemarks; 

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtTitle; 
 private System.Windows.Forms.TextBox txtDiscountPercent; 
 private System.Windows.Forms.TextBox txtRemarks; 

 private System.Windows.Forms.Label  lblId; 
 private System.Windows.Forms.Label  lblTitle; 
 private System.Windows.Forms.Label  lblDiscountPercent; 
 private System.Windows.Forms.Label  lblRemarks; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private Bsoft.Controls.LableFlowLayout flwLayout;
    }
}
