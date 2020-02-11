namespace Bsoft.Date
{
    partial class WeekAtom
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
            this.SuspendLayout();
            // 
            // WeekAtom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "WeekAtom";
            this.Load += new System.EventHandler(this.WeekAtom_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WeekAtom_Paint);
            this.Resize += new System.EventHandler(this.WeekAtom_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
