namespace Friuts
{
    partial class frmProgressBar
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
            this.txtCompleated = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fsButton1 = new bsoftcontrols.fsButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
           
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtCompleated);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtCompleated
            // 
            this.txtCompleated.BackColor = System.Drawing.Color.Gray;
            this.txtCompleated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompleated.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompleated.ForeColor = System.Drawing.Color.Gold;
            this.txtCompleated.Location = new System.Drawing.Point(14, 51);
            this.txtCompleated.Name = "txtCompleated";
            this.txtCompleated.ReadOnly = true;
            this.txtCompleated.Size = new System.Drawing.Size(494, 24);
            this.txtCompleated.TabIndex = 4;
            this.txtCompleated.Text = "s[kof kltIff ug{\'xf];\\ M ===";
            this.txtCompleated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Gray;
            this.progressBar1.ForeColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(13, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(495, 27);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 2;
            // 
            // fsButton1
            // 
            this.fsButton1.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.fsButton1.FlatAppearance.BorderSize = 0;
            this.fsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fsButton1.Location = new System.Drawing.Point(490, 52);
            this.fsButton1.Name = "fsButton1";
            this.fsButton1.Size = new System.Drawing.Size(42, 20);
            this.fsButton1.TabIndex = 2;
            this.fsButton1.Text = "fsButton1";
            // 
            // frmProgressBar
            // 
            this.BackgroundImage = global::Friuts.Properties.Resources._unchecked;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 155);
            this.Controls.Add(this.fsButton1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProgressBar";
           
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.fsButton1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompleated;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.GroupBox groupBox1;
        private bsoftcontrols.fsButton fsButton1;
    }
}
