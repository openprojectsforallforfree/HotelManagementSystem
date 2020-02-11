using UEMS;
namespace Bsoft.Controls
{
    partial class DiscountControl
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
            this.txtDiscountPercent = new Bsoft.Controls.txtShadowTextBox();
            this.txtDiscount = new Bsoft.Controls.txtShadowTextBox();
            this.SuspendLayout();
            // 
            // toolErrorMessage
            // 
            this.toolErrorMessage.IsBalloon = true;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountPercent.Label = " %";
            this.txtDiscountPercent.Location = new System.Drawing.Point(141, 0);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(62, 20);
            this.txtDiscountPercent.TabIndex = 6;
            this.txtDiscountPercent.Text = " %";
            this.txtDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountPercent.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtDiscountPercent.Value = "";
            this.txtDiscountPercent.Enter += new System.EventHandler(this.txtDiscountPercent_Enter);
            this.txtDiscountPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountPercent_KeyPress);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscount.Label = "Rs ";
            this.txtDiscount.Location = new System.Drawing.Point(0, 0);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(135, 20);
            this.txtDiscount.TabIndex = 6;
            this.txtDiscount.Text = "Rs ";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtDiscount.Value = "";
            this.txtDiscount.Enter += new System.EventHandler(this.txtDiscount_Enter);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // DiscountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtDiscount);
            this.Name = "DiscountControl";
            this.Size = new System.Drawing.Size(206, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public txtShadowTextBox txtDiscount;
        public txtShadowTextBox txtDiscountPercent;
        private System.Windows.Forms.ToolTip toolErrorMessage;

    }
}
