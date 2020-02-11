namespace UEMS
{
    partial class frmMaster_Unit
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
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSymbol = new Bsoft.Controls.VtextBox();
            this.lblMaster_UnitCategoryId = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cmbMaster_UnitCategoryId = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblFactor = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFactor = new Bsoft.Controls.VtextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(514, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(291, 156);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(184, 156);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtSymbol);
            this.groupBox1.Controls.Add(this.lblMaster_UnitCategoryId);
            this.groupBox1.Controls.Add(this.txtUnit);
            this.groupBox1.Controls.Add(this.lblSymbol);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.cmbMaster_UnitCategoryId);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(412, 47);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(78, 23);
            this.txtSymbol.TabIndex = 2;
            this.txtSymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSymbol.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.AlphaNumeric;
            this.txtSymbol.Value = "";
            // 
            // lblMaster_UnitCategoryId
            // 
            this.lblMaster_UnitCategoryId.BackColor = System.Drawing.Color.Transparent;
            this.lblMaster_UnitCategoryId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMaster_UnitCategoryId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaster_UnitCategoryId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMaster_UnitCategoryId.Location = new System.Drawing.Point(6, 19);
            this.lblMaster_UnitCategoryId.Name = "lblMaster_UnitCategoryId";
            this.lblMaster_UnitCategoryId.Size = new System.Drawing.Size(160, 22);
            this.lblMaster_UnitCategoryId.TabIndex = 0;
            this.lblMaster_UnitCategoryId.Text = "Unit Category";
            this.lblMaster_UnitCategoryId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaster_UnitCategoryId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMaster_UnitCategoryId_MouseDown);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(172, 47);
            this.txtUnit.MaxLength = 15;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(160, 23);
            this.txtUnit.TabIndex = 1;
            // 
            // lblSymbol
            // 
            this.lblSymbol.BackColor = System.Drawing.Color.Transparent;
            this.lblSymbol.Location = new System.Drawing.Point(340, 47);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(66, 22);
            this.lblSymbol.TabIndex = 0;
            this.lblSymbol.Text = "Symbol";
            this.lblSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnit
            // 
            this.lblUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblUnit.Location = new System.Drawing.Point(6, 47);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(160, 22);
            this.lblUnit.TabIndex = 0;
            this.lblUnit.Text = "Unit";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbMaster_UnitCategoryId
            // 
            this.cmbMaster_UnitCategoryId.FormattingEnabled = true;
            this.cmbMaster_UnitCategoryId.Location = new System.Drawing.Point(172, 17);
            this.cmbMaster_UnitCategoryId.Name = "cmbMaster_UnitCategoryId";
            this.cmbMaster_UnitCategoryId.Size = new System.Drawing.Size(160, 24);
            this.cmbMaster_UnitCategoryId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(16, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblId.Visible = false;
            // 
            // lblFactor
            // 
            this.lblFactor.BackColor = System.Drawing.Color.Transparent;
            this.lblFactor.Location = new System.Drawing.Point(97, 12);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(274, 22);
            this.lblFactor.TabIndex = 0;
            this.lblFactor.Text = "Multiplication Factor with Parent Unit To get the unit";
            this.lblFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFactor.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(53, 11);
            this.txtId.MaxLength = 50;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(56, 23);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "`";
            this.txtId.Visible = false;
            // 
            // txtFactor
            // 
            this.txtFactor.Location = new System.Drawing.Point(377, 12);
            this.txtFactor.Name = "txtFactor";
            this.txtFactor.Size = new System.Drawing.Size(160, 23);
            this.txtFactor.TabIndex = 6;
            this.txtFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFactor.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtFactor.Value = "";
            this.txtFactor.Visible = false;
            // 
            // frmMaster_Unit
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 194);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtFactor);
            this.Controls.Add(this.lblFactor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "frmMaster_Unit";
            this.Text = "Unit Details";
            this.Load += new System.EventHandler(this.frmMaster_Unit_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.lblFactor, 0);
            this.Controls.SetChildIndex(this.txtFactor, 0);
            this.Controls.SetChildIndex(this.lblId, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

}//<Control>
 private System.Windows.Forms.TextBox txtId;
 private System.Windows.Forms.TextBox txtUnit;
 private System.Windows.Forms.ComboBox cmbMaster_UnitCategoryId; 

 private System.Windows.Forms.Label  lblId; 
 private System.Windows.Forms.Label  lblUnit; 
 private System.Windows.Forms.Label  lblSymbol; 
 private System.Windows.Forms.Label  lblMaster_UnitCategoryId;
 private System.Windows.Forms.Label lblFactor; 



        #endregion
        //<declaration>
        private bsoftcontrols .fsButton btnCancel;
        private bsoftcontrols .fsButton btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bsoft.Controls.VtextBox txtFactor;
        private Bsoft.Controls.VtextBox txtSymbol;
    }
}