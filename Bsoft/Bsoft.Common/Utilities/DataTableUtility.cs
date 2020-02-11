using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Bsoft.Common
{
    public class DataTableUtility
    {
        public static DataTable SwapRowAndColumn(DataTable dt)
        {
            DataTable dtnew = new DataTable();
            dtnew.Columns.Add("Name");
            dtnew.Columns.Add("Value");
            foreach (DataColumn dc in dt.Columns)
            {
                dtnew.Rows.Add(dc.ColumnName, dt.Rows[0][dc].ToString());
            }
                return dtnew;
        }

        public static void SetListingGrid(DataGridView dgv, DataTable dt)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            if (dgv .Columns .Count <1)
            {
                dgv.Columns.Add(  "Title" ,"Value");
            }
            //dgv.ColumnHeadersVisible = false;
            foreach (DataColumn dc in dt.Columns)
            {
                dgv.Rows.Add(dt.Rows[0][dc].ToString());
                    dgv.Rows[dgv.Rows.Count-1].HeaderCell.Value = dc.ColumnName;
            }
        }
    }
}
