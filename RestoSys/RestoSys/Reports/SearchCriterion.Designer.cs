namespace RestoSys.UserControls
{
    partial class SearchCriterion
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblfk_Group = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.lblfk_Company = new System.Windows.Forms.Label();
            this.grpDateFromTo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFromPurchage = new System.Windows.Forms.DateTimePicker();
            this.dtToPurchage = new System.Windows.Forms.DateTimePicker();
            this.lblVendor = new System.Windows.Forms.Label();
            this.cboVendor = new System.Windows.Forms.ComboBox();
            this.ExporyDate = new System.Windows.Forms.Label();
            this.datePickerExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.grpDateFromTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(55, 28);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(105, 20);
            this.txtCode.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblfk_Group
            // 
            this.lblfk_Group.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Group.Location = new System.Drawing.Point(-7, 54);
            this.lblfk_Group.Name = "lblfk_Group";
            this.lblfk_Group.Size = new System.Drawing.Size(56, 22);
            this.lblfk_Group.TabIndex = 135;
            this.lblfk_Group.Text = "Group:";
            this.lblfk_Group.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Location = new System.Drawing.Point(3, 26);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 22);
            this.lblCode.TabIndex = 133;
            this.lblCode.Text = "Code :";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCompany
            // 
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(525, 54);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(160, 21);
            this.cboCompany.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 132;
            this.label6.Text = "Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(55, 54);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(160, 21);
            this.cboGroup.TabIndex = 4;
            // 
            // lblfk_Company
            // 
            this.lblfk_Company.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Company.Location = new System.Drawing.Point(456, 54);
            this.lblfk_Company.Name = "lblfk_Company";
            this.lblfk_Company.Size = new System.Drawing.Size(69, 22);
            this.lblfk_Company.TabIndex = 134;
            this.lblfk_Company.Text = "Company:";
            this.lblfk_Company.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpDateFromTo
            // 
            this.grpDateFromTo.BackColor = System.Drawing.Color.Transparent;
            this.grpDateFromTo.Controls.Add(this.label3);
            this.grpDateFromTo.Controls.Add(this.label4);
            this.grpDateFromTo.Controls.Add(this.dtFromPurchage);
            this.grpDateFromTo.Controls.Add(this.dtToPurchage);
            this.grpDateFromTo.Location = new System.Drawing.Point(279, 2);
            this.grpDateFromTo.Name = "grpDateFromTo";
            this.grpDateFromTo.Size = new System.Drawing.Size(385, 44);
            this.grpDateFromTo.TabIndex = 131;
            this.grpDateFromTo.TabStop = false;
            this.grpDateFromTo.Text = "Purchase Date";
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
            // dtFromPurchage
            // 
            this.dtFromPurchage.Checked = false;
            this.dtFromPurchage.CustomFormat = "dd/MMM/yyyy";
            this.dtFromPurchage.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromPurchage.Location = new System.Drawing.Point(60, 18);
            this.dtFromPurchage.Name = "dtFromPurchage";
            this.dtFromPurchage.ShowCheckBox = true;
            this.dtFromPurchage.Size = new System.Drawing.Size(132, 20);
            this.dtFromPurchage.TabIndex = 0;
            // 
            // dtToPurchage
            // 
            this.dtToPurchage.Checked = false;
            this.dtToPurchage.CustomFormat = "dd/MMM/yyyy";
            this.dtToPurchage.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToPurchage.Location = new System.Drawing.Point(246, 18);
            this.dtToPurchage.Name = "dtToPurchage";
            this.dtToPurchage.ShowCheckBox = true;
            this.dtToPurchage.Size = new System.Drawing.Size(132, 20);
            this.dtToPurchage.TabIndex = 1;
            // 
            // lblVendor
            // 
            this.lblVendor.BackColor = System.Drawing.Color.Transparent;
            this.lblVendor.Location = new System.Drawing.Point(222, 54);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(60, 22);
            this.lblVendor.TabIndex = 129;
            this.lblVendor.Text = "Vendor:";
            this.lblVendor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboVendor
            // 
            this.cboVendor.FormattingEnabled = true;
            this.cboVendor.Location = new System.Drawing.Point(288, 54);
            this.cboVendor.Name = "cboVendor";
            this.cboVendor.Size = new System.Drawing.Size(160, 21);
            this.cboVendor.TabIndex = 3;
            // 
            // ExporyDate
            // 
            this.ExporyDate.Location = new System.Drawing.Point(196, 78);
            this.ExporyDate.Name = "ExporyDate";
            this.ExporyDate.Size = new System.Drawing.Size(135, 21);
            this.ExporyDate.TabIndex = 137;
            this.ExporyDate.Text = "Expires on or Before :";
            this.ExporyDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // datePickerExpiryDate
            // 
            this.datePickerExpiryDate.Checked = false;
            this.datePickerExpiryDate.CustomFormat = "dd/MMM/yyyy";
            this.datePickerExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerExpiryDate.Location = new System.Drawing.Point(330, 78);
            this.datePickerExpiryDate.Name = "datePickerExpiryDate";
            this.datePickerExpiryDate.ShowCheckBox = true;
            this.datePickerExpiryDate.Size = new System.Drawing.Size(132, 20);
            this.datePickerExpiryDate.TabIndex = 136;
            // 
            // SearchCriterion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ExporyDate);
            this.Controls.Add(this.datePickerExpiryDate);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblfk_Group);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.cboCompany);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboGroup);
            this.Controls.Add(this.lblfk_Company);
            this.Controls.Add(this.grpDateFromTo);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.cboVendor);
            this.Name = "SearchCriterion";
            this.Size = new System.Drawing.Size(721, 109);
            this.grpDateFromTo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCode;
        public System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtFromPurchage;
        public System.Windows.Forms.DateTimePicker dtToPurchage;
        public System.Windows.Forms.ComboBox cboVendor;
        public System.Windows.Forms.GroupBox grpDateFromTo;
        public System.Windows.Forms.Label lblfk_Group;
        public System.Windows.Forms.Label lblfk_Company;
        public System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label ExporyDate;
        public System.Windows.Forms.DateTimePicker datePickerExpiryDate;

    }
}
