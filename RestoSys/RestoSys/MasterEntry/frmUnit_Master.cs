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
    public partial class frmMaster_Unit : Friuts.EntryFormBase
    {
        public frmMaster_Unit()
        {
            InitializeComponent();
        }

        public frmMaster_Unit(string _tableName)
        {
            TableName = _tableName;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void frmMaster_Unit_Load(object sender, EventArgs e)
        {
            //<Entry>
            TableName = "Master_Unit";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.String, txtId, true, false);
            ColumnList.AddNewEditColumn("Unit", ColumnTypes.String, txtUnit);
            ColumnList.AddNewEditColumn("Symbol", ColumnTypes.String, txtSymbol);
            ColumnList.AddNewEditColumn("Master_UnitCategoryId", ColumnTypes.Number, cmbMaster_UnitCategoryId);
            ColumnList.AddNewEditColumn("Factor", ColumnTypes.String , txtFactor);
           

            ComboUtilities.LoadData("Id", "Title", "Master_UnitCategory", cmbMaster_UnitCategoryId, true,"");

            LoadData();

        }

        private void lblMaster_UnitCategoryId_MouseDown(object sender, MouseEventArgs e)
        {
            UEMS.Master_Lst frmUnitCategory = frmUnitCategory = new UEMS.Master_Lst();
            frmUnitCategory.TableName = "Master_UnitCategory";
            frmUnitCategory.Title = "Units Category";
            frmUnitCategory.ShowDialog();
            ComboUtilities .LoadData("Id", "Title", "Master_UnitCategory", cmbMaster_UnitCategoryId, true,"");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}