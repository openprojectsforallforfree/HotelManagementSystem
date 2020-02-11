using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
namespace RestoSys.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmProductGroupEntry : Friuts.EntryFormBase
    {
        public frmProductGroupEntry()
        {
            InitializeComponent();
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Dev_Item_Type", cboGroupType, true, ColumnTypes.String ,"");
            loader.LoadDataInComboBoxes();

            TableName = "Master_Product_Group";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.Add("Name", ColumnTypes.String, txtName, true, "Name", string.Empty);
            ColumnList.AddNewEditColumn("Description", ColumnTypes.String, txtDescription);
            ColumnList.AddNewEditColumn("code", ColumnTypes.String, txtCode );
            ColumnList.AddNewEditColumn("fk_ItemType", ColumnTypes.String   , cboGroupType );

         
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
            
            string a =InsertSQL;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProductGroupEntry_Load(object sender, EventArgs e)
        {
            this.FirstControl = txtName ;
            txtName.Select();
        }
    }
}
