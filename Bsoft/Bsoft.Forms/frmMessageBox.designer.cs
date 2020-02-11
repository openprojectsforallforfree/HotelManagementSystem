namespace Bsoft.Forms
{
    partial class frmMessageBox : Bsoft .Design .FormDesginBase 
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
            this.btnOk = new bsoftcontrols.fsButton();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnNo = new bsoftcontrols.fsButton();
            this.btnYes = new bsoftcontrols.fsButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            //this._closeButton.FlatAppearance.BorderSize = 0;
            //this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            //this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            //this._closeButton.Location = new System.Drawing.Point(415, 2);
            // 
            // btnOk
            // 
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(165, 5);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 25);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(245, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // btnNo
            // 
            this.btnNo.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNo.Location = new System.Drawing.Point(85, 5);
            this.btnNo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(70, 25);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnYes.Location = new System.Drawing.Point(5, 5);
            this.btnYes.Margin = new System.Windows.Forms.Padding(5);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(70, 25);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btnYes);
            this.flowLayoutPanel1.Controls.Add(this.btnNo);
            this.flowLayoutPanel1.Controls.Add(this.btnOk);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(71, 177);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(323, 35);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            //this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(2, 57);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(445, 98);
            this.lblMessage.TabIndex = 26;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Message";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // frmMessageBox
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblMessage);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 325);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(396, 187);
            this.Name = "frmMessageBox";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Attention Please";
            this.Load += new System.EventHandler(this.frmMessageBox_Load);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
          //  this.Controls.SetChildIndex(this._closeButton, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bsoftcontrols.fsButton btnNo;
        private bsoftcontrols.fsButton btnYes;
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
       // private SunriseSys.CommonControls.CustomToolTip customToolTip1;
    }
}
