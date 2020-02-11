using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.Common;
using System.Data;
namespace Bsoft.Data
{

    public enum databaseKind
    {
        SQLServer,
        SQLite,
        MsAccess,
        Oracle
    }
    public static class ConversionSql
    {
        public static databaseKind dbKind;//Please assign this variable before using 
        /// <summary>
        /// Assign dbkind before
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static string changeSQLNonQuery(string sql)
        {
            //sql = sql.ToUpper();
            // sql = sql.Replace("," ," , ");
            switch (dbKind)
            {
                case databaseKind.SQLite:
                    sql = sql.ReplaceCaseInsensitive(" INT ", " integer ");
                    sql = sql.ReplaceCaseInsensitive(" MONEY ", " float(8,2) ");
                    sql = sql.ReplaceCaseInsensitive(" IDENTITY(1,1) ", " autoincrement ");
                    sql = sql.ReplaceCaseInsensitive(" ISNULL ", " ifnull ");
                    // sql = sql.Replace("+", "||");//this will give conflict to math + and string +
                    break;
                case databaseKind.SQLServer:
                    sql = sql.Replace("||", "+");
                    sql = sql.ReplaceCaseInsensitive(" INTEGER ", " int ");
                    sql = sql.ReplaceCaseInsensitive(" NUMBER ", " integer ");
                    sql = sql.ReplaceCaseInsensitive(" VARCHAR2 ", " varchar ");
                    sql = sql.ReplaceCaseInsensitive(" FLOAT(8,2)", " money ");
                    sql = sql.ReplaceCaseInsensitive(" FLOAT", " decimal");
                    sql = sql.ReplaceCaseInsensitive(" AUTOINCREMENT ", " identity(1,1) ");
                    sql = sql.ReplaceCaseInsensitive(" IFNULL ", " isnull ");
                    break;
            }
            return (sql);
        }
        /// <summary>
        /// Assign dbkind before
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static string changeSQLScalar(string sql)
        {
            switch (dbKind)
            {
                case databaseKind.SQLite:
                    // sql = sql.Replace("+", "||");//this will give conflict to math + and string +
                    break;
                case databaseKind.SQLServer:
                    sql = sql.Replace("||", "+");

                    break;
            }
            return (sql);
        }
    }

    public static class SqlRepository
    {

        public static string GetTableNames
        {
            get
            {
                switch (ConversionSql.dbKind)
                {
                    case databaseKind.SQLServer:
                        return "select TABLE_NAME as TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_TYPE = 'BASE TABLE'";
                    default:
                        return "SELECT name as TABLE_NAME FROM sqlite_master WHERE type='table'";
                }
                
            }
        }

        public static string GetViewNames
        {
            get
            {
                switch (ConversionSql.dbKind)
                {
                    case databaseKind.SQLServer:
                        return "select TABLE_NAME as TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_TYPE = 'view'";
                      
                    default:
                        return "SELECT name as TABLE_NAME FROM sqlite_master WHERE type='view'";
                   
                }
                
            }
        }


        public static string GetColumnNames_Types(string table)
        {
            switch (ConversionSql.dbKind)
            {
                case databaseKind.SQLServer:
                    return string.Format(@"select column_name + ' (' +
                        data_type +
                        case isnull (CAST (CHARACTER_MAXIMUM_LENGTH as varchar) ,'*') 
                        when  '*' then ''
                        else '(' + CAST (CHARACTER_MAXIMUM_LENGTH as varchar) + ')'
                        end 
                         + ')' as columnName
                        from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME ='{0}'      
                        ", table);
                   
                default:
                    break;
            }
            return null;
        }
       
        public static string GetCreateSQL(string table, string[] columns)
        {
            string sql = "CREATE TABLE " + table + "(";
            string columnsStr = GetColumns(table, columns);
            sql = columnsStr + ")";
            return sql;
        }

        public static string GetInsertSQL(string table, string[] columns, string[] columnDetail)
        {
            string columnsStr = GetColumns(table, columns);
            string columnsStrVal = GetColumns(table, columnDetail);
            string sql = string.Format(@" INSERT INTO {0} ( {1} ) VALUES ( {2} )", table, columnsStr, columnsStrVal);
            return sql;
        }

        private static string GetColumns(string table, string[] columns)
        {
            string columnsStr = "";
            foreach (string column in columns)
            {
                columnsStr = columnsStr + System.Environment.NewLine + column + ",";
            }
            columnsStr = columnsStr.Substring(0, columnsStr.Length - 1);
            return columnsStr;
        }

        public static string GetSelectSQL(string tableName, DataTable dataTable)
        {
            StringBuilder sb = new StringBuilder();
            string columns = "";
            
            foreach (DataColumn dc in dataTable.Columns)
            {
                columns = columns + "," + dc.ColumnName + "";
            }
            columns = columns.Remove(0, 1);
            sb.AppendLine("SELECT ");
            sb.AppendLine(columns);
            sb.AppendLine(" FROM ");
            sb.AppendLine(tableName );
            return sb.ToString();
        }

        /// <summary>
        /// Retruns insert script from the datatable
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetInsertScript(string tableName, DataTable dataTable)
        {
            StringBuilder sb = new StringBuilder();

            string sbSql = "";
            string columns = "";
            string values = "";
            foreach (DataColumn dc in dataTable.Columns)
            {
                columns = columns + ",[" + dc.ColumnName + "]";
            }
            columns = columns.Remove(0, 1);
            foreach (DataRow dr in dataTable.Rows)
            {
                values = "";
                foreach (DataColumn dc in dataTable.Columns)
                {
                    values = values + ",'" + dr[dc.ColumnName].ToString() + "'";
                }
                values = values.Remove(0, 1);
                sbSql = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName, columns, values);
                sb.AppendLine(sbSql);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Retruns csv
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetCSV(  DataTable dataTable)
        {
            StringBuilder sb = new StringBuilder();
            string columns = "";
            string values = "";
            foreach (DataColumn dc in dataTable.Columns)
            {
                columns = columns + "," + dc.ColumnName + "";
            }
            columns = columns.Remove(0, 1);
            sb.AppendLine(columns);
            foreach (DataRow dr in dataTable.Rows)
            {
                values = "";
                foreach (DataColumn dc in dataTable.Columns)
                {
                    values = values + "," + dr[dc.ColumnName].ToString() + "";
                }
                values = values.Remove(0, 1);
                sb.AppendLine(values);
            }
            return sb.ToString();
        }

        public static string GetSelectGenerator(string tableName, DataTable dataTable)
        {
            StringBuilder sb = new StringBuilder();

           
            string columns = "";
            string values = "";
            foreach (DataColumn dc in dataTable.Columns)
            {
                columns = columns + ",[" + dc.ColumnName + "]";
            }
            columns = columns.Remove(0, 1);
            foreach (DataColumn dc in dataTable.Columns)
            {
                values = values + "|| ''',''' ||" + dc.ColumnName ;
            }
            values = values.Remove(0, 10);
            values = values + " || ";
            string sql =string .Format ( @"   SELECT 
                'insert into {0} ({1}) values (' ||
                '''' {2} '''' || ');' tabl
                FROM
                {0}",tableName,columns ,values  );

            return sql;
        }

    }
}
