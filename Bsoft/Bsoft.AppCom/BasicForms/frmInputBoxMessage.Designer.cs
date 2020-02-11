namespace UEMS
{
    partial class frmInputBoxMessage
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
            this.txtnputBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(557, 2);
            // 
            // btnOk
            // 
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(256, 192);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 41;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtnputBox
            // 
            this.txtnputBox.Location = new System.Drawing.Point(172, 162);
            this.txtnputBox.Name = "txtnputBox";
            this.txtnputBox.Size = new System.Drawing.Size(376, 23);
            this.txtnputBox.TabIndex = 40;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(12, 162);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(154, 23);
            this.Label4.TabIndex = 39;
            this.Label4.Text = "Registration Key";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Location = new System.Drawing.Point(12, 50);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(567, 96);
            this.lblMessage.TabIndex = 39;
            this.lblMessage.Text = "Registration Key";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // frmInputBoxMessage
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 234);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtnputBox);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.Label4);
            this.Name = "frmInputBoxMessage";
            this.Text = "Message ";
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.txtnputBox, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public bsoftcontrols.fsButton btnOk;
        internal System.Windows.Forms.TextBox txtnputBox;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblMessage;
    }
}
