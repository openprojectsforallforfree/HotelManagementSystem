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
    public partial class Address_Ent : Friuts.EntryFormBase
    {
        public Address_Ent()
        {
            InitializeComponent();
            TableName = "Address";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("Tole", ColumnTypes.String, txtTole);
            ColumnList.AddNewEditColumn("LocalBody", ColumnTypes.String, txtLocalBody);
            ColumnList.AddNewEditColumn("District", ColumnTypes.String, txtDistrict);
            ColumnList.AddNewEditColumn("Zone", ColumnTypes.String, txtZone);
            ColumnList.AddNewEditColumn("Country", ColumnTypes.String, txtCountry);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Address_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Address.selectAddress.SelectionOfAddressFromTree(null, null, null, txtZone, txtDistrict, txtLocalBody, null, null, null);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Address.selectAddress.ClearAddress (null, null, null, txtZone, txtDistrict, txtLocalBody, null, null, null);
        }
    }
}
