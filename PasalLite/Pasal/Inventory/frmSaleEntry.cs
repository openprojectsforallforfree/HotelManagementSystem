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
namespace Pasal.Inventory
{
    public enum ProductEntryType
    {
        Sales,
        damageLoss,
        salesReturn,
        purchageReturn
    }
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmSaleEntry : Friuts.EntryFormBase
    {
        public ProductEntryType ProductEntryType;
        public string purchageId = "";
        public string costPrice = "";
         
        public frmSaleEntry()
        {
            InitializeComponent();
            FormType = FormTypes.EntryForm;
        }
        public frmSaleEntry(ProductEntryType ProductEntryType_)
        {
            ProductEntryType = ProductEntryType_;

            InitializeComponent();
            if (ProductEntryType == ProductEntryType.damageLoss)
            {
                grpDiscount.Visible = false;
                Text = "Damage Lost Entry";
            }
            else if (ProductEntryType == ProductEntryType.purchageReturn)
            {
                grpDiscount.Visible = false;
                Text = "Purchase Return Entry";
            }
            else if (ProductEntryType == ProductEntryType.salesReturn)
            {
                grpDiscount.Visible = false;
                Text = "Sales Return Entry";
            }
            FormType = FormTypes.EntryForm;
        }
       
        //Either browsed or code entered.
        public bool ProductIsSelected(string productId)
        {
            txtProduct.Text = productId;
            txtQuantity.SelectAll();
            txtQuantity.Focus();

            DataSet product;
            StringBuilder SQL = new StringBuilder();

            SQL.Append("SELECT * from Product_Master where id = " + productId);
            try
            {
                product = GlobalResources.SelectDBConnection.ExecuteDataSet(SQL.ToString());
            }
            catch { product = null; }

            DataTable productddt = product.Tables[0];

            if (productddt.Rows.Count > 0)
            {
                lblName.Text = productddt.Rows[0]["Name"].ToString();
                lblfk_Group.Text = Pasal.Inventory.dal.getGroup(productddt.Rows[0]["fk_Group"].ToString());
                lblfk_Company.Text = Pasal.Inventory.dal.getCompany(productddt.Rows[0]["fk_Company"].ToString());
                lblsizeunit.Text = Pasal.Inventory.dal.getUnit(productddt.Rows[0]["fk_sizeunit"].ToString());
                lblweightunit.Text = Pasal.Inventory.dal.getUnit(productddt.Rows[0]["fk_weightunit"].ToString());
                lblcolour.Text = productddt.Rows[0]["colour"].ToString();
                lblweight.Text = productddt.Rows[0]["weight"].ToString();
                lblsize.Text = productddt.Rows[0]["size"].ToString();
                label5.Text = productddt.Rows[0]["Remarks"].ToString();
                //lblfk_User.Text =getUser( productddt.Rows[0]["fk_User"].ToString());
                //lblentrydate.Text = productddt.Rows[0]["entrydate"].ToString();
                lblMeasureUnit.Text = Pasal.Inventory.dal.getUnit(productddt.Rows[0]["fk_MeasureUnit"].ToString());


            }

            //Display rate info

            SQL.Remove(0, SQL.Length);


            if (ProductEntryType == ProductEntryType.salesReturn)
            {

                SQL.Remove(0, SQL.Length);
                SQL.AppendLine("select t1.id,Inv_Purchase.id as purchaseid  ,t1.date as [Selling\nDate],cast (t1.quantity as decimal(10,2)) as Quantity,cast (t1.salesreturn as decimal(10,2))  as [Sales\nReturn],cast (t1.rate as decimal(10,2))  as MRP ,cast (t1.discount as decimal(10,2)) as [Discount\nGiven],cast (t1.netamount as decimal(10,2)) as Amount,Rights_Users.ENGNAME as username ,t1.remarks from Inv_Sale t1");
                SQL.AppendLine(" left outer join Inv_Purchase on");
                SQL.AppendLine(" Inv_Purchase.id = t1.fk_Purchage");
                SQL.AppendLine(" left outer join Product_Master on");
                SQL.AppendLine(" Product_Master.id = Inv_Purchase.fk_Product");
                SQL.AppendLine(" left outer join Rights_Users on");
                SQL.AppendLine(" Rights_Users.id = t1.fk_user ");
                SQL.AppendLine(" where 1=1  ");
                SQL.AppendFormat("AND t1.date >= '{0}'", DateTime.Now.AddDays(-30).ToString("yyyyMMdd"));
                SQL.AppendFormat("AND t1.date <= '{0}'", DateTime.Now.ToString("yyyyMMdd"));
                SQL.AppendFormat("and Product_Master.id = {0}", productId);

                DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
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
                    grid.Columns["id"].Visible = false;
                    grid.Columns["purchaseid"].Visible = false;
                }
            }
            else
            {
                

                string sql = @"
SELECT Inv_Purchase.id, purchagedate  as [Purchage Date],
cast (sellingprice as decimal(10,2))  as MRP,
costprice,
cast (quantity as decimal(10,2))  as QTY,
cast ( quantity_sold as decimal(10,2)) as SOLD ,
cast (quantity_damage as decimal(10,2))  as Damaged, 
 quantity-quantity_sold-quantity_damage-purchaseReturn+salesReturn   as Stock, 
manufacturedate as [Mnf Date],
ExpiryDate as [Ex Date], 
vendor_master.Name as [vendor Name],
remarks from Inv_Purchase
left join vendor_master on fk_vendor=vendor_master.id
where fk_product={0} and  quantity-quantity_sold-quantity_damage-purchaseReturn+salesReturn > 0

                ".With(productId );

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
                    grid.Columns["id"].Visible = false;
                    grid.Columns["costprice"].Visible = false;
                }

            }
            return true;
            //lblquantityinStore.Text = productddt.Rows[0]["quantity_instore"].ToString();
            //lblListPrice.Text = productddt.Rows[0]["listprice"].ToString();
            //lblCostPrice.Text = productddt.Rows[0]["StandardCost"].ToString();
        }

        #region actions
        private void clearValuesinLabel()
        {
            //lblListPrice.Text = "";
            lblName.Text = lblfk_Group.Text = lblfk_Company.Text = "";
            lblsizeunit.Text = lblweightunit.Text = lblcolour.Text = lblweight.Text = "";
            lblsize.Text = lblRemarks.Text = "";
            lblMeasureUnit.Text = "";
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

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void searhItemClick(string searchString)
        {
            Pasal.MasterEntry.frmProductList frm = new Pasal.MasterEntry.frmProductList();
            frm.FormType = FormTypes.SelectionForm;
            frm.txtName.Text = searchString;
            frm.valueSelected += new ListingFormBase.ValueSelected(frm_valueSelected);
            frm.ShowDialog(this);
            
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
                SQL.Append("select fk_Group from Product_Master");
                SQL.AppendFormat("\n WHERE  id = {0}", KEY);
                GroupId = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();


                SQL.Remove(0, SQL.Length);
                SQL.Append("select code from Product_Group_Master");
                SQL.AppendFormat("\n WHERE  id = {0}", GroupId);
                string GroupCode = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();

                SQL.Remove(0, SQL.Length);
                SQL.Append("select code from product_Master");
                SQL.AppendFormat("\n WHERE  id = {0}", KEY);
                code = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
                txtGroup_Code.Text = GroupCode + "." + code;
                ProductIsSelected(KEY);
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            searhItemClick("");
        }

        private void frmSaleEntry_Load(object sender, EventArgs e)
        {
            ListingFormBase lsfb = new ListingFormBase();
            lsfb.SetDataGridViewProperties(grid);
            lblDate.Text = "Date : " + DateTime.Today.ToShortDateString();
            this.FirstControl = txtGroup_Code;
            txtGroup_Code.Select();
            //ComboBoxDataLoader loader = new ComboBoxDataLoader();
            //loader.ComboLoadinfoItems.Add("ID", "code", "Product_Master", cboProduct, true);
            //loader.LoadDataInComboBoxes();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            
            bool searchEntry = false;
            string product;
            if (txtDiscount.Text == "")
            {
                txtDiscount.Text = "0";
            }
            if (txtGroup_Code.Focused)
            {
                //Clearing
                clearValuesinLabel();
                //Validation
                //code ok?
                string[] code;
                code = txtGroup_Code.Text.Split('.');
                if (code.Length != 2)
                {
                    searchEntry = true;
                    // show the search form
                    //MessageBox.Show("Please give code in format : Group Code. Item code eg 25.201");
                    //return;
                }
                //Product exist?
                if (searchEntry)
                {
                    txtProduct.Text = "";
                    searhItemClick(txtGroup_Code.Text);
                    return;
                }
                else
                {
                    product = Pasal.Inventory.dal.GetProductIdFromCode(code[0], code[1]);
                    if (product == null)
                    {
                        searchEntry = true;
                        txtProduct.Text = "";
                        searhItemClick(txtGroup_Code.Text);
                        return;
                        // MessageBox.Show("Product Not found Please check the code.");
                        // txtProduct.Text = "";
                        // return;
                    } 
                }
                // For the product deatails
                // get the products inventory detail from Inv_Purchase
                if (ProductIsSelected(product))
                {
                    txtProduct.Text = product;
                    txtQuantity.SelectAll();
                    txtQuantity.Focus();
                }
                else
                { txtGroup_Code.Select(); }

                return;
            }

            //Real ok click here
            if (txtProduct.Text == "")
            {
                MessageBoxMy.Show("Please select a Product First", MessageBoxButtons.OK);
                return;
            }
            try
            {
                if (Convert.ToDecimal(txtQuantity.Text.Trim()) <= 0)
                {
                    MessageBoxMy.Show("Please enter quantity", MessageBoxButtons.OK);
                    txtQuantity.Focus();
                    txtQuantity.Select();
                    return;
                }
            }
            catch
            {
                MessageBoxMy.Show("Please enter quantity", MessageBoxButtons.OK); txtQuantity.Focus();
                txtQuantity.Select(); return;
            }
            int Purchaseid;
            double qtyInTxtBox, stock;
            DataGridViewRow row = grid.Rows[grid.SelectedCells[0].RowIndex];
            string purchaseId = "";

 try
            {
            qtyInTxtBox = Convert.ToDouble(txtQuantity.Text);
            }
            catch
            {
                MessageBoxMy.Show("Quantity is not valid Please check it .", MessageBoxButtons.OK);
                return;
            }
            try
            {
              double   rate = Convert.ToDouble(txtRate.Text);
                //rate = 2;
              double amount = qtyInTxtBox * rate;
                amount = Math.Round(amount, 2);
                txtAmount.Text = amount.ToString();
            }
            catch (Exception ex)
            {
                txtAmount.Text = "0";
                MessageBoxMy.Show("Rate is not valid Please check it .", MessageBoxButtons.OK);
                return;
            }
            if (ProductEntryType == ProductEntryType.damageLoss)
            {
                purchaseId = row.Cells["id"].Value.ToString();
                Purchaseid = Convert.ToInt16(purchaseId);
                stock = Pasal.Inventory.dal.getStock(Purchaseid);
                if (qtyInTxtBox > stock)
                {
                    MessageBoxMy.Show("There are only " + stock.ToString() + " in store . Loss Entry cannot be more than that quantity.", MessageBoxButtons.OK);
                }
                if (txtRemarks.Text.Trim() == "")
                {
                    MessageBoxMy.Show("Please Enter the Cause of damage or loss in Remarks.", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBoxMy.Show("Do you want to register Damage/Loss Entry ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UpdateDamagequantityTOStore(purchaseId, qtyInTxtBox);
                    MessageBoxMy.Show("Data is Entered.", MessageBoxButtons.OK);
                    DialogResult = DialogResult.OK;
                }
            }
            else if (ProductEntryType == ProductEntryType.purchageReturn)
            {
                purchaseId = row.Cells["id"].Value.ToString();
                Purchaseid = Convert.ToInt16(purchaseId);
                stock = Pasal.Inventory.dal.getStock(Purchaseid);
                if (qtyInTxtBox > stock)
                {
                    MessageBoxMy.Show("There are only " + stock.ToString() + " in store . Purchase return cannot be more than that quantity.", MessageBoxButtons.OK);
                }
                if (txtRemarks.Text.Trim() == "")
                {
                    MessageBoxMy.Show("Please Enter the Cause of Purchase Return in Remarks.", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBoxMy.Show("Do you want to register Purchase Return ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UpdatePurchageReturnToStore(purchaseId, qtyInTxtBox);
                    MessageBoxMy.Show("Data is Entered.", MessageBoxButtons.OK);
                    DialogResult = DialogResult.OK;
                }
            }
            else if (ProductEntryType == ProductEntryType.salesReturn)
            {
                purchaseId = row.Cells["purchaseid"].Value.ToString();
                Purchaseid = Convert.ToInt16(purchaseId);
                if (txtRemarks.Text.Trim() == "")
                {
                    MessageBoxMy.Show("Please Enter the Cause of Sales Return in Remarks.", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBoxMy.Show("Do you want to register Sales Return ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (UpdatesalesReturnToStore(purchaseId, Convert.ToDouble(txtQuantity.Text)))
                    {
                        MessageBoxMy.Show("Data is Entered.", MessageBoxButtons.OK);
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else if (ProductEntryType == ProductEntryType.Sales)
            {
                purchaseId = row.Cells["id"].Value.ToString();
                Purchaseid = Convert.ToInt16(purchaseId);
                stock = Pasal.Inventory.dal.getStock(Purchaseid);
                if (qtyInTxtBox > stock)
                {
                    MessageBoxMy.Show("There are only " + stock.ToString() + " in store . Selling cannot be more than that quantity.", MessageBoxButtons.OK);
                    return;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool UpdatesalesReturnToStore(string Purchageid, double returnQty)
        {
            double totalReturnquantity_Inv_Purchage;
            totalReturnquantity_Inv_Purchage = Convert.ToDouble(getquantity(Purchageid, "salesReturn"));
            double purchaseqty = Convert.ToDouble(getquantity(Purchageid, "Quantity"));
            totalReturnquantity_Inv_Purchage += returnQty;
            if (totalReturnquantity_Inv_Purchage > purchaseqty)
            {
                MessageBoxMy.Show("Please select a different entry for sales return , this selection causes the stock to be more than purchase quantity.", MessageBoxButtons.OK);
                return false;
            }
            string salesId = "";
            try
            {
                DataGridViewRow row = grid.Rows[grid.SelectedCells[0].RowIndex];
                salesId = row.Cells["id"].Value.ToString();
            }
            catch
            {
                MessageBoxMy.Show("Please select the sales item to return.", MessageBoxButtons.OK);
                return false;
            }
            double totalreturnQty_Inv_Sales = 0;
            double qtySold = 0;
            totalreturnQty_Inv_Sales = Convert.ToDouble(getquantity("Inv_Sale", salesId.ToString(), "SalesReturn"));
            qtySold = Convert.ToDouble(getquantity("Inv_Sale", salesId.ToString(), "Quantity"));
            totalreturnQty_Inv_Sales += returnQty;
            if (totalreturnQty_Inv_Sales > qtySold)
            {
                MessageBoxMy.Show("Total Return quantiy cannot be more than quantity sold", MessageBoxButtons.OK);
                return false;
            }

            double refundAmount = 0;
            double discount = Convert.ToDouble(getquantity("Inv_Sale", salesId.ToString(), "Discount"));

            double rate = 0;
            try
            {
                rate = Convert.ToDouble(txtRate.Text);

            }
            catch (Exception ex)
            {
                MessageBoxMy.Show("Rate is not valid Please check it .", MessageBoxButtons.OK);
                return false;
            }

            double discountper = discount / qtySold;
            refundAmount = returnQty * (rate - discountper);
            if (MessageBoxMy.Show("Please Refund Rs " + Math.Round(refundAmount, 2) + "\nDiscount at time of Purchase = Rs " + Math.Round(discount, 2) + ",Quantity Sold = " + qtySold + "\nAdjusted rate =" + Math.Round(rate - discountper, 2), MessageBoxButtons.OK) == DialogResult.OK)
            {
                StringBuilder SQL1 = new StringBuilder();
                //update invpurchase
                SQL1.Append("UPDATE Inv_Purchase set salesReturn = ");
                SQL1.AppendFormat(" {0} ", totalReturnquantity_Inv_Purchage);
                SQL1.AppendFormat("where id = {0} ", Purchageid.ToString());
                GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL1.ToString()).ToString();
                // insert sales return
                SQL1.Remove(0, SQL1.Length);
                SQL1.Append(@"INSERT INTO  Inv_Sales_Return
            (fk_purchage,Quantity,Remarks,Date,fk_User) values ");
                SQL1.AppendFormat("({0}, {1}, '{2}','{4}',{3} )", Purchageid, returnQty, txtRemarks.Text, GlobalValues.LoginUserID, DateTime.Now.ToString("yyyyMMdd"));
                GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL1.ToString()).ToString();
                //update inv_sales


                SQL1.Remove(0, SQL1.Length);
                SQL1.AppendFormat("UPDATE Inv_Sale set SalesReturn =  {0} ", totalreturnQty_Inv_Sales);
                SQL1.AppendFormat("where id = {0} ", salesId.ToString());
                GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL1.ToString()).ToString();



                return true;
            }
            return false;
        }

        private void UpdatePurchageReturnToStore(string Purchageid, double returnQty)
        {
            double totalReturnquantity;
            totalReturnquantity = Convert.ToDouble(getquantity(Purchageid, "purchaseReturn"));
            totalReturnquantity += returnQty;
            StringBuilder SQL1 = new StringBuilder();
            SQL1.Append("UPDATE Inv_Purchase set purchaseReturn = ");
            SQL1.AppendFormat(" {0} ", totalReturnquantity);
            SQL1.AppendFormat("where id = {0} ", Purchageid.ToString());
            GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL1.ToString()).ToString();

            //main db
            SQL1.Remove(0, SQL1.Length);
            SQL1.Append(@"INSERT INTO  Inv_Purchase_Return
            ( 
fk_purchage,
Quantity
           ,Remarks
           ,Date
           ,fk_User) values ");
            SQL1.AppendFormat("({0}, {1}, '{2}','{4}',{3} )", Purchageid, returnQty, txtRemarks.Text, GlobalValues.LoginUserID, DateTime.Now.ToString("yyyyMMdd"));
            GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL1.ToString()).ToString();

        }

        private void UpdateDamagequantityTOStore(string Purchageid, double lossQty)
        {
            double totalLossquantity;
            totalLossquantity = Convert.ToDouble(getquantity(Purchageid, "quantity_damage"));
            totalLossquantity += lossQty;
            StringBuilder SQL1 = new StringBuilder();
            SQL1.Append("UPDATE Inv_Purchase set quantity_damage = ");
            SQL1.AppendFormat(" {0} ", totalLossquantity);
            SQL1.AppendFormat("where id = {0} ", Purchageid.ToString());
            GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL1.ToString()).ToString();

            //main db
            SQL1.Remove(0, SQL1.Length);
            SQL1.Append(@"INSERT INTO  Inv_Damage_Loss_Return
            ( 
            fk_purchage,
            Quantity
           ,Remarks
           ,Date
           ,fk_User) values ");
            SQL1.AppendFormat("({0}, {1}, '{2}','{4}',{3} )", Purchageid, lossQty, txtRemarks.Text, GlobalValues.LoginUserID, DateTime.Now.ToString("yyyyMMdd"));
            GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL1.ToString()).ToString();

        }

        private string getquantity(string table, string id, string field)
        {
            string quantity;
            StringBuilder SQL = new StringBuilder();
            try
            {
                SQL.AppendFormat("SELECT {0} from {1} where id = {2}", field, table, id);
                quantity = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
                if (quantity != "")
                {
                    return quantity;
                }
            }
            catch
            {
                return "0";
            }
            return "0";
        }

        private string getquantity(string purchageId, string field)
        {
            string quantity;
            StringBuilder SQL = new StringBuilder();
            try
            {
                SQL.AppendFormat("SELECT {0} from Inv_Purchase where id = " + purchageId.ToString(), field);
                quantity = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
                if (quantity != "")
                {
                    return quantity;
                }
            }
            catch
            {
                return "0";
            }
            return "0";
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
            calculate();
        }

        private void calculate()
        {
            double rate, quantity, amount;
            try
            {
                quantity = Convert.ToDouble(txtQuantity.Text);

            }
            catch
            {
               // MessageBoxMy.Show("Quantity is not valid Please check it .", MessageBoxButtons.OK);
                return;
            }
            try
            {
                rate = Convert.ToDouble(txtRate.Text);
                //rate = 2;
                amount = quantity * rate;
                amount = Math.Round(amount, 2);
                txtAmount.Text = amount.ToString();
            }
            catch (Exception ex)
            {
                txtAmount.Text = "0";
               // MessageBoxMy.Show("Rate is not valid Please check it .", MessageBoxButtons.OK);
            }
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            txtQuantity.SelectAll();
        }

   
        #endregion
        public bool blnFromEdit = false;
        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            if (!blnFromEdit)
            {
                try
                {
                    txtRate.Text = grid["MRP", grid.SelectedCells[0].RowIndex].Value.ToString();
                    purchageId = grid["id", grid.SelectedCells[0].RowIndex].Value.ToString();
                    costPrice = grid["costprice", grid.SelectedCells[0].RowIndex].Value.ToString();
                    calculate();
                }
                catch { }
            }
        }

        public void selectSuitableGridItem(string purchageId_)
        {
            purchageId = purchageId_;
            try
            {
                foreach (DataGridViewRow dgvr in grid.Rows)
                {
                    if (dgvr.Cells["id"].Value.ToString().Trim() == purchageId.ToString().Trim())
                    {
                        dgvr.Cells["QTY"].Selected = true;
                        try
                        {
                            txtRate.Text = grid["MRP", grid.SelectedCells[0].RowIndex].Value.ToString();
                            // purchageId = grid["id", grid.SelectedCells[0].RowIndex].Value.ToString();
                            costPrice = grid["costprice", grid.SelectedCells[0].RowIndex].Value.ToString();
                            calculate();
                        }
                        catch { }

                        return;
                    }
                }
            }
            catch { }
           // blnFromEdit =false ;
        }

        private void grid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            blnFromEdit = false;
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //blnFromEdit = false;
        }

    }
}
