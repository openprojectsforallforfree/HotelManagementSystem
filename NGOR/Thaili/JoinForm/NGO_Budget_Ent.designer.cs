namespace UEMS
{
    partial class NGO_Budget_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NGO_Budget_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtfk_NGO = new System.Windows.Forms.TextBox();
            this.pnlFiscalYearId = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFinancialYear = new System.Windows.Forms.ComboBox();
            this.txtFiscalYearId = new System.Windows.Forms.TextBox();
            this.pnlfk_FinancialSource = new System.Windows.Forms.Panel();
            this.cmbfk_FinancialSource = new System.Windows.Forms.ComboBox();
            this.lblfk_FinancialSource = new System.Windows.Forms.Label();
            this.pnlAmount = new System.Windows.Forms.Panel();
            this.txtAmount = new Bsoft.Controls.VtextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlFiscalYearId.SuspendLayout();
            this.pnlfk_FinancialSource.SuspendLayout();
            this.pnlAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(445, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(247, 218);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
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
            this.btnOk.Location = new System.Drawing.Point(153, 218);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(224, 12);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(58, 23);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // txtfk_NGO
            // 
            this.txtfk_NGO.Location = new System.Drawing.Point(165, 12);
            this.txtfk_NGO.MaxLength = 5;
            this.txtfk_NGO.Name = "txtfk_NGO";
            this.txtfk_NGO.Size = new System.Drawing.Size(53, 23);
            this.txtfk_NGO.TabIndex = 0;
            this.txtfk_NGO.Visible = false;
            // 
            // pnlFiscalYearId
            // 
            this.pnlFiscalYearId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFiscalYearId.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiscalYearId.Controls.Add(this.label1);
            this.pnlFiscalYearId.Controls.Add(this.cmbFinancialYear);
            this.pnlFiscalYearId.Location = new System.Drawing.Point(22, 84);
            this.pnlFiscalYearId.Margin = new System.Windows.Forms.Padding(1);
            this.pnlFiscalYearId.Name = "pnlFiscalYearId";
            this.pnlFiscalYearId.Size = new System.Drawing.Size(398, 36);
            this.pnlFiscalYearId.TabIndex = 0;
            this.pnlFiscalYearId.Text = "आर्थिक बर्ष ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "आर्थिक बर्ष :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFinancialYear
            // 
            this.cmbFinancialYear.Font = new System.Drawing.Font("Shangrila Numeric", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFinancialYear.FormattingEnabled = true;
            this.cmbFinancialYear.Location = new System.Drawing.Point(172, 0);
            this.cmbFinancialYear.Name = "cmbFinancialYear";
            this.cmbFinancialYear.Size = new System.Drawing.Size(202, 25);
            this.cmbFinancialYear.TabIndex = 0;
            // 
            // txtFiscalYearId
            // 
            this.txtFiscalYearId.Location = new System.Drawing.Point(46, 12);
            this.txtFiscalYearId.MaxLength = 5;
            this.txtFiscalYearId.Name = "txtFiscalYearId";
            this.txtFiscalYearId.Size = new System.Drawing.Size(57, 23);
            this.txtFiscalYearId.TabIndex = 0;
            this.txtFiscalYearId.Visible = false;
            // 
            // pnlfk_FinancialSource
            // 
            this.pnlfk_FinancialSource.AutoSize = true;
            this.pnlfk_FinancialSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlfk_FinancialSource.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_FinancialSource.Controls.Add(this.cmbfk_FinancialSource);
            this.pnlfk_FinancialSource.Controls.Add(this.lblfk_FinancialSource);
            this.pnlfk_FinancialSource.Location = new System.Drawing.Point(22, 121);
            this.pnlfk_FinancialSource.Margin = new System.Windows.Forms.Padding(1);
            this.pnlfk_FinancialSource.Name = "pnlfk_FinancialSource";
            this.pnlfk_FinancialSource.Size = new System.Drawing.Size(377, 28);
            this.pnlfk_FinancialSource.TabIndex = 1;
            this.pnlfk_FinancialSource.Text = "निकाय";
            // 
            // cmbfk_FinancialSource
            // 
            this.cmbfk_FinancialSource.FormattingEnabled = true;
            this.cmbfk_FinancialSource.Location = new System.Drawing.Point(172, 1);
            this.cmbfk_FinancialSource.Name = "cmbfk_FinancialSource";
            this.cmbfk_FinancialSource.Size = new System.Drawing.Size(202, 24);
            this.cmbfk_FinancialSource.TabIndex = 0;
            // 
            // lblfk_FinancialSource
            // 
            this.lblfk_FinancialSource.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_FinancialSource.Location = new System.Drawing.Point(10, 1);
            this.lblfk_FinancialSource.Name = "lblfk_FinancialSource";
            this.lblfk_FinancialSource.Size = new System.Drawing.Size(160, 22);
            this.lblfk_FinancialSource.TabIndex = 0;
            this.lblfk_FinancialSource.Text = "आर्थिक श्रोत :";
            this.lblfk_FinancialSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlAmount
            // 
            this.pnlAmount.AutoSize = true;
            this.pnlAmount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAmount.BackColor = System.Drawing.Color.Transparent;
            this.pnlAmount.Controls.Add(this.txtAmount);
            this.pnlAmount.Controls.Add(this.lblAmount);
            this.pnlAmount.Location = new System.Drawing.Point(22, 157);
            this.pnlAmount.Margin = new System.Windows.Forms.Padding(1);
            this.pnlAmount.Name = "pnlAmount";
            this.pnlAmount.Size = new System.Drawing.Size(377, 30);
            this.pnlAmount.TabIndex = 2;
            this.pnlAmount.Text = "रकम(रु. हाजरमा)";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Shangrila Numeric", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(172, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(202, 25);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Text = "0.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.MoneyNepali;
            this.txtAmount.Value = "0.00";
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Location = new System.Drawing.Point(10, 1);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(160, 22);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "रकम(रु. हजारमा) :";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NGO_Budget_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 256);
            this.Controls.Add(this.txtFiscalYearId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtfk_NGO);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlAmount);
            this.Controls.Add(this.pnlFiscalYearId);
            this.Controls.Add(this.pnlfk_FinancialSource);
            this.Name = "NGO_Budget_Ent";
            this.Text = "वार्षिक बजेट (रु. हजारमा)";
            this.Load += new System.EventHandler(this.NGO_Budget_Ent_Load);
            this.Controls.SetChildIndex(this.pnlfk_FinancialSource, 0);
            this.Controls.SetChildIndex(this.pnlFiscalYearId, 0);
            this.Controls.SetChildIndex(this.pnlAmount, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.txtfk_NGO, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtFiscalYearId, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.pnlFiscalYearId.ResumeLayout(false);
            this.pnlfk_FinancialSource.ResumeLayout(false);
            this.pnlAmount.ResumeLayout(false);
            this.pnlAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }//<Control>  
 private System.Windows.Forms.Panel pnlFiscalYearId; 
 private System.Windows.Forms.Panel pnlfk_FinancialSource; 
 private System.Windows.Forms.Panel pnlAmount; 

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtfk_NGO; 
 private System.Windows.Forms.TextBox txtFiscalYearId;
 private System.Windows.Forms.ComboBox cmbfk_FinancialSource; 
 private System.Windows.Forms.Label  lblfk_FinancialSource; 
 private System.Windows.Forms.Label  lblAmount; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFinancialYear;
        private Bsoft.Controls.VtextBox txtAmount;
    }
}
