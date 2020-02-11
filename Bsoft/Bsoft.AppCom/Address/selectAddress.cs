using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Bsoft.Data;

namespace UEMS.Address
{
  public   class selectAddress
    {
        #region SelectionOfAddressFromTree



        private static string getEngDistrictName(string DistrictID)
        {
            //Set the District Name
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT");
            sql.Append("\n\tDistrictName");
            sql.Append("\nFROM");
            sql.Append("\n\tDistrict");
            sql.Append("\nWHERE");
            sql.AppendFormat("\n\tDistrictID ='{0}'", DistrictID);

            DataTable dtDistrict = null;

            dtDistrict = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
            if (dtDistrict.Rows.Count > 0)
            {
                if (dtDistrict != null && dtDistrict.Rows != null && dtDistrict.Rows.Count > 0)
                {
                    return dtDistrict.Rows[0]["DistrictName"].ToString();
                }
            }
            return "";
        }

        private static string getEngVDCName(string VdcID)
        {
            //set vdc name
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT");
            sql.Append("\n\tVDCName");
            sql.Append("\nFROM");
            sql.Append("\n\tVDC");
            sql.Append("\nWHERE");
            sql.AppendFormat("\n\tVdcID ='{0}'", VdcID);

            DataTable dtVdc = null;

            dtVdc = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
            if (dtVdc.Rows.Count > 0)
            {
                if (dtVdc != null && dtVdc.Rows != null && dtVdc.Rows.Count > 0)
                {
                    return dtVdc.Rows[0]["VDCName"].ToString();
                }
            }
            return "";

        }
        private static string getEngZoneName(string ZoneID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT");
            sql.Append("\n\tZoneName");
            sql.Append("\nFROM");
            sql.Append("\n\tZone");
            sql.Append("\nWHERE");
            sql.AppendFormat("\n\tZoneID ='{0}'", ZoneID);

            DataTable dt = null;

            dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
            if (dt.Rows.Count > 0)
            {
                if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["ZoneName"].ToString();
                }
            }
            return "";
        }
        public static void ClearAddress(Control ZoneIdCtrl, Control DistrictIdCtrl, Control VDCIDCtrl, Control ZoneNp, Control DistrictNp, Control VDCNp, Control ZoneEng, Control DistrictEng, Control VDCEng)
        {
            if (ZoneIdCtrl != null)
                ZoneIdCtrl.Text = "";
            if (DistrictIdCtrl != null)
                DistrictIdCtrl.Text = "";
            if (VDCIDCtrl != null)
                VDCIDCtrl.Text = "";
            
            if (ZoneNp != null)
                ZoneNp.Text = "";
            if (DistrictNp != null)
                DistrictNp.Text = "";
            if (VDCNp != null)
                VDCNp.Text = "";

            if (ZoneEng != null)
                ZoneEng.Text = "";
            if (DistrictEng != null)
                DistrictEng.Text = "";
            if (VDCEng != null)
                VDCEng.Text = "";
        }
        public static void SelectionOfAddressFromTree(Control ZoneIdCtrl, Control DistrictIdCtrl, Control VDCIDCtrl, Control ZoneNp, Control DistrictNp, Control VDCNp, Control ZoneEng, Control DistrictEng, Control VDCEng)
        {
            string zoneID = ZoneIdCtrl == null ? null : ZoneIdCtrl.Text.ToString();
            string districtID = DistrictIdCtrl == null ? null : DistrictIdCtrl.Text.ToString();
            string vdcID = VDCIDCtrl == null ? null : VDCIDCtrl.Text.ToString();
            //address selection
            UEMS.Forms.MasterEntry.frmSelectVDCMunicipaListView frm = new UEMS.Forms.MasterEntry.frmSelectVDCMunicipaListView(zoneID, districtID, vdcID);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                TreeNode node = (TreeNode)frm.SelectedValue;
                if (node.Level == 3)
                {
                    string ZoneName = node.Parent.Parent.Text;
                    string ZoneID = node.Parent.Parent.Name;

                    string DistrictName = node.Parent.Text;
                    string DistrictID = node.Parent.Name;

                    string VdcName = node.Text;
                    string VdcID = node.Name;

                    if (ZoneEng != null)
                    {
                        ZoneEng.Text = getEngZoneName(zoneID);
                    }
                    if (DistrictEng != null)
                    {
                        DistrictEng.Text = getEngDistrictName(districtID);
                    }
                    if (VDCEng != null)
                    {
                        VDCEng.Text = getEngVDCName(vdcID);
                    }

                    int startPositin = -1;
                    startPositin = DistrictName.IndexOf("-"); //get the index of "-"
                    DistrictNp.Text = DistrictName.Substring(0, startPositin);
                    VDCNp.Text = VdcName.ToString();

                    if (ZoneIdCtrl != null)
                        ZoneIdCtrl.Text = ZoneID.ToString();


                    if (DistrictIdCtrl != null)
                        DistrictIdCtrl.Text = DistrictID.ToString();

                    if (VDCIDCtrl != null)
                        VDCIDCtrl.Text = VdcID.ToString();
                    startPositin = -1;
                    ZoneNp.Text = ZoneName.ToString();
                    startPositin = ZoneName.IndexOf("-");
                    ZoneNp.Text = ZoneName.Substring(0, startPositin);
                }
            }
        }


        #endregion
    }
}
