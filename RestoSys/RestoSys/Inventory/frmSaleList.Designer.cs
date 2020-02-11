namespace RestoSys.Inventory
{
    partial class frmSaleList
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
            this._closeButton.Location = new System.Drawing.Point(1118, 2);
            // 
            // anOrder1
            // 
            this.anOrder1.BackColor = System.Drawing.Color.Transparent;
            this.anOrder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anOrder1.Location = new System.Drawing.Point(69, 38);
            this.anOrder1.Name = "anOrder1";
            this.anOrder1.Size = new System.Drawing.Size(851, 280);
            this.anOrder1.TabIndex = 1;
            // 
            // frmSaleList
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 598);
            this.Controls.Add(this.anOrder1);
            this.Name = "frmSaleList";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Text = "Shopping Cart";
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
