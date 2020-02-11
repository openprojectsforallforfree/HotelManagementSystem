namespace UEMS
{
    partial class Hotel_Sales_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel_Sales_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtId = new Bsoft.Controls.VtextBox();
            this.txtfk_Master_Customer = new Bsoft.Controls.VtextBox();
            this.txtfk_Product = new Bsoft.Controls.VtextBox();
            this.txtbookingstaus = new Bsoft.Controls.VtextBox();
            this.txtRate = new Bsoft.Controls.VtextBox();
            this.txtQuantity = new Bsoft.Controls.VtextBox();
            this.txtDiscount = new Bsoft.Controls.VtextBox();
            this.txtRemarks = new Bsoft.Controls.VtextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAmount1 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblServiceCharge = new System.Windows.Forms.Label();
            this.lblNetAmount1 = new System.Windows.Forms.Label();
            this.lbldueamt1 = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.btnSelectRoom = new bsoftcontrols.fsButton();
            this.lister1 = new Bsoft.Controls.lister();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.lbldueamt = new System.Windows.Forms.Label();
            this.lblfk_Master_Customer = new System.Windows.Forms.Label();
            this.lblCustmerName = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.Label();
            this.txtServiceCharge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(778, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(414, 446);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(320, 446);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(345, 7);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(36, 23);
            this.txtId.TabIndex = 0;
            this.txtId.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtId.Value = "";
            this.txtId.Visible = false;
            // 
            // txtfk_Master_Customer
            // 
            this.txtfk_Master_Customer.Location = new System.Drawing.Point(387, 7);
            this.txtfk_Master_Customer.Name = "txtfk_Master_Customer";
            this.txtfk_Master_Customer.Size = new System.Drawing.Size(30, 23);
            this.txtfk_Master_Customer.TabIndex = 0;
            this.txtfk_Master_Customer.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtfk_Master_Customer.Value = "";
            this.txtfk_Master_Customer.Visible = false;
            // 
            // txtfk_Product
            // 
            this.txtfk_Product.Location = new System.Drawing.Point(423, 7);
            this.txtfk_Product.Name = "txtfk_Product";
            this.txtfk_Product.Size = new System.Drawing.Size(24, 23);
            this.txtfk_Product.TabIndex = 0;
            this.txtfk_Product.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtfk_Product.Value = "";
            this.txtfk_Product.Visible = false;
            // 
            // txtbookingstaus
            // 
            this.txtbookingstaus.Location = new System.Drawing.Point(308, 7);
            this.txtbookingstaus.MaxLength = 3;
            this.txtbookingstaus.Name = "txtbookingstaus";
            this.txtbookingstaus.Size = new System.Drawing.Size(31, 23);
            this.txtbookingstaus.TabIndex = 0;
            this.txtbookingstaus.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtbookingstaus.Value = "";
            this.txtbookingstaus.Visible = false;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(263, 12);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(39, 23);
            this.txtRate.TabIndex = 0;
            this.txtRate.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtRate.Value = "";
            this.txtRate.Visible = false;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(244, 144);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(160, 23);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Integer;
            this.txtQuantity.Value = "";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(244, 177);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(160, 23);
            this.txtDiscount.TabIndex = 2;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Integer;
            this.txtDiscount.Value = "";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(244, 372);
            this.txtRemarks.MaxLength = 150;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(400, 50);
            this.txtRemarks.TabIndex = 4;
            this.txtRemarks.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtRemarks.Value = "";
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Location = new System.Drawing.Point(64, 144);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(160, 22);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmount1
            // 
            this.lblAmount1.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount1.Location = new System.Drawing.Point(64, 210);
            this.lblAmount1.Name = "lblAmount1";
            this.lblAmount1.Size = new System.Drawing.Size(160, 22);
            this.lblAmount1.TabIndex = 0;
            this.lblAmount1.Text = "Amount:";
            this.lblAmount1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Location = new System.Drawing.Point(64, 177);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(160, 22);
            this.lblDiscount.TabIndex = 0;
            this.lblDiscount.Text = "Discount:";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVAT
            // 
            this.lblVAT.BackColor = System.Drawing.Color.Transparent;
            this.lblVAT.Location = new System.Drawing.Point(133, 275);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(91, 22);
            this.lblVAT.TabIndex = 0;
            this.lblVAT.Text = "VAT:";
            this.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServiceCharge
            // 
            this.lblServiceCharge.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceCharge.Location = new System.Drawing.Point(55, 242);
            this.lblServiceCharge.Name = "lblServiceCharge";
            this.lblServiceCharge.Size = new System.Drawing.Size(169, 22);
            this.lblServiceCharge.TabIndex = 0;
            this.lblServiceCharge.Text = "ServiceCharge:";
            this.lblServiceCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetAmount1
            // 
            this.lblNetAmount1.BackColor = System.Drawing.Color.Transparent;
            this.lblNetAmount1.Location = new System.Drawing.Point(64, 308);
            this.lblNetAmount1.Name = "lblNetAmount1";
            this.lblNetAmount1.Size = new System.Drawing.Size(160, 22);
            this.lblNetAmount1.TabIndex = 0;
            this.lblNetAmount1.Text = "NetAmount:";
            this.lblNetAmount1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbldueamt1
            // 
            this.lbldueamt1.BackColor = System.Drawing.Color.Transparent;
            this.lbldueamt1.Location = new System.Drawing.Point(64, 340);
            this.lbldueamt1.Name = "lbldueamt1";
            this.lbldueamt1.Size = new System.Drawing.Size(160, 22);
            this.lbldueamt1.TabIndex = 0;
            this.lbldueamt1.Text = "Due Amount:";
            this.lbldueamt1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Location = new System.Drawing.Point(64, 372);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(160, 22);
            this.lblRemarks.TabIndex = 0;
            this.lblRemarks.Text = "Remarks:";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSelectRoom
            // 
            this.btnSelectRoom.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSelectRoom.FlatAppearance.BorderSize = 0;
            this.btnSelectRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectRoom.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectRoom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSelectRoom.Location = new System.Drawing.Point(244, 105);
            this.btnSelectRoom.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(170, 29);
            this.btnSelectRoom.TabIndex = 0;
            this.btnSelectRoom.Text = "Select Product";
            this.btnSelectRoom.Click += new System.EventHandler(this.btnSelectRoom_Click);
            // 
            // lister1
            // 
            this.lister1.Datatable = null;
            this.lister1.hoizontal = false;
            this.lister1.Location = new System.Drawing.Point(530, 115);
            this.lister1.Name = "lister1";
            this.lister1.Size = new System.Drawing.Size(227, 215);
            this.lister1.TabIndex = 14;
            this.lister1.TabStop = false;
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Location = new System.Drawing.Point(244, 210);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(160, 22);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "0";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblNetAmount.Location = new System.Drawing.Point(244, 308);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(160, 22);
            this.lblNetAmount.TabIndex = 0;
            this.lblNetAmount.Text = "0";
            this.lblNetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbldueamt
            // 
            this.lbldueamt.BackColor = System.Drawing.Color.Transparent;
            this.lbldueamt.Location = new System.Drawing.Point(244, 340);
            this.lbldueamt.Name = "lbldueamt";
            this.lbldueamt.Size = new System.Drawing.Size(160, 22);
            this.lbldueamt.TabIndex = 0;
            this.lbldueamt.Text = "0";
            this.lbldueamt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblfk_Master_Customer
            // 
            this.lblfk_Master_Customer.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Master_Customer.Location = new System.Drawing.Point(64, 73);
            this.lblfk_Master_Customer.Name = "lblfk_Master_Customer";
            this.lblfk_Master_Customer.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Master_Customer.TabIndex = 16;
            this.lblfk_Master_Customer.Text = "Customer:";
            this.lblfk_Master_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustmerName
            // 
            this.lblCustmerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustmerName.Location = new System.Drawing.Point(244, 73);
            this.lblCustmerName.Name = "lblCustmerName";
            this.lblCustmerName.Size = new System.Drawing.Size(160, 22);
            this.lblCustmerName.TabIndex = 15;
            this.lblCustmerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.Color.Transparent;
            this.txtVAT.Location = new System.Drawing.Point(244, 275);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(160, 22);
            this.txtVAT.TabIndex = 0;
            this.txtVAT.Text = "0";
            this.txtVAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.BackColor = System.Drawing.Color.Transparent;
            this.txtServiceCharge.Location = new System.Drawing.Point(244, 242);
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.Size = new System.Drawing.Size(160, 22);
            this.txtServiceCharge.TabIndex = 0;
            this.txtServiceCharge.Text = "0";
            this.txtServiceCharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Hotel_Sales_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 494);
            this.Controls.Add(this.lblfk_Master_Customer);
            this.Controls.Add(this.lblCustmerName);
            this.Controls.Add(this.lister1);
            this.Controls.Add(this.btnSelectRoom);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtfk_Master_Customer);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtfk_Product);
            this.Controls.Add(this.txtbookingstaus);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lbldueamt1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtServiceCharge);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAmount1);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblServiceCharge);
            this.Controls.Add(this.lbldueamt);
            this.Controls.Add(this.lblNetAmount);
            this.Controls.Add(this.lblNetAmount1);
            this.Name = "Hotel_Sales_Ent";
            this.Text = "Hotel Sales Item";
            this.Load += new System.EventHandler(this.Hotel_Sales_Ent_Load);
            this.Controls.SetChildIndex(this.lblNetAmount1, 0);
            this.Controls.SetChildIndex(this.lblNetAmount, 0);
            this.Controls.SetChildIndex(this.lbldueamt, 0);
            this.Controls.SetChildIndex(this.lblServiceCharge, 0);
            this.Controls.SetChildIndex(this.lblVAT, 0);
            this.Controls.SetChildIndex(this.lblDiscount, 0);
            this.Controls.SetChildIndex(this.lblAmount1, 0);
            this.Controls.SetChildIndex(this.lblAmount, 0);
            this.Controls.SetChildIndex(this.txtServiceCharge, 0);
            this.Controls.SetChildIndex(this.txtVAT, 0);
            this.Controls.SetChildIndex(this.lblQuantity, 0);
            this.Controls.SetChildIndex(this.lbldueamt1, 0);
            this.Controls.SetChildIndex(this.lblRemarks, 0);
            this.Controls.SetChildIndex(this.txtDiscount, 0);
            this.Controls.SetChildIndex(this.txtQuantity, 0);
            this.Controls.SetChildIndex(this.txtRate, 0);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.txtbookingstaus, 0);
            this.Controls.SetChildIndex(this.txtfk_Product, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.txtfk_Master_Customer, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.btnSelectRoom, 0);
            this.Controls.SetChildIndex(this.lister1, 0);
            this.Controls.SetChildIndex(this.lblCustmerName, 0);
            this.Controls.SetChildIndex(this.lblfk_Master_Customer, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }//<Control>

        private Bsoft.Controls.VtextBox txtId;
        private Bsoft.Controls.VtextBox txtfk_Master_Customer;
        private Bsoft.Controls.VtextBox txtfk_Product;
        private Bsoft.Controls.VtextBox txtbookingstaus;
        private Bsoft.Controls.VtextBox txtRate;
        private Bsoft.Controls.VtextBox txtQuantity;
        private Bsoft.Controls.VtextBox txtDiscount;
        private Bsoft.Controls.VtextBox txtRemarks;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAmount1;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblServiceCharge;
        private System.Windows.Forms.Label lblNetAmount1;
        private System.Windows.Forms.Label lbldueamt1;
        private System.Windows.Forms.Label lblRemarks;




        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private bsoftcontrols.fsButton btnSelectRoom;
        private Bsoft.Controls.lister lister1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Label lbldueamt;
        private System.Windows.Forms.Label lblfk_Master_Customer;
        private System.Windows.Forms.Label lblCustmerName;
        private System.Windows.Forms.Label txtVAT;
        private System.Windows.Forms.Label txtServiceCharge;
    }
}
