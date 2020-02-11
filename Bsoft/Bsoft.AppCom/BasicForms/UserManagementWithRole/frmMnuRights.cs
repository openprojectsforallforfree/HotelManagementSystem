using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Controls;
using Bsoft.Common;
using Bsoft.Forms;
using Bsoft.Data;

namespace Bsoft.AppCom.UserMgtWithRole
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmMnuRights : Friuts.EntryFormBase
    {
        public frmMnuRights()
        {
            InitializeComponent();

        }
        public frmMnuRights(MenuStrip _m)
        {
            InitializeComponent();
            GetmenusToTreeViewdb(_m);
        }
        private void frmMnuRights_Load(object sender, EventArgs e)
        {
            initialright();
            ComboUtilities.LoadData("id", "Title", "SuperAdmin_Rights_Roles", cboRightGroups, true, string.Empty);
        }

        private void cboRightGroups_SelectedIndexChanged(object sender, EventArgs e)
        {//display it
            StringBuilder sql = new StringBuilder();
            TreeNode tn;
            string id, mnuname, mnutext, grp, right = "1";
            ComboItem ci = (ComboItem)cboRightGroups.SelectedItem;
            grp = ci.Key.ToString();

            sql.Append("select t1.id,t1.fk_SuperAdmin_Rights_Roles,t1.fk_SuperAdmin_Rights_Menu,t1.giveright,t2.name");
            sql.Append(" from SuperAdmin_Rights_Menu_Roles t1 ");
            sql.Append("left join SuperAdmin_Rights_Menu t2 on ");
            sql.Append("t1.fk_SuperAdmin_Rights_Menu=t2.id ");
            sql.Append("where fk_SuperAdmin_Rights_Roles=" + grp);

            DataTable dtMenu = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
            foreach (DataRow drMenu in dtMenu.Rows)
            {
                id = Conversion.ToString(drMenu, "id");
                mnuname = Conversion.ToString(drMenu, "name");
                mnutext = Conversion.ToString(drMenu, "text");
                right = Conversion.ToString(drMenu, "giveright");
                tn = treeMenuRights.Nodes.Find(mnuname, true)[0];
                if (right == "0")
                {
                    treeMenuRights.SetChecked(tn, TriStateTreeView.CheckState.Unchecked);
                    tn.Checked = false;
                }
                else
                {
                    treeMenuRights.SetChecked(tn, TriStateTreeView.CheckState.Checked);
                    tn.Checked = true;
                }
            }
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            saveit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            saveit();
            DialogResult = DialogResult.OK;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBoxMy.Show("The latest menu structure will be loaded and also.Please Restart the application after completion of this command.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                GlobalResources.SelectDBConnection.ExecuteNonQuery("DROP TABLE SuperAdmin_Rights_Menu_Roles");
                GlobalResources.SelectDBConnection.ExecuteNonQuery("DROP TABLE SuperAdmin_Rights_Menu");
                MessageBoxMy.Show("The rights are reset .The application will be closed now .\nPlease start the application again ,Thankyou.", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void GetmenusToTreeView(MenuStrip m)
        {
            //  treeMenuRights.CheckBoxes = true;
            TreeNode tn;
            foreach (ToolStripMenuItem mainmenu in m.Items)
            {
                if (mainmenu.Enabled)
                {
                    tn = treeMenuRights.Nodes.Add(mainmenu.Text);
                    foreach (ToolStripItem submenu in mainmenu.DropDownItems)
                    {
                        if (submenu.GetType() == typeof(ToolStripMenuItem))
                        {
                            if (submenu.Enabled)
                            {
                                tn.Nodes.Add(submenu.Text);
                            }
                        }
                    }
                }
            }
            treeMenuRights.ExpandAll();
        }

        private void GetmenusToTreeViewdb(MenuStrip m)
        {//get the menu from db and show in tree

            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable("select * from SuperAdmin_Rights_Menu order by id");

            treeMenuRights.CheckBoxes = false;
            TreeNode tn = null;
            string level, mnuname, mnutext;

            foreach (DataRow dr in dt.Rows)
            {
                level = Conversion.ToString(dr, "level");
                mnuname = Conversion.ToString(dr, "name");
                mnutext = Conversion.ToString(dr, "text");
                if (level == "0")
                {
                    tn = treeMenuRights.Nodes.Add(mnuname, mnutext);
                }
                else
                {

                    tn.Nodes.Add(mnuname, mnutext);
                }
            }
            treeMenuRights.ExpandAll();
        }

        /// <summary>
        /// insert if its not there
        /// </summary>
        private void initialright()
        {//insert 0/1
            DataTable dtMenu = GlobalResources.SelectDBConnection.ExecuteDataTable("select * from SuperAdmin_Rights_Menu order by id");
            DataTable dtGroups = GlobalResources.SelectDBConnection.ExecuteDataTable("select * from SuperAdmin_Rights_Roles");

            StringBuilder sql = new StringBuilder();

            string id, mnuname, mnutext, grp, right = "1";//for first role give all rights

            foreach (DataRow drGroup in dtGroups.Rows)
            {
                grp = Conversion.ToString(drGroup, "id");
                foreach (DataRow drMenu in dtMenu.Rows)
                {
                    id = Conversion.ToString(drMenu, "id");
                    mnuname = Conversion.ToString(drMenu, "name");
                    mnutext = Conversion.ToString(drMenu, "text");
                    string qry = "select count(*) from  SuperAdmin_Rights_Menu_Roles where fk_SuperAdmin_Rights_Roles=" + grp + " and fk_SuperAdmin_Rights_Menu=" + id.ToString();

                    int idt = GlobalResources.SelectDBConnection.ExecuteScalar(qry).ToString().ToInt();
                    if (idt < 1)
                    {
                        sql.Remove(0, sql.Length);
                        sql.AppendFormat("insert into SuperAdmin_Rights_Menu_Roles (fk_SuperAdmin_Rights_Roles,fk_SuperAdmin_Rights_Menu ,giveRight) values({0},{1},{2}) ", grp, id, right);
                        GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
                    }
                    //Note for first group all right will be given for remaining no right will be given
                    right = "0";
                }
            }
        }

        private void saveit()
        {
            //save it
            DataTable dtMenu = GlobalResources.SelectDBConnection.ExecuteDataTable("select * from SuperAdmin_Rights_Menu order by id");
            StringBuilder sql = new StringBuilder();
            TreeNode tn;
            string id, mnuname, mnutext, grp;
            ComboItem ci = (ComboItem)cboRightGroups.SelectedItem;
            grp = ci.Key.ToString();
            foreach (DataRow drMenu in dtMenu.Rows)
            {
                id = Conversion.ToString(drMenu, "id");
                mnuname = Conversion.ToString(drMenu, "name");
                mnutext = Conversion.ToString(drMenu, "text");
                sql.Remove(0, sql.Length);
                sql.Append("UPDATE SuperAdmin_Rights_Menu_Roles ");
                tn = treeMenuRights.Nodes.Find(mnuname, true)[0];
                if (treeMenuRights.GetChecked(tn) == TriStateTreeView.CheckState.Checked | treeMenuRights.GetChecked(tn) == TriStateTreeView.CheckState.GreyChecked)
                {
                    sql.AppendFormat("SET giveRight = {0} ", "1");
                }
                else
                {
                    sql.AppendFormat("SET giveRight = {0} ", "0");
                }

                sql.AppendFormat("WHERE fk_SuperAdmin_Rights_Menu = {0} and  fk_SuperAdmin_Rights_Roles= {1} ", id, grp);
                GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
            }
        }

        private void getMenus(MenuStrip m)
        {
            foreach (TreeNode tn in treeMenuRights.Nodes)
            {
                if (tn.Checked)
                { MessageBox.Show(tn.Text); }
                foreach (TreeNode tsn in tn.Nodes)
                {
                    if (tsn.Checked)
                    { MessageBox.Show(tsn.Text); }

                }
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            lstRights_User_Group frm = new lstRights_User_Group();
            frm.ShowDialog();
        }

        private void btnBasicRights_Click(object sender, EventArgs e)
        {
            List<string> basicRights = new List<string>();
           
            basicRights.Add("mnuChangeLogin");
            basicRights.Add("mnuExit");
            basicRights.Add("mnuAbout");
            basicRights.Add("mnuChangePassWord");
            foreach (var item in basicRights)
            {
                try
                {
                    TreeNode tn;
                    tn = treeMenuRights.Nodes.Find(item , true)[0];
                    treeMenuRights.SetChecked(tn, TriStateTreeView.CheckState.Checked);
                    tn.Checked = true;
                }
                catch { }
            }
        }

    }
}
