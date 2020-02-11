namespace Bsoft.Date
{
    partial class ATOM
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // ATOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ATOM";
            this.Load += new System.EventHandler(this.ATOM_Load);
            this.MouseLeave += new System.EventHandler(this.ATOM_MouseLeave);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ATOM_Paint);
            this.Resize += new System.EventHandler(this.ATOM_Resize);
            this.MouseEnter += new System.EventHandler(this.ATOM_MouseEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
    }
}
