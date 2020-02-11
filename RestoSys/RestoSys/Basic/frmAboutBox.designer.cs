namespace UEMS
{
   public  partial class frmAboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAboutBox));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelLoading = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.txtPw = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = global::RestoSys.Properties.Resources.slashDot;
            this.logoPictureBox.Location = new System.Drawing.Point(126, 112);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(148, 114);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // labelLoading
            // 
            this.labelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoading.BackColor = System.Drawing.Color.Transparent;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.Yellow;
            this.labelLoading.Location = new System.Drawing.Point(57, 37);
            this.labelLoading.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(465, 28);
            this.labelLoading.TabIndex = 27;
            this.labelLoading.Text = "Loading : ...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLoading.Click += new System.EventHandler(this.textBoxDescription_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.BackColor = System.Drawing.Color.Transparent;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.ForeColor = System.Drawing.Color.White;
            this.textBoxDescription.Location = new System.Drawing.Point(280, 188);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(242, 54);
            this.textBoxDescription.TabIndex = 28;
            this.textBoxDescription.Text = "Description";
            this.textBoxDescription.Click += new System.EventHandler(this.textBoxDescription_Click);
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductName.BackColor = System.Drawing.Color.Transparent;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.Color.White;
            this.labelProductName.Location = new System.Drawing.Point(280, 132);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(242, 28);
            this.labelProductName.TabIndex = 28;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.Click += new System.EventHandler(this.textBoxDescription_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(280, 160);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(242, 28);
            this.labelVersion.TabIndex = 28;
            this.labelVersion.Text = "Version";
            this.labelVersion.Click += new System.EventHandler(this.labelVersion_Click);
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(13, 273);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(506, 28);
            this.labelCopyright.TabIndex = 28;
            this.labelCopyright.Text = "Copy Right";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelCopyright.Click += new System.EventHandler(this.textBoxDescription_Click);
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.labelCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.ForeColor = System.Drawing.Color.White;
            this.labelCompanyName.Location = new System.Drawing.Point(12, 9);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(510, 28);
            this.labelCompanyName.TabIndex = 28;
            this.labelCompanyName.Text = "Company Name";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCompanyName.Click += new System.EventHandler(this.textBoxDescription_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(228, 310);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Close";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(493, 109);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '|';
            this.txtPw.Size = new System.Drawing.Size(18, 20);
            this.txtPw.TabIndex = 30;
            this.txtPw.Visible = false;
            this.txtPw.TextChanged += new System.EventHandler(this.txtPw_TextChanged);
            // 
            // frmAboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 348);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxDescription);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UEMS Systems ";
            this.Load += new System.EventHandler(this.frmAboutBox_Load);
            this.Activated += new System.EventHandler(this.frmAboutBox_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Label textBoxDescription;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private bsoftcontrols.fsButton btnCancel;
        private System.Windows.Forms.TextBox txtPw;
    }
}
