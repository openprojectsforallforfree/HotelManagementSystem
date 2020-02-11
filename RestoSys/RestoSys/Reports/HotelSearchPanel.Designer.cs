namespace RestoSys.Reports
{
    partial class HotelSearchPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.chkCanceled = new System.Windows.Forms.CheckBox();
            this.chkOccupied = new System.Windows.Forms.CheckBox();
            this.chkBooked = new System.Windows.Forms.CheckBox();
            this.chkcheckedOut = new System.Windows.Forms.CheckBox();
            this.cboDue = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDateFromTo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.lblUser = new System.Windows.Forms.Label();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.grpDateFromTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboRoomType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboRoom);
            this.groupBox1.Controls.Add(this.chkCanceled);
            this.groupBox1.Controls.Add(this.chkOccupied);
            this.groupBox1.Controls.Add(this.chkBooked);
            this.groupBox1.Controls.Add(this.chkcheckedOut);
            this.groupBox1.Controls.Add(this.cboDue);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.grpDateFromTo);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.cboUser);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 120);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Generation Search Conditions";
            // 
            // cboRoomType
            // 
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(397, 19);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(129, 21);
            this.cboRoomType.TabIndex = 21;
            this.cboRoomType.SelectedIndexChanged += new System.EventHandler(this.cboRoomType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(312, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Room Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRoom
            // 
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(397, 47);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(129, 21);
            this.cboRoom.TabIndex = 6;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // chkCanceled
            // 
            this.chkCanceled.AutoSize = true;
            this.chkCanceled.BackColor = System.Drawing.Color.Transparent;
            this.chkCanceled.Location = new System.Drawing.Point(665, 47);
            this.chkCanceled.Name = "chkCanceled";
            this.chkCanceled.Size = new System.Drawing.Size(73, 17);
            this.chkCanceled.TabIndex = 150;
            this.chkCanceled.Text = "Cancelled";
            this.chkCanceled.UseVisualStyleBackColor = false;
            this.chkCanceled.CheckedChanged += new System.EventHandler(this.chkCanceled_CheckedChanged);
            // 
            // chkOccupied
            // 
            this.chkOccupied.AutoSize = true;
            this.chkOccupied.BackColor = System.Drawing.Color.Transparent;
            this.chkOccupied.Checked = true;
            this.chkOccupied.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOccupied.Location = new System.Drawing.Point(555, 47);
            this.chkOccupied.Name = "chkOccupied";
            this.chkOccupied.Size = new System.Drawing.Size(72, 17);
            this.chkOccupied.TabIndex = 151;
            this.chkOccupied.Text = "Occupied";
            this.chkOccupied.UseVisualStyleBackColor = false;
            this.chkOccupied.CheckedChanged += new System.EventHandler(this.chkOccupied_CheckedChanged);
            // 
            // chkBooked
            // 
            this.chkBooked.AutoSize = true;
            this.chkBooked.BackColor = System.Drawing.Color.Transparent;
            this.chkBooked.Checked = true;
            this.chkBooked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBooked.Location = new System.Drawing.Point(555, 19);
            this.chkBooked.Name = "chkBooked";
            this.chkBooked.Size = new System.Drawing.Size(63, 17);
            this.chkBooked.TabIndex = 148;
            this.chkBooked.Text = "Booked";
            this.chkBooked.UseVisualStyleBackColor = false;
            this.chkBooked.CheckedChanged += new System.EventHandler(this.chkBooked_CheckedChanged);
            // 
            // chkcheckedOut
            // 
            this.chkcheckedOut.AutoSize = true;
            this.chkcheckedOut.BackColor = System.Drawing.Color.Transparent;
            this.chkcheckedOut.Location = new System.Drawing.Point(665, 19);
            this.chkcheckedOut.Name = "chkcheckedOut";
            this.chkcheckedOut.Size = new System.Drawing.Size(89, 17);
            this.chkcheckedOut.TabIndex = 149;
            this.chkcheckedOut.Text = "Checked Out";
            this.chkcheckedOut.UseVisualStyleBackColor = false;
            this.chkcheckedOut.CheckedChanged += new System.EventHandler(this.chkcheckedOut_CheckedChanged);
            // 
            // cboDue
            // 
            this.cboDue.AutoSize = true;
            this.cboDue.Location = new System.Drawing.Point(555, 75);
            this.cboDue.Name = "cboDue";
            this.cboDue.Size = new System.Drawing.Size(99, 17);
            this.cboDue.TabIndex = 147;
            this.cboDue.Text = "Due Remaining";
            this.cboDue.UseVisualStyleBackColor = true;
            this.cboDue.CheckedChanged += new System.EventHandler(this.cboDue_CheckedChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(320, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Room:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(114, 21);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(192, 20);
            this.txtCustomerName.TabIndex = 143;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(5, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
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
            this.grpDateFromTo.Location = new System.Drawing.Point(27, 46);
            this.grpDateFromTo.Name = "grpDateFromTo";
            this.grpDateFromTo.Size = new System.Drawing.Size(242, 68);
            this.grpDateFromTo.TabIndex = 142;
            this.grpDateFromTo.TabStop = false;
            this.grpDateFromTo.Text = "Date";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "From :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(30, 39);
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
            this.dtFrom.Location = new System.Drawing.Point(87, 16);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(132, 20);
            this.dtFrom.TabIndex = 0;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // dtTo
            // 
            this.dtTo.Checked = false;
            this.dtTo.CustomFormat = "dd/MMM/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(87, 42);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(132, 20);
            this.dtTo.TabIndex = 1;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Location = new System.Drawing.Point(331, 76);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 22);
            this.lblUser.TabIndex = 139;
            this.lblUser.Text = "User:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(397, 75);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(129, 21);
            this.cboUser.TabIndex = 138;
            this.cboUser.SelectedIndexChanged += new System.EventHandler(this.cboUser_SelectedIndexChanged);
            // 
            // HotelSearchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Name = "HotelSearchPanel";
            this.Size = new System.Drawing.Size(774, 150);
            this.Load += new System.EventHandler(this.HotelSearchPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDateFromTo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox chkCanceled;
        public System.Windows.Forms.CheckBox chkOccupied;
        public System.Windows.Forms.CheckBox chkBooked;
        public System.Windows.Forms.CheckBox chkcheckedOut;
        public System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.GroupBox grpDateFromTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtFrom;
        public System.Windows.Forms.DateTimePicker dtTo;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.ComboBox cboUser;
        public System.Windows.Forms.ComboBox cboRoom;
        public System.Windows.Forms.ComboBox cboRoomType;
        public System.Windows.Forms.CheckBox cboDue;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label1;
    }
}
