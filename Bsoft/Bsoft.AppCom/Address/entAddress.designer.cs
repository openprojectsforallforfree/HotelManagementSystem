namespace UEMS
{
    partial class entAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entAddress));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.flwLayout = new Bsoft.Controls.LableFlowLayout();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.pnlCountry = new System.Windows.Forms.Panel();
            this.lblZone = new System.Windows.Forms.Label();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.pnlZone = new System.Windows.Forms.Panel();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.pnlDistrict = new System.Windows.Forms.Panel();
            this.lblLocalBody = new System.Windows.Forms.Label();
            this.txtLocalBody = new System.Windows.Forms.TextBox();
            this.pnlLocalBody = new System.Windows.Forms.Panel();
            this.lblTole = new System.Windows.Forms.Label();
            this.txtTole = new System.Windows.Forms.TextBox();
            this.pnlTole = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlId = new System.Windows.Forms.Panel();
            this.flwLayout.SuspendLayout();
            this.pnlCountry.SuspendLayout();
            this.pnlZone.SuspendLayout();
            this.pnlDistrict.SuspendLayout();
            this.pnlLocalBody.SuspendLayout();
            this.pnlTole.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(358, 426);
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
            this.btnOk.Location = new System.Drawing.Point(264, 426);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // flwLayout
            // 
            this.flwLayout.AutoScroll = true;
            this.flwLayout.BackColor = System.Drawing.Color.Transparent;
            this.flwLayout.Controls.Add(this.pnlId);
            this.flwLayout.Controls.Add(this.pnlTole);
            this.flwLayout.Controls.Add(this.pnlLocalBody);
            this.flwLayout.Controls.Add(this.pnlDistrict);
            this.flwLayout.Controls.Add(this.pnlZone);
            this.flwLayout.Controls.Add(this.pnlCountry);
            this.flwLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwLayout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flwLayout.lable = "Address";
            this.flwLayout.Location = new System.Drawing.Point(12, 30);
            this.flwLayout.Name = "flwLayout";
            this.flwLayout.Size = new System.Drawing.Size(677, 377);
            this.flwLayout.TabIndex = 11;
            this.flwLayout.WrapContents = false;
            // 
            // lblCountry
            // 
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Location = new System.Drawing.Point(10, 10);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(160, 22);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(172, 10);
            this.txtCountry.MaxLength = 15;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(160, 24);
            this.txtCountry.TabIndex = 0;
            // 
            // pnlCountry
            // 
            this.pnlCountry.BackColor = System.Drawing.Color.Transparent;
            this.pnlCountry.Controls.Add(this.txtCountry);
            this.pnlCountry.Controls.Add(this.lblCountry);
            this.pnlCountry.Location = new System.Drawing.Point(3, 301);
            this.pnlCountry.Name = "pnlCountry";
            this.pnlCountry.Size = new System.Drawing.Size(400, 45);
            this.pnlCountry.TabIndex = 0;
            this.pnlCountry.Text = "Country";
            // 
            // lblZone
            // 
            this.lblZone.BackColor = System.Drawing.Color.Transparent;
            this.lblZone.Location = new System.Drawing.Point(10, 10);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(160, 22);
            this.lblZone.TabIndex = 0;
            this.lblZone.Text = "Zone";
            this.lblZone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtZone
            // 
            this.txtZone.Location = new System.Drawing.Point(172, 10);
            this.txtZone.MaxLength = 15;
            this.txtZone.Name = "txtZone";
            this.txtZone.Size = new System.Drawing.Size(160, 24);
            this.txtZone.TabIndex = 0;
            // 
            // pnlZone
            // 
            this.pnlZone.BackColor = System.Drawing.Color.Transparent;
            this.pnlZone.Controls.Add(this.txtZone);
            this.pnlZone.Controls.Add(this.lblZone);
            this.pnlZone.Location = new System.Drawing.Point(3, 250);
            this.pnlZone.Name = "pnlZone";
            this.pnlZone.Size = new System.Drawing.Size(400, 45);
            this.pnlZone.TabIndex = 0;
            this.pnlZone.Text = "Zone";
            // 
            // lblDistrict
            // 
            this.lblDistrict.BackColor = System.Drawing.Color.Transparent;
            this.lblDistrict.Location = new System.Drawing.Point(10, 10);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(160, 22);
            this.lblDistrict.TabIndex = 0;
            this.lblDistrict.Text = "District";
            this.lblDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(172, 10);
            this.txtDistrict.MaxLength = 15;
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(160, 24);
            this.txtDistrict.TabIndex = 0;
            // 
            // pnlDistrict
            // 
            this.pnlDistrict.BackColor = System.Drawing.Color.Transparent;
            this.pnlDistrict.Controls.Add(this.txtDistrict);
            this.pnlDistrict.Controls.Add(this.lblDistrict);
            this.pnlDistrict.Location = new System.Drawing.Point(3, 199);
            this.pnlDistrict.Name = "pnlDistrict";
            this.pnlDistrict.Size = new System.Drawing.Size(400, 45);
            this.pnlDistrict.TabIndex = 0;
            this.pnlDistrict.Text = "District";
            // 
            // lblLocalBody
            // 
            this.lblLocalBody.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalBody.Location = new System.Drawing.Point(10, 10);
            this.lblLocalBody.Name = "lblLocalBody";
            this.lblLocalBody.Size = new System.Drawing.Size(160, 22);
            this.lblLocalBody.TabIndex = 0;
            this.lblLocalBody.Text = "Vdc/ Municipality";
            this.lblLocalBody.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLocalBody
            // 
            this.txtLocalBody.Location = new System.Drawing.Point(172, 10);
            this.txtLocalBody.MaxLength = 15;
            this.txtLocalBody.Name = "txtLocalBody";
            this.txtLocalBody.Size = new System.Drawing.Size(160, 24);
            this.txtLocalBody.TabIndex = 0;
            // 
            // pnlLocalBody
            // 
            this.pnlLocalBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlLocalBody.Controls.Add(this.txtLocalBody);
            this.pnlLocalBody.Controls.Add(this.lblLocalBody);
            this.pnlLocalBody.Location = new System.Drawing.Point(3, 148);
            this.pnlLocalBody.Name = "pnlLocalBody";
            this.pnlLocalBody.Size = new System.Drawing.Size(400, 45);
            this.pnlLocalBody.TabIndex = 0;
            this.pnlLocalBody.Text = "Vdc/ Municipality";
            // 
            // lblTole
            // 
            this.lblTole.BackColor = System.Drawing.Color.Transparent;
            this.lblTole.Location = new System.Drawing.Point(10, 10);
            this.lblTole.Name = "lblTole";
            this.lblTole.Size = new System.Drawing.Size(160, 22);
            this.lblTole.TabIndex = 0;
            this.lblTole.Text = "Tole";
            this.lblTole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTole
            // 
            this.txtTole.Location = new System.Drawing.Point(172, 10);
            this.txtTole.MaxLength = 15;
            this.txtTole.Name = "txtTole";
            this.txtTole.Size = new System.Drawing.Size(160, 24);
            this.txtTole.TabIndex = 0;
            // 
            // pnlTole
            // 
            this.pnlTole.BackColor = System.Drawing.Color.Transparent;
            this.pnlTole.Controls.Add(this.txtTole);
            this.pnlTole.Controls.Add(this.lblTole);
            this.pnlTole.Location = new System.Drawing.Point(3, 97);
            this.pnlTole.Name = "pnlTole";
            this.pnlTole.Size = new System.Drawing.Size(400, 45);
            this.pnlTole.TabIndex = 0;
            this.pnlTole.Text = "Tole";
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(10, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(160, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(172, 10);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 24);
            this.txtId.TabIndex = 0;
            // 
            // pnlId
            // 
            this.pnlId.BackColor = System.Drawing.Color.Transparent;
            this.pnlId.Controls.Add(this.txtId);
            this.pnlId.Controls.Add(this.lblId);
            this.pnlId.Location = new System.Drawing.Point(3, 46);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(400, 45);
            this.pnlId.TabIndex = 0;
            this.pnlId.Text = "Id";
            // 
            // entAddress
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 464);
            this.Controls.Add(this.flwLayout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "entAddress";
           
            this.Text = "Address";
            this.Load += new System.EventHandler(this.entAddress_Load);
            this.flwLayout.ResumeLayout(false);
            this.pnlCountry.ResumeLayout(false);
            this.pnlCountry.PerformLayout();
            this.pnlZone.ResumeLayout(false);
            this.pnlZone.PerformLayout();
            this.pnlDistrict.ResumeLayout(false);
            this.pnlDistrict.PerformLayout();
            this.pnlLocalBody.ResumeLayout(false);
            this.pnlLocalBody.PerformLayout();
            this.pnlTole.ResumeLayout(false);
            this.pnlTole.PerformLayout();
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.ResumeLayout(false);

        }//<Control>                  
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        public Bsoft.Controls.LableFlowLayout flwLayout;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlTole;
        private System.Windows.Forms.TextBox txtTole;
        private System.Windows.Forms.Label lblTole;
        private System.Windows.Forms.Panel pnlLocalBody;
        private System.Windows.Forms.TextBox txtLocalBody;
        private System.Windows.Forms.Label lblLocalBody;
        private System.Windows.Forms.Panel pnlDistrict;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Panel pnlZone;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.Panel pnlCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
    }
}
