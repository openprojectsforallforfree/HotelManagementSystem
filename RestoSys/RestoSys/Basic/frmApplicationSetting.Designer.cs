namespace RestoSys.RestaurantBilling
{
    partial class frmApplicationSetting
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
            this.chkPrintBill = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtService = new Bsoft.Controls.VtextBox();
            this.txtVat = new Bsoft.Controls.VtextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new bsoftcontrols.fsButton();
            this.lblBackupFolder = new System.Windows.Forms.Label();
            this.txtBackupFolder = new Bsoft.Controls.VtextBox();
            this.btnClose = new bsoftcontrols.fsButton();
            this.btnSave = new bsoftcontrols.fsButton();
            this.folderBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(783, 2);
            this._closeButton.Size = new System.Drawing.Size(31, 30);
            // 
            // chkPrintBill
            // 
            this.chkPrintBill.AutoSize = true;
            this.chkPrintBill.Location = new System.Drawing.Point(212, 33);
            this.chkPrintBill.Margin = new System.Windows.Forms.Padding(4);
            this.chkPrintBill.Name = "chkPrintBill";
            this.chkPrintBill.Size = new System.Drawing.Size(15, 14);
            this.chkPrintBill.TabIndex = 2;
            this.chkPrintBill.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Print Bill";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "VAT Percentage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Service Charge Percentage";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtService);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVat);
            this.groupBox1.Location = new System.Drawing.Point(19, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(382, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing Setting";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(225, 50);
            this.txtService.Margin = new System.Windows.Forms.Padding(4);
            this.txtService.MaxLength = 3;
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(105, 23);
            this.txtService.TabIndex = 0;
            this.txtService.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtService.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Integer;
            this.txtService.Value = "";
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(225, 81);
            this.txtVat.Margin = new System.Windows.Forms.Padding(4);
            this.txtVat.MaxLength = 3;
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(105, 23);
            this.txtVat.TabIndex = 1;
            this.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVat.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Integer;
            this.txtVat.Value = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.chkPrintBill);
            this.groupBox2.Controls.Add(this.lblBackupFolder);
            this.groupBox2.Controls.Add(this.txtBackupFolder);
            this.groupBox2.Location = new System.Drawing.Point(16, 202);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(751, 135);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Setting";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBrowse.BackColor = System.Drawing.Color.Orange;
            this.btnBrowse.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(676, 68);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(35, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblBackupFolder
            // 
            this.lblBackupFolder.Location = new System.Drawing.Point(8, 64);
            this.lblBackupFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackupFolder.Name = "lblBackupFolder";
            this.lblBackupFolder.Size = new System.Drawing.Size(196, 27);
            this.lblBackupFolder.TabIndex = 3;
            this.lblBackupFolder.Text = "Backup Folder";
            this.lblBackupFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBackupFolder
            // 
            this.txtBackupFolder.Location = new System.Drawing.Point(212, 68);
            this.txtBackupFolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackupFolder.Name = "txtBackupFolder";
            this.txtBackupFolder.Size = new System.Drawing.Size(456, 23);
            this.txtBackupFolder.TabIndex = 1;
            this.txtBackupFolder.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtBackupFolder.Value = "";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BackColor = System.Drawing.Color.Orange;
            this.btnClose.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(419, 356);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 32);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.Orange;
            this.btnSave.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(309, 356);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 32);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // folderBackup
            // 
            this.folderBackup.Description = "Select Location for Database Backup";
            // 
            // frmApplicationSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 402);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmApplicationSetting";
            this.Text = "Application Settings";
            this.Load += new System.EventHandler(this.frmApplicationSetting_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bsoft.Controls.VtextBox txtService;
        private Bsoft.Controls.VtextBox txtVat;
        private System.Windows.Forms.CheckBox chkPrintBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private bsoftcontrols.fsButton btnClose;
        private bsoftcontrols.fsButton btnSave;
        private System.Windows.Forms.Label lblBackupFolder;
        private Bsoft.Controls.VtextBox txtBackupFolder;
        private bsoftcontrols.fsButton btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBackup;
    }
}