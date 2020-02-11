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
    public partial class frmUnitList : Friuts.ListingFormBase
    {
       // string _which;
        public frmUnitList()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
        }


        //public frmUnitList(string which)
        //{
        //    InitializeComponent();
        //    FormType = FormTypes.ListingForm;
        //    ListingDataGridView = grid;
        //  //  _which = which;
        //}

        private void frmUnitList_Load(object sender, EventArgs e)
        {

            //if (_which=="weight")
            //{ TableName = "Unit_Weight_Master";
            //Text = "Weight Unit";
            //}
            //else if (_which == "size")
            //{ 
            TableName = "Master_Unit";
            Text = "Size Unit";
            //}
            //else
            //{ return; }

            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("Name", ColumnTypes.String, "colName");
            DataTableColumns.Add("Symbol", ColumnTypes.String, "colSymbol");
            DataTableColumns.Add("Type", ColumnTypes.String, "colDescription");

        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm( );
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm( );
        }
        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new frmUnitEntry());
        }


        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new frmUnitEntry());
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
