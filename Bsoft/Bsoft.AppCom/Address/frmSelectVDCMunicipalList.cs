using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Friuts;
using UEMS.BLL;
using Bsoft.AppCom;

namespace UEMS.Forms.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmSelectVDCMunicipalList : ListingFormBase
    {
        public string _OpenFrom = string.Empty;
        public bool _isFixed = false;
        public string _zoneID = string.Empty;
        public string _districtID = string.Empty;
        public string _vdcID = string.Empty ;

        public frmSelectVDCMunicipalList() 
        {
            InitializeComponent();
            FormType = FormTypes.SelectionForm;
            ListingDataGridView = dataGridView1;
            TableName = "VDC";
        }

        public frmSelectVDCMunicipalList(string zoneID, string districtID, string vdcID)
        {
            InitializeComponent();
            FormType = FormTypes.SelectionForm;
            ListingDataGridView = dataGridView1;
            TableName = "VDC";
            _districtID = districtID;
            _zoneID = zoneID;
            _vdcID = vdcID;
        }

        //this OpenFrom is Optional 
        public frmSelectVDCMunicipalList(string openFrom,bool isFixed) //in this form constructur pass the compulsory other wise error.
        {
            InitializeComponent();
            _OpenFrom = openFrom.ToUpper();
            _isFixed = isFixed; 

            if (_OpenFrom == "OLDVDC")
            {
                TableName = "OLDVDC";
            }
            else
            {
                TableName = "VDC";
            }
            FormType = FormTypes.SelectionForm;
            ListingDataGridView = dataGridView1;
        }

        private void frmSelectVDCMunicipalList_Load(object sender, EventArgs e)
           {
            LoadDataInGrid();
            AddConditionalListing();

            if (_isFixed)
            {
                int districtID = ConstantValues.Org_DistrictId;
                int zoneID = ConstantValues.Org_ZoneId;

                SelectComboValue(cmbDistrict, districtID.ToString());
                SelectComboValue(cmbZone, zoneID.ToString());    

                txtZoneID.Enabled = false;
                txtDistrictID.Enabled = false;
                cmbZone.Enabled = false;
                cmbDistrict.Enabled = false;
                btnAddEdit.Visible = false;
            }
            else
            {
                cmbZone.Enabled = true;
                txtZoneID.Enabled = true;
                cmbDistrict.Enabled = true;
                txtDistrictID.Enabled = true;

                btnAddEdit.Visible = true;  
            }

            AddSearchCriteria();
            LoadData(); 
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
            if (_OpenFrom != "OLDVDC")
            {
                SearchConditionList.Clear();
                SearchConditionList.AddCriteria(ColumnTypes.Number, "DISTRICTID", ComparisionTypes.EQUAL, cmbDistrict);
            }
            else
            {
                SearchConditionList.Clear();
                SearchConditionList.AddCriteria(ColumnTypes.Number, "DISTRICTID", ComparisionTypes.EQUAL, cmbDistrict);
                SearchConditionList.AddCriteria(ColumnTypes.Number, "ZONEID", ComparisionTypes.EQUAL, cmbZone);        
            }
        }


        private void AddConditionalListing()
        {
            ComboBoxDataLoader loader = new ComboBoxDataLoader();

            if (_isFixed)
            {
                loader.ComboLoadinfoItems.Add("ZONEID", "NEPNAME", "ZONE", cmbZone, true, ColumnTypes.Number,string .Empty );
                loader.ComboLoadinfoItems.Add("DISTRICTID", "NEPNAME", "DISTRICT", cmbDistrict, true, ColumnTypes.Number, string.Empty);
                loader.LoadDataInComboBoxes();
            }
            else
            {
                loader.ComboLoadinfoItems.Add("ZONEID", "NEPNAME", "ZONE", cmbZone, true, ColumnTypes.Number, string.Empty);
                loader.ComboLoadinfoItems.AddDependent("DISTRICTID", "NEPNAME", "DISTRICT", cmbDistrict, true, ColumnTypes.Number, cmbZone, "ZONEID");
                loader.LoadDataInComboBoxes();
            }
        }

        private void RefreshData()
        {
            AddSearchCriteria();
            LoadData();
        }

        private void cmbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDistrict.SelectedItem != null)
            {
                ComboItem itm = (ComboItem)cmbDistrict.SelectedItem;
                txtDistrictID.Text = itm.Key;
                RefreshData();
            }

        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (_OpenFrom != "OLDVDC")
            {
                ComboItem itmZone = (ComboItem)cmbZone.SelectedItem;
                string zoneKey = itmZone.Key;
                ComboItem itmDistrict = (ComboItem)cmbDistrict.SelectedItem;
                string districtKey = itmDistrict.Key;
                string vdcKey = string.Empty;
                if (dataGridView1.CurrentRow != null)
                {
                    vdcKey = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                }
                MasterEntry.frmPresentVDCMunicipalList frm = new UEMS.Forms.MasterEntry.frmPresentVDCMunicipalList(zoneKey, districtKey, vdcKey);
                frm.ShowDialog(this);
            }
            else
            {
                //MasterEntry.frmOldVdcMunicipalList frm = new TPPIMS.Forms.MasterEntry.frmOldVdcMunicipalList();
                //frm.ShowDialog(this);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReturnSelectedValue();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVDCName_TextChanged(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i < dataGridView1.Rows.Count; i++)
            {
                if (txtVDCName.Text == dataGridView1.Rows[i].Cells["Nepname"].ToString())
                {
                    dataGridView1.Rows[i].Selected = true;
                }
            }
        }

        private void txtEngname_TextChanged(object sender, EventArgs e)
        {
            //Grid.CurrentRow.Cells["TaxID"].Value.ToString();
            int i;
            for (i = 1; i < dataGridView1.Rows.Count; i++)
            {
                if (txtEngname.Text == dataGridView1.Rows[i].Cells["NepName"].ToString())
                {
                    dataGridView1.Rows[i].Selected = true;
                }
            }
        }

        //Sets the selected values for Zone, District and VDC
        private void frmSelectVDCMunicipalList_Activated(object sender, EventArgs e)
        {
            if (_OpenFrom != "OLDVDC")
            {
                if (_zoneID != null)
                {
                    SelectComboValue(cmbZone, _zoneID);
                }
                if (_districtID != null)
                {
                    SelectComboValue(cmbDistrict, _districtID);
                }
                int rowcount = dataGridView1.Rows.Count;
                for (int i = 0; i < rowcount; i++)
                {
                    if (dataGridView1.Rows[i].Cells["ID"].Value.ToString() == _vdcID)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells["ID"];
                    }
                }

            } 
         
        }

        private void cmbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbZone.SelectedItem != null)
            {
                ComboItem itm = (ComboItem)cmbZone.SelectedItem;
                txtZoneID.Text = itm.Key;
            }
        }

        private void txtZoneID_Validating(object sender, CancelEventArgs e)
        {
            if (cmbZone.Items.Count == 0)
                return;
            ComboItem itm = null;
            itm = ComboUtilities.SelectComboBoxItemUsingKey(cmbZone, txtZoneID.Text.Trim());
            if (itm == null)
                e.Cancel = true;
        }

        private void txtDistrictID_Validating(object sender, CancelEventArgs e)
        {
            if (cmbDistrict.Items.Count == 0)
                return;
            ComboItem itm = null;
            itm = ComboUtilities.SelectComboBoxItemUsingKey(cmbDistrict, txtDistrictID.Text.Trim());
            if (itm == null)
                e.Cancel = true;
        }



    }
}

