namespace RestoSys.Account
{
    partial class frmCreditItemList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd_standardcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd_listprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdGrp_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdComp_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd_colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd_quantity_instore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd_Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd_Transaction_Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(840, 2);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mangal", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colProd_Name,
            this.colProd_Code,
            this.colProd_standardcost,
            this.colQuantity,
            this.colProd_listprice,
            this.colProdGrp_Name,
            this.colProdComp_Name,
            this.colProd_colour,
            this.colProd_weight,
            this.colProd_size,
            this.colProd_Rate,
            this.colProd_quantity_instore,
            this.colProd_Remarks,
            this.colProd_Transaction_Remarks});
            this.grid.Location = new System.Drawing.Point(12, 47);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(850, 352);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 9;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 49;
            // 
            // colProd_Name
            // 
            this.colProd_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProd_Name.HeaderText = "Name";
            this.colProd_Name.MinimumWidth = 15;
            this.colProd_Name.Name = "colProd_Name";
            this.colProd_Name.Width = 75;
            // 
            // colProd_Code
            // 
            this.colProd_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProd_Code.HeaderText = "Code";
            this.colProd_Code.Name = "colProd_Code";
            this.colProd_Code.Width = 71;
            // 
            // colProd_standardcost
            // 
            this.colProd_standardcost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProd_standardcost.HeaderText = "Cost";
            this.colProd_standardcost.MinimumWidth = 15;
            this.colProd_standardcost.Name = "colProd_standardcost";
            this.colProd_standardcost.Visible = false;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            // 
            // colProd_listprice
            // 
            this.colProd_listprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProd_listprice.HeaderText = "Price";
            this.colProd_listprice.MinimumWidth = 15;
            this.colProd_listprice.Name = "colProd_listprice";
            this.colProd_listprice.Width = 70;
            // 
            // colProdGrp_Name
            // 
            this.colProdGrp_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProdGrp_Name.HeaderText = "Group";
            this.colProdGrp_Name.Name = "colProdGrp_Name";
            this.colProdGrp_Name.Visible = false;
            // 
            // colProdComp_Name
            // 
            this.colProdComp_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProdComp_Name.HeaderText = "Company";
            this.colProdComp_Name.Name = "colProdComp_Name";
            this.colProdComp_Name.Width = 98;
            // 
            // colProd_colour
            // 
            this.colProd_colour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProd_colour.HeaderText = "Color";
            this.colProd_colour.Name = "colProd_colour";
            this.colProd_colour.Visible = false;
            // 
            // colProd_weight
            // 
            this.colProd_weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProd_weight.HeaderText = "Weight";
            this.colProd_weight.Name = "colProd_weight";
            this.colProd_weight.Visible = false;
            // 
            // colProd_size
            // 
            this.colProd_size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProd_size.HeaderText = "Size";
            this.colProd_size.Name = "colProd_size";
            this.colProd_size.Width = 65;
            // 
            // colProd_Rate
            // 
            this.colProd_Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProd_Rate.HeaderText = "Rate";
            this.colProd_Rate.Name = "colProd_Rate";
            this.colProd_Rate.Visible = false;
            // 
            // colProd_quantity_instore
            // 
            this.colProd_quantity_instore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProd_quantity_instore.HeaderText = "Quantity In Store";
            this.colProd_quantity_instore.Name = "colProd_quantity_instore";
            this.colProd_quantity_instore.Visible = false;
            // 
            // colProd_Remarks
            // 
            this.colProd_Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProd_Remarks.HeaderText = "Product Remarks";
            this.colProd_Remarks.Name = "colProd_Remarks";
            this.colProd_Remarks.Width = 150;
            // 
            // colProd_Transaction_Remarks
            // 
            this.colProd_Transaction_Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProd_Transaction_Remarks.HeaderText = "Transaction Remarks";
            this.colProd_Transaction_Remarks.Name = "colProd_Transaction_Remarks";
            this.colProd_Transaction_Remarks.Width = 175;
            // 
            // frmCreditItemList
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 411);
            this.Controls.Add(this.grid);
            this.Name = "frmCreditItemList";
            this.Text = "Credit Items";
            this.Load += new System.EventHandler(this.frmCreditItemList_Load);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        } 

        #endregion

        public System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd_standardcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd_listprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdGrp_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdComp_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd_colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd_quantity_instore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd_Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd_Transaction_Remarks;
    }
}
