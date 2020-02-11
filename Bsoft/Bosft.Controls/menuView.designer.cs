namespace Bsoft.Controls
{
    partial class menuView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.treeViewDisplay = new System.Windows.Forms.TreeView();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(62, 23);
            this.txtFilter.MaxLength = 15;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(161, 20);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TabStop = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // treeViewDisplay
            // 
            this.treeViewDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewDisplay.FullRowSelect = true;
            this.treeViewDisplay.Indent = 15;
            this.treeViewDisplay.ItemHeight = 30;
            this.treeViewDisplay.LineColor = System.Drawing.Color.BlanchedAlmond;
            this.treeViewDisplay.Location = new System.Drawing.Point(4, 48);
            this.treeViewDisplay.Name = "treeViewDisplay";
            this.treeViewDisplay.ShowLines = false;
            this.treeViewDisplay.ShowNodeToolTips = true;
            this.treeViewDisplay.ShowPlusMinus = false;
            this.treeViewDisplay.ShowRootLines = false;
            this.treeViewDisplay.Size = new System.Drawing.Size(220, 464);
            this.treeViewDisplay.TabIndex = 1;
            this.treeViewDisplay.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView1_DrawNode);
            this.treeViewDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeViewDisplay_KeyPress);
            this.treeViewDisplay.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(8, 5);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(45, 16);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menu";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(7, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 15);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search :";
            // 
            // menuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.treeViewDisplay);
            this.Name = "menuView";
            this.Size = new System.Drawing.Size(229, 521);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TreeView treeViewDisplay;
        public System.Windows.Forms.Label lblMenu;
        public System.Windows.Forms.Label lblSearch;
    }
}
