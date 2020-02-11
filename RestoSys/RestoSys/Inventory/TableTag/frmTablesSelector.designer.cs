namespace RestoSys
{
    partial class FrmTablesSelector
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
            this.flwTables = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOks = new bsoftcontrols.fsButton();
            this.btnsCancels = new bsoftcontrols.fsButton();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(359, 2);
            this._closeButton.Size = new System.Drawing.Size(36, 30);
            // 
            // flwTables
            // 
            this.flwTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flwTables.BackColor = System.Drawing.Color.Transparent;
            this.flwTables.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwTables.Location = new System.Drawing.Point(17, 41);
            this.flwTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flwTables.Name = "flwTables";
            this.flwTables.Size = new System.Drawing.Size(369, 260);
            this.flwTables.TabIndex = 0;
            // 
            // btnOks
            // 
            this.btnOks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOks.BackColor = System.Drawing.Color.Transparent;
            this.btnOks.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOks.FlatAppearance.BorderSize = 0;
            this.btnOks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOks.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOks.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOks.Location = new System.Drawing.Point(82, 313);
            this.btnOks.Margin = new System.Windows.Forms.Padding(0);
            this.btnOks.Name = "btnOks";
            this.btnOks.Size = new System.Drawing.Size(98, 29);
            this.btnOks.TabIndex = 11;
            this.btnOks.Text = "Ok";
            this.btnOks.ThemeColor = System.Drawing.Color.Blue;
            this.btnOks.UseVisualStyleBackColor = false;
            this.btnOks.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnsCancels
            // 
            this.btnsCancels.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnsCancels.BackColor = System.Drawing.Color.Transparent;
            this.btnsCancels.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnsCancels.FlatAppearance.BorderSize = 0;
            this.btnsCancels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsCancels.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsCancels.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnsCancels.Location = new System.Drawing.Point(224, 313);
            this.btnsCancels.Margin = new System.Windows.Forms.Padding(0);
            this.btnsCancels.Name = "btnsCancels";
            this.btnsCancels.Size = new System.Drawing.Size(98, 29);
            this.btnsCancels.TabIndex = 12;
            this.btnsCancels.Text = "Cancel";
            this.btnsCancels.ThemeColor = System.Drawing.Color.Blue;
            this.btnsCancels.UseVisualStyleBackColor = false;
            this.btnsCancels.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmTablesSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 351);
            this.Controls.Add(this.btnsCancels);
            this.Controls.Add(this.btnOks);
            this.Controls.Add(this.flwTables);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTablesSelector";
            this.Text = "Select Additional Tables";
            this.Load += new System.EventHandler(this.FrmTablesSelector_Load);
            this.Controls.SetChildIndex(this.flwTables, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.btnOks, 0);
            this.Controls.SetChildIndex(this.btnsCancels, 0);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flwTables;
        public bsoftcontrols.fsButton btnOks;
        public bsoftcontrols.fsButton btnsCancels;
    }
}