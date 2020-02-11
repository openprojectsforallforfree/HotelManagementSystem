namespace UEMS
{
    partial class NGO_AffiliationOrganization_Ent
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
            CrudeFx.NepaliDate.NepaliDate nepaliDate3 = new CrudeFx.NepaliDate.NepaliDate();
            CrudeFx.NepaliDate.NepaliDate nepaliDate4 = new CrudeFx.NepaliDate.NepaliDate();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NGO_AffiliationOrganization_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.pnlId = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtfk_NGO = new System.Windows.Forms.TextBox();
            this.pnlfk_AffiliationOrganization = new System.Windows.Forms.Panel();
            this.cmbfk_AffiliationOrganization = new System.Windows.Forms.ComboBox();
            this.lblfk_AffiliationOrganization = new System.Windows.Forms.Label();
            this.pnlRegistrationDate = new System.Windows.Forms.Panel();
            this.txtRegistrationDate = new CrudeFx.NepaliDate.NepaliDatePicker();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.pnlAffiliationDate = new System.Windows.Forms.Panel();
            this.txtAffiliationDate = new CrudeFx.NepaliDate.NepaliDatePicker();
            this.lblAffiliationDate = new System.Windows.Forms.Label();
            this.pnlRedgeNo = new System.Windows.Forms.Panel();
            this.txtRedgeNo = new System.Windows.Forms.TextBox();
            this.lblRedgeNo = new System.Windows.Forms.Label();
            this.pnlLastRenualDate = new System.Windows.Forms.Panel();
            this.txtLastRenualDate = new CrudeFx.NepaliDate.NepaliDatePicker();
            this.lblLastRenualDate = new System.Windows.Forms.Label();
            this.pnlRenualDuration = new System.Windows.Forms.Panel();
            this.txtRenualDuration = new CrudeFx.NepaliDate.NepaliDatePicker();
            this.lblRenualDuration = new System.Windows.Forms.Label();
            this.pnlfk_AffiliationOrganization.SuspendLayout();
            this.pnlRegistrationDate.SuspendLayout();
            this.pnlAffiliationDate.SuspendLayout();
            this.pnlRedgeNo.SuspendLayout();
            this.pnlLastRenualDate.SuspendLayout();
            this.pnlRenualDuration.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(453, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(251, 250);
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
            this.btnOk.Location = new System.Drawing.Point(157, 250);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pnlId
            // 
            this.pnlId.AutoSize = true;
            this.pnlId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlId.BackColor = System.Drawing.Color.Transparent;
            this.pnlId.Location = new System.Drawing.Point(384, 10);
            this.pnlId.Margin = new System.Windows.Forms.Padding(1);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(0, 0);
            this.pnlId.TabIndex = 0;
            this.pnlId.Text = "Id";
            this.pnlId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(352, 5);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 23);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // txtfk_NGO
            // 
            this.txtfk_NGO.Location = new System.Drawing.Point(301, 4);
            this.txtfk_NGO.MaxLength = 5;
            this.txtfk_NGO.Name = "txtfk_NGO";
            this.txtfk_NGO.Size = new System.Drawing.Size(45, 23);
            this.txtfk_NGO.TabIndex = 0;
            this.txtfk_NGO.Visible = false;
            // 
            // pnlfk_AffiliationOrganization
            // 
            this.pnlfk_AffiliationOrganization.AutoSize = true;
            this.pnlfk_AffiliationOrganization.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlfk_AffiliationOrganization.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_AffiliationOrganization.Controls.Add(this.cmbfk_AffiliationOrganization);
            this.pnlfk_AffiliationOrganization.Controls.Add(this.lblfk_AffiliationOrganization);
            this.pnlfk_AffiliationOrganization.Location = new System.Drawing.Point(49, 90);
            this.pnlfk_AffiliationOrganization.Margin = new System.Windows.Forms.Padding(1);
            this.pnlfk_AffiliationOrganization.Name = "pnlfk_AffiliationOrganization";
            this.pnlfk_AffiliationOrganization.Size = new System.Drawing.Size(429, 28);
            this.pnlfk_AffiliationOrganization.TabIndex = 1;
            this.pnlfk_AffiliationOrganization.Text = "आवद्धता";
            // 
            // cmbfk_AffiliationOrganization
            // 
            this.cmbfk_AffiliationOrganization.FormattingEnabled = true;
            this.cmbfk_AffiliationOrganization.Location = new System.Drawing.Point(172, 1);
            this.cmbfk_AffiliationOrganization.Name = "cmbfk_AffiliationOrganization";
            this.cmbfk_AffiliationOrganization.Size = new System.Drawing.Size(254, 24);
            this.cmbfk_AffiliationOrganization.TabIndex = 0;
            // 
            // lblfk_AffiliationOrganization
            // 
            this.lblfk_AffiliationOrganization.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_AffiliationOrganization.Location = new System.Drawing.Point(10, 1);
            this.lblfk_AffiliationOrganization.Name = "lblfk_AffiliationOrganization";
            this.lblfk_AffiliationOrganization.Size = new System.Drawing.Size(160, 22);
            this.lblfk_AffiliationOrganization.TabIndex = 0;
            this.lblfk_AffiliationOrganization.Text = "आवद्धता:";
            this.lblfk_AffiliationOrganization.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlRegistrationDate
            // 
            this.pnlRegistrationDate.AutoSize = true;
            this.pnlRegistrationDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRegistrationDate.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegistrationDate.Controls.Add(this.txtRegistrationDate);
            this.pnlRegistrationDate.Controls.Add(this.lblRegistrationDate);
            this.pnlRegistrationDate.Location = new System.Drawing.Point(49, 125);
            this.pnlRegistrationDate.Margin = new System.Windows.Forms.Padding(1);
            this.pnlRegistrationDate.Name = "pnlRegistrationDate";
            this.pnlRegistrationDate.Size = new System.Drawing.Size(288, 28);
            this.pnlRegistrationDate.TabIndex = 2;
            this.pnlRegistrationDate.Text = "दर्ता मिति";
            // 
            // txtRegistrationDate
            // 
            this.txtRegistrationDate.Font = new System.Drawing.Font("Shangrila Numeric", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrationDate.Location = new System.Drawing.Point(172, 1);
            this.txtRegistrationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRegistrationDate.Name = "txtRegistrationDate";
            this.txtRegistrationDate.Size = new System.Drawing.Size(113, 23);
            this.txtRegistrationDate.TabIndex = 0;
            nepaliDate1.Day = 12;
            nepaliDate1.Month = 11;
            nepaliDate1.Year = 2065;
            this.txtRegistrationDate.Value = nepaliDate1;
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrationDate.Location = new System.Drawing.Point(10, 1);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(160, 22);
            this.lblRegistrationDate.TabIndex = 0;
            this.lblRegistrationDate.Text = "दर्ता मिति:";
            this.lblRegistrationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlAffiliationDate
            // 
            this.pnlAffiliationDate.AutoSize = true;
            this.pnlAffiliationDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAffiliationDate.BackColor = System.Drawing.Color.Transparent;
            this.pnlAffiliationDate.Controls.Add(this.txtAffiliationDate);
            this.pnlAffiliationDate.Controls.Add(this.lblAffiliationDate);
            this.pnlAffiliationDate.Location = new System.Drawing.Point(49, 152);
            this.pnlAffiliationDate.Margin = new System.Windows.Forms.Padding(1);
            this.pnlAffiliationDate.Name = "pnlAffiliationDate";
            this.pnlAffiliationDate.Size = new System.Drawing.Size(288, 28);
            this.pnlAffiliationDate.TabIndex = 3;
            this.pnlAffiliationDate.Text = "आवद्धता मिति";
            // 
            // txtAffiliationDate
            // 
            this.txtAffiliationDate.Font = new System.Drawing.Font("Shangrila Numeric", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAffiliationDate.Location = new System.Drawing.Point(172, 1);
            this.txtAffiliationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAffiliationDate.Name = "txtAffiliationDate";
            this.txtAffiliationDate.Size = new System.Drawing.Size(113, 23);
            this.txtAffiliationDate.TabIndex = 0;
            nepaliDate2.Day = 12;
            nepaliDate2.Month = 11;
            nepaliDate2.Year = 2065;
            this.txtAffiliationDate.Value = nepaliDate2;
            // 
            // lblAffiliationDate
            // 
            this.lblAffiliationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblAffiliationDate.Location = new System.Drawing.Point(10, 1);
            this.lblAffiliationDate.Name = "lblAffiliationDate";
            this.lblAffiliationDate.Size = new System.Drawing.Size(160, 22);
            this.lblAffiliationDate.TabIndex = 0;
            this.lblAffiliationDate.Text = "आवद्धता मिति:";
            this.lblAffiliationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlRedgeNo
            // 
            this.pnlRedgeNo.AutoSize = true;
            this.pnlRedgeNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRedgeNo.BackColor = System.Drawing.Color.Transparent;
            this.pnlRedgeNo.Controls.Add(this.txtRedgeNo);
            this.pnlRedgeNo.Controls.Add(this.lblRedgeNo);
            this.pnlRedgeNo.Location = new System.Drawing.Point(49, 53);
            this.pnlRedgeNo.Margin = new System.Windows.Forms.Padding(1);
            this.pnlRedgeNo.Name = "pnlRedgeNo";
            this.pnlRedgeNo.Size = new System.Drawing.Size(335, 28);
            this.pnlRedgeNo.TabIndex = 0;
            this.pnlRedgeNo.Text = "दर्ता नम्बर ";
            // 
            // txtRedgeNo
            // 
            this.txtRedgeNo.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRedgeNo.Location = new System.Drawing.Point(172, 1);
            this.txtRedgeNo.MaxLength = 15;
            this.txtRedgeNo.Name = "txtRedgeNo";
            this.txtRedgeNo.Size = new System.Drawing.Size(160, 24);
            this.txtRedgeNo.TabIndex = 0;
            // 
            // lblRedgeNo
            // 
            this.lblRedgeNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRedgeNo.Location = new System.Drawing.Point(10, 1);
            this.lblRedgeNo.Name = "lblRedgeNo";
            this.lblRedgeNo.Size = new System.Drawing.Size(160, 22);
            this.lblRedgeNo.TabIndex = 0;
            this.lblRedgeNo.Text = "दर्ता नम्बर :";
            this.lblRedgeNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLastRenualDate
            // 
            this.pnlLastRenualDate.AutoSize = true;
            this.pnlLastRenualDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLastRenualDate.BackColor = System.Drawing.Color.Transparent;
            this.pnlLastRenualDate.Controls.Add(this.txtLastRenualDate);
            this.pnlLastRenualDate.Controls.Add(this.lblLastRenualDate);
            this.pnlLastRenualDate.Location = new System.Drawing.Point(49, 179);
            this.pnlLastRenualDate.Margin = new System.Windows.Forms.Padding(1);
            this.pnlLastRenualDate.Name = "pnlLastRenualDate";
            this.pnlLastRenualDate.Size = new System.Drawing.Size(288, 28);
            this.pnlLastRenualDate.TabIndex = 4;
            this.pnlLastRenualDate.Text = "अन्तिम नविकरण मिति";
            // 
            // txtLastRenualDate
            // 
            this.txtLastRenualDate.Font = new System.Drawing.Font("Shangrila Numeric", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastRenualDate.Location = new System.Drawing.Point(172, 1);
            this.txtLastRenualDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastRenualDate.Name = "txtLastRenualDate";
            this.txtLastRenualDate.Size = new System.Drawing.Size(113, 23);
            this.txtLastRenualDate.TabIndex = 0;
            nepaliDate3.Day = 12;
            nepaliDate3.Month = 11;
            nepaliDate3.Year = 2065;
            this.txtLastRenualDate.Value = nepaliDate3;
            // 
            // lblLastRenualDate
            // 
            this.lblLastRenualDate.BackColor = System.Drawing.Color.Transparent;
            this.lblLastRenualDate.Location = new System.Drawing.Point(10, 1);
            this.lblLastRenualDate.Name = "lblLastRenualDate";
            this.lblLastRenualDate.Size = new System.Drawing.Size(160, 22);
            this.lblLastRenualDate.TabIndex = 0;
            this.lblLastRenualDate.Text = "अन्तिम नविकरण मिति:";
            this.lblLastRenualDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlRenualDuration
            // 
            this.pnlRenualDuration.AutoSize = true;
            this.pnlRenualDuration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRenualDuration.BackColor = System.Drawing.Color.Transparent;
            this.pnlRenualDuration.Controls.Add(this.txtRenualDuration);
            this.pnlRenualDuration.Controls.Add(this.lblRenualDuration);
            this.pnlRenualDuration.Location = new System.Drawing.Point(49, 206);
            this.pnlRenualDuration.Margin = new System.Windows.Forms.Padding(1);
            this.pnlRenualDuration.Name = "pnlRenualDuration";
            this.pnlRenualDuration.Size = new System.Drawing.Size(288, 28);
            this.pnlRenualDuration.TabIndex = 5;
            this.pnlRenualDuration.Text = "नविकरण अवधि";
            // 
            // txtRenualDuration
            // 
            this.txtRenualDuration.Font = new System.Drawing.Font("Shangrila Numeric", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenualDuration.Location = new System.Drawing.Point(172, 1);
            this.txtRenualDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRenualDuration.Name = "txtRenualDuration";
            this.txtRenualDuration.Size = new System.Drawing.Size(113, 23);
            this.txtRenualDuration.TabIndex = 0;
            nepaliDate4.Day = 12;
            nepaliDate4.Month = 11;
            nepaliDate4.Year = 2065;
            this.txtRenualDuration.Value = nepaliDate4;
            // 
            // lblRenualDuration
            // 
            this.lblRenualDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblRenualDuration.Location = new System.Drawing.Point(10, 1);
            this.lblRenualDuration.Name = "lblRenualDuration";
            this.lblRenualDuration.Size = new System.Drawing.Size(160, 22);
            this.lblRenualDuration.TabIndex = 0;
            this.lblRenualDuration.Text = "नविकरण अवधि:";
            this.lblRenualDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NGO_AffiliationOrganization_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 288);
            this.Controls.Add(this.txtfk_NGO);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.pnlfk_AffiliationOrganization);
            this.Controls.Add(this.pnlRedgeNo);
            this.Controls.Add(this.pnlLastRenualDate);
            this.Controls.Add(this.pnlRenualDuration);
            this.Controls.Add(this.pnlRegistrationDate);
            this.Controls.Add(this.pnlAffiliationDate);
            this.Name = "NGO_AffiliationOrganization_Ent";
            this.Text = "आवद्धता तथा दर्ता (नम्बर सहित अन्तिम नविकरण मिति )";
            this.Load += new System.EventHandler(this.NGO_AffiliationOrganization_Ent_Load);
            this.Controls.SetChildIndex(this.pnlAffiliationDate, 0);
            this.Controls.SetChildIndex(this.pnlRegistrationDate, 0);
            this.Controls.SetChildIndex(this.pnlRenualDuration, 0);
            this.Controls.SetChildIndex(this.pnlLastRenualDate, 0);
            this.Controls.SetChildIndex(this.pnlRedgeNo, 0);
            this.Controls.SetChildIndex(this.pnlfk_AffiliationOrganization, 0);
            this.Controls.SetChildIndex(this.pnlId, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtfk_NGO, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.pnlfk_AffiliationOrganization.ResumeLayout(false);
            this.pnlRegistrationDate.ResumeLayout(false);
            this.pnlAffiliationDate.ResumeLayout(false);
            this.pnlRedgeNo.ResumeLayout(false);
            this.pnlRedgeNo.PerformLayout();
            this.pnlLastRenualDate.ResumeLayout(false);
            this.pnlRenualDuration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

}//<Control>
        private System.Windows.Forms.Panel pnlId; 
 private System.Windows.Forms.Panel pnlfk_AffiliationOrganization; 
 private System.Windows.Forms.Panel pnlRegistrationDate; 
 private System.Windows.Forms.Panel pnlAffiliationDate; 
 private System.Windows.Forms.Panel pnlRedgeNo; 
 private System.Windows.Forms.Panel pnlLastRenualDate; 
 private System.Windows.Forms.Panel pnlRenualDuration; 

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtfk_NGO; 
 private System.Windows.Forms.ComboBox cmbfk_AffiliationOrganization; 
 CrudeFx.NepaliDate.NepaliDatePicker txtRegistrationDate; 
 CrudeFx.NepaliDate.NepaliDatePicker txtAffiliationDate; 
 private System.Windows.Forms.TextBox txtRedgeNo; 
 CrudeFx.NepaliDate.NepaliDatePicker txtLastRenualDate;
 CrudeFx.NepaliDate.NepaliDatePicker txtRenualDuration; 
 private System.Windows.Forms.Label  lblfk_AffiliationOrganization; 
 private System.Windows.Forms.Label  lblRegistrationDate; 
 private System.Windows.Forms.Label  lblAffiliationDate; 
 private System.Windows.Forms.Label  lblRedgeNo; 
 private System.Windows.Forms.Label  lblLastRenualDate; 
 private System.Windows.Forms.Label  lblRenualDuration; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
    }
}
