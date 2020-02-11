namespace RestoSys
{
    partial class customDataGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 55;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.ShowCellErrors = false;
            this.dgv.ShowCellToolTips = false;
            this.dgv.ShowEditingIcon = false;
            this.dgv.ShowRowErrors = false;
            this.dgv.Size = new System.Drawing.Size(379, 247);
            this.dgv.TabIndex = 3;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            this.dgv.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellLeave);
            this.dgv.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValidated);
            this.dgv.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            this.dgv.Validating += new System.ComponentModel.CancelEventHandler(this.dgv_Validating);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(19, 234);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(333, 13);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Error";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgv);
            this.Name = "customDataGrid";
            this.Size = new System.Drawing.Size(379, 247);
            this.Load += new System.EventHandler(this.customDataGrid_Load);
            this.SizeChanged += new System.EventHandler(this.customDataGrid_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

         
        public System.Windows.Forms.DataGridView  dgv;
        public System.Windows.Forms.Label lblError;
    }
}
