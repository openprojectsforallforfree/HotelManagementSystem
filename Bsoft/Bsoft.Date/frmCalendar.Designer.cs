namespace Bsoft.Date
{
    partial class frmCalendar
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
            this.components = new System.ComponentModel.Container();
            this.TimerVisibility = new System.Windows.Forms.Timer(this.components);
            this.calendar1 = new Bsoft.Date.Calendar();
            this.SuspendLayout();
            // 
            // TimerVisibility
            // 
            this.TimerVisibility.Enabled = true;
            this.TimerVisibility.Interval = 10;
            this.TimerVisibility.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // calendar1
            // 
            this.calendar1.autoSizeFont = false;
            this.calendar1.BackColor = System.Drawing.Color.White;
            this.calendar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calendar1.calBackColor = System.Drawing.Color.Transparent;
            this.calendar1.calForeColor = System.Drawing.Color.Black;
            this.calendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar1.EnglishFontHeight = 10F;
            this.calendar1.EnglishForeColor = System.Drawing.Color.CornflowerBlue;
            this.calendar1.ForeColor = System.Drawing.Color.DarkBlue;
            this.calendar1.HoverColor = System.Drawing.Color.LightGray;
            this.calendar1.Location = new System.Drawing.Point(0, 0);
            this.calendar1.month = ((short)(12));
            this.calendar1.Name = "calendar1";
            this.calendar1.NepaliFontHeight = 14F;
            this.calendar1.NepaliForeColor = System.Drawing.Color.DarkBlue;
            this.calendar1.NormalBackColor = System.Drawing.Color.Transparent;
            this.calendar1.SelectedColor = System.Drawing.Color.Red;
            this.calendar1.ShadowBackColor = System.Drawing.Color.Transparent;
            this.calendar1.showBorder = true;
            this.calendar1.showEnglish = true;
            this.calendar1.showShadow = false;
            this.calendar1.showToolTip = false;
            this.calendar1.Size = new System.Drawing.Size(298, 247);
            this.calendar1.TabIndex = 0;
            this.calendar1.TodayColor = System.Drawing.Color.Gold;
            this.calendar1.weekBackColor = System.Drawing.Color.Beige;
            this.calendar1.weekNameFormat = Bsoft.Date.WeekNameFormat.Short;
            this.calendar1.year = ((short)(2066));
            this.calendar1.Alarms += new Bsoft.Date.Calendar.DateEventHandler(this.calendar1_Alarms);
            // 
            // frmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(298, 247);
            this.Controls.Add(this.calendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCalendar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCalendar_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Calendar calendar1;
        private System.Windows.Forms.Timer TimerVisibility;
    }
}