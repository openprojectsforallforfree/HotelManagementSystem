using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Forms;
using UEMS.BLL;
using Bsoft.Data;
using Bsoft.AppCom;
using Bsoft.Common;
using RestoSys.BLL;
namespace RestoSys.Inventory
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmSaleEntry : Friuts.EntryFormBase
    {
        public string purchageId = "";
        public string costPrice = "";
        string ProductEntryType = "";
        public bool blnFromEdit = false;

        #region Constructors Set title , Set Discount visiblity
        public frmSaleEntry()
        {
            InitializeComponent();
            FormType = FormTypes.EntryForm;
        }
        public frmSaleEntry(string stockEntryType)
        {
            ProductEntryType = stockEntryType;
            InitializeComponent();
            FormType = FormTypes.EntryForm;
            if (stockEntryType != StockType.Sales)
            {
                grpDiscount.Visible = false;
            }
            Text = StockType.GetEntryTypeText(ProductEntryType) + " Entry";

        }

        #endregion

        #region Other Events
        private void frmSaleEntry_Load(object sender, EventArgs e)
        {
            //Set style ,date
            ListingFormBase lsfb = new ListingFormBase();
            lsfb.SetDataGridViewProperties(grid);
            lblDate.Text = "Date : " + DateTime.Today.ToShortDateString();
            this.FirstControl = txtGroup_Code;
            txtGroup_Code.Select();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            searhItemClick("");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDiscount_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Convert.ToSingle(txtDiscount.Text) > Convert.ToSingle(txtAmount.Text))
                {
                    MessageBoxMy.Show("Discount can not be more than Amount ", MessageBoxButtons.OK);
                    e.Cancel = true;
                }
            }
            catch { }
        }

        private void txtDiscountPercent_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Convert.ToSingle(txtDiscountPercent.Text) > 100)
                {
                    MessageBoxMy.Show("Discount can not be more than 100 %  ", MessageBoxButtons.OK);
                    e.Cancel = true;
                }
            }
            catch { }
        }


        private void txtDiscountPercent_Enter(object sender, EventArgs e)
        {
            txtDiscountPercent.SelectAll();
        }

        private void txtDiscount_Enter(object sender, EventArgs e)
        {
            txtDiscount.SelectAll();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            updateDiscount();
        }

        private void txtDiscountPercent_TextChanged(object sender, EventArgs e)
        {
            updateDiscount();
        }
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            updateDiscount();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            calculateAmount();
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            txtQuantity.SelectAll();
        }
        //updated rates and other
        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            if (!blnFromEdit)
            {
                try
                {
                    txtRate.Text = grid["MRP", grid.SelectedCells[0].RowIndex].Value.ToString();
                    purchageId = grid["purchaseid", grid.SelectedCells[0].RowIndex].Value.ToString();
                    costPrice = grid["costprice", grid.SelectedCells[0].RowIndex].Value.ToString();
                    calculateAmount();
                }
                catch { }
            }
        }

        private void grid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            blnFromEdit = false;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            // Code entry in text box
            if (txtGroup_Code.Focused)
            {
                CodeEntryInCodeTextBox();
                return;
            }
            //Real ok click 
            if (!IsQuantity_RateValid())
            {
                return;
            }
            double qtyInTxtBox = Convert.ToDouble(txtQuantity.Text);
            string purchaseId = "";
            string salesId = "";
            string productId = txtProduct.Text;


            if (ProductEntryType == StockType.Sales)
            {
                if (CheckStock(productId, out purchaseId, qtyInTxtBox, ProductEntryType, out salesId))
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }

                return;
            }
            else
            {
                if (txtRemarks.Text.Trim() == "")
                {
                    MessageBoxMy.Show("Please Enter the Cause of " + StockType.GetEntryTypeText(ProductEntryType) + " Entry in Remarks.", MessageBoxButtons.OK);
                    return;
                }
            }

            if (MessageBoxMy.Show("Do you want to register " + StockType.GetEntryTypeText(ProductEntryType) + "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (CheckStock(productId, out purchaseId, qtyInTxtBox, ProductEntryType, out salesId))
                {
                    //insert to the inv_stock
                    if (RestoSys.RestoSysDAl.UpdatequantityTOStore(purchaseId, productId, salesId, qtyInTxtBox.ToString(), ProductEntryType))
                    {
                        MessageBoxMy.Show("Data is Entered.", MessageBoxButtons.OK);
                        DialogResult = DialogResult.OK;
                    }
                }

            }
        }

        private void CodeEntryInCodeTextBox()
        {
            string productId = "";

            //Clearing
            clearValuesinLabel();
            //Validation
            //code ok?
            string[] code;
            code = txtGroup_Code.Text.Split('.');
            if (code.Length != 2)
            {
                if (StringUtilities.IsInteger(txtGroup_Code.Text.Trim()))
                {
                    //bar code 
                    productId = RestoSysDAl.GetProductIdFromBarCode(txtGroup_Code.Text.Trim());
                }
                else
                {
                    //Search
                    txtProduct.Text = "";
                    searhItemClick(txtGroup_Code.Text);
                    return;
                }
            }
            else
            {
                productId = RestoSys.Inventory.dal.GetProductIdFromCode(code[0], code[1]);
            }
            if (productId == null || productId =="")
            {
                txtProduct.Text = "";
                searhItemClick(txtGroup_Code.Text);
                return;
                // MessageBox.Show("Product Not found Please check the code.");
                // txtProduct.Text = "";
                // return;
            }

            // For the product deatails
            // get the products inventory detail from Inv_Purchase
            if (ProductIsSelected(productId))
            {
                txtProduct.Text = productId;
                txtQuantity.SelectAll();
                txtQuantity.Focus();
            }
            else
            { txtGroup_Code.Select(); }

        }

        private bool IsQuantity_RateValid()
        {

            double qtyInTxtBox = 0;
            if (txtDiscount.Text == "")
            {
                txtDiscount.Text = "0";
            }

            if (txtProduct.Text == "")
            {
                MessageBoxMy.Show("Please select a Product First", MessageBoxButtons.OK);
                return false;
            }

            if (txtQuantity.Text.Trim().Length == 0)
            {
                MessageBoxMy.Show("Please enter quantity", MessageBoxButtons.OK); txtQuantity.Focus();
                txtQuantity.Select(); return false;
            }
            else
            {
                qtyInTxtBox = Convert.ToDouble(txtQuantity.Text);
                if (qtyInTxtBox <= 0)
                {
                    MessageBoxMy.Show("Please enter quantity", MessageBoxButtons.OK);
                    txtQuantity.Focus();
                    txtQuantity.Select();
                    return false;
                }
            }

            if (txtRate.Text.Trim().Length == 0)
            {
                txtAmount.Text = "0";
                MessageBoxMy.Show("Rate is not valid Please check it .", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                double rate = Convert.ToDouble(txtRate.Text);
                //rate = 2;
                double amount = qtyInTxtBox * rate;
                amount = Math.Round(amount, 2);
                txtAmount.Text = amount.ToString();
            }

            return true;
        }
        #endregion

        #region Methods
        public void SelectSuitableGridItem(string purchageId_)
        {
            purchageId = purchageId_;
            try
            {
                foreach (DataGridViewRow dgvr in grid.Rows)
                {
                    if (dgvr.Cells["purchaseid"].Value.ToString().Trim() == purchageId.ToString().Trim())
                    {
                        dgvr.Cells["QTY"].Selected = true;
                        txtRate.Text = grid["MRP", grid.SelectedCells[0].RowIndex].Value.ToString();
                        // purchageId = grid["id", grid.SelectedCells[0].RowIndex].Value.ToString();
                        costPrice = grid["costprice", grid.SelectedCells[0].RowIndex].Value.ToString();
                        calculateAmount();
                        return;
                    }
                }
            }
            catch { }
            // blnFromEdit =false ;
        }
        //Either browsed or code entered.
        public bool ProductIsSelected(string productId)
        {  //Display rate info
            txtProduct.Text = productId;
            txtQuantity.SelectAll();
            txtQuantity.Focus();
            StringBuilder SQL = new StringBuilder();
            SQL.Append("SELECT * from Master_Product where id = " + productId);
            DataTable productddt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            if (productddt.Rows.Count > 0)
            {
                lblName.Text = productddt.Rows[0]["Name"].ToString();
                lblfk_Group.Text = RestoSys.Inventory.dal.getGroup(productddt.Rows[0]["fk_Group"].ToString());
                lblfk_Company.Text = RestoSys.Inventory.dal.getCompany(productddt.Rows[0]["fk_Company"].ToString());
                lblsizeunit.Text = RestoSys.Inventory.dal.getUnit(productddt.Rows[0]["fk_sizeunit"].ToString());
                lblweightunit.Text = RestoSys.Inventory.dal.getUnit(productddt.Rows[0]["fk_weightunit"].ToString());
                lblcolour.Text = productddt.Rows[0]["colour"].ToString();
                lblweight.Text = productddt.Rows[0]["weight"].ToString();
                lblsize.Text = productddt.Rows[0]["size"].ToString();
                label5.Text = productddt.Rows[0]["Remarks"].ToString();
                //lblUserId.Text =getUser( productddt.Rows[0]["UserId"].ToString());
                //lblentrydate.Text = productddt.Rows[0]["entrydate"].ToString();
                lblMeasureUnit.Text = RestoSys.Inventory.dal.getUnit(productddt.Rows[0]["fk_MeasureUnit"].ToString());
            }
            //other
            //Display rate info
            return DisplayDataToGrid(productId);
            //lblquantityinStore.Text = productddt.Rows[0]["quantity_instore"].ToString();
            //lblListPrice.Text = productddt.Rows[0]["listprice"].ToString();
            //lblCostPrice.Text = productddt.Rows[0]["StandardCost"].ToString();
        }

        /// <summary>
        /// Returns if the data can be entered
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        private bool DisplayDataToGrid(string productId)
        {
            //Only allow return of goods sold in 30 days
            if (ProductEntryType == StockType.SalesReturn)
            {
                string sql = string.Format(@"
                            select t1.id salesid,
                            Inv_Purchase.id as purchaseid  ,
                            t1.date as [Selling
                            Date],
                            cast (t1.quantity as decimal(10,2)) as Quantity,
                            cast (t1.salesreturn as decimal(10,2))  as [Sales
                            Return],
                            cast (t1.rate as decimal(10,2))  as MRP ,
                            cast (t1.discount as decimal(10,2)) as [Discount
                            Given],
                            cast (t1.netamount as decimal(10,2)) as Amount,
                            SuperAdmin_Rights_Users.ENGNAME as username ,
                            t1.remarks from Inv_Sale t1
                             left outer join Inv_Purchase on
                             Inv_Purchase.id = t1.fk_Purchage
                             left outer join Master_Product on
                             Master_Product.id = Inv_Purchase.fk_Product
                             left outer join SuperAdmin_Rights_Users on
                             SuperAdmin_Rights_Users.id = t1.UserId 
                             where t1.date >= '{0}'
                            AND t1.date <= '{1}'
                            and t1.fk_product = {2}
                        ", DateTime.Now.AddDays(-30).ToString("yyyyMMdd"),
                         DateTime.Now.ToString("yyyyMMdd"),
                        productId);

                DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql);
                grid.DataSource = dt;

                if (dt == null | dt.Rows.Count == 0)
                {
                    MessageBoxMy.Show("The Sales entry for since last month for this product doesnot Exist.\n Goods sold more than one month back cannot be returned.", MessageBoxButtons.OK);
                    txtRate.Text = "";
                    txtQuantity.Text = "";
                    txtGroup_Code.Text = "";
                    txtGroup_Code.Focus();
                    return false;
                }
                else
                {
                    grid.Columns["salesid"].Visible = false;
                    grid.Columns["purchaseid"].Visible = false;
                }
                lblRateNote.Visible = true;
                grid.Visible = true;
            }
            else if (ProductEntryType == StockType.StockEntry)
            {
                return true;
            }
            else
            {

                lblRateNote.Visible = true;
                grid.Visible = true;
                string sql = @"
SELECT 
PurchaseRptView.Inv_PurchaseId as purchaseid,
PurchaseRptView.Inv_Purchase_entrydate  as [Purchage Date],
cast (PurchaseRptView.MRP as decimal(10,2))  as MRP,
cast (PurchaseRptView.Cost  as decimal(10,2))  as costprice,
cast (PurchaseRptView.purchageQuantity  as decimal(10,2))  as QTY,
cast ( PurchaseRptView.SoldQuantity  as decimal(10,2))*-1 as SOLD ,
PurchaseRptView.stock   as Stock, 
PurchaseRptView.ManufactureDate as [Mnf Date],
PurchaseRptView.ExpiryDate  as [Ex Date], 
PurchaseRptView.VendorName [vendor Name],
PurchaseRptView.purchageRemarks  as  remarks from PurchaseRptView
where PurchaseRptView.ProductId ={0} and  stock > 0


                ".With(productId);

                DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
                grid.DataSource = dt;

                if (dt == null | dt.Rows.Count == 0)
                {

                    MessageBoxMy.Show("The stock for this item is not entered or finished.", MessageBoxButtons.OK);
                    txtRate.Text = "";
                    txtQuantity.Text = "";
                    txtGroup_Code.Text = "";
                    txtGroup_Code.Focus();
                    return false;
                }
                else
                {
                    grid.Columns["purchaseid"].Visible = false;
                    grid.Columns["costprice"].Visible = false;
                }

            }
            return true;
        }

        //When the search is cliked or code entered in text box
        private void searhItemClick(string searchString)
        {
            RestoSys.MasterEntry.frmProductList frm = new RestoSys.MasterEntry.frmProductList();
            frm.FormType = FormTypes.SelectionForm;
            if (ProductEntryType == StockType.IngredientConsumed)
            {
                frm.StockCode = string.Format("'{0}' , '{1}' ", ItemType.Consumable, ItemType.Ingredient);
                frm.Text = "Ingredient Items";
            }
            else if (ProductEntryType == StockType.Damaged)
            {
                frm.StockCode = string.Format("'{0}' , '{1}', '{2}', '{3}' ", ItemType.Consumable, ItemType.Ingredient, ItemType.Manufacture, ItemType.Retail);
                frm.Text = "Items that could be damaged";
            }
            else if (ProductEntryType == StockType.Lost)
            {
                frm.StockCode = string.Format("'{0}' , '{1}', '{2}', '{3}' ", ItemType.Consumable, ItemType.Ingredient, ItemType.Manufacture, ItemType.Retail);
                frm.Text = "Items that could be lost";
            }
            else if (ProductEntryType == StockType.Purchase)
            {
                frm.StockCode = string.Format("'{0}' , '{1}', '{2}' ", ItemType.Consumable, ItemType.Ingredient, ItemType.Retail);
                frm.Text = "Purchase : Items that can be purchased";
            }
            else if (ProductEntryType == StockType.PurchaseReturn)
            {
                frm.StockCode = string.Format("'{0}' , '{1}', '{2}' ", ItemType.Consumable, ItemType.Ingredient, ItemType.Retail);
                frm.Text = "Purchase Return : Items that can be purchased";
            }
            else if (ProductEntryType == StockType.Sales)
            {
                frm.StockCode = string.Format("'{0}' , '{1}', '{2}','{3}' ",
                    ItemType.Retail,
                    ItemType.Manufacture,
                    ItemType.Service,
                    ItemType.Lend);
                frm.Text = "Sales : Items that could be in sales";
            }
            else if (ProductEntryType == StockType.SalesReturn)
            {
                frm.StockCode = string.Format("'{0}' , '{1}' , '{2}'", ItemType.Retail, ItemType.Manufacture, ItemType.Service);
                frm.Text = "Sales Return : Items that could be in sales";
            }
            else if (ProductEntryType == StockType.StockEntry)
            {
                frm.StockCode = string.Format("'{0}'", ItemType.Manufacture);
                frm.Text = "Stock Entry : Manufactured / Produced Items";
            }
            frm.Text = "Select " + frm.Text;
            frm.txtName.Text = searchString;
            frm.valueSelected += new ListingFormBase.ValueSelected(frm_valueSelected);
            frm.ShowDialog(this);
        }

        private void clearValuesinLabel()
        {
            //lblListPrice.Text = "";
            lblName.Text = lblfk_Group.Text = lblfk_Company.Text = "";
            lblsizeunit.Text = lblweightunit.Text = lblcolour.Text = lblweight.Text = "";
            lblsize.Text = lblRemarks.Text = "";
            lblMeasureUnit.Text = "";
        }



        void frm_valueSelected(object sender, string SelectedPrimaryKey)
        {
            //DataGridViewRow row = (DataGridViewRow)frm.SelectedValue;
            string KEY = SelectedPrimaryKey;// row.Cells["colid"].Value.ToString();
            //SelectComboValue(cboProduct, KEY);
            txtProduct.Text = KEY;
            if (KEY != "")
            {
                string code, GroupId;
                StringBuilder SQL = new StringBuilder();

                //Group  id
                SQL.Remove(0, SQL.Length);
                SQL.Append("select fk_Group from Master_Product");
                SQL.AppendFormat("\n WHERE  id = {0}", KEY);
                GroupId = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();

                SQL.Remove(0, SQL.Length);
                SQL.Append("select code from Master_Product_Group");
                SQL.AppendFormat("\n WHERE  id = {0}", GroupId);
                string GroupCode = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();

                SQL.Remove(0, SQL.Length);
                SQL.Append("select code from Master_Product");
                SQL.AppendFormat("\n WHERE  id = {0}", KEY);
                code = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
                txtGroup_Code.Text = GroupCode + "." + code;
                ProductIsSelected(KEY);
            }
        }


        //salesreturn,purchasereturn,damagequantity,soldquantity,stock,purchageQuantity
        private bool CheckStock(string productId, out string purchaseId, double quantity, string stockType, out string salesId)
        {
            purchaseId = "";
            salesId = "";
            double stock = RestoSys.Inventory.dal.getStock(productId);
            double newStock = 0;
            if (stockType.IsIn(StockType.Damaged, StockType.Lost, StockType.PurchaseReturn, StockType.Sales, StockType.IngredientConsumed))
            {
                newStock = stock - quantity;
            }
            else if (stockType.IsIn(StockType.SalesReturn, StockType.StockEntry))
            {
                newStock = stock + quantity;
            }
            else
            {
                throw new Exception("CheckStock not implemented");
            }
            if (newStock < 0)
            {
                MessageBoxMy.Show("There are only " + stock.ToString() + " in store . " + StockType.GetEntryTypeText(ProductEntryType) + " Entry cannot be more than that quantity.", MessageBoxButtons.OK);
                //MessageBoxMy.Show("Please select a different entry from The displayed grid , this selection causes the stock to be less than zero", MessageBoxButtons.OK);
                return false;
            }

            //damage loss /sales might not have purchase id hence try catch
            try
            {
                DataGridViewRow row = grid.Rows[grid.SelectedCells[0].RowIndex];
                purchaseId = row.Cells["purchaseid"].Value.ToString();
            }
            catch { }

            if (stockType == StockType.SalesReturn)
            {
                // string salesId = "";
                try
                {
                    DataGridViewRow row = grid.Rows[grid.SelectedCells[0].RowIndex];
                    salesId = row.Cells["salesid"].Value.ToString();
                }
                catch
                {
                    MessageBoxMy.Show("Please select the sales item to return.", MessageBoxButtons.OK);
                    return false;
                }


                double CumulativeSalesReturn = 0;
                double qtySold = Convert.ToDouble(RestoSys.RestoSysDAl.GetQuantity("Inv_Sale", salesId.ToString(), "Quantity"));
                CumulativeSalesReturn = quantity + Convert.ToDouble(RestoSys.RestoSysDAl.GetQuantity("Inv_Sale", salesId.ToString(), "salesreturn"));
                if (CumulativeSalesReturn > qtySold)
                {
                    MessageBoxMy.Show("Total Return quantiy cannot be more than quantity sold,Please select a different sales Entry", MessageBoxButtons.OK);
                    return false;
                }
                double refundAmount = 0;
                double discount = Convert.ToDouble(RestoSys.RestoSysDAl.GetQuantity("Inv_Sale", salesId.ToString(), "Discount"));

                double rate = 0;
                try
                {
                    rate = Convert.ToDouble(txtRate.Text);
                }
                catch 
                {
                    MessageBoxMy.Show("Rate is not valid Please check it .", MessageBoxButtons.OK);
                    return false;
                }
                double discountper = discount / qtySold;
                refundAmount = quantity * (rate - discountper);
                if (MessageBoxMy.Show("Please Refund Rs " + Math.Round(refundAmount, 2) + "\nDiscount at time of Purchase = Rs " + Math.Round(discount, 2) + ",Quantity Sold = " + qtySold + "\nAdjusted rate =" + Math.Round(rate - discountper, 2), MessageBoxButtons.OK) == DialogResult.OK)
                {
                    string updateSql = string.Format("update inv_sale set salesreturn = '{0}' where id = {1}", CumulativeSalesReturn, salesId);
                    int retval = GlobalResources.SelectDBConnection.ExecuteNonQuery(updateSql.ToString());
                    if (retval < 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }

        private void calculateAmount()
        {
            double rate, quantity, amount;
            try
            {
                quantity = Convert.ToDouble(txtQuantity.Text);
                rate = Convert.ToDouble(txtRate.Text);
                amount = quantity * rate;
                amount = Math.Round(amount, 2);
                txtAmount.Text = amount.ToString();
            }
            catch  
            {
                txtAmount.Text = "0";
            }
        }

        private void updateDiscount()
        {
            decimal discountA, discountP, amount;
            bool isNum = decimal.TryParse(txtDiscountPercent.Text, out discountP);
            bool isNuma = decimal.TryParse(txtAmount.Text, out amount);
            bool isNumd = decimal.TryParse(txtDiscount.Text, out discountA);
            if (amount == 0)
            {
                return;
            }
            if (txtAmount.Focused | txtDiscount.Focused | txtQuantity.Focused)
            {
                discountP = (discountA / amount) * 100;
                discountP = Math.Round(discountP, 2);
                txtDiscountPercent.Text = discountP.ToString();
            }
            else if (txtDiscountPercent.Focused)
            {

                discountA = (discountP / 100) * amount;
                discountA = Math.Round(discountA, 2);
                txtDiscount.Text = discountA.ToString();
            }
        }

        #endregion

        










    }
}
