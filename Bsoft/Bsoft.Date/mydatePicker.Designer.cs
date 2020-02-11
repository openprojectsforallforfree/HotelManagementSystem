namespace Bsoft.Date
{
    partial class mydatePicker
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
            this.chk = new System.Windows.Forms.CheckBox();
            this.btnDown = new System.Windows.Forms.Label();
            this.mxtDate = new Bsoft.Controls.MyMask();
            this.SuspendLayout();
            // 
            // chk
            // 
            this.chk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk.AutoSize = true;
            this.chk.BackColor = System.Drawing.Color.Transparent;
            this.chk.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk.Location = new System.Drawing.Point(0, 4);
            this.chk.Margin = new System.Windows.Forms.Padding(0);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(15, 14);
            this.chk.TabIndex = 0;
            this.chk.TabStop = false;
            this.chk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk.UseVisualStyleBackColor = false;
            this.chk.VisibleChanged += new System.EventHandler(this.chk_VisibleChanged);
            this.chk.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Font = new System.Drawing.Font("Webdings", 12F);
            this.btnDown.Location = new System.Drawing.Point(215, 0);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(24, 32);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "";
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDown.Click += new System.EventHandler(this.label1_Click);
            // 
            // mxtDate
            // 
            this.mxtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mxtDate.Format = "dd/mm/yyyy";
            this.mxtDate.HideSelection = false;
            this.mxtDate.Location = new System.Drawing.Point(44, 2);
            this.mxtDate.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.mxtDate.Name = "mxtDate";
            this.mxtDate.Size = new System.Drawing.Size(141, 19);
            this.mxtDate.TabIndex = 3;
            this.mxtDate.Text = "";
            this.mxtDate.Leave += new System.EventHandler(this.mxtDate_Leave);
            this.mxtDate.Enter += new System.EventHandler(this.mxtDate_Enter);
            // 
            // mydatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mxtDate);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.chk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "mydatePicker";
            this.Size = new System.Drawing.Size(240, 30);
            this.Resize += new System.EventHandler(this.datePicker_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk;
        private System.Windows.Forms.Label btnDown;
        private Bsoft.Controls.MyMask mxtDate;
    }
}
