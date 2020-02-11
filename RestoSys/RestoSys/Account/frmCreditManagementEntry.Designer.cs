namespace RestoSys.Account
{
    partial class frmCreditManagementEntry
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
            this.txtPayBackAmount = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblPayBackAmount = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtcustomerId = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblcust_name = new System.Windows.Forms.Label();
            this.lblcust_address = new System.Windows.Forms.Label();
            this.lblcust_userid = new System.Windows.Forms.Label();
            this.lblsale_dueAmount = new System.Windows.Forms.Label();
            this.lblsale_CreditAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(432, 2);
            // 
            // txtPayBackAmount
            // 
            this.txtPayBackAmount.Location = new System.Drawing.Point(200, 227);
            this.txtPayBackAmount.Name = "txtPayBackAmount";
            this.txtPayBackAmount.Size = new System.Drawing.Size(160, 30);
            this.txtPayBackAmount.TabIndex = 1;
            this.txtPayBackAmount.Text = "0";
            this.txtPayBackAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(200, 257);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(160, 49);
            this.txtRemarks.TabIndex = 2;
            // 
            // lblPayBackAmount
            // 
            this.lblPayBackAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPayBackAmount.Location = new System.Drawing.Point(34, 227);
            this.lblPayBackAmount.Name = "lblPayBackAmount";
            this.lblPayBackAmount.Size = new System.Drawing.Size(160, 22);
            this.lblPayBackAmount.TabIndex = 0;
            this.lblPayBackAmount.Text = "Pay Back Amount :";
            this.lblPayBackAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Location = new System.Drawing.Point(34, 257);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(160, 22);
            this.lblRemarks.TabIndex = 0;
            this.lblRemarks.Text = "Remarks :";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(247, 327);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeColor = System.Drawing.Color.Blue;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(142, 327);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.ThemeColor = System.Drawing.Color.Blue;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtcustomerId
            // 
            this.txtcustomerId.Location = new System.Drawing.Point(408, 276);
            this.txtcustomerId.Name = "txtcustomerId";
            this.txtcustomerId.Size = new System.Drawing.Size(160, 30);
            this.txtcustomerId.TabIndex = 1;
            this.txtcustomerId.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(408, 246);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(160, 30);
            this.txtid.TabIndex = 1;
            this.txtid.Visible = false;
            // 
            // lblcust_name
            // 
            this.lblcust_name.BackColor = System.Drawing.Color.Transparent;
            this.lblcust_name.Location = new System.Drawing.Point(210, 13);
            this.lblcust_name.Name = "lblcust_name";
            this.lblcust_name.Size = new System.Drawing.Size(160, 22);
            this.lblcust_name.TabIndex = 0;
            this.lblcust_name.Text = "Name";
            this.lblcust_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcust_address
            // 
            this.lblcust_address.BackColor = System.Drawing.Color.Transparent;
            this.lblcust_address.Location = new System.Drawing.Point(210, 41);
            this.lblcust_address.Name = "lblcust_address";
            this.lblcust_address.Size = new System.Drawing.Size(160, 22);
            this.lblcust_address.TabIndex = 0;
            this.lblcust_address.Text = "Address";
            this.lblcust_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcust_userid
            // 
            this.lblcust_userid.BackColor = System.Drawing.Color.Transparent;
            this.lblcust_userid.Location = new System.Drawing.Point(210, 69);
            this.lblcust_userid.Name = "lblcust_userid";
            this.lblcust_userid.Size = new System.Drawing.Size(160, 22);
            this.lblcust_userid.TabIndex = 0;
            this.lblcust_userid.Text = "Userid";
            this.lblcust_userid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsale_dueAmount
            // 
            this.lblsale_dueAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblsale_dueAmount.Location = new System.Drawing.Point(210, 97);
            this.lblsale_dueAmount.Name = "lblsale_dueAmount";
            this.lblsale_dueAmount.Size = new System.Drawing.Size(160, 22);
            this.lblsale_dueAmount.TabIndex = 0;
            this.lblsale_dueAmount.Text = "Due Amount";
            this.lblsale_dueAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsale_CreditAmount
            // 
            this.lblsale_CreditAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblsale_CreditAmount.Location = new System.Drawing.Point(210, 125);
            this.lblsale_CreditAmount.Name = "lblsale_CreditAmount";
            this.lblsale_CreditAmount.Size = new System.Drawing.Size(160, 22);
            this.lblsale_CreditAmount.TabIndex = 0;
            this.lblsale_CreditAmount.Text = "Credit Amount";
            this.lblsale_CreditAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(33, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit Amount :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Due Amount :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(33, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Userid :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(33, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(33, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = " Name :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblsale_CreditAmount);
            this.groupBox1.Controls.Add(this.lblsale_dueAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblcust_userid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblcust_address);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblcust_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 168);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // frmCreditManagementEntry
            // 
            this.AcceptButton = this.btnOk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPayBackAmount);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtcustomerId);
            this.Controls.Add(this.txtPayBackAmount);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtRemarks);
            this.Name = "frmCreditManagementEntry";
            this.Text = "Credit PayBack";
            this.Load += new System.EventHandler(this.frmCreditManagementEntry_Load);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.lblRemarks, 0);
            this.Controls.SetChildIndex(this.txtPayBackAmount, 0);
            this.Controls.SetChildIndex(this.txtcustomerId, 0);
            this.Controls.SetChildIndex(this.txtid, 0);
            this.Controls.SetChildIndex(this.lblPayBackAmount, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblcust_name;


        private System.Windows.Forms.Label lblcust_address;

        private System.Windows.Forms.Label lblcust_userid;

        private System.Windows.Forms.Label lblsale_dueAmount;

        private System.Windows.Forms.Label lblsale_CreditAmount; 
        private System.Windows.Forms.Label lblPayBackAmount;


        private System.Windows.Forms.Label lblRemarks; 
        private System.Windows.Forms.TextBox txtPayBackAmount;


        private System.Windows.Forms.TextBox txtRemarks; 

        #endregion
        public bsoftcontrols.fsButton btnCancel;
        public bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.TextBox txtcustomerId;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
