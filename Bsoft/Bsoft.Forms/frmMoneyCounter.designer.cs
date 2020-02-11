namespace Bsoft.Forms
{
    partial class frmMoneyCounter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colDenomination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeficit = new System.Windows.Forms.Label();
            this.btnOk = new bsoftcontrols.fsButton();
            this.btnCancel = new bsoftcontrols.fsButton();
            this.txtExpected = new Bsoft.Controls.VtextBox();
            this.txtTotal = new Bsoft.Controls.VtextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(438, 0);
            this._closeButton.Size = new System.Drawing.Size(32, 33);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDenomination,
            this.colValue,
            this.colQuantity,
            this.colAmount});
            this.grid.Location = new System.Drawing.Point(4, 45);
            this.grid.Margin = new System.Windows.Forms.Padding(4);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(467, 457);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 1;
            this.grid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellValidated);
            // 
            // colDenomination
            // 
            this.colDenomination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDenomination.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDenomination.HeaderText = "Denomination";
            this.colDenomination.Name = "colDenomination";
            this.colDenomination.ReadOnly = true;
            this.colDenomination.Width = 120;
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Visible = false;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 86;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 81;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 510);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 540);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Expected Amount:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDeficit
            // 
            this.lblDeficit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeficit.BackColor = System.Drawing.Color.Transparent;
            this.lblDeficit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeficit.Location = new System.Drawing.Point(16, 568);
            this.lblDeficit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeficit.Name = "lblDeficit";
            this.lblDeficit.Size = new System.Drawing.Size(263, 35);
            this.lblDeficit.TabIndex = 5;
            this.lblDeficit.Text = "Deficit :";
            this.lblDeficit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeficit.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(389, 571);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 36);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Close";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(309, 571);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Clear All";
            this.btnCancel.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtExpected
            // 
            this.txtExpected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpected.Location = new System.Drawing.Point(322, 540);
            this.txtExpected.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpected.Name = "txtExpected";
            this.txtExpected.Size = new System.Drawing.Size(138, 22);
            this.txtExpected.TabIndex = 0;
            this.txtExpected.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExpected.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtExpected.Value = "";
            this.txtExpected.TextChanged += new System.EventHandler(this.txtExpected_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(322, 510);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(138, 22);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Decimal;
            this.txtTotal.Value = "";
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // frmMoneyCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 618);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtExpected);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblDeficit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMoneyCounter";
            this.Text = "Cash counting tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblDeficit, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.txtExpected, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeficit;
        private Bsoft.Controls.VtextBox txtTotal;
        private Bsoft.Controls.VtextBox txtExpected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDenomination;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private bsoftcontrols.fsButton btnOk;
        private bsoftcontrols.fsButton btnCancel;



    }
}

