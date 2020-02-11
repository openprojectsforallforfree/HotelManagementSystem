namespace Bsoft.Tools
{
    partial class frmDbTool
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.splittxtSQL = new System.Windows.Forms.SplitContainer();
            this.lblDown = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.treeTables = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsertGenerator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.splittxtSQL.Panel1.SuspendLayout();
            this.splittxtSQL.Panel2.SuspendLayout();
            this.splittxtSQL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(674, 321);
            this.dgv.TabIndex = 0;
            // 
            // txtSQL
            // 
            this.txtSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSQL.Location = new System.Drawing.Point(3, 3);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(674, 141);
            this.txtSQL.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(565, 7);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // splittxtSQL
            // 
            this.splittxtSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splittxtSQL.Location = new System.Drawing.Point(227, 36);
            this.splittxtSQL.Name = "splittxtSQL";
            this.splittxtSQL.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splittxtSQL.Panel1
            // 
            this.splittxtSQL.Panel1.Controls.Add(this.txtSQL);
            // 
            // splittxtSQL.Panel2
            // 
            this.splittxtSQL.Panel2.Controls.Add(this.dgv);
            this.splittxtSQL.Size = new System.Drawing.Size(680, 478);
            this.splittxtSQL.SplitterDistance = 147;
            this.splittxtSQL.TabIndex = 4;
            this.splittxtSQL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseClick);
            // 
            // lblDown
            // 
            this.lblDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDown.AutoSize = true;
            this.lblDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDown.Location = new System.Drawing.Point(881, 13);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(18, 18);
            this.lblDown.TabIndex = 5;
            this.lblDown.Text = "v";
            this.lblDown.Click += new System.EventHandler(this.lblDown_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(3, 0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(217, 20);
            this.txtFilter.TabIndex = 6;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // treeTables
            // 
            this.treeTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeTables.Location = new System.Drawing.Point(3, 26);
            this.treeTables.Name = "treeTables";
            this.treeTables.Size = new System.Drawing.Size(217, 488);
            this.treeTables.TabIndex = 0;
            this.treeTables.DoubleClick += new System.EventHandler(this.treeTables_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Controls.Add(this.treeTables);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 517);
            this.panel1.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(223, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 517);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(322, 7);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(403, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(484, 7);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(75, 23);
            this.btnCSV.TabIndex = 13;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(241, 7);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 14;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsertGenerator
            // 
            this.btnInsertGenerator.Location = new System.Drawing.Point(668, 5);
            this.btnInsertGenerator.Name = "btnInsertGenerator";
            this.btnInsertGenerator.Size = new System.Drawing.Size(145, 25);
            this.btnInsertGenerator.TabIndex = 15;
            this.btnInsertGenerator.Text = "Insert Generator";
            this.btnInsertGenerator.UseVisualStyleBackColor = true;
            this.btnInsertGenerator.Click += new System.EventHandler(this.btnInsertGenerator_Click);
            // 
            // frmDbTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 517);
            this.Controls.Add(this.btnInsertGenerator);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.splittxtSQL);
            this.Controls.Add(this.btnExecute);
            this.Name = "frmDbTool";
            this.Text = "Data Base Tool - Dhiraj";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.splittxtSQL.Panel1.ResumeLayout(false);
            this.splittxtSQL.Panel1.PerformLayout();
            this.splittxtSQL.Panel2.ResumeLayout(false);
            this.splittxtSQL.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.SplitContainer splittxtSQL;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TreeView treeTables;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsertGenerator;
    }
}

