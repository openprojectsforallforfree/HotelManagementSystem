namespace Bsoft.Controls
{
    partial class LableFlowLayout
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Mangal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "-&Label";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LableFlowLayout
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.label1);
            this.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Size = new System.Drawing.Size(515, 369);
            this.Leave += new System.EventHandler(this.LableFlowLayout_Leave);
            this.Resize += new System.EventHandler(this.LableFlowLayout_Resize);
            this.Enter += new System.EventHandler(this.LableFlowLayout_Enter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;





    }
}
