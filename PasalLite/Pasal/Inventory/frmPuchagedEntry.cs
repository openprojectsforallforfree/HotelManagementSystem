using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using UEMS.BLL;
using Bsoft.Forms;
using Bsoft.Data;
using Bsoft.AppCom;
namespace Pasal.Inventory
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmPuchagedEntry : Friuts.EntryFormBase
    {
        public frmPuchagedEntry()
        {
            InitializeComponent();

            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Vendor_Master", cboVendor, true);
            loader.LoadDataInComboBoxes();
            TableName = "Inv_Purchase";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("ManufactureDate", ColumnTypes.String, dtManufacture);
            ColumnList.AddNewEditColumn("ExpiryDate", ColumnTypes.String, dtExpiry);
            ColumnList.AddNewEditColumn("fk_Product", ColumnTypes.Number, txtProduct, true, "Product", "");
            ColumnList.AddNewEditColumn("fk_Vendor", ColumnTypes.Number, cboVendor);

            ColumnList.AddNewEditColumn("Quantity", ColumnTypes.Number, txtQuantity);
            //ColumnList.AddNewEditColumn("Code", ColumnTypes.String, txtCode);
            //ColumnList.AddNewEditColumn("standardcost ", ColumnTypes.Number, txtstandardcost);
            //ColumnList.AddNewEditColumn("listprice ", ColumnTypes.Number, txtlistprice);
            //Added Later 
            ColumnList.AddNewEditColumn("CostPrice", ColumnTypes.Number, txtCostPrice);
            ColumnList.AddNewEditColumn("SellingPrice", ColumnTypes.Number, txtSellingPrice);
            ColumnList.AddNewEditColumn("PurchageDate", ColumnTypes.String, dtPurchageDate.Value.ToString("yyyyMMdd"));

            if (FormType == FormTypes.EntryForm)
            {
                ColumnList.AddNewEditColumn("quantity_damage", ColumnTypes.Number, 0);
                ColumnList.AddNewEditColumn("quantity_sold", ColumnTypes.Number, 0);
            }
            ColumnList.Add("Remarks", ColumnTypes.String, txtRemarks);
            ColumnList.AddNewEditColumn("fk_User", ColumnTypes.Number, GlobalValues.LoginUserID);
            ColumnList.AddNewEditColumn("entrydate", ColumnTypes.String, DateTime.Now.ToString("yyyyMMdd"));

            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
        }
        private double getquantity(int id)
        {
            string quantity = "";
            StringBuilder SQL = new StringBuilder();
            SQL.Append("SELECT quantity_instore from Product_Master where id = " + id.ToString());
            try
            {
                quantity = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            }
            catch { }
            if (quantity != "")
            {
                return Convert.ToDouble(quantity);
            }
            return 0;
        }
        private int getLatestID()
        {
            string id;
            StringBuilder SQL = new StringBuilder();
            SQL.Append("SELECT max(id) from Inv_Purchase");
            id = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            return Convert.ToInt16(id);
        }


        private void addquantityTOStore()
        {
            int id;
            double quantity;
            id = getLatestID();
            id = Convert.ToInt16(txtProduct.Text);
            quantity = getquantity(id);
            quantity += Convert.ToDouble(txtQuantity.Text);

            StringBuilder SQL = new StringBuilder();
            SQL.Append("UPDATE Product_Master set quantity_instore = ");
            SQL.AppendFormat(" {0} ", quantity);
            SQL.AppendFormat("where id = {0} ", id.ToString());
            GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL.ToString()).ToString();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
             if (Bsoft.AppCom.Entities.DataSave.isRunOk(TableName, (new frmRegister()), 5))
              return;
            bool searchEntry = false;
            if (txtGroup_Code.Focused)
            {
                clearValuesinLabel();
                string[] a;
                a = txtGroup_Code.Text.Split('.');
                if (a.Length != 2)
                {
                    MessageBox.Show("Please give code in format : GroupCode.ItemCode eg g25.201");
                    return;
                }
               
                string product;
                product = Pasal.Inventory.dal.GetProductIdFromCode(a[0], a[1]);
                try
                {
                    if (product == null)
                    {
                        MessageBox.Show("Product Not found Please check the code.");
                        txtProduct.Text = "";
                        return;
                    }
                    else
                    {

                        ProductIsSelected(product);
                        txtProduct.Text = product;
                    }
                }
                catch { return; }
                return;
            }
            try
            {
                double cp = Convert.ToDouble(txtCostPrice.Text.Trim());
                double sp = Convert.ToDouble(txtSellingPrice.Text.Trim());

                if (cp > sp)
                { MessageBoxMy.Show("Cost price can not be more than selling price ", MessageBoxButtons.OK); return; }

            }
            catch
            {
                MessageBoxMy.Show("Please give proper cost and selling price.", MessageBoxButtons.OK); return;
            }
            Save();
            string s = InsertSQL;
        }
        private void clearValuesinLabel()
        {
            lblName.Text = lblfk_Group.Text = lblfk_Company.Text = "";
            lblsizeunit.Text = lblweightunit.Text = lblcolour.Text = lblweight.Text = "";
            lblsize.Text = lblRemarks.Text = "";
            lblMeasureUnit.Text = "";
        }


        private void displayvaluesinLabel(DataTable productddt)
        {
            if (productddt.Rows.Count > 0)
            {
                lblName.Text = productddt.Rows[0]["Name"].ToString();
                lblfk_Group.Text = dal.getGroup(productddt.Rows[0]["fk_Group"].ToString());
                lblfk_Company.Text = dal.getCompany(productddt.Rows[0]["fk_Company"].ToString());
                lblsizeunit.Text = dal.getUnit(productddt.Rows[0]["fk_sizeunit"].ToString());
                lblweightunit.Text = dal.getUnit(productddt.Rows[0]["fk_weightunit"].ToString());
                lblcolour.Text = productddt.Rows[0]["colour"].ToString();
                lblweight.Text = productddt.Rows[0]["weight"].ToString();
                lblsize.Text = productddt.Rows[0]["size"].ToString();
                lblRemarks.Text = productddt.Rows[0]["Remarks"].ToString();
                lblMeasureUnit.Text = dal.getUnit(productddt.Rows[0]["fk_MeasureUnit"].ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPuchagedEntry_Load(object sender, EventArgs e)
        {
            this.FirstControl = txtGroup_Code;
            txtGroup_Code.Select();
            calculatorButton1.AssociatedControl = txtCostPrice;
            calculatorButton2.AssociatedControl = txtSellingPrice;
        }
        public override bool LoadData()
        {
            base.LoadData();
            txtGroup_Code.Text = ProductIsSelected(txtProduct.Text);
            //dtExpiry.Text = dtExpiry.Text;
            //dtManufacture.Text = dtManufacture.Text;
            return true;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Pasal.MasterEntry.frmProductList frm = new Pasal.MasterEntry.frmProductList();
            frm.FormType = FormTypes.SelectionForm;
            frm.toolStrip1.Enabled = false;
            frm.valueSelected += new ListingFormBase.ValueSelected(frm_valueSelected);
            frm.ShowDialog(this);
           
        }

        void frm_valueSelected(object sender, string SelectedPrimaryKey)
        {
            //DataGridViewRow row = (DataGridViewRow)((ListingFormBase)sender).SelectedValue;
           // DataGridViewRow row = (DataGridViewRow)frm.SelectedValue;
            string KEY = SelectedPrimaryKey;// row.Cells["colid"].Value.ToString();
            //SelectComboValue(cboProduct, KEY);
            txtProduct.Text = KEY;
            if (KEY != "")
            {
                txtGroup_Code.Text = ProductIsSelected(KEY);
            }
        }
        private void dtManufacture1_Validated(object sender, EventArgs e)
        {
            dtManufacture.Text = dtManufacture.Text;
        }

        private void dtExpiry1_Validated(object sender, EventArgs e)
        {
            dtExpiry.Text = dtExpiry.Text;
        }
        private void dtExpiry_Validated(object sender, EventArgs e)
        {
            dtExpiry.Text = dtExpiry.Text;
        }

        private void dtManufacture1_ValueChanged(object sender, EventArgs e)
        {
            dtManufacture.Text = dtManufacture.Text;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prodid"></param>
        /// <returns>Retruns group.code</returns>
        private string ProductIsSelected(string prodid)
        { 
            DataTable dt = new DataTable();
            string groupId, groupCode;
            StringBuilder SQL = new StringBuilder();
            //ComboItem ci = (ComboItem)cboProduct.SelectedItem;

            SQL.Append("select fk_Group from Product_Master");
            SQL.AppendFormat("\n WHERE  Product_Master.id = {0}", prodid);
            groupId = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            DataTable product = isProductExist(prodid);
            displayvaluesinLabel(product);

            string grpCd_itmCode, code;

            groupCode = GlobalResources.SelectDBConnection.ExecuteScalar("select code from  Product_Group_Master where id ='" + groupId + "' ").ToString();

            SQL.Remove(0, SQL.Length);
            SQL.Append("select code from product_Master");
            SQL.AppendFormat("\n WHERE  id = {0}", prodid);
            code = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            grpCd_itmCode = groupCode + "." + code;

            return grpCd_itmCode;
        }
        

        private DataTable isProductExist(string productId)
        {
            ////Make changes here to get all the data using the following logic
            ////DT From inv_purchage get stock of all rows with productId
            DataTable product;
            StringBuilder SQL = new StringBuilder();
            SQL.Append("SELECT * from Product_Master where id = " + productId);
            try
            {
                product = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            }
            catch
            {
                product = null;
            }
            return product;
        }

        private void lblfk_Vendor_Click(object sender, EventArgs e)
        {
            Pasal.MasterEntry.frmProductVendorList frm = new Pasal.MasterEntry.frmProductVendorList();
            frm.ShowDialog();
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Vendor_Master", cboVendor, true);
            loader.LoadDataInComboBoxes();
        }

    }
}
