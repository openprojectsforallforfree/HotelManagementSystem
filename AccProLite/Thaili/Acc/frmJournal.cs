using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Data;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmJournal : Friuts.EntryFormBase
    {
        public frmJournal()
        {
            InitializeComponent();
        }

        public frmJournal(string TableName_)
        {
            TableName = TableName;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void frmJournal_Load(object sender, EventArgs e)
        {
            //<Entry>
            TableName = "Journal";
            //System.Data.SqlClient.SqlTransaction str = (System.Data.SqlClient.SqlTransaction)GlobalResources.SelectDBConnection.BeginTransaction();

            //Journal Naration
            StringBuilder sbJournalNaration = new StringBuilder();
            int num = 0;
            num = int.Parse(GlobalResources.SelectDBConnection.ExecuteScalar("SELECT MAX(NUMBER) FROM Journal_Naration WHERE JournalTypeId = " + cmbJournalTypeId.SelectedIndex.ToString()).ToString());// need to change to key 
            sbJournalNaration.AppendLine("INSERT INTO Journal_Naration ('JournalTypeId','DateTime','Narration','Number') VALUES (");
            sbJournalNaration.AppendLine(cmbJournalTypeId.SelectedIndex + "," + DateTime.Now + "," + txtNarration.Text + ++num);// need to change to key N NEED NEPDATE
            sbJournalNaration.AppendLine(")");
            GlobalResources.SelectDBConnection.ExecuteNonQuery(sbJournalNaration.ToString());
            //get the key
            sbJournalNaration.Remove(0, sbJournalNaration.Length);
            sbJournalNaration.AppendLine("SELECT max(id) from Journal_Naration");
            int jnid = 0;
            int.TryParse(GlobalResources.SelectDBConnection.ExecuteScalar(sbJournalNaration.ToString()).ToString (), out jnid);

            //grp = ((ComboItem)cboRightGroups.SelectedItem).Key.ToString();
             

            //Journal
            foreach (ctrlJournal ctrlJr in flwJournal.Controls)
            {
                StringBuilder sbJournal = new StringBuilder();
                sbJournal.AppendLine("insert into Journal  ('AccountId','DrCr','Amount','Journal_NarationId') values (");
                sbJournal.AppendFormat("'{0}','{1}','{2}','{3}','{4}'", ctrlJr.AccountId, ctrlJr.drcr, ctrlJr.Amount, jnid.ToString ());
                sbJournal.AppendLine(")");
                GlobalResources.SelectDBConnection.ExecuteNonQuery(sbJournalNaration.ToString());

            }


            //GlobalResources.SelectDBConnection.CommitTransaction(out str);
            //ComboBoxDataLoader.LoadData("Id", "Name", "AccountGroup", cmbAccountId, true);
            //ComboBoxDataLoader.LoadData("Id", "Title", "JournalType", cmbJournalTypeId, true);
            //UEMS.BLL.Loader.LoadDrCr(cmbDrCr ,false ,false );
            //cmbDrCr.SelectedIndex = 0;
            //ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            //ColumnList.AddNewEditColumn("AccountId", ColumnTypes.Number, cmbAccountId);
            //ColumnList.AddNewEditColumn("JournalTypeId", ColumnTypes.Number, cmbJournalTypeId);
            //ColumnList.AddNewEditColumn("DrCr", ColumnTypes.String , cmbDrCr );
            //ColumnList.AddNewEditColumn("Amount", ColumnTypes.Number, txtAmount);
            //ColumnList.AddNewEditColumn("DateTime", ColumnTypes.String, dateTimePicker1);
            //ColumnList.AddNewEditColumn("Narration", ColumnTypes.String, txtNarration);
        }

        private void lblJournalTypeId_Click(object sender, EventArgs e)
        {
        }
    }
}