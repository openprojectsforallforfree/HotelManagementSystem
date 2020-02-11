namespace Bsoft.Controls
{
    partial class lblTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLable = new System.Windows.Forms.Label();
            this.vtxtBox = new Bsoft.Controls.VtextBox();
            this.SuspendLayout();
            // 
            // lblLable
            // 
            this.lblLable.AutoEllipsis = true;
            this.lblLable.Location = new System.Drawing.Point(6, 0);
            this.lblLable.Name = "lblLable";
            this.lblLable.Size = new System.Drawing.Size(162, 25);
            this.lblLable.TabIndex = 0;
            this.lblLable.Text = "Lable :";
            this.lblLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLable.Click += new System.EventHandler(this.lblLable_Click);
            // 
            // vtxtBox
            // 
            this.vtxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.vtxtBox.Location = new System.Drawing.Point(172, 1);
            this.vtxtBox.Name = "vtxtBox";
            this.vtxtBox.Size = new System.Drawing.Size(246, 23);
            this.vtxtBox.TabIndex = 1;
            this.vtxtBox.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.vtxtBox.Value = "";
            // 
            // lblTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.vtxtBox);
            this.Controls.Add(this.lblLable);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "lblTextBox";
            this.Size = new System.Drawing.Size(421, 25);
            this.Resize += new System.EventHandler(this.lblTextBox_Resize);
            this.Enter += new System.EventHandler(this.lblTextBox_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblLable;
        public VtextBox vtxtBox;

    }
}
