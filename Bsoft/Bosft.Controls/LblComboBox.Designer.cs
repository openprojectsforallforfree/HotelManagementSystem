namespace Bsoft.Controls
{
    partial class lblComboBox
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
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblLable
            // 
            this.lblLable.AutoEllipsis = true;
            this.lblLable.Location = new System.Drawing.Point(6, 1);
            this.lblLable.Name = "lblLable";
            this.lblLable.Size = new System.Drawing.Size(161, 25);
            this.lblLable.TabIndex = 0;
            this.lblLable.Text = "Lable :";
            this.lblLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLable.Click += new System.EventHandler(this.lblLable_Click);
            // 
            // cmbBox
            // 
            this.cmbBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(174, 0);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(236, 24);
            this.cmbBox.TabIndex = 2;
            // 
            // lblComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cmbBox);
            this.Controls.Add(this.lblLable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "lblComboBox";
            this.Size = new System.Drawing.Size(413, 25);
            this.Resize += new System.EventHandler(this.lblComboBox_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblLable;
        public System.Windows.Forms.ComboBox cmbBox;

    }
}
