using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using Friuts;
using Bsoft.Data;




namespace UEMS.Forms.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmSelectVDCMunicipaListView : ListingFormBase
    {
        #region Member Variables
        private DataTable _dtZone = null;
        private DataTable _dtDistrict = null;
        private DataTable _dtVDC = null;
        public string _zoneID = null;
        public string _districtID = null;
        public string _vdcID = null;

        
        #endregion
        public frmSelectVDCMunicipaListView(string zoneID, string districtID, string vdcID)
        {
            InitializeComponent();
            _zoneID = zoneID;
            _districtID = districtID;
            _vdcID = vdcID;
        }

        public frmSelectVDCMunicipaListView()
        {
            InitializeComponent();
            
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEditNew_Click(object sender, EventArgs e)
        {
            string zoneKey="", districtKey="", vdcKey="";
            try
            {
                 zoneKey = treeView1.SelectedNode.Parent.Parent.Name.ToString();
                 districtKey = treeView1.SelectedNode.Parent.Name.ToString();
                 vdcKey = treeView1.SelectedNode.Name.ToString();
            
           
            }
            catch { }
            UEMS.Forms.MasterEntry.frmSelectVDCMunicipalList frm = new UEMS.Forms.MasterEntry.frmSelectVDCMunicipalList(zoneKey, districtKey, vdcKey);
            frm.ShowDialog(this);
        }

        #region User Define Methods
        private void AddZoneToTreeView()
        { 
            DataTable dt = _dtZone;
            //add zone name
            if (dt.Rows.Count > 0)
            {
                treeView1.Nodes.Clear();
                TreeNode Nepal = new TreeNode();
                if (optEngLish.Checked)
                {
                    treeView1.Font = new Font("Times New Roman", 14);
                    Nepal.Text = "Nepal";
                }
                if (optNepali.Checked)
                {
                    treeView1.Font = new Font("Madan", 12);
                    Nepal.Text = "g]kfn";
                }
                Nepal.Name ="1";
                treeView1.ImageList = imageList1;
                Nepal.ImageIndex = 0;
                treeView1.Nodes.Add(Nepal);
                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    TreeNode ZoneName = new TreeNode();
                    ZoneName.ImageIndex = 1;
                    ZoneName.SelectedImageIndex = 1;

                    ZoneName.Text = dt.Rows[i]["NepName"].ToString() + " -" + dt.Rows[i]["dTot"].ToString() + " -" + dt.Rows[i]["vdctot"].ToString();
                    ZoneName.Name = dt.Rows[i]["ZoneID"].ToString();

                    Nepal.Nodes.Add(ZoneName);
                    Nepal.Expand();
                    AddDistrictToTreeView(ZoneName, ZoneName.Name,i);
                }
            }
        }

        public void AddDistrictToTreeView(TreeNode Parent, string ParentId,int a)
        {
            DataRow[] dRows = null;
            dRows = _dtDistrict.Select("ZoneID = " + Parent.Name);
            //add district name
            if (dRows.Length > 0)
            {
                int i;
                for (i = 0; i < dRows.Length; i++)
                {
                    TreeNode District = new TreeNode();
                    District.ImageIndex = 2;
                    District.SelectedImageIndex = 2;

                    District.Text = dRows[i]["DistrictName"].ToString();
                    District.Name = dRows[i]["DISTRICTID"].ToString();

                    if (i == 1)
                    {
                        District.Expand();
                    }
                    Parent.Nodes.Add(District);
                    ShowVDCName(District, District.Name, i);
                }
            }
        }

        private void ShowVDCName(TreeNode Parent, string ParentId, int a)
        {
            DataRow[] dRows = null;
            dRows = _dtVDC.Select("DistrictID = " + Parent.Name);
            if (dRows.Length > 0)
            {
                int i;

                for (i = 0; i < dRows.Length; i++)
                {
                    TreeNode Vdc = new TreeNode();
                    Vdc.ImageIndex = 3;
                    Vdc.SelectedImageIndex = 3;

                    Vdc.Text = dRows[i]["NepName"].ToString();
                    Vdc.Name = dRows[i]["VdcID"].ToString();

                    Parent.Nodes.Add(Vdc);
                }
            }
        }
        
        private void FindNodeInHierarchy(TreeNodeCollection nodes, string strSearchValue)
        {
            bool m_bNodeFound;
            for (int iCount = 0; iCount < nodes.Count; iCount++)
            {
                if (nodes[iCount].Text.ToUpper().Contains(strSearchValue.ToUpper()))
                { 
                    treeView1.SelectedNode = nodes[iCount];
                    treeView1.Select();                    
                    m_bNodeFound = true;
                    nodes[iCount].Expand();                
                    return;                
                }                
                else                
                {                    
                    m_bNodeFound = false;                
                }                
                //expand the nodes                
                nodes[iCount].Expand();                
                //Recursively search the text in the child nodes                
                FindNodeInHierarchy(nodes[iCount].Nodes, strSearchValue);
                if (m_bNodeFound)                
                {                    
                    return;                
                }                
                //collapses the nodes                
                //nodes[iCount].Collapse();   //it will very slow             
                //return;            
            }                    
        }

        private void NepalInfoDisplayNepalifont()
        {
            Console.WriteLine("Before executing query {0}", DateTime.Now.ToString("HH:mm:ss"));
            StringBuilder sqlVDC = new StringBuilder();
            sqlVDC.Append("SELECT");
            sqlVDC.Append("\n\tDISTINCT VdcID, NepName, DistrictID");
            sqlVDC.Append("\nFROM");
            sqlVDC.Append("\n\tVDC");
            sqlVDC.Append("\nWHERE");
            sqlVDC.Append("\n\tNepName IS NOT NULL ");
            _dtVDC = GlobalResources.SelectDBConnection.ExecuteDataTable(sqlVDC.ToString());


            StringBuilder sqlDistrict = new StringBuilder();
            sqlDistrict.Remove(0, sqlDistrict.Length);
            sqlDistrict.Append("SELECT");
            sqlDistrict.Append("\n\tDistrict.DistrictID, District.NepName || ' - ' || vd.tot DistrictName, District.ZoneID");
            sqlDistrict.Append("\nFROM");
            sqlDistrict.Append("\n\tDistrict");
            sqlDistrict.Append("\n\tLEFT JOIN (");
            sqlDistrict.Append("SELECT");
            sqlDistrict.Append("\n\tDistrictID, Count(1) TOT");
            sqlDistrict.Append("\nFROM");
            sqlDistrict.Append("\n\tVDC");
            sqlDistrict.Append("\n\tGROUP BY DistrictID ) vd ON VD.DistrictID = District.DistrictID");
            sqlDistrict.Append("\nWHERE");
            sqlDistrict.AppendFormat("\n\tDistrict.NepName IS NOT NULL ");
            //sqlDistrict.AppendFormat("\n\tAND District.ZoneID ='{0}'", ParentId);
            _dtDistrict =  GlobalResources .SelectDBConnection .ExecuteDataTable(sqlDistrict.ToString());

            StringBuilder sqlZone = new StringBuilder();
            sqlZone.Append("SELECT");
            sqlZone.Append("\n\tZONE.NepName, ZONE.ZoneID, d.dtot,v.vdctot");
            sqlZone.Append("\nFROM");
            sqlZone.Append("\nZONE");
            sqlZone.Append("\nLEFT JOIN (");
            sqlZone.Append("SELECT ");
            sqlZone.Append("\n\tZoneid, COUNT(1) dtot");
            sqlZone.Append("\nFROM");
            sqlZone.Append("\nDistrict");
            sqlZone.Append("\nGROUP BY ZOneid ) D ON ZONE.ZONEID =  D.ZONEID");
            sqlZone.Append("\nLEFT JOIN (");
            sqlZone.Append("SELECT");
            sqlZone.Append("\n\tZoneid, Count(1) vdctot");
            sqlZone.Append("\nFROM");
            sqlZone.Append("\nVDC");
            sqlZone.Append("\nGROUP BY Zoneid ) v ON ZONE.ZONEID =  v.ZONEID");
            _dtZone = GlobalResources.SelectDBConnection.ExecuteDataTable(sqlZone.ToString());
            Console.WriteLine("After executing query {0}", DateTime.Now.ToString("HH:mm:ss"));
            treeView1.SuspendLayout();
            Console.WriteLine("Before Adding to treeview {0}", DateTime.Now.ToString("HH:mm:ss"));
            AddZoneToTreeView();
            treeView1.ResumeLayout();
            Console.WriteLine("After Adding to treeview {0}", DateTime.Now.ToString("HH:mm:ss"));
            //treeView1.ExpandAll();
        }

        private void NepalsInfoDisplayEnglishFont()
        {

            Console.WriteLine("Before executing query {0}", DateTime.Now.ToString("HH:mm:ss"));
            StringBuilder sqlVDC = new StringBuilder();
            sqlVDC.Append("SELECT");
            sqlVDC.Append("\n\tDISTINCT VdcID, VdcName NepName, DistrictID");
            sqlVDC.Append("\nFROM");
            sqlVDC.Append("\n\tVDC");
            sqlVDC.Append("\nWHERE");
            sqlVDC.Append("\n\tNepName IS NOT NULL ");
            _dtVDC = GlobalResources.SelectDBConnection.ExecuteDataTable(sqlVDC.ToString());


            StringBuilder sqlDistrict = new StringBuilder();
            sqlDistrict.Remove(0, sqlDistrict.Length);
            sqlDistrict.Append("SELECT");
            sqlDistrict.Append("\n\tDistrict.DistrictID, District.DISTRICTNAME || ' - ' || vd.tot DistrictName, District.ZoneID");
            sqlDistrict.Append("\nFROM");
            sqlDistrict.Append("\n\tDistrict");
            sqlDistrict.Append("\n\tLEFT JOIN (");
            sqlDistrict.Append("SELECT");
            sqlDistrict.Append("\n\tDistrictID, Count(1) TOT");
            sqlDistrict.Append("\nFROM");
            sqlDistrict.Append("\n\tVDC");
            sqlDistrict.Append("\n\tGROUP BY DistrictID ) vd ON VD.DistrictID = District.DistrictID");
            sqlDistrict.Append("\nWHERE");
            sqlDistrict.AppendFormat("\n\tDistrict.NepName IS NOT NULL ");
            //sqlDistrict.AppendFormat("\n\tAND District.ZoneID ='{0}'", ParentId);
            _dtDistrict = GlobalResources.SelectDBConnection.ExecuteDataTable(sqlDistrict.ToString());

            StringBuilder sqlZone = new StringBuilder();
            sqlZone.Append("SELECT");
            sqlZone.Append("\n\tZONE.ZONENAME NepName, ZONE.ZoneID, d.dtot,v.vdctot");
            sqlZone.Append("\nFROM");
            sqlZone.Append("\nZONE");
            sqlZone.Append("\nLEFT JOIN (");
            sqlZone.Append("SELECT ");
            sqlZone.Append("\n\tZoneid, COUNT(1) dtot");
            sqlZone.Append("\nFROM");
            sqlZone.Append("\nDistrict");
            sqlZone.Append("\nGROUP BY ZOneid ) D ON ZONE.ZONEID =  D.ZONEID");
            sqlZone.Append("\nLEFT JOIN (");
            sqlZone.Append("SELECT");
            sqlZone.Append("\n\tZoneid, Count(1) vdctot");
            sqlZone.Append("\nFROM");
            sqlZone.Append("\nVDC");
            sqlZone.Append("\nGROUP BY Zoneid ) v ON ZONE.ZONEID =  v.ZONEID");
            _dtZone = GlobalResources.SelectDBConnection.ExecuteDataTable(sqlZone.ToString());
            Console.WriteLine("After executing query {0}", DateTime.Now.ToString("HH:mm:ss"));
            treeView1.SuspendLayout();
            Console.WriteLine("Before Adding to treeview {0}", DateTime.Now.ToString("HH:mm:ss"));
            AddZoneToTreeView();
            treeView1.ResumeLayout();
            Console.WriteLine("After Adding to treeview {0}", DateTime.Now.ToString("HH:mm:ss"));
        }
        #endregion

        private void frmSelectVDCMunicipaListView_Load(object sender, EventArgs e)
        {
            NepalInfoDisplayNepalifont();
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
         //   ReturnSelectedValue();
            if (treeView1.SelectedNode != null)
            {
                SelectedValue = treeView1.SelectedNode;
                DialogResult = DialogResult.OK;
                this.Hide();
            }
        }

        private void optEngLish_Click(object sender, EventArgs e)
        {
            NepalsInfoDisplayEnglishFont();
        }

        private void optNepali_Click(object sender, EventArgs e)
        {
            NepalInfoDisplayNepalifont();
        }

        private void txtEngName_TextChanged(object sender, EventArgs e)
        {
            if (txtEngName.Text.Trim() != "")
            {
                //FindNodeInHierarchy(treeView1.Nodes, txtEngName.Text); 
                //this method all the parent and child is workking but to much slow
                for (int a = 0; a < 14; a++)
                {
                    if (treeView1.Nodes[0].Nodes[a].Text.ToUpper().Contains(txtEngName.Text.ToUpper()))
                    {
                        treeView1.Nodes[0].Nodes[a].Expand();
                        treeView1.SelectedNode = treeView1.Nodes[0].Nodes[a];
                        treeView1.Select();
                        txtEngName.Focus();
                        return;
                    }
                }
            }
        }

        private void txtNepaliName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNepaliName.Text.Trim() != "")
            {
                //FindNodeInHierarchy(treeView1.Nodes, txtEngName.Text); 
                //this method all the parent and child is workking but to much slow
                for (int a = 0; a < 14; a++)
                {
                    if (treeView1.Nodes[0].Nodes[a].Text.ToUpper().Contains(txtNepaliName.Text.ToUpper()))
                    {
                        treeView1.Nodes[0].Nodes[a].Expand();
                        treeView1.SelectedNode = treeView1.Nodes[0].Nodes[a];
                        treeView1.Select();
                        return;
                    }
                }
                txtNepaliName.Focus();
            }
        }

        private void frmSelectVDCMunicipaListView_Activated(object sender, EventArgs e)
        {
            if (_zoneID != null
                && _districtID != null
                && _vdcID != null)
            {
                for (int zone = 0; zone < 14; zone++)
                {
                    if (treeView1.Nodes[0].Nodes[zone].Name.ToString() == _zoneID)
                    {
                        treeView1.Nodes[0].Nodes[zone].Expand();
                        for (int district = 0; district < 75; district++)
                        {
                            if (treeView1.Nodes[0].Nodes[zone].Nodes[district].Name.ToString() == _districtID)
                            {
                                treeView1.Nodes[0].Nodes[zone].Nodes[district].Expand();
                                for (int vdc = 0; vdc < 150; vdc++)
                                {
                                    if (treeView1.Nodes[0].Nodes[zone].Nodes[district].Nodes[vdc].Name.ToString() == _vdcID)
                                    {
                                        treeView1.SelectedNode = treeView1.Nodes[0].Nodes[zone].Nodes[district].Nodes[vdc];
                                        break;
                                    }


                                }
                                break;
                            }
                        }
                        break;

                    }
                }
            }
        }
    }
}

