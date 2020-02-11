namespace UEMS
{
    partial class frmJournal
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
            this.btnCancel = new  bsoftcontrols .fsButton();
            this.btnOk = new  bsoftcontrols .fsButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblJournalTypeId = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblNarration = new System.Windows.Forms.Label();
            this.cmbJournalTypeId = new System.Windows.Forms.ComboBox();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.ctrlJournal1 = new UEMS.ctrlJournal();
            this.flwJournal = new System.Windows.Forms.FlowLayoutPanel();
            this.flwJournal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(546, 374);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(439, 374);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Location = new System.Drawing.Point(511, 24);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(160, 22);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJournalTypeId
            // 
            this.lblJournalTypeId.BackColor = System.Drawing.Color.Transparent;
            this.lblJournalTypeId.Location = new System.Drawing.Point(27, 24);
            this.lblJournalTypeId.Name = "lblJournalTypeId";
            this.lblJournalTypeId.Size = new System.Drawing.Size(460, 22);
            this.lblJournalTypeId.TabIndex = 0;
            this.lblJournalTypeId.Text = "Particulars";
            this.lblJournalTypeId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJournalTypeId.Click += new System.EventHandler(this.lblJournalTypeId_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(102, -3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(44, 24);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblNarration
            // 
            this.lblNarration.BackColor = System.Drawing.Color.Transparent;
            this.lblNarration.Location = new System.Drawing.Point(27, 292);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(101, 22);
            this.lblNarration.TabIndex = 0;
            this.lblNarration.Text = "Narration";
            this.lblNarration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbJournalTypeId
            // 
            this.cmbJournalTypeId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbJournalTypeId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbJournalTypeId.FormattingEnabled = true;
            this.cmbJournalTypeId.Location = new System.Drawing.Point(46, -3);
            this.cmbJournalTypeId.Name = "cmbJournalTypeId";
            this.cmbJournalTypeId.Size = new System.Drawing.Size(50, 24);
            this.cmbJournalTypeId.TabIndex = 3;
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(146, 292);
            this.txtNarration.MaxLength = 150;
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(548, 53);
            this.txtNarration.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(6, -3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(24, 24);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            
            this.ctrlJournal1.Location = new System.Drawing.Point(3, 3);
            this.ctrlJournal1.Name = "ctrlJournal1";
            this.ctrlJournal1.Size = new System.Drawing.Size(884, 33);
            this.ctrlJournal1.TabIndex = 11;
            // 
            // flwJournal
            // 
            this.flwJournal.Controls.Add(this.ctrlJournal1);
            this.flwJournal.Location = new System.Drawing.Point(30, 65);
            this.flwJournal.Name = "flwJournal";
            this.flwJournal.Size = new System.Drawing.Size(871, 179);
            this.flwJournal.TabIndex = 12;
            // 
            // frmJournal
            // 
            this.ClientSize = new System.Drawing.Size(1033, 412);
            this.Controls.Add(this.flwJournal);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblJournalTypeId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbJournalTypeId);
            this.Controls.Add(this.txtNarration);
            this.Name = "frmJournal";
            this.ShowIcon = false;
           
            this.Load += new System.EventHandler(this.frmJournal_Load);
            this.flwJournal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

}//<Control>
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbJournalTypeId;
 private System.Windows.Forms.TextBox txtNarration; 
 private System.Windows.Forms.Label  lblJournalTypeId;
 private System.Windows.Forms.Label lblAmount; 
 private System.Windows.Forms.Label  lblNarration; 



        #endregion
        //<declaration>
        private bsoftcontrols .fsButton btnCancel;
        private bsoftcontrols .fsButton btnOk;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ctrlJournal ctrlJournal1;
        private System.Windows.Forms.FlowLayoutPanel flwJournal;
    }
}