namespace UEMS
{
    partial class SubjectiveWrk_NGO_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectiveWrk_NGO_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNGO_ID = new System.Windows.Forms.TextBox();
            this.pnlfk_SubjectiveWrk = new System.Windows.Forms.Panel();
            this.txtfk_SubjectiveWrk = new System.Windows.Forms.TextBox();
            this.lblfk_SubjectiveWrk = new System.Windows.Forms.Label();
            this.pnlfk_SubjectiveWrk.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(407, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(228, 152);
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
            this.btnOk.Location = new System.Drawing.Point(134, 152);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(241, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(80, 30);
            this.txtId.TabIndex = 0;
            // 
            // txtNGO_ID
            // 
            this.txtNGO_ID.Location = new System.Drawing.Point(135, 12);
            this.txtNGO_ID.Name = "txtNGO_ID";
            this.txtNGO_ID.Size = new System.Drawing.Size(61, 30);
            this.txtNGO_ID.TabIndex = 0;
            // 
            // pnlfk_SubjectiveWrk
            // 
            this.pnlfk_SubjectiveWrk.AutoSize = true;
            this.pnlfk_SubjectiveWrk.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_SubjectiveWrk.Controls.Add(this.txtfk_SubjectiveWrk);
            this.pnlfk_SubjectiveWrk.Controls.Add(this.lblfk_SubjectiveWrk);
            this.pnlfk_SubjectiveWrk.Location = new System.Drawing.Point(26, 73);
            this.pnlfk_SubjectiveWrk.Name = "pnlfk_SubjectiveWrk";
            this.pnlfk_SubjectiveWrk.Size = new System.Drawing.Size(335, 43);
            this.pnlfk_SubjectiveWrk.TabIndex = 0;
            this.pnlfk_SubjectiveWrk.Text = "fk_SubjectiveWrk";
            // 
            // txtfk_SubjectiveWrk
            // 
            this.txtfk_SubjectiveWrk.Location = new System.Drawing.Point(172, 10);
            this.txtfk_SubjectiveWrk.Name = "txtfk_SubjectiveWrk";
            this.txtfk_SubjectiveWrk.Size = new System.Drawing.Size(160, 30);
            this.txtfk_SubjectiveWrk.TabIndex = 0;
            // 
            // lblfk_SubjectiveWrk
            // 
            this.lblfk_SubjectiveWrk.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_SubjectiveWrk.Location = new System.Drawing.Point(10, 10);
            this.lblfk_SubjectiveWrk.Name = "lblfk_SubjectiveWrk";
            this.lblfk_SubjectiveWrk.Size = new System.Drawing.Size(160, 22);
            this.lblfk_SubjectiveWrk.TabIndex = 0;
            this.lblfk_SubjectiveWrk.Text = "fk_SubjectiveWrk:";
            this.lblfk_SubjectiveWrk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SubjectiveWrk_NGO_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 190);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNGO_ID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlfk_SubjectiveWrk);
            this.Name = "SubjectiveWrk_NGO_Ent";
            this.Text = "विषयगत कार्यक्षेत्र ";
            this.Load += new System.EventHandler(this.SubjectiveWrk_NGO_Ent_Load);
            this.Controls.SetChildIndex(this.pnlfk_SubjectiveWrk, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtNGO_ID, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.pnlfk_SubjectiveWrk.ResumeLayout(false);
            this.pnlfk_SubjectiveWrk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }//<Control>  
        private System.Windows.Forms.Panel pnlfk_SubjectiveWrk; 
 private System.Windows.Forms.Label  lblfk_SubjectiveWrk; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtNGO_ID;
        public System.Windows.Forms.TextBox txtfk_SubjectiveWrk;
    }
}
