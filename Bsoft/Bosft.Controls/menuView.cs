using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Plasmoid.Extensions;
namespace Bsoft.Controls
{
    public partial class menuView : UserControl
    {

        public delegate void refreshHandler(string message, object obj, bool isDecrease);
        public event refreshHandler ItemIsClicked;
        private TreeView _treeViewCache = new TreeView();
        public menuView()
        {
            InitializeComponent();
            treeViewDisplay.DrawMode = TreeViewDrawMode.OwnerDrawText;
            treeViewDisplay.HideSelection = false ;
        }

        Pen penBorderGroup = new Pen(Color.GhostWhite, 5);
        Pen penBorderItem = new Pen(Color.SlateBlue, 5);
        Pen penBorderSelected = new Pen(Color.Gold, 7);
        Brush brushSelected = Brushes.Green;
        Brush brushGroup = Brushes.AliceBlue;
        Brush brushItem = Brushes.SteelBlue;
        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            Rectangle boundsBorder = new Rectangle(0, e.Bounds.Y, treeViewDisplay.Width - 3, e.Bounds.Height - 1);
            Rectangle boundsImage = new Rectangle(0, e.Bounds.Y, treeViewDisplay.Width - 3, e.Bounds.Height - 1);
            Rectangle boundsText= new Rectangle(20, e.Bounds.Y, treeViewDisplay.Width - 3, e.Bounds.Height - 1);
            Rectangle boundsImageText = new Rectangle(30, e.Bounds.Y, treeViewDisplay.Width - 3, e.Bounds.Height - 1);
            //fill and the text
            if (e.Node.Level == 1)
            {
                e.Graphics.FillRoundedRectangle(brushGroup, boundsBorder, 3);

                if (e.Node.Tag != null && e.Node.Tag is bool)
                {
                    if (((bool)e.Node.Tag) == true)
                    {
                        TextRenderer.DrawText(e.Graphics,
                                 e.Node.Text,
                                 e.Node.NodeFont,
                                 boundsImageText,
                                 Color.Black,
                                 Color.Empty,
                                 TextFormatFlags.VerticalCenter);
                        e.Graphics.DrawIconUnstretched(Properties.Resources.Man, boundsImage);
                    }
                    else
                    {
                        TextRenderer.DrawText(e.Graphics,
                                     e.Node.Text,
                                     e.Node.NodeFont,
                                     boundsText,
                                     Color.Black,
                                     Color.Empty,
                                     TextFormatFlags.VerticalCenter);
                    }
                }
                else
                {
                    TextRenderer.DrawText(e.Graphics,
                                        e.Node.Text,
                                        e.Node.NodeFont,
                                        boundsText,
                                        Color.Black,
                                        Color.Empty,
                                        TextFormatFlags.VerticalCenter);
                }

            }
            else
            {

                e.Graphics.FillRoundedRectangle(brushItem, boundsBorder, 3);
                TextRenderer.DrawText(e.Graphics,
                                 e.Node.Text,
                                 e.Node.NodeFont,
                                 e.Bounds  ,
                                 Color.White,
                                 Color.Empty,
                                 TextFormatFlags.VerticalCenter);

            }

            //border
            if (e.Node.Level == 1)
            {
                if ((e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected)
                {
                    e.Graphics.DrawLine(penBorderSelected, new Point(boundsBorder.X, boundsBorder.Y), new Point(boundsBorder.X, boundsBorder.Bottom));
                }
                else
                {
                    e.Graphics.DrawLine(penBorderGroup, new Point(boundsBorder.X, boundsBorder.Y), new Point(boundsBorder.X, boundsBorder.Bottom));
                }
            }
            else
            {
                e.Graphics.DrawLine(penBorderItem, new Point(boundsBorder.X, boundsBorder.Y), new Point(boundsBorder.X, boundsBorder.Bottom));
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeViewDisplay.SelectedNode = e.Node;
            if ((e.Node.Level == 1))
            {
                if (ItemIsClicked != null)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        ItemIsClicked(e.Node.Text, e.Node.Tag, true);
                    }
                    else
                    {
                        ItemIsClicked(e.Node.Text, e.Node.Tag, false);
                    }
                }
            }
            else
            {
                //if (e.Node.IsExpanded)
                //{
                //    e.Node.Collapse();
                //}
                //else
                //{
                //    e.Node.Expand();
                //}
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            this.treeViewDisplay.BeginUpdate();
            this.treeViewDisplay.Nodes.Clear();
            if (this.txtFilter.Text != string.Empty)
            {
                foreach (TreeNode parentNode in _treeViewCache.Nodes)
                {
                    this.treeViewDisplay.Nodes.Add(parentNode.Text);
                    foreach (TreeNode childNode in parentNode.Nodes)
                    {
                        if (match(childNode, this.txtFilter.Text))
                        {
                            this.treeViewDisplay.Nodes[treeViewDisplay.Nodes.Count - 1].Nodes.Add((TreeNode)childNode.Clone());
                        }
                    }
                }
            }
            else
            {
                foreach (TreeNode _node in this._treeViewCache.Nodes)
                {
                    treeViewDisplay.Nodes.Add((TreeNode)_node.Clone());
                }
            }
            //enables redrawing tree after all objects have been added
            this.treeViewDisplay.EndUpdate();
            // beautify(treeViewDisplay);
            treeViewDisplay.ExpandAll();
        }

        private void treeViewDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (null != treeViewDisplay.SelectedNode && treeViewDisplay.SelectedNode.Level == 1)
            {
                // if the Enter key was pressed
                if ((char)Keys.Return == e.KeyChar)
                {
                    // do stuff
                    if (ItemIsClicked != null)
                    {
                        ItemIsClicked(treeViewDisplay.SelectedNode.Text, treeViewDisplay.SelectedNode.Tag, false);
                        //System.Diagnostics.Debug.WriteLine(treeViewDisplay.SelectedNode.Text);
                    }
                }
            }
        }

        public void AddGroup(string groupName, string buttontext, object obj)
        {
            TreeNode tn = treeViewDisplay.Nodes.Add(groupName, buttontext);
            tn.Tag = obj;
            // tn.ToolTipText = tips;
        }
        public void AddItem(string groupName, string name, string buttontext, object obj)
        {
            TreeNode tn = treeViewDisplay.Nodes[groupName].Nodes.Add(name, buttontext);
            tn.Tag = obj;
            //tn.ToolTipText = tips;
        }
        public void StartTree()
        {
            _treeViewCache = cloneTree(treeViewDisplay);
            treeViewDisplay.ExpandAll();
        }

        private TreeView cloneTree(TreeView treeView)
        {
            TreeView tree = new TreeView();
            foreach (TreeNode _parentNode in treeView.Nodes)
            {
                tree.Nodes.Add((TreeNode)_parentNode.Clone());
            }
            return tree;
        }

        //word based search
        private bool match(TreeNode inNode, string search)
        {
            search = " " + search.ToLower();//For word search
            string inText = " " + inNode.Text.ToLower();//For first string
            while (inText.IndexOf("  ") >= 0)
            {
                inText = inText.Replace("  ", " ");
            }
            while (search.IndexOf("  ") >= 0)
            {
                search = search.Replace("  ", " ");
            }
            return inText.IndexOf(search) >= 0;
        }


        public void ShowImage(string NodeName)
        {
            if (treeViewDisplay.Nodes.Count > 0)
            {
                foreach (TreeNode tn in treeViewDisplay.Nodes)
                {
                    if (tn.Nodes.Count > 0)
                    {
                        foreach (TreeNode tnl in tn.Nodes)
                        {
                            if (NodeName == tnl.Name)
                            {
                                tnl.Tag = true;
                                treeViewDisplay.Refresh();
                                return;
                            }
                        
                           
                        }
                    }

                }
            }
        }

        public void RemoveImage(string NodeName)
        {
            if (treeViewDisplay.Nodes.Count > 0)
            {
                foreach (TreeNode tn in treeViewDisplay.Nodes)
                {
                    if (tn.Nodes.Count > 0)
                    {
                        foreach (TreeNode tnl in tn.Nodes)
                        {
                            if (NodeName == tnl.Name)
                            {
                                tnl.Tag = false ;
                                treeViewDisplay.Refresh();
                                return;
                            }
                        
                        }
                    }

                }
            }
        }

    }
}
