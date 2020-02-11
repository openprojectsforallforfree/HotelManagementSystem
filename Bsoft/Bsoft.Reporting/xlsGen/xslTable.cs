using System;
using System.Collections.Generic;
 
using System.Text;
 
 
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///    
//cell c = new cell("Hi");
//cells cls = new cells();
//cls.add(c);
//cls.add(c);
//cls.add(c);
//row rw = new row(cls, bdr);
//rw.addcell(c);
//rw.addcell(c);
//rw.addcell(c);
//column col = new column("5%",bdr);
//column col1 = new column("20%", bdr);
//column col2 = new column("20%", bdr);
//column col3 = new column("25%", bdr);
//column col4 = new column("30%", bdr);
//columns cols = new columns();
//cols.add(col); cols.add(col1); cols.add(col2); cols.add(col3); cols.add(col4);
//table_body tbdy = new table_body(rw);

//table tbl = new table(cols, tbdy);
//tbl.tblayout = table_layout.fixxed;
//tbl.width = "5in";
//block blkt = new block(tbl.ToString());
//tble.Columns.add(new column("20%"));
//tble.Columns.add(new column("10%"));
//tble.Columns.add(new column("10%"));
//tble.Columns.add(new column("10%"));
// Please use with permission from mrdhiraj@gmail.com 
namespace Bsoft.Reporting.xls
{
    public enum keep_together
    {
        auto,
        always
    }

    
    public class table
    {
        public table_layout tblayout { get; set; }
        public string width;
        //public StringBuilder content = new StringBuilder();
        //public cell c = new cell("Hi");
        //public cells cls = new cells();
        //public borderDesign bd = new borderDesign(border_width.medium, border_style.dotted, Color.Bisque);
        //public border bdr = new border();
        public rows Rows = new rows();
        //public row rw = new row(cls, bdr);
        //public column col = new column("5%", bdr);
        public columns Columns = new columns();
        public table_body  Body = new table_body();
        public table_header  Header = new table_header();
        //public table tbl = new table(cols, tbdy);
        //public block blkt = new block(tbl.ToString());
        public block block = new block("");
        private void creatContents()
        {

        }
        public table()
        {
        }
        public table(columns columns, table_header header, table_body body)
        {
            Columns = columns;
            Header = header;
            Body = body;
            //content.Append(columns.ToString() + "\n" + header.ToString() + "\n" + body.ToString());
        }
        public table(columns columns, table_body body)
        {
            Columns = columns;
            Body = body;
           // content.Append(columns.ToString() + "\n" + body.ToString());
        }

        public table(table_body body, table_layout tableLayout, string width)
        {
            Body = body;
           // content.Append(body.ToString());
            tblayout = tableLayout;
            this.width = width;
        }
        public table(table_header header, table_body body, table_layout tableLayout, string width)
        {
            Header = header;
            Body = body;
            //content.Append(header.ToString() + "\n" + body.ToString());
            tblayout = tableLayout;
            this.width = width;
        }




        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<fo:table ");

            switch (tblayout)
            {
                case table_layout.auto:
                    break;
                case table_layout.fixxed:
                    sb.Append(" table-layout = " + utililty.getQuoted("fixed"));
                    break;
                default:
                    break;
            }

            if (width != null && width.Trim() != "")
            {
                sb.Append(" width = " + utililty.getQuoted(width));
            }
            sb.Append(">");
           // sb.Append(content.ToString());
            sb.Append(Columns.ToString() + "\n" + Header.ToString() + "\n" + Body.ToString());
            sb.Append("</fo:table>");
            block.add(sb.ToString ());
            return utililty .RemoveTroublesomeCharacters ( block.ToString());
        }
    }

    public class table_header
    {
        public rows Rows = new rows();
        public table_header()
        {
        }
        public table_header(row row)
        {
            Rows.add(row);
        }
        public table_header(rows rows)
        {
            this.Rows = rows;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<fo:table-header>");
            sb.Append(Rows.ToString());
            sb.Append("</fo:table-header>");
            return sb.ToString();
        }
    }
    /// <summary>
    /// A Table body has rows only 
    /// </summary>
    public class table_body : table_header
    {
        public table_body()
        {
        }
        public table_body(row row)
        {
            Rows.add(row);
        }
        public table_body(rows rows)
        {
            this.Rows = rows;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<fo:table-body>");
            sb.Append(Rows.ToString());
            sb.Append("</fo:table-body>");
            return sb.ToString();
        }
    }
    public class percentage
    {
        double value_;
        public percentage(double value)
        {
            value_ = value;
        }
        public override string ToString()
        {
            return value_.ToString() + "%";
        }
    }
    public class columns
    {
        StringBuilder sb = new StringBuilder();
        public columns()
        { }
        public columns(params column[] col)
        { add(col); }

        public void add(params double [] widths)
        {
            for (int i = 0; i < widths.Length; i++)
            {
                column c = new column(widths[i].ToString () + "in");
                sb.Append(c.ToString());
            }
        }
        public void add(string unit, params double[] widths)
        {
            for (int i = 0; i < widths.Length; i++)
            {
                column c = new column(widths[i].ToString () + unit );
                sb.Append(c.ToString());
            }
        }
        public void add( string width)
        {
          
                column c = new column(width);
                sb.Append(c.ToString());
           
        }
        public  void add  (params string[] widths)
        {
            for (int i = 0; i < widths.Length; i++)
            {
                column c = new column(widths[i]);
                sb.Append(c.ToString ());
            }
        }
        public void add(string unit, border boder, params double[] widths)
        {
            for (int i = 0; i < widths.Length; i++)
            {
                column c = new column(widths[i] .ToString () +unit , boder);
                sb.Append(c.ToString());
            }
        }
        public void add(border boder,  string width)
        {
                column c = new column(width, boder);
                sb.Append(c.ToString());
        }
        public  void add  (border boder, params string[] widths)
        {
            for (int i = 0; i < widths.Length; i++)
            {
                column c = new column(widths[i], boder);
                sb.Append(c.ToString());
            }
        }
        public void add(params column[] col)
        {
            for (int i = 0; i < col.Length ; i++)
            {
                sb.Append(col[i].ToString());    
            }
            
        }
        public override string ToString()
        {
            return sb.ToString();
        }
    }
    public class column
    {
        public column()
        {
           
        }
        public column(string column_with_unit)
        {
            this.column_width = column_with_unit;
        }
        public column(string column_with_unit, border border)
        {
            this.column_width = column_with_unit;
            this.border_ = border;
        }
        public string column_width { get; set; }
        public border border_ { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" <fo:table-column  ");
            if (column_width != null && column_width.Trim() != "")
            {
                sb.Append(" column-width=" + utililty.getQuoted(column_width) + " ");
            }
            if (border_ != null)
            {
                sb.Append(border_.ToString());
            }
            sb.Append("/>");
            return sb.ToString();
        }
    }
    public class rows
    {
        StringBuilder sb = new StringBuilder();
        public void add(row row)
        {
            sb.Append(row.ToString());
        }
        public void add(border boderall,row row)
        {
            row.border_ = boderall;
            sb.Append(row.ToString());
        }
        public void add(params string[] cellValues)
        {
            cells cels = new cells  ();
            rows ros = new rows ();
            for (int i = 0; i < cellValues.Length ; i++)
			{
                cell c  = new cell ( cellValues [i]);
                cels .add ( c);
			}
            ros.add (new row (  cels));

            sb.Append(ros.ToString());
        }
        
        public void add(border boderall,params string[] cellValues)
        {
            cells cels = new cells();
            rows ros = new rows();
            for (int i = 0; i < cellValues.Length; i++)
            {
                cell c = new cell(cellValues[i]);
                cels.add(c);
            }
            ros.add(new row(cels,boderall));

            sb.Append(ros.ToString());
        }
        public override string ToString()
        {
            return sb.ToString();
        }
    }
    public class row
    {
        public font font { get; set; }
        public double height { get; set; }
        public keep_together keepTogether { get; set; }
        public border border_ { get; set; }
     

        public string content;

        public row()
        {
        }
        public row(cells cells)
        {
            content = cells.ToString();
        }
        public row( border boder)
        {
            border_ = boder;
        }
        public row(cells cells, border boder)
        {
            content = cells.ToString();
            border_ = boder;
        }
        public row(params string[] cellValues)
        {
            cells cels = new cells();
                      for (int i = 0; i < cellValues.Length; i++)
            {
                cell c = new cell(cellValues[i]);
                cels.add(c);
            }
                      content += cels.ToString();
        }
        public row(params cell[] cell)
        {
            for (int i = 0; i < cell.Length ; i++)
            {
                content+= cell[i].ToString();
            }
        }
        public row(font font_, double height)
        {
            this.font = font;
            this.height = height;
            font = new font();
        }
        public row(font font_, double height, keep_together keeptogether)
        {
            this.font = font;
            this.height = height;
            this.keepTogether = keeptogether;
            font = new font();
        }
        public void addcell(string  text)
        {
            if (text .Trim ().StartsWith ( "<fo:table-cell"))
            {
                content = content + text;
            }
            else
            {
            cell ce = new cell(text);
            content = content + "\n" + ce.ToString();
            }
        }
        public void addcell(cell cell)
        {
            content = content + "\n" + cell.ToString();
        }
        public void addcell(cells cells)
        {
            content = content + "\n" + cells.ToString();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<fo:table-row ");
            if (font != null)
            { sb.Append(font.ToString()); }
            if (height != 0)
            {
                sb.Append(" height=" + utililty.getQuoted(height, "in"));
            }
            if (border_ != null)
            {
                sb.Append(border_.ToString());
            }
            if (keepTogether == keep_together.always)
            {
                sb.Append(" keep-together = " + utililty.getQuoted("always"));
            }
           
            sb.Append(">");
            sb.Append(content);
            sb.Append(" </fo:table-row>");
            return sb.ToString();
        }
    }
    public class cells
    {
        StringBuilder sb = new StringBuilder();
        public void add(cell cell)
        {
            sb.Append(cell.ToString());
        }
        public void add(string  cell)
        {
            cell cel = new cell(cell);
            sb.Append(cel.ToString());
        }
        public override string ToString()
        {
            return sb.ToString();
        }
    }
    public class cell
    {
        public StringBuilder content = new StringBuilder();
        public int columnSpan { get; set; }
        public int rowSpan { get; set; }
        public font font { get; set; }
        public cell()
        {
        }
        public void clearContent()
        {
            content.Remove(0, content.Length);
        }
        public cell(node node)
        {
            content.Append(" <fo:block>");
            content.Append(node.ToString());
            content.Append(" </fo:block>");
        }
        public cell(string text, int colspan )
        {
            columnSpan = colspan;
            block b = new block(text);
            content.Append(b.ToString());
        }
        public cell(string text,int colspan,int rowspan )
        {
            columnSpan = colspan;
            rowSpan = rowspan;
            block b = new block(text);
            content.Append(b.ToString());
        }
        public cell(string text)
        {
            block b = new block(text);

            content.Append(b.ToString());
            
        }
        public cell(block blck)
        {
            content.Append(blck.ToString());
        }
        public cell(block blck, int colspan, int rowspan)
        {
            columnSpan = colspan;
            rowSpan = rowspan;
            content.Append(blck.ToString());
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" <fo:table-cell");
            
            if (columnSpan != 0)
            {
                sb.Append(" number-columns-spanned=" + utililty.getQuoted(columnSpan));
            }
            if (font != null)
                sb.Append(font.ToString());
            if (rowSpan != 0)
            {
                sb.Append(" number-rows-spanned=" + utililty.getQuoted(rowSpan));
            }
            sb.Append(">"+content.ToString());
            sb.Append(" </fo:table-cell>");
            return sb.ToString();
        }
    }

    /// <summary>
    /// old way
    /// </summary>
    public class xslGenTable
    {
        private StringBuilder sb = new StringBuilder();

        public void startTable()
        {
            sb.Append("<fo:table table-layout=\"fixed\" width =\"100%\">");
        }
        public void closeTable()
        {
            sb.Append("</fo:table>");
        }
        public void addcolumn(string columnwidht, double bordersizeinpt)
        {
            sb.Append(" <fo:table-column column-width=\"" + columnwidht + "\" border=\"" + bordersizeinpt.ToString() + "pt solid black\"/>");
        }
        public void addcolumn(double columnwidthinPercent, double bordersizeinpt)
        {
            sb.Append(" <fo:table-column column-width=\"" + columnwidthinPercent + "%\" border=\"" + bordersizeinpt.ToString() + "pt solid black\"/>");
        }

        public void addTableHeader()
        {
            sb.Append(" <fo:table-header>");

        }
        public void closeTableHeader()
        {
            sb.Append("  </fo:table-header>");

        }
        public void addTableRow()
        {
            sb.Append(" <fo:table-row height=\"0.25in\" font-weight=\"bold\" >");
        }
        public void closeTableRow()
        {
            sb.Append(" </fo:table-row> >");
        }
        public void addTableCell(string node)
        {
            sb.Append(" <fo:table-cell>");
            sb.Append(" <fo:block>");
            sb.Append(" <xsl:value-of select=\"" + node + "\"/>");
            sb.Append(" </fo:block>");
            sb.Append(" </fo:table-cell>");
        }


        public void addTableBody()
        {
            sb.Append(" <fo:table-body>");
        }
        public void closeTableBody()
        {
            sb.Append("  </fo:table-body>");
        }
        public void addForLoop(string node)
        {
            sb.Append("<xsl:for-each select=\"" + node + "\">");
        }
        public void closeForLoop()
        {
            sb.Append(" </xsl:for-each>");
        }

        public void addComment(string comment)
        {
            sb.Append(" <!--" + comment + "-->");
        }

        public void clear()
        {
            sb.Remove(0, sb.Length);
        }
        public string getXls()
        {
            return sb.ToString();
        }

    }
}
