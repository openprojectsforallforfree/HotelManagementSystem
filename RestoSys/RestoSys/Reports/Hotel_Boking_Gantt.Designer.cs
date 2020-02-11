namespace RestoSys.Reports
{
    partial class Hotel_Boking_Gantt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel_Boking_Gantt));
            this.lblMessage = new System.Windows.Forms.Label();
            this.ganttChart1 = new Bsoft.Controls.GanttChart();
            this.dateFromTo21 = new Bsoft.Controls.DateFromTo2();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(1090, 2);
            this._closeButton.Size = new System.Drawing.Size(31, 32);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.Location = new System.Drawing.Point(315, 232);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(380, 26);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.Text = "No Rooms Booked in the selected days Range";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ganttChart1
            // 
            this.ganttChart1.AllowManualEditBar = false;
            this.ganttChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ganttChart1.BackColor = System.Drawing.Color.White;
            this.ganttChart1.DateFont = new System.Drawing.Font("Vijaya", 10F);
            this.ganttChart1.FromDate = new System.DateTime(((long)(0)));
            this.ganttChart1.Location = new System.Drawing.Point(13, 96);
            this.ganttChart1.Margin = new System.Windows.Forms.Padding(4);
            this.ganttChart1.Name = "ganttChart1";
            this.ganttChart1.RowFont = new System.Drawing.Font("Verdana", 10F);
            this.ganttChart1.Size = new System.Drawing.Size(1097, 557);
            this.ganttChart1.TabIndex = 0;
            this.ganttChart1.Text = "ganttChart1";
            this.ganttChart1.TimeFont = new System.Drawing.Font("Verdana", 8F);
            this.ganttChart1.ToDate = new System.DateTime(((long)(0)));
            this.ganttChart1.ToolTipText = ((System.Collections.Generic.List<string>)(resources.GetObject("ganttChart1.ToolTipText")));
            this.ganttChart1.ToolTipTextTitle = "";
            this.ganttChart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ganttChart1_MouseMove);
            // 
            // dateFromTo21
            // 
            this.dateFromTo21.BackColor = System.Drawing.Color.Transparent;
            this.dateFromTo21.Location = new System.Drawing.Point(507, 51);
            this.dateFromTo21.Margin = new System.Windows.Forms.Padding(4);
            this.dateFromTo21.Name = "dateFromTo21";
            this.dateFromTo21.Size = new System.Drawing.Size(486, 37);
            this.dateFromTo21.TabIndex = 17;
            // 
            // cboRoom
            // 
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(354, 57);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(129, 24);
            this.cboRoom.TabIndex = 19;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(277, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Room:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(43, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Room Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRoomType
            // 
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(145, 57);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(129, 24);
            this.cboRoomType.TabIndex = 19;
            this.cboRoomType.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // Hotel_Boking_Gantt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 666);
            this.Controls.Add(this.cboRoomType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.ganttChart1);
            this.Controls.Add(this.dateFromTo21);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hotel_Boking_Gantt";
            this.Text = "Hotel Boking Gantt Chart";
            this.Load += new System.EventHandler(this.Hotel_Boking_Gantt_Load);
            this.Controls.SetChildIndex(this.dateFromTo21, 0);
            this.Controls.SetChildIndex(this.ganttChart1, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cboRoom, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cboRoomType, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Bsoft.Controls.GanttChart ganttChart1;
        private System.Windows.Forms.Label lblMessage;
        private Bsoft.Controls.DateFromTo2 dateFromTo21;
        public System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cboRoomType;
    }
}