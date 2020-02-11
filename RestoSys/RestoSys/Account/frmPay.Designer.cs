namespace RestoSys.Forms
{
    partial class frmPay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sevenShoppingAmount = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.sevenPayAmount = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.sevenDiscount = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.txtTender = new Bsoft.Controls.VtextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sevenReturn = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.btnSave = new bsoftcontrols.fsButton();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnReprint = new bsoftcontrols.fsButton();
            this.lblInWords = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fsBrowse = new bsoftcontrols.fsButton();
            this.btnCancelCustomer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(595, 2);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(77, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Discount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(77, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tender Amount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(77, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Shopping Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(77, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Amount to Pay";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sevenShoppingAmount
            // 
            this.sevenShoppingAmount.ArrayCount = 10;
            this.sevenShoppingAmount.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenShoppingAmount.ColorDark = System.Drawing.Color.Transparent;
            this.sevenShoppingAmount.ColorLight = System.Drawing.Color.LawnGreen;
            this.sevenShoppingAmount.DecimalShow = true;
            this.sevenShoppingAmount.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenShoppingAmount.ElementWidth = 10;
            this.sevenShoppingAmount.ItalicFactor = 0F;
            this.sevenShoppingAmount.Location = new System.Drawing.Point(296, 79);
            this.sevenShoppingAmount.Name = "sevenShoppingAmount";
            this.sevenShoppingAmount.Size = new System.Drawing.Size(263, 36);
            this.sevenShoppingAmount.TabIndex = 10;
            this.sevenShoppingAmount.TabStop = false;
            this.sevenShoppingAmount.Value = null;
            // 
            // sevenPayAmount
            // 
            this.sevenPayAmount.ArrayCount = 10;
            this.sevenPayAmount.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenPayAmount.ColorDark = System.Drawing.Color.Transparent;
            this.sevenPayAmount.ColorLight = System.Drawing.Color.LawnGreen;
            this.sevenPayAmount.DecimalShow = true;
            this.sevenPayAmount.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenPayAmount.ElementWidth = 10;
            this.sevenPayAmount.ItalicFactor = 0F;
            this.sevenPayAmount.Location = new System.Drawing.Point(296, 193);
            this.sevenPayAmount.Name = "sevenPayAmount";
            this.sevenPayAmount.Size = new System.Drawing.Size(263, 36);
            this.sevenPayAmount.TabIndex = 10;
            this.sevenPayAmount.TabStop = false;
            this.sevenPayAmount.Value = null;
            // 
            // sevenDiscount
            // 
            this.sevenDiscount.ArrayCount = 10;
            this.sevenDiscount.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenDiscount.ColorDark = System.Drawing.Color.Transparent;
            this.sevenDiscount.ColorLight = System.Drawing.Color.LawnGreen;
            this.sevenDiscount.DecimalShow = true;
            this.sevenDiscount.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenDiscount.ElementWidth = 10;
            this.sevenDiscount.ItalicFactor = 0F;
            this.sevenDiscount.Location = new System.Drawing.Point(296, 133);
            this.sevenDiscount.Name = "sevenDiscount";
            this.sevenDiscount.Size = new System.Drawing.Size(263, 36);
            this.sevenDiscount.TabIndex = 10;
            this.sevenDiscount.TabStop = false;
            this.sevenDiscount.Value = null;
            // 
            // txtTender
            // 
            this.txtTender.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTender.Location = new System.Drawing.Point(296, 240);
            this.txtTender.MaxLength = 10;
            this.txtTender.Name = "txtTender";
            this.txtTender.Size = new System.Drawing.Size(263, 31);
            this.txtTender.TabIndex = 0;
            this.txtTender.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtTender.Value = "";
            this.txtTender.TextChanged += new System.EventHandler(this.txtTender_TextChanged);
            this.txtTender.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtTender_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(77, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Return";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sevenReturn
            // 
            this.sevenReturn.ArrayCount = 10;
            this.sevenReturn.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenReturn.ColorDark = System.Drawing.Color.Transparent;
            this.sevenReturn.ColorLight = System.Drawing.Color.LawnGreen;
            this.sevenReturn.DecimalShow = true;
            this.sevenReturn.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenReturn.ElementWidth = 10;
            this.sevenReturn.ItalicFactor = 0F;
            this.sevenReturn.Location = new System.Drawing.Point(296, 286);
            this.sevenReturn.Name = "sevenReturn";
            this.sevenReturn.Size = new System.Drawing.Size(263, 36);
            this.sevenReturn.TabIndex = 10;
            this.sevenReturn.TabStop = false;
            this.sevenReturn.Value = null;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(413, 400);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Ok";
            this.btnSave.ThemeColor = System.Drawing.Color.Blue;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(518, 400);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeColor = System.Drawing.Color.Blue;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReprint
            // 
            this.btnReprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReprint.BackColor = System.Drawing.Color.Transparent;
            this.btnReprint.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnReprint.FlatAppearance.BorderSize = 0;
            this.btnReprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReprint.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReprint.Location = new System.Drawing.Point(52, 398);
            this.btnReprint.Margin = new System.Windows.Forms.Padding(0);
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.Size = new System.Drawing.Size(92, 29);
            this.btnReprint.TabIndex = 11;
            this.btnReprint.Text = "RePrint Bill";
            this.btnReprint.ThemeColor = System.Drawing.Color.Blue;
            this.btnReprint.UseVisualStyleBackColor = false;
            this.btnReprint.Visible = false;
            // 
            // lblInWords
            // 
            this.lblInWords.BackColor = System.Drawing.Color.Transparent;
            this.lblInWords.Location = new System.Drawing.Point(24, 359);
            this.lblInWords.Name = "lblInWords";
            this.lblInWords.Size = new System.Drawing.Size(540, 22);
            this.lblInWords.TabIndex = 12;
            this.lblInWords.Text = "In Words";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(295, 46);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(231, 23);
            this.txtCustomerName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(78, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Customer Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fsBrowse
            // 
            this.fsBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fsBrowse.BackColor = System.Drawing.Color.Transparent;
            this.fsBrowse.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.fsBrowse.FlatAppearance.BorderSize = 0;
            this.fsBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fsBrowse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fsBrowse.Location = new System.Drawing.Point(535, 46);
            this.fsBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.fsBrowse.Name = "fsBrowse";
            this.fsBrowse.Size = new System.Drawing.Size(29, 23);
            this.fsBrowse.TabIndex = 11;
            this.fsBrowse.Text = "...";
            this.fsBrowse.ThemeColor = System.Drawing.Color.Blue;
            this.fsBrowse.UseVisualStyleBackColor = false;
            this.fsBrowse.Click += new System.EventHandler(this.fsBrowse_Click);
            // 
            // btnCancelCustomer
            // 
            this.btnCancelCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelCustomer.Image = global::RestoSys.Properties.Resources.cross_script;
            this.btnCancelCustomer.Location = new System.Drawing.Point(567, 50);
            this.btnCancelCustomer.Name = "btnCancelCustomer";
            this.btnCancelCustomer.Size = new System.Drawing.Size(21, 20);
            this.btnCancelCustomer.TabIndex = 18;
            this.btnCancelCustomer.TabStop = false;
            this.btnCancelCustomer.Click += new System.EventHandler(this.btnCancelCustomer_Click);
            // 
            // frmPay
            // 
            this.AcceptButton = this.btnSave;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 438);
            this.Controls.Add(this.btnCancelCustomer);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInWords);
            this.Controls.Add(this.fsBrowse);
            this.Controls.Add(this.btnReprint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTender);
            this.Controls.Add(this.sevenReturn);
            this.Controls.Add(this.sevenPayAmount);
            this.Controls.Add(this.sevenDiscount);
            this.Controls.Add(this.sevenShoppingAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmPay";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPay_Load);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.sevenShoppingAmount, 0);
            this.Controls.SetChildIndex(this.sevenDiscount, 0);
            this.Controls.SetChildIndex(this.sevenPayAmount, 0);
            this.Controls.SetChildIndex(this.sevenReturn, 0);
            this.Controls.SetChildIndex(this.txtTender, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnReprint, 0);
            this.Controls.SetChildIndex(this.fsBrowse, 0);
            this.Controls.SetChildIndex(this.lblInWords, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCustomerName, 0);
            this.Controls.SetChildIndex(this.btnCancelCustomer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
 
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenShoppingAmount;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenDiscount;
        private Bsoft.Controls.VtextBox txtTender;
        private System.Windows.Forms.Label label2;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenReturn;
        public bsoftcontrols.fsButton btnSave;
        public bsoftcontrols.fsButton btnCancel;
        public bsoftcontrols.fsButton btnReprint;
        private System.Windows.Forms.Label lblInWords;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        public DmitryBrant.CustomControls.SevenSegmentArray sevenPayAmount;
        public bsoftcontrols.fsButton fsBrowse;
        private System.Windows.Forms.PictureBox btnCancelCustomer;
    }
}
