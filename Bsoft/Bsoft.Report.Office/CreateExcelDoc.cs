using System;
using System.Collections.Generic;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Reflection;

//using System.Runtime.InteropServices;


namespace ExcelExample.logic
{
    class CreateExcelDoc
    {
        private Excel.Application app = null;
        private Excel.Workbook workbook = null;
        private Excel.Worksheet worksheet = null;
        private Excel.Range workSheet_range = null;
        ExcelExample.logic.ExcelRowColumn erc = new ExcelRowColumn();
        public CreateExcelDoc()
        {
            createDoc();
        }
        public CreateExcelDoc(bool isnew, string filename)
        {
            if (isnew)
            { 
                createDoc();
            }
            else
            {
                getdoc(filename);
            }

        }

        public void getdoc(string filename)
        {
            try
            {
                app = new Excel.Application();
                app.Visible = true;
                Missing missing = Missing.Value;
                workbook = app.Workbooks.Open(filename, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
                worksheet = (Excel.Worksheet)workbook.Sheets[1];
            }
            catch  
            {
                Console.Write("Error");
            }
            finally
            {
            }

        }
        public void getDoc()
        {
            //Excel._Application excelApp = null;
            //try
            //{
            //   Interaction.Ge
            //    excelApp = new Excel.ApplicationClass();

            //    excelApp.Visible = true;

            //    Missing missing = Missing.Value;
            //    excelApp.Workbooks.Add(missing);
            //    // or
            //    //excelApp.Workbooks.Open("file.xlsx", missing, missing, missing, missing,
            //    //                        missing, missing, missing, missing,
            //    //                        missing, missing, missing, missing,
            //    //                        missing, missing);

            //    Excel.Worksheet sheet = excelApp.ActiveWorkbook.ActiveSheet as Excel.Worksheet;
            //    Excel.Range r = sheet.Cells[1, 1] as Excel.Range;
            //    r.FormulaR1C1 = "Test";
            //}
            //finally
            //{
            //    excelApp.Quit();
            //}

        }
        public string GetCurrentCell()
        {
            string row = app.ActiveCell.Row.ToString();
            string col = app.ActiveCell.Column  .ToString();
               col=erc.ExcelColumnFromNumber(Convert.ToInt32 (col));
            return col + row ;
        }
        public void createDoc()
        {
            try
            {

                app = new Excel.Application();
                app.Visible = true;
                workbook = app.Workbooks.Add(1);
                worksheet = (Excel.Worksheet)workbook.Sheets[1];
            }
            catch (Exception e)
            {
                Console.Write("Error");

            }
            finally
            {
            }
        }
        public void createHeaders(string Cell, string htext, int mergeColumns, string b, bool font, int size, string fcolor)
        {

            int row, col;
            erc.setCell(Cell);
            col = erc.col;
            row = erc.row;
            createHeaders(row, col, htext, Cell, Cell, mergeColumns, b, font, size, fcolor);
        }

        public void createHeaders(int row, int col, string htext, int mergeColumns, string b, bool font, int size, string fcolor)
        {

            string cell1, cell2;
            cell1 = erc.getCellName(row, col);
            //  cell2 = erc.getCellName(row, col);
            createHeaders(row, col, htext, cell1, cell1, mergeColumns, b, font, size, fcolor);
        }

        public void createHeaders(int row, int col, string htext, string cell1, string cell2, int mergeColumns, string b, bool font, int size, string fcolor)
        {
            worksheet.Cells[row, col] = htext;
            workSheet_range = worksheet.get_Range(cell1, cell2);
            if (mergeColumns > 1)
            {
                workSheet_range.Merge(mergeColumns);
            }

            switch (b)
            {
                case "YELLOW":
                    workSheet_range.Interior.Color = System.Drawing.Color.Yellow.ToArgb();
                    break;
                case "GRAY":
                    workSheet_range.Interior.Color = System.Drawing.Color.Gray.ToArgb();
                    break;
                case "GAINSBORO":
                    workSheet_range.Interior.Color = System.Drawing.Color.Gainsboro.ToArgb();
                    break;
                case "Turquoise":
                    workSheet_range.Interior.Color = System.Drawing.Color.Turquoise.ToArgb();
                    break;
                case "PeachPuff":
                    workSheet_range.Interior.Color = System.Drawing.Color.PeachPuff.ToArgb();
                    break;
                default:
                    //  workSheet_range.Interior.Color = System.Drawing.Color..ToArgb();
                    break;

            }
            workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            workSheet_range.Font.Bold = font;
            workSheet_range.ColumnWidth = size;
            if (fcolor.Equals(""))
            {
                workSheet_range.Font.Color = System.Drawing.Color.White.ToArgb();
            }
            else
            {
                workSheet_range.Font.Color = System.Drawing.Color.Black.ToArgb();
            }
        }
        public void addData(int row, int col, string data, string cell1, string cell2, string format)
        {
            worksheet.Cells[row, col] = data;
            workSheet_range = worksheet.get_Range(cell1, cell2);
            workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            workSheet_range.NumberFormat = format;
        }
        public void addData(int row, int col, string data, string format)
        {
            string cell1;
            cell1 = erc.getCellName(row, col);
            //cell2 = erc.getCellName(row, col);
            addData(row, col, data, cell1, cell1, format);
        }
        public void addData(string Cell, string data, string format)
        {
            int row, col;
            erc.setCell(Cell);
            col = erc.col;
            row = erc.row;
            addData(row, col, data, Cell, Cell, format);
        }
        public void addData(int row, int col, string data)
        {
            worksheet.Cells[row, col] = data;
        }
        public void addDataTable(string Cell, DataTable dt, int mergeColumns, string b, bool font, int size, string fcolor, bool addTitle)
        {
            int row, col;
            erc.setCell(Cell);
            col = erc.col;
            row = erc.row;
            addDataTable(row, col, dt, mergeColumns, b, font, size, fcolor, addTitle);
        }
        public void addDataTable(int row, int col, DataTable dt, int mergeColumns, string b, bool font, int size, string fcolor, bool addTitle)
        {
            string title, data;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string c = dt.Columns[i].ColumnName;
                if (i == 0)
                {
                    title = c;
                }
            }

            foreach (DataRow dr in dt.Rows)
            {
                if (addTitle)
                {
                    data = dr[0].ToString();

                    createHeaders(row, col, data, mergeColumns, b, font, size, fcolor);

                    data = dr[1].ToString();
                    addData(row + 1, col++, data, "#,##0");

                }
                else
                {
                    data = dr[1].ToString();
                    addData(row, col++, data, "#,##0");
                }

            }

            //worksheet.Cells[row, col] = data;
            //workSheet_range = worksheet.get_Range(cell1, cell2);
            //workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            //workSheet_range.NumberFormat = format;
        }
        public void addDataTableAll(string Cell, DataTable dt, string b, bool font, int size, string fcolor, bool addTitle)
        {
            int row, col;
            erc.setCell(Cell);
            col = erc.col;
            row = erc.row;
            addDataTableAll(row, col, dt, b, font, size, fcolor, addTitle);
        }
        public void addDataTableAll(int row, int col, DataTable dt, string b, bool font, int size, string fcolor, bool addTitle)
        {
            string title, data;
            int rowCount = 0;
            for (int i = 0; i < dt.Columns.Count; i++)
            {rowCount = 0;
            foreach (DataRow dr in dt.Rows)
            {
                    if (addTitle & i == 0)
                    {
                        data = dr[i].ToString();
                        createHeaders(row + i, col + rowCount, data, 0, b, font, size, fcolor);
                    }
                    else
                    {
                        data = dr[i].ToString();
                        addData(row + i, col + rowCount, data, "#,##0");
                    }
                    rowCount++;
                }
            }

            //worksheet.Cells[row, col] = data;
            //workSheet_range = worksheet.get_Range(cell1, cell2);
            //workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            //workSheet_range.NumberFormat = format;
        }
    }

    public class ExcelRowColumn
    {
        public int row, col;
        public void setCell(string cell)
        {
            int a = getIndexofNumber(cell);
            string rowpart = cell.Substring(a, cell.Length - a);
            row = Convert.ToInt32(rowpart);
            string colpart = cell.Substring(0, a);
            col = NumberFromExcelColumn(colpart);
        }
        public string getCellName(int row, int col)
        {
            return ExcelColumnFromNumber(col) + row.ToString();

        }
        public string ExcelColumnFromNumber(int column)
        {
            string columnString = "";
            decimal columnNumber = column;
            while (columnNumber > 0)
            {
                decimal currentLetterNumber = (columnNumber - 1) % 26;
                char currentLetter = (char)(currentLetterNumber + 65);
                columnString = currentLetter + columnString;
                columnNumber = (columnNumber - (currentLetterNumber + 1)) / 26;
            }
            return columnString;
        }

        /// <summary>
        /// A -> 1<br/>
        /// B -> 2<br/>
        /// C -> 3<br/>
        /// ...
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        public int NumberFromExcelColumn(string column)
        {
            int retVal = 0;
            string col = column.ToUpper();
            for (int iChar = col.Length - 1; iChar >= 0; iChar--)
            {
                char colPiece = col[iChar];
                int colNum = colPiece - 64;
                retVal = retVal + colNum * (int)Math.Pow(26, col.Length - (iChar + 1));
            }
            return retVal;
        }

        private int getIndexofNumber(string cell)
        {
            int a = -1, indexofNum = 10000;
            a = cell.IndexOf("0"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("1"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("2"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("3"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("4"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("5"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("6"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("7"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("8"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("9"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }

            if (indexofNum != 10000)
            { return indexofNum; }
            else
            { return 0; }

            
        }

    }
}
