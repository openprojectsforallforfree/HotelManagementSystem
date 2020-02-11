namespace UEMS
{
    partial class TagGroup_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagGroup_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbTagTypeId = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTagTypeId = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(656, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(353, 195);
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
            this.btnOk.Location = new System.Drawing.Point(259, 195);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(289, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 23);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(243, 58);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(160, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // cmbTagTypeId
            // 
            this.cmbTagTypeId.FormattingEnabled = true;
            this.cmbTagTypeId.Location = new System.Drawing.Point(243, 88);
            this.cmbTagTypeId.Name = "cmbTagTypeId";
            this.cmbTagTypeId.Size = new System.Drawing.Size(160, 24);
            this.cmbTagTypeId.TabIndex = 0;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(243, 118);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(400, 50);
            this.txtRemarks.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(77, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Parameter Name:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTagTypeId
            // 
            this.lblTagTypeId.BackColor = System.Drawing.Color.Transparent;
            this.lblTagTypeId.Location = new System.Drawing.Point(77, 89);
            this.lblTagTypeId.Name = "lblTagTypeId";
            this.lblTagTypeId.Size = new System.Drawing.Size(160, 22);
            this.lblTagTypeId.TabIndex = 0;
            this.lblTagTypeId.Text = "Parameter Type:";
            this.lblTagTypeId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Location = new System.Drawing.Point(77, 119);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(160, 22);
            this.lblRemarks.TabIndex = 0;
            this.lblRemarks.Text = "Remarks:";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TagGroup_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 233);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cmbTagTypeId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblTagTypeId);
            this.Name = "TagGroup_Ent";
            this.Text = "Parameter";
            this.Load += new System.EventHandler(this.TagGroup_Ent_Load);
            this.Controls.SetChildIndex(this.lblTagTypeId, 0);
            this.Controls.SetChildIndex(this.lblRemarks, 0);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.cmbTagTypeId, 0);
            this.Controls.SetChildIndex(this.txtTitle, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

}//<Control>

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtTitle; 
 private System.Windows.Forms.ComboBox cmbTagTypeId;
 private System.Windows.Forms.TextBox txtRemarks; 
 private System.Windows.Forms.Label  lblTitle; 
 private System.Windows.Forms.Label  lblTagTypeId; 
 private System.Windows.Forms.Label  lblRemarks; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
    }
}
