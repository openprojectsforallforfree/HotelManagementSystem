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
namespace Pasal.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmProductEntry : Friuts.EntryFormBase
    {
        public frmProductEntry()
        {
            InitializeComponent();
            TableName = "Product_Master";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.Add("Name", ColumnTypes.String, txtName, true, "Name", string.Empty);
            ColumnList.AddNewEditColumn("fk_Group", ColumnTypes.Number, cboGroup);
            ColumnList.AddNewEditColumn("fk_Company", ColumnTypes.Number, cboCompany);
            ColumnList.AddNewEditColumn("fk_sizeunit", ColumnTypes.Number, cboSizeUnit);
            ColumnList.AddNewEditColumn("fk_weightunit", ColumnTypes.Number, cboWeightUnit);
            ColumnList.AddNewEditColumn("colour", ColumnTypes.String, txtcolour);
            ColumnList.AddNewEditColumn("weight", ColumnTypes.Number, txtweight);
            ColumnList.AddNewEditColumn("size", ColumnTypes.Number, txtsize);
            ColumnList.AddNewEditColumn("reorderpoint", ColumnTypes.Number, txtreorderpoint);
            //ColumnList.AddNewEditColumn("Rate", ColumnTypes.Number, txtRate);
            ColumnList.AddNewEditColumn("Remarks", ColumnTypes.String, txtRemarks);
           
            ColumnList.AddNewEditColumn("fk_MeasureUnit", ColumnTypes.Number, cboMeasureUnit);
            ColumnList.AddNewEditColumn("fk_User", ColumnTypes.Number, GlobalValues.LoginUserID);
            ColumnList.AddNewEditColumn("entrydate", ColumnTypes.String, DateTime.Now.ToString("yyyyMMdd"));

            //sql = sql & "and cast(convert(varchar,date_viewed,101) as datetime) >= cast('"&trim(hdnsdates)&"' as datetime)"

            ColumnList.AddNewEditColumn("Code", ColumnTypes.String, txtCode, true, "Code", string.Empty);
            //ColumnList.AddNewEditColumn("standardcost", ColumnTypes.Number, txtstandardcost);
            //ColumnList.AddNewEditColumn("listprice", ColumnTypes.Number, txtlistprice, true, "List Price", string.Empty);


        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns>true if already used </returns>
        private Boolean checkCode()
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
            sql.AppendFormat("select * from Product_Master where fk_Group = {0} and code = '{1}' ", GroupId, txtCode.Text);
            //}
            //else
            //{
            //    sql.AppendFormat("select * from Product_Master where fk_Group = {0} and code = {1} and id != {2}", GroupId, txtCode.Text, txtId.Text);
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
            bool saved = false;
             if (Bsoft.AppCom.Entities.DataSave.isRunOk(TableName, (new frmRegister()), 5))
                return;
            if (checkCode())
            {
                saved = Save();
            }
            else
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
            if (saved)
            {
                if (FormType == FormTypes.EntryForm)
                {
                    int pk = getLatestIdFromSQL(InsertSQL, "Id");
                    tags.ItemID = pk.ToString();
                }
                tags.Save();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        Pasal.Tags.frmProductDescription tags = new Pasal.Tags.frmProductDescription();
        private void frmProductEntry_Load(object sender, EventArgs e)
        {
            this.FirstControl = cboGroup;
            txtName.Focus();
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Product_Group_Master", cboGroup, true);
            loader.LoadDataInComboBoxes();
            loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Product_Company_Master", cboCompany, true);
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

            tags.flwTags.Parent = this.grpTags;

            if (FormType == FormTypes.EditForm)
            {
                LoadData();
                tags.LoadTags();
                tags.ItemID = txtId.Text;
            }
            else
            {//entry form
                tags.LoadTags();
                //tags.ItemID = "0";
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
                Pasal.MasterEntry.frmProductGroupList frm = new Pasal.MasterEntry.frmProductGroupList();
                frm.ShowDialog();
                ComboBoxDataLoader loader = new ComboBoxDataLoader();
                loader.ComboLoadinfoItems.Add("ID", "Name", "Product_Group_Master", cboGroup, true);
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
            Pasal.MasterEntry.frmProductCompanyList frm = new Pasal.MasterEntry.frmProductCompanyList();
            frm.ShowDialog();
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Product_Company_Master", cboCompany, true);
            loader.LoadDataInComboBoxes();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            //unit
            Pasal.MasterEntry.frmUnitList frm = new Pasal.MasterEntry.frmUnitList();
            frm.ShowDialog();
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Unit_Master", cboMeasureUnit, true);
            loader.LoadDataInComboBoxes();

        }


    }
}
