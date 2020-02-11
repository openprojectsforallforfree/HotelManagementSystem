namespace UEMS
{
    partial class NGO_YearlyReport_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NGO_YearlyReport_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.flwLayout = new Bsoft.Controls.LableFlowLayout();
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
            this.flwLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwLayout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flwLayout.lable = "";
            this.flwLayout.Location = new System.Drawing.Point(6, 50);
            this.flwLayout.Name = "flwLayout";
            this.flwLayout.Size = new System.Drawing.Size(837, 409);
            this.flwLayout.TabIndex = 11;
            this.flwLayout.WrapContents = false;
            // 
            // NGO_YearlyReport_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 510);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flwLayout);
            this.Controls.Add(this.btnOk);
            this.Name = "NGO_YearlyReport_Ent";
            this.Text = "";
            this.Load += new System.EventHandler(this.NGO_YearlyReport_Ent_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.flwLayout, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.ResumeLayout(false);

        // 
// lblId
// 
this.pnlId = new System.Windows.Forms.Panel();
this.pnlId.BackColor = System.Drawing.Color.Transparent;
this.pnlId.Location =new System.Drawing.Point(100, 72);
this.pnlId.Name ="pnlId";
this.pnlId.Size = new System.Drawing.Size(400, 45);
this.pnlId.TabIndex = 0;
this.pnlId .AutoSize = true;
 this.pnlId .Text = "Id";
 this.flwLayout.Controls.Add(this.pnlId);
// 
// lblfk_NGO
// 
this.pnlfk_NGO = new System.Windows.Forms.Panel();
this.pnlfk_NGO.BackColor = System.Drawing.Color.Transparent;
this.pnlfk_NGO.Location =new System.Drawing.Point(100, 122);
this.pnlfk_NGO.Name ="pnlfk_NGO";
this.pnlfk_NGO.Size = new System.Drawing.Size(400, 45);
this.pnlfk_NGO.TabIndex = 0;
this.pnlfk_NGO .AutoSize = true;
 this.pnlfk_NGO .Text = "fk_NGO";
 this.flwLayout.Controls.Add(this.pnlfk_NGO);
// 
// lblfk_WorkDone
// 
this.pnlfk_WorkDone = new System.Windows.Forms.Panel();
this.pnlfk_WorkDone.BackColor = System.Drawing.Color.Transparent;
this.pnlfk_WorkDone.Location =new System.Drawing.Point(100, 172);
this.pnlfk_WorkDone.Name ="pnlfk_WorkDone";
this.pnlfk_WorkDone.Size = new System.Drawing.Size(400, 45);
this.pnlfk_WorkDone.TabIndex = 0;
this.pnlfk_WorkDone .AutoSize = true;
 this.pnlfk_WorkDone .Text = "fk_WorkDone";
 this.flwLayout.Controls.Add(this.pnlfk_WorkDone);

// 
//txtId
// 
 this.txtId = new System.Windows.Forms.TextBox();
 this.txtId .Location = new System.Drawing.Point(172, 10);
 this.txtId .Name = "txtId";
 this.txtId .Size = new System.Drawing.Size(160, 20);
 this.txtId .TabIndex = 0;
 this.pnlId.Controls.Add(this.txtId);
// 
//txtfk_NGO
// 
 this.txtfk_NGO = new System.Windows.Forms.TextBox();
 this.txtfk_NGO .Location = new System.Drawing.Point(172, 10);
 this.txtfk_NGO .Name = "txtfk_NGO";
 this.txtfk_NGO .MaxLength = 5;
 this.txtfk_NGO .Size = new System.Drawing.Size(160, 20);
 this.txtfk_NGO .TabIndex = 0;
 this.pnlfk_NGO.Controls.Add(this.txtfk_NGO);
// 
//txtfk_WorkDone
// 
 this.txtfk_WorkDone = new System.Windows.Forms.TextBox();
 this.txtfk_WorkDone .Location = new System.Drawing.Point(172, 10);
 this.txtfk_WorkDone .Name = "txtfk_WorkDone";
 this.txtfk_WorkDone .MaxLength = 5;
 this.txtfk_WorkDone .Size = new System.Drawing.Size(160, 20);
 this.txtfk_WorkDone .TabIndex = 0;
 this.pnlfk_WorkDone.Controls.Add(this.txtfk_WorkDone);

// 
// lblId
// 
this.lblId = new System.Windows.Forms.Label();
this.lblId.BackColor = System.Drawing.Color.Transparent;
this.lblId.Location =new System.Drawing.Point(10, 10);
this.lblId.Name ="lblId";
this.lblId.Size = new System.Drawing.Size(160, 22);
this.lblId.TabIndex = 0;
 this.lblId .Text = "Id:";
this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlId.Controls.Add(this.lblId);
// 
// lblfk_NGO
// 
this.lblfk_NGO = new System.Windows.Forms.Label();
this.lblfk_NGO.BackColor = System.Drawing.Color.Transparent;
this.lblfk_NGO.Location =new System.Drawing.Point(10, 10);
this.lblfk_NGO.Name ="lblfk_NGO";
this.lblfk_NGO.Size = new System.Drawing.Size(160, 22);
this.lblfk_NGO.TabIndex = 0;
 this.lblfk_NGO .Text = "fk_NGO:";
this.lblfk_NGO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlfk_NGO.Controls.Add(this.lblfk_NGO);
// 
// lblfk_WorkDone
// 
this.lblfk_WorkDone = new System.Windows.Forms.Label();
this.lblfk_WorkDone.BackColor = System.Drawing.Color.Transparent;
this.lblfk_WorkDone.Location =new System.Drawing.Point(10, 10);
this.lblfk_WorkDone.Name ="lblfk_WorkDone";
this.lblfk_WorkDone.Size = new System.Drawing.Size(160, 22);
this.lblfk_WorkDone.TabIndex = 0;
 this.lblfk_WorkDone .Text = "fk_WorkDone:";
this.lblfk_WorkDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlfk_WorkDone.Controls.Add(this.lblfk_WorkDone);

}//<Control>
 private System.Windows.Forms.Panel pnlId; 
 private System.Windows.Forms.Panel pnlfk_NGO; 
 private System.Windows.Forms.Panel pnlfk_WorkDone; 

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtfk_NGO; 
 private System.Windows.Forms.TextBox txtfk_WorkDone; 

 private System.Windows.Forms.Label  lblId; 
 private System.Windows.Forms.Label  lblfk_NGO; 
 private System.Windows.Forms.Label  lblfk_WorkDone; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private Bsoft.Controls.LableFlowLayout flwLayout;
    }
}
