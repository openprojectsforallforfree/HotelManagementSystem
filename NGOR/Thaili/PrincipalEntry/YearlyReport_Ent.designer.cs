namespace UEMS
{
    partial class YearlyReport_Ent
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
            CrudeFx.NepaliDate.NepaliDate nepaliDate1 = new CrudeFx.NepaliDate.NepaliDate();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YearlyReport_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtfk_NGO = new System.Windows.Forms.TextBox();
            this.pnlFiscalYearId = new System.Windows.Forms.Panel();
            this.cmbFiscalYearId = new System.Windows.Forms.ComboBox();
            this.lblFiscalYearId = new System.Windows.Forms.Label();
            this.pnlAuthorisedAmount = new System.Windows.Forms.Panel();
            this.lblAuthorisedAmount = new System.Windows.Forms.Label();
            this.txtAuthorisedAmount = new Bsoft.Controls.VtextBox();
            this.pnlRecievedAmount = new System.Windows.Forms.Panel();
            this.txtRecievedAmount = new Bsoft.Controls.VtextBox();
            this.lblRecievedAmount = new System.Windows.Forms.Label();
            this.pnlSpentAmount = new System.Windows.Forms.Panel();
            this.lblSpentAmount = new System.Windows.Forms.Label();
            this.txtSpentAmount = new Bsoft.Controls.VtextBox();
            this.grpWorkDone = new System.Windows.Forms.GroupBox();
            this.pnlSignedBy = new System.Windows.Forms.Panel();
            this.txtSignedBy = new System.Windows.Forms.TextBox();
            this.lblSignedBy = new System.Windows.Forms.Label();
            this.pnlD_Date = new System.Windows.Forms.Panel();
            this.txtD_Date = new CrudeFx.NepaliDate.NepaliDatePicker();
            this.lblD_Date = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFiscalYearId.SuspendLayout();
            this.pnlAuthorisedAmount.SuspendLayout();
            this.pnlRecievedAmount.SuspendLayout();
            this.pnlSpentAmount.SuspendLayout();
            this.pnlSignedBy.SuspendLayout();
            this.pnlD_Date.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(433, 512);
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
            this.btnOk.Location = new System.Drawing.Point(339, 512);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(433, 4);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(78, 23);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // txtfk_NGO
            // 
            this.txtfk_NGO.Location = new System.Drawing.Point(368, 4);
            this.txtfk_NGO.MaxLength = 5;
            this.txtfk_NGO.Name = "txtfk_NGO";
            this.txtfk_NGO.Size = new System.Drawing.Size(64, 23);
            this.txtfk_NGO.TabIndex = 0;
            this.txtfk_NGO.Visible = false;
            // 
            // pnlFiscalYearId
            // 
            this.pnlFiscalYearId.AutoSize = true;
            this.pnlFiscalYearId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFiscalYearId.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiscalYearId.Controls.Add(this.cmbFiscalYearId);
            this.pnlFiscalYearId.Controls.Add(this.lblFiscalYearId);
            this.pnlFiscalYearId.Location = new System.Drawing.Point(42, 51);
            this.pnlFiscalYearId.Margin = new System.Windows.Forms.Padding(1);
            this.pnlFiscalYearId.Name = "pnlFiscalYearId";
            this.pnlFiscalYearId.Size = new System.Drawing.Size(335, 31);
            this.pnlFiscalYearId.TabIndex = 0;
            this.pnlFiscalYearId.Text = "आर्थिक बर्ष";
            // 
            // cmbFiscalYearId
            // 
            this.cmbFiscalYearId.Font = new System.Drawing.Font("Shangrila Numeric", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiscalYearId.FormattingEnabled = true;
            this.cmbFiscalYearId.Location = new System.Drawing.Point(172, 1);
            this.cmbFiscalYearId.Name = "cmbFiscalYearId";
            this.cmbFiscalYearId.Size = new System.Drawing.Size(160, 27);
            this.cmbFiscalYearId.TabIndex = 0;
            // 
            // lblFiscalYearId
            // 
            this.lblFiscalYearId.BackColor = System.Drawing.Color.Transparent;
            this.lblFiscalYearId.Location = new System.Drawing.Point(10, 1);
            this.lblFiscalYearId.Name = "lblFiscalYearId";
            this.lblFiscalYearId.Size = new System.Drawing.Size(160, 22);
            this.lblFiscalYearId.TabIndex = 0;
            this.lblFiscalYearId.Text = "आर्थिक बर्ष:";
            this.lblFiscalYearId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlAuthorisedAmount
            // 
            this.pnlAuthorisedAmount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAuthorisedAmount.BackColor = System.Drawing.Color.Transparent;
            this.pnlAuthorisedAmount.Controls.Add(this.lblAuthorisedAmount);
            this.pnlAuthorisedAmount.Controls.Add(this.txtAuthorisedAmount);
            this.pnlAuthorisedAmount.Location = new System.Drawing.Point(42, 86);
            this.pnlAuthorisedAmount.Margin = new System.Windows.Forms.Padding(1);
            this.pnlAuthorisedAmount.Name = "pnlAuthorisedAmount";
            this.pnlAuthorisedAmount.Size = new System.Drawing.Size(408, 34);
            this.pnlAuthorisedAmount.TabIndex = 1;
            this.pnlAuthorisedAmount.Text = "समाजकल्याणबाट स्वीकृत प्रस्तावना रकम रु ";
            // 
            // lblAuthorisedAmount
            // 
            this.lblAuthorisedAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthorisedAmount.Location = new System.Drawing.Point(10, 1);
            this.lblAuthorisedAmount.Name = "lblAuthorisedAmount";
            this.lblAuthorisedAmount.Size = new System.Drawing.Size(160, 22);
            this.lblAuthorisedAmount.TabIndex = 0;
            this.lblAuthorisedAmount.Text = "समाजकल्याणबाट स्वीकृत प्रस्तावना रकम रु :";
            this.lblAuthorisedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAuthorisedAmount
            // 
            this.txtAuthorisedAmount.Font = new System.Drawing.Font("Shangrila Numeric", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorisedAmount.Location = new System.Drawing.Point(172, 1);
            this.txtAuthorisedAmount.MaxLength = 20;
            this.txtAuthorisedAmount.Name = "txtAuthorisedAmount";
            this.txtAuthorisedAmount.Size = new System.Drawing.Size(160, 27);
            this.txtAuthorisedAmount.TabIndex = 10;
            this.txtAuthorisedAmount.Text = "0.00";
            this.txtAuthorisedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAuthorisedAmount.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.MoneyNepali;
            this.txtAuthorisedAmount.Value = "0.00";
            // 
            // pnlRecievedAmount
            // 
            this.pnlRecievedAmount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRecievedAmount.BackColor = System.Drawing.Color.Transparent;
            this.pnlRecievedAmount.Controls.Add(this.txtRecievedAmount);
            this.pnlRecievedAmount.Controls.Add(this.lblRecievedAmount);
            this.pnlRecievedAmount.Location = new System.Drawing.Point(42, 120);
            this.pnlRecievedAmount.Margin = new System.Windows.Forms.Padding(1);
            this.pnlRecievedAmount.Name = "pnlRecievedAmount";
            this.pnlRecievedAmount.Size = new System.Drawing.Size(408, 34);
            this.pnlRecievedAmount.TabIndex = 2;
            this.pnlRecievedAmount.Text = "हालसम्म प्राप्त रकम रु";
            // 
            // txtRecievedAmount
            // 
            this.txtRecievedAmount.Font = new System.Drawing.Font("Shangrila Numeric", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecievedAmount.Location = new System.Drawing.Point(172, 2);
            this.txtRecievedAmount.MaxLength = 20;
            this.txtRecievedAmount.Name = "txtRecievedAmount";
            this.txtRecievedAmount.Size = new System.Drawing.Size(160, 27);
            this.txtRecievedAmount.TabIndex = 10;
            this.txtRecievedAmount.Text = "0.00";
            this.txtRecievedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecievedAmount.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.MoneyNepali;
            this.txtRecievedAmount.Value = "0.00";
            // 
            // lblRecievedAmount
            // 
            this.lblRecievedAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblRecievedAmount.Location = new System.Drawing.Point(10, 1);
            this.lblRecievedAmount.Name = "lblRecievedAmount";
            this.lblRecievedAmount.Size = new System.Drawing.Size(160, 22);
            this.lblRecievedAmount.TabIndex = 0;
            this.lblRecievedAmount.Text = "हालसम्म प्राप्त रकम रु:";
            this.lblRecievedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlSpentAmount
            // 
            this.pnlSpentAmount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSpentAmount.BackColor = System.Drawing.Color.Transparent;
            this.pnlSpentAmount.Controls.Add(this.lblSpentAmount);
            this.pnlSpentAmount.Controls.Add(this.txtSpentAmount);
            this.pnlSpentAmount.Location = new System.Drawing.Point(42, 154);
            this.pnlSpentAmount.Margin = new System.Windows.Forms.Padding(1);
            this.pnlSpentAmount.Name = "pnlSpentAmount";
            this.pnlSpentAmount.Size = new System.Drawing.Size(408, 34);
            this.pnlSpentAmount.TabIndex = 3;
            this.pnlSpentAmount.Text = "खर्च भएको रकम रु ";
            // 
            // lblSpentAmount
            // 
            this.lblSpentAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblSpentAmount.Location = new System.Drawing.Point(10, 1);
            this.lblSpentAmount.Name = "lblSpentAmount";
            this.lblSpentAmount.Size = new System.Drawing.Size(160, 22);
            this.lblSpentAmount.TabIndex = 0;
            this.lblSpentAmount.Text = "खर्च भएको रकम रु :";
            this.lblSpentAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSpentAmount
            // 
            this.txtSpentAmount.Font = new System.Drawing.Font("Shangrila Numeric", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpentAmount.Location = new System.Drawing.Point(172, 2);
            this.txtSpentAmount.MaxLength = 20;
            this.txtSpentAmount.Name = "txtSpentAmount";
            this.txtSpentAmount.Size = new System.Drawing.Size(160, 27);
            this.txtSpentAmount.TabIndex = 10;
            this.txtSpentAmount.Text = "0.00";
            this.txtSpentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSpentAmount.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.MoneyNepali;
            this.txtSpentAmount.Value = "0.00";
            // 
            // grpWorkDone
            // 
            this.grpWorkDone.BackColor = System.Drawing.Color.Transparent;
            this.grpWorkDone.Location = new System.Drawing.Point(3, 3);
            this.grpWorkDone.Name = "grpWorkDone";
            this.grpWorkDone.Size = new System.Drawing.Size(794, 241);
            this.grpWorkDone.TabIndex = 0;
            this.grpWorkDone.TabStop = false;
            this.grpWorkDone.Text = "सम्पन्न कार्यक्रमहरु";
            // 
            // pnlSignedBy
            // 
            this.pnlSignedBy.AutoSize = true;
            this.pnlSignedBy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSignedBy.BackColor = System.Drawing.Color.Transparent;
            this.pnlSignedBy.Controls.Add(this.txtSignedBy);
            this.pnlSignedBy.Controls.Add(this.lblSignedBy);
            this.pnlSignedBy.Location = new System.Drawing.Point(45, 440);
            this.pnlSignedBy.Margin = new System.Windows.Forms.Padding(1);
            this.pnlSignedBy.Name = "pnlSignedBy";
            this.pnlSignedBy.Size = new System.Drawing.Size(335, 27);
            this.pnlSignedBy.TabIndex = 4;
            this.pnlSignedBy.Text = "अध्यक्ष";
            this.pnlSignedBy.Visible = false;
            // 
            // txtSignedBy
            // 
            this.txtSignedBy.Location = new System.Drawing.Point(172, 1);
            this.txtSignedBy.Name = "txtSignedBy";
            this.txtSignedBy.Size = new System.Drawing.Size(160, 23);
            this.txtSignedBy.TabIndex = 0;
            // 
            // lblSignedBy
            // 
            this.lblSignedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblSignedBy.Location = new System.Drawing.Point(10, 1);
            this.lblSignedBy.Name = "lblSignedBy";
            this.lblSignedBy.Size = new System.Drawing.Size(160, 22);
            this.lblSignedBy.TabIndex = 0;
            this.lblSignedBy.Text = "अध्यक्ष:";
            this.lblSignedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlD_Date
            // 
            this.pnlD_Date.AutoSize = true;
            this.pnlD_Date.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlD_Date.BackColor = System.Drawing.Color.Transparent;
            this.pnlD_Date.Controls.Add(this.txtD_Date);
            this.pnlD_Date.Controls.Add(this.lblD_Date);
            this.pnlD_Date.Location = new System.Drawing.Point(45, 480);
            this.pnlD_Date.Margin = new System.Windows.Forms.Padding(1);
            this.pnlD_Date.Name = "pnlD_Date";
            this.pnlD_Date.Size = new System.Drawing.Size(292, 25);
            this.pnlD_Date.TabIndex = 5;
            this.pnlD_Date.Text = "मिति ";
            // 
            // txtD_Date
            // 
            this.txtD_Date.Font = new System.Drawing.Font("Shangrila Numeric", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_Date.Location = new System.Drawing.Point(172, 1);
            this.txtD_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtD_Date.Name = "txtD_Date";
            this.txtD_Date.Size = new System.Drawing.Size(117, 20);
            this.txtD_Date.TabIndex = 0;
            nepaliDate1.Day = 12;
            nepaliDate1.Month = 11;
            nepaliDate1.Year = 2065;
            this.txtD_Date.Value = nepaliDate1;
            // 
            // lblD_Date
            // 
            this.lblD_Date.BackColor = System.Drawing.Color.Transparent;
            this.lblD_Date.Location = new System.Drawing.Point(10, 1);
            this.lblD_Date.Name = "lblD_Date";
            this.lblD_Date.Size = new System.Drawing.Size(160, 22);
            this.lblD_Date.TabIndex = 0;
            this.lblD_Date.Text = "मिति :";
            this.lblD_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.grpWorkDone);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 192);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(797, 246);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // YearlyReport_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 550);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtfk_NGO);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlFiscalYearId);
            this.Controls.Add(this.pnlD_Date);
            this.Controls.Add(this.pnlAuthorisedAmount);
            this.Controls.Add(this.pnlRecievedAmount);
            this.Controls.Add(this.pnlSignedBy);
            this.Controls.Add(this.pnlSpentAmount);
            this.Name = "YearlyReport_Ent";
            this.Text = "बार्षिक प्रगति प्रतिवेदन ";
            this.Load += new System.EventHandler(this.YearlyReport_Ent_Load);
            this.Shown += new System.EventHandler(this.YearlyReport_Ent_Shown);
            this.Controls.SetChildIndex(this.pnlSpentAmount, 0);
            this.Controls.SetChildIndex(this.pnlSignedBy, 0);
            this.Controls.SetChildIndex(this.pnlRecievedAmount, 0);
            this.Controls.SetChildIndex(this.pnlAuthorisedAmount, 0);
            this.Controls.SetChildIndex(this.pnlD_Date, 0);
            this.Controls.SetChildIndex(this.pnlFiscalYearId, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtfk_NGO, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.pnlFiscalYearId.ResumeLayout(false);
            this.pnlAuthorisedAmount.ResumeLayout(false);
            this.pnlAuthorisedAmount.PerformLayout();
            this.pnlRecievedAmount.ResumeLayout(false);
            this.pnlRecievedAmount.PerformLayout();
            this.pnlSpentAmount.ResumeLayout(false);
            this.pnlSpentAmount.PerformLayout();
            this.pnlSignedBy.ResumeLayout(false);
            this.pnlSignedBy.PerformLayout();
            this.pnlD_Date.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }//<Control>  
 private System.Windows.Forms.Panel pnlFiscalYearId; 
 private System.Windows.Forms.Panel pnlAuthorisedAmount; 
 private System.Windows.Forms.Panel pnlRecievedAmount;
 private System.Windows.Forms.Panel pnlSpentAmount; 
 private System.Windows.Forms.Panel pnlSignedBy; 
 private System.Windows.Forms.Panel pnlD_Date; 

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtfk_NGO;
 private System.Windows.Forms.ComboBox cmbFiscalYearId; 
 private System.Windows.Forms.GroupBox grpWorkDone; 
 private System.Windows.Forms.TextBox txtSignedBy;
 CrudeFx.NepaliDate.NepaliDatePicker txtD_Date; 
 private System.Windows.Forms.Label  lblFiscalYearId; 
 private System.Windows.Forms.Label  lblAuthorisedAmount; 
 private System.Windows.Forms.Label  lblRecievedAmount; 
 private System.Windows.Forms.Label  lblSpentAmount; 
 private System.Windows.Forms.Label  lblSignedBy; 
 private System.Windows.Forms.Label  lblD_Date; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private Bsoft.Controls.VtextBox txtRecievedAmount;
        private Bsoft.Controls.VtextBox txtSpentAmount;
        private Bsoft.Controls.VtextBox txtAuthorisedAmount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
