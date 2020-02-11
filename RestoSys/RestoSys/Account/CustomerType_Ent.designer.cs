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
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDiscountPercent = new System.Windows.Forms.Panel();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.txtDiscountPercent = new Bsoft.Controls.VtextBox();
            this.pnlRemarks = new System.Windows.Forms.Panel();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.pnlDiscountPercent.SuspendLayout();
            this.pnlRemarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(593, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(321, 185);
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
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(227, 185);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(249, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 23);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.AutoSize = true;
            this.pnlTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.Controls.Add(this.txtTitle);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(30, 50);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(1);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(372, 27);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.Text = "Name";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(172, 1);
            this.txtTitle.MaxLength = 50;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(197, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(10, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Name:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDiscountPercent
            // 
            this.pnlDiscountPercent.AutoSize = true;
            this.pnlDiscountPercent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDiscountPercent.BackColor = System.Drawing.Color.Transparent;
            this.pnlDiscountPercent.Controls.Add(this.lblDiscountPercent);
            this.pnlDiscountPercent.Controls.Add(this.txtDiscountPercent);
            this.pnlDiscountPercent.Location = new System.Drawing.Point(30, 79);
            this.pnlDiscountPercent.Margin = new System.Windows.Forms.Padding(1);
            this.pnlDiscountPercent.Name = "pnlDiscountPercent";
            this.pnlDiscountPercent.Size = new System.Drawing.Size(276, 26);
            this.pnlDiscountPercent.TabIndex = 0;
            this.pnlDiscountPercent.Text = "Discount Percent";
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscountPercent.Location = new System.Drawing.Point(10, 1);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(160, 22);
            this.lblDiscountPercent.TabIndex = 0;
            this.lblDiscountPercent.Text = "Discount Percent:";
            this.lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(172, 0);
            this.txtDiscountPercent.MaxLength = 5;
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(101, 23);
            this.txtDiscountPercent.TabIndex = 10;
            this.txtDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountPercent.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtDiscountPercent.Value = "";
            // 
            // pnlRemarks
            // 
            this.pnlRemarks.AutoSize = true;
            this.pnlRemarks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRemarks.BackColor = System.Drawing.Color.Transparent;
            this.pnlRemarks.Controls.Add(this.txtRemarks);
            this.pnlRemarks.Controls.Add(this.lblRemarks);
            this.pnlRemarks.Location = new System.Drawing.Point(30, 108);
            this.pnlRemarks.Margin = new System.Windows.Forms.Padding(1);
            this.pnlRemarks.Name = "pnlRemarks";
            this.pnlRemarks.Size = new System.Drawing.Size(575, 54);
            this.pnlRemarks.TabIndex = 0;
            this.pnlRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(172, 1);
            this.txtRemarks.MaxLength = 150;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(400, 50);
            this.txtRemarks.TabIndex = 0;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Location = new System.Drawing.Point(10, 1);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(160, 22);
            this.lblRemarks.TabIndex = 0;
            this.lblRemarks.Text = "Remarks:";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerType_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 223);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlDiscountPercent);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlRemarks);
            this.Name = "CustomerType_Ent";
            this.Text = "Customer Types Entry";
            this.Load += new System.EventHandler(this.CustomerType_Ent_Load);
            this.Controls.SetChildIndex(this.pnlRemarks, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.pnlDiscountPercent, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.pnlTitle, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlDiscountPercent.ResumeLayout(false);
            this.pnlDiscountPercent.PerformLayout();
            this.pnlRemarks.ResumeLayout(false);
            this.pnlRemarks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }//<Control> 
 private System.Windows.Forms.Panel pnlTitle; 
 private System.Windows.Forms.Panel pnlDiscountPercent; 
 private System.Windows.Forms.Panel pnlRemarks; 

 private System.Windows.Forms.TextBox txtId;
 private System.Windows.Forms.TextBox txtTitle;
 private System.Windows.Forms.TextBox txtRemarks; 
 private System.Windows.Forms.Label  lblTitle; 
 private System.Windows.Forms.Label  lblDiscountPercent; 
 private System.Windows.Forms.Label  lblRemarks; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private Bsoft.Controls.VtextBox txtDiscountPercent;
    }
}
