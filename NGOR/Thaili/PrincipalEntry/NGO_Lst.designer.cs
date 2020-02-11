namespace UEMS
{
    partial class NGO_Lst
    {
     
     public    TypeOfNgoForm typeOfNgoForm = TypeOfNgoForm.ForNGO;
        public enum TypeOfNgoForm
        {
            ForNGO,
            ForReview,
            ForRenew,
            ForDartaReport
        }
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NGO_Lst));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolbar = new System.Windows.Forms.ToolStripButton();
            this.EditToolbar = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRenew = new System.Windows.Forms.ToolStripButton();
            this.YearlyReport = new System.Windows.Forms.ToolStripButton();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcronym = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDDCCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colD_Registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colD_Established = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkingAreaText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_ContactInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_President = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colD_LastAgm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colD_LastAudit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParikalpana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDhyaye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLakshya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUdeshya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectiveWrkText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTargetAudienceText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkDoneText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoalPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFiscalPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHrPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBudgetPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAchievements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChallenges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_FormFillBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_RegisterBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbfk_FinancialYear = new System.Windows.Forms.ComboBox();
            this.lblfk_FinancialSource = new System.Windows.Forms.Label();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.txtWorkArea = new System.Windows.Forms.TextBox();
            this.txtName_En = new System.Windows.Forms.TextBox();
            this.txtName_Np = new System.Windows.Forms.TextBox();
            this.chkMyEnties = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(986, 2);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolbar,
            this.EditToolbar,
            this.DeleteToolbar,
            this.toolStripSeparator1,
            this.ExportToolbar,
            this.toolStripSeparator2,
            this.btnRenew,
            this.YearlyReport,
            this.btnReport});
            this.toolStrip1.Location = new System.Drawing.Point(4, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(1014, 60);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.TabStop = true;
            // 
            // newToolbar
            // 
            this.newToolbar.AutoSize = false;
            this.newToolbar.Font = new System.Drawing.Font("Mangal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolbar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.newToolbar.Image = global::UEMS.Properties.Resources.AddNew;
            this.newToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolbar.Name = "newToolbar";
            this.newToolbar.Size = new System.Drawing.Size(75, 57);
            this.newToolbar.Text = "&New";
            this.newToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newToolbar.Click += new System.EventHandler(this.newToolbar_Click);
            // 
            // EditToolbar
            // 
            this.EditToolbar.AutoSize = false;
            this.EditToolbar.Font = new System.Drawing.Font("Mangal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditToolbar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.EditToolbar.Image = global::UEMS.Properties.Resources.Edit;
            this.EditToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolbar.Name = "EditToolbar";
            this.EditToolbar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.EditToolbar.Size = new System.Drawing.Size(75, 57);
            this.EditToolbar.Text = "&Edit";
            this.EditToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditToolbar.Click += new System.EventHandler(this.EditToolbar_Click);
            // 
            // DeleteToolbar
            // 
            this.DeleteToolbar.AutoSize = false;
            this.DeleteToolbar.Font = new System.Drawing.Font("Mangal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteToolbar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DeleteToolbar.Image = global::UEMS.Properties.Resources.delete;
            this.DeleteToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolbar.Name = "DeleteToolbar";
            this.DeleteToolbar.Size = new System.Drawing.Size(60, 57);
            this.DeleteToolbar.Text = "&Delete";
            this.DeleteToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteToolbar.Click += new System.EventHandler(this.DeleteToolbar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // ExportToolbar
            // 
            this.ExportToolbar.AutoSize = false;
            this.ExportToolbar.Font = new System.Drawing.Font("Mangal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToolbar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ExportToolbar.Image = global::UEMS.Properties.Resources.ExcelExport;
            this.ExportToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToolbar.Name = "ExportToolbar";
            this.ExportToolbar.Size = new System.Drawing.Size(60, 57);
            this.ExportToolbar.Text = "E&xport";
            this.ExportToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExportToolbar.Click += new System.EventHandler(this.ExportToolbar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            // 
            // btnRenew
            // 
            this.btnRenew.AutoSize = false;
            this.btnRenew.Font = new System.Drawing.Font("Mangal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRenew.Image = global::UEMS.Properties.Resources.Marks;
            this.btnRenew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(71, 57);
            this.btnRenew.Text = "नविकरण";
            this.btnRenew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRenew.Visible = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // YearlyReport
            // 
            this.YearlyReport.Font = new System.Drawing.Font("Mangal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearlyReport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.YearlyReport.Image = global::UEMS.Properties.Resources.Marks;
            this.YearlyReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.YearlyReport.Name = "YearlyReport";
            this.YearlyReport.Size = new System.Drawing.Size(97, 57);
            this.YearlyReport.Text = "बार्षिक प्रगति";
            this.YearlyReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.YearlyReport.Visible = false;
            this.YearlyReport.Click += new System.EventHandler(this.YearlyReport_Click);
            // 
            // btnReport
            // 
            this.btnReport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnReport.Font = new System.Drawing.Font("Mangal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReport.Image = global::UEMS.Properties.Resources.Marks;
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.btnReport.Size = new System.Drawing.Size(126, 57);
            this.btnReport.Text = "प्रतिबेदन ";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colEnglishName,
            this.colAcronym,
            this.colDDCCode,
            this.colfk_Address,
            this.colD_Registration,
            this.colD_Established,
            this.colWorkingAreaText,
            this.colfk_ContactInformation,
            this.colfk_President,
            this.colfk_ContactPerson,
            this.colD_LastAgm,
            this.colD_LastAudit,
            this.colParikalpana,
            this.colDhyaye,
            this.colLakshya,
            this.colUdeshya,
            this.colSubjectiveWrkText,
            this.colTargetAudienceText,
            this.colWorkDoneText,
            this.colGoalPlan,
            this.colFiscalPlan,
            this.colHrPlan,
            this.colBudgetPlan,
            this.colAchievements,
            this.colChallenges,
            this.colfk_FormFillBy,
            this.colfk_RegisterBy,
            this.colRemarks});
            this.grid.Location = new System.Drawing.Point(1, 248);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1017, 301);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 4;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            this.colId.Width = 44;
            // 
            // colName
            // 
            this.colName.HeaderText = "संस्थाको नाम";
            this.colName.Name = "colName";
            this.colName.Width = 89;
            // 
            // colEnglishName
            // 
            this.colEnglishName.HeaderText = "Name of Organization";
            this.colEnglishName.Name = "colEnglishName";
            this.colEnglishName.Width = 171;
            // 
            // colAcronym
            // 
            this.colAcronym.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAcronym.HeaderText = "Acronym ";
            this.colAcronym.Name = "colAcronym";
            this.colAcronym.Width = 92;
            // 
            // colDDCCode
            // 
            this.colDDCCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDDCCode.HeaderText = "जिविस कोड नं.";
            this.colDDCCode.Name = "colDDCCode";
            this.colDDCCode.Width = 96;
            // 
            // colfk_Address
            // 
            this.colfk_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_Address.HeaderText = "ठेगाना";
            this.colfk_Address.Name = "colfk_Address";
            this.colfk_Address.Width = 59;
            // 
            // colD_Registration
            // 
            this.colD_Registration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colD_Registration.DefaultCellStyle = dataGridViewCellStyle1;
            this.colD_Registration.HeaderText = "दर्ता मिति";
            this.colD_Registration.Name = "colD_Registration";
            this.colD_Registration.Width = 74;
            // 
            // colD_Established
            // 
            this.colD_Established.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colD_Established.DefaultCellStyle = dataGridViewCellStyle2;
            this.colD_Established.HeaderText = "स्थापना मिति ";
            this.colD_Established.Name = "colD_Established";
            this.colD_Established.Width = 95;
            // 
            // colWorkingAreaText
            // 
            this.colWorkingAreaText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colWorkingAreaText.HeaderText = "संस्थाको कार्यक्षेत्र ";
            this.colWorkingAreaText.Name = "colWorkingAreaText";
            this.colWorkingAreaText.Width = 109;
            // 
            // colfk_ContactInformation
            // 
            this.colfk_ContactInformation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colfk_ContactInformation.DefaultCellStyle = dataGridViewCellStyle3;
            this.colfk_ContactInformation.HeaderText = "फोन";
            this.colfk_ContactInformation.Name = "colfk_ContactInformation";
            this.colfk_ContactInformation.Width = 51;
            // 
            // colfk_President
            // 
            this.colfk_President.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_President.HeaderText = "अध्यक्ष";
            this.colfk_President.Name = "colfk_President";
            this.colfk_President.Visible = false;
            this.colfk_President.Width = 61;
            // 
            // colfk_ContactPerson
            // 
            this.colfk_ContactPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_ContactPerson.HeaderText = "सम्पर्क व्यक्ति";
            this.colfk_ContactPerson.Name = "colfk_ContactPerson";
            this.colfk_ContactPerson.Width = 87;
            // 
            // colD_LastAgm
            // 
            this.colD_LastAgm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colD_LastAgm.HeaderText = "अन्तिम साधारण सभा / अधिवेशन मिति ";
            this.colD_LastAgm.Name = "colD_LastAgm";
            this.colD_LastAgm.Width = 204;
            // 
            // colD_LastAudit
            // 
            this.colD_LastAudit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colD_LastAudit.HeaderText = "अन्तिम लेखा परीक्षण मिति ";
            this.colD_LastAudit.Name = "colD_LastAudit";
            this.colD_LastAudit.Width = 151;
            // 
            // colParikalpana
            // 
            this.colParikalpana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colParikalpana.HeaderText = "परिकल्पना";
            this.colParikalpana.Name = "colParikalpana";
            this.colParikalpana.Width = 77;
            // 
            // colDhyaye
            // 
            this.colDhyaye.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDhyaye.HeaderText = "ध्येय";
            this.colDhyaye.Name = "colDhyaye";
            this.colDhyaye.Width = 52;
            // 
            // colLakshya
            // 
            this.colLakshya.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colLakshya.HeaderText = "लक्ष्य";
            this.colLakshya.Name = "colLakshya";
            this.colLakshya.Width = 53;
            // 
            // colUdeshya
            // 
            this.colUdeshya.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colUdeshya.HeaderText = "उद्धेश्य";
            this.colUdeshya.Name = "colUdeshya";
            this.colUdeshya.Width = 58;
            // 
            // colSubjectiveWrkText
            // 
            this.colSubjectiveWrkText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSubjectiveWrkText.HeaderText = "कैफियत   ";
            this.colSubjectiveWrkText.Name = "colSubjectiveWrkText";
            this.colSubjectiveWrkText.Visible = false;
            this.colSubjectiveWrkText.Width = 81;
            // 
            // colTargetAudienceText
            // 
            this.colTargetAudienceText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTargetAudienceText.HeaderText = "कैफियत   ";
            this.colTargetAudienceText.Name = "colTargetAudienceText";
            this.colTargetAudienceText.Visible = false;
            this.colTargetAudienceText.Width = 81;
            // 
            // colWorkDoneText
            // 
            this.colWorkDoneText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colWorkDoneText.HeaderText = "कैफियत   ";
            this.colWorkDoneText.Name = "colWorkDoneText";
            this.colWorkDoneText.Visible = false;
            this.colWorkDoneText.Width = 81;
            // 
            // colGoalPlan
            // 
            this.colGoalPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colGoalPlan.HeaderText = "रणनैतिक योजना ";
            this.colGoalPlan.Name = "colGoalPlan";
            this.colGoalPlan.Visible = false;
            this.colGoalPlan.Width = 109;
            // 
            // colFiscalPlan
            // 
            this.colFiscalPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colFiscalPlan.HeaderText = "आर्थिक नियमावली";
            this.colFiscalPlan.Name = "colFiscalPlan";
            this.colFiscalPlan.Visible = false;
            this.colFiscalPlan.Width = 109;
            // 
            // colHrPlan
            // 
            this.colHrPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colHrPlan.HeaderText = "कर्मचारी प्रशासन नियमावली";
            this.colHrPlan.Name = "colHrPlan";
            this.colHrPlan.Visible = false;
            this.colHrPlan.Width = 149;
            // 
            // colBudgetPlan
            // 
            this.colBudgetPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colBudgetPlan.HeaderText = "वार्षिक कार्यक्रम बजेट ";
            this.colBudgetPlan.Name = "colBudgetPlan";
            this.colBudgetPlan.Visible = false;
            this.colBudgetPlan.Width = 127;
            // 
            // colAchievements
            // 
            this.colAchievements.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAchievements.HeaderText = "संस्थाको प्रमुख सफलता/ उपलब्धीहरु (भौतिक सम्पत्ति लगायत)";
            this.colAchievements.Name = "colAchievements";
            this.colAchievements.Width = 290;
            // 
            // colChallenges
            // 
            this.colChallenges.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colChallenges.HeaderText = "मुख्य चुनौतिहरु (खुलाउने)";
            this.colChallenges.Name = "colChallenges";
            this.colChallenges.Width = 139;
            // 
            // colfk_FormFillBy
            // 
            this.colfk_FormFillBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_FormFillBy.HeaderText = "फारम भर्ने व्यक्ति";
            this.colfk_FormFillBy.Name = "colfk_FormFillBy";
            this.colfk_FormFillBy.Visible = false;
            this.colfk_FormFillBy.Width = 102;
            // 
            // colfk_RegisterBy
            // 
            this.colfk_RegisterBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_RegisterBy.HeaderText = "निवेदक ";
            this.colfk_RegisterBy.Name = "colfk_RegisterBy";
            this.colfk_RegisterBy.Width = 63;
            // 
            // colRemarks
            // 
            this.colRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colRemarks.HeaderText = "कैफियत   ";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Width = 81;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbfk_FinancialYear);
            this.groupBox2.Controls.Add(this.lblfk_FinancialSource);
            this.groupBox2.Controls.Add(this.btnOk);
            this.groupBox2.Controls.Add(this.txtTarget);
            this.groupBox2.Controls.Add(this.txtWorkArea);
            this.groupBox2.Controls.Add(this.txtName_En);
            this.groupBox2.Controls.Add(this.txtName_Np);
            this.groupBox2.Controls.Add(this.chkMyEnties);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Mangal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(999, 146);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "तथ्यांक खोज्नकालागि विवरण ";
            // 
            // cmbfk_FinancialYear
            // 
            this.cmbfk_FinancialYear.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfk_FinancialYear.FormattingEnabled = true;
            this.cmbfk_FinancialYear.Location = new System.Drawing.Point(767, 48);
            this.cmbfk_FinancialYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbfk_FinancialYear.MaxDropDownItems = 5;
            this.cmbfk_FinancialYear.Name = "cmbfk_FinancialYear";
            this.cmbfk_FinancialYear.Size = new System.Drawing.Size(162, 24);
            this.cmbfk_FinancialYear.TabIndex = 126;
            // 
            // lblfk_FinancialSource
            // 
            this.lblfk_FinancialSource.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_FinancialSource.Location = new System.Drawing.Point(543, 44);
            this.lblfk_FinancialSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfk_FinancialSource.Name = "lblfk_FinancialSource";
            this.lblfk_FinancialSource.Size = new System.Drawing.Size(224, 28);
            this.lblfk_FinancialSource.TabIndex = 125;
            this.lblfk_FinancialSource.Text = "नविकरण आर्थिक बर्ष :";
            this.lblfk_FinancialSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(907, 105);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 124;
            this.btnOk.Text = "Search";
            this.btnOk.ThemeColor = System.Drawing.Color.Blue;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(386, 73);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(138, 34);
            this.txtTarget.TabIndex = 2;
            // 
            // txtWorkArea
            // 
            this.txtWorkArea.Location = new System.Drawing.Point(386, 33);
            this.txtWorkArea.Name = "txtWorkArea";
            this.txtWorkArea.Size = new System.Drawing.Size(138, 34);
            this.txtWorkArea.TabIndex = 2;
            // 
            // txtName_En
            // 
            this.txtName_En.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_En.Location = new System.Drawing.Point(146, 72);
            this.txtName_En.Name = "txtName_En";
            this.txtName_En.Size = new System.Drawing.Size(138, 31);
            this.txtName_En.TabIndex = 2;
            // 
            // txtName_Np
            // 
            this.txtName_Np.Location = new System.Drawing.Point(146, 33);
            this.txtName_Np.Name = "txtName_Np";
            this.txtName_Np.Size = new System.Drawing.Size(138, 34);
            this.txtName_Np.TabIndex = 1;
            // 
            // chkMyEnties
            // 
            this.chkMyEnties.AutoSize = true;
            this.chkMyEnties.Location = new System.Drawing.Point(611, 13);
            this.chkMyEnties.Name = "chkMyEnties";
            this.chkMyEnties.Size = new System.Drawing.Size(278, 33);
            this.chkMyEnties.TabIndex = 35;
            this.chkMyEnties.Text = "मैले गरेका प्रविष्टि सुधार मात्र देखाउने\r\n";
            this.chkMyEnties.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "लक्षित वर्ग :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "कार्यक्षेत्र  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "नेपालीमा नाम :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "अंग्रेजीमा नाम :";
            // 
            // NGO_Lst
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grid);
            this.Name = "NGO_Lst";
            this.Text = "गैरसरकारी संस्थाको तथ्यांक विवरण";
            this.Load += new System.EventHandler(this.List_Load);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolbar;
        private System.Windows.Forms.ToolStripButton EditToolbar;
        private System.Windows.Forms.ToolStripButton DeleteToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ExportToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRenew;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName_En;
        private System.Windows.Forms.TextBox txtName_Np;
        private System.Windows.Forms.CheckBox chkMyEnties;
        private System.Windows.Forms.Label label4;
        public bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.ToolStripButton YearlyReport;
        private System.Windows.Forms.TextBox txtWorkArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnglishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcronym;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDDCCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn colD_Registration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colD_Established;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkingAreaText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_ContactInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_President;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_ContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colD_LastAgm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colD_LastAudit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParikalpana;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDhyaye;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLakshya;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUdeshya;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectiveWrkText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTargetAudienceText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkDoneText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoalPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFiscalPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHrPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBudgetPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAchievements;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChallenges;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_FormFillBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfk_RegisterBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btnReport;
        private System.Windows.Forms.ComboBox cmbfk_FinancialYear;
        private System.Windows.Forms.Label lblfk_FinancialSource;

    }
}
