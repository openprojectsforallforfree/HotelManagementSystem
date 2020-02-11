namespace Bsoft.AppCom
{
    partial class frmRegister
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
            this.txtRegistrationKey = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picIsRegistered = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIsRegistered)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(498, 2);
            // 
            // txtRegistrationKey
            // 
            this.txtRegistrationKey.Location = new System.Drawing.Point(207, 76);
            this.txtRegistrationKey.Name = "txtRegistrationKey";
            this.txtRegistrationKey.Size = new System.Drawing.Size(253, 23);
            this.txtRegistrationKey.TabIndex = 33;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(53, 72);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(137, 30);
            this.Label4.TabIndex = 31;
            this.Label4.Text = "Registration Key";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(173, 125);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 38;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(282, 125);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picIsRegistered
            // 
            this.picIsRegistered.BackColor = System.Drawing.Color.Transparent;
            this.picIsRegistered.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIsRegistered.Location = new System.Drawing.Point(470, 79);
            this.picIsRegistered.Name = "picIsRegistered";
            this.picIsRegistered.Size = new System.Drawing.Size(23, 20);
            this.picIsRegistered.TabIndex = 39;
            this.picIsRegistered.TabStop = false;
            // 
            // frmRegister
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 177);
            this.Controls.Add(this.txtRegistrationKey);
            this.Controls.Add(this.picIsRegistered);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.Label4);
            this.Name = "frmRegister";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.picIsRegistered, 0);
            this.Controls.SetChildIndex(this.txtRegistrationKey, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picIsRegistered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtRegistrationKey;
        internal System.Windows.Forms.Label Label4;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picIsRegistered;
    }
}
