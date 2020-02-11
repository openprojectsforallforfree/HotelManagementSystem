using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Bsoft.Reporting.xls;

namespace Bsoft.Reporting
{
    public class tools
    {
        /// <summary>
        /// <para> datatable ExtendedProperties </para>
        ///  <para>  For Table Widht</para>
        ///  <para>    dt.ExtendedProperties.Add("width", "3in");</para>
        ///  <para>column ExtendedProperties</para>
        ///  <para>  For Column width and Border</para>
        ///  <para>    dt.Columns["AMC"].ExtendedProperties.Add("width", "1in");</para>
        ///  <para>    dt.Columns["AMC"].ExtendedProperties.Add("boder", new border("1pt solid black"));</para>
        ///  <para>RowError Properties (miss use!)</para>
        ///  <para>For Row Border  </para>
        ///  <para>    dt.Rows.Add(new cell("Ad", 1, 2), new cell("Ad", 2)).RowError = "1pt solid black";</para>
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public table datatableToPdfTable(DataTable dt)
        {
            string width = "";
            table tbl = new table(); ;
            if (dt.ExtendedProperties.ContainsKey("width"))
            {
                width = dt.ExtendedProperties["width"].ToString();
                tbl.width = width;
            }

            tbl.tblayout = table_layout.fixxed;
            //add columns
            foreach (DataColumn dc in dt.Columns)
            {
                column c = new column();

                if (dc.ExtendedProperties.ContainsKey("width"))
                {
                    c.column_width = dc.ExtendedProperties["width"].ToString();
                }
                if (dc.ExtendedProperties.ContainsKey("boder"))
                {
                    c.border_ = (border)dc.ExtendedProperties["boder"];
                }

                tbl.Columns.add(c);
            }
            //Add rows
            foreach (DataRow dr in dt.Rows)
            {
                row pdfrow = new row(new border(getboder(dr.RowError)));

                foreach (DataColumn dc in dt.Columns)
                {
                    if (dr[dc].ToString().Trim() != "dontuse")
                        pdfrow.addcell(dr[dc].ToString());
                }
                if (isheader(dr.RowError))
                {
                    tbl.Header .Rows.add(pdfrow);
                }
                else
                {
                    tbl.Body.Rows.add(pdfrow);
                }
            }
            return tbl;
        }

        public bool isheader(string rowerr)
        { 
        if(rowerr .Contains ( "header"))
            return true ;
        else
            return false ;

        }
        public string  getboder(string rowerr)
        {
            rowerr = rowerr.Replace(":", "");
            rowerr = rowerr.Replace("header", "");
            return rowerr.Trim ();

        }

        public void setWidth(DataColumn dc, string width)
        {
            dc.ExtendedProperties.Add("width", width);
        }
        public void setBoder(DataRow dr, string bdr)
        {
            dr.RowError = dr.RowError + ":" + bdr;
        }
        public void setHeaderRow(DataRow dr )
        {
            dr.RowError = dr.RowError + ":" + "header";
        }
        public void setBoder(DataColumn dc, border bdr)
        {
            dc.ExtendedProperties.Add("boder", bdr);
        }
        public DataTable  MergeRows(DataTable dt, string value, int row, int col, int rowsCount)
        {
            dt.Rows[row][col] = new cell(value, 0, rowsCount);
            for (int i = row+1; i < row + rowsCount; i++)
            {
                dt.Rows[i][col] = "dontuse";
            }
            return dt;
        }
        public DataTable MergeCols(DataTable dt, string value, int row, int col, int colsCount)
        {
            dt.Rows[row][col] = new cell(value, colsCount);
            for (int i = col+1; i < col + colsCount; i++)
            {
                dt.Rows[row][i] = "dontuse";
            }
            return dt;
        }

    }
}
