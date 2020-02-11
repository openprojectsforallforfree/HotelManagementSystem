using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmAccountGroupEntry : Friuts.EntryFormBase
    {
        public frmAccountGroupEntry()
        {
            InitializeComponent();

        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void frmAccountGroupEntry_Load(object sender, EventArgs e)
        {
            //<Entry>
            // ComboBoxDataLoader.LoadData("Id", "Name", "", "AccountGroup", cmbParentId, "Id != " +txtId.Text , this);
            TableName = "AccountGroup";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("Name", ColumnTypes.String, txtName);
            ColumnList.AddNewEditColumn("Description", ColumnTypes.String, txtDescription);
            ColumnList.AddNewEditColumn("BehavesLikeSubLedger", ColumnTypes.String, chkBehavesLikeSubLedger);
            ColumnList.AddNewEditColumn("DebitcreditBalanceforReporting", ColumnTypes.String, chkDebitcreditBalanceforReporting);
            ColumnList.AddNewEditColumn("UsedforCalculations", ColumnTypes.String, chkUsedforCalculations);
            ColumnList.AddNewEditColumn("Alias", ColumnTypes.String, txtAlias);
            ColumnList.AddNewEditColumn("ParentId", ColumnTypes.Number, cmbParentId);


            if (FormType == FormTypes.EntryForm)
            {
                ComboUtilities .LoadData("Id", "Name", "AccountGroup", cmbParentId, true, string.Empty); 
            }
            else
            {
                LoadData();
                if (txtName.Text == "Root")
                {
                    groupBox1.Enabled = false;
                    btnOk.Enabled = false;
                }
                else
                {
                    ComboUtilities.LoadData("Id", "Name", "AccountGroup", cmbParentId, true, ColumnTypes.Number, "Id != " + txtId.Text);
                }
            }
            //ComboBoxDataLoader.LoadData("Id", "Name", "", "AccountGroup", cmbParentId, "Id != " + txtId.Text, this);



        }
    }
}