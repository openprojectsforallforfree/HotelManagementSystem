using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using UEMS.BLL;
using Bsoft.Data;

namespace UEMS.Forms.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmPresentVDCMunicipalNew : EntryFormBase
    {
        private ComboItem _zoneComboItem = null;
        private ComboItem _districtComboItem = null;

        public frmPresentVDCMunicipalNew(ComboItem zoneComboItem, ComboItem districtComboItem)
        {
            InitializeComponent();
            TableName = "VDC";

            _zoneComboItem = zoneComboItem;
            _districtComboItem = districtComboItem;
        }

        private void frmPresentVDCMunicipalNew_Load(object sender, EventArgs e)
        {
            //add these code in the begining of the load function
            if (_districtComboItem != null
                && _zoneComboItem != null
                )
            {
                cmbZone.Items.Add(_zoneComboItem);
                cmbZone.SelectedItem = _zoneComboItem;
                cmbDistrict.Items.Add(_districtComboItem);
                cmbDistrict.SelectedItem = _districtComboItem;

                lblZoneName.Text = _zoneComboItem.Value;
                lblDistrictName.Text = _districtComboItem.Value;

                string zoneKey = _zoneComboItem.Key;
                string districtKey = _districtComboItem.Key;
                txtZoneID.Text = zoneKey;
                txtDistrictID.Text = districtKey;
            }

            StringBuilder sql = new StringBuilder();
            sql.Remove(0, sql.Length);
            sql.Append("SELECT");
            sql.Append("\n\tNvl(Max(serial), 0) + 1");
            sql.Append("\nAS Serial");
            sql.Append("\nFROM");
            sql.Append("\n\tVDC");



            DataTable dt = null;

            dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
            if (dt.Rows.Count > 0)
            {
                if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
                {
                    txtSerial.Text = dt.Rows[0]["Serial"].ToString();
                }
            }

            ColumnList.AddNewEditColumn("VDCID", ColumnTypes.Number, txtVDCID, true, true);
            ColumnList.AddNewEditColumn("NEPNAME", ColumnTypes.String, txtVDCname, true, "NepName", "uf.lj.;./g.kf. sf] gfd vfnL % M");
            ColumnList.AddNewEditColumn("VDCNAME", ColumnTypes.String, txtVDCengname, true, "VdcNameEnglish", "c_u|]hL gfd vfnL % M");
            ColumnList.AddNewEditColumn("ZONEID", ColumnTypes.Number, txtZoneID);
            ColumnList.AddNewEditColumn("DISTRICTID", ColumnTypes.Number, txtDistrictID);
            ColumnList.AddNewEditColumn("SERIAL", ColumnTypes.Number, txtSerial);
        }

  
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

