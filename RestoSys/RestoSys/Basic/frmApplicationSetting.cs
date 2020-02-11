using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Common;
using Bsoft.Forms;

namespace RestoSys.RestaurantBilling
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmApplicationSetting : EntryFormBase
    {
        public frmApplicationSetting()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            ApplicationSetting.PrintBilll = chkPrintBill.Checked;
            ApplicationSetting.VatPercent = txtVat.Text.ToInt();
            ApplicationSetting.ServiceChargePercent = txtService.Text.ToInt();
            if (!System.IO.Directory.Exists(txtBackupFolder.Text))
            {
                MessageBoxMy.Show("The backup folder does not exits ,Please select an existing folder.");
                return;
            }
            else
            {
                ApplicationSetting.BackUpFolder = txtBackupFolder.Text;
            }

            Close();
        }

        private void frmApplicationSetting_Load(object sender, EventArgs e)
        {
            chkPrintBill.Checked = ApplicationSetting.PrintBilll;
            txtVat.Text = ApplicationSetting.VatPercent.ToString ();
            txtService.Text = ApplicationSetting.ServiceChargePercent.ToString();
            txtBackupFolder.Text = ApplicationSetting.BackUpFolder;

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            if (System .IO .Directory .Exists ( txtBackupFolder.Text ) )
            {
                folderBackup.SelectedPath = txtBackupFolder.Text;
            }
            if (folderBackup.ShowDialog() == DialogResult.OK)
            {
                string FileName = folderBackup.SelectedPath ;
                txtBackupFolder.Text = FileName;
            }
        }


    }
}
