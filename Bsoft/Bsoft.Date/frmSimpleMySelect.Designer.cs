namespace Bsoft.Date
{
    partial class frmSimpleMySelect
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.lblYear = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Button();
            this.lblLeft = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TimerVisibility = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.numMonth);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.numYear);
            this.panel1.Controls.Add(this.lblMonth);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(38, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 30);
            this.panel1.TabIndex = 166;
            // 
            // numMonth
            // 
            this.numMonth.AutoSize = true;
            this.numMonth.Location = new System.Drawing.Point(156, 6);
            this.numMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(43, 21);
            this.numMonth.TabIndex = 1;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.ValueChanged += new System.EventHandler(this.numMonth_ValueChanged);
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(7, 6);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(37, 21);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblYear.Click += new System.EventHandler(this.lalyears_Click);
            // 
            // numYear
            // 
            this.numYear.AutoSize = true;
            this.numYear.Location = new System.Drawing.Point(46, 6);
            this.numYear.Maximum = new decimal(new int[] {
            2075,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1975,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(61, 21);
            this.numYear.TabIndex = 1;
            this.numYear.Value = new decimal(new int[] {
            1975,
            0,
            0,
            0});
            this.numYear.ValueChanged += new System.EventHandler(this.numYear_ValueChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.Location = new System.Drawing.Point(107, 6);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(43, 21);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Month";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonth.Click += new System.EventHandler(this.lblMonth_Click);
            // 
            // lblRight
            // 
            this.lblRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRight.BackColor = System.Drawing.Color.Transparent;
            this.lblRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRight.FlatAppearance.BorderSize = 0;
            this.lblRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRight.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblRight.ForeColor = System.Drawing.Color.Black;
            this.lblRight.Location = new System.Drawing.Point(253, 3);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(27, 34);
            this.lblRight.TabIndex = 164;
            this.lblRight.Text = "4";
            this.lblRight.UseVisualStyleBackColor = false;
            this.lblRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblRight_MouseDown);
            // 
            // lblLeft
            // 
            this.lblLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lblLeft.FlatAppearance.BorderSize = 0;
            this.lblLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLeft.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblLeft.ForeColor = System.Drawing.Color.Black;
            this.lblLeft.Location = new System.Drawing.Point(2, 3);
            this.lblLeft.Margin = new System.Windows.Forms.Padding(0);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(27, 34);
            this.lblLeft.TabIndex = 165;
            this.lblLeft.Text = "3";
            this.lblLeft.UseVisualStyleBackColor = false;
            this.lblLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblLeft_MouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 45);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 195);
            this.tableLayoutPanel1.TabIndex = 168;
            // 
            // TimerVisibility
            // 
            this.TimerVisibility.Enabled = true;
            this.TimerVisibility.Interval = 10;
            this.TimerVisibility.Tick += new System.EventHandler(this.TimerVisibility_Tick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblRight);
            this.panel2.Controls.Add(this.lblLeft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 247);
            this.panel2.TabIndex = 169;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // frmSimpleMySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 247);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmSimpleMySelect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmSimpleMySelect";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMYSelection_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button lblRight;
        private System.Windows.Forms.Button lblLeft;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer TimerVisibility;
        private System.Windows.Forms.Panel panel2;
    }
}