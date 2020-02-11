namespace RestoSys.Inventory
{
    partial class frmDamageLossEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRate = new Bsoft.Controls.VtextBox();
            this.lblRateUnit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblfk_Group = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.lblfk_Company = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblsizeunit = new System.Windows.Forms.Label();
            this.lblcolour = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblweightunit = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.lblRateNote = new System.Windows.Forms.Label();
            this.lblListPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMeasureUnit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblentrydate = new System.Windows.Forms.Label();
            this.txtGroup_Code = new System.Windows.Forms.TextBox();
            this.btnBrowse = new bsoftcontrols.fsButton();
            this.txtQuantity = new Bsoft.Controls.VtextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblfk = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(796, 2);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.lblRateUnit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grid);
            this.groupBox1.Controls.Add(this.lblRateNote);
            this.groupBox1.Controls.Add(this.lblListPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMeasureUnit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblentrydate);
            this.groupBox1.Controls.Add(this.txtGroup_Code);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.lblfk);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Location = new System.Drawing.Point(15, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 429);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(181, 137);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(160, 30);
            this.txtRate.TabIndex = 110;
            this.txtRate.TabStop = false;
            this.txtRate.Text = "0";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRate.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtRate.Value = "0";
            // 
            // lblRateUnit
            // 
            this.lblRateUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblRateUnit.Location = new System.Drawing.Point(347, 139);
            this.lblRateUnit.Name = "lblRateUnit";
            this.lblRateUnit.Size = new System.Drawing.Size(47, 22);
            this.lblRateUnit.TabIndex = 109;
            this.lblRateUnit.Text = "Rs";
            this.lblRateUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(58, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 108;
            this.label1.Text = "Rate:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblRemarks);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.lblsize);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblfk_Group);
            this.groupBox2.Controls.Add(this.lblweight);
            this.groupBox2.Controls.Add(this.lblfk_Company);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblsizeunit);
            this.groupBox2.Controls.Add(this.lblcolour);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblweightunit);
            this.groupBox2.Location = new System.Drawing.Point(456, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 252);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(1, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 22);
            this.label16.TabIndex = 43;
            this.label16.Text = "Product Name:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "--";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(1, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 22);
            this.label15.TabIndex = 40;
            this.label15.Text = "Group:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Location = new System.Drawing.Point(1, 206);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(160, 22);
            this.lblRemarks.TabIndex = 37;
            this.lblRemarks.Text = "Remarks:";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(167, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 22);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "--";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsize
            // 
            this.lblsize.BackColor = System.Drawing.Color.Transparent;
            this.lblsize.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsize.Location = new System.Drawing.Point(167, 175);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(81, 22);
            this.lblsize.TabIndex = 28;
            this.lblsize.Text = "--";
            this.lblsize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(1, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 22);
            this.label14.TabIndex = 39;
            this.label14.Text = "Company:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblfk_Group
            // 
            this.lblfk_Group.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Group.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfk_Group.Location = new System.Drawing.Point(167, 57);
            this.lblfk_Group.Name = "lblfk_Group";
            this.lblfk_Group.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Group.TabIndex = 41;
            this.lblfk_Group.Text = "--";
            this.lblfk_Group.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblweight
            // 
            this.lblweight.BackColor = System.Drawing.Color.Transparent;
            this.lblweight.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweight.Location = new System.Drawing.Point(167, 145);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(81, 22);
            this.lblweight.TabIndex = 30;
            this.lblweight.Text = "--";
            this.lblweight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblfk_Company
            // 
            this.lblfk_Company.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Company.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfk_Company.Location = new System.Drawing.Point(167, 87);
            this.lblfk_Company.Name = "lblfk_Company";
            this.lblfk_Company.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Company.TabIndex = 38;
            this.lblfk_Company.Text = "--";
            this.lblfk_Company.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(1, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 22);
            this.label9.TabIndex = 29;
            this.label9.Text = "size:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblsizeunit
            // 
            this.lblsizeunit.BackColor = System.Drawing.Color.Transparent;
            this.lblsizeunit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsizeunit.Location = new System.Drawing.Point(246, 175);
            this.lblsizeunit.Name = "lblsizeunit";
            this.lblsizeunit.Size = new System.Drawing.Size(70, 22);
            this.lblsizeunit.TabIndex = 48;
            this.lblsizeunit.Text = "--";
            this.lblsizeunit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcolour
            // 
            this.lblcolour.BackColor = System.Drawing.Color.Transparent;
            this.lblcolour.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolour.Location = new System.Drawing.Point(167, 115);
            this.lblcolour.Name = "lblcolour";
            this.lblcolour.Size = new System.Drawing.Size(160, 22);
            this.lblcolour.TabIndex = 44;
            this.lblcolour.Text = "--";
            this.lblcolour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(1, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 22);
            this.label11.TabIndex = 45;
            this.label11.Text = "colour:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(1, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "weight:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblweightunit
            // 
            this.lblweightunit.BackColor = System.Drawing.Color.Transparent;
            this.lblweightunit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweightunit.Location = new System.Drawing.Point(246, 145);
            this.lblweightunit.Name = "lblweightunit";
            this.lblweightunit.Size = new System.Drawing.Size(70, 22);
            this.lblweightunit.TabIndex = 46;
            this.lblweightunit.Text = "--";
            this.lblweightunit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mangal", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(31, 303);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(686, 99);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 106;
            // 
            // lblRateNote
            // 
            this.lblRateNote.BackColor = System.Drawing.Color.Transparent;
            this.lblRateNote.Location = new System.Drawing.Point(31, 278);
            this.lblRateNote.Name = "lblRateNote";
            this.lblRateNote.Size = new System.Drawing.Size(583, 22);
            this.lblRateNote.TabIndex = 105;
            this.lblRateNote.Text = "There are some old stock also ,Please select the rate for current selling.";
            this.lblRateNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblListPrice
            // 
            this.lblListPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblListPrice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListPrice.Location = new System.Drawing.Point(212, 512);
            this.lblListPrice.Name = "lblListPrice";
            this.lblListPrice.Size = new System.Drawing.Size(160, 22);
            this.lblListPrice.TabIndex = 104;
            this.lblListPrice.Text = "na";
            this.lblListPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(46, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 103;
            this.label3.Text = "List Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMeasureUnit
            // 
            this.lblMeasureUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblMeasureUnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasureUnit.Location = new System.Drawing.Point(348, 52);
            this.lblMeasureUnit.Name = "lblMeasureUnit";
            this.lblMeasureUnit.Size = new System.Drawing.Size(59, 22);
            this.lblMeasureUnit.TabIndex = 99;
            this.lblMeasureUnit.Text = "--";
            this.lblMeasureUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(2, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 90;
            this.label2.Text = "Remarks:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(46, 481);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 22);
            this.label17.TabIndex = 86;
            this.label17.Text = "entrydate:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblentrydate
            // 
            this.lblentrydate.BackColor = System.Drawing.Color.Transparent;
            this.lblentrydate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentrydate.Location = new System.Drawing.Point(212, 481);
            this.lblentrydate.Name = "lblentrydate";
            this.lblentrydate.Size = new System.Drawing.Size(160, 22);
            this.lblentrydate.TabIndex = 85;
            this.lblentrydate.Text = "--";
            this.lblentrydate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGroup_Code
            // 
            this.txtGroup_Code.Location = new System.Drawing.Point(182, 22);
            this.txtGroup_Code.Name = "txtGroup_Code";
            this.txtGroup_Code.Size = new System.Drawing.Size(160, 30);
            this.txtGroup_Code.TabIndex = 77;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBrowse.Location = new System.Drawing.Point(349, 22);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(38, 24);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.ThemeColor = System.Drawing.Color.Blue;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(182, 52);
            this.txtQuantity.MaxLength = 10;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(160, 30);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Integer;
            this.txtQuantity.Value = "";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(182, 82);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(205, 48);
            this.txtRemarks.TabIndex = 3;
            // 
            // lblfk
            // 
            this.lblfk.BackColor = System.Drawing.Color.Transparent;
            this.lblfk.Location = new System.Drawing.Point(2, 22);
            this.lblfk.Name = "lblfk";
            this.lblfk.Size = new System.Drawing.Size(160, 22);
            this.lblfk.TabIndex = 0;
            this.lblfk.Text = "Product List:";
            this.lblfk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Location = new System.Drawing.Point(2, 52);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(160, 22);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(288, 7);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(141, 30);
            this.txtProduct.TabIndex = 78;
            this.txtProduct.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(458, 9);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(70, 30);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(434, 492);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeColor = System.Drawing.Color.Blue;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(327, 492);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.ThemeColor = System.Drawing.Color.Blue;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmDamageLossEntry
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtId);
            this.Name = "frmDamageLossEntry";
            this.Text = "Damage / Loss ";
            this.Load += new System.EventHandler(this.frmDamageLossEntry_Load);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtProduct, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;

        private System.Windows.Forms.TextBox txtRemarks;


        private System.Windows.Forms.Label lblfk;

        private System.Windows.Forms.Label lblQuantity; 


        private System.Windows.Forms.GroupBox groupBox1;
        public bsoftcontrols.fsButton btnCancel;
        public bsoftcontrols.fsButton btnOk;
        private Bsoft.Controls.VtextBox txtQuantity;
        public bsoftcontrols.fsButton btnBrowse;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtGroup_Code;
        public System.Windows.Forms.Label lblListPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblentrydate;
        private System.Windows.Forms.Label lblMeasureUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label lblRateNote;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblRemarks;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblfk_Group;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblfk_Company;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblsizeunit;
        private System.Windows.Forms.Label lblcolour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblweightunit;
        public Bsoft.Controls.VtextBox txtRate;
        private System.Windows.Forms.Label lblRateUnit;
        private System.Windows.Forms.Label label1;
    }
}
