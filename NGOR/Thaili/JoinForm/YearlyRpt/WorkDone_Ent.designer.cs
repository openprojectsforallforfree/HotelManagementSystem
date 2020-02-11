namespace UEMS
{
    partial class WorkDone_Ent
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
            CrudeFx.NepaliDate.NepaliDate nepaliDate1 = new CrudeFx.NepaliDate.NepaliDate();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkDone_Ent));
            this.btnCancel = new bsoftcontrols.fsButton();
            this.btnOk = new bsoftcontrols.fsButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnFind = new bsoftcontrols.fsButton();
            this.txtfk_OBJECTIVE = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtfk_YearlyReport = new System.Windows.Forms.TextBox();
            this.txtfk_Address = new System.Windows.Forms.TextBox();
            this.lblfk_Address = new System.Windows.Forms.Label();
            this.pnlTaskDate = new System.Windows.Forms.Panel();
            this.lblTaskDate = new System.Windows.Forms.Label();
            this.dtTaskDate = new CrudeFx.NepaliDate.NepaliDatePicker();
            this.grpTasks = new System.Windows.Forms.GroupBox();
            this.pnlRemarks = new System.Windows.Forms.Panel();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.pnlRFU = new System.Windows.Forms.Panel();
            this.txtRFU = new System.Windows.Forms.TextBox();
            this.lblRFU = new System.Windows.Forms.Label();
            this.grpfk_Address = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWorkDoneTitle = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.pnlTaskDate.SuspendLayout();
            this.pnlRemarks.SuspendLayout();
            this.pnlRFU.SuspendLayout();
            this.grpfk_Address.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(841, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(445, 563);
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
            this.btnOk.Location = new System.Drawing.Point(351, 563);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(526, 12);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 23);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.AutoSize = true;
            this.pnlTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.Controls.Add(this.btnFind);
            this.pnlTitle.Controls.Add(this.txtfk_OBJECTIVE);
            this.pnlTitle.Controls.Add(this.lblWorkDoneTitle);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(321, 63);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(1);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(504, 126);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.Text = "सम्पन्न कार्यक्रमहरु";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFind.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFind.Location = new System.Drawing.Point(249, 82);
            this.btnFind.Margin = new System.Windows.Forms.Padding(0);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(122, 29);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "खोजेर ल्याउने ";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtfk_OBJECTIVE
            // 
            this.txtfk_OBJECTIVE.Location = new System.Drawing.Point(154, 82);
            this.txtfk_OBJECTIVE.MaxLength = 150;
            this.txtfk_OBJECTIVE.Multiline = true;
            this.txtfk_OBJECTIVE.Name = "txtfk_OBJECTIVE";
            this.txtfk_OBJECTIVE.Size = new System.Drawing.Size(92, 25);
            this.txtfk_OBJECTIVE.TabIndex = 0;
            this.txtfk_OBJECTIVE.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(10, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "सम्पन्न कार्यक्रम :";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtfk_YearlyReport
            // 
            this.txtfk_YearlyReport.Location = new System.Drawing.Point(315, 12);
            this.txtfk_YearlyReport.MaxLength = 5;
            this.txtfk_YearlyReport.Name = "txtfk_YearlyReport";
            this.txtfk_YearlyReport.Size = new System.Drawing.Size(160, 23);
            this.txtfk_YearlyReport.TabIndex = 0;
            this.txtfk_YearlyReport.Visible = false;
            // 
            // txtfk_Address
            // 
            this.txtfk_Address.Location = new System.Drawing.Point(320, 10);
            this.txtfk_Address.MaxLength = 5;
            this.txtfk_Address.Name = "txtfk_Address";
            this.txtfk_Address.Size = new System.Drawing.Size(39, 23);
            this.txtfk_Address.TabIndex = 0;
            this.txtfk_Address.Visible = false;
            // 
            // lblfk_Address
            // 
            this.lblfk_Address.BackColor = System.Drawing.Color.Transparent;
            this.lblfk_Address.Location = new System.Drawing.Point(3, -2);
            this.lblfk_Address.Name = "lblfk_Address";
            this.lblfk_Address.Size = new System.Drawing.Size(88, 21);
            this.lblfk_Address.TabIndex = 0;
            this.lblfk_Address.Text = "कार्यस्थल:";
            this.lblfk_Address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTaskDate
            // 
            this.pnlTaskDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTaskDate.BackColor = System.Drawing.Color.Transparent;
            this.pnlTaskDate.Controls.Add(this.lblTaskDate);
            this.pnlTaskDate.Controls.Add(this.dtTaskDate);
            this.pnlTaskDate.Location = new System.Drawing.Point(23, 62);
            this.pnlTaskDate.Margin = new System.Windows.Forms.Padding(1);
            this.pnlTaskDate.Name = "pnlTaskDate";
            this.pnlTaskDate.Size = new System.Drawing.Size(290, 39);
            this.pnlTaskDate.TabIndex = 0;
            this.pnlTaskDate.Text = "कार्यक्रम संचालन मिति";
            // 
            // lblTaskDate
            // 
            this.lblTaskDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskDate.Location = new System.Drawing.Point(10, 1);
            this.lblTaskDate.Name = "lblTaskDate";
            this.lblTaskDate.Size = new System.Drawing.Size(160, 22);
            this.lblTaskDate.TabIndex = 0;
            this.lblTaskDate.Text = "कार्यक्रम संचालन मिति:";
            this.lblTaskDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtTaskDate
            // 
            this.dtTaskDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtTaskDate.Location = new System.Drawing.Point(172, 3);
            this.dtTaskDate.Name = "dtTaskDate";
            this.dtTaskDate.Size = new System.Drawing.Size(110, 24);
            this.dtTaskDate.TabIndex = 1;
            nepaliDate1.Day = 12;
            nepaliDate1.Month = 11;
            nepaliDate1.Year = 2065;
            this.dtTaskDate.Value = nepaliDate1;
            // 
            // grpTasks
            // 
            this.grpTasks.BackColor = System.Drawing.Color.Transparent;
            this.grpTasks.Location = new System.Drawing.Point(3, 3);
            this.grpTasks.Name = "grpTasks";
            this.grpTasks.Size = new System.Drawing.Size(836, 205);
            this.grpTasks.TabIndex = 0;
            this.grpTasks.TabStop = false;
            this.grpTasks.Text = "क्रियाकलापहरु";
            // 
            // pnlRemarks
            // 
            this.pnlRemarks.AutoSize = true;
            this.pnlRemarks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRemarks.BackColor = System.Drawing.Color.Transparent;
            this.pnlRemarks.Controls.Add(this.txtRemarks);
            this.pnlRemarks.Controls.Add(this.lblRemarks);
            this.pnlRemarks.Location = new System.Drawing.Point(27, 525);
            this.pnlRemarks.Margin = new System.Windows.Forms.Padding(1);
            this.pnlRemarks.Name = "pnlRemarks";
            this.pnlRemarks.Size = new System.Drawing.Size(575, 37);
            this.pnlRemarks.TabIndex = 0;
            this.pnlRemarks.Text = "कैफियत";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(172, 1);
            this.txtRemarks.MaxLength = 150;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(400, 33);
            this.txtRemarks.TabIndex = 0;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Location = new System.Drawing.Point(10, 1);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(160, 22);
            this.lblRemarks.TabIndex = 0;
            this.lblRemarks.Text = "कैफियत:";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlRFU
            // 
            this.pnlRFU.AutoSize = true;
            this.pnlRFU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRFU.BackColor = System.Drawing.Color.Transparent;
            this.pnlRFU.Controls.Add(this.txtRFU);
            this.pnlRFU.Controls.Add(this.lblRFU);
            this.pnlRFU.Location = new System.Drawing.Point(29, 16);
            this.pnlRFU.Margin = new System.Windows.Forms.Padding(1);
            this.pnlRFU.Name = "pnlRFU";
            this.pnlRFU.Size = new System.Drawing.Size(282, 26);
            this.pnlRFU.TabIndex = 0;
            this.pnlRFU.Text = "RFU";
            this.pnlRFU.Visible = false;
            // 
            // txtRFU
            // 
            this.txtRFU.Location = new System.Drawing.Point(172, 1);
            this.txtRFU.MaxLength = 150;
            this.txtRFU.Multiline = true;
            this.txtRFU.Name = "txtRFU";
            this.txtRFU.Size = new System.Drawing.Size(107, 22);
            this.txtRFU.TabIndex = 0;
            // 
            // lblRFU
            // 
            this.lblRFU.BackColor = System.Drawing.Color.Transparent;
            this.lblRFU.Location = new System.Drawing.Point(10, 1);
            this.lblRFU.Name = "lblRFU";
            this.lblRFU.Size = new System.Drawing.Size(160, 22);
            this.lblRFU.TabIndex = 0;
            this.lblRFU.Text = "RFU:";
            this.lblRFU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpfk_Address
            // 
            this.grpfk_Address.BackColor = System.Drawing.Color.Transparent;
            this.grpfk_Address.Controls.Add(this.lblfk_Address);
            this.grpfk_Address.Controls.Add(this.txtfk_Address);
            this.grpfk_Address.Location = new System.Drawing.Point(20, 120);
            this.grpfk_Address.Name = "grpfk_Address";
            this.grpfk_Address.Size = new System.Drawing.Size(361, 186);
            this.grpfk_Address.TabIndex = 10;
            this.grpfk_Address.Text = "स्थापना मिति ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.grpTasks);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 312);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(853, 211);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // lblWorkDoneTitle
            // 
            this.lblWorkDoneTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkDoneTitle.Location = new System.Drawing.Point(144, 2);
            this.lblWorkDoneTitle.Name = "lblWorkDoneTitle";
            this.lblWorkDoneTitle.Size = new System.Drawing.Size(357, 74);
            this.lblWorkDoneTitle.TabIndex = 0;
            this.lblWorkDoneTitle.Text = "--";
            // 
            // WorkDone_Ent
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 601);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.grpfk_Address);
            this.Controls.Add(this.txtfk_YearlyReport);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlRFU);
            this.Controls.Add(this.pnlTaskDate);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlRemarks);
            this.Name = "WorkDone_Ent";
            this.Text = "सम्पन्न कार्यक्रमहरु";
            this.Load += new System.EventHandler(this.WorkDone_Ent_Load);
            this.Shown += new System.EventHandler(this.WorkDone_Ent_Shown);
            this.Controls.SetChildIndex(this.pnlRemarks, 0);
            this.Controls.SetChildIndex(this.pnlTitle, 0);
            this.Controls.SetChildIndex(this.pnlTaskDate, 0);
            this.Controls.SetChildIndex(this.pnlRFU, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtfk_YearlyReport, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.grpfk_Address, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlTaskDate.ResumeLayout(false);
            this.pnlRemarks.ResumeLayout(false);
            this.pnlRemarks.PerformLayout();
            this.pnlRFU.ResumeLayout(false);
            this.pnlRFU.PerformLayout();
            this.grpfk_Address.ResumeLayout(false);
            this.grpfk_Address.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }//<Control> 
        private System.Windows.Forms.Panel pnlTitle;
 private System.Windows.Forms.Panel pnlTaskDate; 
 private System.Windows.Forms.Panel pnlRemarks; 
 private System.Windows.Forms.Panel pnlRFU; 

 private System.Windows.Forms.TextBox txtId; 
 private System.Windows.Forms.TextBox txtfk_OBJECTIVE; 
 private System.Windows.Forms.TextBox txtfk_YearlyReport;
 private System.Windows.Forms.TextBox txtfk_Address; 
 private System.Windows.Forms.GroupBox grpTasks; 
 private System.Windows.Forms.TextBox txtRemarks;
 private System.Windows.Forms.TextBox txtRFU;
 private System.Windows.Forms.Label lblTitle; 
 private System.Windows.Forms.Label  lblfk_Address; 
 private System.Windows.Forms.Label  lblTaskDate; 
 private System.Windows.Forms.Label  lblRemarks; 
 private System.Windows.Forms.Label  lblRFU; 
      



        #endregion
        //<declaration>
        private bsoftcontrols.fsButton btnCancel;
        private bsoftcontrols.fsButton btnOk;
        private CrudeFx.NepaliDate.NepaliDatePicker dtTaskDate;
        private System.Windows.Forms.Panel grpfk_Address;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private bsoftcontrols.fsButton btnFind;
        private System.Windows.Forms.Label lblWorkDoneTitle;
    }
}
