namespace UEMS 
{
    partial class IndividualPerson_Lst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualPerson_Lst));
            this.newToolbar = new System.Windows.Forms.ToolStripButton();
            this.EditToolbar = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolbar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolbar = new System.Windows.Forms.ToolStripButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Ethnicity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDifferentlyAbled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSocialWorkExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_HighestEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_ContactInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfk_Master_Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFirstName = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlfk_Ethnicity = new System.Windows.Forms.Panel();
            this.cmbfk_Ethnicity = new System.Windows.Forms.ComboBox();
            this.lblfk_Ethnicity = new System.Windows.Forms.Label();
            this.pnlfk_Gender = new System.Windows.Forms.Panel();
            this.cmbfk_Gender = new System.Windows.Forms.ComboBox();
            this.lblfk_Gender = new System.Windows.Forms.Label();
            this.pnlLastName = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnOk = new bsoftcontrols.fsButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.pnlFirstName.SuspendLayout();
            this.pnlfk_Ethnicity.SuspendLayout();
            this.pnlfk_Gender.SuspendLayout();
            this.pnlLastName.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(986, 2);
            // 
            // newToolbar
            // 
            this.newToolbar.AutoSize = false;
            this.newToolbar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newToolbar.Image = global::UEMS.Properties.Resources.AddNew;
            this.newToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolbar.Name = "newToolbar";
            this.newToolbar.Size = new System.Drawing.Size(60, 60);
            this.newToolbar.Text = "&New";
            this.newToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newToolbar.Click += new System.EventHandler(this.newToolbar_Click);
            // 
            // EditToolbar
            // 
            this.EditToolbar.AutoSize = false;
            this.EditToolbar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditToolbar.Image = global::UEMS.Properties.Resources.Edit;
            this.EditToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolbar.Name = "EditToolbar";
            this.EditToolbar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.EditToolbar.Size = new System.Drawing.Size(60, 60);
            this.EditToolbar.Text = "&Edit";
            this.EditToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditToolbar.Click += new System.EventHandler(this.EditToolbar_Click);
            // 
            // DeleteToolbar
            // 
            this.DeleteToolbar.AutoSize = false;
            this.DeleteToolbar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteToolbar.Image = global::UEMS.Properties.Resources.delete;
            this.DeleteToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolbar.Name = "DeleteToolbar";
            this.DeleteToolbar.Size = new System.Drawing.Size(60, 60);
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
            this.ExportToolbar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportToolbar.Image = global::UEMS.Properties.Resources.ExcelExport;
            this.ExportToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToolbar.Name = "ExportToolbar";
            this.ExportToolbar.Size = new System.Drawing.Size(60, 60);
            this.ExportToolbar.Text = "E&xport";
            this.ExportToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExportToolbar.Click += new System.EventHandler(this.ExportToolbar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            // 
            // ExitToolbar
            // 
            this.ExitToolbar.AutoSize = false;
            this.ExitToolbar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitToolbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitToolbar.Image = global::UEMS.Properties.Resources.close;
            this.ExitToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitToolbar.Name = "ExitToolbar";
            this.ExitToolbar.Size = new System.Drawing.Size(60, 60);
            this.ExitToolbar.Text = "&Close";
            this.ExitToolbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitToolbar.Click += new System.EventHandler(this.ExitToolbar_Click);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFirstName,
            this.colLastName,
            this.colfk_Gender,
            this.colfk_Ethnicity,
            this.colDifferentlyAbled,
            this.colfk_Specialization,
            this.colSocialWorkExp,
            this.colfk_HighestEducation,
            this.colfk_Position,
            this.colfk_Address,
            this.colfk_ContactInformation,
            this.colfk_Master_Profession});
            this.grid.Location = new System.Drawing.Point(1, 188);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1017, 390);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 4;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colFirstName
            // 
            this.colFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colFirstName.HeaderText = "नाम ";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Width = 52;
            // 
            // colLastName
            // 
            this.colLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colLastName.HeaderText = "थर";
            this.colLastName.Name = "colLastName";
            this.colLastName.Width = 45;
            // 
            // colfk_Gender
            // 
            this.colfk_Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_Gender.HeaderText = "लिंग";
            this.colfk_Gender.Name = "colfk_Gender";
            this.colfk_Gender.Width = 50;
            // 
            // colfk_Ethnicity
            // 
            this.colfk_Ethnicity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_Ethnicity.HeaderText = "जाति";
            this.colfk_Ethnicity.Name = "colfk_Ethnicity";
            this.colfk_Ethnicity.Width = 54;
            // 
            // colDifferentlyAbled
            // 
            this.colDifferentlyAbled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDifferentlyAbled.HeaderText = "फरक क्षमता भएको";
            this.colDifferentlyAbled.Name = "colDifferentlyAbled";
            this.colDifferentlyAbled.Width = 113;
            // 
            // colfk_Specialization
            // 
            this.colfk_Specialization.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_Specialization.HeaderText = "बिषयगत क्षेत्रको अनुभव";
            this.colfk_Specialization.Name = "colfk_Specialization";
            this.colfk_Specialization.Width = 132;
            // 
            // colSocialWorkExp
            // 
            this.colSocialWorkExp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSocialWorkExp.HeaderText = "सामाजिक क्षेत्रको अनुभव";
            this.colSocialWorkExp.Name = "colSocialWorkExp";
            this.colSocialWorkExp.Width = 135;
            // 
            // colfk_HighestEducation
            // 
            this.colfk_HighestEducation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_HighestEducation.HeaderText = "शौक्षिक योग्यता";
            this.colfk_HighestEducation.Name = "colfk_HighestEducation";
            this.colfk_HighestEducation.Width = 99;
            // 
            // colfk_Position
            // 
            this.colfk_Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_Position.HeaderText = "पद";
            this.colfk_Position.Name = "colfk_Position";
            this.colfk_Position.Width = 45;
            // 
            // colfk_Address
            // 
            this.colfk_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_Address.HeaderText = "ठेगाना";
            this.colfk_Address.Name = "colfk_Address";
            this.colfk_Address.Width = 59;
            // 
            // colfk_ContactInformation
            // 
            this.colfk_ContactInformation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_ContactInformation.HeaderText = "fk_ContactInformation";
            this.colfk_ContactInformation.Name = "colfk_ContactInformation";
            this.colfk_ContactInformation.Width = 170;
            // 
            // colfk_Master_Profession
            // 
            this.colfk_Master_Profession.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colfk_Master_Profession.HeaderText = "ब्यबशाये ";
            this.colfk_Master_Profession.Name = "colfk_Master_Profession";
            this.colfk_Master_Profession.Width = 67;
            // 
            // pnlFirstName
            // 
            this.pnlFirstName.AutoSize = true;
            this.pnlFirstName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFirstName.BackColor = System.Drawing.Color.Transparent;
            this.pnlFirstName.Controls.Add(this.txtFirstName);
            this.pnlFirstName.Controls.Add(this.lblFirstName);
            this.pnlFirstName.Location = new System.Drawing.Point(10, 108);
            this.pnlFirstName.Margin = new System.Windows.Forms.Padding(1);
            this.pnlFirstName.Name = "pnlFirstName";
            this.pnlFirstName.Size = new System.Drawing.Size(335, 27);
            this.pnlFirstName.TabIndex = 8;
            this.pnlFirstName.Text = "नाम ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(172, 1);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 23);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Location = new System.Drawing.Point(10, 1);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(160, 22);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "नाम :";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlfk_Ethnicity
            // 
            this.pnlfk_Ethnicity.AutoSize = true;
            this.pnlfk_Ethnicity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlfk_Ethnicity.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_Ethnicity.Controls.Add(this.cmbfk_Ethnicity);
            this.pnlfk_Ethnicity.Controls.Add(this.lblfk_Ethnicity);
            this.pnlfk_Ethnicity.Location = new System.Drawing.Point(359, 143);
            this.pnlfk_Ethnicity.Margin = new System.Windows.Forms.Padding(1);
            this.pnlfk_Ethnicity.Name = "pnlfk_Ethnicity";
            this.pnlfk_Ethnicity.Size = new System.Drawing.Size(335, 28);
            this.pnlfk_Ethnicity.TabIndex = 9;
            this.pnlfk_Ethnicity.Text = "जाति";
            // 
            // cmbfk_Ethnicity
            // 
            this.cmbfk_Ethnicity.FormattingEnabled = true;
            this.cmbfk_Ethnicity.Location = new System.Drawing.Point(172, 1);
            this.cmbfk_Ethnicity.Name = "cmbfk_Ethnicity";
            this.cmbfk_Ethnicity.Size = new System.Drawing.Size(160, 24);
            this.cmbfk_Ethnicity.TabIndex = 0;
            // 
            // lblfk_Ethnicity
            // 
            this.lblfk_Ethnicity.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Ethnicity.Location = new System.Drawing.Point(10, 1);
            this.lblfk_Ethnicity.Name = "lblfk_Ethnicity";
            this.lblfk_Ethnicity.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Ethnicity.TabIndex = 0;
            this.lblfk_Ethnicity.Text = "जाति:";
            this.lblfk_Ethnicity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlfk_Gender
            // 
            this.pnlfk_Gender.AutoSize = true;
            this.pnlfk_Gender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlfk_Gender.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_Gender.Controls.Add(this.cmbfk_Gender);
            this.pnlfk_Gender.Controls.Add(this.lblfk_Gender);
            this.pnlfk_Gender.Location = new System.Drawing.Point(359, 109);
            this.pnlfk_Gender.Margin = new System.Windows.Forms.Padding(1);
            this.pnlfk_Gender.Name = "pnlfk_Gender";
            this.pnlfk_Gender.Size = new System.Drawing.Size(335, 28);
            this.pnlfk_Gender.TabIndex = 6;
            this.pnlfk_Gender.Text = "लिंग";
            // 
            // cmbfk_Gender
            // 
            this.cmbfk_Gender.FormattingEnabled = true;
            this.cmbfk_Gender.Location = new System.Drawing.Point(172, 1);
            this.cmbfk_Gender.Name = "cmbfk_Gender";
            this.cmbfk_Gender.Size = new System.Drawing.Size(160, 24);
            this.cmbfk_Gender.TabIndex = 0;
            // 
            // lblfk_Gender
            // 
            this.lblfk_Gender.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Gender.Location = new System.Drawing.Point(10, 1);
            this.lblfk_Gender.Name = "lblfk_Gender";
            this.lblfk_Gender.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Gender.TabIndex = 0;
            this.lblfk_Gender.Text = "लिंग:";
            this.lblfk_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLastName
            // 
            this.pnlLastName.AutoSize = true;
            this.pnlLastName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLastName.BackColor = System.Drawing.Color.Transparent;
            this.pnlLastName.Controls.Add(this.txtLastName);
            this.pnlLastName.Controls.Add(this.lblLastName);
            this.pnlLastName.Location = new System.Drawing.Point(10, 140);
            this.pnlLastName.Margin = new System.Windows.Forms.Padding(1);
            this.pnlLastName.Name = "pnlLastName";
            this.pnlLastName.Size = new System.Drawing.Size(335, 27);
            this.pnlLastName.TabIndex = 7;
            this.pnlLastName.Text = "थर";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(172, 1);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 23);
            this.txtLastName.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Location = new System.Drawing.Point(10, 1);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(160, 22);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "थर:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(745, 143);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "Search";
            this.btnOk.ThemeColor = System.Drawing.Color.Blue;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(10, 46);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(989, 60);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.TabStop = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton1.Image = global::UEMS.Properties.Resources.AddNew;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton1.Text = "&New";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.newToolbar_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton2.Image = global::UEMS.Properties.Resources.Edit;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripButton2.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton2.Text = "&Edit";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.EditToolbar_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton3.Image = global::UEMS.Properties.Resources.delete;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton3.Text = "&Delete";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.DeleteToolbar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton4.Image = global::UEMS.Properties.Resources.ExcelExport;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton4.Text = "E&xport";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.ExportToolbar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 60);
            // 
            // IndividualPerson_Lst
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 580);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlFirstName);
            this.Controls.Add(this.pnlfk_Ethnicity);
            this.Controls.Add(this.pnlfk_Gender);
            this.Controls.Add(this.pnlLastName);
            this.Controls.Add(this.grid);
            this.Name = "IndividualPerson_Lst";
            this.Text = "ब्यक्तिगत विवरण ";
            this.Load += new System.EventHandler(this.List_Load);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.pnlLastName, 0);
            this.Controls.SetChildIndex(this.pnlfk_Gender, 0);
            this.Controls.SetChildIndex(this.pnlfk_Ethnicity, 0);
            this.Controls.SetChildIndex(this.pnlFirstName, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.pnlFirstName.ResumeLayout(false);
            this.pnlFirstName.PerformLayout();
            this.pnlfk_Ethnicity.ResumeLayout(false);
            this.pnlfk_Gender.ResumeLayout(false);
            this.pnlLastName.ResumeLayout(false);
            this.pnlLastName.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

} private System.Windows.Forms.DataGridViewTextBoxColumn  colId; 
 private System.Windows.Forms.DataGridViewTextBoxColumn  colFirstName; 
 private System.Windows.Forms.DataGridViewTextBoxColumn  colLastName; 
 private System.Windows.Forms.DataGridViewTextBoxColumn  colfk_Gender; 
 private System.Windows.Forms.DataGridViewTextBoxColumn  colfk_Ethnicity; 
 private System.Windows.Forms.DataGridViewTextBoxColumn  colDifferentlyAbled; 
 private System.Windows.Forms.DataGridViewTextBoxColumn  colfk_Specialization; 
 private System.Windows.Forms.DataGridViewTextBoxColumn  colSocialWorkExp; 
 private System.Windows.Forms.DataGridViewTextBoxColumn  colfk_HighestEducation; 
 private System.Windows.Forms.DataGridViewTextBoxColumn  colfk_Position; 
 private System.Windows.Forms.DataGridViewTextBoxColumn  colfk_Address; 
 private System.Windows.Forms.DataGridViewTextBoxColumn  colfk_ContactInformation; 
 private System.Windows.Forms.DataGridViewTextBoxColumn  colfk_Master_Profession; 



        #endregion

 private System.Windows.Forms.ToolStripButton newToolbar;
        private System.Windows.Forms.ToolStripButton EditToolbar;
        private System.Windows.Forms.ToolStripButton DeleteToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ExportToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ExitToolbar;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel pnlFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel pnlfk_Ethnicity;
        private System.Windows.Forms.ComboBox cmbfk_Ethnicity;
        private System.Windows.Forms.Label lblfk_Ethnicity;
        private System.Windows.Forms.Panel pnlfk_Gender;
        private System.Windows.Forms.ComboBox cmbfk_Gender;
        private System.Windows.Forms.Label lblfk_Gender;
        private System.Windows.Forms.Panel pnlLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        public bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
 
    }
}
