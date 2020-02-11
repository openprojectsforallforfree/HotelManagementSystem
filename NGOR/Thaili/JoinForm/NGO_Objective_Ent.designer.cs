namespace UEMS
{
    partial class NGO_Objective_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NGO_Objective_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.pnlId = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlfk_NGO = new System.Windows.Forms.Panel();
            this.txtfk_NGO = new System.Windows.Forms.TextBox();
            this.lblfk_NGO = new System.Windows.Forms.Label();
            this.pnlfk_Objective = new System.Windows.Forms.Panel();
            this.txtfk_Objective = new System.Windows.Forms.TextBox();
            this.lblfk_Objective = new System.Windows.Forms.Label();
            this.pnlId.SuspendLayout();
            this.pnlfk_NGO.SuspendLayout();
            this.pnlfk_Objective.SuspendLayout();
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
            // pnlId
            // 
            this.pnlId.AutoSize = true;
            this.pnlId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlId.BackColor = System.Drawing.Color.Transparent;
            this.pnlId.Controls.Add(this.txtId);
            this.pnlId.Controls.Add(this.lblId);
            this.pnlId.Location = new System.Drawing.Point(100, 72);
            this.pnlId.Margin = new System.Windows.Forms.Padding(1);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(335, 34);
            this.pnlId.TabIndex = 0;
            this.pnlId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(172, 1);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 30);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(10, 1);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(160, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlfk_NGO
            // 
            this.pnlfk_NGO.AutoSize = true;
            this.pnlfk_NGO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlfk_NGO.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_NGO.Controls.Add(this.txtfk_NGO);
            this.pnlfk_NGO.Controls.Add(this.lblfk_NGO);
            this.pnlfk_NGO.Location = new System.Drawing.Point(100, 122);
            this.pnlfk_NGO.Margin = new System.Windows.Forms.Padding(1);
            this.pnlfk_NGO.Name = "pnlfk_NGO";
            this.pnlfk_NGO.Size = new System.Drawing.Size(335, 34);
            this.pnlfk_NGO.TabIndex = 0;
            this.pnlfk_NGO.Text = "fk_NGO";
            // 
            // txtfk_NGO
            // 
            this.txtfk_NGO.Location = new System.Drawing.Point(172, 1);
            this.txtfk_NGO.MaxLength = 5;
            this.txtfk_NGO.Name = "txtfk_NGO";
            this.txtfk_NGO.Size = new System.Drawing.Size(160, 30);
            this.txtfk_NGO.TabIndex = 0;
            // 
            // lblfk_NGO
            // 
            this.lblfk_NGO.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_NGO.Location = new System.Drawing.Point(10, 1);
            this.lblfk_NGO.Name = "lblfk_NGO";
            this.lblfk_NGO.Size = new System.Drawing.Size(160, 22);
            this.lblfk_NGO.TabIndex = 0;
            this.lblfk_NGO.Text = "fk_NGO:";
            this.lblfk_NGO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlfk_Objective
            // 
            this.pnlfk_Objective.AutoSize = true;
            this.pnlfk_Objective.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlfk_Objective.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_Objective.Controls.Add(this.txtfk_Objective);
            this.pnlfk_Objective.Controls.Add(this.lblfk_Objective);
            this.pnlfk_Objective.Location = new System.Drawing.Point(100, 172);
            this.pnlfk_Objective.Margin = new System.Windows.Forms.Padding(1);
            this.pnlfk_Objective.Name = "pnlfk_Objective";
            this.pnlfk_Objective.Size = new System.Drawing.Size(335, 34);
            this.pnlfk_Objective.TabIndex = 0;
            this.pnlfk_Objective.Text = "उद्देश्यहरु ";
            // 
            // txtfk_Objective
            // 
            this.txtfk_Objective.Location = new System.Drawing.Point(172, 1);
            this.txtfk_Objective.MaxLength = 5;
            this.txtfk_Objective.Name = "txtfk_Objective";
            this.txtfk_Objective.Size = new System.Drawing.Size(160, 30);
            this.txtfk_Objective.TabIndex = 0;
            // 
            // lblfk_Objective
            // 
            this.lblfk_Objective.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Objective.Location = new System.Drawing.Point(10, 1);
            this.lblfk_Objective.Name = "lblfk_Objective";
            this.lblfk_Objective.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Objective.TabIndex = 0;
            this.lblfk_Objective.Text = "उद्देश्यहरु :";
            this.lblfk_Objective.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NGO_Objective_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 510);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.pnlfk_NGO);
            this.Controls.Add(this.pnlfk_Objective);
            this.Name = "NGO_Objective_Ent";
            this.Text = "संस्थाको उद्देश्यहरु ";
            this.Load += new System.EventHandler(this.NGO_Objective_Ent_Load);
            this.Controls.SetChildIndex(this.pnlfk_Objective, 0);
            this.Controls.SetChildIndex(this.pnlfk_NGO, 0);
            this.Controls.SetChildIndex(this.pnlId, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.pnlfk_NGO.ResumeLayout(false);
            this.pnlfk_NGO.PerformLayout();
            this.pnlfk_Objective.ResumeLayout(false);
            this.pnlfk_Objective.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

}//<Control>
 private System.Windows.Forms.Panel pnlId; 
 private System.Windows.Forms.Panel pnlfk_NGO;
 private System.Windows.Forms.Panel pnlfk_Objective; 

 private System.Windows.Forms.Label  lblId; 
 private System.Windows.Forms.Label  lblfk_NGO; 
 private System.Windows.Forms.Label  lblfk_Objective; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        public System.Windows.Forms.TextBox txtfk_NGO;
        public System.Windows.Forms.TextBox txtfk_Objective;
        public System.Windows.Forms.TextBox txtId;
    }
}
