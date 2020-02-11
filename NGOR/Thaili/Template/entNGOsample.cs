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
    public partial class entNGOsample : Friuts.EntryFormBase
    {
        public entNGOsample()
        {
            InitializeComponent();
        }

        public entNGOsample(string TableName_)
        {
            TableName = TableName_;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }
        entAddress ad = new entAddress();
        private void entNGO_Load(object sender, EventArgs e)
        {
            //<Entry>
            TableName = "NGO";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("Guid", ColumnTypes.String, txtGuid);
            ColumnList.AddNewEditColumn("Name", ColumnTypes.String, txtName);
            ColumnList.AddNewEditColumn("EnglishName", ColumnTypes.String, txtEnglishName);
            ColumnList.AddNewEditColumn("Address", ColumnTypes.String, txtAddress);
            ColumnList.AddNewEditColumn("Date", ColumnTypes.String, txtDate);
            ColumnList.AddNewEditColumn("WorkingArea", ColumnTypes.String, txtWorkingArea);
            ColumnList.AddNewEditColumn("Acronym", ColumnTypes.String, txtAcronym);
            ColumnList.AddNewEditColumn("Phone", ColumnTypes.String, txtPhone);
            ColumnList.AddNewEditColumn("Fax", ColumnTypes.String, txtFax);
            ColumnList.AddNewEditColumn("Email", ColumnTypes.String, txtEmail);
            ColumnList.AddNewEditColumn("WebSite", ColumnTypes.String, txtWebSite);
            ColumnList.AddNewEditColumn("MobileNo", ColumnTypes.String, txtMobileNo);
            ColumnList.AddNewEditColumn("President", ColumnTypes.Number, txtPresident);
            ColumnList.AddNewEditColumn("ContactPerson", ColumnTypes.Number, txtContactPerson);
            ColumnList.AddNewEditColumn("EstablishedDate", ColumnTypes.String, txtEstablishedDate);
                        ColumnList.AddNewEditColumn("LastAgmDate", ColumnTypes.String, txtLastAgmDate);
            ColumnList.AddNewEditColumn("Parikalpana", ColumnTypes.String, txtParikalpana);
            ColumnList.AddNewEditColumn("Dhyaye", ColumnTypes.String, txtDhyaye);
            ColumnList.AddNewEditColumn("Lakshya", ColumnTypes.String, txtLakshya);
            ColumnList.AddNewEditColumn("Udeshya", ColumnTypes.String, txtUdeshya);
            //lstObjective o = new lstObjective();
            //o.grid.Parent = kryptonPanel1;
            //o.toolStrip1.Parent  = kryptonPanel1;
            //o.Show();

          
            ad.flwLayout .Parent   = kryptonPanel2;
            ad.Show();
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            // kryptonDataGridView1.Rows.RemoveAt (kryptonDataGridView1.SelectedCells [0].RowIndex );
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            ad.Save();
        }
    }
}
