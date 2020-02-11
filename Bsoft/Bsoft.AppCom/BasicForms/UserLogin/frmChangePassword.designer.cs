namespace UEMS.Forms.UserLogin
{
    partial class frmChangePassword
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblNewPwConfirm = new System.Windows.Forms.Label();
            this.lblOldPw = new System.Windows.Forms.Label();
            this.lblNewpw = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtOldPasswordc = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdCancel = new bsoftcontrols.fsButton();
            this.cmdOk = new bsoftcontrols.fsButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(520, 2);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.txtOldPassword);
            this.groupBox1.Controls.Add(this.lblNewPwConfirm);
            this.groupBox1.Controls.Add(this.lblOldPw);
            this.groupBox1.Controls.Add(this.lblNewpw);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.txtOldPasswordc);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(70, 31);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(148, 19);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User Name ";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOldPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(240, 25);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.ReadOnly = true;
            this.txtOldPassword.Size = new System.Drawing.Size(235, 27);
            this.txtOldPassword.TabIndex = 2;
            // 
            // lblNewPwConfirm
            // 
            this.lblNewPwConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPwConfirm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPwConfirm.Location = new System.Drawing.Point(70, 145);
            this.lblNewPwConfirm.Name = "lblNewPwConfirm";
            this.lblNewPwConfirm.Size = new System.Drawing.Size(148, 19);
            this.lblNewPwConfirm.TabIndex = 7;
            this.lblNewPwConfirm.Text = " Re-Enter Password ";
            this.lblNewPwConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOldPw
            // 
            this.lblOldPw.BackColor = System.Drawing.Color.Transparent;
            this.lblOldPw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPw.Location = new System.Drawing.Point(70, 69);
            this.lblOldPw.Name = "lblOldPw";
            this.lblOldPw.Size = new System.Drawing.Size(148, 19);
            this.lblOldPw.TabIndex = 4;
            this.lblOldPw.Text = "Old Password ";
            this.lblOldPw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNewpw
            // 
            this.lblNewpw.BackColor = System.Drawing.Color.Transparent;
            this.lblNewpw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewpw.Location = new System.Drawing.Point(70, 107);
            this.lblNewpw.Name = "lblNewpw";
            this.lblNewpw.Size = new System.Drawing.Size(148, 19);
            this.lblNewpw.TabIndex = 4;
            this.lblNewpw.Text = "New Password ";
            this.lblNewpw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(240, 138);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(235, 27);
            this.txtConfirmPassword.TabIndex = 8;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtOldPasswordc
            // 
            this.txtOldPasswordc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPasswordc.Location = new System.Drawing.Point(240, 66);
            this.txtOldPasswordc.Name = "txtOldPasswordc";
            this.txtOldPasswordc.PasswordChar = '*';
            this.txtOldPasswordc.Size = new System.Drawing.Size(235, 27);
            this.txtOldPasswordc.TabIndex = 5;
            this.txtOldPasswordc.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(240, 102);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(235, 27);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.cmdCancel.FlatAppearance.BorderSize = 0;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Mangal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmdCancel.Location = new System.Drawing.Point(280, 279);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(0);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(90, 31);
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.cmdOk.FlatAppearance.BorderSize = 0;
            this.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOk.Font = new System.Drawing.Font("Mangal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmdOk.Location = new System.Drawing.Point(181, 279);
            this.cmdOk.Margin = new System.Windows.Forms.Padding(0);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(90, 31);
            this.cmdOk.TabIndex = 9;
            this.cmdOk.Text = "Ok";
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // frmChangePassword
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 320);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsQuickSaveKey = false;
            this.Name = "frmChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cmdOk, 0);
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNewPwConfirm;
        private System.Windows.Forms.Label lblNewpw;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private bsoftcontrols.fsButton cmdCancel;
        private bsoftcontrols.fsButton cmdOk;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblOldPw;
        private System.Windows.Forms.TextBox txtOldPasswordc;
    }
}
