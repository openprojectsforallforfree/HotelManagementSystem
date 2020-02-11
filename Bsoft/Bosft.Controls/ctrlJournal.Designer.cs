namespace UEMS
{
    partial class ctrlJournal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDrCr = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbAccountId = new System.Windows.Forms.ComboBox();
            this.pnlCredit = new System.Windows.Forms.Panel();
            this.pnlDebit = new System.Windows.Forms.Panel();
            this.pnlDebit.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDrCr
            // 
            this.cmbDrCr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDrCr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDrCr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrCr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDrCr.FormattingEnabled = true;
            this.cmbDrCr.IntegralHeight = false;
            this.cmbDrCr.Items.AddRange(new object[] {
            "Dr",
            "Cr"});
            this.cmbDrCr.Location = new System.Drawing.Point(18, 3);
            this.cmbDrCr.Name = "cmbDrCr";
            this.cmbDrCr.Size = new System.Drawing.Size(53, 21);
            this.cmbDrCr.TabIndex = 11;
            this.cmbDrCr.SelectedIndexChanged += new System.EventHandler(this.cmbDrCr_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAmount.Location = new System.Drawing.Point(0, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(139, 20);
            this.txtAmount.TabIndex = 10;
            // 
            // cmbAccountId
            // 
            this.cmbAccountId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccountId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccountId.FormattingEnabled = true;
            this.cmbAccountId.Location = new System.Drawing.Point(102, 3);
            this.cmbAccountId.Name = "cmbAccountId";
            this.cmbAccountId.Size = new System.Drawing.Size(160, 21);
            this.cmbAccountId.TabIndex = 9;
            // 
            // pnlCredit
            // 
            this.pnlCredit.Location = new System.Drawing.Point(484, 3);
            this.pnlCredit.Name = "pnlCredit";
            this.pnlCredit.Size = new System.Drawing.Size(139, 30);
            this.pnlCredit.TabIndex = 12;
            // 
            // pnlDebit
            // 
            this.pnlDebit.Controls.Add(this.txtAmount);
            this.pnlDebit.Location = new System.Drawing.Point(335, 3);
            this.pnlDebit.Name = "pnlDebit";
            this.pnlDebit.Size = new System.Drawing.Size(139, 29);
            this.pnlDebit.TabIndex = 12;
            // 
            // ctrlJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDebit);
            this.Controls.Add(this.pnlCredit);
            this.Controls.Add(this.cmbDrCr);
            this.Controls.Add(this.cmbAccountId);
            this.Name = "ctrlJournal";
            this.Size = new System.Drawing.Size(634, 33);
            this.pnlDebit.ResumeLayout(false);
            this.pnlDebit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrCr;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbAccountId;
        private System.Windows.Forms.Panel pnlCredit;
        private System.Windows.Forms.Panel pnlDebit;
    }
}
