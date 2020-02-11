using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
namespace Pasal.Inventory
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmPurchageList : Friuts.ListingFormBase
    {
        public frmPurchageList()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            TableName = "Inv_Purchase";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            //DataTableColumns.Add("ManufactureDate", ColumnTypes.EnglishDate, "colManufactureDate");
            //DataTableColumns.Add("ExpiryDate", ColumnTypes.EnglishDate, "colExpiryDate");
            RelationList.Add("fk_Product", "Product_Master", "id", "Name", "colfk_Product");
            RelationList.Add("fk_Vendor", "Vendor_Master", "id", "Name", "colfk_Vendor");
            RelationList.Add("fk_Product", "Product_Master", "id", "Code", "colCode", TableJoinTypes.LEFT_JOIN);
            //  RelationList.Add("fk_Product", "Product_Master", "id", "listprice", "colListPrice");
            // RelationList.Add("fk_Product", "Product_Master", "id", "Code", "colCode");
            // RelationList.Add("fk_Product", "Product_Master", "id", "Code", "colCode");
            //DataTableColumns.Add("fk_Product", ColumnTypes.Number, "colfk_Product");
            //DataTableColumns.Add("fk_Vendor", ColumnTypes.Number, "colfk_Vendor");
            //DataTableColumns.Add("Quantity", ColumnTypes.String, "colQuantity");
            DataTableColumns.Add("t1_Id", ColumnTypes.String, "colId");
            DataTableColumns.Add("t1_ManufactureDate", ColumnTypes.EnglishDate, "colManufactureDate");
            DataTableColumns.Add("t1_ExpiryDate", ColumnTypes.EnglishDate, "colExpiryDate");
            DataTableColumns.Add("t1_Quantity", ColumnTypes.AmountRound2, "colQuantity");
            DataTableColumns.Add("t2_ProductName", ColumnTypes.String, "colfk_Product");
            DataTableColumns.Add("VendorName", ColumnTypes.String, "colfk_Vendor");
            DataTableColumns.Add("Code", ColumnTypes.String , "colCode");
            DataTableColumns.Add("standardcost", ColumnTypes.AmountRound2, "colstandardcost");
            DataTableColumns.Add("listprice", ColumnTypes.AmountRound2, "collistprice");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public override bool LoadData()
        {
            return base.LoadData();
        }
        public override string GetWhereClauseForSelect()
        {
            return "";
        }
        public override bool GenerateSelectSQL()
        {
            StringBuilder SQL = new StringBuilder();
            SQL.Append("\nSELECT");
            SQL.Append("\nt1.Id t1_Id,");
            SQL.Append("\nt1.ManufactureDate t1_ManufactureDate,");
            SQL.Append("\nt1.ExpiryDate t1_ExpiryDate,");
            SQL.Append("\nt1.Quantity t1_Quantity,");

            SQL.Append("\nt2.Name t2_ProductName,");
            SQL.Append("\nt3.Name VendorName,");
            SQL.Append("\nt4.Name t4_Groupname,");
            SQL.Append("\nt1.fk_Product t1_fk_Product,");

            SQL.Append(" \n cast(t4.Code as nvarchar ) || '.' || cast(t2.Code as nvarchar ) as code,");
            SQL.Append("\nt1.costprice as standardcost ,");
            SQL.Append("\nt1.sellingprice as listprice ");
            SQL.Append("\nFROM");
            SQL.Append("\nInv_Purchase t1 ");
            SQL.Append("\nleft outer join ");
            SQL.Append("\nProduct_Master t2 on ");
            SQL.Append("\nt1.fk_product=t2.id");
            SQL.Append("\nleft outer join ");
            SQL.Append("\nProduct_Group_Master t4 on");
            SQL.Append("\nt2.fk_group =t4.id");
            SQL.Append("\nleft outer join ");
            SQL.Append("\nVendor_Master t3 on");
            SQL.Append("\nt1.fk_vendor =t3.id");
            SQL.Append("\nleft outer join ");
            SQL.Append("\nProduct_Company_Master company on");
            SQL.Append("\nt2.fk_Company =company.id");
            SQL.Append("\nWHERE ");
            SQL.Append("\nt1.fk_Product = t2.id");
            //SQL.Append("\nt1.fk_Product = t2.id");
            // SQL.AppendFormat ("\nt1.entrydate >= cast ('{0}' as datetime) and t1.entrydate <= cast ('{1}' as datetime)",);
            //entrydate

            if (searchCriterion1 .dtFromPurchage.Checked)
            {
                SQL.Append(" \n AND t1.PurchageDate >= '" + searchCriterion1.dtFromPurchage.Value.ToString("yyyyMMdd") + "'");
            }
            if (searchCriterion1.dtToPurchage .Checked)
            {
                SQL.Append(" \n AND t1.PurchageDate <= '" + searchCriterion1.dtToPurchage.Value.ToString("yyyyMMdd") + "'");
            }
            ComboItem citem;
            if (searchCriterion1.cboGroup.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboGroup.SelectedItem;

                SQL.Append(" \n AND t2.id=" + citem.Key.ToString());
            }
            if (searchCriterion1.cboCompany.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboCompany.SelectedItem;
                SQL.Append(" \n AND company.id=" + citem.Key.ToString());
            }
            if (searchCriterion1.cboVendor.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboVendor.SelectedItem;
                SQL.Append(" \n AND t3.id=" + citem.Key.ToString());
            }
            if (searchCriterion1.txtName.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND t2.name like '{0}%'", searchCriterion1.txtName.Text.Trim());
            }
            if (searchCriterion1.txtCode.Text.ToLower().Trim() != "")
            {
                string[] a;
                a = searchCriterion1.txtCode.Text.Split('.');
                SQL.Append(" \n AND t4.code=" + a[0].ToString());
                SQL.Append(" \n AND t2.Code=" + a[1].ToString());
            }
            SelectSQL = SQL.ToString();
            return true;
        }
        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }
        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new frmPuchagedEntry());
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new frmPuchagedEntry());
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }



        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPurchageList_Load(object sender, EventArgs e)
        {
            if (this.FormType == FormTypes.SelectionForm)
            {
                toolStrip1.Enabled = false;
            }

            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Product_Group_Master", searchCriterion1.cboGroup, false);
            loader.LoadDataInComboBoxes();

            ComboBoxDataLoader loader1 = new ComboBoxDataLoader();
            loader1.ComboLoadinfoItems.Add("ID", "Name", "Product_Company_Master", searchCriterion1.cboCompany, false);
            loader1.LoadDataInComboBoxes();

            ComboBoxDataLoader loader2 = new ComboBoxDataLoader();
            loader2.ComboLoadinfoItems.Add("ID", "Name", "Vendor_Master", searchCriterion1.cboVendor, false);
            loader2.LoadDataInComboBoxes();

        

        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            UEMS.Reports.ExcelReport exrept = new  UEMS.Reports.ExcelReport(this.Text, 4, grid);
        }

        private void ExitToolbar_Click_1(object sender, EventArgs e)
        {
            Pasal.MasterEntry.frmProductList frm = new Pasal.MasterEntry.frmProductList();
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] a;
            if (searchCriterion1.txtCode.Text.ToLower().Trim() != "")
            {
                a = searchCriterion1.txtCode.Text.Split('.');
                if (a.Length != 2)
                {
                    MessageBox.Show("Please give code in format : Group Code.Item Code eg 25.201");
                    return;
                }
            }
            SearchConditionList.Clear();
            LoadData();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
