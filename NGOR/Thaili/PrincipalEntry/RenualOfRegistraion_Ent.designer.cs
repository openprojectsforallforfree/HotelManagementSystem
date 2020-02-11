namespace UEMS
{
    partial class RenualOfRegistraion_Ent
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
            CrudeFx.NepaliDate.NepaliDate nepaliDate2 = new CrudeFx.NepaliDate.NepaliDate();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenualOfRegistraion_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtfk_NGO = new System.Windows.Forms.TextBox();
            this.pnlFiscalyearId = new System.Windows.Forms.Panel();
            this.cmbFiscalyearId = new System.Windows.Forms.ComboBox();
            this.lblFiscalyearId = new System.Windows.Forms.Label();
            this.pnlD_RenalDate = new System.Windows.Forms.Panel();
            this.txtD_RenalDate = new CrudeFx.NepaliDate.NepaliDatePicker();
            this.lblD_RenalDate = new System.Windows.Forms.Label();
            this.pnlD_RenualTill = new System.Windows.Forms.Panel();
            this.txtD_RenualTill = new CrudeFx.NepaliDate.NepaliDatePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.grpRenewBy = new System.Windows.Forms.GroupBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.lstGrdContactPeson = new Bsoft.Controls.ListingGrid();
            this.btnContactPerson = new bsoftcontrols.fsButton();
            this.grpIncludedDocument = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFiscalyearId.SuspendLayout();
            this.pnlD_RenalDate.SuspendLayout();
            this.pnlD_RenualTill.SuspendLayout();
            this.grpRenewBy.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(550, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(300, 515);
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
            this.btnOk.Location = new System.Drawing.Point(206, 515);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(400, 12);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(31, 23);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // txtfk_NGO
            // 
            this.txtfk_NGO.Location = new System.Drawing.Point(437, 12);
            this.txtfk_NGO.MaxLength = 5;
            this.txtfk_NGO.Name = "txtfk_NGO";
            this.txtfk_NGO.Size = new System.Drawing.Size(31, 23);
            this.txtfk_NGO.TabIndex = 0;
            this.txtfk_NGO.Visible = false;
            // 
            // pnlFiscalyearId
            // 
            this.pnlFiscalyearId.AutoSize = true;
            this.pnlFiscalyearId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFiscalyearId.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiscalyearId.Controls.Add(this.cmbFiscalyearId);
            this.pnlFiscalyearId.Controls.Add(this.lblFiscalyearId);
            this.pnlFiscalyearId.Location = new System.Drawing.Point(82, 57);
            this.pnlFiscalyearId.Margin = new System.Windows.Forms.Padding(1);
            this.pnlFiscalyearId.Name = "pnlFiscalyearId";
            this.pnlFiscalyearId.Size = new System.Drawing.Size(335, 28);
            this.pnlFiscalyearId.TabIndex = 0;
            this.pnlFiscalyearId.Text = "FiscalyearId";
            // 
            // cmbFiscalyearId
            // 
            this.cmbFiscalyearId.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiscalyearId.FormattingEnabled = true;
            this.cmbFiscalyearId.Location = new System.Drawing.Point(172, 1);
            this.cmbFiscalyearId.Name = "cmbFiscalyearId";
            this.cmbFiscalyearId.Size = new System.Drawing.Size(160, 24);
            this.cmbFiscalyearId.TabIndex = 0;
            // 
            // lblFiscalyearId
            // 
            this.lblFiscalyearId.BackColor = System.Drawing.Color.Transparent;
            this.lblFiscalyearId.Location = new System.Drawing.Point(10, 1);
            this.lblFiscalyearId.Name = "lblFiscalyearId";
            this.lblFiscalyearId.Size = new System.Drawing.Size(160, 22);
            this.lblFiscalyearId.TabIndex = 0;
            this.lblFiscalyearId.Text = "आर्थिक बर्ष :";
            this.lblFiscalyearId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlD_RenalDate
            // 
            this.pnlD_RenalDate.AutoSize = true;
            this.pnlD_RenalDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlD_RenalDate.BackColor = System.Drawing.Color.Transparent;
            this.pnlD_RenalDate.Controls.Add(this.txtD_RenalDate);
            this.pnlD_RenalDate.Controls.Add(this.lblD_RenalDate);
            this.pnlD_RenalDate.Location = new System.Drawing.Point(82, 87);
            this.pnlD_RenalDate.Margin = new System.Windows.Forms.Padding(1);
            this.pnlD_RenalDate.Name = "pnlD_RenalDate";
            this.pnlD_RenalDate.Size = new System.Drawing.Size(266, 25);
            this.pnlD_RenalDate.TabIndex = 1;
            this.pnlD_RenalDate.Text = "D_RenalDate";
            // 
            // txtD_RenalDate
            // 
            this.txtD_RenalDate.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_RenalDate.Location = new System.Drawing.Point(172, 1);
            this.txtD_RenalDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtD_RenalDate.Name = "txtD_RenalDate";
            this.txtD_RenalDate.Size = new System.Drawing.Size(91, 20);
            this.txtD_RenalDate.TabIndex = 0;
            nepaliDate1.Day = 12;
            nepaliDate1.Month = 11;
            nepaliDate1.Year = 2065;
            this.txtD_RenalDate.Value = nepaliDate1;
            // 
            // lblD_RenalDate
            // 
            this.lblD_RenalDate.BackColor = System.Drawing.Color.Transparent;
            this.lblD_RenalDate.Location = new System.Drawing.Point(10, 1);
            this.lblD_RenalDate.Name = "lblD_RenalDate";
            this.lblD_RenalDate.Size = new System.Drawing.Size(160, 22);
            this.lblD_RenalDate.TabIndex = 0;
            this.lblD_RenalDate.Text = "नविकरण मिति :";
            this.lblD_RenalDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlD_RenualTill
            // 
            this.pnlD_RenualTill.AutoSize = true;
            this.pnlD_RenualTill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlD_RenualTill.BackColor = System.Drawing.Color.Transparent;
            this.pnlD_RenualTill.Controls.Add(this.txtD_RenualTill);
            this.pnlD_RenualTill.Controls.Add(this.label20);
            this.pnlD_RenualTill.Controls.Add(this.label22);
            this.pnlD_RenualTill.Location = new System.Drawing.Point(60, 7);
            this.pnlD_RenualTill.Margin = new System.Windows.Forms.Padding(1);
            this.pnlD_RenualTill.Name = "pnlD_RenualTill";
            this.pnlD_RenualTill.Size = new System.Drawing.Size(266, 28);
            this.pnlD_RenualTill.TabIndex = 0;
            this.pnlD_RenualTill.Text = "D_RenualTill";
            this.pnlD_RenualTill.Visible = false;
            // 
            // txtD_RenualTill
            // 
            this.txtD_RenualTill.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_RenualTill.Location = new System.Drawing.Point(172, 4);
            this.txtD_RenualTill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtD_RenualTill.Name = "txtD_RenualTill";
            this.txtD_RenualTill.Size = new System.Drawing.Size(91, 20);
            this.txtD_RenualTill.TabIndex = 0;
            nepaliDate2.Day = 12;
            nepaliDate2.Month = 11;
            nepaliDate2.Year = 2065;
            this.txtD_RenualTill.Value = nepaliDate2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Mangal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(14, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 23);
            this.label20.TabIndex = 35;
            this.label20.Text = "देखि";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Mangal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(90, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 23);
            this.label22.TabIndex = 36;
            this.label22.Text = "सम्म";
            // 
            // grpRenewBy
            // 
            this.grpRenewBy.BackColor = System.Drawing.Color.Transparent;
            this.grpRenewBy.Controls.Add(this.txtContactPerson);
            this.grpRenewBy.Controls.Add(this.lstGrdContactPeson);
            this.grpRenewBy.Controls.Add(this.btnContactPerson);
            this.grpRenewBy.Location = new System.Drawing.Point(3, 3);
            this.grpRenewBy.Name = "grpRenewBy";
            this.grpRenewBy.Size = new System.Drawing.Size(263, 161);
            this.grpRenewBy.TabIndex = 1;
            this.grpRenewBy.TabStop = false;
            this.grpRenewBy.Text = "निबेदक ";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(13, 24);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(100, 23);
            this.txtContactPerson.TabIndex = 9;
            this.txtContactPerson.Visible = false;
            // 
            // lstGrdContactPeson
            // 
            this.lstGrdContactPeson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstGrdContactPeson.Location = new System.Drawing.Point(6, 60);
            this.lstGrdContactPeson.Name = "lstGrdContactPeson";
            this.lstGrdContactPeson.Size = new System.Drawing.Size(248, 95);
            this.lstGrdContactPeson.TabIndex = 1;
            // 
            // btnContactPerson
            // 
            this.btnContactPerson.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnContactPerson.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnContactPerson.FlatAppearance.BorderSize = 0;
            this.btnContactPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactPerson.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactPerson.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnContactPerson.Location = new System.Drawing.Point(116, 23);
            this.btnContactPerson.Margin = new System.Windows.Forms.Padding(0);
            this.btnContactPerson.Name = "btnContactPerson";
            this.btnContactPerson.Size = new System.Drawing.Size(126, 29);
            this.btnContactPerson.TabIndex = 8;
            this.btnContactPerson.Text = "खोजेर ल्याउनुहोस् ";
            this.btnContactPerson.Click += new System.EventHandler(this.btnContactPerson_Click);
            // 
            // grpIncludedDocument
            // 
            this.grpIncludedDocument.BackColor = System.Drawing.Color.Transparent;
            this.grpIncludedDocument.Location = new System.Drawing.Point(3, 170);
            this.grpIncludedDocument.Name = "grpIncludedDocument";
            this.grpIncludedDocument.Size = new System.Drawing.Size(476, 220);
            this.grpIncludedDocument.TabIndex = 0;
            this.grpIncludedDocument.TabStop = false;
            this.grpIncludedDocument.Text = "संलग्न विवरण ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.grpRenewBy);
            this.flowLayoutPanel1.Controls.Add(this.grpIncludedDocument);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(77, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(482, 393);
            this.flowLayoutPanel1.TabIndex = 38;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // RenualOfRegistraion_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 553);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtfk_NGO);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlFiscalyearId);
            this.Controls.Add(this.pnlD_RenalDate);
            this.Controls.Add(this.pnlD_RenualTill);
            this.Name = "RenualOfRegistraion_Ent";
            this.Load += new System.EventHandler(this.RenualOfRegistraion_Ent_Load);
            this.Shown += new System.EventHandler(this.RenualOfRegistraion_Ent_Shown);
            this.Controls.SetChildIndex(this.pnlD_RenualTill, 0);
            this.Controls.SetChildIndex(this.pnlD_RenalDate, 0);
            this.Controls.SetChildIndex(this.pnlFiscalyearId, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtfk_NGO, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.pnlFiscalyearId.ResumeLayout(false);
            this.pnlD_RenalDate.ResumeLayout(false);
            this.pnlD_RenualTill.ResumeLayout(false);
            this.pnlD_RenualTill.PerformLayout();
            this.grpRenewBy.ResumeLayout(false);
            this.grpRenewBy.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }//<Control>  
 private System.Windows.Forms.Panel pnlFiscalyearId; 
 private System.Windows.Forms.Panel pnlD_RenalDate;
 private System.Windows.Forms.Panel pnlD_RenualTill; 

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtfk_NGO; 
 private System.Windows.Forms.ComboBox cmbFiscalyearId; 
 CrudeFx.NepaliDate.NepaliDatePicker txtD_RenalDate;
 CrudeFx.NepaliDate.NepaliDatePicker txtD_RenualTill; 
 private System.Windows.Forms.Label  lblFiscalyearId;
 private System.Windows.Forms.Label lblD_RenalDate; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.GroupBox grpRenewBy;
        private System.Windows.Forms.TextBox txtContactPerson;
        private Bsoft.Controls.ListingGrid lstGrdContactPeson;
        private bsoftcontrols.fsButton btnContactPerson;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox grpIncludedDocument;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
