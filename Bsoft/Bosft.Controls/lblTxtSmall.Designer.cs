namespace UEMS
{
    partial class lblTxtSmall
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lblLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(0, 26);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(85, 22);
            this.txtBox.TabIndex = 3;
            // 
            // lblLable
            // 
            this.lblLable.Location = new System.Drawing.Point(1, 3);
            this.lblLable.Name = "lblLable";
            this.lblLable.Size = new System.Drawing.Size(78, 23);
            this.lblLable.TabIndex = 2;
            this.lblLable.Text = "Lable :";
            this.lblLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTxtSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblLable);
            this.Name = "lblTxtSmall";
            this.Size = new System.Drawing.Size(85, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtBox;
        public System.Windows.Forms.Label lblLable;
    }
}
