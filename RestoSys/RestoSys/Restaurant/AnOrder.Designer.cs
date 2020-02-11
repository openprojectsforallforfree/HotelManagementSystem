namespace RestoSys.RestaurantBilling
{
    partial class AnOrder
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

        #region Component Designer generated code

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
            this.fsButtonCancel = new bsoftcontrols.fsButton();
            this.btnRemoveItem = new bsoftcontrols.fsButton();
            this.btnAddItem = new bsoftcontrols.fsButton();
            this.btnSave = new bsoftcontrols.fsButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridSummary = new System.Windows.Forms.DataGridView();
            this.btnCalculateDiscount = new bsoftcontrols.fsButton();
            this.discountControl = new Bsoft.Controls.Discount();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // fsButtonCancel
            // 
            this.fsButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fsButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.fsButtonCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.fsButtonCancel.FlatAppearance.BorderSize = 0;
            this.fsButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fsButtonCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fsButtonCancel.Location = new System.Drawing.Point(707, 547);
            this.fsButtonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.fsButtonCancel.Name = "fsButtonCancel";
            this.fsButtonCancel.Size = new System.Drawing.Size(63, 29);
            this.fsButtonCancel.TabIndex = 2;
            this.fsButtonCancel.Text = "Cancel";
            this.fsButtonCancel.ThemeColor = System.Drawing.Color.Blue;
            this.fsButtonCancel.UseVisualStyleBackColor = false;
            this.fsButtonCancel.Click += new System.EventHandler(this.fsButtonCancel_Click_1);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRemoveItem.Location = new System.Drawing.Point(510, 547);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(113, 29);
            this.btnRemoveItem.TabIndex = 0;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.ThemeColor = System.Drawing.Color.Blue;
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddItem.Location = new System.Drawing.Point(420, 547);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(80, 29);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.ThemeColor = System.Drawing.Color.Blue;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(635, 547);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 29);
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
            this.Description,
            this.Quantity,
            this.code,
            this.purchageId,
            this.CostPrice,
            this.ProductId,
            this.Rate,
            this.Amount,
            this.Discount,
            this.netAmount,
            this.Remarks});
            this.grid.Location = new System.Drawing.Point(3, 35);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(767, 320);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 6;
            this.grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEndEdit);
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
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 86;
            // 
            // code
            // 
            this.code.HeaderText = "Group_Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Visible = false;
            // 
            // purchageId
            // 
            this.purchageId.HeaderText = "PurchaseId";
            this.purchageId.Name = "purchageId";
            this.purchageId.ReadOnly = true;
            this.purchageId.Visible = false;
            // 
            // CostPrice
            // 
            this.CostPrice.HeaderText = "colCostPrice";
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            this.CostPrice.Visible = false;
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductId.HeaderText = "Product";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
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
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Visible = false;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(11, 9);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(49, 16);
            this.lblTable.TabIndex = 199;
            this.lblTable.Text = "Bill For";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 201;
            this.label1.Text = "Discount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridSummary
            // 
            this.gridSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSummary.Location = new System.Drawing.Point(486, 362);
            this.gridSummary.Name = "gridSummary";
            this.gridSummary.Size = new System.Drawing.Size(284, 173);
            this.gridSummary.TabIndex = 202;
            this.gridSummary.TabStop = false;
            // 
            // btnCalculateDiscount
            // 
            this.btnCalculateDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalculateDiscount.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculateDiscount.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCalculateDiscount.FlatAppearance.BorderSize = 0;
            this.btnCalculateDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateDiscount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCalculateDiscount.Location = new System.Drawing.Point(14, 427);
            this.btnCalculateDiscount.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalculateDiscount.Name = "btnCalculateDiscount";
            this.btnCalculateDiscount.Size = new System.Drawing.Size(80, 29);
            this.btnCalculateDiscount.TabIndex = 9;
            this.btnCalculateDiscount.Text = "Discount Estimator";
            this.btnCalculateDiscount.ThemeColor = System.Drawing.Color.Blue;
            this.btnCalculateDiscount.UseVisualStyleBackColor = false;
            this.btnCalculateDiscount.Click += new System.EventHandler(this.btnCalculateDiscount_Click);
            // 
            // discountControl
            // 
            this.discountControl.Amount = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.discountControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.discountControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountControl.Location = new System.Drawing.Point(14, 362);
            this.discountControl.Margin = new System.Windows.Forms.Padding(4);
            this.discountControl.Name = "discountControl";
            this.discountControl.Size = new System.Drawing.Size(287, 28);
            this.discountControl.TabIndex = 8;
            this.discountControl.DiscountUpdated += new Bsoft.Controls.Discount.discountUpdatedH(this.discountControl_DiscountUpdated);
            // 
            // AnOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnCalculateDiscount);
            this.Controls.Add(this.gridSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discountControl);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.fsButtonCancel);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grid);
            this.Name = "AnOrder";
            this.Size = new System.Drawing.Size(773, 584);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public bsoftcontrols.fsButton fsButtonCancel;
        public bsoftcontrols.fsButton btnRemoveItem;
        public bsoftcontrols.fsButton btnAddItem;
        public bsoftcontrols.fsButton btnSave;
        public System.Windows.Forms.DataGridView grid;
        public System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private Bsoft.Controls.Discount discountControl;
        private System.Windows.Forms.Label label1;
        public bsoftcontrols.fsButton btnCalculateDiscount;
        public System.Windows.Forms.DataGridView gridSummary;
    }
}
