using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Forms;
using Bsoft.Data;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmAccountGroupList : Friuts.ListingFormBase
    {
        public frmAccountGroupList()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            toolstrip = toolStrip1;

        }

        private void Listing_Load(object sender, EventArgs e)
        {

            //<Listing>
            TableName = "AccountGroup";
            DataTableColumns.Add("t1_Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("t1_Name", ColumnTypes.String, "colName");
            DataTableColumns.Add("t1_Description", ColumnTypes.String, "colDescription");
            DataTableColumns.Add("t1_BehavesLikeSubLedger", ColumnTypes.String, "colBehavesLikeSubLedger");
            DataTableColumns.Add("t1_DebitcreditBalanceforReporting", ColumnTypes.String, "colDebitcreditBalanceforReporting");
            DataTableColumns.Add("t1_UsedforCalculations", ColumnTypes.String, "colUsedforCalculations");
            DataTableColumns.Add("t1_Alias", ColumnTypes.String, "colAlias");
            //DataTableColumns.Add("t1_ParentId", ColumnTypes.Number, "colParentId");
            DataTableColumns.Add("t2_Name", ColumnTypes.String, "colParentId");

        }
        public override bool GenerateSelectSQL()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("  SELECT ");
            sb.Append("  t1.Id t1_Id, ");
            sb.Append("  t1.Name t1_Name, ");
            sb.Append("  t1.Description t1_Description, ");
            sb.Append("  t1.BehavesLikeSubLedger t1_BehavesLikeSubLedger, ");
            sb.Append("  t1.DebitcreditBalanceforReporting t1_DebitcreditBalanceforReporting, ");
            sb.Append("  t1.UsedforCalculations t1_UsedforCalculations, ");
            sb.Append("  t1.Alias t1_Alias, ");
            sb.Append("  t2.Name t2_Name, ");
            sb.Append("  t1.ParentId t1_ParentId ");
            sb.Append("  FROM AccountGroup t1 ");
            sb.Append("  left join AccountGroup t2 on t2.Id = t1.ParentId   ");
              
            if (_isRefreshData )
            {
                sb.AppendLine("  where t1_Id = " + PrimaryKeyValue );
            
            }

            sb.Append("ORDER BY t1.ParentId");
            SelectSQL = sb.ToString();
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
            //LoadData();
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
            //LoadData();//needed when customized code
        }
        public override bool OpenEditForm()
        {
       
            return base.OpenEditForm(new frmAccountGroupEntry());
            
        }

        public override bool OpenNewForm()
        {
            
            return base.OpenNewForm(new frmAccountGroupEntry());
           
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            
            Delete();
        }

        public override string GetWhereClauseForDelete()
        {
            return "where id = " + TableColumn.GetDBValue(ColumnTypes .Number , PrimaryKeyValue);
        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            LoadData();
            //Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, grid);
        }

        private void tlbTreeView_Click(object sender, EventArgs e)
        {
            frmTreeView tvw = new frmTreeView();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("SELECT * from {0} order by {1}", TableName, "ParentId");
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sb.ToString());
          // loadtree(parentCol, childCol, parentdisplayCol, childdisplayCol, dt);

            tvw.loadtree( "ParentId", "Id", "Name", "Name",dt );
            tvw.ShowDialog();
        }


        /// <summary>
        /// Concerts only 1 table
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="parentCol"></param>
        /// <param name="childCol"></param>
        /// <param name="parentdisplayCol"></param>
        /// <param name="childdisplayCol"></param>
        public void loadtree(string tableName, string parentCol, string childCol, string parentdisplayCol, string childdisplayCol, DataTable dt)
        {
            

        }
        
       
    }
}