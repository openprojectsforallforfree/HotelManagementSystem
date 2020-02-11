using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.ComponentModel;
using System.Collections;
using System.Windows.Forms;

namespace UEMS.Reports
{


    public class ExcelReport
    {
        #region Member Variables
        private string Heading1;
        private DataGridView Grid;
        private int ReportType;

        private int StartCol = 0;
        private int StartRow = 0;
        #endregion

        #region Constructors
        /// <summary>
        /// Report Type:Excel=1,HTML=2,Word=3 and All=4
        /// </summary>
        /// <param name="_heading1"></param>
        /// <param name="_grid"></param>
        public ExcelReport(string _heading1, int _reportType, DataGridView _grid)
        {
            this.Heading1 = _heading1;
            this.ReportType = _reportType;
            this.Grid = _grid;
            WriteReport();

        }
        #endregion

        #region Main Function For Exporting
        private void WriteReport()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (ReportType == 1)
            {
                saveFileDialog1.Filter = "Excel Worksheet files|*.xls";
            }
            else if (ReportType == 2)
            {
                saveFileDialog1.Filter = "HTML Files|*.htm";
            }
            else if (ReportType == 3)
            {
                saveFileDialog1.Filter = "Word Files|*.doc";
            }
            else if (ReportType == 4)
            {
                saveFileDialog1.Filter = "Excel Worksheet files|*.xls|HTML Files|*.html|Word Files|*.doc|All Files|*.*";
            }

            //Exporting To Different Formates using Stream
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(saveFileDialog1.FileName);
                StreamWriter sw = fi.CreateText();
                //sw.WriteLine("<html><head><title>&nbsp;" + Heading1 + "&nbsp;</title>");
                //sw.WriteLine("<style>th, td {border-bottom:solid 1px black;border-right:solid 1px black;} table {font:normal 12px Shangrila Numeric}</style>");

                //Wites the heading of the report in the top
              
                sw.WriteLine("<table bgcolor='#FFFFFF' border=1 width='100%'>");
                sw.Write("<tr>");
                foreach (DataGridViewColumn col in Grid.Columns)
                {
                    if (Grid.Columns[col.Index].Visible == true)
                    {
                        string FontName;
                        if (Grid.ColumnHeadersDefaultCellStyle.Font.Name.ToString() != null)
                        {
                            FontName = Grid.ColumnHeadersDefaultCellStyle.Font.Name.ToString();
                        }
                        else
                        {
                            FontName = col.DefaultCellStyle.Font.Name.ToString();
                        }
                        //sw.Write("<th bgcolor='#ECE9D8'><FONT FACE='"+FontName+"'>" + col.HeaderText + "</font></th>");
                        sw.Write("<th bgcolor='#ECE9D8'><FONT FACE='" + FontName + "'>" + ReplaceSpclChars(col.HeaderText) + "</font></th>");
                    }
                }
                sw.Write("</tr>");

                //Fills cells of excel sheet by the content of grid view
                int i = 0;
                for (i = 0; i < Grid.Rows.Count; i++)
                {
                    if (Grid.Rows[i].Visible == false)
                        goto aa;

                    sw.Write("<tr>");
                    for (int j = 0; j < Grid.Columns.Count; j++)
                    {
                        if (Grid.Columns[j].Visible == true)
                        {
                            string FontName;
                            if (Grid.Columns[j].DefaultCellStyle.Font != null)
                            {
                                FontName = Grid.Columns[j].DefaultCellStyle.Font.Name.ToString();
                            }
                            else
                            {
                                FontName = Grid.DefaultCellStyle.Font.Name.ToString();
                            }
                            if (Grid[j, i].Value != null)
                            {
                                sw.Write("<td><FONT FACE='" + FontName + "'>" + ReplaceSpclChars(Grid[j, i].Value.ToString()) + "</font></td>");
                            }
                            else
                            {
                                sw.Write("<td><FONT FACE='" + FontName + "'>" + Grid[j, i].Value + "</font></td>");
                            }
                        }
                    }
                    sw.Write("</tr>");
                aa: ;

                }
                
                sw.WriteLine("<b><Font Face='Verdana' size='14px'>" +ReplaceSpclChars(Heading1) + "</Font></b>\n");
                sw.WriteLine("</table>");
                sw.Close();
                if (i >= 1)
                {
                  //  Friuts.MessageBoxMy .Show(@"Data is Exported to Excel Successfully", MessageBoxButtons.OK);
                }
            }
        #endregion
        }

        private string ReplaceSpclChars(string fieldName)
        {
            fieldName = fieldName.Replace("<", "&lt;");
            fieldName = fieldName.Replace(">", "&gt;");
            //fieldName = fieldName.Replace("&", "&amp;");
            //fieldName = fieldName.Replace("[", "#91;");
           // fieldName = fieldName.Replace("]", "#93;");
            return fieldName;
        }
    }
}
