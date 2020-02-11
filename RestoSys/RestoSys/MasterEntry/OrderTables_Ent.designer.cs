namespace UEMS
{
    partial class OrderTables_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderTables_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlRemarks = new System.Windows.Forms.Panel();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.pnlName.SuspendLayout();
            this.pnlRemarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(595, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(322, 117);
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
            this.btnOk.Location = new System.Drawing.Point(228, 117);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(38, 7);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 23);
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
            this.pnlName.Location = new System.Drawing.Point(38, 43);
            this.pnlName.Margin = new System.Windows.Forms.Padding(1);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(335, 27);
            this.pnlName.TabIndex = 0;
            this.pnlName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 1);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 23);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(10, 1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlRemarks
            // 
            this.pnlRemarks.AutoSize = true;
            this.pnlRemarks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRemarks.BackColor = System.Drawing.Color.Transparent;
            this.pnlRemarks.Controls.Add(this.txtRemarks);
            this.pnlRemarks.Controls.Add(this.lblRemarks);
            this.pnlRemarks.Location = new System.Drawing.Point(38, 72);
            this.pnlRemarks.Margin = new System.Windows.Forms.Padding(1);
            this.pnlRemarks.Name = "pnlRemarks";
            this.pnlRemarks.Size = new System.Drawing.Size(565, 27);
            this.pnlRemarks.TabIndex = 0;
            this.pnlRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(172, 1);
            this.txtRemarks.MaxLength = 50;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(390, 23);
            this.txtRemarks.TabIndex = 0;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Location = new System.Drawing.Point(10, 1);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(160, 22);
            this.lblRemarks.TabIndex = 0;
            this.lblRemarks.Text = "Remarks:";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderTables_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 155);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.pnlRemarks);
            this.Name = "OrderTables_Ent";
            this.Load += new System.EventHandler(this.OrderTables_Ent_Load);
            this.Controls.SetChildIndex(this.pnlRemarks, 0);
            this.Controls.SetChildIndex(this.pnlName, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlRemarks.ResumeLayout(false);
            this.pnlRemarks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }//<Control> 
 private System.Windows.Forms.Panel pnlName; 
 private System.Windows.Forms.Panel pnlRemarks; 

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtName;
 private System.Windows.Forms.TextBox txtRemarks; 
 private System.Windows.Forms.Label  lblName; 
 private System.Windows.Forms.Label  lblRemarks; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
    }
}
