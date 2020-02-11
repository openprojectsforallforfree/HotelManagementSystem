namespace test
{
    partial class Form1
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
            this.vtextBox2 = new Bsoft.Controls.VtextBox();
            this.vtextBox1 = new Bsoft.Controls.VtextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vtextBox2
            // 
            this.vtextBox2.Location = new System.Drawing.Point(189, 201);
            this.vtextBox2.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vtextBox2.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vtextBox2.Name = "vtextBox2";
            this.vtextBox2.Size = new System.Drawing.Size(200, 20);
            this.vtextBox2.TabIndex = 0;
            this.vtextBox2.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.SignedDecimal;
            this.vtextBox2.Value = "";
            // 
            // vtextBox1
            // 
            this.vtextBox1.Location = new System.Drawing.Point(189, 101);
            this.vtextBox1.MaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vtextBox1.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vtextBox1.Name = "vtextBox1";
            this.vtextBox1.Size = new System.Drawing.Size(200, 20);
            this.vtextBox1.TabIndex = 0;
            this.vtextBox1.ValidationType = Bsoft.Controls.VtextBox.ValidationTypeEnum.SignedDecimal;
            this.vtextBox1.Value = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vtextBox2);
            this.Controls.Add(this.vtextBox1);
            this.Name = "Form1";
            this.Text = "test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bsoft.Controls.VtextBox vtextBox1;
        private Bsoft.Controls.VtextBox vtextBox2;
        private System.Windows.Forms.Button button1;





    }
}

