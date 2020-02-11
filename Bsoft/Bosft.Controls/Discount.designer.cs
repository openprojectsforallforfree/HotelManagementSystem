namespace Bsoft.Controls
{
    partial class Discount
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
            this.components = new System.ComponentModel.Container();
            this.toolErrorMessage = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelDiscount = new System.Windows.Forms.Panel();
            this.panelAmount = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new Bsoft.Controls.VtextBox();
            this.txtPercent = new Bsoft.Controls.VtextBox();
            this.panelDiscount.SuspendLayout();
            this.panelAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = " Rs.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelDiscount
            // 
            this.panelDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelDiscount.BackColor = System.Drawing.Color.Transparent;
            this.panelDiscount.Controls.Add(this.label2);
            this.panelDiscount.Controls.Add(this.txtPercent);
            this.panelDiscount.Location = new System.Drawing.Point(200, 0);
            this.panelDiscount.Name = "panelDiscount";
            this.panelDiscount.Size = new System.Drawing.Size(94, 34);
            this.panelDiscount.TabIndex = 6;
            // 
            // panelAmount
            // 
            this.panelAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAmount.BackColor = System.Drawing.Color.Transparent;
            this.panelAmount.Controls.Add(this.txtAmount);
            this.panelAmount.Controls.Add(this.label1);
            this.panelAmount.Location = new System.Drawing.Point(3, 0);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(193, 34);
            this.panelAmount.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(69, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "%";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(44, 4);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.MaxLength = 0;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(145, 22);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtAmount.Value = "";
            this.txtAmount.Validated += new System.EventHandler(this.txtAmount_Validated);
            this.txtAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyUp);
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(10, 4);
            this.txtPercent.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercent.MaxLength = 5;
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(56, 22);
            this.txtPercent.TabIndex = 4;
            this.txtPercent.Text = "99.9999";
            this.txtPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPercent.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtPercent.Value = "99.9999";
            this.txtPercent.Validated += new System.EventHandler(this.txtPercent_Validated);
            this.txtPercent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPercent_KeyUp);
            this.txtPercent.Validating += new System.ComponentModel.CancelEventHandler(this.txtPercent_Validating);
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelAmount);
            this.Controls.Add(this.panelDiscount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Discount";
            this.Size = new System.Drawing.Size(296, 36);
            this.Resize += new System.EventHandler(this.Discount_Resize);
            this.panelDiscount.ResumeLayout(false);
            this.panelDiscount.PerformLayout();
            this.panelAmount.ResumeLayout(false);
            this.panelAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolErrorMessage;
        private System.Windows.Forms.Label label1;
        public VtextBox txtAmount;
        public VtextBox txtPercent;
        private System.Windows.Forms.Panel panelDiscount;
        private System.Windows.Forms.Panel panelAmount;
        private System.Windows.Forms.Label label2;

    }
}
