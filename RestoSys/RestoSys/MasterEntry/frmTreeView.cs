using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Bsoft.Data;

namespace Friuts
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Concerts only 1 table
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="parentCol"></param>
        /// <param name="childCol"></param>
        /// <param name="parentdisplayCol"></param>
        /// <param name="childdisplayCol"></param>
        public void loadtree(string tableName, string parentCol, string childCol, string parentdisplayCol, string childdisplayCol)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("SELECT * from {0} order by {1}", tableName, parentCol);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sb.ToString());
            loadtree(parentCol, childCol, parentdisplayCol, childdisplayCol, dt);

        }
        /// <summary>
        /// when concerns 2 tables
        /// </summary>
        /// <param name="tableName1"></param>
        /// <param name="tableName2"></param>
        /// <param name="parentCol"></param>
        /// <param name="childCol"></param>
        /// <param name="parentdisplayCol"></param>
        /// <param name="childdisplayCol"></param>
        public void loadtree(string parentTable, string childTable, string parentCol, string childCol,string parentReferenceIdCol, string parentdisplayCol, string childdisplayCol)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("SELECT p.{0} p_{0},c.{1} c_{1},p.{2} p_{2} ,c.{3} c_{3}  ", parentCol,childCol,parentdisplayCol,  childdisplayCol );
            //select p.id  pid, c.id cid,p.Title ,c.Unit  
               // from units c left join Master_UnitCategory p on p.id = c.Master_UnitCategoryId  


            sb.AppendFormat(" FROM {0} c left join {1} p on p.{2}  = c.{3}",childTable ,parentTable ,parentCol ,parentReferenceIdCol);
            sb.AppendFormat(" ORDER BY p.{0}" ,parentCol );
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sb.ToString());
            loadtree2("p_"+parentCol,"c_"+ childCol,"p_"+ parentdisplayCol,"c_"+ childdisplayCol, dt);
        }
        /// <summary>
        /// The final loading
        /// </summary>
        /// <param name="parentCol"></param>
        /// <param name="childCol"></param>
        /// <param name="parentdisplayCol"></param>
        /// <param name="childdisplayCol"></param>
        /// <param name="dt"></param>
        private void loadtree(string parentCol, string childCol, string parentdisplayCol, string childdisplayCol, DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode[] parentNode = treeView1.Nodes.Find(dr[parentCol].ToString(), true);
                if (parentNode.Length > 0)
                {
                    parentNode[0].Nodes.Add(dr[childCol].ToString(), dr[parentdisplayCol].ToString());
                }
                else
                {
                    treeView1.Nodes.Add(dr[childCol].ToString(), dr[childdisplayCol].ToString());
                }
            }

            treeView1.ExpandAll();
        }

        private void loadtree2(string parentCol, string childCol, string parentdisplayCol, string childdisplayCol, DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode[] parentNode = treeView1.Nodes.Find(dr[parentCol].ToString(), true);
                if (parentNode.Length > 0)
                {
                    //already there so dont add 
                }
                else
                {
                    treeView1.Nodes.Add(dr[parentCol].ToString(), dr[parentdisplayCol].ToString());
                }
            }

            foreach (DataRow dr in dt.Rows)
            {
                TreeNode[] parentNode = treeView1.Nodes.Find(dr[parentCol].ToString(), true);
                if (parentNode.Length > 0)
                {
                    parentNode[0].Nodes.Add(dr[childCol].ToString(), dr[childdisplayCol].ToString());
                }
                else
                {
                    //since there is no parent add in na
                }
            }

            treeView1.ExpandAll();
        }
        private void frmTreeView_Load(object sender, EventArgs e)
        {


            //int[] Account = new int[6];
            //int[] AccountGroup = new int[6];
            //Account[0] = 0; AccountGroup[0] = -1;
            //Account[1] = 1; AccountGroup[1] = -1;
            //Account[2] = 2; AccountGroup[2] = 1;
            //Account[3] = 3; AccountGroup[3] = 1;
            //Account[4] = 4; AccountGroup[4] = 2;
            //Account[5] = 5; AccountGroup[5] = 2;
            ////Populate TreeView
            //for (int i = 0; i < 6; i++)
            //{
            //    TreeNode[] parentNode = treeView1.Nodes.Find(AccountGroup[i].ToString(), true);
            //    if (parentNode.Count() > 0)
            //    {
            //        parentNode[0].Nodes.Add(Account[i].ToString(), Account[i].ToString());
            //    }
            //    else
            //    {
            //        treeView1.Nodes.Add(Account[i].ToString(), Account[i].ToString());
            //    }
            //}
            //treeView1.ExpandAll();

        }
    }
}
