using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
 
using System.Text;
using System.Windows.Forms;

namespace UEMS
{
    public partial class ctrlJournal : UserControl
    {
        public ctrlJournal()
        {
            InitializeComponent();
        }
        public string drcr
        {
            get
            {
                if (cmbDrCr.SelectedIndex == 1)
                {
                    return "d";
                }
                else
                {
                    return "c";
                }
            }
            set
            {
                if (value.ToString() == "d")
                {
                    cmbDrCr.SelectedIndex = 1;
                }
                else
                {
                    cmbDrCr.SelectedIndex = 2;
                }
            }
        }
        public int AccountId
        {
            get
            {
                return cmbAccountId.SelectedIndex;
            }
            set
            {
                if( cmbAccountId .Items .Count >0    )
                {
                    cmbAccountId.SelectedIndex = value;
                }
                
            }
        }
        public string Amount
        {
            get
            { return txtAmount.Text; }
            set
            { txtAmount.Text = value.ToString(); }
        }

        private void cmbDrCr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDrCr.SelectedIndex == 0)
            {
                txtAmount.Parent = pnlDebit;
                txtAmount.Visible = true;
                txtAmount.Dock = DockStyle.Top;
            }
            else if (cmbDrCr.SelectedIndex == 1)
            {
                txtAmount.Parent = pnlCredit;
                txtAmount.Visible = true;
                txtAmount.Dock = DockStyle.Top;
            }
            else
            {
                txtAmount.Visible = false;
                txtAmount.Text = "";
            }
        }
    }
}
