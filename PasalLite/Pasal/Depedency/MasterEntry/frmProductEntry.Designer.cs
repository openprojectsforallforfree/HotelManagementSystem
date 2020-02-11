namespace Pasal.MasterEntry
{
    partial class frmProductEntry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.cboMeasureUnit = new System.Windows.Forms.ComboBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblfk_Company = new System.Windows.Forms.Label();
            this.lblfk_Group = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpTags = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblcolour = new System.Windows.Forms.Label();
            this.lblsizeunit = new System.Windows.Forms.Label();
            this.txtcolour = new System.Windows.Forms.TextBox();
            this.lblweightunit = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.cboSizeUnit = new System.Windows.Forms.ComboBox();
            this.cboWeightUnit = new System.Windows.Forms.ComboBox();
            this.txtweight = new Bsoft.Controls.NumericTextBox();
            this.txtsize = new Bsoft.Controls.NumericTextBox();
            this.fsColor = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtreorderpoint = new Bsoft.Controls.NumericTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(589, 2);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.lblRemarks);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.cboCompany);
            this.groupBox1.Controls.Add(this.cboMeasureUnit);
            this.groupBox1.Controls.Add(this.cboGroup);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblfk_Company);
            this.groupBox1.Controls.Add(this.lblfk_Group);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(220, 171);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(201, 77);
            this.txtRemarks.TabIndex = 5;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Location = new System.Drawing.Point(40, 171);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(160, 22);
            this.lblRemarks.TabIndex = 31;
            this.lblRemarks.Text = "Remarks:";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Location = new System.Drawing.Point(41, 112);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(160, 22);
            this.lblCode.TabIndex = 24;
            this.lblCode.Text = "Code:";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(221, 111);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(160, 23);
            this.txtCode.TabIndex = 3;
            // 
            // cboCompany
            // 
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(221, 81);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(160, 24);
            this.cboCompany.TabIndex = 2;
            // 
            // cboMeasureUnit
            // 
            this.cboMeasureUnit.FormattingEnabled = true;
            this.cboMeasureUnit.Location = new System.Drawing.Point(220, 141);
            this.cboMeasureUnit.Name = "cboMeasureUnit";
            this.cboMeasureUnit.Size = new System.Drawing.Size(160, 24);
            this.cboMeasureUnit.TabIndex = 4;
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(221, 52);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(160, 24);
            this.cboGroup.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(221, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 23);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(34, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selling Unit:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblfk_Company
            // 
            this.lblfk_Company.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Company.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblfk_Company.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblfk_Company.Location = new System.Drawing.Point(41, 82);
            this.lblfk_Company.Name = "lblfk_Company";
            this.lblfk_Company.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Company.TabIndex = 0;
            this.lblfk_Company.Text = "Company:";
            this.lblfk_Company.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblfk_Company.Click += new System.EventHandler(this.lblfk_Company_Click);
            // 
            // lblfk_Group
            // 
            this.lblfk_Group.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Group.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblfk_Group.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblfk_Group.Location = new System.Drawing.Point(41, 52);
            this.lblfk_Group.Name = "lblfk_Group";
            this.lblfk_Group.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Group.TabIndex = 0;
            this.lblfk_Group.Text = "Group:";
            this.lblfk_Group.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblfk_Group.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblfk_Group_MouseDown);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(41, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpTags
            // 
            this.grpTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grpTags.BackColor = System.Drawing.Color.Transparent;
            this.grpTags.Location = new System.Drawing.Point(55, 533);
            this.grpTags.Name = "grpTags";
            this.grpTags.Size = new System.Drawing.Size(414, 0);
            this.grpTags.TabIndex = 6;
            this.grpTags.TabStop = false;
            this.grpTags.Text = "Details";
            this.grpTags.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblcolour);
            this.groupBox2.Controls.Add(this.lblsizeunit);
            this.groupBox2.Controls.Add(this.txtcolour);
            this.groupBox2.Controls.Add(this.lblweightunit);
            this.groupBox2.Controls.Add(this.lblweight);
            this.groupBox2.Controls.Add(this.lblsize);
            this.groupBox2.Controls.Add(this.cboSizeUnit);
            this.groupBox2.Controls.Add(this.cboWeightUnit);
            this.groupBox2.Controls.Add(this.txtweight);
            this.groupBox2.Controls.Add(this.txtsize);
            this.groupBox2.Controls.Add(this.fsColor);
            this.groupBox2.Location = new System.Drawing.Point(15, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 139);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Description";
            // 
            // lblcolour
            // 
            this.lblcolour.BackColor = System.Drawing.Color.Transparent;
            this.lblcolour.Location = new System.Drawing.Point(-36, 23);
            this.lblcolour.Name = "lblcolour";
            this.lblcolour.Size = new System.Drawing.Size(160, 22);
            this.lblcolour.TabIndex = 0;
            this.lblcolour.Text = "Colour:";
            this.lblcolour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblsizeunit
            // 
            this.lblsizeunit.BackColor = System.Drawing.Color.Transparent;
            this.lblsizeunit.Location = new System.Drawing.Point(305, 57);
            this.lblsizeunit.Name = "lblsizeunit";
            this.lblsizeunit.Size = new System.Drawing.Size(45, 22);
            this.lblsizeunit.TabIndex = 0;
            this.lblsizeunit.Text = "Unit:";
            this.lblsizeunit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcolour
            // 
            this.txtcolour.Location = new System.Drawing.Point(144, 23);
            this.txtcolour.Name = "txtcolour";
            this.txtcolour.Size = new System.Drawing.Size(160, 23);
            this.txtcolour.TabIndex = 0;
            this.txtcolour.Click += new System.EventHandler(this.txtcolour_Click);
            // 
            // lblweightunit
            // 
            this.lblweightunit.BackColor = System.Drawing.Color.Transparent;
            this.lblweightunit.Location = new System.Drawing.Point(305, 87);
            this.lblweightunit.Name = "lblweightunit";
            this.lblweightunit.Size = new System.Drawing.Size(45, 22);
            this.lblweightunit.TabIndex = 0;
            this.lblweightunit.Text = "Unit:";
            this.lblweightunit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblweight
            // 
            this.lblweight.BackColor = System.Drawing.Color.Transparent;
            this.lblweight.Location = new System.Drawing.Point(6, 55);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(118, 22);
            this.lblweight.TabIndex = 0;
            this.lblweight.Text = "Weight:";
            this.lblweight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblsize
            // 
            this.lblsize.BackColor = System.Drawing.Color.Transparent;
            this.lblsize.Location = new System.Drawing.Point(6, 85);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(118, 22);
            this.lblsize.TabIndex = 0;
            this.lblsize.Text = "Size:";
            this.lblsize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSizeUnit
            // 
            this.cboSizeUnit.FormattingEnabled = true;
            this.cboSizeUnit.Location = new System.Drawing.Point(356, 88);
            this.cboSizeUnit.Name = "cboSizeUnit";
            this.cboSizeUnit.Size = new System.Drawing.Size(100, 24);
            this.cboSizeUnit.TabIndex = 4;
            // 
            // cboWeightUnit
            // 
            this.cboWeightUnit.FormattingEnabled = true;
            this.cboWeightUnit.Location = new System.Drawing.Point(356, 57);
            this.cboWeightUnit.Name = "cboWeightUnit";
            this.cboWeightUnit.Size = new System.Drawing.Size(100, 24);
            this.cboWeightUnit.TabIndex = 2;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(144, 57);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(160, 23);
            this.txtweight.TabIndex = 1;
            this.txtweight.ValidationType = Bsoft.Controls.NumericTextBox.ValidationTypeEnum.Decimal;
            this.txtweight.Value = "";
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(144, 86);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(160, 23);
            this.txtsize.TabIndex = 3;
            this.txtsize.ValidationType = Bsoft.Controls.NumericTextBox.ValidationTypeEnum.Decimal;
            this.txtsize.Value = "";
            // 
            // fsColor
            // 
            this.fsColor.BackColor = System.Drawing.Color.Transparent;
            this.fsColor.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.fsColor.FlatAppearance.BorderSize = 0;
            this.fsColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fsColor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fsColor.Location = new System.Drawing.Point(308, 21);
            this.fsColor.Margin = new System.Windows.Forms.Padding(0);
            this.fsColor.Name = "fsColor";
            this.fsColor.Size = new System.Drawing.Size(64, 29);
            this.fsColor.TabIndex = 20;
            this.fsColor.Text = "Choose";
            this.fsColor.ThemeColor = System.Drawing.Color.White;
            this.fsColor.UseVisualStyleBackColor = false;
            this.fsColor.Click += new System.EventHandler(this.fsButton1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(199, 7);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(160, 23);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(160, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(333, 451);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeColor = System.Drawing.Color.Blue;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(221, 451);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.ThemeColor = System.Drawing.Color.Blue;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtreorderpoint
            // 
            this.txtreorderpoint.Location = new System.Drawing.Point(365, 8);
            this.txtreorderpoint.Name = "txtreorderpoint";
            this.txtreorderpoint.Size = new System.Drawing.Size(160, 23);
            this.txtreorderpoint.TabIndex = 9;
            this.txtreorderpoint.ValidationType = Bsoft.Controls.NumericTextBox.ValidationTypeEnum.Decimal;
            this.txtreorderpoint.Value = "";
            this.txtreorderpoint.Visible = false;
            // 
            // frmProductEntry
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtreorderpoint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpTags);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "frmProductEntry";
            this.Text = "Product (Items)";
            this.Load += new System.EventHandler(this.frmProductEntry_Load);
            this.Controls.SetChildIndex(this.lblId, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.grpTags, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtreorderpoint, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;


        private System.Windows.Forms.Label lblName;

        private System.Windows.Forms.Label lblfk_Group;

        private System.Windows.Forms.Label lblfk_Company;

        private System.Windows.Forms.Label lblsizeunit;

        private System.Windows.Forms.Label lblweightunit;

        private System.Windows.Forms.Label lblcolour;

        private System.Windows.Forms.Label lblweight;

        private System.Windows.Forms.Label lblsize;


        private System.Windows.Forms.TextBox txtId;


        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.TextBox txtcolour; 


        private System.Windows.Forms.GroupBox groupBox1;
        public bsoftcontrols.fsButton btnCancel;
        public bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.ComboBox cboWeightUnit;
        private System.Windows.Forms.ComboBox cboSizeUnit;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.ComboBox cboCompany;
        private  Bsoft .Controls .NumericTextBox txtreorderpoint;
        private  Bsoft .Controls .NumericTextBox txtsize;
        private  Bsoft .Controls .NumericTextBox txtweight;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public bsoftcontrols.fsButton fsColor;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cboMeasureUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpTags;
    }
}
