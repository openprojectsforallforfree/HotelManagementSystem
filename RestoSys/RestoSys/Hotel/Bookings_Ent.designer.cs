namespace UEMS
{
    partial class Bookings_Ent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookings_Ent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.lblCustmerName = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblfk_Master_Customer = new System.Windows.Forms.Label();
            this.btnSelectRoom = new bsoftcontrols.fsButton();
            this.lblBookingStatus = new System.Windows.Forms.Label();
            this.rdoOccupy = new System.Windows.Forms.RadioButton();
            this.rdoBooking = new System.Windows.Forms.RadioButton();
            this.btnCancelBooking = new bsoftcontrols.fsButton();
            this.btnSelectCustomer = new bsoftcontrols.fsButton();
            this.lblDiscountedRate = new System.Windows.Forms.Label();
            this.radioPerPerson = new System.Windows.Forms.RadioButton();
            this.radioPerRoom = new System.Windows.Forms.RadioButton();
            this.txtfk_Hotel_Master_Room = new Bsoft.Controls.VtextBox();
            this.txtfk_Master_Customer = new Bsoft.Controls.VtextBox();
            this.txtid = new Bsoft.Controls.VtextBox();
            this.txtNoofPerson = new Bsoft.Controls.VtextBox();
            this.Quantity = new Bsoft.Controls.VtextBox();
            this.txtRemarks = new Bsoft.Controls.VtextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblRoomSelect = new System.Windows.Forms.Label();
            this.txtRateType = new Bsoft.Controls.VtextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.lblSpan = new System.Windows.Forms.Label();
            this.txtRateDiscount = new Bsoft.Controls.VtextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gridSummary = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblamount = new System.Windows.Forms.Label();
            this.lblTotaldiscount = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblNET = new System.Windows.Forms.Label();
            this.lblDUE = new System.Windows.Forms.Label();
            this.lblSC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlus = new bsoftcontrols.fsButton();
            this.btnMinus = new bsoftcontrols.fsButton();
            this.calculatorButton1 = new PopupCalculator.CalculatorButton();
            this.fsButton1 = new bsoftcontrols.fsButton();
            this.fsButton2 = new bsoftcontrols.fsButton();
            this.listerRoom = new System.Windows.Forms.DataGridView();
            this.lblCancelDate = new System.Windows.Forms.Label();
            this.btnRatePercentCalculate = new bsoftcontrols.fsButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBooking = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listerRoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(920, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(486, 657);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Close";
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
            this.btnOk.Location = new System.Drawing.Point(391, 657);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblCustmerName
            // 
            this.lblCustmerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustmerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustmerName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCustmerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustmerName.ForeColor = System.Drawing.Color.Black;
            this.lblCustmerName.Location = new System.Drawing.Point(235, 63);
            this.lblCustmerName.Name = "lblCustmerName";
            this.lblCustmerName.Size = new System.Drawing.Size(448, 22);
            this.lblCustmerName.TabIndex = 0;
            this.lblCustmerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Location = new System.Drawing.Point(59, 251);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(160, 22);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "No of Person:";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Location = new System.Drawing.Point(59, 315);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(160, 22);
            this.lblRemarks.TabIndex = 0;
            this.lblRemarks.Text = "Remarks:";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblfk_Master_Customer
            // 
            this.lblfk_Master_Customer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblfk_Master_Customer.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Master_Customer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblfk_Master_Customer.ForeColor = System.Drawing.Color.Black;
            this.lblfk_Master_Customer.Location = new System.Drawing.Point(60, 63);
            this.lblfk_Master_Customer.Name = "lblfk_Master_Customer";
            this.lblfk_Master_Customer.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Master_Customer.TabIndex = 0;
            this.lblfk_Master_Customer.Text = "Customer:";
            this.lblfk_Master_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblfk_Master_Customer.Click += new System.EventHandler(this.bnSelectCustomer_Click);
            // 
            // btnSelectRoom
            // 
            this.btnSelectRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectRoom.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSelectRoom.FlatAppearance.BorderSize = 0;
            this.btnSelectRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectRoom.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectRoom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSelectRoom.Location = new System.Drawing.Point(706, 94);
            this.btnSelectRoom.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(123, 28);
            this.btnSelectRoom.TabIndex = 8;
            this.btnSelectRoom.Text = "Select Room";
            this.btnSelectRoom.Visible = false;
            this.btnSelectRoom.Click += new System.EventHandler(this.btnSelectRoom_Click);
            // 
            // lblBookingStatus
            // 
            this.lblBookingStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBookingStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingStatus.Location = new System.Drawing.Point(238, 158);
            this.lblBookingStatus.Name = "lblBookingStatus";
            this.lblBookingStatus.Size = new System.Drawing.Size(138, 22);
            this.lblBookingStatus.TabIndex = 15;
            this.lblBookingStatus.Text = "0";
            this.lblBookingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoOccupy
            // 
            this.rdoOccupy.AutoSize = true;
            this.rdoOccupy.Checked = true;
            this.rdoOccupy.Location = new System.Drawing.Point(15, 7);
            this.rdoOccupy.Name = "rdoOccupy";
            this.rdoOccupy.Size = new System.Drawing.Size(86, 21);
            this.rdoOccupy.TabIndex = 0;
            this.rdoOccupy.TabStop = true;
            this.rdoOccupy.Text = "Occupied";
            this.rdoOccupy.UseVisualStyleBackColor = true;
            this.rdoOccupy.CheckedChanged += new System.EventHandler(this.rdoOccupy_CheckedChanged);
            // 
            // rdoBooking
            // 
            this.rdoBooking.AutoSize = true;
            this.rdoBooking.Location = new System.Drawing.Point(163, 7);
            this.rdoBooking.Name = "rdoBooking";
            this.rdoBooking.Size = new System.Drawing.Size(74, 21);
            this.rdoBooking.TabIndex = 1;
            this.rdoBooking.Text = "Booked";
            this.rdoBooking.UseVisualStyleBackColor = true;
            this.rdoBooking.CheckedChanged += new System.EventHandler(this.rdoBooking_CheckedChanged);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelBooking.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancelBooking.FlatAppearance.BorderSize = 0;
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelBooking.Location = new System.Drawing.Point(605, 155);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(123, 29);
            this.btnCancelBooking.TabIndex = 6;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectCustomer.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSelectCustomer.FlatAppearance.BorderSize = 0;
            this.btnSelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCustomer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCustomer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSelectCustomer.Location = new System.Drawing.Point(706, 63);
            this.btnSelectCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(123, 28);
            this.btnSelectCustomer.TabIndex = 7;
            this.btnSelectCustomer.Text = "Select Customer";
            this.btnSelectCustomer.Click += new System.EventHandler(this.bnSelectCustomer_Click);
            // 
            // lblDiscountedRate
            // 
            this.lblDiscountedRate.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscountedRate.Location = new System.Drawing.Point(19, 219);
            this.lblDiscountedRate.Name = "lblDiscountedRate";
            this.lblDiscountedRate.Size = new System.Drawing.Size(22, 22);
            this.lblDiscountedRate.TabIndex = 15;
            this.lblDiscountedRate.Text = "0";
            this.lblDiscountedRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiscountedRate.Visible = false;
            // 
            // radioPerPerson
            // 
            this.radioPerPerson.AutoSize = true;
            this.radioPerPerson.Location = new System.Drawing.Point(163, 3);
            this.radioPerPerson.Name = "radioPerPerson";
            this.radioPerPerson.Size = new System.Drawing.Size(131, 21);
            this.radioPerPerson.TabIndex = 0;
            this.radioPerPerson.Text = "Per Person Rate";
            this.radioPerPerson.UseVisualStyleBackColor = true;
            this.radioPerPerson.CheckedChanged += new System.EventHandler(this.radioPerPerson_CheckedChanged);
            // 
            // radioPerRoom
            // 
            this.radioPerRoom.AutoSize = true;
            this.radioPerRoom.Checked = true;
            this.radioPerRoom.Location = new System.Drawing.Point(15, 4);
            this.radioPerRoom.Name = "radioPerRoom";
            this.radioPerRoom.Size = new System.Drawing.Size(123, 21);
            this.radioPerRoom.TabIndex = 1;
            this.radioPerRoom.TabStop = true;
            this.radioPerRoom.Text = "Per Room Rate";
            this.radioPerRoom.UseVisualStyleBackColor = true;
            this.radioPerRoom.CheckedChanged += new System.EventHandler(this.radioPerRate_CheckedChanged);
            // 
            // txtfk_Hotel_Master_Room
            // 
            this.txtfk_Hotel_Master_Room.Enabled = false;
            this.txtfk_Hotel_Master_Room.Location = new System.Drawing.Point(219, 2);
            this.txtfk_Hotel_Master_Room.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtfk_Hotel_Master_Room.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtfk_Hotel_Master_Room.Name = "txtfk_Hotel_Master_Room";
            this.txtfk_Hotel_Master_Room.Size = new System.Drawing.Size(61, 23);
            this.txtfk_Hotel_Master_Room.TabIndex = 0;
            this.txtfk_Hotel_Master_Room.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtfk_Hotel_Master_Room.Value = "";
            this.txtfk_Hotel_Master_Room.Visible = false;
            // 
            // txtfk_Master_Customer
            // 
            this.txtfk_Master_Customer.Enabled = false;
            this.txtfk_Master_Customer.Location = new System.Drawing.Point(143, 2);
            this.txtfk_Master_Customer.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtfk_Master_Customer.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtfk_Master_Customer.Name = "txtfk_Master_Customer";
            this.txtfk_Master_Customer.Size = new System.Drawing.Size(27, 23);
            this.txtfk_Master_Customer.TabIndex = 0;
            this.txtfk_Master_Customer.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtfk_Master_Customer.Value = "";
            this.txtfk_Master_Customer.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(22, 2);
            this.txtid.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtid.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(27, 23);
            this.txtid.TabIndex = 0;
            this.txtid.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtid.Value = "";
            this.txtid.Visible = false;
            // 
            // txtNoofPerson
            // 
            this.txtNoofPerson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNoofPerson.Location = new System.Drawing.Point(234, 251);
            this.txtNoofPerson.MaxLength = 2;
            this.txtNoofPerson.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNoofPerson.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNoofPerson.Name = "txtNoofPerson";
            this.txtNoofPerson.Size = new System.Drawing.Size(160, 23);
            this.txtNoofPerson.TabIndex = 1;
            this.txtNoofPerson.Text = "1";
            this.txtNoofPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNoofPerson.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Integer;
            this.txtNoofPerson.Value = "1";
            this.txtNoofPerson.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(382, 2);
            this.Quantity.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Quantity.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(82, 23);
            this.Quantity.TabIndex = 4;
            this.Quantity.Text = "1";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Quantity.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Integer;
            this.Quantity.Value = "1";
            this.Quantity.Visible = false;
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRemarks.Location = new System.Drawing.Point(234, 315);
            this.txtRemarks.MaxLength = 150;
            this.txtRemarks.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtRemarks.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(427, 41);
            this.txtRemarks.TabIndex = 3;
            this.txtRemarks.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtRemarks.Value = "";
            // 
            // lblRoom
            // 
            this.lblRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.Black;
            this.lblRoom.Location = new System.Drawing.Point(235, 94);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(448, 22);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomSelect
            // 
            this.lblRoomSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRoomSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomSelect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblRoomSelect.ForeColor = System.Drawing.Color.Black;
            this.lblRoomSelect.Location = new System.Drawing.Point(60, 94);
            this.lblRoomSelect.Name = "lblRoomSelect";
            this.lblRoomSelect.Size = new System.Drawing.Size(160, 22);
            this.lblRoomSelect.TabIndex = 0;
            this.lblRoomSelect.Text = "Room:";
            this.lblRoomSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRoomSelect.Click += new System.EventHandler(this.btnSelectRoom_Click);
            // 
            // txtRateType
            // 
            this.txtRateType.Enabled = false;
            this.txtRateType.Location = new System.Drawing.Point(298, 2);
            this.txtRateType.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtRateType.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtRateType.Name = "txtRateType";
            this.txtRateType.Size = new System.Drawing.Size(61, 23);
            this.txtRateType.TabIndex = 0;
            this.txtRateType.Text = "R";
            this.txtRateType.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtRateType.Value = "R";
            this.txtRateType.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(457, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "To :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(62, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "No Of Days :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(317, 214);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(137, 23);
            this.dtFrom.TabIndex = 10;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // dtTo
            // 
            this.dtTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtTo.CustomFormat = "dd/MMM/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(460, 214);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(137, 23);
            this.dtTo.TabIndex = 11;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // lblSpan
            // 
            this.lblSpan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSpan.BackColor = System.Drawing.Color.Transparent;
            this.lblSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpan.Location = new System.Drawing.Point(235, 214);
            this.lblSpan.Name = "lblSpan";
            this.lblSpan.Size = new System.Drawing.Size(76, 23);
            this.lblSpan.TabIndex = 0;
            this.lblSpan.Text = "0";
            this.lblSpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRateDiscount
            // 
            this.txtRateDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRateDiscount.Location = new System.Drawing.Point(234, 283);
            this.txtRateDiscount.MaxLength = 10;
            this.txtRateDiscount.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtRateDiscount.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtRateDiscount.Name = "txtRateDiscount";
            this.txtRateDiscount.Size = new System.Drawing.Size(160, 23);
            this.txtRateDiscount.TabIndex = 14;
            this.txtRateDiscount.Text = "0";
            this.txtRateDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateDiscount.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Integer;
            this.txtRateDiscount.Value = "0";
            this.txtRateDiscount.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(317, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "From :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(59, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rate Discount:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridSummary
            // 
            this.gridSummary.AllowUserToAddRows = false;
            this.gridSummary.AllowUserToDeleteRows = false;
            this.gridSummary.AllowUserToResizeColumns = false;
            this.gridSummary.AllowUserToResizeRows = false;
            this.gridSummary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridSummary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridSummary.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.gridSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSummary.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Rate,
            this.Amount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSummary.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridSummary.Enabled = false;
            this.gridSummary.EnableHeadersVisualStyles = false;
            this.gridSummary.GridColor = System.Drawing.Color.LightGray;
            this.gridSummary.Location = new System.Drawing.Point(47, 411);
            this.gridSummary.Margin = new System.Windows.Forms.Padding(4);
            this.gridSummary.Name = "gridSummary";
            this.gridSummary.ReadOnly = true;
            this.gridSummary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSummary.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridSummary.RowHeadersWidth = 175;
            this.gridSummary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridSummary.Size = new System.Drawing.Size(478, 241);
            this.gridSummary.TabIndex = 206;
            this.gridSummary.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 78;
            // 
            // Rate
            // 
            this.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Rate.HeaderText = "Days";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 80;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // lblamount
            // 
            this.lblamount.BackColor = System.Drawing.Color.Transparent;
            this.lblamount.Location = new System.Drawing.Point(19, 248);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(22, 22);
            this.lblamount.TabIndex = 15;
            this.lblamount.Text = "0";
            this.lblamount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblamount.Visible = false;
            // 
            // lblTotaldiscount
            // 
            this.lblTotaldiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotaldiscount.Location = new System.Drawing.Point(19, 270);
            this.lblTotaldiscount.Name = "lblTotaldiscount";
            this.lblTotaldiscount.Size = new System.Drawing.Size(22, 22);
            this.lblTotaldiscount.TabIndex = 15;
            this.lblTotaldiscount.Text = "0";
            this.lblTotaldiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotaldiscount.Visible = false;
            // 
            // lblVAT
            // 
            this.lblVAT.BackColor = System.Drawing.Color.Transparent;
            this.lblVAT.Location = new System.Drawing.Point(19, 303);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(22, 22);
            this.lblVAT.TabIndex = 15;
            this.lblVAT.Text = "0";
            this.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVAT.Visible = false;
            // 
            // lblNET
            // 
            this.lblNET.BackColor = System.Drawing.Color.Transparent;
            this.lblNET.Location = new System.Drawing.Point(19, 325);
            this.lblNET.Name = "lblNET";
            this.lblNET.Size = new System.Drawing.Size(22, 22);
            this.lblNET.TabIndex = 15;
            this.lblNET.Text = "0";
            this.lblNET.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNET.Visible = false;
            // 
            // lblDUE
            // 
            this.lblDUE.BackColor = System.Drawing.Color.Transparent;
            this.lblDUE.Location = new System.Drawing.Point(19, 347);
            this.lblDUE.Name = "lblDUE";
            this.lblDUE.Size = new System.Drawing.Size(22, 22);
            this.lblDUE.TabIndex = 15;
            this.lblDUE.Text = "0";
            this.lblDUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDUE.Visible = false;
            // 
            // lblSC
            // 
            this.lblSC.BackColor = System.Drawing.Color.Transparent;
            this.lblSC.Location = new System.Drawing.Point(19, 379);
            this.lblSC.Name = "lblSC";
            this.lblSC.Size = new System.Drawing.Size(22, 22);
            this.lblSC.TabIndex = 15;
            this.lblSC.Text = "0";
            this.lblSC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSC.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(47, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculation Details:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(50, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 10);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(544, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room Details:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPlus
            // 
            this.btnPlus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlus.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPlus.Location = new System.Drawing.Point(635, 214);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(26, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMinus.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMinus.Location = new System.Drawing.Point(608, 214);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(26, 23);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Text = "-";
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // calculatorButton1
            // 
            this.calculatorButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.calculatorButton1.AssociatedControl = null;
            this.calculatorButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calculatorButton1.BackgroundImage")));
            this.calculatorButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.calculatorButton1.FlatAppearance.BorderSize = 0;
            this.calculatorButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculatorButton1.focusColor = System.Drawing.Color.Bisque;
            this.calculatorButton1.Image = ((System.Drawing.Image)(resources.GetObject("calculatorButton1.Image")));
            this.calculatorButton1.Location = new System.Drawing.Point(404, 284);
            this.calculatorButton1.Name = "calculatorButton1";
            this.calculatorButton1.showTitle = true;
            this.calculatorButton1.Size = new System.Drawing.Size(23, 21);
            this.calculatorButton1.TabIndex = 13;
            this.calculatorButton1.UseVisualStyleBackColor = true;
            // 
            // fsButton1
            // 
            this.fsButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fsButton1.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.fsButton1.FlatAppearance.BorderSize = 0;
            this.fsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fsButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fsButton1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fsButton1.Location = new System.Drawing.Point(431, 251);
            this.fsButton1.Margin = new System.Windows.Forms.Padding(0);
            this.fsButton1.Name = "fsButton1";
            this.fsButton1.Size = new System.Drawing.Size(26, 23);
            this.fsButton1.TabIndex = 1;
            this.fsButton1.Text = "+";
            this.fsButton1.Click += new System.EventHandler(this.fsButton1_Click);
            // 
            // fsButton2
            // 
            this.fsButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fsButton2.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.fsButton2.FlatAppearance.BorderSize = 0;
            this.fsButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fsButton2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fsButton2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fsButton2.Location = new System.Drawing.Point(404, 251);
            this.fsButton2.Margin = new System.Windows.Forms.Padding(0);
            this.fsButton2.Name = "fsButton2";
            this.fsButton2.Size = new System.Drawing.Size(26, 23);
            this.fsButton2.TabIndex = 13;
            this.fsButton2.Text = "-";
            this.fsButton2.Click += new System.EventHandler(this.fsButton2_Click);
            // 
            // listerRoom
            // 
            this.listerRoom.AllowUserToAddRows = false;
            this.listerRoom.AllowUserToDeleteRows = false;
            this.listerRoom.AllowUserToResizeColumns = false;
            this.listerRoom.AllowUserToResizeRows = false;
            this.listerRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listerRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listerRoom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listerRoom.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.listerRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listerRoom.CausesValidation = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listerRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.listerRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listerRoom.DefaultCellStyle = dataGridViewCellStyle6;
            this.listerRoom.Enabled = false;
            this.listerRoom.EnableHeadersVisualStyles = false;
            this.listerRoom.GridColor = System.Drawing.Color.LightGray;
            this.listerRoom.Location = new System.Drawing.Point(547, 411);
            this.listerRoom.Margin = new System.Windows.Forms.Padding(4);
            this.listerRoom.Name = "listerRoom";
            this.listerRoom.ReadOnly = true;
            this.listerRoom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listerRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.listerRoom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listerRoom.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.listerRoom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.listerRoom.Size = new System.Drawing.Size(358, 241);
            this.listerRoom.TabIndex = 206;
            this.listerRoom.TabStop = false;
            // 
            // lblCancelDate
            // 
            this.lblCancelDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCancelDate.Location = new System.Drawing.Point(482, 7);
            this.lblCancelDate.Name = "lblCancelDate";
            this.lblCancelDate.Size = new System.Drawing.Size(50, 22);
            this.lblCancelDate.TabIndex = 15;
            this.lblCancelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCancelDate.Visible = false;
            // 
            // btnRatePercentCalculate
            // 
            this.btnRatePercentCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRatePercentCalculate.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnRatePercentCalculate.FlatAppearance.BorderSize = 0;
            this.btnRatePercentCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRatePercentCalculate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRatePercentCalculate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRatePercentCalculate.Location = new System.Drawing.Point(430, 283);
            this.btnRatePercentCalculate.Margin = new System.Windows.Forms.Padding(0);
            this.btnRatePercentCalculate.Name = "btnRatePercentCalculate";
            this.btnRatePercentCalculate.Size = new System.Drawing.Size(62, 23);
            this.btnRatePercentCalculate.TabIndex = 2;
            this.btnRatePercentCalculate.Text = "<";
            this.btnRatePercentCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnRatePercentCalculate, "Use percent Discount.");
            this.btnRatePercentCalculate.Click += new System.EventHandler(this.btnRatePercentCalculate_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(63, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rate Type:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioPerRoom);
            this.panel1.Controls.Add(this.radioPerPerson);
            this.panel1.Location = new System.Drawing.Point(238, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 31);
            this.panel1.TabIndex = 207;
            // 
            // grpBooking
            // 
            this.grpBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpBooking.BackColor = System.Drawing.Color.Transparent;
            this.grpBooking.Controls.Add(this.rdoBooking);
            this.grpBooking.Controls.Add(this.rdoOccupy);
            this.grpBooking.Location = new System.Drawing.Point(238, 152);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Size = new System.Drawing.Size(321, 31);
            this.grpBooking.TabIndex = 207;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(63, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Booking Status:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Bookings_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 694);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.calculatorButton1);
            this.Controls.Add(this.listerRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridSummary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBooking);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.lblSpan);
            this.Controls.Add(this.lblCancelDate);
            this.Controls.Add(this.lblSC);
            this.Controls.Add(this.lblDUE);
            this.Controls.Add(this.lblNET);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblTotaldiscount);
            this.Controls.Add(this.lblBookingStatus);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lblDiscountedRate);
            this.Controls.Add(this.btnSelectCustomer);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.fsButton2);
            this.Controls.Add(this.btnRatePercentCalculate);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.fsButton1);
            this.Controls.Add(this.btnSelectRoom);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.txtRateType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtfk_Hotel_Master_Room);
            this.Controls.Add(this.txtfk_Master_Customer);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.lblRoomSelect);
            this.Controls.Add(this.txtRateDiscount);
            this.Controls.Add(this.txtNoofPerson);
            this.Controls.Add(this.lblfk_Master_Customer);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustmerName);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "Bookings_Ent";
            this.Text = "Booking Form";
            this.Load += new System.EventHandler(this.Bookings_Ent_Load);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lbl1, 0);
            this.Controls.SetChildIndex(this.lblRemarks, 0);
            this.Controls.SetChildIndex(this.lblCustmerName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblRoom, 0);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.lblfk_Master_Customer, 0);
            this.Controls.SetChildIndex(this.txtNoofPerson, 0);
            this.Controls.SetChildIndex(this.txtRateDiscount, 0);
            this.Controls.SetChildIndex(this.lblRoomSelect, 0);
            this.Controls.SetChildIndex(this.Quantity, 0);
            this.Controls.SetChildIndex(this.txtid, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.txtfk_Master_Customer, 0);
            this.Controls.SetChildIndex(this.txtfk_Hotel_Master_Room, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtRateType, 0);
            this.Controls.SetChildIndex(this.btnCancelBooking, 0);
            this.Controls.SetChildIndex(this.btnSelectRoom, 0);
            this.Controls.SetChildIndex(this.fsButton1, 0);
            this.Controls.SetChildIndex(this.btnPlus, 0);
            this.Controls.SetChildIndex(this.btnRatePercentCalculate, 0);
            this.Controls.SetChildIndex(this.fsButton2, 0);
            this.Controls.SetChildIndex(this.btnMinus, 0);
            this.Controls.SetChildIndex(this.btnSelectCustomer, 0);
            this.Controls.SetChildIndex(this.lblDiscountedRate, 0);
            this.Controls.SetChildIndex(this.lblamount, 0);
            this.Controls.SetChildIndex(this.lblBookingStatus, 0);
            this.Controls.SetChildIndex(this.lblTotaldiscount, 0);
            this.Controls.SetChildIndex(this.lblVAT, 0);
            this.Controls.SetChildIndex(this.lblNET, 0);
            this.Controls.SetChildIndex(this.lblDUE, 0);
            this.Controls.SetChildIndex(this.lblSC, 0);
            this.Controls.SetChildIndex(this.lblCancelDate, 0);
            this.Controls.SetChildIndex(this.lblSpan, 0);
            this.Controls.SetChildIndex(this.dtTo, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.grpBooking, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridSummary, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.listerRoom, 0);
            this.Controls.SetChildIndex(this.calculatorButton1, 0);
            this.Controls.SetChildIndex(this.dtFrom, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listerRoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

}//<Control>

        private Bsoft .Controls .VtextBox txtid; 
 private Bsoft .Controls .VtextBox Quantity;
 private Bsoft.Controls.VtextBox txtNoofPerson;
 private Bsoft.Controls.VtextBox txtRemarks; 
 private System.Windows.Forms.Label  lblCustmerName;
 private System.Windows.Forms.Label lbl1;
 private System.Windows.Forms.Label lblRemarks; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.Label lblfk_Master_Customer;
        private Bsoft.Controls.VtextBox txtfk_Master_Customer;
        private bsoftcontrols.fsButton btnSelectRoom;
        private Bsoft.Controls.VtextBox txtfk_Hotel_Master_Room;
        private System.Windows.Forms.Label lblBookingStatus;
        private System.Windows.Forms.RadioButton rdoOccupy;
        private System.Windows.Forms.RadioButton rdoBooking;
        private bsoftcontrols.fsButton btnCancelBooking;
        private System.Windows.Forms.Label lblDiscountedRate;
        public bsoftcontrols.fsButton btnSelectCustomer;
        private System.Windows.Forms.RadioButton radioPerPerson;
        private System.Windows.Forms.RadioButton radioPerRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblRoomSelect;
        private Bsoft.Controls.VtextBox txtRateType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtFrom;
        public System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label lblSpan;
        private Bsoft.Controls.VtextBox txtRateDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView gridSummary;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label lblTotaldiscount;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblNET;
        private System.Windows.Forms.Label lblDUE;
        private System.Windows.Forms.Label lblSC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private bsoftcontrols.fsButton btnPlus;
        private bsoftcontrols.fsButton btnMinus;
        private PopupCalculator.CalculatorButton calculatorButton1;
        private bsoftcontrols.fsButton fsButton1;
        private bsoftcontrols.fsButton fsButton2;
        public System.Windows.Forms.DataGridView listerRoom;
        private System.Windows.Forms.Label lblCancelDate;
        private bsoftcontrols.fsButton btnRatePercentCalculate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel grpBooking;
        private System.Windows.Forms.Label label6;
        
    }
}
