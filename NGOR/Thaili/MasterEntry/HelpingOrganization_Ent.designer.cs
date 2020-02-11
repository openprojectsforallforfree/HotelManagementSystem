namespace UEMS
{
    partial class HelpingOrganization_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpingOrganization_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlTypeLocal = new System.Windows.Forms.Panel();
            this.rdoLocal = new System.Windows.Forms.RadioButton();
            this.rdoINGO = new System.Windows.Forms.RadioButton();
            this.lblTypeLocal = new System.Windows.Forms.Label();
            this.pnlObjective = new System.Windows.Forms.Panel();
            this.txtObjective = new System.Windows.Forms.TextBox();
            this.lblObjective = new System.Windows.Forms.Label();
            this.grpfk_Address = new System.Windows.Forms.Panel();
            this.txtDonorType = new System.Windows.Forms.TextBox();
            this.txtfk_Address = new System.Windows.Forms.TextBox();
            this.pnlName.SuspendLayout();
            this.pnlTypeLocal.SuspendLayout();
            this.pnlObjective.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(682, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(366, 444);
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
            this.btnOk.Location = new System.Drawing.Point(272, 444);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(461, 12);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 30);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // pnlName
            // 
            this.pnlName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlName.BackColor = System.Drawing.Color.Transparent;
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Controls.Add(this.lblName);
            this.pnlName.Location = new System.Drawing.Point(100, 73);
            this.pnlName.Margin = new System.Windows.Forms.Padding(1);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(533, 34);
            this.pnlName.TabIndex = 0;
            this.pnlName.Text = "निकाय";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 1);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(349, 30);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(10, 1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "निकायको नाम :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTypeLocal
            // 
            this.pnlTypeLocal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTypeLocal.BackColor = System.Drawing.Color.Transparent;
            this.pnlTypeLocal.Controls.Add(this.rdoLocal);
            this.pnlTypeLocal.Controls.Add(this.rdoINGO);
            this.pnlTypeLocal.Controls.Add(this.lblTypeLocal);
            this.pnlTypeLocal.Location = new System.Drawing.Point(100, 109);
            this.pnlTypeLocal.Margin = new System.Windows.Forms.Padding(1);
            this.pnlTypeLocal.Name = "pnlTypeLocal";
            this.pnlTypeLocal.Size = new System.Drawing.Size(425, 66);
            this.pnlTypeLocal.TabIndex = 1;
            this.pnlTypeLocal.Text = "स्थानीय / बाह्य (INGO / Donor)";
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
            // lblTypeLocal
            // 
            this.lblTypeLocal.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeLocal.Location = new System.Drawing.Point(10, 1);
            this.lblTypeLocal.Name = "lblTypeLocal";
            this.lblTypeLocal.Size = new System.Drawing.Size(160, 22);
            this.lblTypeLocal.TabIndex = 0;
            this.lblTypeLocal.Text = " Donor:";
            this.lblTypeLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlObjective
            // 
            this.pnlObjective.AutoSize = true;
            this.pnlObjective.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlObjective.BackColor = System.Drawing.Color.Transparent;
            this.pnlObjective.Controls.Add(this.txtObjective);
            this.pnlObjective.Controls.Add(this.lblObjective);
            this.pnlObjective.Location = new System.Drawing.Point(97, 368);
            this.pnlObjective.Margin = new System.Windows.Forms.Padding(1);
            this.pnlObjective.Name = "pnlObjective";
            this.pnlObjective.Size = new System.Drawing.Size(575, 54);
            this.pnlObjective.TabIndex = 3;
            this.pnlObjective.Text = "उद्देश्य तथा कार्यक्रम ";
            // 
            // txtObjective
            // 
            this.txtObjective.Location = new System.Drawing.Point(172, 1);
            this.txtObjective.MaxLength = 150;
            this.txtObjective.Multiline = true;
            this.txtObjective.Name = "txtObjective";
            this.txtObjective.Size = new System.Drawing.Size(400, 50);
            this.txtObjective.TabIndex = 0;
            // 
            // lblObjective
            // 
            this.lblObjective.BackColor = System.Drawing.Color.Transparent;
            this.lblObjective.Location = new System.Drawing.Point(10, 1);
            this.lblObjective.Name = "lblObjective";
            this.lblObjective.Size = new System.Drawing.Size(160, 22);
            this.lblObjective.TabIndex = 0;
            this.lblObjective.Text = "उद्देश्य तथा कार्यक्रम :";
            this.lblObjective.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpfk_Address
            // 
            this.grpfk_Address.BackColor = System.Drawing.Color.Transparent;
            this.grpfk_Address.Location = new System.Drawing.Point(97, 178);
            this.grpfk_Address.Name = "grpfk_Address";
            this.grpfk_Address.Size = new System.Drawing.Size(380, 186);
            this.grpfk_Address.TabIndex = 2;
            this.grpfk_Address.Text = "स्थापना मिति ";
            // 
            // txtDonorType
            // 
            this.txtDonorType.Location = new System.Drawing.Point(544, 142);
            this.txtDonorType.MaxLength = 5;
            this.txtDonorType.Name = "txtDonorType";
            this.txtDonorType.Size = new System.Drawing.Size(160, 30);
            this.txtDonorType.TabIndex = 0;
            this.txtDonorType.Visible = false;
            // 
            // txtfk_Address
            // 
            this.txtfk_Address.Location = new System.Drawing.Point(544, 192);
            this.txtfk_Address.MaxLength = 5;
            this.txtfk_Address.Name = "txtfk_Address";
            this.txtfk_Address.Size = new System.Drawing.Size(160, 30);
            this.txtfk_Address.TabIndex = 0;
            this.txtfk_Address.Visible = false;
            // 
            // HelpingOrganization_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 482);
            this.Controls.Add(this.grpfk_Address);
            this.Controls.Add(this.txtfk_Address);
            this.Controls.Add(this.txtDonorType);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlTypeLocal);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.pnlObjective);
            this.Name = "HelpingOrganization_Ent";
            this.Text = "निकाय";
            this.Load += new System.EventHandler(this.HelpingOrganization_Ent_Load);
            this.Controls.SetChildIndex(this.pnlObjective, 0);
            this.Controls.SetChildIndex(this.pnlName, 0);
            this.Controls.SetChildIndex(this.pnlTypeLocal, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtDonorType, 0);
            this.Controls.SetChildIndex(this.txtfk_Address, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.grpfk_Address, 0);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlTypeLocal.ResumeLayout(false);
            this.pnlTypeLocal.PerformLayout();
            this.pnlObjective.ResumeLayout(false);
            this.pnlObjective.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }//<Control> 
 private System.Windows.Forms.Panel pnlName;
 private System.Windows.Forms.Panel pnlTypeLocal; 
 private System.Windows.Forms.Panel pnlObjective; 

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtName;
 private System.Windows.Forms.RadioButton rdoINGO;
 private System.Windows.Forms.TextBox txtObjective; 
 private System.Windows.Forms.Label  lblName; 
 private System.Windows.Forms.Label  lblTypeLocal; 
 private System.Windows.Forms.Label  lblObjective; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.Panel grpfk_Address;
        private System.Windows.Forms.RadioButton rdoLocal;
        private System.Windows.Forms.TextBox txtDonorType;
        private System.Windows.Forms.TextBox txtfk_Address;
    }
}
