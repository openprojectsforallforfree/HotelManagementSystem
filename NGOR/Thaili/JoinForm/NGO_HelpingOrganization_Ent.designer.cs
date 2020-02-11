namespace UEMS
{
    partial class NGO_HelpingOrganization_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NGO_HelpingOrganization_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlfk_HelpingOrganization = new System.Windows.Forms.Panel();
            this.lblfk_HelpingOrganization = new System.Windows.Forms.Label();
            this.txtfk_NGO = new System.Windows.Forms.TextBox();
            this.txtFkHelpingOrg = new System.Windows.Forms.TextBox();
            this.pnlfk_HelpingOrganization.SuspendLayout();
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
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(146, 4);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 30);
            this.txtId.TabIndex = 0;
            // 
            // pnlfk_HelpingOrganization
            // 
            this.pnlfk_HelpingOrganization.AutoSize = true;
            this.pnlfk_HelpingOrganization.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_HelpingOrganization.Controls.Add(this.lblfk_HelpingOrganization);
            this.pnlfk_HelpingOrganization.Location = new System.Drawing.Point(21, 118);
            this.pnlfk_HelpingOrganization.Name = "pnlfk_HelpingOrganization";
            this.pnlfk_HelpingOrganization.Size = new System.Drawing.Size(396, 44);
            this.pnlfk_HelpingOrganization.TabIndex = 0;
            this.pnlfk_HelpingOrganization.Text = "सहयोगी तथा साझेदारी संस्था ";
            // 
            // lblfk_HelpingOrganization
            // 
            this.lblfk_HelpingOrganization.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_HelpingOrganization.Location = new System.Drawing.Point(10, 10);
            this.lblfk_HelpingOrganization.Name = "lblfk_HelpingOrganization";
            this.lblfk_HelpingOrganization.Size = new System.Drawing.Size(215, 22);
            this.lblfk_HelpingOrganization.TabIndex = 0;
            this.lblfk_HelpingOrganization.Text = "सहयोगी तथा साझेदारी संस्था :";
            this.lblfk_HelpingOrganization.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtfk_NGO
            // 
            this.txtfk_NGO.Location = new System.Drawing.Point(12, 2);
            this.txtfk_NGO.MaxLength = 5;
            this.txtfk_NGO.Name = "txtfk_NGO";
            this.txtfk_NGO.Size = new System.Drawing.Size(70, 30);
            this.txtfk_NGO.TabIndex = 0;
            // 
            // txtFkHelpingOrg
            // 
            this.txtFkHelpingOrg.Location = new System.Drawing.Point(312, 4);
            this.txtFkHelpingOrg.MaxLength = 5;
            this.txtFkHelpingOrg.Name = "txtFkHelpingOrg";
            this.txtFkHelpingOrg.Size = new System.Drawing.Size(160, 30);
            this.txtFkHelpingOrg.TabIndex = 0;
            // 
            // NGO_HelpingOrganization_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 510);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtfk_NGO);
            this.Controls.Add(this.txtFkHelpingOrg);
            this.Controls.Add(this.pnlfk_HelpingOrganization);
            this.Name = "NGO_HelpingOrganization_Ent";
            this.Text = "सहयोगी तथा साझेदारी संस्था ";
            this.Load += new System.EventHandler(this.NGO_HelpingOrganization_Ent_Load);
            this.Controls.SetChildIndex(this.pnlfk_HelpingOrganization, 0);
            this.Controls.SetChildIndex(this.txtFkHelpingOrg, 0);
            this.Controls.SetChildIndex(this.txtfk_NGO, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.pnlfk_HelpingOrganization.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }//<Control> 
        private System.Windows.Forms.Panel pnlfk_HelpingOrganization; 
 private System.Windows.Forms.Label  lblfk_HelpingOrganization; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtfk_NGO;
        public System.Windows.Forms.TextBox txtFkHelpingOrg;
    }
}
