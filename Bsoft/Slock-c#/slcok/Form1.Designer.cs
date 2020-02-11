namespace slcok
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtRegistrationKey = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtIdKey = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnGenKey = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKeyText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(223, 153);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(86, 34);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtRegistrationKey
            // 
            this.txtRegistrationKey.Location = new System.Drawing.Point(113, 127);
            this.txtRegistrationKey.Name = "txtRegistrationKey";
            this.txtRegistrationKey.Size = new System.Drawing.Size(275, 20);
            this.txtRegistrationKey.TabIndex = 3;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(113, 28);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(275, 20);
            this.txtCompanyName.TabIndex = 1;
            this.txtCompanyName.Text = "mycompany";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 134);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(84, 13);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Registration Key";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(82, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Company Name";
            // 
            // txtIdKey
            // 
            this.txtIdKey.Location = new System.Drawing.Point(113, 54);
            this.txtIdKey.Name = "txtIdKey";
            this.txtIdKey.Size = new System.Drawing.Size(275, 20);
            this.txtIdKey.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 57);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(37, 13);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Id Key";
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(113, 6);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(275, 20);
            this.txtAppName.TabIndex = 0;
            this.txtAppName.Text = "test";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(90, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Application Name";
            // 
            // btnGenKey
            // 
            this.btnGenKey.Location = new System.Drawing.Point(39, 153);
            this.btnGenKey.Name = "btnGenKey";
            this.btnGenKey.Size = new System.Drawing.Size(86, 34);
            this.btnGenKey.TabIndex = 4;
            this.btnGenKey.Text = "GenerateAdv";
            this.btnGenKey.UseVisualStyleBackColor = true;
            this.btnGenKey.Click += new System.EventHandler(this.btnGenKey_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(108, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Key Text";
            // 
            // txtKeyText
            // 
            this.txtKeyText.Location = new System.Drawing.Point(113, 101);
            this.txtKeyText.Name = "txtKeyText";
            this.txtKeyText.Size = new System.Drawing.Size(275, 20);
            this.txtKeyText.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "v";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::slcok.Properties.Resources.green_tick;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(411, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(131, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Generate Full";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtRegistrationKey);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtKeyText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdKey);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGenKey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Set";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCheck;
        internal System.Windows.Forms.TextBox txtRegistrationKey;
        internal System.Windows.Forms.TextBox txtCompanyName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtIdKey;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtAppName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnGenKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtKeyText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button button3;
    }
}

