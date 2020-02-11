namespace UEMS
{
    partial class Room_Ent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtid = new Bsoft.Controls.VtextBox();
            this.txtName = new Bsoft.Controls.VtextBox();
            this.txtIsDormitory = new Bsoft.Controls.VtextBox();
            this.txtPerRoomRate = new Bsoft.Controls.VtextBox();
            this.txtfacilities = new Bsoft.Controls.VtextBox();
            this.txtmaxnos = new Bsoft.Controls.VtextBox();
            this.txtremarks = new Bsoft.Controls.VtextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblfacilities = new System.Windows.Forms.Label();
            this.lblmaxnos = new System.Windows.Forms.Label();
            this.lblremarks = new System.Windows.Forms.Label();
            this.chkDormitory = new System.Windows.Forms.CheckBox();
            this.lblMEssage = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.lblCtype = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerPersonRate = new Bsoft.Controls.VtextBox();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(624, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(337, 338);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 6;
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
            this.btnOk.Location = new System.Drawing.Point(243, 338);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(193, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(160, 23);
            this.txtid.TabIndex = 0;
            this.txtid.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtid.Value = "";
            this.txtid.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(220, 104);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 23);
            this.txtName.TabIndex = 0;
            this.txtName.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtName.Value = "";
            // 
            // txtIsDormitory
            // 
            this.txtIsDormitory.Location = new System.Drawing.Point(88, 11);
            this.txtIsDormitory.Name = "txtIsDormitory";
            this.txtIsDormitory.Size = new System.Drawing.Size(52, 23);
            this.txtIsDormitory.TabIndex = 0;
            this.txtIsDormitory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIsDormitory.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Integer;
            this.txtIsDormitory.Value = "";
            this.txtIsDormitory.Visible = false;
            this.txtIsDormitory.TextChanged += new System.EventHandler(this.txtIsDormitory_TextChanged);
            // 
            // txtPerRoomRate
            // 
            this.txtPerRoomRate.Location = new System.Drawing.Point(220, 158);
            this.txtPerRoomRate.Name = "txtPerRoomRate";
            this.txtPerRoomRate.Size = new System.Drawing.Size(160, 23);
            this.txtPerRoomRate.TabIndex = 1;
            this.txtPerRoomRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPerRoomRate.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Integer;
            this.txtPerRoomRate.Value = "";
            // 
            // txtfacilities
            // 
            this.txtfacilities.Location = new System.Drawing.Point(425, 12);
            this.txtfacilities.MaxLength = 50;
            this.txtfacilities.Name = "txtfacilities";
            this.txtfacilities.Size = new System.Drawing.Size(160, 23);
            this.txtfacilities.TabIndex = 0;
            this.txtfacilities.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtfacilities.Value = "";
            this.txtfacilities.Visible = false;
            // 
            // txtmaxnos
            // 
            this.txtmaxnos.Location = new System.Drawing.Point(220, 185);
            this.txtmaxnos.Name = "txtmaxnos";
            this.txtmaxnos.Size = new System.Drawing.Size(160, 23);
            this.txtmaxnos.TabIndex = 2;
            this.txtmaxnos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtmaxnos.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Integer;
            this.txtmaxnos.Value = "";
            // 
            // txtremarks
            // 
            this.txtremarks.Location = new System.Drawing.Point(220, 212);
            this.txtremarks.MaxLength = 150;
            this.txtremarks.Multiline = true;
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(400, 50);
            this.txtremarks.TabIndex = 3;
            this.txtremarks.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.No_Validation;
            this.txtremarks.Value = "";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(37, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRate
            // 
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Location = new System.Drawing.Point(37, 157);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(160, 22);
            this.lblRate.TabIndex = 0;
            this.lblRate.Text = "Rate Per Room:";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblfacilities
            // 
            this.lblfacilities.BackColor = System.Drawing.Color.Transparent;
            this.lblfacilities.Location = new System.Drawing.Point(242, 12);
            this.lblfacilities.Name = "lblfacilities";
            this.lblfacilities.Size = new System.Drawing.Size(160, 22);
            this.lblfacilities.TabIndex = 0;
            this.lblfacilities.Text = "Facilities:";
            this.lblfacilities.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblfacilities.Visible = false;
            // 
            // lblmaxnos
            // 
            this.lblmaxnos.BackColor = System.Drawing.Color.Transparent;
            this.lblmaxnos.Location = new System.Drawing.Point(37, 184);
            this.lblmaxnos.Name = "lblmaxnos";
            this.lblmaxnos.Size = new System.Drawing.Size(160, 22);
            this.lblmaxnos.TabIndex = 0;
            this.lblmaxnos.Text = "Max Nos:";
            this.lblmaxnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblremarks
            // 
            this.lblremarks.BackColor = System.Drawing.Color.Transparent;
            this.lblremarks.Location = new System.Drawing.Point(37, 211);
            this.lblremarks.Name = "lblremarks";
            this.lblremarks.Size = new System.Drawing.Size(160, 22);
            this.lblremarks.TabIndex = 0;
            this.lblremarks.Text = "Remarks:";
            this.lblremarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkDormitory
            // 
            this.chkDormitory.AutoSize = true;
            this.chkDormitory.BackColor = System.Drawing.Color.Transparent;
            this.chkDormitory.Checked = true;
            this.chkDormitory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDormitory.Location = new System.Drawing.Point(220, 266);
            this.chkDormitory.Name = "chkDormitory";
            this.chkDormitory.Size = new System.Drawing.Size(88, 21);
            this.chkDormitory.TabIndex = 4;
            this.chkDormitory.Text = "Dormitory";
            this.chkDormitory.UseVisualStyleBackColor = false;
            this.chkDormitory.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblMEssage
            // 
            this.lblMEssage.BackColor = System.Drawing.Color.Transparent;
            this.lblMEssage.Location = new System.Drawing.Point(74, 291);
            this.lblMEssage.Name = "lblMEssage";
            this.lblMEssage.Size = new System.Drawing.Size(546, 22);
            this.lblMEssage.TabIndex = 0;
            this.lblMEssage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRoomType
            // 
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(220, 76);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(336, 24);
            this.cboRoomType.TabIndex = 11;
            // 
            // lblCtype
            // 
            this.lblCtype.BackColor = System.Drawing.Color.Transparent;
            this.lblCtype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCtype.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCtype.Location = new System.Drawing.Point(31, 76);
            this.lblCtype.Name = "lblCtype";
            this.lblCtype.Size = new System.Drawing.Size(166, 22);
            this.lblCtype.TabIndex = 12;
            this.lblCtype.Text = "Room Type :";
            this.lblCtype.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCtype.Click += new System.EventHandler(this.lblCtype_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(37, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rate Per Person:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPerPersonRate
            // 
            this.txtPerPersonRate.Location = new System.Drawing.Point(220, 131);
            this.txtPerPersonRate.Name = "txtPerPersonRate";
            this.txtPerPersonRate.Size = new System.Drawing.Size(160, 23);
            this.txtPerPersonRate.TabIndex = 1;
            this.txtPerPersonRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPerPersonRate.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.Integer;
            this.txtPerPersonRate.Value = "";
            // 
            // Room_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 376);
            this.Controls.Add(this.cboRoomType);
            this.Controls.Add(this.lblCtype);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtfacilities);
            this.Controls.Add(this.chkDormitory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtIsDormitory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPerPersonRate);
            this.Controls.Add(this.txtPerRoomRate);
            this.Controls.Add(this.txtmaxnos);
            this.Controls.Add(this.lblfacilities);
            this.Controls.Add(this.lblmaxnos);
            this.Controls.Add(this.txtremarks);
            this.Controls.Add(this.lblremarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMEssage);
            this.Controls.Add(this.lblRate);
            this.Name = "Room_Ent";
            this.Text = "Room Entry";
            this.Load += new System.EventHandler(this.Room_Ent_Load);
            this.Controls.SetChildIndex(this.lblRate, 0);
            this.Controls.SetChildIndex(this.lblMEssage, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblremarks, 0);
            this.Controls.SetChildIndex(this.txtremarks, 0);
            this.Controls.SetChildIndex(this.lblmaxnos, 0);
            this.Controls.SetChildIndex(this.lblfacilities, 0);
            this.Controls.SetChildIndex(this.txtmaxnos, 0);
            this.Controls.SetChildIndex(this.txtPerRoomRate, 0);
            this.Controls.SetChildIndex(this.txtPerPersonRate, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.txtIsDormitory, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.chkDormitory, 0);
            this.Controls.SetChildIndex(this.txtfacilities, 0);
            this.Controls.SetChildIndex(this.txtid, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.lblCtype, 0);
            this.Controls.SetChildIndex(this.cboRoomType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

}//<Control>

 private Bsoft.Controls.VtextBox txtid; 
 private Bsoft.Controls.VtextBox txtName; 
 private Bsoft.Controls.VtextBox txtIsDormitory; 
 private Bsoft.Controls.VtextBox txtPerRoomRate; 
 private Bsoft.Controls.VtextBox txtfacilities; 
 private Bsoft.Controls.VtextBox txtmaxnos;
 private Bsoft.Controls.VtextBox txtremarks;
 private System.Windows.Forms.Label lblName; 
 private System.Windows.Forms.Label  lblRate; 
 private System.Windows.Forms.Label  lblfacilities; 
 private System.Windows.Forms.Label  lblmaxnos; 
 private System.Windows.Forms.Label  lblremarks; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.CheckBox chkDormitory;
        private System.Windows.Forms.Label lblMEssage;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Label lblCtype;
        private System.Windows.Forms.Label label1;
        private Bsoft.Controls.VtextBox txtPerPersonRate;
    }
}
