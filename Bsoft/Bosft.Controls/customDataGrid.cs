using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;


namespace RestoSys
{
    public partial class customDataGrid : UserControl
    {
        public customDataGrid()
        {
            isDirty = false;
            InitializeComponent();
        }
        public delegate void cellUpdated(DataGridViewCellEventArgs e);
        public event cellUpdated cellupdated;
        string tableName = "";
        #region Properties
        string[] readOnlyCols_;
        string[] invisibleCols_;
        string[] numberCols_;

        private bool isNumberCol(string col)
        {
            try
            {
                for (int i = 0; i < numberCols_.Length; i++)
                {
                    if (numberCols_[i] == col)
                    {
                        return true;
                    }
                }
            }
            catch { }
            return false;
        }
        private bool isNumberCol(int col)
        {
            return isNumberCol(dgv.Columns[col].Name);
        }
        private bool isReadonlyCol(string col)
        {
            try
            {
                for (int i = 0; i < readOnlyCols_.Length; i++)
                {
                    if (readOnlyCols_[i] == col)
                    {
                        return true;
                    }
                }
            }
            catch { }
            return false;
        }
        private bool isReadonlyCol(int col)
        {
            return isReadonlyCol(dgv.Columns[col].Name);
        }
        private bool isInvisibleCol(string col)
        {
            try
            {
                for (int i = 0; i < invisibleCols_.Length; i++)
                {
                    if (invisibleCols_[i] == col)
                    {
                        return true;
                    }
                }
            }
            catch { }
            return false;
        }
        private bool isInvisibleCol(int col)
        {
            return isInvisibleCol(dgv.Columns[col].Name);
        }
    
        public void setReadOnlyColumns(params string[] readonlycols)
        {
            readOnlyCols_ = readonlycols;
        }

        public void setNumberColumns(params string[] numberCols)
        {
            try
            {
                numberCols_ = numberCols;
                //            create new style object
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                // set the alignment to the right (for numbers)
                style.Alignment = DataGridViewContentAlignment.MiddleRight;
                // add a wee bit of padding to the right side
                System.Windows.Forms.Padding p = new System.Windows.Forms.Padding();
                p.Right = 5;
                style.Padding = p;
                // set the monetary string format
                style.Format = "$#.00";
                // apply the sytle to the column
                for (int col = 0; col < numberCols_.Length; col++)
                {
                    dgv.Columns[numberCols_ [col]].DefaultCellStyle = style;
                }
            }
            catch { }
        }
        public void setinVisibleColumns(params string[] invisibleCols)
        {
            invisibleCols_ = invisibleCols;
            foreach (string str in invisibleCols)
            {
                dgv.Columns[str].Visible = false;
            }
        }
        #endregion

        #region Events
        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Two hour
            if (isReadonlyCol(this.dgv.CurrentCell.ColumnIndex))
            {
                //this.dataGridView2.Rows[2].Cells[2].Selected = true;
                this.dgv.CurrentCell.Selected = false;
                SendKeys.Send("{TAB}");
            }
            else
            {
                DataGridViewCellStyle cs = new DataGridViewCellStyle();
                cs.BackColor = System.Drawing.Color.LightBlue;
                this.dgv.CurrentCell.Style = cs;
            }
            //One hour
            //if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly)
            //{
            //    SendKeys.Send("{TAB}");
            //}
        }

        private void dgv_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.BackColor = System.Drawing.Color.White;
            this.dgv.CurrentCell.Style = cs;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //dgv.EndEdit();
            //if (e.ColumnIndex == 1)
            //{
            //    string a = e.FormattedValue.ToString();
            //    double val;
            //    if (double.TryParse(a, out val))
            //    {
            //        dgv.CurrentRow.Cells[1].ErrorText = "";
            //    }
            //    else
            //    {
            //        dgv.Rows[e.RowIndex].ErrorText = "error";
            //        e.Cancel = true;
            //    }
            //}
        }

        private float getStringLenght(string str)
        {
            Graphics graphics = this.CreateGraphics();
            SizeF textSize = graphics.MeasureString(str, this.Font);
            return textSize.Width;
        }

        private void dgv_Validating(object sender, CancelEventArgs e)
        {
            bool err = false;
            for (int col = 0; col < dgv.Columns.Count; col++)
            {
                for (int row = 0; row < dgv.Rows.Count; row++)
                {
                    if (isNumberCol(col))
                    {
                        string str = dgv.Rows[row].Cells[col].Value.ToString();
                        double val = 0;
                        if (double.TryParse(str, out val))
                        {
                        }
                        else
                        {
                            //   MessageBox.Show("nono " + row.ToString () +" " + col .ToString ());
                            dgv.Rows[row].Cells[col].Selected = true;
                            lblError.Visible = true;
                            lblError.Text = "Please enter Number in Highlighted Box";
                            err = true;
                        }
                    }
                    else
                    {

                    }
                }
            }
            if (!err)
                lblError.Visible = false;
        }

        private void customDataGrid_SizeChanged(object sender, EventArgs e)
        {
            lblError.Top = this.Height - lblError.Height;
            lblError.Left = 0;
            lblError.Width = Width;
        }

        private void customDataGrid_Load(object sender, EventArgs e)
        {
            lblError.Top = this.Height - lblError.Height;
            lblError.Left = 0;
            lblError.Width = Width;
            lblError.Visible = false;
            isDirty = true;
        }
        //private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        //{
        //    if (e.ColumnIndex == 0)
        //    {
        //        e.Cancel = true;
        //    }

        //} 
        #endregion

        #region Data related
        /// <summary>
        /// Datatable column's Caption property is used as the Column tilte
        /// Datatable column's name proerty is Column Name
        /// </summary>
        /// <param name="dt"></param>
        public void setDataTable(DataTable dt)
        {
            //Display
            //bool isDirty = false;
            dgv.Columns.Clear();
            tableName = dt.TableName;
            for (int col = 0; col < dt.Columns.Count; col++)
            {
                dgv.Columns.Add(dt.Columns[col].ColumnName, dt.Columns[col].Caption);
                dgv.Columns[col].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int row = 0; row < dt.Rows.Count; row++)
            {
                dgv.Rows.Add();
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    dgv.Rows[row].Cells[col].Value = dt.Rows[row][col].ToString();
                }
            }

            DataGridViewCellStyle dataGridRowStyle = new DataGridViewCellStyle();
            dgv.ColumnHeadersHeight = 35;
            dgv.RowHeadersWidth = 54;
            dgv.AllowUserToResizeRows = true;
            dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(224)))));
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.BackColor = System.Drawing.Color.LightGray;
            dgv.AlternatingRowsDefaultCellStyle = dataGridRowStyle;
            isDirty = false;
        }
        public void clear()
        {
            dgv.Columns.Clear();
        }
        /// <summary>
        /// To set the header numbering
        /// </summary>
        public void setHeaderRow()
        {
            int rowCnt = 0;
            dgv.RowHeadersVisible = true;
            foreach (DataGridViewRow dgvr in dgv.Rows)
            {
                try
                {
                    dgv.Rows[rowCnt].HeaderCell.Value = Convert.ToString(++rowCnt);
                }
                catch   { }
            }
            isDirty = false;
        }

        public DataTable getDataTable()
        {
            DataTable dt = new DataTable();
            for (int col = 0; col < dgv.Columns.Count; col++)
            {
                if (!isReadonlyCol(col))
                {
                    dt.Columns.Add(dgv.Columns[col].Name);
                }
            }
            int colCount = 0;
            for (int row = 0; row < dgv.Rows.Count; row++)
            {
                dt.Rows.Add();
                colCount = 0;
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    if (!isReadonlyCol(col))
                    {
                        dt.Rows[row][colCount++] = dgv.Rows[row].Cells[col].Value.ToString();
                    }
                }
            }
            return dt;
        }
        /// <summary>
        /// The Column Names should be the name of database field
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public string getInsertSql(int row)
        {
            //Insert
            StringBuilder sb = new StringBuilder();
            string columns = "";
            string values = "";
            for (int col = 0; col < dgv.Columns.Count; col++)
            {
                if (!isReadonlyCol(col))
                {
                    columns += dgv.Columns[col].Name.ToString() + ",";
                }
            }
            columns = columns.Remove(columns.Length - 1, 1);
            //for (int row = 0; row < dgv.Rows.Count; row++)
            //{
            sb.Append("Insert into " + tableName + " (" + columns + ") values (");
            for (int col = 0; col < dgv.Columns.Count; col++)
            {
                if (!isReadonlyCol(col))
                {
                    if (isNumberCol(col))
                    {
                        values += dgv.Rows[row].Cells[col].Value.ToString() + ",";
                    }
                    else
                    {
                        values += "'" + dgv.Rows[row].Cells[col].Value.ToString() + "',";
                    }
                }

            }
            values = values.Remove(values.Length - 1, 1);
            //}
            sb.Append(values + ")");
            return sb.ToString();
        }

        public string[] getInsertSql()
        {
            List<string> StringtoList = new List<string>();

            for (int row = 0; row < dgv.Rows.Count; row++)
            {
                StringtoList.Add(getInsertSql(row));
            }
            return StringtoList.ToArray();
        }

     /// <summary>
     /// Gets the update sql
     /// </summary>
     /// <param name="row"></param>
     /// <param name="idCol">id column for the where clause </param>
     /// <param name="columns">columns for updating</param>
     /// <returns></returns>
        private  string getUpdateSql(DataGridViewRow  row, string idCol, params string[] columns)
        {
            //Update
            StringBuilder sb = new StringBuilder();
            string values = "";
            sb.Append("update " + tableName + " set ");
            for (int col = 0; col < columns.Length ; col++)
            {
                if (!isReadonlyCol(columns[col]))
                {
                    if (isNumberCol(columns[col]))
                    {
                        values = Bsoft.Common.Conversion.ToDouble (row, columns[col]).ToString ();
                    }
                    else
                    {
                        values = "'" + Bsoft.Common.Conversion.ToString(row, columns[col]) + "'";
                    }
                    sb.Append(columns[col] + " = " + values + ",");
                }
              
            }
            sb.Remove(sb.Length-1, 1);

            sb.Append(" WHERE id = " + Bsoft.Common.Conversion.ToString(row, idCol));
            return sb.ToString();
        }
        /// <summary>
        /// Gets the update sql
        /// </summary>
        /// <param name="idCol">id column for the where clause </param>
        /// <param name="columns">columns for updating</param>
        /// <returns></returns>
        public string[] getUpdateSql( string idCol, params string[] columns)
        {
            List<string> stlst= new List<string>() ;
           // string[] st  ;
            foreach (DataGridViewRow  dgvr  in dgv.Rows )
            {
                stlst.Add( getUpdateSql(dgvr, idCol, columns));
            }
            return stlst.ToArray ();
        }
        #endregion
       public  bool isDirty = false;
       

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isDirty = true;
        }

        private void dgv_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            cellupdated(e);
        }
    }
}
