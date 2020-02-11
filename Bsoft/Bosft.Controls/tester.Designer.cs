namespace Bsoft.Controls
{
    partial class tester
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
            this.lblGeneric1 = new Bsoft.Controls.LblGeneric();
            this.SuspendLayout();
            // 
            // lblGeneric1
            // 
            this.lblGeneric1.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneric1.ControlType = Bsoft.Controls.LblGeneric.ControlTypes.DateFromTo;
            this.lblGeneric1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneric1.Lable = "Lable :";
            this.lblGeneric1.Location = new System.Drawing.Point(98, 59);
            this.lblGeneric1.Margin = new System.Windows.Forms.Padding(1);
            this.lblGeneric1.Name = "lblGeneric1";
            this.lblGeneric1.Size = new System.Drawing.Size(294, 80);
            this.lblGeneric1.TabIndex = 0;
            // 
            // tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 250);
            this.Controls.Add(this.lblGeneric1);
            this.Name = "tester";
            this.Text = "tester";
            this.ResumeLayout(false);

        }

        #endregion

        private LblGeneric lblGeneric1;
    }
}