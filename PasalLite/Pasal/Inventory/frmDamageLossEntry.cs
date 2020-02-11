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
    public partial class frmDamageLossEntry : Friuts.EntryFormBase
    {
        public frmDamageLossEntry()
        {
            InitializeComponent();

            TableName = "Inv_Damage_Loss_Return";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("fk_Product", ColumnTypes.Number, txtProduct, true, "Product", "");
            ColumnList.AddNewEditColumn("Quantity", ColumnTypes.Number, txtQuantity);
            ColumnList.AddNewEditColumn("Remarks", ColumnTypes.String, txtRemarks);
            //ColumnList.AddNewEditColumn("loss_code",ColumnTypes.String , txtloss_code );
            ColumnList.AddNewEditColumn("fk_User", ColumnTypes.Number, GlobalValues.LoginUserID);
            ColumnList.AddNewEditColumn("entrydate", ColumnTypes.String, DateTime.Now.ToString("yyyyMMdd"));
            this.AcceptButton = btnOk;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string getUnit(string id)
        {
            string unit = "";
            StringBuilder SQL = new StringBuilder();

            SQL.Append("SELECT symbol from unit_Master where id = " + id);
            try
            {
                unit = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            }
            catch { return ""; }

            return unit;

        }
        private double getquantity(string id)
        {

            string quantity;
            StringBuilder SQL = new StringBuilder();

            SQL.Append("SELECT quantity_instore from Product_Master where id = " + id.ToString());
            quantity = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            if (quantity != "")
            {
                return Convert.ToDouble(quantity);
            }
            return 0;
        }

        //private int getComboID()
        //{
        //    string id;
        //    ComboItem ci=         (ComboItem)cboProduct.SelectedItem;
        //    id=  ci.Key.ToString ();
        //    return Convert.ToInt16(id);
        //}
        private void UpdatequantityTOStore(string id, double damageqty, double quantity)
        {

            double quantityinstore = quantity - damageqty;

            double totaldamagequantity;

            totaldamagequantity = Convert.ToDouble(getDamagequantity(id));
            StringBuilder SQL = new StringBuilder();
            SQL.Append("UPDATE Product_Master set quantity_instore = ");
            SQL.AppendFormat(" {0} ", quantityinstore);
            SQL.AppendFormat("where id = {0} ", id.ToString());
            GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL.ToString()).ToString();

            totaldamagequantity += damageqty;

            StringBuilder SQL1 = new StringBuilder();
            SQL1.Append("UPDATE Product_Master set quantity_damage = ");
            SQL1.AppendFormat(" {0} ", totaldamagequantity);
            SQL1.AppendFormat("where id = {0} ", id.ToString());
            GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL1.ToString()).ToString();

        }

        private string getDamagequantity(string id)
        {

            string quantity;
            StringBuilder SQL = new StringBuilder();
            try
            {
                SQL.Append("SELECT quantity_damage from Product_Master where id = " + id.ToString());
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void clearValuesinLabel()
        {
            lblListPrice.Text = "";

            lblName.Text = lblfk_Group.Text = lblfk_Company.Text = "";

            lblsizeunit.Text = lblweightunit.Text = lblcolour.Text = lblweight.Text = "";

            lblsize.Text =  lblentrydate.Text = "";

        }
        
         
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtGroup_Code.Focused)
            {
                clearValuesinLabel();
                string[] a;
                a = txtGroup_Code.Text.Split('.');
                if (a.Length != 2)
                {
                    MessageBox.Show("Please give code in format : Group Code.Item Code eg 25.201");
                    return;
                }
                string product;
                product = dal.GetProductIdFromCode (a[0], a[1]);
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
            string id;
            double damageqty, quantity;
            id = txtProduct.Text;
            quantity = getquantity(id.ToString());
            damageqty = Convert.ToDouble(txtQuantity.Text);
            if (damageqty > quantity)
            {
                MessageBoxMy.Show("There are only " + quantity.ToString() + " in store . Damage cannot be more than that quantity.", MessageBoxButtons.OK);
                return;
            }
            if (Save())
            {
                UpdatequantityTOStore(id, damageqty, quantity);
            }
        }

        private void frmDamageLossEntry_Load(object sender, EventArgs e)
        {
            this.FirstControl = txtProduct;
            //ComboBoxDataLoader loader = new ComboBoxDataLoader();

            //loader.ComboLoadinfoItems.Add("ID", "code", "Product_Master", cboProduct , true);
            ////  loader.ComboLoadinfoItems.Add("ID", "id", "Inv_Purchase", cboPurchage, true);
            //loader.LoadDataInComboBoxes();
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
            
                //DataGridViewRow row = (DataGridViewRow)frm.SelectedValue;
                string KEY = SelectedPrimaryKey;// row.Cells["colid"].Value.ToString();
                //SelectComboValue(cboProduct, KEY);
                txtProduct.Text = KEY;
                if (KEY != "")
                {
                    txtGroup_Code.Text = ProductIsSelected(KEY);
                }
            
        }

        private void displayvaluesinLabel(DataTable productddt)
        {

            //  if (product == null | product .Tables .Count ==0| product .Tables [0].Rows .Count ==0 )
            if (productddt.Rows.Count > 0)
            {

            //    lblListPrice.Text = productddt.Rows[0]["listprice"].ToString();

                lblName.Text = productddt.Rows[0]["Name"].ToString();

                lblfk_Group.Text = productddt.Rows[0]["fk_Group"].ToString();

                lblfk_Company.Text = productddt.Rows[0]["fk_Company"].ToString();

                lblsizeunit.Text = getUnit(productddt.Rows[0]["fk_sizeunit"].ToString());

                lblweightunit.Text = getUnit(productddt.Rows[0]["fk_weightunit"].ToString());

                lblcolour.Text = productddt.Rows[0]["colour"].ToString();

                lblweight.Text = productddt.Rows[0]["weight"].ToString();

                lblsize.Text = productddt.Rows[0]["size"].ToString();

             //   lblquantityinStore.Text = productddt.Rows[0]["quantity_instore"].ToString();

              

                lblentrydate.Text = productddt.Rows[0]["entrydate"].ToString();

                lblMeasureUnit.Text = getUnit(productddt.Rows[0]["fk_MeasureUnit"].ToString());

            }
        }

        private string ProductIsSelected(string prodid)
        {//Retruns Group.code
            DataTable dt = new DataTable();
            string  GroupId, groupCode, mycode,itemCode;
            StringBuilder SQL = new StringBuilder();
            SQL.Append("select fk_Group from Product_Master");
            SQL.AppendFormat("\n WHERE  Product_Master.id = {0}", prodid);
            GroupId = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            
            DataSet product = isProductExist(prodid);
            displayvaluesinLabel(product.Tables[0]);
            
            SQL.Remove(0, SQL.Length);
            SQL.Append("select code from Product_Group_Master");
            SQL.AppendFormat("\n WHERE  id = {0}", GroupId);
            groupCode = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            
            SQL.Remove(0, SQL.Length);
            SQL.Append("select code from product_Master");
            SQL.AppendFormat("\n WHERE  id = {0}", prodid);
            itemCode = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            mycode = groupCode + "." + itemCode;
            return mycode;
        }
        private DataSet isProductExist(string productId)
        {
            DataSet product;
            StringBuilder SQL = new StringBuilder();

            SQL.Append("SELECT * from Product_Master where id = " + productId);
            try
            {
                product = GlobalResources.SelectDBConnection.ExecuteDataSet(SQL.ToString());
            }
            catch { product = null; }
            return product;

        }

    }
}
