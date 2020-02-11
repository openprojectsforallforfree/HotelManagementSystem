using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
 

namespace Bsoft.Forms
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// The final loading
        /// </summary>
        /// <param name="parentCol"></param>
        /// <param name="childCol"></param>
        /// <param name="parentdisplayCol"></param>
        /// <param name="childdisplayCol"></param>
        /// <param name="dt"></param>
        public  void loadtree(string parentCol, string childCol, string parentdisplayCol, string childdisplayCol, DataTable dt)
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

        public  void loadtree2(string parentCol, string childCol, string parentdisplayCol, string childdisplayCol, DataTable dt)
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
