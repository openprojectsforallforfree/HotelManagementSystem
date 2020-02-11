namespace UEMS
{
    partial class WorkDone_NGO_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkDone_NGO_Ent));
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
            this.flwLayout.lable = "संस्थाको सञ्चालन गरको प्रमुख कार्यक्रमहरु ";
            this.flwLayout.Location = new System.Drawing.Point(6, 50);
            this.flwLayout.Name = "flwLayout";
            this.flwLayout.Size = new System.Drawing.Size(837, 409);
            this.flwLayout.TabIndex = 11;
            this.flwLayout.WrapContents = false;
            // 
            // WorkDone_NGO_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 510);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flwLayout);
            this.Controls.Add(this.btnOk);
            this.Name = "WorkDone_NGO_Ent";
            this.Text = "संस्थाको सञ्चालन गरको प्रमुख कार्यक्रमहरु ";
            this.Load += new System.EventHandler(this.WorkDone_NGO_Ent_Load);
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
// lblNGO_ID
// 
this.pnlNGO_ID = new System.Windows.Forms.Panel();
this.pnlNGO_ID.BackColor = System.Drawing.Color.Transparent;
this.pnlNGO_ID.Location =new System.Drawing.Point(100, 122);
this.pnlNGO_ID.Name ="pnlNGO_ID";
this.pnlNGO_ID.Size = new System.Drawing.Size(400, 45);
this.pnlNGO_ID.TabIndex = 0;
this.pnlNGO_ID .AutoSize = true;
 this.pnlNGO_ID .Text = "NGO_ID";
 this.flwLayout.Controls.Add(this.pnlNGO_ID);
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
//txtNGO_ID
// 
 this.txtNGO_ID = new System.Windows.Forms.TextBox();
 this.txtNGO_ID .Location = new System.Drawing.Point(172, 10);
 this.txtNGO_ID .Name = "txtNGO_ID";
 this.txtNGO_ID .Size = new System.Drawing.Size(160, 20);
 this.txtNGO_ID .TabIndex = 0;
 this.pnlNGO_ID.Controls.Add(this.txtNGO_ID);
// 
//txtfk_WorkDone
// 
 this.txtfk_WorkDone = new System.Windows.Forms.TextBox();
 this.txtfk_WorkDone .Location = new System.Drawing.Point(172, 10);
 this.txtfk_WorkDone .Name = "txtfk_WorkDone";
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
// lblNGO_ID
// 
this.lblNGO_ID = new System.Windows.Forms.Label();
this.lblNGO_ID.BackColor = System.Drawing.Color.Transparent;
this.lblNGO_ID.Location =new System.Drawing.Point(10, 10);
this.lblNGO_ID.Name ="lblNGO_ID";
this.lblNGO_ID.Size = new System.Drawing.Size(160, 22);
this.lblNGO_ID.TabIndex = 0;
 this.lblNGO_ID .Text = "NGO_ID:";
this.lblNGO_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
 this.pnlNGO_ID.Controls.Add(this.lblNGO_ID);
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
 private System.Windows.Forms.Panel pnlNGO_ID; 
 private System.Windows.Forms.Panel pnlfk_WorkDone; 

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtNGO_ID; 
 private System.Windows.Forms.TextBox txtfk_WorkDone; 

 private System.Windows.Forms.Label  lblId; 
 private System.Windows.Forms.Label  lblNGO_ID; 
 private System.Windows.Forms.Label  lblfk_WorkDone; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private Bsoft.Controls.LableFlowLayout flwLayout;
    }
}
