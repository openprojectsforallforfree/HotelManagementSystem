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

namespace UEMS.Forms.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmPresentVDCMunicipalList : ListingFormBase
    {
        public string _zoneKey = null;
        public string _districtKey = null;
        public string _vdcKey = null;

        public frmPresentVDCMunicipalList(string zoneKey, string districtKey, string vdcKey)
        {
            InitializeComponent();
            TableName = "VDC";
            FormType = FormTypes.ListingForm;
            ListingDataGridView = dataGridView1;
            _zoneKey = zoneKey;
            _districtKey = districtKey;

            _vdcKey = vdcKey;
        }

        public frmPresentVDCMunicipalList()
        {
            InitializeComponent();
            TableName = "VDC";
            FormType = FormTypes.ListingForm;
            ListingDataGridView = dataGridView1;
            
        }

        private void frmPresentVDCMunicipalList_Load(object sender, EventArgs e)
        {
            LoadDataInGrid();

            AddConditionalListing();

            AddSearchCriteria();
            
        }

        private void LoadDataInGrid()
        {
            DataTableColumns.AddListColumn("VDCID", ColumnTypes.String, "ID", true,true);
            DataTableColumns.AddListColumn("NEPNAME", ColumnTypes.String, "NepName");
            DataTableColumns.AddListColumn("VDCNAME", ColumnTypes.String, "EngName");
            DataTableColumns.AddListColumn("SERIAL", ColumnTypes.String, "SerialNo");
        }

        private void AddSearchCriteria()
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "DISTRICTID", ComparisionTypes.EQUAL, cmbDistrict);
        }

        ComboBoxDataLoader loader = new ComboBoxDataLoader();
        private void AddConditionalListing()
        {
            loader.ComboLoadinfoItems.Clear();
            //Load zone information in cmbZone
            loader.ComboLoadinfoItems.Add("ZONEID", "ZONEID || '-' || NEPNAME", "ZONE", cmbZone, true,ColumnTypes.Number,string .Empty );
            //Load District Information as per zone selected in cmbZone.
            loader.ComboLoadinfoItems.AddDependent("DISTRICTID", "DISTRICTID || '-' || NEPNAME", "DISTRICT", cmbDistrict, true, ColumnTypes.Number, cmbZone, "ZONEID");
            loader.LoadDataInComboBoxes();

        }

        private void RefreshData()
        {
            AddSearchCriteria();
            LoadData();
        }

        private void cmbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

       public override bool OpenNewForm()
        {
            frmPresentVDCMunicipalNew frm = new frmPresentVDCMunicipalNew((ComboItem)cmbZone.SelectedItem, (ComboItem)cmbDistrict.SelectedItem);
                //(ComboItem)cmbZone.SelectedItem, (ComboItem)cmbDistrict.SelectedItem);
            return OpenNewForm(frm);
            
        }

        public override bool OpenEditForm()
        {
            frmPresentVDCMunicipalNew frm = new frmPresentVDCMunicipalNew((ComboItem)cmbZone.SelectedItem, (ComboItem)cmbDistrict.SelectedItem);
            return OpenEditForm(frm);
            
        }

        public override bool Delete()
        {
            if (base.DeleteDependentTableExists(dataGridView1, "Lands", "WARDNO", "ID"))
            {
                return false;
            }

            if (base.DeleteDependentTableExists(dataGridView1, "PEOPLE", "VDCID", "ID"))
            {
                return false;
            }

            if (base.DeleteDependentTableExists(dataGridView1, "BUSINESSMASTER", "VDCID", "ID"))
            {
                return false;
            }
            if (dataGridView1.CurrentRow ==null)
            {
                return false;
            }

            if (dataGridView1.CurrentRow.Cells["ID"].Value.ToString().Trim() == "")
            {
                return false;
            }
            string ID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString().Trim();

            //vdc id exists or not checking in CONSTANTVALUES
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT 1 FROM SuperAdmin_CONSTANTVALUES");
            sql.Append("\nWHERE");
            sql.Append("\nVarName = 'VDCID'");
            sql.AppendFormat("\n AND Strvalue = '{0}'", ID);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
            if (dt.Rows.Count > 0)
            {
                MessageBoxMy .Show("k|of]u ul<Psf] tYofª\\sx?nfO{ d]^fpg lgif]w ul<Psf] % È", MessageBoxButtons.OK);
                return false;
            }

            return base.Delete();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void cmbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbZone.SelectedItem != null)
            {
                ComboItem itm = (ComboItem)cmbZone.SelectedItem;
                txtZoneID.Text = itm.Key;
            }
        }

        private void cmbDistrict_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbDistrict.SelectedItem != null)
            {
                ComboItem itm = (ComboItem)cmbDistrict.SelectedItem;
                txtDistrictID.Text = itm.Key;
                RefreshData();
            }
        }

        private void txtZoneID_Validating(object sender, CancelEventArgs e)
        {
            if (cmbZone.Items.Count == 0)
                return;
            ComboItem itm = null;
            itm = ComboUtilities.SelectComboBoxItemUsingKey(cmbZone, txtZoneID.Text.Trim());
            if (itm == null)
                e.Cancel = false;
        }

        private void txtDistrictID_Validating(object sender, CancelEventArgs e)
        {
            if (cmbDistrict.Items.Count == 0)
                return;
            ComboItem itm = null;
            itm = ComboUtilities.SelectComboBoxItemUsingKey(cmbDistrict, txtDistrictID.Text.Trim());
            if (itm == null)
                e.Cancel = false;
        }

        //Sets the selected values for Zone, District and VDC
        private void frmPresentVDCMunicipalList_Activated(object sender, EventArgs e)
        {
            if (_zoneKey != null
                && _districtKey != null
                && _vdcKey != null)
            {                           
                SelectComboValue(cmbZone, _zoneKey);
                SelectComboValue(cmbDistrict, _districtKey);
                int rowcount = dataGridView1.Rows.Count;
                for (int i = 0; i < rowcount; i++)
                {
                    if (dataGridView1.Rows[i].Cells["ID"].Value.ToString() == _vdcKey)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells["ID"];
                    }
                }
                   
                
            }
        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
         //   Reports.ExcelReport Excel = new Reports.ExcelReport(this.Text, 4, dataGridView1);
        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

