namespace UEMS.Forms.MasterEntry
{
    partial class frmPresentVDCMunicipalNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresentVDCMunicipalNew));
            this.SaveButton = new bsoftcontrols.fsButton();
            this.CancelBtn = new bsoftcontrols.fsButton();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.txtVDCID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.txtDistrictID = new System.Windows.Forms.TextBox();
            this.txtZoneID = new System.Windows.Forms.TextBox();
            this.lblDistrictName = new System.Windows.Forms.Label();
            this.lblZoneName = new System.Windows.Forms.Label();
            this.txtVDCengname = new System.Windows.Forms.TextBox();
            this.txtVDCname = new System.Windows.Forms.TextBox();
            this.lblVDCEngname = new System.Windows.Forms.Label();
            this.lblVDCname = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SaveButton.Location = new System.Drawing.Point(120, 252);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 31);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "सदर गरेर फर्कने";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CancelBtn.Location = new System.Drawing.Point(248, 252);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(112, 31);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "त्यसै फर्कने";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.Enabled = false;
            this.cmbDistrict.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(201, 27);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(121, 31);
            this.cmbDistrict.TabIndex = 60;
            this.cmbDistrict.Visible = false;
            // 
            // cmbZone
            // 
            this.cmbZone.Enabled = false;
            this.cmbZone.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(222, 20);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(121, 31);
            this.cmbZone.TabIndex = 61;
            this.cmbZone.Visible = false;
            // 
            // txtVDCID
            // 
            this.txtVDCID.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVDCID.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtVDCID.Location = new System.Drawing.Point(222, 57);
            this.txtVDCID.Name = "txtVDCID";
            this.txtVDCID.Size = new System.Drawing.Size(124, 30);
            this.txtVDCID.TabIndex = 62;
            this.txtVDCID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtSerial);
            this.groupBox1.Controls.Add(this.txtDistrictID);
            this.groupBox1.Controls.Add(this.txtZoneID);
            this.groupBox1.Controls.Add(this.lblDistrictName);
            this.groupBox1.Controls.Add(this.lblZoneName);
            this.groupBox1.Controls.Add(this.txtVDCengname);
            this.groupBox1.Controls.Add(this.txtVDCname);
            this.groupBox1.Controls.Add(this.lblVDCEngname);
            this.groupBox1.Controls.Add(this.lblVDCname);
            this.groupBox1.Controls.Add(this.lblDistrict);
            this.groupBox1.Controls.Add(this.lblZone);
            this.groupBox1.Controls.Add(this.cmbDistrict);
            this.groupBox1.Location = new System.Drawing.Point(11, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(407, 23);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(47, 30);
            this.txtSerial.TabIndex = 63;
            this.txtSerial.Visible = false;
            // 
            // txtDistrictID
            // 
            this.txtDistrictID.Location = new System.Drawing.Point(354, 57);
            this.txtDistrictID.Name = "txtDistrictID";
            this.txtDistrictID.Size = new System.Drawing.Size(47, 30);
            this.txtDistrictID.TabIndex = 62;
            this.txtDistrictID.Tag = "DEFAULT";
            this.txtDistrictID.Visible = false;
            // 
            // txtZoneID
            // 
            this.txtZoneID.Location = new System.Drawing.Point(354, 20);
            this.txtZoneID.Name = "txtZoneID";
            this.txtZoneID.Size = new System.Drawing.Size(47, 30);
            this.txtZoneID.TabIndex = 61;
            this.txtZoneID.Tag = "DEFAULT";
            this.txtZoneID.Visible = false;
            // 
            // lblDistrictName
            // 
            this.lblDistrictName.AutoSize = true;
            this.lblDistrictName.BackColor = System.Drawing.Color.Transparent;
            this.lblDistrictName.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrictName.ForeColor = System.Drawing.Color.Blue;
            this.lblDistrictName.Location = new System.Drawing.Point(202, 60);
            this.lblDistrictName.Name = "lblDistrictName";
            this.lblDistrictName.Size = new System.Drawing.Size(48, 23);
            this.lblDistrictName.TabIndex = 3;
            this.lblDistrictName.Text = "जिल्ला";
            // 
            // lblZoneName
            // 
            this.lblZoneName.AutoSize = true;
            this.lblZoneName.BackColor = System.Drawing.Color.Transparent;
            this.lblZoneName.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoneName.ForeColor = System.Drawing.Color.Blue;
            this.lblZoneName.Location = new System.Drawing.Point(202, 23);
            this.lblZoneName.Name = "lblZoneName";
            this.lblZoneName.Size = new System.Drawing.Size(43, 23);
            this.lblZoneName.TabIndex = 1;
            this.lblZoneName.Text = "अंचल";
            // 
            // txtVDCengname
            // 
            this.txtVDCengname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVDCengname.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVDCengname.Location = new System.Drawing.Point(228, 150);
            this.txtVDCengname.MaxLength = 49;
            this.txtVDCengname.Name = "txtVDCengname";
            this.txtVDCengname.Size = new System.Drawing.Size(252, 23);
            this.txtVDCengname.TabIndex = 1;
            // 
            // txtVDCname
            // 
            this.txtVDCname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVDCname.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVDCname.Location = new System.Drawing.Point(228, 102);
            this.txtVDCname.MaxLength = 69;
            this.txtVDCname.Name = "txtVDCname";
            this.txtVDCname.Size = new System.Drawing.Size(252, 23);
            this.txtVDCname.TabIndex = 0;
            // 
            // lblVDCEngname
            // 
            this.lblVDCEngname.AutoSize = true;
            this.lblVDCEngname.BackColor = System.Drawing.Color.Transparent;
            this.lblVDCEngname.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVDCEngname.ForeColor = System.Drawing.Color.DarkRed;
            this.lblVDCEngname.Location = new System.Drawing.Point(16, 145);
            this.lblVDCEngname.Name = "lblVDCEngname";
            this.lblVDCEngname.Size = new System.Drawing.Size(192, 23);
            this.lblVDCEngname.TabIndex = 6;
            this.lblVDCEngname.Text = "गा.वि.स./न.पा.को अंगेजी नाम";
            // 
            // lblVDCname
            // 
            this.lblVDCname.AutoSize = true;
            this.lblVDCname.BackColor = System.Drawing.Color.Transparent;
            this.lblVDCname.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVDCname.ForeColor = System.Drawing.Color.DarkRed;
            this.lblVDCname.Location = new System.Drawing.Point(16, 98);
            this.lblVDCname.Name = "lblVDCname";
            this.lblVDCname.Size = new System.Drawing.Size(144, 23);
            this.lblVDCname.TabIndex = 4;
            this.lblVDCname.Text = "गा.वि.स./न.पा.को नाम";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.BackColor = System.Drawing.Color.Transparent;
            this.lblDistrict.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.ForeColor = System.Drawing.Color.Black;
            this.lblDistrict.Location = new System.Drawing.Point(19, 57);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(48, 23);
            this.lblDistrict.TabIndex = 2;
            this.lblDistrict.Text = "जिल्ला";
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.BackColor = System.Drawing.Color.Transparent;
            this.lblZone.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZone.ForeColor = System.Drawing.Color.Black;
            this.lblZone.Location = new System.Drawing.Point(19, 20);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(43, 23);
            this.lblZone.TabIndex = 0;
            this.lblZone.Text = "अंचल";
            // 
            // frmPresentVDCMunicipalNew
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(503, 300);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtVDCID);
            this.Controls.Add(this.cmbZone);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveButton);
            this.Font = new System.Drawing.Font("Madan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPresentVDCMunicipalNew";
            this.Text = "गा.वि.स./न.पा.हरूको विवरण प्रविष्टि";
            this.Load += new System.EventHandler(this.frmPresentVDCMunicipalNew_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bsoftcontrols.fsButton SaveButton;
        private bsoftcontrols.fsButton CancelBtn;
        public System.Windows.Forms.ComboBox cmbDistrict;
        public System.Windows.Forms.ComboBox cmbZone;
        private System.Windows.Forms.TextBox txtVDCID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDistrictName;
        private System.Windows.Forms.Label lblZoneName;
        private System.Windows.Forms.TextBox txtVDCengname;
        private System.Windows.Forms.TextBox txtVDCname;
        private System.Windows.Forms.Label lblVDCEngname;
        private System.Windows.Forms.Label lblVDCname;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.TextBox txtDistrictID;
        private System.Windows.Forms.TextBox txtZoneID;
        private System.Windows.Forms.TextBox txtSerial;
    }
}
