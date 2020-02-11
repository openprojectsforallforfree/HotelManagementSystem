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
using RestoSys.BLL;
namespace RestoSys.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmProductEntry : Friuts.EntryFormBase
    {
        public frmProductEntry()
        {
            InitializeComponent();
            TableName = "Master_Product";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.Add("Name", ColumnTypes.String, txtName, true, "Name", string.Empty);
            ColumnList.AddNewEditColumn("fk_Group", ColumnTypes.Number, cboGroup);
            ColumnList.AddNewEditColumn("fk_Company", ColumnTypes.Number, cboCompany);
            ColumnList.AddNewEditColumn("fk_sizeunit", ColumnTypes.Number, cboSizeUnit);
            ColumnList.AddNewEditColumn("fk_weightunit", ColumnTypes.Number, cboWeightUnit);
            ColumnList.AddNewEditColumn("colour", ColumnTypes.String, txtcolour);
            ColumnList.AddNewEditColumn("sellingPrice", ColumnTypes.Number, txtSellingPrice);//added later for restomgt
            ColumnList.AddNewEditColumn("costPrice", ColumnTypes.Number, txtCostPrice);//added later for restomgt
            ColumnList.AddNewEditColumn("weight", ColumnTypes.Number, txtweight);
            ColumnList.AddNewEditColumn("size", ColumnTypes.Number, txtsize);
            ColumnList.AddNewEditColumn("reorderpoint", ColumnTypes.Number, txtreorderpoint);
            //ColumnList.AddNewEditColumn("Rate", ColumnTypes.Number, txtRate);
            ColumnList.AddNewEditColumn("Remarks", ColumnTypes.String, txtRemarks);

            ColumnList.AddNewEditColumn("fk_MeasureUnit", ColumnTypes.Number, cboMeasureUnit);
            ColumnList.AddNewEditColumn("UserId", ColumnTypes.String , GlobalValues.LoginUserName);
            ColumnList.AddNewEditColumn("entrydate", ColumnTypes.String, DateTime.Now.ToString("yyyyMMdd"));

            //sql = sql & "and cast(convert(varchar,date_viewed,101) as datetime) >= cast('"&trim(hdnsdates)&"' as datetime)"

            ColumnList.AddNewEditColumn("Code", ColumnTypes.String, txtCode, true, "Code", string.Empty);
            ColumnList.AddNewEditColumn("BarCode", ColumnTypes.String, txtBarCode);//, false, "BarCode", string.Empty);
            //ColumnList.AddNewEditColumn("standardcost", ColumnTypes.Number, txtstandardcost);
            //ColumnList.AddNewEditColumn("listprice", ColumnTypes.Number, txtlistprice, true, "List Price", string.Empty);


        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns>false if already used </returns>
        private Boolean isNewCode()
        {
            //return true;
            //returns if the code is valid ( unique )
            // code should be unique for the selected group but can repeat in itself
            StringBuilder sql = new StringBuilder();
            ComboItem ci = (ComboItem)cboGroup.SelectedItem;
            string GroupId = ci.Key;
            //if (txtId.Text.Trim() == "")
            //{
            //entry ,in this case the grop
            sql.AppendFormat("select * from Master_Product where fk_Group = {0} and code = '{1}' ", GroupId, txtCode.Text);
            //}
            //else
            //{
            //    sql.AppendFormat("select * from Master_Product where fk_Group = {0} and code = {1} and id != {2}", GroupId, txtCode.Text, txtId.Text);
            //}

            DataTable dt = new DataTable();
            dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
            if (dt == null || dt.Rows.Count <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            string t = TableName;
            if (txtSellingPrice.Visible && txtCostPrice.Visible)
            {
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
            }
            bool saved = false;
          


            if (FormType == FormTypes.EntryForm && !isNewCode())
            {
                string groupid;
                ComboItem ci = (ComboItem)cboGroup.SelectedItem;
                groupid = ci.Key;

                string oldcode = txtCode.Text;
                string newcode = Bsoft.Common.StringUtilities.GetIncreamentedValue(oldcode);
                txtCode.Text = newcode;
                string groupCode = staticClasses.GetGroupCode(groupid);
                string txt = string.Format("The {0}.{1} is already used {0}.{2} is selected for you!", groupCode, oldcode, newcode);
                MessageBoxMy.Show(txt, MessageBoxButtons.OK);
                saved = Save();
            }
            else
            {
                saved = Save();
            }
            if (saved)
            {
                string pk = "0";
                if (FormType == FormTypes.EntryForm)
                {
                    pk = getLatestIdFromSQL(InsertSQL, "Id").ToString();
              //      tags.ItemID = pk.ToString();
                }
                else
                {
                    pk = PrimaryKeyValue.ToString();
                }


              //  tags.Save();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //RestoSys.Tags.frmProductDescription tags = new RestoSys.Tags.frmProductDescription();
        private void frmProductEntry_Load(object sender, EventArgs e)
        {
            if (FormType != FormTypes.EntryForm)
            {
                txtCode.Enabled = false;
            }
            else
            {
                txtCode.Enabled = true;
            }
            this.FirstControl = cboGroup;
            txtName.Focus();
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Master_Product_Group", cboGroup, true);
            loader.LoadDataInComboBoxes();
            loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Master_Product_Company", cboCompany, true);
            loader.LoadDataInComboBoxes();
            loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Unit", "UnitView", cboSizeUnit, false, ColumnTypes.String, "Categogy like '%Length%'");
            loader.LoadDataInComboBoxes();
            loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Unit", "UnitView", cboWeightUnit, false, ColumnTypes.String, "Categogy like '%Weight%'");
            loader.LoadDataInComboBoxes();

            loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Unit", "UnitView", cboMeasureUnit, true);
            loader.LoadDataInComboBoxes();
            txtName.Select();

           // tags.flwTags.Parent = this.grpTags;

            if (FormType == FormTypes.EditForm)
            {
                LoadData();
             //   tags.LoadTags();
             //   tags.ItemID = txtId.Text;
            }
            else
            {//entry form
             //   tags.LoadTags();
               
            }

        }





        private void txtcolour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtcolour.BackColor = colorDialog1.Color;
            txtcolour.Text = colorDialog1.Color.Name;
        }

        private void fsButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtcolour.BackColor = colorDialog1.Color;

                txtcolour.Text = colorDialog1.Color.Name;
            }

        }





        private void lblfk_Group_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RestoSys.MasterEntry.frmProductGroupList frm = new RestoSys.MasterEntry.frmProductGroupList();
                frm.ShowDialog();
                ComboBoxDataLoader loader = new ComboBoxDataLoader();
                loader.ComboLoadinfoItems.Add("ID", "Name", "Master_Product_Group", cboGroup, true);
                loader.LoadDataInComboBoxes();
            }
        }

        private void cbmGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (FormType == FormTypes.EntryForm)
                {
                    string groupId;
                    ComboItem ci = (ComboItem)cboGroup.SelectedItem;
                    groupId = ci.Key;
                }
            }
            catch { }


        }

        private void lblfk_Company_Click(object sender, EventArgs e)
        {
            RestoSys.MasterEntry.frmProductCompanyList frm = new RestoSys.MasterEntry.frmProductCompanyList();
            frm.ShowDialog();
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Master_Product_Company", cboCompany, true);
            loader.LoadDataInComboBoxes();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            UEMS.frmUnit_MasterList frm = new UEMS.frmUnit_MasterList();
            frm.ShowDialog();
            //unit
            //RestoSys.MasterEntry.frmUnitList frm = new RestoSys.MasterEntry.frmUnitList();
            //frm.ShowDialog();
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Unit", "Master_Unit", cboMeasureUnit, true);
            loader.LoadDataInComboBoxes();

        }

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboItem ci = (ComboItem)cboGroup.SelectedItem;
            string GroupId = ci.Key;
            string IExp = RestoSysDAl.GetIncomeOrExpense(GroupId);

            if (IExp.Contains(ItemType.Service))//service
            {
                pnlCostPrice.Visible = lblCostPrice.Visible = txtCostPrice.Visible = false;
                pnlSellingPrice.Visible = lblSellingPrice.Visible = txtSellingPrice.Visible = true;
                grpDetails.Visible = false;
                lblGroupType.Text = "Service";

            }
            else if (IExp.Contains(ItemType.Retail))//retail (enter at purchase time)
            {
                pnlCostPrice.Visible = lblCostPrice.Visible = txtCostPrice.Visible = false;
                pnlSellingPrice.Visible = lblSellingPrice.Visible = txtSellingPrice.Visible = false;
                grpDetails.Visible = true;
                lblGroupType.Text = "Retail:Set cost/selling price during purchage entry";
            }
            else if (IExp.Contains(ItemType.Manufacture))//manufactured
            {
                pnlCostPrice.Visible = lblCostPrice.Visible = txtCostPrice.Visible = true;
                pnlSellingPrice.Visible = lblSellingPrice.Visible = txtSellingPrice.Visible = true;
                grpDetails.Visible = true;
                lblGroupType.Text = "Produced/Manufactured";
            }
            else if (IExp.Contains(ItemType.Consumable))//consumable
            {
                pnlCostPrice.Visible = lblCostPrice.Visible = txtCostPrice.Visible = true;
                pnlSellingPrice.Visible = lblSellingPrice.Visible = txtSellingPrice.Visible = false;
                grpDetails.Visible = true;
                lblGroupType.Text = "Consumable";
            }
            else if (IExp.Contains(ItemType.Ingredient))
            {
                pnlCostPrice.Visible = lblCostPrice.Visible = txtCostPrice.Visible = false;
                pnlSellingPrice.Visible = lblSellingPrice.Visible = txtSellingPrice.Visible = false;
                grpDetails.Visible = true;
                lblGroupType.Text = "Ingredients";
            }
            else if (IExp.Contains(ItemType.Lend))
            {
                pnlCostPrice.Visible = lblCostPrice.Visible = txtCostPrice.Visible = false;
                pnlSellingPrice.Visible = lblSellingPrice.Visible = txtSellingPrice.Visible = true;
                grpDetails.Visible = false;
                lblGroupType.Text = "Rent Items";
            }
            //else if (IExp.Contains("h"))
            //{
            //    lblCostPrice.Visible = txtCostPrice.Visible = true;
            //    lblSellingPrice.Visible = txtSellingPrice.Visible = true;

            //}
            if (txtSellingPrice.Visible == false)
            {
                txtSellingPrice.Text = "0";
            }

            if (txtCostPrice.Visible == false)
            {
                txtCostPrice.Text = "0";
            }

        }


    }
}
