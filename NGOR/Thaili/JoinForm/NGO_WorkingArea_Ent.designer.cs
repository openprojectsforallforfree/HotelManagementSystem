namespace UEMS
{
    partial class NGO_WorkingArea_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NGO_WorkingArea_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtfk_NGO = new System.Windows.Forms.TextBox();
            this.txtfk_Address = new System.Windows.Forms.TextBox();
            this.grpfk_Address = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(490, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(270, 261);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(176, 261);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(203, 4);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(45, 30);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // txtfk_NGO
            // 
            this.txtfk_NGO.Location = new System.Drawing.Point(254, 4);
            this.txtfk_NGO.MaxLength = 5;
            this.txtfk_NGO.Name = "txtfk_NGO";
            this.txtfk_NGO.Size = new System.Drawing.Size(45, 30);
            this.txtfk_NGO.TabIndex = 0;
            this.txtfk_NGO.Visible = false;
            // 
            // txtfk_Address
            // 
            this.txtfk_Address.Location = new System.Drawing.Point(305, 4);
            this.txtfk_Address.MaxLength = 5;
            this.txtfk_Address.Name = "txtfk_Address";
            this.txtfk_Address.Size = new System.Drawing.Size(45, 30);
            this.txtfk_Address.TabIndex = 0;
            this.txtfk_Address.Visible = false;
            // 
            // grpfk_Address
            // 
            this.grpfk_Address.BackColor = System.Drawing.Color.Transparent;
            this.grpfk_Address.Location = new System.Drawing.Point(32, 51);
            this.grpfk_Address.Name = "grpfk_Address";
            this.grpfk_Address.Size = new System.Drawing.Size(460, 207);
            this.grpfk_Address.TabIndex = 10;
            // 
            // NGO_WorkingArea_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 299);
            this.Controls.Add(this.grpfk_Address);
            this.Controls.Add(this.txtfk_Address);
            this.Controls.Add(this.txtfk_NGO);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "NGO_WorkingArea_Ent";
            this.Text = "वर्तमान कार्यक्रम क्षेत्र (भौगोलिक)";
            this.Load += new System.EventHandler(this.NGO_WorkingArea_Ent_Load);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtfk_NGO, 0);
            this.Controls.SetChildIndex(this.txtfk_Address, 0);
            this.Controls.SetChildIndex(this.grpfk_Address, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }//<Control>   

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtfk_NGO;
 private System.Windows.Forms.TextBox txtfk_Address; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.Panel grpfk_Address;
    }
}
