namespace Bsoft.Controls
{
    partial class DateFromTo
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.lblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "To ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(41, 5);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.ShowCheckBox = true;
            this.dtFrom.Size = new System.Drawing.Size(131, 20);
            this.dtFrom.TabIndex = 2;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd/MMM/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(41, 27);
            this.dtTo.Name = "dtTo";
            this.dtTo.ShowCheckBox = true;
            this.dtTo.Size = new System.Drawing.Size(131, 20);
            this.dtTo.TabIndex = 3;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // lblDays
            // 
            this.lblDays.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDays.Location = new System.Drawing.Point(6, 47);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(166, 21);
            this.lblDays.TabIndex = 5;
            this.lblDays.Text = "Days";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateFromTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.dtTo);
            this.Name = "DateFromTo";
            this.Size = new System.Drawing.Size(183, 74);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtFrom;
        public System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label lblDays;
    }
}
