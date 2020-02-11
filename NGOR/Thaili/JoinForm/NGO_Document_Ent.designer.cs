namespace UEMS
{
    partial class NGO_Document_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NGO_Document_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.flwLayout = new Bsoft.Controls.LableFlowLayout();
            this.pnlId = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlfk_RenualOfRegistraion = new System.Windows.Forms.Panel();
            this.txtfk_RenualOfRegistraion = new System.Windows.Forms.TextBox();
            this.lblfk_RenualOfRegistraion = new System.Windows.Forms.Label();
            this.pnlfk_Document = new System.Windows.Forms.Panel();
            this.txtfk_Document = new System.Windows.Forms.TextBox();
            this.lblfk_Document = new System.Windows.Forms.Label();
            this.flwLayout.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.pnlfk_RenualOfRegistraion.SuspendLayout();
            this.pnlfk_Document.SuspendLayout();
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
            this.flwLayout.Controls.Add(this.pnlfk_RenualOfRegistraion);
            this.flwLayout.Controls.Add(this.pnlfk_Document);
            this.flwLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwLayout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flwLayout.lable = "संलग्न विवरण ";
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
            this.txtId.MaxLength = 5;
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
            // pnlfk_RenualOfRegistraion
            // 
            this.pnlfk_RenualOfRegistraion.AutoSize = true;
            this.pnlfk_RenualOfRegistraion.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_RenualOfRegistraion.Controls.Add(this.txtfk_RenualOfRegistraion);
            this.pnlfk_RenualOfRegistraion.Controls.Add(this.lblfk_RenualOfRegistraion);
            this.pnlfk_RenualOfRegistraion.Location = new System.Drawing.Point(3, 95);
            this.pnlfk_RenualOfRegistraion.Name = "pnlfk_RenualOfRegistraion";
            this.pnlfk_RenualOfRegistraion.Size = new System.Drawing.Size(335, 43);
            this.pnlfk_RenualOfRegistraion.TabIndex = 0;
            this.pnlfk_RenualOfRegistraion.Text = "fk_RenualOfRegistraion";
            // 
            // txtfk_RenualOfRegistraion
            // 
            this.txtfk_RenualOfRegistraion.Location = new System.Drawing.Point(172, 10);
            this.txtfk_RenualOfRegistraion.MaxLength = 5;
            this.txtfk_RenualOfRegistraion.Name = "txtfk_RenualOfRegistraion";
            this.txtfk_RenualOfRegistraion.Size = new System.Drawing.Size(160, 30);
            this.txtfk_RenualOfRegistraion.TabIndex = 0;
            // 
            // lblfk_RenualOfRegistraion
            // 
            this.lblfk_RenualOfRegistraion.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_RenualOfRegistraion.Location = new System.Drawing.Point(10, 10);
            this.lblfk_RenualOfRegistraion.Name = "lblfk_RenualOfRegistraion";
            this.lblfk_RenualOfRegistraion.Size = new System.Drawing.Size(160, 22);
            this.lblfk_RenualOfRegistraion.TabIndex = 0;
            this.lblfk_RenualOfRegistraion.Text = "fk_RenualOfRegistraion:";
            this.lblfk_RenualOfRegistraion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlfk_Document
            // 
            this.pnlfk_Document.AutoSize = true;
            this.pnlfk_Document.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_Document.Controls.Add(this.txtfk_Document);
            this.pnlfk_Document.Controls.Add(this.lblfk_Document);
            this.pnlfk_Document.Location = new System.Drawing.Point(3, 144);
            this.pnlfk_Document.Name = "pnlfk_Document";
            this.pnlfk_Document.Size = new System.Drawing.Size(335, 43);
            this.pnlfk_Document.TabIndex = 0;
            this.pnlfk_Document.Text = " विवरण ";
            // 
            // txtfk_Document
            // 
            this.txtfk_Document.Location = new System.Drawing.Point(172, 10);
            this.txtfk_Document.MaxLength = 5;
            this.txtfk_Document.Name = "txtfk_Document";
            this.txtfk_Document.Size = new System.Drawing.Size(160, 30);
            this.txtfk_Document.TabIndex = 0;
            // 
            // lblfk_Document
            // 
            this.lblfk_Document.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Document.Location = new System.Drawing.Point(10, 10);
            this.lblfk_Document.Name = "lblfk_Document";
            this.lblfk_Document.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Document.TabIndex = 0;
            this.lblfk_Document.Text = " विवरण :";
            this.lblfk_Document.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NGO_Document_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 510);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flwLayout);
            this.Controls.Add(this.btnOk);
            this.Name = "NGO_Document_Ent";
            this.Text = "संलग्न विवरण ";
            this.Load += new System.EventHandler(this.NGO_Document_Ent_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.flwLayout, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.flwLayout.ResumeLayout(false);
            this.flwLayout.PerformLayout();
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.pnlfk_RenualOfRegistraion.ResumeLayout(false);
            this.pnlfk_RenualOfRegistraion.PerformLayout();
            this.pnlfk_Document.ResumeLayout(false);
            this.pnlfk_Document.PerformLayout();
            this.ResumeLayout(false);

}//<Control>
 private System.Windows.Forms.Panel pnlId; 
 private System.Windows.Forms.Panel pnlfk_RenualOfRegistraion;
 private System.Windows.Forms.Panel pnlfk_Document; 

 private System.Windows.Forms.Label  lblId; 
 private System.Windows.Forms.Label  lblfk_RenualOfRegistraion; 
 private System.Windows.Forms.Label  lblfk_Document; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private Bsoft.Controls.LableFlowLayout flwLayout;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtfk_RenualOfRegistraion;
        public System.Windows.Forms.TextBox txtfk_Document;
    }
}
