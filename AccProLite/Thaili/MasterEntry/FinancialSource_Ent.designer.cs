namespace UEMS
{
    partial class FinancialSource_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialSource_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlfkHelpingOrganization = new System.Windows.Forms.Panel();
            this.cmbfkHelpingOrganization = new System.Windows.Forms.ComboBox();
            this.lblfkHelpingOrganization = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoLocal = new System.Windows.Forms.RadioButton();
            this.rdoINGO = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonorType = new System.Windows.Forms.TextBox();
            this.pnlName.SuspendLayout();
            this.pnlfkHelpingOrganization.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(473, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(261, 218);
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
            this.btnOk.Location = new System.Drawing.Point(167, 218);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(318, 21);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(38, 30);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // pnlName
            // 
            this.pnlName.AutoSize = true;
            this.pnlName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlName.BackColor = System.Drawing.Color.Transparent;
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Controls.Add(this.lblName);
            this.pnlName.Location = new System.Drawing.Point(51, 56);
            this.pnlName.Margin = new System.Windows.Forms.Padding(1);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(414, 34);
            this.pnlName.TabIndex = 0;
            this.pnlName.Text = "निकाय";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 1);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 30);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(10, 1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "श्रोत :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlfkHelpingOrganization
            // 
            this.pnlfkHelpingOrganization.AutoSize = true;
            this.pnlfkHelpingOrganization.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlfkHelpingOrganization.BackColor = System.Drawing.Color.Transparent;
            this.pnlfkHelpingOrganization.Controls.Add(this.cmbfkHelpingOrganization);
            this.pnlfkHelpingOrganization.Controls.Add(this.lblfkHelpingOrganization);
            this.pnlfkHelpingOrganization.Location = new System.Drawing.Point(52, 92);
            this.pnlfkHelpingOrganization.Margin = new System.Windows.Forms.Padding(1);
            this.pnlfkHelpingOrganization.Name = "pnlfkHelpingOrganization";
            this.pnlfkHelpingOrganization.Size = new System.Drawing.Size(413, 35);
            this.pnlfkHelpingOrganization.TabIndex = 1;
            this.pnlfkHelpingOrganization.Text = "सहयोगी निकाये ";
            // 
            // cmbfkHelpingOrganization
            // 
            this.cmbfkHelpingOrganization.FormattingEnabled = true;
            this.cmbfkHelpingOrganization.Location = new System.Drawing.Point(172, 1);
            this.cmbfkHelpingOrganization.Name = "cmbfkHelpingOrganization";
            this.cmbfkHelpingOrganization.Size = new System.Drawing.Size(238, 31);
            this.cmbfkHelpingOrganization.TabIndex = 0;
            // 
            // lblfkHelpingOrganization
            // 
            this.lblfkHelpingOrganization.BackColor = System.Drawing.Color.Transparent;
            this.lblfkHelpingOrganization.Location = new System.Drawing.Point(10, 1);
            this.lblfkHelpingOrganization.Name = "lblfkHelpingOrganization";
            this.lblfkHelpingOrganization.Size = new System.Drawing.Size(160, 22);
            this.lblfkHelpingOrganization.TabIndex = 0;
            this.lblfkHelpingOrganization.Text = "सहयोगी निकाये :";
            this.lblfkHelpingOrganization.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rdoLocal);
            this.panel1.Controls.Add(this.rdoINGO);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 129);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 66);
            this.panel1.TabIndex = 2;
            this.panel1.Text = "स्थानीय / बाह्य (INGO / Donor)";
            // 
            // rdoLocal
            // 
            this.rdoLocal.AutoSize = true;
            this.rdoLocal.Location = new System.Drawing.Point(187, 3);
            this.rdoLocal.Name = "rdoLocal";
            this.rdoLocal.Size = new System.Drawing.Size(74, 30);
            this.rdoLocal.TabIndex = 0;
            this.rdoLocal.Text = "स्थानीय";
            this.rdoLocal.UseVisualStyleBackColor = true;
            this.rdoLocal.CheckedChanged += new System.EventHandler(this.rdoLocal_CheckedChanged);
            // 
            // rdoINGO
            // 
            this.rdoINGO.AutoSize = true;
            this.rdoINGO.Location = new System.Drawing.Point(187, 33);
            this.rdoINGO.Name = "rdoINGO";
            this.rdoINGO.Size = new System.Drawing.Size(105, 30);
            this.rdoINGO.TabIndex = 1;
            this.rdoINGO.Text = "बाह्य (INGO)";
            this.rdoINGO.UseVisualStyleBackColor = true;
            this.rdoINGO.CheckedChanged += new System.EventHandler(this.rdoINGO_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "स्थानीय/बाह्य :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDonorType
            // 
            this.txtDonorType.Location = new System.Drawing.Point(249, 21);
            this.txtDonorType.MaxLength = 5;
            this.txtDonorType.Name = "txtDonorType";
            this.txtDonorType.Size = new System.Drawing.Size(55, 30);
            this.txtDonorType.TabIndex = 11;
            this.txtDonorType.Visible = false;
            // 
            // FinancialSource_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 256);
            this.Controls.Add(this.txtDonorType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.pnlfkHelpingOrganization);
            this.Name = "FinancialSource_Ent";
            this.Text = "आर्थिक श्रोत ";
            this.Load += new System.EventHandler(this.FinancialSource_Ent_Load);
            this.Controls.SetChildIndex(this.pnlfkHelpingOrganization, 0);
            this.Controls.SetChildIndex(this.pnlName, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txtDonorType, 0);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlfkHelpingOrganization.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }//<Control> 
        private System.Windows.Forms.Panel pnlName; 
 private System.Windows.Forms.Panel pnlfkHelpingOrganization; 

 private System.Windows.Forms.TextBox txtId;
 private System.Windows.Forms.TextBox txtName;
 private System.Windows.Forms.ComboBox cmbfkHelpingOrganization;
 private System.Windows.Forms.Label lblName; 
 private System.Windows.Forms.Label  lblfkHelpingOrganization; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoLocal;
        private System.Windows.Forms.RadioButton rdoINGO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonorType;
    }
}
