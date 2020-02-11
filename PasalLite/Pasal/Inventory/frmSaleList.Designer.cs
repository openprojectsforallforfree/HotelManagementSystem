namespace Pasal.Inventory
{
    partial class frmSaleList
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpurchageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new bsoftcontrols.fsButton();
            this.btnAddItem = new bsoftcontrols.fsButton();
            this.txtTotalCash = new Bsoft.Controls.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalDiscount = new Bsoft.Controls.NumericTextBox();
            this.btnRemoveItem = new bsoftcontrols.fsButton();
            this.fsButtonCancel = new bsoftcontrols.fsButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(876, 2);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            this.colId,
            this.grp_Code,
            this.colpurchageId,
            this.colCostPrice,
            this.colfk_Product,
            this.colDescription,
            this.colQuantity,
            this.colRate,
            this.colAmount,
            this.colDiscount,
            this.colnetAmount,
            this.colRemarks,
            this.colDate,
            this.colUser});
            this.grid.Location = new System.Drawing.Point(12, 37);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(891, 388);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 8;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            this.grid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grid_MouseDoubleClick);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // grp_Code
            // 
            this.grp_Code.HeaderText = "Group_Code";
            this.grp_Code.Name = "grp_Code";
            this.grp_Code.Visible = false;
            // 
            // colpurchageId
            // 
            this.colpurchageId.HeaderText = "PurchaseId";
            this.colpurchageId.Name = "colpurchageId";
            this.colpurchageId.Visible = false;
            // 
            // colCostPrice
            // 
            this.colCostPrice.HeaderText = "colCostPrice";
            this.colCostPrice.Name = "colCostPrice";
            this.colCostPrice.Visible = false;
            // 
            // colfk_Product
            // 
            this.colfk_Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_Product.HeaderText = "Product";
            this.colfk_Product.Name = "colfk_Product";
            this.colfk_Product.Visible = false;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 200;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 86;
            // 
            // colRate
            // 
            this.colRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colRate.HeaderText = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.Width = 63;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 81;
            // 
            // colDiscount
            // 
            this.colDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Width = 88;
            // 
            // colnetAmount
            // 
            this.colnetAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colnetAmount.HeaderText = "Net Amount";
            this.colnetAmount.Name = "colnetAmount";
            this.colnetAmount.Width = 98;
            // 
            // colRemarks
            // 
            this.colRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemarks.HeaderText = "Remarks";
            this.colRemarks.Name = "colRemarks";
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = false;
            // 
            // colUser
            // 
            this.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colUser.HeaderText = "User";
            this.colUser.Name = "colUser";
            this.colUser.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(797, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 18);
            this.label11.TabIndex = 167;
            this.label11.Text = "Total Amount";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(763, 503);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 33);
            this.btnSave.TabIndex = 169;
            this.btnSave.Text = "Ok";
            this.btnSave.ThemeColor = System.Drawing.Color.Blue;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddItem.Location = new System.Drawing.Point(674, 503);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(80, 33);
            this.btnAddItem.TabIndex = 169;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.ThemeColor = System.Drawing.Color.Blue;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtTotalCash
            // 
            this.txtTotalCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCash.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCash.Location = new System.Drawing.Point(681, 431);
            this.txtTotalCash.Name = "txtTotalCash";
            this.txtTotalCash.ReadOnly = true;
            this.txtTotalCash.Size = new System.Drawing.Size(217, 31);
            this.txtTotalCash.TabIndex = 170;
            this.txtTotalCash.Text = "0";
            this.txtTotalCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCash.ValidationType = Bsoft.Controls.NumericTextBox.ValidationTypeEnum.Decimal;
            this.txtTotalCash.Value = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 167;
            this.label1.Text = "Total Discount";
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalDiscount.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDiscount.Location = new System.Drawing.Point(445, 431);
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.ReadOnly = true;
            this.txtTotalDiscount.Size = new System.Drawing.Size(217, 31);
            this.txtTotalDiscount.TabIndex = 170;
            this.txtTotalDiscount.Text = "0";
            this.txtTotalDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalDiscount.ValidationType = Bsoft.Controls.NumericTextBox.ValidationTypeEnum.Decimal;
            this.txtTotalDiscount.Value = "0";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRemoveItem.Location = new System.Drawing.Point(552, 503);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(113, 33);
            this.btnRemoveItem.TabIndex = 169;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.ThemeColor = System.Drawing.Color.Blue;
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // fsButtonCancel
            // 
            this.fsButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fsButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.fsButtonCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.fsButtonCancel.FlatAppearance.BorderSize = 0;
            this.fsButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fsButtonCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fsButtonCancel.Location = new System.Drawing.Point(835, 503);
            this.fsButtonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.fsButtonCancel.Name = "fsButtonCancel";
            this.fsButtonCancel.Size = new System.Drawing.Size(63, 33);
            this.fsButtonCancel.TabIndex = 169;
            this.fsButtonCancel.Text = "Cancel";
            this.fsButtonCancel.ThemeColor = System.Drawing.Color.Blue;
            this.fsButtonCancel.UseVisualStyleBackColor = false;
            this.fsButtonCancel.Click += new System.EventHandler(this.fsButtonCancel_Click);
            // 
            // frmSaleList
            // 
            this.AcceptButton = this.btnSave;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 545);
            this.Controls.Add(this.txtTotalDiscount);
            this.Controls.Add(this.txtTotalCash);
            this.Controls.Add(this.fsButtonCancel);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grid);
            this.Name = "frmSaleList";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.frmSaleList_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSaleList_FormClosed);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnAddItem, 0);
            this.Controls.SetChildIndex(this.btnRemoveItem, 0);
            this.Controls.SetChildIndex(this.fsButtonCancel, 0);
            this.Controls.SetChildIndex(this.txtTotalCash, 0);
            this.Controls.SetChildIndex(this.txtTotalDiscount, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label11;
        public bsoftcontrols.fsButton btnSave;
        public bsoftcontrols.fsButton btnAddItem;
        private  Bsoft .Controls .NumericTextBox txtTotalCash;
        private System.Windows.Forms.Label label1;
        private  Bsoft .Controls .NumericTextBox txtTotalDiscount;
        public bsoftcontrols.fsButton btnRemoveItem;
        public bsoftcontrols.fsButton fsButtonCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn grp_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpurchageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser; 


    }
}
