namespace UEMS.MasterEntry
{
    partial class frmCompany
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
        /// 
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtEmail; 
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblOrgName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblWebSite = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grporgDetail = new System.Windows.Forms.GroupBox();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.btnSearch = new bsoftcontrols.fsButton();
            this.pnlZone = new System.Windows.Forms.Panel();
            this.lblZone = new System.Windows.Forms.Label();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.btnEmpty = new bsoftcontrols.fsButton();
            this.pnlLocalBody = new System.Windows.Forms.Panel();
            this.lblLocalBody = new System.Windows.Forms.Label();
            this.txtLocalBody = new System.Windows.Forms.TextBox();
            this.pnlDistrict = new System.Windows.Forms.Panel();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new bsoftcontrols.fsButton();
            this.btnClose = new bsoftcontrols.fsButton();
            this.txtDistrictId = new System.Windows.Forms.TextBox();
            this.txtZoneId = new System.Windows.Forms.TextBox();
            this.txtLocalBodyId = new System.Windows.Forms.TextBox();
            this.pnlfk_FinancialSource = new System.Windows.Forms.Panel();
            this.cmbfk_FinancialYear = new System.Windows.Forms.ComboBox();
            this.lblfk_FinancialSource = new System.Windows.Forms.Label();
            this.pnlFiscalYearId = new System.Windows.Forms.Panel();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblFISCALYEARStart = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblFiscalYearEnd = new System.Windows.Forms.Label();
            this.btnRegistration = new bsoftcontrols.fsButton();
            this.grporgDetail.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.pnlZone.SuspendLayout();
            this.pnlLocalBody.SuspendLayout();
            this.pnlDistrict.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlfk_FinancialSource.SuspendLayout();
            this.pnlFiscalYearId.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(727, 2);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(242, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(399, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(112, 7);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 24);
            this.txtPhone.TabIndex = 1;
            // 
            // txtFax
            // 
            this.txtFax.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(112, 7);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(160, 24);
            this.txtFax.TabIndex = 2;
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(112, 7);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(160, 24);
            this.txtUrl.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(112, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 24);
            this.txtEmail.TabIndex = 4;
            // 
            // lblOrgName
            // 
            this.lblOrgName.BackColor = System.Drawing.Color.Transparent;
            this.lblOrgName.Location = new System.Drawing.Point(87, 23);
            this.lblOrgName.Name = "lblOrgName";
            this.lblOrgName.Size = new System.Drawing.Size(145, 26);
            this.lblOrgName.TabIndex = 1;
            this.lblOrgName.Text = "कार्यालयको नाम : ";
            this.lblOrgName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Location = new System.Drawing.Point(25, 7);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 26);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "फोन : ";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFax
            // 
            this.lblFax.BackColor = System.Drawing.Color.Transparent;
            this.lblFax.Location = new System.Drawing.Point(25, 5);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(73, 26);
            this.lblFax.TabIndex = 1;
            this.lblFax.Text = "फ्याक्स : ";
            this.lblFax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWebSite
            // 
            this.lblWebSite.BackColor = System.Drawing.Color.Transparent;
            this.lblWebSite.Location = new System.Drawing.Point(25, 7);
            this.lblWebSite.Name = "lblWebSite";
            this.lblWebSite.Size = new System.Drawing.Size(73, 26);
            this.lblWebSite.TabIndex = 1;
            this.lblWebSite.Text = "वेबसाईट : ";
            this.lblWebSite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(25, 2);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 26);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "इ-मेल : ";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grporgDetail
            // 
            this.grporgDetail.BackColor = System.Drawing.Color.Transparent;
            this.grporgDetail.Controls.Add(this.grpAddress);
            this.grporgDetail.Controls.Add(this.panel4);
            this.grporgDetail.Controls.Add(this.panel3);
            this.grporgDetail.Controls.Add(this.panel2);
            this.grporgDetail.Controls.Add(this.panel1);
            this.grporgDetail.Controls.Add(this.lblOrgName);
            this.grporgDetail.Controls.Add(this.txtName);
            this.grporgDetail.Location = new System.Drawing.Point(12, 50);
            this.grporgDetail.Name = "grporgDetail";
            this.grporgDetail.Size = new System.Drawing.Size(728, 263);
            this.grporgDetail.TabIndex = 0;
            this.grporgDetail.TabStop = false;
            this.grporgDetail.Text = "कार्यालयको विवरण ";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.btnSearch);
            this.grpAddress.Controls.Add(this.pnlZone);
            this.grpAddress.Controls.Add(this.btnEmpty);
            this.grpAddress.Controls.Add(this.pnlLocalBody);
            this.grpAddress.Controls.Add(this.pnlDistrict);
            this.grpAddress.Location = new System.Drawing.Point(33, 57);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(373, 182);
            this.grpAddress.TabIndex = 1;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "ठेगाना";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Location = new System.Drawing.Point(200, 148);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 29);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "खोज्ने";
            this.btnSearch.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // pnlZone
            // 
            this.pnlZone.AutoSize = true;
            this.pnlZone.BackColor = System.Drawing.Color.Transparent;
            this.pnlZone.Controls.Add(this.lblZone);
            this.pnlZone.Controls.Add(this.txtZone);
            this.pnlZone.Location = new System.Drawing.Point(13, 27);
            this.pnlZone.Margin = new System.Windows.Forms.Padding(1);
            this.pnlZone.Name = "pnlZone";
            this.pnlZone.Size = new System.Drawing.Size(335, 34);
            this.pnlZone.TabIndex = 9;
            this.pnlZone.Text = "अञ्चल ";
            // 
            // lblZone
            // 
            this.lblZone.BackColor = System.Drawing.Color.Transparent;
            this.lblZone.Location = new System.Drawing.Point(10, 5);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(160, 22);
            this.lblZone.TabIndex = 0;
            this.lblZone.Text = "अञ्चल :";
            this.lblZone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtZone
            // 
            this.txtZone.Location = new System.Drawing.Point(176, 7);
            this.txtZone.MaxLength = 15;
            this.txtZone.Name = "txtZone";
            this.txtZone.Size = new System.Drawing.Size(150, 23);
            this.txtZone.TabIndex = 0;
            // 
            // btnEmpty
            // 
            this.btnEmpty.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEmpty.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnEmpty.FlatAppearance.BorderSize = 0;
            this.btnEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpty.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEmpty.Location = new System.Drawing.Point(271, 148);
            this.btnEmpty.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(77, 29);
            this.btnEmpty.TabIndex = 1;
            this.btnEmpty.Text = "खाली गर्ने";
            this.btnEmpty.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // pnlLocalBody
            // 
            this.pnlLocalBody.AutoSize = true;
            this.pnlLocalBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlLocalBody.Controls.Add(this.lblLocalBody);
            this.pnlLocalBody.Controls.Add(this.txtLocalBody);
            this.pnlLocalBody.Location = new System.Drawing.Point(13, 99);
            this.pnlLocalBody.Margin = new System.Windows.Forms.Padding(1);
            this.pnlLocalBody.Name = "pnlLocalBody";
            this.pnlLocalBody.Size = new System.Drawing.Size(335, 34);
            this.pnlLocalBody.TabIndex = 11;
            this.pnlLocalBody.Text = "गाविस / नगरपालिका";
            // 
            // lblLocalBody
            // 
            this.lblLocalBody.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalBody.Location = new System.Drawing.Point(10, 5);
            this.lblLocalBody.Name = "lblLocalBody";
            this.lblLocalBody.Size = new System.Drawing.Size(160, 22);
            this.lblLocalBody.TabIndex = 0;
            this.lblLocalBody.Text = "गाविस / नगरपालिका:";
            this.lblLocalBody.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLocalBody
            // 
            this.txtLocalBody.Location = new System.Drawing.Point(176, 5);
            this.txtLocalBody.MaxLength = 15;
            this.txtLocalBody.Name = "txtLocalBody";
            this.txtLocalBody.Size = new System.Drawing.Size(150, 23);
            this.txtLocalBody.TabIndex = 0;
            // 
            // pnlDistrict
            // 
            this.pnlDistrict.AutoSize = true;
            this.pnlDistrict.BackColor = System.Drawing.Color.Transparent;
            this.pnlDistrict.Controls.Add(this.lblDistrict);
            this.pnlDistrict.Controls.Add(this.txtDistrict);
            this.pnlDistrict.Location = new System.Drawing.Point(13, 63);
            this.pnlDistrict.Margin = new System.Windows.Forms.Padding(1);
            this.pnlDistrict.Name = "pnlDistrict";
            this.pnlDistrict.Size = new System.Drawing.Size(335, 34);
            this.pnlDistrict.TabIndex = 10;
            this.pnlDistrict.Text = "जिल्ला";
            // 
            // lblDistrict
            // 
            this.lblDistrict.BackColor = System.Drawing.Color.Transparent;
            this.lblDistrict.Location = new System.Drawing.Point(10, 5);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(160, 22);
            this.lblDistrict.TabIndex = 0;
            this.lblDistrict.Text = "जिल्ला:";
            this.lblDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(176, 5);
            this.txtDistrict.MaxLength = 15;
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(150, 23);
            this.txtDistrict.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txtPhone);
            this.panel4.Controls.Add(this.lblPhone);
            this.panel4.Location = new System.Drawing.Point(410, 81);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 34);
            this.panel4.TabIndex = 2;
            this.panel4.Text = "अञ्चल ";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtFax);
            this.panel3.Controls.Add(this.lblFax);
            this.panel3.Location = new System.Drawing.Point(410, 117);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 34);
            this.panel3.TabIndex = 3;
            this.panel3.Text = "जिल्ला";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Location = new System.Drawing.Point(410, 153);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 34);
            this.panel2.TabIndex = 4;
            this.panel2.Text = "गाविस / नगरपालिका";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Controls.Add(this.lblWebSite);
            this.panel1.Location = new System.Drawing.Point(410, 189);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 34);
            this.panel1.TabIndex = 5;
            this.panel1.Text = "टोल ";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.Orange;
            this.btnSave.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(283, 491);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BackColor = System.Drawing.Color.Orange;
            this.btnClose.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(382, 491);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 26);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDistrictId
            // 
            this.txtDistrictId.Location = new System.Drawing.Point(83, 4);
            this.txtDistrictId.MaxLength = 15;
            this.txtDistrictId.Name = "txtDistrictId";
            this.txtDistrictId.Size = new System.Drawing.Size(36, 23);
            this.txtDistrictId.TabIndex = 0;
            this.txtDistrictId.Visible = false;
            // 
            // txtZoneId
            // 
            this.txtZoneId.Location = new System.Drawing.Point(154, 4);
            this.txtZoneId.MaxLength = 15;
            this.txtZoneId.Name = "txtZoneId";
            this.txtZoneId.Size = new System.Drawing.Size(36, 23);
            this.txtZoneId.TabIndex = 0;
            this.txtZoneId.Visible = false;
            // 
            // txtLocalBodyId
            // 
            this.txtLocalBodyId.Location = new System.Drawing.Point(225, 4);
            this.txtLocalBodyId.MaxLength = 15;
            this.txtLocalBodyId.Name = "txtLocalBodyId";
            this.txtLocalBodyId.Size = new System.Drawing.Size(36, 23);
            this.txtLocalBodyId.TabIndex = 0;
            this.txtLocalBodyId.Visible = false;
            // 
            // pnlfk_FinancialSource
            // 
            this.pnlfk_FinancialSource.AutoSize = true;
            this.pnlfk_FinancialSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlfk_FinancialSource.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_FinancialSource.Controls.Add(this.cmbfk_FinancialYear);
            this.pnlfk_FinancialSource.Controls.Add(this.lblfk_FinancialSource);
            this.pnlfk_FinancialSource.Location = new System.Drawing.Point(53, 327);
            this.pnlfk_FinancialSource.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlfk_FinancialSource.Name = "pnlfk_FinancialSource";
            this.pnlfk_FinancialSource.Size = new System.Drawing.Size(501, 31);
            this.pnlfk_FinancialSource.TabIndex = 1;
            this.pnlfk_FinancialSource.Text = "निकाय";
            // 
            // cmbfk_FinancialYear
            // 
            this.cmbfk_FinancialYear.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfk_FinancialYear.FormattingEnabled = true;
            this.cmbfk_FinancialYear.Location = new System.Drawing.Point(229, 2);
            this.cmbfk_FinancialYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbfk_FinancialYear.Name = "cmbfk_FinancialYear";
            this.cmbfk_FinancialYear.Size = new System.Drawing.Size(268, 24);
            this.cmbfk_FinancialYear.TabIndex = 0;
            // 
            // lblfk_FinancialSource
            // 
            this.lblfk_FinancialSource.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_FinancialSource.Location = new System.Drawing.Point(13, 2);
            this.lblfk_FinancialSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfk_FinancialSource.Name = "lblfk_FinancialSource";
            this.lblfk_FinancialSource.Size = new System.Drawing.Size(213, 28);
            this.lblfk_FinancialSource.TabIndex = 0;
            this.lblfk_FinancialSource.Text = "आर्थिक बर्ष :";
            this.lblfk_FinancialSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFiscalYearId
            // 
            this.pnlFiscalYearId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFiscalYearId.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiscalYearId.Controls.Add(this.lblStartDate);
            this.pnlFiscalYearId.Controls.Add(this.lblFISCALYEARStart);
            this.pnlFiscalYearId.Location = new System.Drawing.Point(53, 365);
            this.pnlFiscalYearId.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlFiscalYearId.Name = "pnlFiscalYearId";
            this.pnlFiscalYearId.Size = new System.Drawing.Size(501, 38);
            this.pnlFiscalYearId.TabIndex = 2;
            this.pnlFiscalYearId.Text = "आर्थिक बर्ष ";
            this.pnlFiscalYearId.Visible = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Location = new System.Drawing.Point(13, 0);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(213, 28);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "आर्थिक बर्ष सुरु मिति :";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFISCALYEARStart
            // 
            this.lblFISCALYEARStart.BackColor = System.Drawing.Color.Transparent;
            this.lblFISCALYEARStart.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFISCALYEARStart.Location = new System.Drawing.Point(223, 2);
            this.lblFISCALYEARStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFISCALYEARStart.Name = "lblFISCALYEARStart";
            this.lblFISCALYEARStart.Size = new System.Drawing.Size(213, 28);
            this.lblFISCALYEARStart.TabIndex = 0;
            this.lblFISCALYEARStart.Text = "आर्थिक बर्ष ";
            this.lblFISCALYEARStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lblEndDate);
            this.panel5.Controls.Add(this.lblFiscalYearEnd);
            this.panel5.Location = new System.Drawing.Point(53, 403);
            this.panel5.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(501, 38);
            this.panel5.TabIndex = 3;
            this.panel5.Text = "आर्थिक बर्ष ";
            this.panel5.Visible = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Location = new System.Drawing.Point(13, 0);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(213, 28);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "आर्थिक बर्ष अन्त्य मिति  :";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFiscalYearEnd
            // 
            this.lblFiscalYearEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblFiscalYearEnd.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiscalYearEnd.Location = new System.Drawing.Point(223, 2);
            this.lblFiscalYearEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiscalYearEnd.Name = "lblFiscalYearEnd";
            this.lblFiscalYearEnd.Size = new System.Drawing.Size(213, 28);
            this.lblFiscalYearEnd.TabIndex = 0;
            this.lblFiscalYearEnd.Text = "आर्थिक बर्ष ";
            this.lblFiscalYearEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistration.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnRegistration.FlatAppearance.BorderSize = 0;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistration.Location = new System.Drawing.Point(45, 488);
            this.btnRegistration.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(125, 29);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "दर्ता प्रमाणिकरन ";
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // frmCompany
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 528);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.pnlfk_FinancialSource);
            this.Controls.Add(this.pnlFiscalYearId);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtZoneId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLocalBodyId);
            this.Controls.Add(this.txtDistrictId);
            this.Controls.Add(this.grporgDetail);
            this.Name = "frmCompany";
            this.Text = "Company Details";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            this.Controls.SetChildIndex(this.grporgDetail, 0);
            this.Controls.SetChildIndex(this.txtDistrictId, 0);
            this.Controls.SetChildIndex(this.txtLocalBodyId, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.txtZoneId, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.pnlFiscalYearId, 0);
            this.Controls.SetChildIndex(this.pnlfk_FinancialSource, 0);
            this.Controls.SetChildIndex(this.btnRegistration, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.grporgDetail.ResumeLayout(false);
            this.grporgDetail.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.pnlZone.ResumeLayout(false);
            this.pnlZone.PerformLayout();
            this.pnlLocalBody.ResumeLayout(false);
            this.pnlLocalBody.PerformLayout();
            this.pnlDistrict.ResumeLayout(false);
            this.pnlDistrict.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlfk_FinancialSource.ResumeLayout(false);
            this.pnlFiscalYearId.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrgName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblWebSite;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox grporgDetail;
        private bsoftcontrols.fsButton btnSave;
        private bsoftcontrols.fsButton btnClose;
        public System.Windows.Forms.Panel pnlZone;
        private System.Windows.Forms.Label lblZone;
        public System.Windows.Forms.Panel pnlDistrict;
        private System.Windows.Forms.Label lblDistrict;
        public System.Windows.Forms.Panel pnlLocalBody;
        private System.Windows.Forms.Label lblLocalBody;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        private bsoftcontrols.fsButton btnEmpty;
        private System.Windows.Forms.TextBox txtZoneId;
        private System.Windows.Forms.TextBox txtDistrictId;
        private System.Windows.Forms.TextBox txtLocalBodyId;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.Panel pnlfk_FinancialSource;
        private System.Windows.Forms.ComboBox cmbfk_FinancialYear;
        private System.Windows.Forms.Label lblfk_FinancialSource;
        private System.Windows.Forms.Panel pnlFiscalYearId;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblFISCALYEARStart;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblFiscalYearEnd;
        private bsoftcontrols.fsButton btnRegistration;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.TextBox txtLocalBody;
        private System.Windows.Forms.TextBox txtDistrict;
        public bsoftcontrols.fsButton btnSearch;
    }
}
