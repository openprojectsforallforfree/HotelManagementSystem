namespace UEMS.Forms.MasterEntry
{
    partial class frmSelectVDCMunicipalList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectVDCMunicipalList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSrchbyName = new System.Windows.Forms.Label();
            this.txtVDCName = new System.Windows.Forms.TextBox();
            this.lblSrchbyEngname = new System.Windows.Forms.Label();
            this.txtEngname = new System.Windows.Forms.TextBox();
            this.btnAddEdit = new bsoftcontrols.fsButton();
            this.btnSave = new bsoftcontrols.fsButton();
            this.btnExit = new bsoftcontrols.fsButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDistrictID = new System.Windows.Forms.TextBox();
            this.txtZoneID = new System.Windows.Forms.TextBox();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NepName,
            this.EngName,
            this.SerialNo});
            this.dataGridView1.Location = new System.Drawing.Point(7, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 269);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "संकेत";
            this.ID.Name = "ID";
            this.ID.Width = 80;
            // 
            // NepName
            // 
            this.NepName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NepName.HeaderText = "नाम";
            this.NepName.Name = "NepName";
            // 
            // EngName
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngName.DefaultCellStyle = dataGridViewCellStyle2;
            this.EngName.HeaderText = "नाम (अंगेजीमा)";
            this.EngName.Name = "EngName";
            this.EngName.Width = 140;
            // 
            // SerialNo
            // 
            this.SerialNo.HeaderText = "क्रम संख्या";
            this.SerialNo.Name = "SerialNo";
            // 
            // lblSrchbyName
            // 
            this.lblSrchbyName.AutoSize = true;
            this.lblSrchbyName.BackColor = System.Drawing.Color.Transparent;
            this.lblSrchbyName.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrchbyName.Location = new System.Drawing.Point(62, 96);
            this.lblSrchbyName.Name = "lblSrchbyName";
            this.lblSrchbyName.Size = new System.Drawing.Size(216, 23);
            this.lblSrchbyName.TabIndex = 36;
            this.lblSrchbyName.Text = "गा.वि.स./न.पा.को नामबाट खोज्नेः";
            this.lblSrchbyName.Visible = false;
            // 
            // txtVDCName
            // 
            this.txtVDCName.Location = new System.Drawing.Point(278, 93);
            this.txtVDCName.Name = "txtVDCName";
            this.txtVDCName.Size = new System.Drawing.Size(211, 30);
            this.txtVDCName.TabIndex = 37;
            this.txtVDCName.Visible = false;
            this.txtVDCName.TextChanged += new System.EventHandler(this.txtVDCName_TextChanged);
            // 
            // lblSrchbyEngname
            // 
            this.lblSrchbyEngname.AutoSize = true;
            this.lblSrchbyEngname.BackColor = System.Drawing.Color.Transparent;
            this.lblSrchbyEngname.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
 
            this.lblSrchbyEngname.Location = new System.Drawing.Point(62, 132);
            this.lblSrchbyEngname.Name = "lblSrchbyEngname";
            this.lblSrchbyEngname.Size = new System.Drawing.Size(152, 23);
            this.lblSrchbyEngname.TabIndex = 38;
            this.lblSrchbyEngname.Text = "अंग्रेजी नामबाट खोज्नेः";
            this.lblSrchbyEngname.Visible = false;
            // 
            // txtEngname
            // 
            this.txtEngname.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngname.Location = new System.Drawing.Point(278, 129);
            this.txtEngname.Name = "txtEngname";
            this.txtEngname.Size = new System.Drawing.Size(211, 30);
            this.txtEngname.TabIndex = 39;
            this.txtEngname.Visible = false;
            this.txtEngname.TextChanged += new System.EventHandler(this.txtEngname_TextChanged);
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddEdit.Location = new System.Drawing.Point(182, 111);
            this.btnAddEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(191, 31);
            this.btnAddEdit.TabIndex = 4;
            this.btnAddEdit.Text = "थप/घट तथा सुधार";
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(152, 453);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "सदर गरेर फर्कने";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Location = new System.Drawing.Point(278, 453);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "त्यसै फर्कने";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtDistrictID);
            this.groupBox1.Controls.Add(this.txtZoneID);
            this.groupBox1.Controls.Add(this.cmbDistrict);
            this.groupBox1.Controls.Add(this.cmbZone);
            this.groupBox1.Controls.Add(this.lblDistrict);
            this.groupBox1.Controls.Add(this.lblZone);
            this.groupBox1.Location = new System.Drawing.Point(19, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtDistrictID
            // 
            this.txtDistrictID.Location = new System.Drawing.Point(308, 18);
            this.txtDistrictID.Name = "txtDistrictID";
            this.txtDistrictID.Size = new System.Drawing.Size(43, 30);
            this.txtDistrictID.TabIndex = 2;
            this.txtDistrictID.Validating += new System.ComponentModel.CancelEventHandler(this.txtDistrictID_Validating);
            // 
            // txtZoneID
            // 
            this.txtZoneID.Location = new System.Drawing.Point(46, 18);
            this.txtZoneID.Name = "txtZoneID";
            this.txtZoneID.Size = new System.Drawing.Size(43, 30);
            this.txtZoneID.TabIndex = 0;
            this.txtZoneID.Validating += new System.ComponentModel.CancelEventHandler(this.txtZoneID_Validating);
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(357, 18);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(163, 31);
            this.cmbDistrict.TabIndex = 3;
            this.cmbDistrict.SelectedIndexChanged += new System.EventHandler(this.cmbDistrict_SelectedIndexChanged);
            // 
            // cmbZone
            // 
            this.cmbZone.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(95, 18);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(161, 31);
            this.cmbZone.TabIndex = 1;
            this.cmbZone.SelectedIndexChanged += new System.EventHandler(this.cmbZone_SelectedIndexChanged);
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.BackColor = System.Drawing.Color.Transparent;
            this.lblDistrict.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         
            this.lblDistrict.Location = new System.Drawing.Point(262, 21);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(48, 23);
            this.lblDistrict.TabIndex = 6;
            this.lblDistrict.Text = "जिल्ला";
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.BackColor = System.Drawing.Color.Transparent;
            this.lblZone.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZone.Location = new System.Drawing.Point(6, 23);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(43, 23);
            this.lblZone.TabIndex = 4;
            this.lblZone.Text = "अचंल";
            // 
            // frmSelectVDCMunicipalList
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(555, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.txtEngname);
            this.Controls.Add(this.lblSrchbyEngname);
            this.Controls.Add(this.txtVDCName);
            this.Controls.Add(this.lblSrchbyName);
            this.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSelectVDCMunicipalList";
            this.Text = "गा.वि.स./न.पा.हरूको सूची";
            this.Load += new System.EventHandler(this.frmSelectVDCMunicipalList_Load);
            this.Activated += new System.EventHandler(this.frmSelectVDCMunicipalList_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSrchbyName;
        private System.Windows.Forms.TextBox txtVDCName;
        private System.Windows.Forms.Label lblSrchbyEngname;
        private System.Windows.Forms.TextBox txtEngname;
        private bsoftcontrols .fsButton  btnAddEdit;
        private bsoftcontrols.fsButton btnSave;
        private bsoftcontrols.fsButton btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmbDistrict;
        public System.Windows.Forms.ComboBox cmbZone;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.TextBox txtDistrictID;
        private System.Windows.Forms.TextBox txtZoneID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
    }
}
