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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelLoading = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.14006F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.85994F));
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 9);
            this.tableLayoutPanel.Controls.Add(this.labelLoading, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 2, 6);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 9;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.84783F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.76087F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.93478F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.84783F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(467, 312);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Click += new System.EventHandler(this.tableLayoutPanel_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.ForeColor = System.Drawing.Color.Black;
            this.labelVersion.Location = new System.Drawing.Point(254, 116);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(210, 17);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelVersion.Click += new System.EventHandler(this.textBoxDescription_Click);
            // 
            // labelProductName
            // 
            this.labelProductName.BackColor = System.Drawing.Color.Transparent;
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.ForeColor = System.Drawing.Color.Black;
            this.labelProductName.Location = new System.Drawing.Point(254, 89);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(210, 17);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelProductName.Click += new System.EventHandler(this.textBoxDescription_Click);
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCompanyName.ForeColor = System.Drawing.Color.Black;
            this.labelCompanyName.Location = new System.Drawing.Point(34, 0);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(211, 17);
            this.labelCompanyName.TabIndex = 22;
            this.labelCompanyName.Text = "Company Name";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCompanyName.Click += new System.EventHandler(this.textBoxDescription_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::UEMS.Properties.Resources.index1;
            this.logoPictureBox.Location = new System.Drawing.Point(31, 64);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 5);
            this.logoPictureBox.Size = new System.Drawing.Size(214, 180);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.labelCopyright, 2);
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.ForeColor = System.Drawing.Color.Black;
            this.labelCopyright.Location = new System.Drawing.Point(34, 287);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(430, 17);
            this.labelCopyright.TabIndex = 25;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLoading
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelLoading, 2);
            this.labelLoading.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelLoading.Location = new System.Drawing.Point(12, 31);
            this.labelLoading.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(219, 28);
            this.labelLoading.TabIndex = 27;
            this.labelLoading.Text = "Loading : ...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLoading.Click += new System.EventHandler(this.textBoxDescription_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.Transparent;
            this.textBoxDescription.ForeColor = System.Drawing.Color.Black;
            this.textBoxDescription.Location = new System.Drawing.Point(251, 178);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(213, 66);
            this.textBoxDescription.TabIndex = 28;
            this.textBoxDescription.Text = "Description";
            this.textBoxDescription.Click += new System.EventHandler(this.textBoxDescription_Click);
            // 
            // frmAboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 330);
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UEMS Systems ";
            this.Load += new System.EventHandler(this.frmAboutBox_Load);
            this.Activated += new System.EventHandler(this.frmAboutBox_Activated);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Label textBoxDescription;
    }
}
