namespace UEMS
{
    partial class FiscalYears_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiscalYears_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.flwLayout = new Bsoft.Controls.LableFlowLayout();
            this.pnlId = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlFiscalYear = new System.Windows.Forms.Panel();
            this.txtFiscalYear = new System.Windows.Forms.TextBox();
            this.lblFiscalYear = new System.Windows.Forms.Label();
            this.pnlDateFrom = new System.Windows.Forms.Panel();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.pnlDateTo = new System.Windows.Forms.Panel();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.flwLayout.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.pnlFiscalYear.SuspendLayout();
            this.pnlDateFrom.SuspendLayout();
            this.pnlDateTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(817, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(433, 472);
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
            this.btnOk.Location = new System.Drawing.Point(339, 472);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // flwLayout
            // 
            this.flwLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flwLayout.AutoScroll = true;
            this.flwLayout.BackColor = System.Drawing.Color.Transparent;
            this.flwLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwLayout.Controls.Add(this.pnlId);
            this.flwLayout.Controls.Add(this.pnlFiscalYear);
            this.flwLayout.Controls.Add(this.pnlDateFrom);
            this.flwLayout.Controls.Add(this.pnlDateTo);
            this.flwLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwLayout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flwLayout.lable = "";
            this.flwLayout.Location = new System.Drawing.Point(6, 50);
            this.flwLayout.Name = "flwLayout";
            this.flwLayout.Size = new System.Drawing.Size(837, 409);
            this.flwLayout.TabIndex = 11;
            this.flwLayout.WrapContents = false;
            // 
            // pnlId
            // 
            this.pnlId.AutoSize = true;
            this.pnlId.BackColor = System.Drawing.Color.Transparent;
            this.pnlId.Controls.Add(this.txtId);
            this.pnlId.Controls.Add(this.lblId);
            this.pnlId.Location = new System.Drawing.Point(3, 46);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(335, 43);
            this.pnlId.TabIndex = 0;
            this.pnlId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(172, 10);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 30);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(10, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(160, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFiscalYear
            // 
            this.pnlFiscalYear.AutoSize = true;
            this.pnlFiscalYear.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiscalYear.Controls.Add(this.txtFiscalYear);
            this.pnlFiscalYear.Controls.Add(this.lblFiscalYear);
            this.pnlFiscalYear.Location = new System.Drawing.Point(3, 95);
            this.pnlFiscalYear.Name = "pnlFiscalYear";
            this.pnlFiscalYear.Size = new System.Drawing.Size(335, 38);
            this.pnlFiscalYear.TabIndex = 0;
            this.pnlFiscalYear.Text = "FiscalYear";
            // 
            // txtFiscalYear
            // 
            this.txtFiscalYear.Font = new System.Drawing.Font("Shangrila Numeric", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiscalYear.Location = new System.Drawing.Point(172, 10);
            this.txtFiscalYear.MaxLength = 15;
            this.txtFiscalYear.Name = "txtFiscalYear";
            this.txtFiscalYear.Size = new System.Drawing.Size(160, 25);
            this.txtFiscalYear.TabIndex = 0;
            // 
            // lblFiscalYear
            // 
            this.lblFiscalYear.BackColor = System.Drawing.Color.Transparent;
            this.lblFiscalYear.Location = new System.Drawing.Point(10, 10);
            this.lblFiscalYear.Name = "lblFiscalYear";
            this.lblFiscalYear.Size = new System.Drawing.Size(160, 22);
            this.lblFiscalYear.TabIndex = 0;
            this.lblFiscalYear.Text = "FiscalYear:";
            this.lblFiscalYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDateFrom
            // 
            this.pnlDateFrom.AutoSize = true;
            this.pnlDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.pnlDateFrom.Controls.Add(this.txtDateFrom);
            this.pnlDateFrom.Controls.Add(this.lblDateFrom);
            this.pnlDateFrom.Location = new System.Drawing.Point(3, 139);
            this.pnlDateFrom.Name = "pnlDateFrom";
            this.pnlDateFrom.Size = new System.Drawing.Size(335, 38);
            this.pnlDateFrom.TabIndex = 0;
            this.pnlDateFrom.Text = "DateFrom";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Font = new System.Drawing.Font("Shangrila Numeric", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFrom.Location = new System.Drawing.Point(172, 10);
            this.txtDateFrom.MaxLength = 15;
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(160, 25);
            this.txtDateFrom.TabIndex = 0;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblDateFrom.Location = new System.Drawing.Point(10, 10);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(160, 22);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "DateFrom:";
            this.lblDateFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDateTo
            // 
            this.pnlDateTo.AutoSize = true;
            this.pnlDateTo.BackColor = System.Drawing.Color.Transparent;
            this.pnlDateTo.Controls.Add(this.txtDateTo);
            this.pnlDateTo.Controls.Add(this.lblDateTo);
            this.pnlDateTo.Location = new System.Drawing.Point(3, 183);
            this.pnlDateTo.Name = "pnlDateTo";
            this.pnlDateTo.Size = new System.Drawing.Size(335, 38);
            this.pnlDateTo.TabIndex = 0;
            this.pnlDateTo.Text = "DateTo";
            // 
            // txtDateTo
            // 
            this.txtDateTo.Font = new System.Drawing.Font("Shangrila Numeric", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTo.Location = new System.Drawing.Point(172, 10);
            this.txtDateTo.MaxLength = 15;
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(160, 25);
            this.txtDateTo.TabIndex = 0;
            // 
            // lblDateTo
            // 
            this.lblDateTo.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTo.Location = new System.Drawing.Point(10, 10);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(160, 22);
            this.lblDateTo.TabIndex = 0;
            this.lblDateTo.Text = "DateTo:";
            this.lblDateTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FiscalYears_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 510);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flwLayout);
            this.Controls.Add(this.btnOk);
            this.Name = "FiscalYears_Ent";
            this.Load += new System.EventHandler(this.FiscalYears_Ent_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.flwLayout, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.flwLayout.ResumeLayout(false);
            this.flwLayout.PerformLayout();
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.pnlFiscalYear.ResumeLayout(false);
            this.pnlFiscalYear.PerformLayout();
            this.pnlDateFrom.ResumeLayout(false);
            this.pnlDateFrom.PerformLayout();
            this.pnlDateTo.ResumeLayout(false);
            this.pnlDateTo.PerformLayout();
            this.ResumeLayout(false);

}//<Control>
 private System.Windows.Forms.Panel pnlId; 
 private System.Windows.Forms.Panel pnlFiscalYear; 
 private System.Windows.Forms.Panel pnlDateFrom; 
 private System.Windows.Forms.Panel pnlDateTo; 

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtFiscalYear; 
 private System.Windows.Forms.TextBox txtDateFrom; 
 private System.Windows.Forms.TextBox txtDateTo; 

 private System.Windows.Forms.Label  lblId; 
 private System.Windows.Forms.Label  lblFiscalYear; 
 private System.Windows.Forms.Label  lblDateFrom; 
 private System.Windows.Forms.Label  lblDateTo; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private Bsoft.Controls.LableFlowLayout flwLayout;
    }
}
