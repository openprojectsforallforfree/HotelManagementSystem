namespace UEMS
{
    partial class TargetAudienceText_NGO_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetAudienceText_NGO_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.flwLayout = new Bsoft.Controls.LableFlowLayout();
            this.pnlId = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlNGO_ID = new System.Windows.Forms.Panel();
            this.txtNGO_ID = new System.Windows.Forms.TextBox();
            this.lblNGO_ID = new System.Windows.Forms.Label();
            this.pnlfk_TargetAudience = new System.Windows.Forms.Panel();
            this.txtfk_TargetAudience = new System.Windows.Forms.TextBox();
            this.lblfk_TargetAudience = new System.Windows.Forms.Label();
            this.flwLayout.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.pnlNGO_ID.SuspendLayout();
            this.pnlfk_TargetAudience.SuspendLayout();
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
            this.flwLayout.Controls.Add(this.pnlNGO_ID);
            this.flwLayout.Controls.Add(this.pnlfk_TargetAudience);
            this.flwLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwLayout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flwLayout.lable = "लक्षित वर्ग /समुदाय ";
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
            // pnlNGO_ID
            // 
            this.pnlNGO_ID.AutoSize = true;
            this.pnlNGO_ID.BackColor = System.Drawing.Color.Transparent;
            this.pnlNGO_ID.Controls.Add(this.txtNGO_ID);
            this.pnlNGO_ID.Controls.Add(this.lblNGO_ID);
            this.pnlNGO_ID.Location = new System.Drawing.Point(3, 95);
            this.pnlNGO_ID.Name = "pnlNGO_ID";
            this.pnlNGO_ID.Size = new System.Drawing.Size(335, 43);
            this.pnlNGO_ID.TabIndex = 0;
            this.pnlNGO_ID.Text = "NGO_ID";
            // 
            // txtNGO_ID
            // 
            this.txtNGO_ID.Location = new System.Drawing.Point(172, 10);
            this.txtNGO_ID.Name = "txtNGO_ID";
            this.txtNGO_ID.Size = new System.Drawing.Size(160, 30);
            this.txtNGO_ID.TabIndex = 0;
            // 
            // lblNGO_ID
            // 
            this.lblNGO_ID.BackColor = System.Drawing.Color.Transparent;
            this.lblNGO_ID.Location = new System.Drawing.Point(10, 10);
            this.lblNGO_ID.Name = "lblNGO_ID";
            this.lblNGO_ID.Size = new System.Drawing.Size(160, 22);
            this.lblNGO_ID.TabIndex = 0;
            this.lblNGO_ID.Text = "NGO_ID:";
            this.lblNGO_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlfk_TargetAudience
            // 
            this.pnlfk_TargetAudience.AutoSize = true;
            this.pnlfk_TargetAudience.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_TargetAudience.Controls.Add(this.txtfk_TargetAudience);
            this.pnlfk_TargetAudience.Controls.Add(this.lblfk_TargetAudience);
            this.pnlfk_TargetAudience.Location = new System.Drawing.Point(3, 144);
            this.pnlfk_TargetAudience.Name = "pnlfk_TargetAudience";
            this.pnlfk_TargetAudience.Size = new System.Drawing.Size(335, 43);
            this.pnlfk_TargetAudience.TabIndex = 0;
            this.pnlfk_TargetAudience.Text = "fk_TargetAudience";
            // 
            // txtfk_TargetAudience
            // 
            this.txtfk_TargetAudience.Location = new System.Drawing.Point(172, 10);
            this.txtfk_TargetAudience.Name = "txtfk_TargetAudience";
            this.txtfk_TargetAudience.Size = new System.Drawing.Size(160, 30);
            this.txtfk_TargetAudience.TabIndex = 0;
            // 
            // lblfk_TargetAudience
            // 
            this.lblfk_TargetAudience.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_TargetAudience.Location = new System.Drawing.Point(10, 10);
            this.lblfk_TargetAudience.Name = "lblfk_TargetAudience";
            this.lblfk_TargetAudience.Size = new System.Drawing.Size(160, 22);
            this.lblfk_TargetAudience.TabIndex = 0;
            this.lblfk_TargetAudience.Text = "fk_TargetAudience:";
            this.lblfk_TargetAudience.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TargetAudienceText_NGO_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 510);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flwLayout);
            this.Controls.Add(this.btnOk);
            this.Name = "TargetAudienceText_NGO_Ent";
            this.Text = "लक्षित वर्ग /समुदाय ";
            this.Load += new System.EventHandler(this.TargetAudienceText_NGO_Ent_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.flwLayout, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.flwLayout.ResumeLayout(false);
            this.flwLayout.PerformLayout();
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.pnlNGO_ID.ResumeLayout(false);
            this.pnlNGO_ID.PerformLayout();
            this.pnlfk_TargetAudience.ResumeLayout(false);
            this.pnlfk_TargetAudience.PerformLayout();
            this.ResumeLayout(false);

}//<Control>
 private System.Windows.Forms.Panel pnlId; 
 private System.Windows.Forms.Panel pnlNGO_ID;
 private System.Windows.Forms.Panel pnlfk_TargetAudience; 

 private System.Windows.Forms.Label  lblId; 
 private System.Windows.Forms.Label  lblNGO_ID; 
 private System.Windows.Forms.Label  lblfk_TargetAudience; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private Bsoft.Controls.LableFlowLayout flwLayout;
        public System.Windows.Forms.TextBox txtNGO_ID;
        public System.Windows.Forms.TextBox txtfk_TargetAudience;
        public System.Windows.Forms.TextBox txtId;
    }
}
