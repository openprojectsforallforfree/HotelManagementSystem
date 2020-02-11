using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;
using Bsoft.Data;
namespace Bsoft.Tools
{
    public partial class frmDbTool : Form
    {
        public frmDbTool()
        {
            InitializeComponent();
            showtree();
        }

        public void showtree()
        {
            TreeNode tablesNode = new TreeNode("Tables", DbToolDAL.GetTables());
            TreeNode viewsNode = new TreeNode("Views", DbToolDAL.GetViews());
            treeTables.Nodes.Add(tablesNode);
            treeTables.Nodes.Add(viewsNode);
            TreeNode tablesNodeClone = new TreeNode("Tables", DbToolDAL.GetTables());
            TreeNode viewsNodeClone = new TreeNode("Views", DbToolDAL.GetViews());
            _treeTablesCache.Nodes.Add(tablesNodeClone);
            _treeTablesCache.Nodes.Add(viewsNodeClone);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            showData(txtSQL.Text);
        }

        private void showData(string SQL)
        {
            txtSQL.Text = SQL;
            //Db db = new Db();
            //DataTable dt = db.ExecuteDataTable(SQL);
            if (SQL.ToLower().Contains("select"))
            {
                DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL);
                dgv.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Rows Affected");
                dt.Rows.Add(GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL).ToString());
                dgv.DataSource = dt;
            }
        }

        private void splitContainer1_MouseClick(object sender, MouseEventArgs e)
        {
            splittxtSQL.Panel1Collapsed = !splittxtSQL.Panel1Collapsed;
        }

        private void lblDown_Click(object sender, EventArgs e)
        {
            if (lblDown.Text == "=")
            {
                lblDown.Text = "v";
            }
            else if (lblDown.Text == "v")
            {
                lblDown.Text = "^";
            }
            else
            {
                lblDown.Text = "=";
            }

            if (lblDown.Text == "=")
            {
                splittxtSQL.Panel1Collapsed = false;
                splittxtSQL.Panel2Collapsed = false;
            }
            else if (lblDown.Text == "v")
            {
                splittxtSQL.Panel1Collapsed = true;
                splittxtSQL.Panel2Collapsed = false;
            }
            else
            {
                splittxtSQL.Panel1Collapsed = false;
                splittxtSQL.Panel2Collapsed = true;
            }
        }

        private void treeTables_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = treeTables.SelectedNode;
            try
            {
                showData(string.Format("select * from {0}", node.Text));
            }
            catch { }

        }

        private TreeView _treeTablesCache = new TreeView();

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            this.treeTables.BeginUpdate();
            this.treeTables.Nodes.Clear();
            if (this.txtFilter.Text != string.Empty)
            {
                foreach (TreeNode _parentNode in _treeTablesCache.Nodes)
                {
                    foreach (TreeNode _childNode in _parentNode.Nodes)
                    {
                        if (_childNode.Text.StartsWith(this.txtFilter.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            this.treeTables.Nodes.Add((TreeNode)_childNode.Clone());
                        }
                    }
                }
            }
            else
            {
                foreach (TreeNode _node in this._treeTablesCache.Nodes)
                {
                    treeTables.Nodes.Add((TreeNode)_node.Clone());
                }
            }
            //enables redrawing tree after all objects have been added
            this.treeTables.EndUpdate();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable("select * from " + treeTables.SelectedNode.Text);
            if (dt.Rows.Count > 0)
            {
                string sql = SqlRepository.GetInsertScript(treeTables.SelectedNode.Text, dt);
                Clipboard.SetText(sql);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from " + treeTables.SelectedNode.Text;
            txtSQL.Text = sql;
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable("select * from " + treeTables.SelectedNode.Text);
            if (dt.Rows.Count > 0)
            {
                string sql = SqlRepository.GetCSV(dt);
                Clipboard.SetText(sql);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable("select * from " + treeTables.SelectedNode.Text);
            if (dt.Rows.Count > 0)
            {
                string sql = SqlRepository.GetSelectSQL(treeTables.SelectedNode.Text,dt);
                Clipboard.SetText(sql);
            }
        }

        private void btnInsertGenerator_Click(object sender, EventArgs e)
        {
             DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable("select * from " + treeTables.SelectedNode.Text);
             if (dt.Rows.Count > 0)
             {
                 string sql = SqlRepository.GetSelectGenerator(treeTables.SelectedNode.Text, dt);
                 Clipboard.SetText(sql);
             }
           

        }
    }



    public static class DbToolDAL
    {

        public static TreeNode[] GetTables()
        {
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SqlRepository.GetTableNames);
            var v = (from DataRow dr in dt.Rows
                     select new TreeNode(dr["TABLE_NAME"].ToString())).ToArray<TreeNode>();
            return v;
        }
        public static TreeNode[] GetViews()
        {
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SqlRepository.GetViewNames);
            var v = (from DataRow dr in dt.Rows
                     select new TreeNode(dr["TABLE_NAME"].ToString())).ToArray<TreeNode>();
            return v;
        }
    }

}
