namespace RestoSys.Reports
{
    partial class TransactionReport
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
            this.btnSearch = new bsoftcontrols.fsButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStockSP = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDue = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCredit = new System.Windows.Forms.CheckBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDateFromTo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.lblUser = new System.Windows.Forms.Label();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.lblServiceCharge = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpDateFromTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(1085, 2);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Location = new System.Drawing.Point(961, 84);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 33);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.ThemeColor = System.Drawing.Color.Blue;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.colDate,
            this.colAmount,
            this.colDiscount,
            this.colServiceCharge,
            this.colVAT,
            this.colUser,
            this.colCustomer,
            this.colCredit,
            this.colDue,
            this.colTender,
            this.colReturn});
            this.grid.Location = new System.Drawing.Point(9, 170);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1094, 380);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 121;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 81;
            // 
            // colDiscount
            // 
            this.colDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Width = 88;
            // 
            // colServiceCharge
            // 
            this.colServiceCharge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colServiceCharge.HeaderText = "ServiceCharge";
            this.colServiceCharge.Name = "colServiceCharge";
            this.colServiceCharge.Width = 126;
            // 
            // colVAT
            // 
            this.colVAT.HeaderText = "VAT";
            this.colVAT.Name = "colVAT";
            // 
            // colUser
            // 
            this.colUser.HeaderText = "User";
            this.colUser.Name = "colUser";
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.Name = "colCustomer";
            // 
            // colCredit
            // 
            this.colCredit.HeaderText = "Credit";
            this.colCredit.Name = "colCredit";
            // 
            // colDue
            // 
            this.colDue.HeaderText = "Due";
            this.colDue.Name = "colDue";
            // 
            // colTender
            // 
            this.colTender.HeaderText = "Tender";
            this.colTender.Name = "colTender";
            // 
            // colReturn
            // 
            this.colReturn.HeaderText = "Return";
            this.colReturn.Name = "colReturn";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportToolbar});
            this.toolStrip1.Location = new System.Drawing.Point(968, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(71, 63);
            this.toolStrip1.TabIndex = 123;
            this.toolStrip1.TabStop = true;
            // 
            // ExportToolbar
            // 
            this.ExportToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportToolbar.Image = global::RestoSys.Properties.Resources.MS_Excel1;
            this.ExportToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToolbar.Name = "ExportToolbar";
            this.ExportToolbar.Size = new System.Drawing.Size(69, 60);
            this.ExportToolbar.Text = "E&xport";
            this.ExportToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExportToolbar.Click += new System.EventHandler(this.ExportToolbar_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Location = new System.Drawing.Point(206, 570);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(149, 22);
            this.lblAmount.TabIndex = 125;
            this.lblAmount.Text = "---";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(6, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 22);
            this.label5.TabIndex = 124;
            this.label5.Text = "Amount:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStockSP
            // 
            this.lblStockSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStockSP.BackColor = System.Drawing.Color.Transparent;
            this.lblStockSP.Location = new System.Drawing.Point(5, 594);
            this.lblStockSP.Name = "lblStockSP";
            this.lblStockSP.Size = new System.Drawing.Size(193, 22);
            this.lblStockSP.TabIndex = 124;
            this.lblStockSP.Text = "Discount:";
            this.lblStockSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Location = new System.Drawing.Point(205, 594);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(149, 22);
            this.lblDiscount.TabIndex = 125;
            this.lblDiscount.Text = "---";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboDue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboCredit);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.grpDateFromTo);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.cboUser);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(9, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Generation Search Conditions";
            // 
            // cboDue
            // 
            this.cboDue.AutoSize = true;
            this.cboDue.Location = new System.Drawing.Point(705, 28);
            this.cboDue.Name = "cboDue";
            this.cboDue.Size = new System.Drawing.Size(15, 14);
            this.cboDue.TabIndex = 147;
            this.cboDue.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(570, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 146;
            this.label2.Text = "Due Remaining:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCredit
            // 
            this.cboCredit.AutoSize = true;
            this.cboCredit.Location = new System.Drawing.Point(523, 28);
            this.cboCredit.Name = "cboCredit";
            this.cboCredit.Size = new System.Drawing.Size(15, 14);
            this.cboCredit.TabIndex = 145;
            this.cboCredit.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(145, 22);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(218, 23);
            this.txtCustomerName.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(388, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 144;
            this.label1.Text = "Credit Taken:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 144;
            this.label6.Text = "Customer Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpDateFromTo
            // 
            this.grpDateFromTo.BackColor = System.Drawing.Color.Transparent;
            this.grpDateFromTo.Controls.Add(this.label3);
            this.grpDateFromTo.Controls.Add(this.label4);
            this.grpDateFromTo.Controls.Add(this.dtFrom);
            this.grpDateFromTo.Controls.Add(this.dtTo);
            this.grpDateFromTo.Location = new System.Drawing.Point(20, 51);
            this.grpDateFromTo.Name = "grpDateFromTo";
            this.grpDateFromTo.Size = new System.Drawing.Size(385, 44);
            this.grpDateFromTo.TabIndex = 142;
            this.grpDateFromTo.TabStop = false;
            this.grpDateFromTo.Text = "Transaction Date";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "From :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(196, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "To :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtFrom
            // 
            this.dtFrom.Checked = false;
            this.dtFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(60, 18);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.ShowCheckBox = true;
            this.dtFrom.Size = new System.Drawing.Size(132, 23);
            this.dtFrom.TabIndex = 0;
            // 
            // dtTo
            // 
            this.dtTo.Checked = false;
            this.dtTo.CustomFormat = "dd/MMM/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(246, 18);
            this.dtTo.Name = "dtTo";
            this.dtTo.ShowCheckBox = true;
            this.dtTo.Size = new System.Drawing.Size(132, 23);
            this.dtTo.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Location = new System.Drawing.Point(439, 71);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 22);
            this.lblUser.TabIndex = 139;
            this.lblUser.Text = "User:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(505, 71);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(160, 24);
            this.cboUser.TabIndex = 138;
            // 
            // lblServiceCharge
            // 
            this.lblServiceCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblServiceCharge.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceCharge.Location = new System.Drawing.Point(533, 572);
            this.lblServiceCharge.Name = "lblServiceCharge";
            this.lblServiceCharge.Size = new System.Drawing.Size(149, 22);
            this.lblServiceCharge.TabIndex = 125;
            this.lblServiceCharge.Text = "---";
            this.lblServiceCharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(333, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 22);
            this.label8.TabIndex = 124;
            this.label8.Text = "Service Charge:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(332, 596);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 22);
            this.label9.TabIndex = 124;
            this.label9.Text = "VAT:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVAT
            // 
            this.lblVAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVAT.BackColor = System.Drawing.Color.Transparent;
            this.lblVAT.Location = new System.Drawing.Point(532, 596);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(149, 22);
            this.lblVAT.TabIndex = 125;
            this.lblVAT.Text = "---";
            this.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCredit
            // 
            this.lblCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCredit.BackColor = System.Drawing.Color.Transparent;
            this.lblCredit.Location = new System.Drawing.Point(911, 570);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(149, 22);
            this.lblCredit.TabIndex = 125;
            this.lblCredit.Text = "---";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(711, 570);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 22);
            this.label12.TabIndex = 124;
            this.label12.Text = "Credit:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(710, 594);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 22);
            this.label13.TabIndex = 124;
            this.label13.Text = "Due Remaining:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDue
            // 
            this.lblDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDue.BackColor = System.Drawing.Color.Transparent;
            this.lblDue.Location = new System.Drawing.Point(910, 594);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(149, 22);
            this.lblDue.TabIndex = 125;
            this.lblDue.Text = "---";
            this.lblDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TransactionReport
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 648);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.lblStockSP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblServiceCharge);
            this.Controls.Add(this.lblAmount);
            this.Name = "TransactionReport";
            this.Text = "Transaction Report";
            this.Load += new System.EventHandler(this.frmproductSumrpt_Load);
            this.Controls.SetChildIndex(this.lblAmount, 0);
            this.Controls.SetChildIndex(this.lblServiceCharge, 0);
            this.Controls.SetChildIndex(this.lblCredit, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.lblStockSP, 0);
            this.Controls.SetChildIndex(this.lblDue, 0);
            this.Controls.SetChildIndex(this.lblVAT, 0);
            this.Controls.SetChildIndex(this.lblDiscount, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDateFromTo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public bsoftcontrols.fsButton btnSearch;
        private System.Windows.Forms.DataGridView grid;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExportToolbar;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStockSP;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.ComboBox cboUser;
        public System.Windows.Forms.GroupBox grpDateFromTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtFrom;
        public System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturn;
        public System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cboDue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cboCredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServiceCharge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDue;












    }
}
