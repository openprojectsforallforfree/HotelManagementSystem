namespace RestoSys.Inventory
{
    partial class frmSalesCart
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
            this.anOrder1 = new RestoSys.RestaurantBilling.AnOrder();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(797, 2);
            this._closeButton.Size = new System.Drawing.Size(31, 32);
            // 
            // anOrder1
            // 
            this.anOrder1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.anOrder1.BackColor = System.Drawing.Color.Transparent;
            this.anOrder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anOrder1.Location = new System.Drawing.Point(2, 38);
            this.anOrder1.Margin = new System.Windows.Forms.Padding(4);
            this.anOrder1.Name = "anOrder1";
            this.anOrder1.Padding = new System.Windows.Forms.Padding(0, 4, 205, 105);
            this.anOrder1.Size = new System.Drawing.Size(815, 500);
            this.anOrder1.TabIndex = 1;
            // 
            // frmSalesCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 543);
            this.Controls.Add(this.anOrder1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSalesCart";
            this.Text = "frmSalesCart";
            this.Load += new System.EventHandler(this.frmSaleList_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSaleList_FormClosed);
            this.Controls.SetChildIndex(this.anOrder1, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private RestoSys.RestaurantBilling.AnOrder anOrder1;


    }
}