namespace Fruits.Controls
{
    partial class bsoftDgvControler
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
            this.tlControler = new System.Windows.Forms.ToolStrip();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.lblbeforepage = new System.Windows.Forms.ToolStripLabel();
            this.txtPgNo = new System.Windows.Forms.ToolStripTextBox();
            this.lblTotalPage = new System.Windows.Forms.ToolStripLabel();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.lblrowsize = new System.Windows.Forms.ToolStripLabel();
            this.txtpageSize = new System.Windows.Forms.ToolStripTextBox();
            this.lblLast = new System.Windows.Forms.ToolStripLabel();
            this.tlControler.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlControler
            // 
            this.tlControler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlControler.AutoSize = false;
            this.tlControler.Dock = System.Windows.Forms.DockStyle.None;
            this.tlControler.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tlControler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirst,
            this.btnPrevious,
            this.lblbeforepage,
            this.txtPgNo,
            this.lblTotalPage,
            this.btnNext,
            this.btnLast,
            this.lblrowsize,
            this.txtpageSize,
            this.lblLast});
            this.tlControler.Location = new System.Drawing.Point(6, 1);
            this.tlControler.Name = "tlControler";
            this.tlControler.Size = new System.Drawing.Size(579, 25);
            this.tlControler.TabIndex = 5;
            this.tlControler.Text = "toolStrip1";
            // 
            // btnFirst
            // 
            this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirst.Image = global::Friuts.Properties.Resources.first;
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(23, 22);
            this.btnFirst.Text = "First Page";
            // 
            // btnPrevious
            // 
            this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrevious.Image = global::Friuts.Properties.Resources.previous;
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(23, 22);
            this.btnPrevious.Text = "Previous Page";
            // 
            // lblbeforepage
            // 
            this.lblbeforepage.Name = "lblbeforepage";
            this.lblbeforepage.Size = new System.Drawing.Size(35, 22);
            this.lblbeforepage.Text = "Page:";
            // 
            // txtPgNo
            // 
            this.txtPgNo.AutoSize = false;
            this.txtPgNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPgNo.Name = "txtPgNo";
            this.txtPgNo.Size = new System.Drawing.Size(50, 23);
            this.txtPgNo.Text = "1";
            this.txtPgNo.Enter += new System.EventHandler(this.txtPgNo_Enter);
            this.txtPgNo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtPgNo_MouseUp);
            // 
            // lblTotalPage
            // 
            this.lblTotalPage.Name = "lblTotalPage";
            this.lblTotalPage.Size = new System.Drawing.Size(122, 22);
            this.lblTotalPage.Text = "of 5 Page (200 Results)";
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = global::Friuts.Properties.Resources.next;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 22);
            this.btnNext.Text = "Next Page";
            // 
            // btnLast
            // 
            this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLast.Image = global::Friuts.Properties.Resources.last;
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(23, 22);
            this.btnLast.Text = "Last Page";
            // 
            // lblrowsize
            // 
            this.lblrowsize.Name = "lblrowsize";
            this.lblrowsize.Size = new System.Drawing.Size(95, 22);
            this.lblrowsize.Text = "Results per Page:";
            // 
            // txtpageSize
            // 
            this.txtpageSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpageSize.Name = "txtpageSize";
            this.txtpageSize.Size = new System.Drawing.Size(50, 25);
            this.txtpageSize.Text = "10";
            this.txtpageSize.Enter += new System.EventHandler(this.txtPageSize_Enter);
            this.txtpageSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtPageSize_MouseUp);
            // 
            // lblLast
            // 
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(76, 22);
            this.lblLast.Text = "Total Records";
            // 
            // bsoftDgvControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlControler);
            this.Name = "bsoftDgvControler";
            this.Size = new System.Drawing.Size(589, 27);
            this.Load += new System.EventHandler(this.bsoftDgvControler_Load);
            this.tlControler.ResumeLayout(false);
            this.tlControler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ToolStrip tlControler;
        private System.Windows.Forms.ToolStripLabel lblbeforepage;
        public System.Windows.Forms.ToolStripTextBox txtPgNo;
        private System.Windows.Forms.ToolStripLabel lblTotalPage;
        private System.Windows.Forms.ToolStripLabel lblrowsize;
        public System.Windows.Forms.ToolStripButton btnFirst;
        public System.Windows.Forms.ToolStripButton btnNext;
        public System.Windows.Forms.ToolStripButton btnLast;
        public System.Windows.Forms.ToolStripButton btnPrevious;
        private System.Windows.Forms.ToolStripLabel lblLast;
        public System.Windows.Forms.ToolStripTextBox txtpageSize;

    }
}
