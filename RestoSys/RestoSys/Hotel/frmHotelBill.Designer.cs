namespace RestoSys.Inventory
{
    partial class frmHotelBill
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
            this.panelBooking = new System.Windows.Forms.Panel();
            this.customerGrid = new System.Windows.Forms.DataGridView();
            this.panelRestaurant = new System.Windows.Forms.Panel();
            this.gridSummary = new System.Windows.Forms.DataGridView();
            this.btnSave = new bsoftcontrols.fsButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewBooking = new bsoftcontrols.fsButton();
            this.bnClose = new bsoftcontrols.fsButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckOut = new bsoftcontrols.fsButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(1163, 2);
            // 
            // panelBooking
            // 
            this.panelBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBooking.BackColor = System.Drawing.Color.Transparent;
            this.panelBooking.Location = new System.Drawing.Point(360, 54);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(828, 625);
            this.panelBooking.TabIndex = 4;
            // 
            // customerGrid
            // 
            this.customerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.customerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customerGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.customerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerGrid.CausesValidation = false;
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.customerName,
            this.colRooms,
            this.IdNumber});
            this.customerGrid.Location = new System.Drawing.Point(12, 120);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.Size = new System.Drawing.Size(342, 429);
            this.customerGrid.TabIndex = 3;
            this.customerGrid.SelectionChanged += new System.EventHandler(this.customerGrid_SelectionChanged);
            // 
            // panelRestaurant
            // 
            this.panelRestaurant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRestaurant.BackColor = System.Drawing.Color.Transparent;
            this.panelRestaurant.Location = new System.Drawing.Point(360, 685);
            this.panelRestaurant.Name = "panelRestaurant";
            this.panelRestaurant.Size = new System.Drawing.Size(828, 19);
            this.panelRestaurant.TabIndex = 11;
            this.panelRestaurant.Visible = false;
            // 
            // gridSummary
            // 
            this.gridSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gridSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridSummary.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.gridSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSummary.Location = new System.Drawing.Point(12, 580);
            this.gridSummary.Name = "gridSummary";
            this.gridSummary.Size = new System.Drawing.Size(258, 176);
            this.gridSummary.TabIndex = 210;
            this.gridSummary.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(956, 716);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Receive Payment";
            this.btnSave.ThemeColor = System.Drawing.Color.Blue;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 211;
            this.label1.Text = "Billing Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 212;
            this.label2.Text = "Current Customer List";
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnNewBooking.FlatAppearance.BorderSize = 0;
            this.btnNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBooking.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBooking.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNewBooking.Location = new System.Drawing.Point(15, 40);
            this.btnNewBooking.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(170, 29);
            this.btnNewBooking.TabIndex = 1;
            this.btnNewBooking.Text = "New Booking";
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // bnClose
            // 
            this.bnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnClose.BackColor = System.Drawing.Color.Transparent;
            this.bnClose.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.bnClose.FlatAppearance.BorderSize = 0;
            this.bnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnClose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bnClose.Location = new System.Drawing.Point(1115, 716);
            this.bnClose.Margin = new System.Windows.Forms.Padding(0);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(73, 29);
            this.bnClose.TabIndex = 7;
            this.bnClose.Text = "Close";
            this.bnClose.ThemeColor = System.Drawing.Color.Blue;
            this.bnClose.UseVisualStyleBackColor = false;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(71, 92);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(199, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 212;
            this.label3.Text = "Search:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckOut.Location = new System.Drawing.Point(818, 716);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(124, 29);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.ThemeColor = System.Drawing.Color.Blue;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 44;
            // 
            // customerName
            // 
            this.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customerName.HeaderText = "Name";
            this.customerName.Name = "customerName";
            this.customerName.Width = 70;
            // 
            // colRooms
            // 
            this.colRooms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRooms.HeaderText = "Rooms";
            this.colRooms.Name = "colRooms";
            this.colRooms.Width = 77;
            // 
            // IdNumber
            // 
            this.IdNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdNumber.HeaderText = "Id Number";
            this.IdNumber.Name = "IdNumber";
            this.IdNumber.Width = 98;
            // 
            // frmHotelBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 765);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnNewBooking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridSummary);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.customerGrid);
            this.Controls.Add(this.panelRestaurant);
            this.Controls.Add(this.panelBooking);
            this.Name = "frmHotelBill";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.frmHotelBill_Load);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.panelBooking, 0);
            this.Controls.SetChildIndex(this.panelRestaurant, 0);
            this.Controls.SetChildIndex(this.customerGrid, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.bnClose, 0);
            this.Controls.SetChildIndex(this.gridSummary, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnNewBooking, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnCheckOut, 0);
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBooking;
        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.Panel panelRestaurant;
        public System.Windows.Forms.DataGridView gridSummary;
        public bsoftcontrols.fsButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private bsoftcontrols.fsButton btnNewBooking;
        public bsoftcontrols.fsButton bnClose;
        private System.Windows.Forms.TextBox  txtSearch;
        private System.Windows.Forms.Label label3;
        public bsoftcontrols.fsButton btnCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNumber;

    }
}