namespace RestoSys.Forms
{
    partial class frmPayWithDiscount
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sevenShoppingAmount = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.sevenPayAmount = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.txtTender = new Bsoft.Controls.NumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sevenReturn = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.btnSave = new bsoftcontrols.fsButton();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnReprint = new bsoftcontrols.fsButton();
            this.lblInWords = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sevenServiceCharge = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.label8 = new System.Windows.Forms.Label();
            this.sevenVat = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.label9 = new System.Windows.Forms.Label();
            this.sevenSubTotal = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.discountControl = new Bsoft.Controls.DiscountControl();
            this.btnBrowseCustomer = new bsoftcontrols.fsButton();
            this.btnCancelCustomer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(606, 2);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(78, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tender Amount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(78, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Shopping Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(78, 321);
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
            this.sevenShoppingAmount.Location = new System.Drawing.Point(295, 76);
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
            this.sevenPayAmount.Location = new System.Drawing.Point(295, 315);
            this.sevenPayAmount.Name = "sevenPayAmount";
            this.sevenPayAmount.Size = new System.Drawing.Size(263, 36);
            this.sevenPayAmount.TabIndex = 10;
            this.sevenPayAmount.TabStop = false;
            this.sevenPayAmount.Value = null;
            // 
            // txtTender
            // 
            this.txtTender.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTender.Location = new System.Drawing.Point(295, 357);
            this.txtTender.MaxLength = 10;
            this.txtTender.Name = "txtTender";
            this.txtTender.Size = new System.Drawing.Size(263, 31);
            this.txtTender.TabIndex = 0;
            this.txtTender.ValidationType = Bsoft.Controls.NumericTextBox.ValidationTypeEnum.Decimal;
            this.txtTender.Value = "";
            this.txtTender.TextChanged += new System.EventHandler(this.txtTender_TextChanged);
            this.txtTender.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtTender_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(78, 399);
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
            this.sevenReturn.ColorLight = System.Drawing.Color.Red;
            this.sevenReturn.DecimalShow = true;
            this.sevenReturn.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenReturn.ElementWidth = 10;
            this.sevenReturn.ItalicFactor = 0F;
            this.sevenReturn.Location = new System.Drawing.Point(295, 394);
            this.sevenReturn.Name = "sevenReturn";
            this.sevenReturn.Size = new System.Drawing.Size(263, 36);
            this.sevenReturn.TabIndex = 10;
            this.sevenReturn.TabStop = false;
            this.sevenReturn.Value = "";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(424, 485);
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
            this.btnCancel.Location = new System.Drawing.Point(529, 485);
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
            this.btnReprint.Location = new System.Drawing.Point(63, 483);
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
            this.lblInWords.Location = new System.Drawing.Point(35, 439);
            this.lblInWords.Name = "lblInWords";
            this.lblInWords.Size = new System.Drawing.Size(540, 22);
            this.lblInWords.TabIndex = 12;
            this.lblInWords.Text = "In Words";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(295, 46);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(231, 23);
            this.txtCustomerName.TabIndex = 15;
            this.txtCustomerName.TabStop = false;
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
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(78, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Service Charge";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sevenServiceCharge
            // 
            this.sevenServiceCharge.ArrayCount = 10;
            this.sevenServiceCharge.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenServiceCharge.ColorDark = System.Drawing.Color.Transparent;
            this.sevenServiceCharge.ColorLight = System.Drawing.Color.LawnGreen;
            this.sevenServiceCharge.DecimalShow = true;
            this.sevenServiceCharge.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenServiceCharge.ElementWidth = 10;
            this.sevenServiceCharge.ItalicFactor = 0F;
            this.sevenServiceCharge.Location = new System.Drawing.Point(295, 119);
            this.sevenServiceCharge.Name = "sevenServiceCharge";
            this.sevenServiceCharge.Size = new System.Drawing.Size(263, 36);
            this.sevenServiceCharge.TabIndex = 10;
            this.sevenServiceCharge.TabStop = false;
            this.sevenServiceCharge.Value = null;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(78, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "VAT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sevenVat
            // 
            this.sevenVat.ArrayCount = 10;
            this.sevenVat.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenVat.ColorDark = System.Drawing.Color.Transparent;
            this.sevenVat.ColorLight = System.Drawing.Color.LawnGreen;
            this.sevenVat.DecimalShow = true;
            this.sevenVat.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenVat.ElementWidth = 10;
            this.sevenVat.ItalicFactor = 0F;
            this.sevenVat.Location = new System.Drawing.Point(295, 239);
            this.sevenVat.Name = "sevenVat";
            this.sevenVat.Size = new System.Drawing.Size(263, 36);
            this.sevenVat.TabIndex = 10;
            this.sevenVat.TabStop = false;
            this.sevenVat.Value = null;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(78, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Sub Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sevenSubTotal
            // 
            this.sevenSubTotal.ArrayCount = 10;
            this.sevenSubTotal.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenSubTotal.ColorDark = System.Drawing.Color.Transparent;
            this.sevenSubTotal.ColorLight = System.Drawing.Color.LawnGreen;
            this.sevenSubTotal.DecimalShow = true;
            this.sevenSubTotal.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSubTotal.ElementWidth = 10;
            this.sevenSubTotal.ItalicFactor = 0F;
            this.sevenSubTotal.Location = new System.Drawing.Point(295, 196);
            this.sevenSubTotal.Name = "sevenSubTotal";
            this.sevenSubTotal.Size = new System.Drawing.Size(263, 36);
            this.sevenSubTotal.TabIndex = 10;
            this.sevenSubTotal.TabStop = false;
            this.sevenSubTotal.Value = null;
            // 
            // discountControl
            // 
            this.discountControl.Amount = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.discountControl.AutoSize = true;
            this.discountControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.discountControl.BackColor = System.Drawing.Color.Transparent;
            this.discountControl.DiscountAmount = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.discountControl.DiscountPercent = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.discountControl.Location = new System.Drawing.Point(295, 162);
            this.discountControl.Name = "discountControl";
            this.discountControl.Size = new System.Drawing.Size(273, 27);
            this.discountControl.TabIndex = 16;
            // 
            // btnBrowseCustomer
            // 
            this.btnBrowseCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseCustomer.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnBrowseCustomer.FlatAppearance.BorderSize = 0;
            this.btnBrowseCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseCustomer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBrowseCustomer.Location = new System.Drawing.Point(529, 46);
            this.btnBrowseCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowseCustomer.Name = "btnBrowseCustomer";
            this.btnBrowseCustomer.Size = new System.Drawing.Size(29, 23);
            this.btnBrowseCustomer.TabIndex = 11;
            this.btnBrowseCustomer.Text = "...";
            this.btnBrowseCustomer.ThemeColor = System.Drawing.Color.Blue;
            this.btnBrowseCustomer.UseVisualStyleBackColor = false;
            this.btnBrowseCustomer.Click += new System.EventHandler(this.btnBrowseCustomer_Click);
            // 
            // btnCancelCustomer
            // 
            this.btnCancelCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelCustomer.Image = global::RestoSys.Properties.Resources.cross_script;
            this.btnCancelCustomer.Location = new System.Drawing.Point(564, 48);
            this.btnCancelCustomer.Name = "btnCancelCustomer";
            this.btnCancelCustomer.Size = new System.Drawing.Size(21, 20);
            this.btnCancelCustomer.TabIndex = 17;
            this.btnCancelCustomer.TabStop = false;
            this.btnCancelCustomer.Click += new System.EventHandler(this.btnCancelCustomer_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(78, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Discount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(210, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 2);
            this.panel1.TabIndex = 18;
            // 
            // frmPayWithDiscount
            // 
            this.AcceptButton = this.btnSave;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelCustomer);
            this.Controls.Add(this.discountControl);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInWords);
            this.Controls.Add(this.btnBrowseCustomer);
            this.Controls.Add(this.btnReprint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTender);
            this.Controls.Add(this.sevenReturn);
            this.Controls.Add(this.sevenSubTotal);
            this.Controls.Add(this.sevenVat);
            this.Controls.Add(this.sevenServiceCharge);
            this.Controls.Add(this.sevenPayAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sevenShoppingAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "frmPayWithDiscount";
            this.Text = "Payment";
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.sevenShoppingAmount, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.sevenPayAmount, 0);
            this.Controls.SetChildIndex(this.sevenServiceCharge, 0);
            this.Controls.SetChildIndex(this.sevenVat, 0);
            this.Controls.SetChildIndex(this.sevenSubTotal, 0);
            this.Controls.SetChildIndex(this.sevenReturn, 0);
            this.Controls.SetChildIndex(this.txtTender, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnReprint, 0);
            this.Controls.SetChildIndex(this.btnBrowseCustomer, 0);
            this.Controls.SetChildIndex(this.lblInWords, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCustomerName, 0);
            this.Controls.SetChildIndex(this.discountControl, 0);
            this.Controls.SetChildIndex(this.btnCancelCustomer, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
 
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenShoppingAmount;
        private Bsoft.Controls .NumericTextBox txtTender;
        private System.Windows.Forms.Label label2;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenReturn;
        public bsoftcontrols.fsButton btnSave;
        public bsoftcontrols.fsButton btnCancel;
        public bsoftcontrols.fsButton btnReprint;
        private System.Windows.Forms.Label lblInWords;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        public DmitryBrant.CustomControls.SevenSegmentArray sevenPayAmount;
        private System.Windows.Forms.Label label7;
        public DmitryBrant.CustomControls.SevenSegmentArray sevenServiceCharge;
        private System.Windows.Forms.Label label8;
        public DmitryBrant.CustomControls.SevenSegmentArray sevenVat;
        private System.Windows.Forms.Label label9;
        public DmitryBrant.CustomControls.SevenSegmentArray sevenSubTotal;
        private Bsoft .Controls .DiscountControl discountControl;
        public bsoftcontrols.fsButton btnBrowseCustomer;
        private System.Windows.Forms.PictureBox btnCancelCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
