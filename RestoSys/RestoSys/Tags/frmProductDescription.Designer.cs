namespace RestoSys.Tags
{
    partial class frmProductDescription
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
            this.flwTags = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGeneric = new Bsoft.Controls.LblGeneric();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flwTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(804, 2);
            this._closeButton.Size = new System.Drawing.Size(43, 39);
            // 
            // flwTags
            // 
            this.flwTags.BackColor = System.Drawing.Color.Transparent;
            this.flwTags.Controls.Add(this.lblGeneric);
            this.flwTags.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwTags.Location = new System.Drawing.Point(11, 10);
            this.flwTags.Margin = new System.Windows.Forms.Padding(4);
            this.flwTags.Name = "flwTags";
            this.flwTags.Size = new System.Drawing.Size(498, 239);
            this.flwTags.TabIndex = 1;
            this.flwTags.WrapContents = false;
            // 
            // lblGeneric
            // 
            this.lblGeneric.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneric.ControlType = Bsoft.Controls.LblGeneric.ControlTypes.TextBox;
            this.lblGeneric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneric.Lable = "Lable :";
            this.lblGeneric.Location = new System.Drawing.Point(4, 4);
            this.lblGeneric.Margin = new System.Windows.Forms.Padding(4);
            this.lblGeneric.Name = "lblGeneric";
            this.lblGeneric.Size = new System.Drawing.Size(484, 27);
            this.lblGeneric.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(569, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // frmProductDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.flwTags);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductDescription";
            this.Text = "frmProductDescription";
            this.Controls.SetChildIndex(this.flwTags, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.flwTags.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bsoft.Controls.LblGeneric lblGeneric;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.FlowLayoutPanel flwTags;

    }
}