namespace UEMS 
{
    partial class NGO_Member_Lst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NGO_Member_Lst));
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDifferentlyAbled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSocialWorkExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new bsoftcontrols.fsButton();
            this.btnRemove = new bsoftcontrols.fsButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(780, 2);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colGender,
            this.colPosition,
            this.colDifferentlyAbled,
            this.colSpecialization,
            this.colEducation,
            this.colSocialWorkExp,
            this.colAddress,
            this.colPhone,
            this.colEmail});
            this.grid.Location = new System.Drawing.Point(4, 52);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(800, 423);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 6;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colName.HeaderText = "नाम";
            this.colName.Name = "colName";
            this.colName.Width = 60;
            // 
            // colGender
            // 
            this.colGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colGender.HeaderText = "लिंग";
            this.colGender.Name = "colGender";
            this.colGender.Visible = false;
            // 
            // colPosition
            // 
            this.colPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPosition.HeaderText = "पद";
            this.colPosition.Name = "colPosition";
            this.colPosition.Width = 53;
            // 
            // colDifferentlyAbled
            // 
            this.colDifferentlyAbled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDifferentlyAbled.HeaderText = "फरक क्षमता भएको";
            this.colDifferentlyAbled.Name = "colDifferentlyAbled";
            this.colDifferentlyAbled.Width = 147;
            // 
            // colSpecialization
            // 
            this.colSpecialization.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSpecialization.HeaderText = "बिषयगत क्षेत्र";
            this.colSpecialization.Name = "colSpecialization";
            this.colSpecialization.Width = 111;
            // 
            // colEducation
            // 
            this.colEducation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEducation.HeaderText = "शिक्षा ";
            this.colEducation.Name = "colEducation";
            this.colEducation.Width = 73;
            // 
            // colSocialWorkExp
            // 
            this.colSocialWorkExp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSocialWorkExp.HeaderText = "SocialWorkExp";
            this.colSocialWorkExp.Name = "colSocialWorkExp";
            this.colSocialWorkExp.Width = 135;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAddress.HeaderText = "ठेगाना";
            this.colAddress.Name = "colAddress";
            this.colAddress.Width = 73;
            // 
            // colPhone
            // 
            this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPhone.HeaderText = "फोन";
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 61;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEmail.HeaderText = "इमेल";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 65;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Location = new System.Drawing.Point(9, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 29);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "खोजेर ल्याउनुहोस् ";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemove.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRemove.Location = new System.Drawing.Point(147, 9);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(98, 29);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "हताउनुहोश ";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // NGO_Member_Lst
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 527);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grid);
            this.Name = "NGO_Member_Lst";
            this.Text = " List";
            this.Load += new System.EventHandler(this.List_Load);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnRemove, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        } 



        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDifferentlyAbled;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSocialWorkExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        public System.Windows.Forms.DataGridView grid;
        private bsoftcontrols.fsButton btnSearch;
        private bsoftcontrols.fsButton btnRemove;
 
    }
}
