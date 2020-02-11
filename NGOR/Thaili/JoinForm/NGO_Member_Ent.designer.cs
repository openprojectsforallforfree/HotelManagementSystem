namespace UEMS
{
    partial class NGO_Member_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NGO_Member_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.flwLayout = new Bsoft.Controls.LableFlowLayout();
            this.pnlID = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlfk_NGO = new System.Windows.Forms.Panel();
            this.txtfk_NGO = new System.Windows.Forms.TextBox();
            this.lblfk_NGO = new System.Windows.Forms.Label();
            this.pnlfk_Person = new System.Windows.Forms.Panel();
            this.txtfk_Person = new System.Windows.Forms.TextBox();
            this.lblfk_Person = new System.Windows.Forms.Label();
            this.pnlfk_Person_Role = new System.Windows.Forms.Panel();
            this.txtfk_Person_Role = new System.Windows.Forms.TextBox();
            this.lblfk_Person_Role = new System.Windows.Forms.Label();
            this.flwLayout.SuspendLayout();
            this.pnlID.SuspendLayout();
            this.pnlfk_NGO.SuspendLayout();
            this.pnlfk_Person.SuspendLayout();
            this.pnlfk_Person_Role.SuspendLayout();
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
            this.flwLayout.Controls.Add(this.pnlID);
            this.flwLayout.Controls.Add(this.pnlfk_NGO);
            this.flwLayout.Controls.Add(this.pnlfk_Person);
            this.flwLayout.Controls.Add(this.pnlfk_Person_Role);
            this.flwLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwLayout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flwLayout.lable = "";
            this.flwLayout.Location = new System.Drawing.Point(6, 50);
            this.flwLayout.Name = "flwLayout";
            this.flwLayout.Size = new System.Drawing.Size(837, 409);
            this.flwLayout.TabIndex = 11;
            this.flwLayout.WrapContents = false;
            // 
            // pnlID
            // 
            this.pnlID.AutoSize = true;
            this.pnlID.BackColor = System.Drawing.Color.Transparent;
            this.pnlID.Controls.Add(this.txtID);
            this.pnlID.Controls.Add(this.lblID);
            this.pnlID.Location = new System.Drawing.Point(3, 46);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(335, 43);
            this.pnlID.TabIndex = 0;
            this.pnlID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(172, 10);
            this.txtID.MaxLength = 5;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(160, 30);
            this.txtID.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Location = new System.Drawing.Point(10, 10);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(160, 22);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlfk_NGO
            // 
            this.pnlfk_NGO.AutoSize = true;
            this.pnlfk_NGO.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_NGO.Controls.Add(this.txtfk_NGO);
            this.pnlfk_NGO.Controls.Add(this.lblfk_NGO);
            this.pnlfk_NGO.Location = new System.Drawing.Point(3, 95);
            this.pnlfk_NGO.Name = "pnlfk_NGO";
            this.pnlfk_NGO.Size = new System.Drawing.Size(335, 43);
            this.pnlfk_NGO.TabIndex = 0;
            this.pnlfk_NGO.Text = "fk_NGO";
            // 
            // txtfk_NGO
            // 
            this.txtfk_NGO.Location = new System.Drawing.Point(172, 10);
            this.txtfk_NGO.MaxLength = 5;
            this.txtfk_NGO.Name = "txtfk_NGO";
            this.txtfk_NGO.Size = new System.Drawing.Size(160, 30);
            this.txtfk_NGO.TabIndex = 0;
            // 
            // lblfk_NGO
            // 
            this.lblfk_NGO.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_NGO.Location = new System.Drawing.Point(10, 10);
            this.lblfk_NGO.Name = "lblfk_NGO";
            this.lblfk_NGO.Size = new System.Drawing.Size(160, 22);
            this.lblfk_NGO.TabIndex = 0;
            this.lblfk_NGO.Text = "fk_NGO:";
            this.lblfk_NGO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlfk_Person
            // 
            this.pnlfk_Person.AutoSize = true;
            this.pnlfk_Person.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_Person.Controls.Add(this.txtfk_Person);
            this.pnlfk_Person.Controls.Add(this.lblfk_Person);
            this.pnlfk_Person.Location = new System.Drawing.Point(3, 144);
            this.pnlfk_Person.Name = "pnlfk_Person";
            this.pnlfk_Person.Size = new System.Drawing.Size(335, 43);
            this.pnlfk_Person.TabIndex = 0;
            this.pnlfk_Person.Text = "fk_Person";
            // 
            // txtfk_Person
            // 
            this.txtfk_Person.Location = new System.Drawing.Point(172, 10);
            this.txtfk_Person.MaxLength = 5;
            this.txtfk_Person.Name = "txtfk_Person";
            this.txtfk_Person.Size = new System.Drawing.Size(160, 30);
            this.txtfk_Person.TabIndex = 0;
            // 
            // lblfk_Person
            // 
            this.lblfk_Person.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Person.Location = new System.Drawing.Point(10, 10);
            this.lblfk_Person.Name = "lblfk_Person";
            this.lblfk_Person.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Person.TabIndex = 0;
            this.lblfk_Person.Text = "fk_Person:";
            this.lblfk_Person.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlfk_Person_Role
            // 
            this.pnlfk_Person_Role.AutoSize = true;
            this.pnlfk_Person_Role.BackColor = System.Drawing.Color.Transparent;
            this.pnlfk_Person_Role.Controls.Add(this.txtfk_Person_Role);
            this.pnlfk_Person_Role.Controls.Add(this.lblfk_Person_Role);
            this.pnlfk_Person_Role.Location = new System.Drawing.Point(3, 193);
            this.pnlfk_Person_Role.Name = "pnlfk_Person_Role";
            this.pnlfk_Person_Role.Size = new System.Drawing.Size(335, 43);
            this.pnlfk_Person_Role.TabIndex = 0;
            this.pnlfk_Person_Role.Text = "fk_Person_Role";
            // 
            // txtfk_Person_Role
            // 
            this.txtfk_Person_Role.Location = new System.Drawing.Point(172, 10);
            this.txtfk_Person_Role.MaxLength = 5;
            this.txtfk_Person_Role.Name = "txtfk_Person_Role";
            this.txtfk_Person_Role.Size = new System.Drawing.Size(160, 30);
            this.txtfk_Person_Role.TabIndex = 0;
            // 
            // lblfk_Person_Role
            // 
            this.lblfk_Person_Role.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Person_Role.Location = new System.Drawing.Point(10, 10);
            this.lblfk_Person_Role.Name = "lblfk_Person_Role";
            this.lblfk_Person_Role.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Person_Role.TabIndex = 0;
            this.lblfk_Person_Role.Text = "fk_Person_Role:";
            this.lblfk_Person_Role.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NGO_Member_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 510);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flwLayout);
            this.Controls.Add(this.btnOk);
            this.Name = "NGO_Member_Ent";
            this.Load += new System.EventHandler(this.NGO_Member_Ent_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.flwLayout, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.flwLayout.ResumeLayout(false);
            this.flwLayout.PerformLayout();
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.pnlfk_NGO.ResumeLayout(false);
            this.pnlfk_NGO.PerformLayout();
            this.pnlfk_Person.ResumeLayout(false);
            this.pnlfk_Person.PerformLayout();
            this.pnlfk_Person_Role.ResumeLayout(false);
            this.pnlfk_Person_Role.PerformLayout();
            this.ResumeLayout(false);

}//<Control>
 private System.Windows.Forms.Panel pnlID; 
 private System.Windows.Forms.Panel pnlfk_NGO; 
 private System.Windows.Forms.Panel pnlfk_Person;
 private System.Windows.Forms.Panel pnlfk_Person_Role; 

 private System.Windows.Forms.Label  lblID; 
 private System.Windows.Forms.Label  lblfk_NGO; 
 private System.Windows.Forms.Label  lblfk_Person; 
 private System.Windows.Forms.Label  lblfk_Person_Role; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private Bsoft.Controls.LableFlowLayout flwLayout;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtfk_NGO;
        public System.Windows.Forms.TextBox txtfk_Person;
        public System.Windows.Forms.TextBox txtfk_Person_Role;
    }
}
