namespace RestoSys.Forms
{
    partial class frmCreditManagementList
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
            this.colsale_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcust_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcust_userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcust_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcust_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsale_dueAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsale_CreditAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsale_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsale_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsale_Tender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsale_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsale_UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetPayment = new bsoftcontrols.fsButton();
            this.btnShowDetails = new bsoftcontrols.fsButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(914, 2);
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
            this.colsale_id,
            this.colcust_name,
            this.colcust_userid,
            this.colcust_address,
            this.colcust_phone,
            this.colsale_dueAmount,
            this.colsale_CreditAmount,
            this.colsale_Amount,
            this.colsale_Discount,
            this.colsale_Tender,
            this.colsale_date,
            this.colsale_UserId});
            this.grid.Location = new System.Drawing.Point(12, 37);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(924, 534);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 12;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // colsale_id
            // 
            this.colsale_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colsale_id.HeaderText = "id";
            this.colsale_id.Name = "colsale_id";
            this.colsale_id.Visible = false;
            // 
            // colcust_name
            // 
            this.colcust_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colcust_name.HeaderText = "Name";
            this.colcust_name.Name = "colcust_name";
            this.colcust_name.Width = 70;
            // 
            // colcust_userid
            // 
            this.colcust_userid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colcust_userid.HeaderText = "Userid";
            this.colcust_userid.Name = "colcust_userid";
            this.colcust_userid.Width = 74;
            // 
            // colcust_address
            // 
            this.colcust_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colcust_address.HeaderText = "Address";
            this.colcust_address.Name = "colcust_address";
            this.colcust_address.Width = 85;
            // 
            // colcust_phone
            // 
            this.colcust_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colcust_phone.HeaderText = "Phone";
            this.colcust_phone.Name = "colcust_phone";
            this.colcust_phone.Width = 74;
            // 
            // colsale_dueAmount
            // 
            this.colsale_dueAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colsale_dueAmount.HeaderText = "Due Amount";
            this.colsale_dueAmount.Name = "colsale_dueAmount";
            this.colsale_dueAmount.Width = 102;
            // 
            // colsale_CreditAmount
            // 
            this.colsale_CreditAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colsale_CreditAmount.HeaderText = "Credit Amount";
            this.colsale_CreditAmount.Name = "colsale_CreditAmount";
            this.colsale_CreditAmount.Width = 112;
            // 
            // colsale_Amount
            // 
            this.colsale_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colsale_Amount.HeaderText = "Purchase Amount";
            this.colsale_Amount.Name = "colsale_Amount";
            this.colsale_Amount.Width = 133;
            // 
            // colsale_Discount
            // 
            this.colsale_Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colsale_Discount.HeaderText = "Discount Given";
            this.colsale_Discount.Name = "colsale_Discount";
            this.colsale_Discount.Width = 118;
            // 
            // colsale_Tender
            // 
            this.colsale_Tender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colsale_Tender.HeaderText = "Tender Amount";
            this.colsale_Tender.Name = "colsale_Tender";
            this.colsale_Tender.Width = 120;
            // 
            // colsale_date
            // 
            this.colsale_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colsale_date.HeaderText = "Date";
            this.colsale_date.Name = "colsale_date";
            this.colsale_date.Width = 63;
            // 
            // colsale_UserId
            // 
            this.colsale_UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colsale_UserId.HeaderText = "User";
            this.colsale_UserId.Name = "colsale_UserId";
            this.colsale_UserId.Width = 63;
            // 
            // btnGetPayment
            // 
            this.btnGetPayment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGetPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnGetPayment.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnGetPayment.FlatAppearance.BorderSize = 0;
            this.btnGetPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetPayment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPayment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGetPayment.Location = new System.Drawing.Point(488, 579);
            this.btnGetPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnGetPayment.Name = "btnGetPayment";
            this.btnGetPayment.Size = new System.Drawing.Size(112, 29);
            this.btnGetPayment.TabIndex = 13;
            this.btnGetPayment.Text = "Get Payment";
            this.btnGetPayment.ThemeColor = System.Drawing.Color.Blue;
            this.btnGetPayment.UseVisualStyleBackColor = false;
            this.btnGetPayment.Click += new System.EventHandler(this.btnGetPayment_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShowDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnShowDetails.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnShowDetails.FlatAppearance.BorderSize = 0;
            this.btnShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDetails.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnShowDetails.Location = new System.Drawing.Point(341, 579);
            this.btnShowDetails.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(134, 29);
            this.btnShowDetails.TabIndex = 14;
            this.btnShowDetails.Text = "Show Item Details";
            this.btnShowDetails.ThemeColor = System.Drawing.Color.Blue;
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // frmCreditManagementList
            // 
            this.AcceptButton = this.btnGetPayment;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 617);
            this.Controls.Add(this.btnGetPayment);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnShowDetails);
            this.Name = "frmCreditManagementList";
            this.Text = "Remaining Credits";
            this.Controls.SetChildIndex(this.btnShowDetails, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.btnGetPayment, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        } 

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsale_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcust_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcust_userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcust_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcust_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsale_dueAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsale_CreditAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsale_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsale_Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsale_Tender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsale_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsale_UserId;
        public bsoftcontrols.fsButton btnGetPayment;
        public bsoftcontrols.fsButton btnShowDetails;
    }
}
