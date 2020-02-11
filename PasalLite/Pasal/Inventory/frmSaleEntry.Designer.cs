namespace Pasal.Inventory
{
    partial class frmSaleEntry
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
            this.grpDiscount = new System.Windows.Forms.GroupBox();
            this.txtDiscount = new Bsoft.Controls.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscountPercent = new Bsoft.Controls.NumericTextBox();
            this.grid = new System.Windows.Forms.DataGridView();
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
            this.txtGroup_Code = new System.Windows.Forms.TextBox();
            this.lblMeasureUnit = new System.Windows.Forms.Label();
            this.btnBrowse = new bsoftcontrols.fsButton();
            this.txtRate = new Bsoft.Controls.NumericTextBox();
            this.txtAmount = new Bsoft.Controls.NumericTextBox();
            this.lblRateUnit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new Bsoft.Controls.NumericTextBox();
            this.lblRateNote = new System.Windows.Forms.Label();
            this.lblRemarkss = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblfk_store = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(814, 2);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.grpDiscount);
            this.groupBox1.Controls.Add(this.grid);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtGroup_Code);
            this.groupBox1.Controls.Add(this.lblMeasureUnit);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.lblRateUnit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.lblRateNote);
            this.groupBox1.Controls.Add(this.lblRemarkss);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblfk_store);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 490);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // grpDiscount
            // 
            this.grpDiscount.Controls.Add(this.txtDiscount);
            this.grpDiscount.Controls.Add(this.label1);
            this.grpDiscount.Controls.Add(this.label2);
            this.grpDiscount.Controls.Add(this.txtDiscountPercent);
            this.grpDiscount.Location = new System.Drawing.Point(63, 142);
            this.grpDiscount.Name = "grpDiscount";
            this.grpDiscount.Size = new System.Drawing.Size(281, 74);
            this.grpDiscount.TabIndex = 83;
            this.grpDiscount.TabStop = false;
            this.grpDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(85, 15);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(160, 23);
            this.txtDiscount.TabIndex = 4;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.ValidationType = Bsoft.Controls.NumericTextBox.ValidationTypeEnum.Decimal;
            this.txtDiscount.Value = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.Enter += new System.EventHandler(this.txtDiscount_Enter);
            this.txtDiscount.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiscount_Validating);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "(%)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(248, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(85, 43);
            this.txtDiscountPercent.MaxLength = 5;
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(68, 23);
            this.txtDiscountPercent.TabIndex = 5;
            this.txtDiscountPercent.Text = "0";
            this.txtDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountPercent.ValidationType = Bsoft.Controls.NumericTextBox.ValidationTypeEnum.Decimal;
            this.txtDiscountPercent.Value = "0";
            this.txtDiscountPercent.TextChanged += new System.EventHandler(this.txtDiscountPercent_TextChanged);
            this.txtDiscountPercent.Enter += new System.EventHandler(this.txtDiscountPercent_Enter);
            this.txtDiscountPercent.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiscountPercent_Validating);
            // 
            // grid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(70, 336);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(686, 143);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 82;
            this.grid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_CellMouseDown);
            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
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
            this.groupBox2.Location = new System.Drawing.Point(458, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 252);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(1, 36);
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
            this.label5.Location = new System.Drawing.Point(167, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "--";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(1, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 22);
            this.label15.TabIndex = 40;
            this.label15.Text = "Group:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Location = new System.Drawing.Point(1, 215);
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
            this.lblName.Location = new System.Drawing.Point(167, 36);
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
            this.lblsize.Location = new System.Drawing.Point(167, 184);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(81, 22);
            this.lblsize.TabIndex = 28;
            this.lblsize.Text = "--";
            this.lblsize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(1, 96);
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
            this.lblfk_Group.Location = new System.Drawing.Point(167, 66);
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
            this.lblweight.Location = new System.Drawing.Point(167, 154);
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
            this.lblfk_Company.Location = new System.Drawing.Point(167, 96);
            this.lblfk_Company.Name = "lblfk_Company";
            this.lblfk_Company.Size = new System.Drawing.Size(160, 22);
            this.lblfk_Company.TabIndex = 38;
            this.lblfk_Company.Text = "--";
            this.lblfk_Company.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(1, 184);
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
            this.lblsizeunit.Location = new System.Drawing.Point(246, 184);
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
            this.lblcolour.Location = new System.Drawing.Point(167, 124);
            this.lblcolour.Name = "lblcolour";
            this.lblcolour.Size = new System.Drawing.Size(160, 22);
            this.lblcolour.TabIndex = 44;
            this.lblcolour.Text = "--";
            this.lblcolour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(1, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 22);
            this.label11.TabIndex = 45;
            this.label11.Text = "colour:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(1, 154);
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
            this.lblweightunit.Location = new System.Drawing.Point(246, 154);
            this.lblweightunit.Name = "lblweightunit";
            this.lblweightunit.Size = new System.Drawing.Size(70, 22);
            this.lblweightunit.TabIndex = 46;
            this.lblweightunit.Text = "--";
            this.lblweightunit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGroup_Code
            // 
            this.txtGroup_Code.Location = new System.Drawing.Point(148, 23);
            this.txtGroup_Code.Name = "txtGroup_Code";
            this.txtGroup_Code.Size = new System.Drawing.Size(160, 23);
            this.txtGroup_Code.TabIndex = 0;
            // 
            // lblMeasureUnit
            // 
            this.lblMeasureUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblMeasureUnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasureUnit.Location = new System.Drawing.Point(322, 55);
            this.lblMeasureUnit.Name = "lblMeasureUnit";
            this.lblMeasureUnit.Size = new System.Drawing.Size(70, 22);
            this.lblMeasureUnit.TabIndex = 46;
            this.lblMeasureUnit.Text = "--";
            this.lblMeasureUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBrowse.Location = new System.Drawing.Point(325, 23);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(38, 24);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.ThemeColor = System.Drawing.Color.Blue;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(148, 114);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(160, 23);
            this.txtRate.TabIndex = 3;
            this.txtRate.TabStop = false;
            this.txtRate.Text = "0";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRate.ValidationType = Bsoft.Controls.NumericTextBox.ValidationTypeEnum.Decimal;
            this.txtRate.Value = "0";
            this.txtRate.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(148, 82);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(160, 23);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TabStop = false;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.ValidationType = Bsoft.Controls.NumericTextBox.ValidationTypeEnum.Decimal;
            this.txtAmount.Value = "0";
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblRateUnit
            // 
            this.lblRateUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblRateUnit.Location = new System.Drawing.Point(312, 114);
            this.lblRateUnit.Name = "lblRateUnit";
            this.lblRateUnit.Size = new System.Drawing.Size(47, 22);
            this.lblRateUnit.TabIndex = 0;
            this.lblRateUnit.Text = "Rs";
            this.lblRateUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(312, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rs";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(148, 52);
            this.txtQuantity.MaxLength = 10;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(160, 23);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.ValidationType = Bsoft.Controls.NumericTextBox.ValidationTypeEnum.Decimal;
            this.txtQuantity.Value = "";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            // 
            // lblRateNote
            // 
            this.lblRateNote.BackColor = System.Drawing.Color.Transparent;
            this.lblRateNote.Location = new System.Drawing.Point(70, 303);
            this.lblRateNote.Name = "lblRateNote";
            this.lblRateNote.Size = new System.Drawing.Size(583, 22);
            this.lblRateNote.TabIndex = 0;
            this.lblRateNote.Text = "There are some old stock also ,Please select the rate for current selling.";
            this.lblRateNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemarkss
            // 
            this.lblRemarkss.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarkss.Location = new System.Drawing.Point(25, 223);
            this.lblRemarkss.Name = "lblRemarkss";
            this.lblRemarkss.Size = new System.Drawing.Size(115, 22);
            this.lblRemarkss.TabIndex = 0;
            this.lblRemarkss.Text = "Remarks:";
            this.lblRemarkss.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(27, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rate:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Location = new System.Drawing.Point(29, 81);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(112, 22);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Location = new System.Drawing.Point(29, 51);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(112, 22);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblfk_store
            // 
            this.lblfk_store.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_store.Location = new System.Drawing.Point(29, 22);
            this.lblfk_store.Name = "lblfk_store";
            this.lblfk_store.Size = new System.Drawing.Size(112, 22);
            this.lblfk_store.TabIndex = 0;
            this.lblfk_store.Text = "Item:";
            this.lblfk_store.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.Location = new System.Drawing.Point(148, 223);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(192, 64);
            this.txtRemarks.TabIndex = 6;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(469, 16);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(73, 23);
            this.txtProduct.TabIndex = 80;
            this.txtProduct.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(295, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(160, 23);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(172, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(112, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(422, 544);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 1;
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
            this.btnOk.Location = new System.Drawing.Point(327, 544);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.ThemeColor = System.Drawing.Color.Blue;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(181)))), ((int)(((byte)(223)))));
            this.lblDate.Location = new System.Drawing.Point(623, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 17);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Date : ";
            // 
            // frmSaleEntry
            // 
            this.AcceptButton = this.btnOk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 588);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "frmSaleEntry";
            this.Text = "Selling";
            this.Load += new System.EventHandler(this.frmSaleEntry_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblId, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtProduct, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDiscount.ResumeLayout(false);
            this.grpDiscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;          private System.Windows.Forms.Label  lblId;


 private System.Windows.Forms.Label lblfk_store;

 private System.Windows.Forms.Label lblQuantity;

        private System.Windows.Forms.Label lblAmount;

 private System.Windows.Forms.Label lblRemarkss; 
        private System.Windows.Forms.GroupBox groupBox1;
        public bsoftcontrols.fsButton btnCancel;
        public bsoftcontrols.fsButton btnOk;
        private  Bsoft .Controls .NumericTextBox txtDiscountPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public bsoftcontrols.fsButton btnBrowse;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblfk_Group;
        private System.Windows.Forms.Label lblfk_Company;
        private System.Windows.Forms.Label lblsizeunit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblweightunit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblcolour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtRemarks;
        public  Bsoft .Controls .NumericTextBox txtDiscount;
        public  Bsoft .Controls .NumericTextBox txtAmount;
        public Bsoft.Controls.NumericTextBox txtQuantity;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMeasureUnit;
        public System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid;
        public Bsoft.Controls.NumericTextBox txtRate;
        private System.Windows.Forms.Label lblRateUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRateNote;
        private System.Windows.Forms.GroupBox grpDiscount;
        public System.Windows.Forms.TextBox txtGroup_Code;
    }
}
