namespace UEMS
{
    partial class ContactInformation_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactInformation_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlPhone = new System.Windows.Forms.Panel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.pnlFax = new System.Windows.Forms.Panel();
            this.lblFax = new System.Windows.Forms.Label();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlWebSite = new System.Windows.Forms.Panel();
            this.lblWebSite = new System.Windows.Forms.Label();
            this.pnlMobileNo = new System.Windows.Forms.Panel();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPhone = new Bsoft.Controls.VtextBox();
            this.txtMobileNo = new Bsoft.Controls.VtextBox();
            this.txtFax = new Bsoft.Controls.VtextBox();
            this.txtEmail = new Bsoft.Controls.VtextBox();
            this.txtWebSite = new Bsoft.Controls.VtextBox();
            this.pnlPhone.SuspendLayout();
            this.pnlFax.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.pnlWebSite.SuspendLayout();
            this.pnlMobileNo.SuspendLayout();
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
            this.txtId.Location = new System.Drawing.Point(478, 12);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 23);
            this.txtId.TabIndex = 0;
            // 
            // pnlPhone
            // 
            this.pnlPhone.AutoSize = true;
            this.pnlPhone.BackColor = System.Drawing.Color.Transparent;
            this.pnlPhone.Controls.Add(this.lblPhone);
            this.pnlPhone.Controls.Add(this.txtPhone);
            this.pnlPhone.Location = new System.Drawing.Point(1, 1);
            this.pnlPhone.Margin = new System.Windows.Forms.Padding(1);
            this.pnlPhone.Name = "pnlPhone";
            this.pnlPhone.Size = new System.Drawing.Size(296, 27);
            this.pnlPhone.TabIndex = 0;
            this.pnlPhone.Text = "फोन";
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Location = new System.Drawing.Point(10, 1);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(94, 22);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "फोन:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFax
            // 
            this.pnlFax.AutoSize = true;
            this.pnlFax.BackColor = System.Drawing.Color.Transparent;
            this.pnlFax.Controls.Add(this.txtFax);
            this.pnlFax.Controls.Add(this.lblFax);
            this.pnlFax.Location = new System.Drawing.Point(1, 62);
            this.pnlFax.Margin = new System.Windows.Forms.Padding(1);
            this.pnlFax.Name = "pnlFax";
            this.pnlFax.Size = new System.Drawing.Size(295, 30);
            this.pnlFax.TabIndex = 0;
            this.pnlFax.Text = "फ्याक्स";
            // 
            // lblFax
            // 
            this.lblFax.BackColor = System.Drawing.Color.Transparent;
            this.lblFax.Location = new System.Drawing.Point(10, 1);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(94, 22);
            this.lblFax.TabIndex = 0;
            this.lblFax.Text = "फ्याक्स:";
            this.lblFax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlEmail
            // 
            this.pnlEmail.AutoSize = true;
            this.pnlEmail.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Location = new System.Drawing.Point(1, 94);
            this.pnlEmail.Margin = new System.Windows.Forms.Padding(1);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(295, 31);
            this.pnlEmail.TabIndex = 0;
            this.pnlEmail.Text = "इमेल";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(10, 1);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 22);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "इमेल:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlWebSite
            // 
            this.pnlWebSite.AutoSize = true;
            this.pnlWebSite.BackColor = System.Drawing.Color.Transparent;
            this.pnlWebSite.Controls.Add(this.txtWebSite);
            this.pnlWebSite.Controls.Add(this.lblWebSite);
            this.pnlWebSite.Location = new System.Drawing.Point(1, 127);
            this.pnlWebSite.Margin = new System.Windows.Forms.Padding(1);
            this.pnlWebSite.Name = "pnlWebSite";
            this.pnlWebSite.Size = new System.Drawing.Size(295, 29);
            this.pnlWebSite.TabIndex = 0;
            this.pnlWebSite.Text = "वेवसाइट";
            // 
            // lblWebSite
            // 
            this.lblWebSite.BackColor = System.Drawing.Color.Transparent;
            this.lblWebSite.Location = new System.Drawing.Point(10, 4);
            this.lblWebSite.Name = "lblWebSite";
            this.lblWebSite.Size = new System.Drawing.Size(94, 22);
            this.lblWebSite.TabIndex = 0;
            this.lblWebSite.Text = "वेवसाइट:";
            this.lblWebSite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMobileNo
            // 
            this.pnlMobileNo.AutoSize = true;
            this.pnlMobileNo.BackColor = System.Drawing.Color.Transparent;
            this.pnlMobileNo.Controls.Add(this.txtMobileNo);
            this.pnlMobileNo.Controls.Add(this.lblMobileNo);
            this.pnlMobileNo.Location = new System.Drawing.Point(1, 30);
            this.pnlMobileNo.Margin = new System.Windows.Forms.Padding(1);
            this.pnlMobileNo.Name = "pnlMobileNo";
            this.pnlMobileNo.Size = new System.Drawing.Size(295, 30);
            this.pnlMobileNo.TabIndex = 0;
            this.pnlMobileNo.Text = "मोबाइल नं ";
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.BackColor = System.Drawing.Color.Transparent;
            this.lblMobileNo.Location = new System.Drawing.Point(10, 1);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(94, 22);
            this.lblMobileNo.TabIndex = 0;
            this.lblMobileNo.Text = "मोबाइल नं :";
            this.lblMobileNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.pnlPhone);
            this.flowLayoutPanel1.Controls.Add(this.pnlMobileNo);
            this.flowLayoutPanel1.Controls.Add(this.pnlFax);
            this.flowLayoutPanel1.Controls.Add(this.pnlEmail);
            this.flowLayoutPanel1.Controls.Add(this.pnlWebSite);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(371, 236);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(132, 1);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(161, 23);
            this.txtPhone.TabIndex = 13;
            this.txtPhone.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.PhoneFax;
            this.txtPhone.Value = "";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(131, 4);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(161, 23);
            this.txtMobileNo.TabIndex = 13;
            this.txtMobileNo.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.PhoneFax;
            this.txtMobileNo.Value = "";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(131, 4);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(161, 23);
            this.txtFax.TabIndex = 13;
            this.txtFax.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.PhoneFax;
            this.txtFax.Value = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 23);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Email;
            this.txtEmail.Value = "";
            // 
            // txtWebSite
            // 
            this.txtWebSite.Location = new System.Drawing.Point(131, 3);
            this.txtWebSite.Name = "txtWebSite";
            this.txtWebSite.Size = new System.Drawing.Size(161, 23);
            this.txtWebSite.TabIndex = 13;
            this.txtWebSite.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.WebSite;
            this.txtWebSite.Value = "";
            // 
            // ContactInformation_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 510);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "ContactInformation_Ent";
            this.Load += new System.EventHandler(this.ContactInformation_Ent_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.pnlPhone.ResumeLayout(false);
            this.pnlPhone.PerformLayout();
            this.pnlFax.ResumeLayout(false);
            this.pnlFax.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlWebSite.ResumeLayout(false);
            this.pnlWebSite.PerformLayout();
            this.pnlMobileNo.ResumeLayout(false);
            this.pnlMobileNo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }//<Control>           
 private System.Windows.Forms.Label  lblPhone; 
 private System.Windows.Forms.Label  lblFax; 
 private System.Windows.Forms.Label  lblEmail; 
 private System.Windows.Forms.Label  lblWebSite; 
 private System.Windows.Forms.Label  lblMobileNo; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Panel pnlPhone;
        public System.Windows.Forms.Panel pnlFax;
        public System.Windows.Forms.Panel pnlEmail;
        public System.Windows.Forms.Panel pnlWebSite;
        public System.Windows.Forms.Panel pnlMobileNo;
        public System.Windows.Forms.TextBox txtId;
        public Bsoft.Controls.VtextBox txtPhone;
        public Bsoft.Controls.VtextBox txtFax;
        public Bsoft.Controls.VtextBox txtEmail;
        public Bsoft.Controls.VtextBox txtMobileNo;
        public Bsoft.Controls.VtextBox txtWebSite;
    }
}
