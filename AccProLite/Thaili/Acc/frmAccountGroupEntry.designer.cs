namespace UEMS
{
    partial class frmAccountGroupEntry
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
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbParentId = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblParentId = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkUsedforCalculations = new System.Windows.Forms.CheckBox();
            this.chkBehavesLikeSubLedger = new System.Windows.Forms.CheckBox();
            this.chkDebitcreditBalanceforReporting = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(564, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(318, 353);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(211, 353);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbParentId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblParentId);
            this.groupBox1.Controls.Add(this.lblAlias);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtAlias);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.chkUsedforCalculations);
            this.groupBox1.Controls.Add(this.chkBehavesLikeSubLedger);
            this.groupBox1.Controls.Add(this.chkDebitcreditBalanceforReporting);
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 311);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // cmbParentId
            // 
            this.cmbParentId.FormattingEnabled = true;
            this.cmbParentId.Location = new System.Drawing.Point(278, 52);
            this.cmbParentId.Name = "cmbParentId";
            this.cmbParentId.Size = new System.Drawing.Size(160, 31);
            this.cmbParentId.TabIndex = 11;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(28, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblId.Visible = false;
            // 
            // lblParentId
            // 
            this.lblParentId.BackColor = System.Drawing.Color.Transparent;
            this.lblParentId.Location = new System.Drawing.Point(116, 52);
            this.lblParentId.Name = "lblParentId";
            this.lblParentId.Size = new System.Drawing.Size(160, 22);
            this.lblParentId.TabIndex = 0;
            this.lblParentId.Text = "ParentId";
            this.lblParentId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAlias
            // 
            this.lblAlias.BackColor = System.Drawing.Color.Transparent;
            this.lblAlias.Location = new System.Drawing.Point(112, 112);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(160, 22);
            this.lblAlias.TabIndex = 0;
            this.lblAlias.Text = "Alias";
            this.lblAlias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Location = new System.Drawing.Point(116, 142);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(160, 22);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(66, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(32, 30);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(116, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Account Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(278, 82);
            this.txtName.MaxLength = 15;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 30);
            this.txtName.TabIndex = 2;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(278, 112);
            this.txtAlias.MaxLength = 15;
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(160, 30);
            this.txtAlias.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(278, 142);
            this.txtDescription.MaxLength = 150;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(160, 30);
            this.txtDescription.TabIndex = 3;
            // 
            // chkUsedforCalculations
            // 
            this.chkUsedforCalculations.AutoSize = true;
            this.chkUsedforCalculations.Location = new System.Drawing.Point(278, 232);
            this.chkUsedforCalculations.Name = "chkUsedforCalculations";
            this.chkUsedforCalculations.Size = new System.Drawing.Size(171, 30);
            this.chkUsedforCalculations.TabIndex = 6;
            this.chkUsedforCalculations.Text = "Used for Calculations";
            this.chkUsedforCalculations.UseVisualStyleBackColor = true;
            // 
            // chkBehavesLikeSubLedger
            // 
            this.chkBehavesLikeSubLedger.AutoSize = true;
            this.chkBehavesLikeSubLedger.Location = new System.Drawing.Point(278, 172);
            this.chkBehavesLikeSubLedger.Name = "chkBehavesLikeSubLedger";
            this.chkBehavesLikeSubLedger.Size = new System.Drawing.Size(205, 30);
            this.chkBehavesLikeSubLedger.TabIndex = 4;
            this.chkBehavesLikeSubLedger.Text = "Behaves Like Sub Ledger";
            this.chkBehavesLikeSubLedger.UseVisualStyleBackColor = true;
            // 
            // chkDebitcreditBalanceforReporting
            // 
            this.chkDebitcreditBalanceforReporting.AutoSize = true;
            this.chkDebitcreditBalanceforReporting.Location = new System.Drawing.Point(278, 202);
            this.chkDebitcreditBalanceforReporting.Name = "chkDebitcreditBalanceforReporting";
            this.chkDebitcreditBalanceforReporting.Size = new System.Drawing.Size(255, 30);
            this.chkDebitcreditBalanceforReporting.TabIndex = 5;
            this.chkDebitcreditBalanceforReporting.Text = "Debit credit Balance for Reporting";
            this.chkDebitcreditBalanceforReporting.UseVisualStyleBackColor = true;
            // 
            // frmAccountGroupEntry
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "frmAccountGroupEntry";
            this.Load += new System.EventHandler(this.frmAccountGroupEntry_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

}//<Control>
 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtName; 
 private System.Windows.Forms.TextBox txtDescription; 
 private System.Windows.Forms.CheckBox chkBehavesLikeSubLedger; 
 private System.Windows.Forms.CheckBox chkDebitcreditBalanceforReporting; 
 private System.Windows.Forms.CheckBox chkUsedforCalculations;
 private System.Windows.Forms.TextBox txtAlias; 

 private System.Windows.Forms.Label  lblId; 
 private System.Windows.Forms.Label  lblName;
 private System.Windows.Forms.Label lblDescription; 
 private System.Windows.Forms.Label  lblAlias; 
 private System.Windows.Forms.Label  lblParentId; 



        #endregion
        //<declaration>
        private bsoftcontrols .fsButton btnCancel;
        private bsoftcontrols .fsButton btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbParentId;
    }
}