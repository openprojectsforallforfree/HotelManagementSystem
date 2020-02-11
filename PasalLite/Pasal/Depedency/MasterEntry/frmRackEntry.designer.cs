namespace Pasal.MasterEntry
{
    partial class frmRackEntry
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
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRackNumber = new Bsoft.Controls.NumericTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblRackNumber = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.Location = new System.Drawing.Point(482, 7);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(283, 206);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 6;
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
            this.btnOk.Location = new System.Drawing.Point(176, 206);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.ThemeColor = System.Drawing.Color.Blue;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtRackNumber);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.lblRackNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtRackNumber
            // 
            this.txtRackNumber.Location = new System.Drawing.Point(252, 46);
            this.txtRackNumber.Name = "txtRackNumber";
            this.txtRackNumber.Size = new System.Drawing.Size(160, 24);
            this.txtRackNumber.TabIndex = 1;
            this.txtRackNumber.Text = "";
            this.txtRackNumber.ValidationType = Bsoft.Controls.NumericTextBox.ValidationTypeEnum.Integer;
            this.txtRackNumber.Value = "";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(252, 16);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(160, 24);
            this.txtid.TabIndex = 1;
            this.txtid.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(252, 76);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(210, 24);
            this.txtDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Location = new System.Drawing.Point(72, 76);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(160, 22);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblid
            // 
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Location = new System.Drawing.Point(72, 16);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(160, 22);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "id:";
            this.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblid.Visible = false;
            // 
            // lblRackNumber
            // 
            this.lblRackNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRackNumber.Location = new System.Drawing.Point(72, 46);
            this.lblRackNumber.Name = "lblRackNumber";
            this.lblRackNumber.Size = new System.Drawing.Size(160, 22);
            this.lblRackNumber.TabIndex = 0;
            this.lblRackNumber.Text = "RackNumber:";
            this.lblRackNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmRackEntry
            // 
            this.ClientSize = new System.Drawing.Size(536, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "frmRackEntry";
            this.Text = "Rack Entry";
            this.Load += new System.EventHandler(this.Entry_Load);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;

        private System.Windows.Forms.TextBox txtDescription;


        private System.Windows.Forms.Label lblid;


        private System.Windows.Forms.Label lblRackNumber;

        private System.Windows.Forms.Label lblDescription; 


        public bsoftcontrols.fsButton btnCancel;
        public bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bsoft.Controls.NumericTextBox txtRackNumber;
    }
}
