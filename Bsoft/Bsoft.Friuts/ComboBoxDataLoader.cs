using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

//using Oracle.DataAccess.Client;
//using Oracle.DataAccess.Types;
using System.Drawing;
using Bsoft;
using Bsoft.Controls;
using Bsoft.Common;
using Bsoft.Data;

//using fruitFx.Data.Oracle;

//using TPPIMS.AppClass;

namespace Friuts
{
    /// <summary>
    /// This loads data into Combo Boxes
    /// </summary>
    public class ComboBoxDataLoader
    {
        public ComboBoxDataLoader()
        {
            Form f = new Form();
            _FormName = f;
        }
        /// <summary>
        /// Required for manking the combo size box variable
        /// </summary>
        /// <param name="CallingForm"></param>
        public ComboBoxDataLoader(Form callingForm)
        {
            _FormName = callingForm;
        }
        #region Member variables.
        public string NotApplicableString="";
         
        public string ComboboxOrderBy = "";
        private ComboLoadInfoList _comboLoadinfoItems = new ComboLoadInfoList();
        private StringBuilder _sql = new StringBuilder();
        private Form _FormName = null;

        #endregion

        #region Constructors & Finalizers.
        #endregion

        #region Nested Enums, Structs, and Classes.
        #endregion

        #region Properties

        public ComboLoadInfoList ComboLoadinfoItems
        {
            get { return _comboLoadinfoItems; }
            set { _comboLoadinfoItems = value; }
        }

        public Form FormName
        {
            get { return _FormName; }
            set { _FormName = value; }
        }

        #endregion

        #region Methods
        public bool LoadDataInComboBoxes()
        {
            return LoadData();
        }

        public bool LoadData()
        {
            GenerateSQL();

            return LoadDataInAllComboBoxes();
        }
        /// <summary>
        /// The Should have name 
        /// </summary>
        /// <param name="sqlquery">eg select xyz as name form abc wehere ...</param>
        /// <returns></returns>
        public  bool LoadData(string sqlquery)
        {   //added By Dhiraj
            _sql.Remove(0, _sql.Length);
            _sql.AppendLine("SELECT CAST(s.[key] as nvarchar(25)) as 'key', 	s.value as 'value', 	 '' as 'code', 	'tt' as 'tableName' FROM ( ");
            _sql.AppendLine(sqlquery);
            _sql.AppendLine(") s");

            return LoadDataInAllComboBoxes();
        }

        private bool GenerateSQL()
        {
            _sql.Remove(0, _sql.Length);

            bool isFirst = true;
            foreach (ComboLoadInfo info in _comboLoadinfoItems)
            {
                if (info.DependentOnCombo != null)
                    continue;
                if (isFirst)
                    isFirst = false;
                else
                    _sql.AppendLine("\nUNION ALL\n");

                //_sql.AppendFormat("SELECT \n\t{0} key, \n\t{1} value, \n\t {2} code, \n\t'{3}' tableName \nFROM \n\t{3}"
                //, info.KeyColumnForSelect(), info.DisplayColumn
                //, info.CodeColumn.Trim().Length == 0 ? "''": info.CodeColumn
                //, info.TableName);

                _sql.AppendFormat("SELECT \n\t{0} as 'key', \n\t{1} as 'value', \n\t {2} as 'code', \n\t'{3}' as 'tableName' \nFROM \n\t{3}"
                        , info.KeyColumnForSelect(), info.DisplayColumn
                        , info.CodeColumn.Trim().Length == 0 ? "''" : info.CodeColumn
                        , info.TableName);

                //adding the where clause.
                if (info.Condition.Trim().Length > 0)
                {
                    _sql.AppendFormat("\n WHERE \n\t{0}", info.Condition);
                }

                //adding the orderBy Clause
                //_sql.Append("\nORDER BY");
                //_sql.AppendFormat("\n\t{0} ASC", info.KeyColumnForSelect());

                _sql.AppendLine();
            }

            _sql.Append("\nORDER BY \n\t");
            if (ComboboxOrderBy == "")
            {

                //_sql.Append("\n\ttableName, Key ASC");
                _sql.Append(" 'Key' ASC");
            }
            else
            {
                _sql.Append(ComboboxOrderBy);
                ComboboxOrderBy = "";
            }

            return true;
        }
        
        private bool LoadDataInAllComboBoxes()
        {
            //open the db connection
            //DBConnect con = new DBConnect(_connectionString);
            DBConnect con = GlobalResources.SelectDBConnection;
            if (con.Open())
            {
                //execute the query and load it into datatable
                DataTable dt = con.ExecuteDataTable(_sql.ToString());
                Graphics G = null;
                SizeF sz = SizeF.Empty;
                decimal setSize = 0;
                string str = string.Empty;

                if (_FormName != null)
                {
                    G = Graphics.FromHwnd(_FormName.Handle);
                }
                else
                {
                    //_FormName = 
                }

                if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
                {
                    //now load the data in all the comboboxes.
                    foreach (ComboLoadInfo info in _comboLoadinfoItems)
                    {
                        DataRow[] rows = dt.Select(string.Format("tableName = '{0}'", info.TableName));
                        ////FormName = info.thisFormName;
                        if (rows.Length > 0)
                        {
                            //add the selected rows into the combo box.
                            info.ComboBox.Items.Clear();
                            if (!info.IsCompulsory)
                            {
                                if (info.KeyColumnType == ColumnTypes.Number)
                                    info.ComboBox.Items.Add(new ComboItem(string.Empty, string.Empty, info.KeyColumnType));
                                else
                                    info.ComboBox.Items.Add(new ComboItem(string.Empty, string.Empty, info.KeyColumnType));
                            }
                            foreach (DataRow row in rows)
                            {
                      
                                info.ComboBox.Items.Add(new ComboItem(row["key"].ToString(), row["value"].ToString().Trim(), row["code"].ToString(), info.KeyColumnType));

                                if (_FormName != null)
                                {
                                    try
                                    {
                                        str = row["value"].ToString().Trim();
                                        sz = G.MeasureString(str, info.ComboBox.Font);
                                        if (Convert.ToDecimal(sz.Width) > setSize)
                                        {
                                            setSize = Convert.ToDecimal(sz.Width);
                                        }
                                    }
                                    catch
                                    {
                                        //do nothing..error handl..
                                    }
                                }
                            }
                            if (_FormName != null)
                            {
                                try
                                {
                                    if (setSize > 0)
                                    {
                                        info.ComboBox.DropDownWidth = Convert.ToInt32(setSize);
                                    }
                                    //G = null;
                                    sz = SizeF.Empty;
                                    setSize = 0;
                                }
                                catch
                                {
                                    //do nothing.. error resume next
                                }
                            }

                            if (info.IsCompulsory)
                                info.ComboBox.SelectedIndex = 0;
                            if (info.AddItem)
                            {
                                info.ComboBox.Items.Add(new ComboItem(string.Empty, ComboLoadInfo.AddItemString, info.KeyColumnType));
                            }
                             
                        }

                        if (info.IsCompulsory)
                            info.ComboBox.SelectedIndex = 0;

                       
                    }

                    DataGeneral.DisposeObject(dt);

                    if (_FormName != null)
                    {
                        G.Dispose();
                    }
                    return true;
                }
                else
                {
                    foreach (ComboLoadInfo info in _comboLoadinfoItems)
                    {
                        info.ComboBox.Items.Clear();
                        if (info.AddItem)
                        {
                            if (info.KeyColumnType == ColumnTypes.Number)
                                info.ComboBox.Items.Add(new ComboItem(string.Empty, string.Empty, info.KeyColumnType));
                            else
                                info.ComboBox.Items.Add(new ComboItem(string.Empty, string.Empty, info.KeyColumnType));
                            if (info.IsCompulsory)
                                info.ComboBox.SelectedIndex = 0;
                            info.ComboBox.Items.Add(new ComboItem(string.Empty, ComboLoadInfo.AddItemString, info.KeyColumnType));
                        }
                    }

                }
            }
            return false;
        }


     
        #endregion

        
    }

   
}
