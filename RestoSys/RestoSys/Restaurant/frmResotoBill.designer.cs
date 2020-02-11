namespace RestoSys
{
    partial class frmResotoBill
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
            this.panelOrder = new System.Windows.Forms.Panel();
            this.TableView = new Bsoft.Controls.menuView();
            this.menuView = new Bsoft.Controls.menuView();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(1097, 2);
            this._closeButton.Size = new System.Drawing.Size(28, 27);
            // 
            // panelOrder
            // 
            this.panelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOrder.BackColor = System.Drawing.Color.Transparent;
            this.panelOrder.Location = new System.Drawing.Point(474, 38);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(623, 520);
            this.panelOrder.TabIndex = 2;
            // 
            // TableView
            // 
            this.TableView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TableView.BackColor = System.Drawing.Color.Transparent;
            this.TableView.Location = new System.Drawing.Point(16, 39);
            this.TableView.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TableView.Name = "TableView";
            this.TableView.Size = new System.Drawing.Size(151, 519);
            this.TableView.TabIndex = 0;
            // 
            // menuView
            // 
            this.menuView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.menuView.BackColor = System.Drawing.Color.Transparent;
            this.menuView.Location = new System.Drawing.Point(167, 39);
            this.menuView.Margin = new System.Windows.Forms.Padding(5);
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(288, 519);
            this.menuView.TabIndex = 1;
            // 
            // frmResotoBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 591);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.TableView);
            this.Controls.Add(this.menuView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmResotoBill";
            this.Text = "Restaurant Billing ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.menuView, 0);
            this.Controls.SetChildIndex(this._closeButton, 0);
            this.Controls.SetChildIndex(this.TableView, 0);
            this.Controls.SetChildIndex(this.panelOrder, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Bsoft.Controls.menuView menuView;
        private Bsoft.Controls.menuView TableView;
        private System.Windows.Forms.Panel panelOrder;



    }
}

