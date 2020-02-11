namespace UEMS.BasicForms
{
    partial class frmSuperAdmin_FISCALYEARSelection
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
            this.pnlFiscalYearId = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFISCALYEARStart = new System.Windows.Forms.Label();
            this.pnlfk_FinancialSource = new System.Windows.Forms.Panel();
            this.cmbfk_FinancialYear = new System.Windows.Forms.ComboBox();
            this.lblfk_FinancialSource = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFiscalYearEnd = new System.Windows.Forms.Label();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.pnlFiscalYearId.SuspendLayout();
            this.pnlfk_FinancialSource.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(523, 2);
            this._closeButton.Size = new System.Drawing.Size(43, 37);
            // 
            // pnlFiscalYearId
            // 
            this.pnlFiscalYearId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFiscalYearId.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiscalYearId.Controls.Add(this.label1);
            this.pnlFiscalYearId.Controls.Add(this.lblFISCALYEARStart);
            this.pnlFiscalYearId.Location = new System.Drawing.Point(45, 110);
            this.pnlFiscalYearId.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlFiscalYearId.Name = "pnlFiscalYearId";
            this.pnlFiscalYearId.Size = new System.Drawing.Size(501, 38);
            this.pnlFiscalYearId.TabIndex = 1;
            this.pnlFiscalYearId.Text = "आर्थिक बर्ष ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "आर्थिक बर्ष सुरु मिति :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFISCALYEARStart
            // 
            this.lblFISCALYEARStart.BackColor = System.Drawing.Color.Transparent;
            this.lblFISCALYEARStart.Location = new System.Drawing.Point(223, 2);
            this.lblFISCALYEARStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFISCALYEARStart.Name = "lblFISCALYEARStart";
            this.lblFISCALYEARStart.Size = new System.Drawing.Size(213, 28);
            this.lblFISCALYEARStart.TabIndex = 0;
            this.lblFISCALYEARStart.Text = "आर्थिक बर्ष ";
            this.lblFISCALYEARStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlfk_FinancialSource
            // 
            this.pnlfk_FinancialSource.AutoSize = true;
            this.pnlfk_FinancialSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlfk_FinancialSource.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_FinancialSource.Controls.Add(this.cmbfk_FinancialYear);
            this.pnlfk_FinancialSource.Controls.Add(this.lblfk_FinancialSource);
            this.pnlfk_FinancialSource.Location = new System.Drawing.Point(45, 72);
            this.pnlfk_FinancialSource.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlfk_FinancialSource.Name = "pnlfk_FinancialSource";
            this.pnlfk_FinancialSource.Size = new System.Drawing.Size(501, 38);
            this.pnlfk_FinancialSource.TabIndex = 2;
            this.pnlfk_FinancialSource.Text = "निकाय";
            // 
            // cmbfk_FinancialYear
            // 
            this.cmbfk_FinancialYear.FormattingEnabled = true;
            this.cmbfk_FinancialYear.Location = new System.Drawing.Point(229, 2);
            this.cmbfk_FinancialYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbfk_FinancialYear.Name = "cmbfk_FinancialYear";
            this.cmbfk_FinancialYear.Size = new System.Drawing.Size(268, 31);
            this.cmbfk_FinancialYear.TabIndex = 0;
            this.cmbfk_FinancialYear.SelectedIndexChanged += new System.EventHandler(this.cmbfk_FinancialYear_SelectedIndexChanged);
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
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblFiscalYearEnd);
            this.panel1.Location = new System.Drawing.Point(45, 148);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 38);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "आर्थिक बर्ष ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "आर्थिक बर्ष अन्त्य मिति  :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFiscalYearEnd
            // 
            this.lblFiscalYearEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblFiscalYearEnd.Location = new System.Drawing.Point(223, 2);
            this.lblFiscalYearEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiscalYearEnd.Name = "lblFiscalYearEnd";
            this.lblFiscalYearEnd.Size = new System.Drawing.Size(213, 28);
            this.lblFiscalYearEnd.TabIndex = 0;
            this.lblFiscalYearEnd.Text = "आर्थिक बर्ष ";
            this.lblFiscalYearEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(292, 205);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeColor = System.Drawing.Color.LimeGreen;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(198, 205);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmSuperAdmin_FISCALYEARSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 255);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlfk_FinancialSource);
            this.Controls.Add(this.pnlFiscalYearId);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSuperAdmin_FISCALYEARSelection";
            this.Text = "चालु आर्थिक बर्ष ";
            this.Load += new System.EventHandler(this.frmSuperAdmin_FISCALYEARSelection_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlFiscalYearId, 0);
            this.Controls.SetChildIndex(this.pnlfk_FinancialSource, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.pnlFiscalYearId.ResumeLayout(false);
            this.pnlfk_FinancialSource.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiscalYearId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFISCALYEARStart;
        private System.Windows.Forms.Panel pnlfk_FinancialSource;
        private System.Windows.Forms.ComboBox cmbfk_FinancialYear;
        private System.Windows.Forms.Label lblfk_FinancialSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFiscalYearEnd;
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
    }
}