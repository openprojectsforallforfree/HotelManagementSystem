namespace RestoSys.Account
{
    partial class PaymentDetails
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
            this.gridSummary = new System.Windows.Forms.DataGridView();
            this.fsButtonCancel = new bsoftcontrols.fsButton();
            this.btnSave = new bsoftcontrols.fsButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.BookingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkManual = new System.Windows.Forms.CheckBox();
            this.sevenTotalDue = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.lblDueAmt = new System.Windows.Forms.Label();
            this.txtAmountPaid = new Bsoft.Controls.VtextBox();
            this.lblPayamount = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            this.sevenDueAmount = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.lblcopy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(958, 2);
            this._closeButton.Size = new System.Drawing.Size(36, 37);
            // 
            // gridSummary
            // 
            this.gridSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSummary.Location = new System.Drawing.Point(13, 314);
            this.gridSummary.Margin = new System.Windows.Forms.Padding(4);
            this.gridSummary.Name = "gridSummary";
            this.gridSummary.Size = new System.Drawing.Size(369, 207);
            this.gridSummary.TabIndex = 206;
            this.gridSummary.TabStop = false;
            // 
            // fsButtonCancel
            // 
            this.fsButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fsButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.fsButtonCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.fsButtonCancel.FlatAppearance.BorderSize = 0;
            this.fsButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fsButtonCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fsButtonCancel.Location = new System.Drawing.Point(896, 487);
            this.fsButtonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.fsButtonCancel.Name = "fsButtonCancel";
            this.fsButtonCancel.Size = new System.Drawing.Size(84, 36);
            this.fsButtonCancel.TabIndex = 2;
            this.fsButtonCancel.Text = "Cancel";
            this.fsButtonCancel.ThemeColor = System.Drawing.Color.Blue;
            this.fsButtonCancel.UseVisualStyleBackColor = false;
            this.fsButtonCancel.Click += new System.EventHandler(this.fsButtonCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(800, 487);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Ok";
            this.btnSave.ThemeColor = System.Drawing.Color.Blue;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingId,
            this.ProductId,
            this.Description,
            this.Quantity,
            this.Rate,
            this.Amount,
            this.Discount,
            this.ServiceCharge,
            this.vat,
            this.netAmount,
            this.dueAmount,
            this.Remarks,
            this.colTableName});
            this.grid.Location = new System.Drawing.Point(13, 46);
            this.grid.Margin = new System.Windows.Forms.Padding(4);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(967, 266);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 3;
            this.grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellValueChanged);
            this.grid.CurrentCellDirtyStateChanged += new System.EventHandler(this.grid_CurrentCellDirtyStateChanged);
            // 
            // BookingId
            // 
            this.BookingId.HeaderText = "BookingId";
            this.BookingId.Name = "BookingId";
            this.BookingId.Visible = false;
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.HeaderText = "PAX";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 60;
            // 
            // Rate
            // 
            this.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 63;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 81;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Discount.DefaultCellStyle = dataGridViewCellStyle3;
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.Width = 88;
            // 
            // ServiceCharge
            // 
            this.ServiceCharge.HeaderText = "Service Charge";
            this.ServiceCharge.Name = "ServiceCharge";
            this.ServiceCharge.Visible = false;
            // 
            // vat
            // 
            this.vat.HeaderText = "VAT";
            this.vat.Name = "vat";
            this.vat.Visible = false;
            // 
            // netAmount
            // 
            this.netAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.netAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.netAmount.HeaderText = "Net Amount";
            this.netAmount.Name = "netAmount";
            this.netAmount.ReadOnly = true;
            this.netAmount.Width = 98;
            // 
            // dueAmount
            // 
            this.dueAmount.HeaderText = "Due Amount";
            this.dueAmount.Name = "dueAmount";
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Visible = false;
            // 
            // colTableName
            // 
            this.colTableName.HeaderText = "TableName";
            this.colTableName.Name = "colTableName";
            this.colTableName.Visible = false;
            // 
            // chkManual
            // 
            this.chkManual.AutoSize = true;
            this.chkManual.BackColor = System.Drawing.Color.Transparent;
            this.chkManual.ForeColor = System.Drawing.Color.White;
            this.chkManual.Location = new System.Drawing.Point(759, 18);
            this.chkManual.Name = "chkManual";
            this.chkManual.Size = new System.Drawing.Size(135, 21);
            this.chkManual.TabIndex = 207;
            this.chkManual.Text = "Manual Selection";
            this.chkManual.UseVisualStyleBackColor = false;
            this.chkManual.Visible = false;
            // 
            // sevenTotalDue
            // 
            this.sevenTotalDue.ArrayCount = 10;
            this.sevenTotalDue.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenTotalDue.ColorDark = System.Drawing.Color.Transparent;
            this.sevenTotalDue.ColorLight = System.Drawing.Color.LawnGreen;
            this.sevenTotalDue.DecimalShow = true;
            this.sevenTotalDue.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenTotalDue.ElementWidth = 10;
            this.sevenTotalDue.ItalicFactor = 0F;
            this.sevenTotalDue.Location = new System.Drawing.Point(707, 319);
            this.sevenTotalDue.Name = "sevenTotalDue";
            this.sevenTotalDue.Size = new System.Drawing.Size(246, 36);
            this.sevenTotalDue.TabIndex = 210;
            this.sevenTotalDue.TabStop = false;
            this.sevenTotalDue.Value = null;
            // 
            // lblDueAmt
            // 
            this.lblDueAmt.BackColor = System.Drawing.Color.Transparent;
            this.lblDueAmt.Location = new System.Drawing.Point(492, 325);
            this.lblDueAmt.Name = "lblDueAmt";
            this.lblDueAmt.Size = new System.Drawing.Size(201, 24);
            this.lblDueAmt.TabIndex = 211;
            this.lblDueAmt.Text = "Total Amount";
            this.lblDueAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.Location = new System.Drawing.Point(707, 374);
            this.txtAmountPaid.MaxLength = 10;
            this.txtAmountPaid.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAmountPaid.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(246, 31);
            this.txtAmountPaid.TabIndex = 0;
            this.txtAmountPaid.Text = "0";
            this.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountPaid.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.SignedDecimal;
            this.txtAmountPaid.Value = "0";
            this.txtAmountPaid.TextChanged += new System.EventHandler(this.txtAmountPaid_TextChanged);
            // 
            // lblPayamount
            // 
            this.lblPayamount.BackColor = System.Drawing.Color.Transparent;
            this.lblPayamount.Location = new System.Drawing.Point(492, 379);
            this.lblPayamount.Name = "lblPayamount";
            this.lblPayamount.Size = new System.Drawing.Size(201, 24);
            this.lblPayamount.TabIndex = 211;
            this.lblPayamount.Text = "Received Amount";
            this.lblPayamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDue
            // 
            this.lblDue.BackColor = System.Drawing.Color.Transparent;
            this.lblDue.Location = new System.Drawing.Point(492, 424);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(201, 24);
            this.lblDue.TabIndex = 211;
            this.lblDue.Text = "Due Amount";
            this.lblDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sevenDueAmount
            // 
            this.sevenDueAmount.ArrayCount = 10;
            this.sevenDueAmount.ColorBackground = System.Drawing.Color.Transparent;
            this.sevenDueAmount.ColorDark = System.Drawing.Color.Transparent;
            this.sevenDueAmount.ColorLight = System.Drawing.Color.LawnGreen;
            this.sevenDueAmount.DecimalShow = true;
            this.sevenDueAmount.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenDueAmount.ElementWidth = 10;
            this.sevenDueAmount.ItalicFactor = 0F;
            this.sevenDueAmount.Location = new System.Drawing.Point(707, 418);
            this.sevenDueAmount.Name = "sevenDueAmount";
            this.sevenDueAmount.Size = new System.Drawing.Size(246, 36);
            this.sevenDueAmount.TabIndex = 213;
            this.sevenDueAmount.TabStop = false;
            this.sevenDueAmount.Value = null;
            // 
            // lblcopy
            // 
            this.lblcopy.BackColor = System.Drawing.Color.Transparent;
            this.lblcopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcopy.Font = new System.Drawing.Font("Wingdings 3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblcopy.ForeColor = System.Drawing.Color.Green;
            this.lblcopy.Location = new System.Drawing.Point(959, 305);
            this.lblcopy.Name = "lblcopy";
            this.lblcopy.Size = new System.Drawing.Size(59, 137);
            this.lblcopy.TabIndex = 214;
            this.lblcopy.Text = "";
            this.lblcopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblcopy.Click += new System.EventHandler(this.lblcopy_Click);
            // 
            // PaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 534);
            this.Controls.Add(this.sevenDueAmount);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.lblDueAmt);
            this.Controls.Add(this.lblPayamount);
            this.Controls.Add(this.sevenTotalDue);
            this.Controls.Add(this.chkManual);
            this.Controls.Add(this.gridSummary);
            this.Controls.Add(this.fsButtonCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.lblcopy);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaymentDetails";
            this.Text = "PaymentDetails";
            this.Controls.SetChildIndex(this.lblcopy, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.fsButtonCancel, 0);
            this.Controls.SetChildIndex(this.gridSummary, 0);
            this.Controls.SetChildIndex(this.chkManual, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.sevenTotalDue, 0);
            this.Controls.SetChildIndex(this.lblPayamount, 0);
            this.Controls.SetChildIndex(this.lblDueAmt, 0);
            this.Controls.SetChildIndex(this.lblDue, 0);
            this.Controls.SetChildIndex(this.txtAmountPaid, 0);
            this.Controls.SetChildIndex(this.sevenDueAmount, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView gridSummary;
        public bsoftcontrols.fsButton fsButtonCancel;
        public bsoftcontrols.fsButton btnSave;
        public System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.CheckBox chkManual;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenTotalDue;
        private System.Windows.Forms.Label lblDueAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableName;
        private Bsoft.Controls.VtextBox txtAmountPaid;
        private System.Windows.Forms.Label lblPayamount;
        private System.Windows.Forms.Label lblDue;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenDueAmount;
        private System.Windows.Forms.Label lblcopy;
    }
}