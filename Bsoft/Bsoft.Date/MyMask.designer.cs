namespace Bsoft.Controls
{
    partial class MyMask
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
            // MyMask
            // 
            this.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.Size = new System.Drawing.Size(502, 20);
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextChanged += new System.EventHandler(this.MyMask_TextChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyMask_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyMask_KeyUp);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyMask_KeyPress);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MyMask_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
