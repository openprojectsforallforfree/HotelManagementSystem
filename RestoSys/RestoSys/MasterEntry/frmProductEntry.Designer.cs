namespace RestoSys.MasterEntry
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGroupType = new System.Windows.Forms.Label();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.lblfk_Group = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new Bsoft.Controls.VtextBox();
            this.pnlBarcode = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarCode = new Bsoft.Controls.VtextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMeasureUnit = new System.Windows.Forms.ComboBox();
            this.pnlCostPrice = new System.Windows.Forms.Panel();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.txtCostPrice = new Bsoft.Controls.VtextBox();
            this.pnlSellingPrice = new System.Windows.Forms.Panel();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.txtSellingPrice = new Bsoft.Controls.VtextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblcolour = new System.Windows.Forms.Label();
            this.lblsizeunit = new System.Windows.Forms.Label();
            this.txtcolour = new System.Windows.Forms.TextBox();
            this.lblweightunit = new System.Windows.Forms.Label();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.lblweight = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.cboSizeUnit = new System.Windows.Forms.ComboBox();
            this.cboWeightUnit = new System.Windows.Forms.ComboBox();
            this.lblfk_Company = new System.Windows.Forms.Label();
            this.txtweight = new Bsoft.Controls.VtextBox();
            this.txtsize = new Bsoft.Controls.VtextBox();
            this.fsColor = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grpTags = new System.Windows.Forms.GroupBox();
            this.txtreorderpoint = new Bsoft.Controls.VtextBox();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlBarcode.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlCostPrice.SuspendLayout();
            this.pnlSellingPrice.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(551, 2);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 529);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.pnlBarcode);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.pnlCostPrice);
            this.flowLayoutPanel1.Controls.Add(this.pnlSellingPrice);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.grpDetails);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(516, 491);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGroupType);
            this.panel1.Controls.Add(this.cboGroup);
            this.panel1.Controls.Add(this.lblfk_Group);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 61);
            this.panel1.TabIndex = 0;
            // 
            // lblGroupType
            // 
            this.lblGroupType.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupType.Location = new System.Drawing.Point(7, 30);
            this.lblGroupType.Name = "lblGroupType";
            this.lblGroupType.Size = new System.Drawing.Size(460, 22);
            this.lblGroupType.TabIndex = 1;
            this.lblGroupType.Text = "Group Type";
            this.lblGroupType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(175, 0);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(160, 24);
            this.cboGroup.TabIndex = 0;
            this.cboGroup.SelectedIndexChanged += new System.EventHandler(this.cboGroup_SelectedIndexChanged);
            // 
            // lblfk_Group
            // 
            this.lblfk_Group.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Group.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblfk_Group.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblfk_Group.Location = new System.Drawing.Point(3, 0);
            this.lblfk_Group.Name = "lblfk_Group";
            this.lblfk_Group.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Group.TabIndex = 0;
            this.lblfk_Group.Text = "Group:";
            this.lblfk_Group.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblfk_Group.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblfk_Group_MouseDown);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblName);
            this.panel7.Controls.Add(this.txtName);
            this.panel7.Location = new System.Drawing.Point(3, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(376, 28);
            this.panel7.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 1);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 23);
            this.txtName.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblCode);
            this.panel5.Controls.Add(this.txtCode);
            this.panel5.Location = new System.Drawing.Point(3, 104);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(376, 28);
            this.panel5.TabIndex = 2;
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Location = new System.Drawing.Point(3, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(160, 22);
            this.lblCode.TabIndex = 24;
            this.lblCode.Text = "Code:";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(175, 2);
            this.txtCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(160, 23);
            this.txtCode.TabIndex = 0;
            this.txtCode.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.AlphaNumeric;
            this.txtCode.Value = "";
            // 
            // pnlBarcode
            // 
            this.pnlBarcode.Controls.Add(this.label1);
            this.pnlBarcode.Controls.Add(this.txtBarCode);
            this.pnlBarcode.Location = new System.Drawing.Point(3, 138);
            this.pnlBarcode.Name = "pnlBarcode";
            this.pnlBarcode.Size = new System.Drawing.Size(376, 28);
            this.pnlBarcode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Bar Code:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(175, 2);
            this.txtBarCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(160, 23);
            this.txtBarCode.TabIndex = 0;
            this.txtBarCode.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.AlphaNumeric;
            this.txtBarCode.Value = "";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.cboMeasureUnit);
            this.panel6.Location = new System.Drawing.Point(3, 172);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(376, 28);
            this.panel6.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Counting Unit:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboMeasureUnit
            // 
            this.cboMeasureUnit.FormattingEnabled = true;
            this.cboMeasureUnit.Location = new System.Drawing.Point(175, 1);
            this.cboMeasureUnit.Name = "cboMeasureUnit";
            this.cboMeasureUnit.Size = new System.Drawing.Size(160, 24);
            this.cboMeasureUnit.TabIndex = 0;
            // 
            // pnlCostPrice
            // 
            this.pnlCostPrice.Controls.Add(this.lblCostPrice);
            this.pnlCostPrice.Controls.Add(this.txtCostPrice);
            this.pnlCostPrice.Location = new System.Drawing.Point(3, 206);
            this.pnlCostPrice.Name = "pnlCostPrice";
            this.pnlCostPrice.Size = new System.Drawing.Size(376, 31);
            this.pnlCostPrice.TabIndex = 5;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblCostPrice.Location = new System.Drawing.Point(3, 0);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(160, 22);
            this.lblCostPrice.TabIndex = 34;
            this.lblCostPrice.Text = "Latest Cost Price:";
            this.lblCostPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(175, 2);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(160, 23);
            this.txtCostPrice.TabIndex = 0;
            this.txtCostPrice.Text = "0";
            this.txtCostPrice.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtCostPrice.Value = "0";
            // 
            // pnlSellingPrice
            // 
            this.pnlSellingPrice.Controls.Add(this.lblSellingPrice);
            this.pnlSellingPrice.Controls.Add(this.txtSellingPrice);
            this.pnlSellingPrice.Location = new System.Drawing.Point(3, 243);
            this.pnlSellingPrice.Name = "pnlSellingPrice";
            this.pnlSellingPrice.Size = new System.Drawing.Size(376, 28);
            this.pnlSellingPrice.TabIndex = 6;
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSellingPrice.Location = new System.Drawing.Point(3, 0);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(160, 22);
            this.lblSellingPrice.TabIndex = 32;
            this.lblSellingPrice.Text = "Price:";
            this.lblSellingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(175, 2);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(160, 23);
            this.txtSellingPrice.TabIndex = 0;
            this.txtSellingPrice.Text = "0";
            this.txtSellingPrice.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtSellingPrice.Value = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblRemarks);
            this.panel2.Controls.Add(this.txtRemarks);
            this.panel2.Location = new System.Drawing.Point(3, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 64);
            this.panel2.TabIndex = 7;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Location = new System.Drawing.Point(3, 2);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(160, 22);
            this.lblRemarks.TabIndex = 31;
            this.lblRemarks.Text = "Remarks:";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(175, 2);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(252, 59);
            this.txtRemarks.TabIndex = 0;
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpDetails.Controls.Add(this.lblcolour);
            this.grpDetails.Controls.Add(this.lblsizeunit);
            this.grpDetails.Controls.Add(this.txtcolour);
            this.grpDetails.Controls.Add(this.lblweightunit);
            this.grpDetails.Controls.Add(this.cboCompany);
            this.grpDetails.Controls.Add(this.lblweight);
            this.grpDetails.Controls.Add(this.lblsize);
            this.grpDetails.Controls.Add(this.cboSizeUnit);
            this.grpDetails.Controls.Add(this.cboWeightUnit);
            this.grpDetails.Controls.Add(this.lblfk_Company);
            this.grpDetails.Controls.Add(this.txtweight);
            this.grpDetails.Controls.Add(this.txtsize);
            this.grpDetails.Controls.Add(this.fsColor);
            this.grpDetails.Location = new System.Drawing.Point(3, 347);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(489, 130);
            this.grpDetails.TabIndex = 8;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Item Description";
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
            // cboCompany
            // 
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(206, 115);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(160, 24);
            this.cboCompany.TabIndex = 2;
            this.cboCompany.Visible = false;
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
            // lblfk_Company
            // 
            this.lblfk_Company.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Company.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblfk_Company.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblfk_Company.Location = new System.Drawing.Point(26, 116);
            this.lblfk_Company.Name = "lblfk_Company";
            this.lblfk_Company.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Company.TabIndex = 0;
            this.lblfk_Company.Text = "Company:";
            this.lblfk_Company.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblfk_Company.Visible = false;
            this.lblfk_Company.Click += new System.EventHandler(this.lblfk_Company_Click);
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(144, 57);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(160, 23);
            this.txtweight.TabIndex = 1;
            this.txtweight.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtweight.Value = "";
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(144, 86);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(160, 23);
            this.txtsize.TabIndex = 3;
            this.txtsize.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
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
            this.fsColor.TabIndex = 1;
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
            this.txtId.Size = new System.Drawing.Size(32, 23);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(314, 586);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 1;
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
            this.btnOk.Location = new System.Drawing.Point(202, 586);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.ThemeColor = System.Drawing.Color.Blue;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpTags
            // 
            this.grpTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grpTags.BackColor = System.Drawing.Color.Transparent;
            this.grpTags.Location = new System.Drawing.Point(413, 9);
            this.grpTags.Name = "grpTags";
            this.grpTags.Size = new System.Drawing.Size(118, 72);
            this.grpTags.TabIndex = 6;
            this.grpTags.TabStop = false;
            this.grpTags.Text = "Details";
            this.grpTags.Visible = false;
            // 
            // txtreorderpoint
            // 
            this.txtreorderpoint.Location = new System.Drawing.Point(365, 8);
            this.txtreorderpoint.Name = "txtreorderpoint";
            this.txtreorderpoint.Size = new System.Drawing.Size(26, 23);
            this.txtreorderpoint.TabIndex = 9;
            this.txtreorderpoint.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtreorderpoint.Value = "";
            this.txtreorderpoint.Visible = false;
            // 
            // frmProductEntry
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 630);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtreorderpoint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.grpTags);
            this.Name = "frmProductEntry";
            this.Text = " Products Entry Form";
            this.Load += new System.EventHandler(this.frmProductEntry_Load);
            this.Controls.SetChildIndex(this.grpTags, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtreorderpoint, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlBarcode.ResumeLayout(false);
            this.pnlBarcode.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.pnlCostPrice.ResumeLayout(false);
            this.pnlCostPrice.PerformLayout();
            this.pnlSellingPrice.ResumeLayout(false);
            this.pnlSellingPrice.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



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
        private  Bsoft.Controls.VtextBox txtreorderpoint;
        private  Bsoft.Controls.VtextBox txtsize;
        private  Bsoft.Controls.VtextBox txtweight;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public bsoftcontrols.fsButton fsColor;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox cboMeasureUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.GroupBox grpTags;
        private System.Windows.Forms.Label lblSellingPrice;
        private Bsoft.Controls.VtextBox txtSellingPrice;
        private System.Windows.Forms.Label lblCostPrice;
        private Bsoft.Controls.VtextBox txtCostPrice;
        public Bsoft.Controls.VtextBox txtCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlCostPrice;
        private System.Windows.Forms.Panel pnlSellingPrice;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblGroupType;
        private System.Windows.Forms.Panel pnlBarcode;
        private System.Windows.Forms.Label label1;
        public Bsoft.Controls.VtextBox txtBarCode;
    }
}
