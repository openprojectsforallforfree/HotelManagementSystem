namespace Bsoft.Date
{
    partial class Calendar
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
            this.lblRight = new System.Windows.Forms.Button();
            this.lblLeft = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNepYear = new System.Windows.Forms.Label();
            this.lblNepMonth = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEngYear = new System.Windows.Forms.Label();
            this.lblEngMonth = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.cal1 = new Bsoft.Date.CAL();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRight
            // 
            this.lblRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRight.BackColor = System.Drawing.Color.Transparent;
            this.lblRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRight.FlatAppearance.BorderSize = 0;
            this.lblRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.lblRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lblRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lblRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRight.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblRight.ForeColor = System.Drawing.Color.Black;
            this.lblRight.Location = new System.Drawing.Point(422, 0);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(26, 34);
            this.lblRight.TabIndex = 145;
            this.lblRight.Text = "4";
            this.lblRight.UseVisualStyleBackColor = false;
            this.lblRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Right_MouseDown);
            // 
            // lblLeft
            // 
            this.lblLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lblLeft.FlatAppearance.BorderSize = 0;
            this.lblLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.lblLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lblLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lblLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLeft.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblLeft.ForeColor = System.Drawing.Color.Black;
            this.lblLeft.Location = new System.Drawing.Point(0, 0);
            this.lblLeft.Margin = new System.Windows.Forms.Padding(0);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(26, 34);
            this.lblLeft.TabIndex = 146;
            this.lblLeft.Text = "3";
            this.lblLeft.UseVisualStyleBackColor = false;
            this.lblLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Left_MouseDown);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(27, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(395, 31);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 149;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblNepYear);
            this.flowLayoutPanel2.Controls.Add(this.lblNepMonth);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(185, 31);
            this.flowLayoutPanel2.TabIndex = 151;
            // 
            // lblNepYear
            // 
            this.lblNepYear.AutoSize = true;
            this.lblNepYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNepYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNepYear.Location = new System.Drawing.Point(3, 7);
            this.lblNepYear.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblNepYear.Name = "lblNepYear";
            this.lblNepYear.Size = new System.Drawing.Size(29, 20);
            this.lblNepYear.TabIndex = 0;
            this.lblNepYear.Text = "----";
            this.lblNepYear.Click += new System.EventHandler(this.lblNepYear_Click);
            // 
            // lblNepMonth
            // 
            this.lblNepMonth.AutoSize = true;
            this.lblNepMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNepMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNepMonth.Location = new System.Drawing.Point(38, 7);
            this.lblNepMonth.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblNepMonth.Name = "lblNepMonth";
            this.lblNepMonth.Size = new System.Drawing.Size(29, 20);
            this.lblNepMonth.TabIndex = 0;
            this.lblNepMonth.Text = "----";
            this.lblNepMonth.Click += new System.EventHandler(this.lblNepMonth_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lblEngYear);
            this.flowLayoutPanel1.Controls.Add(this.lblEngMonth);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 31);
            this.flowLayoutPanel1.TabIndex = 150;
            // 
            // lblEngYear
            // 
            this.lblEngYear.AutoSize = true;
            this.lblEngYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEngYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngYear.Location = new System.Drawing.Point(174, 7);
            this.lblEngYear.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblEngYear.Name = "lblEngYear";
            this.lblEngYear.Size = new System.Drawing.Size(29, 20);
            this.lblEngYear.TabIndex = 0;
            this.lblEngYear.Text = "----";
            this.lblEngYear.Click += new System.EventHandler(this.lblEngYear_Click);
            // 
            // lblEngMonth
            // 
            this.lblEngMonth.AutoSize = true;
            this.lblEngMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEngMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngMonth.Location = new System.Drawing.Point(139, 7);
            this.lblEngMonth.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblEngMonth.Name = "lblEngMonth";
            this.lblEngMonth.Size = new System.Drawing.Size(29, 20);
            this.lblEngMonth.TabIndex = 0;
            this.lblEngMonth.Text = "----";
            this.lblEngMonth.Click += new System.EventHandler(this.lblEngMonth_Click);
            // 
            // lblToday
            // 
            this.lblToday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.Location = new System.Drawing.Point(25, 329);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(399, 20);
            this.lblToday.TabIndex = 150;
            this.lblToday.Text = "----";
            this.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblToday_MouseDown);
            // 
            // cal1
            // 
            this.cal1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cal1.BackColor = System.Drawing.Color.Transparent;
            this.cal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cal1.calBackColor = System.Drawing.Color.Transparent;
            this.cal1.Location = new System.Drawing.Point(0, 36);
            this.cal1.Name = "cal1";
            this.cal1.NormalBackColor = System.Drawing.Color.SlateGray;
            this.cal1.SelectedColor = System.Drawing.Color.Teal;
            this.cal1.ShadowBackColor = System.Drawing.Color.SteelBlue;
            this.cal1.showBorder = true;
            this.cal1.Size = new System.Drawing.Size(446, 286);
            this.cal1.TabIndex = 0;
            this.cal1.weekNameFormat = Bsoft.Date.WeekNameFormat.Short;
            this.cal1.Load += new System.EventHandler(this.cal1_Load);
            this.cal1.Alarm += new Bsoft.Date.CAL.DateEventHandler(this.cal1_Alarm_1);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.cal1);
            this.Name = "Calendar";
            this.Size = new System.Drawing.Size(448, 354);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lblRight;
        private System.Windows.Forms.Button lblLeft;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblNepYear;
        private System.Windows.Forms.Label lblNepMonth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblEngYear;
        private System.Windows.Forms.Label lblEngMonth;
        private System.Windows.Forms.Label lblToday;
        public CAL cal1;
    }
}
