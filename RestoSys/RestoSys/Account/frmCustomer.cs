using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using UEMS;
namespace RestoSys.Forms
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmCustomer : Friuts.EntryFormBase
    {
        public frmCustomer()
        {
            InitializeComponent();
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Title", "Master_CustomerType", cboMaster_CustomerType, true);
            loader.LoadDataInComboBoxes();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

            TableName = "Master_Customer";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("Name", ColumnTypes.String, txtName);
            ColumnList.AddNewEditColumn("LastName", ColumnTypes.String, txtLastName);
            //  ColumnList.AddNewEditColumn("Userid", ColumnTypes.String, txtUserid);
            ColumnList.AddNewEditColumn("Email", ColumnTypes.String, txtEmail);
            ColumnList.AddNewEditColumn("IdNumber", ColumnTypes.String, txtIdNumber );
            ColumnList.AddNewEditColumn("Phone", ColumnTypes.String, txtPhone);
            ColumnList.AddNewEditColumn("Address", ColumnTypes.String, txtAddress);
            ColumnList.AddNewEditColumn("Remarks", ColumnTypes.String, txtRemarks);

            ColumnList.AddNewEditColumn("fk_Master_CustomerType", ColumnTypes.Number, cboMaster_CustomerType);

            FirstControl = txtName;
        }



        private void lblCtype_Click(object sender, EventArgs e)
        {
            UEMS.CustomerType_Lst frm = new CustomerType_Lst();
            frm.ShowDialog();
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Title", "Master_CustomerType", cboMaster_CustomerType, true);
            loader.LoadDataInComboBoxes();
        }
    }
}

