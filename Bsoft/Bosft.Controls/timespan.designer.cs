namespace WindowsFormsApplication1
{
    partial class timespan
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
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.lblSpan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFrom = new System.Windows.Forms.Panel();
            this.pnlSpan = new System.Windows.Forms.Panel();
            this.pnlTo = new System.Windows.Forms.Panel();
            this.pnlFrom.SuspendLayout();
            this.pnlSpan.SuspendLayout();
            this.pnlTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(61, 3);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(125, 20);
            this.dtFrom.TabIndex = 0;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.CustomFormat = "dd/MMM/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(61, 2);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(125, 20);
            this.dtTo.TabIndex = 1;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // lblSpan
            // 
            this.lblSpan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpan.BackColor = System.Drawing.Color.Transparent;
            this.lblSpan.Location = new System.Drawing.Point(5, 3);
            this.lblSpan.Name = "lblSpan";
            this.lblSpan.Size = new System.Drawing.Size(92, 33);
            this.lblSpan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFrom
            // 
            this.pnlFrom.Controls.Add(this.dtFrom);
            this.pnlFrom.Controls.Add(this.label1);
            this.pnlFrom.Location = new System.Drawing.Point(3, 3);
            this.pnlFrom.Name = "pnlFrom";
            this.pnlFrom.Size = new System.Drawing.Size(182, 36);
            this.pnlFrom.TabIndex = 2;
            // 
            // pnlSpan
            // 
            this.pnlSpan.Controls.Add(this.lblSpan);
            this.pnlSpan.Location = new System.Drawing.Point(3, 85);
            this.pnlSpan.Name = "pnlSpan";
            this.pnlSpan.Size = new System.Drawing.Size(100, 36);
            this.pnlSpan.TabIndex = 3;
            // 
            // pnlTo
            // 
            this.pnlTo.Controls.Add(this.label2);
            this.pnlTo.Controls.Add(this.dtTo);
            this.pnlTo.Location = new System.Drawing.Point(3, 45);
            this.pnlTo.Name = "pnlTo";
            this.pnlTo.Size = new System.Drawing.Size(182, 34);
            this.pnlTo.TabIndex = 1;
            // 
            // timespan
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlFrom);
            this.Controls.Add(this.pnlTo);
            this.Controls.Add(this.pnlSpan);
            this.Size = new System.Drawing.Size(251, 138);
            this.pnlFrom.ResumeLayout(false);
            this.pnlSpan.ResumeLayout(false);
            this.pnlTo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtFrom;
        public System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Panel pnlFrom;
        private System.Windows.Forms.Panel pnlTo;
        private System.Windows.Forms.Panel pnlSpan;
    }
}
