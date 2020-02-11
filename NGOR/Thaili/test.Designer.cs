namespace UEMS
{
    partial class test
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnOk = new bsoftcontrols.fsButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.roundRectButton1 = new Bsoft.Controls.RoundRectButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(550, 2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.ButtonTheme = bsoftcontrols.fsButton.Themes.Office2003;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Location = new System.Drawing.Point(232, 115);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 23);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 23);
            this.textBox2.TabIndex = 13;
            // 
            // roundRectButton1
            // 
            this.roundRectButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundRectButton1.ButtonDisabledImage = null;
            this.roundRectButton1.ButtonFocusImage = null;
            this.roundRectButton1.ButtonHoverImage = null;
            this.roundRectButton1.ButtonImage = null;
            this.roundRectButton1.ButtonPressedImage = null;
            this.roundRectButton1.DashLineColor = System.Drawing.Color.Empty;
            this.roundRectButton1.DashLineWidth = 0;
            this.roundRectButton1.DisableForeColor = System.Drawing.Color.Empty;
            this.roundRectButton1.FlatAppearance.BorderSize = 0;
            this.roundRectButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundRectButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundRectButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundRectButton1.HeightEllipse = 0;
            this.roundRectButton1.Location = new System.Drawing.Point(358, 52);
            this.roundRectButton1.Name = "roundRectButton1";
            this.roundRectButton1.Size = new System.Drawing.Size(165, 81);
            this.roundRectButton1.TabIndex = 14;
            this.roundRectButton1.Text = "roundRectButton1";
            this.roundRectButton1.UseVisualStyleBackColor = true;
            this.roundRectButton1.WidthEllipse = 0;
            this.roundRectButton1.Click += new System.EventHandler(this.roundRectButton1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 125);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 409);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.roundRectButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.button1);
            this.Name = "test";
            this.Text = "test";
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.roundRectButton1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private bsoftcontrols.fsButton btnOk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Bsoft.Controls.RoundRectButton roundRectButton1;
        private System.Windows.Forms.Button button2;
    }
}