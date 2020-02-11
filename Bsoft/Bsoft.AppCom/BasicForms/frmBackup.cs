using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Data;
using Bsoft.Common;
using UEMS.BLL;
using Bsoft.AppCom;
using Bsoft.Forms;
namespace UEMS.Forms
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmBackup : Friuts.EntryFormBase
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Backup Files(*.bak,*.trn)|*.bak";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                txtFolderPath.Text = FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string dbname = GlobalValues.DbPath;
                if (txtFolderPath.Text != "")
                {
                    switch (ConversionSql.dbKind)
                    {

                        case databaseKind.SQLite:
                            System.IO.File.Copy(dbname, txtFolderPath.Text.Trim());
                            break;

                        case databaseKind.SQLServer:

                            string sql = "BACKUP DATABASE " + dbname + " TO DISK = '" + txtFolderPath.Text.Trim() + "'";
                            int rslt = GlobalResources.SelectDBConnection.ExecuteNonQuery(sql.ToString());
                            break;

                    }



                    if (System.IO.File.Exists(txtFolderPath.Text))
                    {
                        MessageBox.Show("Backup done successfully ");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Couldnot take Backup Please choose a different path. ");
                    }
                    txtFolderPath.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static void BackupSQLITE(string dbname, string folderLocation)
        {
            if (!System .IO .Directory .Exists (folderLocation ))
            {
                MessageBoxMy.Show("The Backup Folder  \n{0}\nDoesnot exist ,Please create it First.".With (folderLocation ));
                return;
            }
            string fullpath = System.IO.Path.GetFullPath(dbname);
            string filename = System.IO.Path.GetFileName(fullpath);
            int counter = 1;
            string finalFileName = DateTime.Now.Date.ToString("yyyy_MMM_dd_") + filename;
            finalFileName =  folderLocation + "/"+ finalFileName;
            string tempFileName =  finalFileName;
            while (System.IO.File.Exists(finalFileName))
            {
                finalFileName = tempFileName + "_"+counter.ToString();
                counter++;
            }

            System.IO.File.Copy(dbname, finalFileName);

            MessageBoxMy.Show("The data is successfully backed up at following location\n{0}".With (finalFileName ));
        }

    }
}
