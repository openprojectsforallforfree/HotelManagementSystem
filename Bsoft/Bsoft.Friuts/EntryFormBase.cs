using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Bsoft.Controls;
using Bsoft;
using System.Drawing;
using System.IO;
using Bsoft.Common;


using Bsoft.Data;
using CrudeFx.NepaliDate;
namespace Friuts
{

    public class EntryFormBase : FormBase
    {
        #region Member variables.
        private bool _isQuickSaveKey = true;
        #endregion

        #region Constructors & Finalizers.
        public EntryFormBase()
            : base()
        {
            ShowInTaskbar = false;
        }

        public EntryFormBase(FormTypes formType, string tableName)
            : base(formType, tableName)
        {
            ShowInTaskbar = false;
        }
        #endregion

        #region Nested Enums, Structs, and Classes.
        #endregion

        #region Properties
        //try to Overload the KeyPreview Properties but not success.
        /// <summary>
        ///  Every Entry Form when user key Press the Alt + S then data saving
        /// </summary>
        public bool IsQuickSaveKey
        {
            get { return _isQuickSaveKey; }
            set { _isQuickSaveKey = value; }
        }

        #endregion

        #region Methods
        public override bool GenerateInsertSQL()
        {
            bool status = false;
            InsertSQL = string.Empty;
            queryBulilder.Remove(0, queryBulilder.Length);
            queryBulilder2.Remove(0, queryBulilder2.Length);

            queryBulilder.AppendFormat("INSERT INTO {0} (", TableName);
            queryBulilder2.Append(" VALUES(");

            //adding the filelds in which data are to be udpated.
            foreach (TableColumn col in ColumnList)
            {
                //Oracle queryBulilder.AppendFormat("{0},", col.DbColumnName);

                if (col.IsPrimaryKeyColumn && col.SequenceName.Trim().Length > 0)
                {
                    queryBulilder.AppendFormat("{0},", col.DbColumnName);
                    queryBulilder2.AppendFormat("{0},", col.SequenceName);
                }
                else if (col.IsPrimaryKeyColumn && col.UseMaxValue)
                {
                    queryBulilder.AppendFormat("{0},", col.DbColumnName);
                    //use the max value of the primary Key ID + 1.                    
                    queryBulilder2.AppendFormat("  (SELECT Nvl( MAX({0}),0) + 1 FROM {1}),", col.DbColumnName, TableName);
                }

                else if (col.IsPrimaryKeyColumn && col.Type == ColumnTypes.Guid)
                {
                    queryBulilder.AppendFormat("{0},", col.DbColumnName);
                    queryBulilder2.AppendFormat("'{0}',", System.Guid.NewGuid().ToString());
                    //queryBulilder2.AppendFormat("{0},", col.SequenceName);
                    //do nothing
                }
                else if (col.IsPrimaryKeyColumn)
                {
                    //queryBulilder.AppendFormat("{0},", col.DbColumnName);
                    //queryBulilder2.AppendFormat("{0},", col.SequenceName);
                    //do nothing
                }
                else
                {
                    queryBulilder.AppendFormat("{0},", col.DbColumnName);
                    if (col.Control is ComboBox | col.Control is Bsoft.Controls.lblComboBox)
                    {
                        ComboBox cbo = null;
                        if (col.Control is ComboBox)
                        { cbo = (ComboBox)col.Control; }
                        else
                        { cbo = ((Bsoft.Controls.lblComboBox)col.Control).cmbBox; }


                        ComboItem itm = (ComboItem)cbo.SelectedItem;
                        if (cbo.DropDownStyle == ComboBoxStyle.DropDown)
                        {
                            if (cbo.Text == null)
                            {
                                queryBulilder2.Append(" NULL,");
                            }
                            else
                            {
                                queryBulilder2.AppendFormat(" {0},", TableColumn.GetDBValue(ColumnTypes.String, cbo.Text));
                            }
                        }
                        else
                        {
                            //string value = string.Empty;
                            if (itm == null || itm.ToString().Trim() == "")
                            {
                                queryBulilder2.Append(" NULL,");
                            }
                            else
                            {
                                //queryBulilder2.AppendFormat(" {0},", TableColumn.GetDBValue(itm.KeyType, ComboItem.GetDBValue(itm)));
                                if (itm.KeyType == ColumnTypes.String)
                                {
                                    queryBulilder2.AppendFormat(" {0},", TableColumn.GetDBValue(itm.KeyType, itm.Key));
                                }
                                else
                                {
                                    queryBulilder2.AppendFormat(" '{0}',", TableColumn.GetDBValue(itm.KeyType, itm.Key));
                                }
                            }
                        }
                    }

                    else if (col.Control is Bsoft.Controls.lblTextBox)
                    {
                        //=========================================================
                        TextBox pwd = ((Bsoft.Controls.lblTextBox)col.Control).vtxtBox;
                        if (pwd == null || pwd.ToString().Trim() == "")
                        {
                            queryBulilder2.Append(" NULL,");
                        }
                        else if (pwd.UseSystemPasswordChar) // UseSystemPasswordChar true means password field
                        {
                            clsEncryptorDecryptor enc = new clsEncryptorDecryptor();
                            string Password = string.Empty; //set password text box blank..

                            Password = enc.Encrypt(pwd.Text); //User Type password Encryping..
                            queryBulilder2.AppendFormat(" '{0}',", Password.ToString().Replace("'", "''")); //saving and single quot replace..
                        }
                        else
                        {
                            if (col.DBValue.Trim() == "" | col.DBValue == null)
                            {
                                queryBulilder2.AppendFormat("{0},", "null");//By Dhiraj
                            }
                            else
                            {
                                queryBulilder2.AppendFormat("{0},", col.DBValue);
                            }
                        }
                        //=====================================================================
                    }
                    else if (col.Control is Label)
                    {// vtextbox is derived from text box so need to keep vtextbox check first every where!!!
                        if (col.DBValue.Trim() == "" | col.DBValue == null)
                        {
                            queryBulilder2.AppendFormat("{0},", "NULL");
                        }
                        else
                        {
                            queryBulilder2.AppendFormat("{0},", col.DBValue);
                        }
                    }
                    else if (col.Control is VtextBox)
                    {// vtextbox is derived from text box so need to keep vtextbox check first every where!!!
                        if (col.DBValue.Trim() == "" | col.DBValue == null)
                        {
                            queryBulilder2.AppendFormat("{0},", "NULL");
                        }
                        else
                        {
                            queryBulilder2.AppendFormat("{0},", col.DBValue);
                        }
                    }
                    else if (col.Control is TextBox)
                    {
                        //=========================================================
                        TextBox pwd = (TextBox)col.Control;
                        if (pwd == null || pwd.ToString().Trim() == "")
                        {
                            queryBulilder2.Append(" NULL,");
                        }
                        else if (pwd.UseSystemPasswordChar) // UseSystemPasswordChar true means password field
                        {
                            clsEncryptorDecryptor enc = new clsEncryptorDecryptor();
                            string Password = string.Empty; //set password text box blank..

                            Password = enc.Encrypt(pwd.Text); //User Type password Encryping..
                            queryBulilder2.AppendFormat(" '{0}',", Password.ToString().Replace("'", "''")); //saving and single quot replace..
                        }
                        else
                        {
                            if (col.DBValue.Trim() == "" | col.DBValue == null)
                            {
                                queryBulilder2.AppendFormat("{0},", "null");//By Dhiraj
                            }
                            else
                            {
                                queryBulilder2.AppendFormat("{0},", col.DBValue);
                            }
                        }
                        //=====================================================================
                    }
                    else if (col.Control is VtextBox )  
                    {
                        if (col.DBValue.Trim() == "" | col.DBValue == null)
                        {
                            queryBulilder2.AppendFormat("{0},", "NULL");
                        }
                        else
                        {
                            queryBulilder2.AppendFormat("{0},", col.DBValue);
                        }
                    }
                    else if (col.Control is DateTimePicker)
                    {
                        DateTimePicker dtp = (DateTimePicker)col.Control;
                        if (col.DBValue.Trim() == "" | col.DBValue == null | !dtp.Checked)
                        {
                            queryBulilder2.AppendFormat("{0},", "NULL");
                        }
                        else
                        {
                            queryBulilder2.AppendFormat("{0},", col.DBValue);
                        }
                    }
                    else if (col.Control is CheckBox)
                    {
                        if (col.DBValue.Trim() == "" | col.DBValue == null)
                        {
                            queryBulilder2.AppendFormat("{0},", "NULL");
                        }
                        else
                        {
                            queryBulilder2.AppendFormat("{0},", col.DBValue);
                        }
                    }
                    else
                    {
                        if (col.DBValue.Trim() == "" | col.DBValue == null)
                        {
                            queryBulilder2.AppendFormat("{0},", "NULL");
                        }
                        else
                        {
                            queryBulilder2.AppendFormat("{0},", col.DBValue);
                        }
                    }
                }
            }
            //remove the ending comma(,)
            queryBulilder.Replace(",", ")", queryBulilder.Length - 1, 1);
            queryBulilder2.Replace(",", ")", queryBulilder2.Length - 1, 1);
            //queryBulilder.Append(")");
            //queryBulilder2.Append(" )");

            InsertSQL = queryBulilder.ToString() + " " + queryBulilder2.ToString();
            queryBulilder.Remove(0, queryBulilder.Length);
            queryBulilder2.Remove(0, queryBulilder2.Length);
            status = true;
            return status;
        }

        public override bool GenerateSelectSQL()
        {
            bool status = false;
            InsertSQL = string.Empty;
            queryBulilder.Remove(0, queryBulilder.Length);
            //queryBulilder2.Remove(0, queryBulilder2.Length);

            queryBulilder.Append("SELECT ");
            //queryBulilder2.Append(" WHERE 1=1 ");

            //adding the filelds in which data are to be udpated.
            foreach (TableColumn col in ColumnList)
            {
                queryBulilder.AppendFormat("\n\t{0},", col.DbColumnName);
                //if (FormType == FormTypes.EntryForm)
                //{
                //    if (col.IsUniqueValueColumn)
                //    {
                //        if (ActiveControl.Equals(col.Control))
                //            queryBulilder2.AppendFormat(" AND {0} = {1} ", col.DbColumnName, col.DBValue);
                //    }
                //}
                //else if (FormType == FormTypes.EditForm)
                //{
                //    if (col.IsPrimaryKeyColumn)
                //    {
                //        queryBulilder2.AppendFormat(" AND {0} = {1} ", col.DbColumnName, TableColumn.GetDBValue(col.Type, PrimaryKeyValue));
                //    }
                //}
            }

            //remove the ending comma(,)
            queryBulilder.Replace(",", "", queryBulilder.Length - 1, 1);
            queryBulilder.AppendFormat("\n FROM {0} ", TableName);

            SelectSQL = queryBulilder.ToString();// +" " + queryBulilder2.ToString();
            base.GenerateSelectSQL();
            status = true;
            return status;
        }

        public override string GetWhereClauseForSelect()
        {
            if (FormType != FormTypes.EditForm)
                return string.Empty;

            // bool status = false;
            queryBulilder2.Remove(0, queryBulilder2.Length);

            queryBulilder2.Append("\nWHERE 1=1 ");

            //adding the filelds in which data are to be udpated.
            foreach (TableColumn col in ColumnList)
            {
                if (col.IsPrimaryKeyColumn && col.Type == ColumnTypes.Guid)
                {
                    //queryBulilder2.AppendFormat("\n\tAND {0} = {1} ", col.DbColumnName, TableColumn.GetDBValue(col.Type, PrimaryKeyValue));
                    queryBulilder2.AppendFormat("\n\tAND {0} = {1} ", col.DbColumnName, TableColumn.GetDBValue(col.Type, PrimaryKeyValue));
                }
                else if (col.IsPrimaryKeyColumn)
                {
                    //queryBulilder2.AppendFormat("\n\tAND {0} = {1} ", col.DbColumnName, TableColumn.GetDBValue(col.Type, PrimaryKeyValue));
                    queryBulilder2.AppendFormat("\n\tAND {0} = {1} ", col.DbColumnName, TableColumn.GetDBValue(col.Type, PrimaryKeyValue));
                }
            }
            return queryBulilder2.ToString();
        }

        public override bool GenerateUpdateSQL()
        {
            bool status = false;
            UpdateSQL = string.Empty;
            queryBulilder.Remove(0, queryBulilder.Length);
            queryBulilder2.Remove(0, queryBulilder2.Length);

            queryBulilder.AppendFormat("UPDATE {0} SET ", TableName);
            // queryBulilder2.Append(" WHERE 1=1 ");

            //adding the filelds in which data are to be udpated.
            foreach (TableColumn col in ColumnList)
            {
                if (col.IsPrimaryKeyColumn)
                {
                    // queryBulilder2.Append(" WHERE 1=1 ");
                    //By Dhiraj not required for MSSQL2005
                    // queryBulilder2.AppendFormat(" AND {0} = {1} ", col.DbColumnName, col.DBValue);//col.GetDBValue(col.Type, PrimaryKeyValue));
                    if (col.DBValue.ToInt() < 0)
                    {
                        queryBulilder2.AppendFormat(" WHERE {0} = {1} ", col.DbColumnName, TableColumn.GetDBValue(col.Type, PrimaryKeyValue));//col.GetDBValue(col.Type, PrimaryKeyValue));
                    }
                    else
                    {
                        queryBulilder2.AppendFormat(" WHERE {0} = {1} ", col.DbColumnName, col.DBValue);//col.GetDBValue(col.Type, PrimaryKeyValue));
                    }
                }
                else
                {
                    genupdatesqlControlscode(col);
                }
            }
            //remove the ending comma(,)
            queryBulilder.Replace(",", " ", queryBulilder.Length - 1, 1);
            //queryBulilder2.Replace(",", ")", queryBulilder2.Length - 1, 1);

            UpdateSQL = queryBulilder.ToString() + " " + queryBulilder2.ToString();

            status = true;
            return status;
        }

        /// <summary>
        /// Required for some data base where it cannot save more at onece eg in msaccess
        /// Here limit is set to 100
        /// By Dhiraj
        /// </summary>
        /// <returns></returns>
        public bool multipleUpdateSave()
        {
            if (FormType != FormTypes.EditForm)
            {
                DisplayErrorMessage("Form type should be edit form");

                return false;
            }
            if (!ValidateData()) { DisplayErrorMessage(ColumnList.ErrorMsg); return false; }
            if (!GetConfirmation()) { return false; }

            bool status = false;
            UpdateSQL = string.Empty;
            queryBulilder.Remove(0, queryBulilder.Length);
            queryBulilder2.Remove(0, queryBulilder2.Length);
            queryBulilder.AppendFormat("UPDATE {0} SET ", TableName);
            foreach (TableColumn col in ColumnList)
            {
                if (col.IsPrimaryKeyColumn)
                {
                    queryBulilder2.AppendFormat(" WHERE {0} = {1} ", col.DbColumnName, col.DBValue);
                }
            }
            //reqd
            int Fieldcount = 0;
            foreach (TableColumn col in ColumnList)
            {
                if (!col.IsPrimaryKeyColumn)
                {
                    genupdatesqlControlscode(col);
                }

                Fieldcount++;

                if (Fieldcount >= 100)
                {

                    performupdate();
                    queryBulilder.Remove(0, queryBulilder.Length);
                    queryBulilder.AppendFormat("UPDATE {0} SET ", TableName);
                    Fieldcount = 0;
                }
            }
            //remove the ending comma(,)

            status = performupdate();

            if (status)
            {



                DialogResult = DialogResult.OK;
                this.Hide();

            }


            return status;
        }

        private bool performupdate()
        {
            queryBulilder.Replace(",", " ", queryBulilder.Length - 1, 1);
            UpdateSQL = queryBulilder.ToString() + " " + queryBulilder2.ToString();
            string updatesql = UpdateSQL;
            return PeformDML(ref updatesql);
        }

        private void genupdatesqlControlscode(TableColumn col)
        {

            if (col.Control is ComboBox)
            {
                ComboItem itm = (ComboItem)((ComboBox)col.Control).SelectedItem;
                if (itm == null || itm.ToString().Trim() == "")
                {
                    queryBulilder.AppendFormat(" {0} = NULL ,", col.DbColumnName);
                }
                else
                {
                    //queryBulilder.AppendFormat(" {0} = {1} ,", col.DbColumnName, TableColumn.GetDBValue(itm.KeyType, ComboItem.GetDBValue(itm)));

                    // queryBulilder.AppendFormat(" {0} = {1} ,", col.DbColumnName, TableColumn.GetDBValue(itm.KeyType, itm.Key));

                    //if ((itm.KeyType == ColumnTypes.String
                    //        || itm.KeyType == ColumnTypes.SysDate
                    //        || itm.KeyType == ColumnTypes.NepaliDate)
                    //        || TableColumn.GetDBValue(itm.KeyType, itm.Key).Trim().Length > 0)
                    //{
                    //    queryBulilder.AppendFormat(" {0} = {1} ,", col.DbColumnName, TableColumn.GetDBValue(itm.KeyType, itm.Key));
                    //}

                    if (TableColumn.GetDBValue(itm.KeyType, itm.Key).Trim().Length > 0)
                    {
                        if (itm.KeyType == ColumnTypes.String
                          || itm.KeyType == ColumnTypes.SysDate
                          || itm.KeyType == ColumnTypes.NepaliDate)
                        {
                            queryBulilder.AppendFormat(" {0} = {1} ,", col.DbColumnName, TableColumn.GetDBValue(itm.KeyType, itm.Key));
                        }
                        else
                        {
                            queryBulilder.AppendFormat(" {0} = {1} ,", col.DbColumnName, TableColumn.GetDBValue(itm.KeyType, itm.Key));
                        }
                    }

                }
            }
            else
            {
                if (col.Control == null)
                    queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, col.DBValue);
                else
                    if (col.Control is VtextBox)
                    {
                        queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, col.DBValue.Trim() == "" ? "NULL" : col.DBValue);

                    }
                    else if (col.Control is Label)
                    {
                        queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, col.DBValue.Trim() == "" ? "NULL" : col.DBValue);

                    }
                    else if (col.Control is TextBox)
                    {
                        //=========================================================
                        TextBox pwd = (TextBox)col.Control;
                        if (pwd.UseSystemPasswordChar) // UseSystemPasswordChar true means password field
                        {
                            clsEncryptorDecryptor enc = new clsEncryptorDecryptor();
                            string Password = string.Empty; //set password text box blank..

                            Password = enc.Encrypt(pwd.Text); //User Type password Encryping..
                            queryBulilder.AppendFormat(" {0} = '{1}',", col.DbColumnName, Password.ToString().Replace("'", "''")); //saving and single quot replace..
                        }
                        else
                        {
                            if ((col.Type == ColumnTypes.String
                                || col.Type == ColumnTypes.SysDate
                                || col.Type == ColumnTypes.NepaliDate)
                                || col.DBValue.Trim().Length > 0)
                            {
                                queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, col.DBValue);
                            }
                        }
                        //=====================================================================
                    }
                    else if (col.Control is NumericUpDown)
                    {
                        queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, col.DBValue.Trim() == "" ? "NULL" : col.DBValue);
                    }
                    else if (col.Control is DateTimePicker)
                    {
                        DateTimePicker dtp = (DateTimePicker)col.Control;
                        if (col.DBValue.Trim() == "" | col.DBValue == null | !dtp.Checked)
                        {
                            queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, "NULL");
                        }
                        else
                        {
                            queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, col.DBValue);
                        }
                    }
                    else if (col.Control is CrudeFx.NepaliDate.NepaliDatePicker)
                    {
                        CrudeFx.NepaliDate.NepaliDatePicker dtpNep = (CrudeFx.NepaliDate.NepaliDatePicker)col.Control;
                        if (col.DBValue.Trim() == "" | col.DBValue == null)
                        {
                            queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, "NULL");
                        }
                        else
                        {
                            queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, col.DBValue);
                        }
                    }
                    else if (col.Control is Panel)
                    {
                        Panel pnl = (Panel)col.Control;
                        if (col.DBValue.Trim() == "" | col.DBValue == null)
                        {
                            queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, "NULL");
                        }
                        else
                        {
                            queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, col.DBValue);
                        }
                    }
                    else if (col.Control is CheckBox)
                    {
                        queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, col.DBValue);
                    }
                    else
                    {
                        queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, col.DBValue);
                    }
                //queryBulilder.AppendFormat(" {0} = {1},", col.DbColumnName, col.DBValue);
            }
        }
        public override bool LoadData()
        {
            bool status = false;
            base.LoadData();

            if (!GenerateSelectSQL())
            {
                DisplayErrorMessage("Errro while generating Select SQL.");
                return false;
            }

            ExecuteSelectSQL();

            status = LoadDataInControls();
            if (FirstControl != null)
            {
                this.FirstControl.Focus(); //set focus is first contrls
                this.FirstControl.Select();
                // Dhiraj this.FirstControl.BackColor = System.Drawing.SystemColors.Info;

            }
            return status;
        }

        public virtual bool LoadDataInControls()
        {
            bool status = false;

            if (_formDataTable != null && _formDataTable.Rows.Count > 0)
            {
                foreach (TableColumn col in ColumnList)
                {
                    if (col.Control == null)
                        continue;

                    DataRow row = _formDataTable.Rows[0];
                    if (col.Control is VtextBox)
                    {
                        string v = Bsoft.Common.Conversion.ToString(row, col.DbColumnName);
                        ((VtextBox)col.Control).Value = v;
                    }
                    else if (col.Control is TextBox)
                    {
                        col.Control.Text = Conversion.ToString(row, col.DbColumnName);
                    }
                    else if (col.Control is Label)
                    {
                        col.Control.Text = Conversion.ToString(row, col.DbColumnName);
                    }
                    else if (col.Control is Bsoft.Controls.lblTextBox)
                    {
                        col.Control.Text = Conversion.ToString(row, col.DbColumnName);
                    }
                    else if (col.Control is System.Windows.Forms.PictureBox)
                    {

                        try
                        {
                            //Get image data from gridview column.
                            byte[] imageData = (byte[])row[col.DbColumnName];

                            //Initialize image variable
                            Image newImage;
                            //Read image data into a memory stream
                            using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                            {
                                ms.Write(imageData, 0, imageData.Length);

                                //Set image variable value using memory stream.
                                newImage = Image.FromStream(ms, true);
                            }

                            //set picture
                            ((PictureBox)col.Control).Image = newImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                    else if (col.Control is NumericUpDown)
                    {
                        col.Control.Text = Conversion.ToString(row, col.DbColumnName);
                    }
                  
                    else if (col.Control is DateTimePicker)
                    {
                        string tmp = Conversion.ToString(row, col.DbColumnName);
                        if (tmp != "")
                        {

                            if (tmp.Length == 8)
                            {
                                DateTime dt = new DateTime(tmp.Substring(0, 4).ToInt(), tmp.Substring(4, 2).ToInt(), tmp.Substring(6, 2).ToInt());
                                ((DateTimePicker)col.Control).Value = dt;
                            }
                            else
                            {
                                ((DateTimePicker)col.Control).Text = Convert.ToDateTime(tmp).ToString(Configuration.DATE_DISPLAY_FORMAT);
                            }
                        }
                    }
                    else if (col.Control is NepaliDatePicker)
                    {
                        try
                        {
                            string val = Conversion.ToString(row, col.DbColumnName);
                            if (val.IndexOf("/") < 1)
                            {
                                val = val.Substring(0, 4) + "/" + val.Substring(4, 2) + "/" + val.Substring(6, 2);
                            }


                            if (CrudeFx.NepaliDate.NepaliDate.IsValidDate(val))
                            {

                                ((CrudeFx.NepaliDate.NepaliDatePicker)col.Control).Value = new NepaliDate(val);
                                //  col.Control.Text = Conversion.ToString(row, col.DbColumnName);
                                col.Control.Enabled = true;
                            }
                            else
                            {
                                col.Control.Enabled = false;
                            }
                        }
                        catch
                        {
                            throw;
                        }
                    }
                    else if (col.Control is ComboBox)
                    {
                        SelectComboValue((ComboBox)col.Control, Conversion.ToString(row, col.DbColumnName));
                    }
                    else if (col.Control is Bsoft.Controls.lblComboBox)
                    {
                        SelectComboValue(((Bsoft.Controls.lblComboBox)col.Control).cmbBox, Conversion.ToString(row, col.DbColumnName));
                    }
                    else if (col.Control is CheckBox)
                    {
                        if (Conversion.ToString(row, col.DbColumnName) == "1")
                        {
                            ((CheckBox)col.Control).Checked = true;
                        }
                        else
                        {
                            ((CheckBox)col.Control).Checked = false;
                        }

                    }
                    else
                    {
                        col.Control.Text = Conversion.ToString(row, col.DbColumnName);
                        DisplayErrorMessage("No features for this control"); //No fetarues for this control
                    }
                }

                DataGeneral.DisposeObject(_formDataTable);

                status = true;
            }
            return status;
        }

        /// <summary>
        /// warning: this Function is do not used
        /// </summary>Check whether the new field already exists in database
        /// <param name="tableName"></param>
        /// <param name="DataBaseColName"></param>
        /// <param name="CheckField"></param>
        public bool DataAlreadyInTable(string TblName, string dBColName, Control newField)
        {

            if (TblName.Length == 0)
                throw new Exception("Must Pass Table Name");
            if (dBColName.Length == 0)
                throw new Exception("Must Pass DataBase ColumnName");

            StringBuilder sqlNew = new StringBuilder();
            sqlNew.Remove(0, sqlNew.Length);
            sqlNew.Append("SELECT 1");
            sqlNew.Append("\nFROM");
            sqlNew.AppendFormat("\n\t{0}", TblName);
            sqlNew.Append("\nWHERE");
            sqlNew.AppendFormat("\n\t{0}='{1}'", dBColName, newField.Text.Replace("'", "''"));

            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sqlNew.ToString());
            if (dt.Rows.Count > 0)
            {
                //   MsgBoxNepali.Show("pNn]lvt tYofª\\s k|of]u e};s]sf] % È ", MessageBoxButtons.OK);

                MessageBox.Show("pNn]lvt tYofª\\s k|of]u e};s]sf] % È ", "", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Pass the Db table name & Unique column name and Primary key pass always 
        /// </summary>
        /// <param name="TblName"></param>
        /// <param name="dBColName"></param>
        /// <param name="DbPrimaryKeyIDColumn"></param>
        /// <param name="newField"></param>
        /// <returns></returns>
        public bool DataAlreadyInTable(string TblName, string dBColName, string DbPrimaryKeyIDColumn, Control newField)
        {
            if (TblName.Length == 0)
                throw new Exception("Must Pass Table Name");
            if (dBColName.Length == 0)
                throw new Exception("Must Pass DataBase ColumnName");

            StringBuilder sqlNew = new StringBuilder();
            sqlNew.Remove(0, sqlNew.Length);
            sqlNew.Append("SELECT 1");
            sqlNew.Append("\nFROM");
            sqlNew.AppendFormat("\n\t{0}", TblName);
            sqlNew.Append("\nWHERE");
            sqlNew.AppendFormat("\n\t{0}='{1}'", dBColName, newField.Text.Replace("'", "''"));

            if (FormType == FormTypes.EditForm)
            {
                sqlNew.AppendFormat("AND {0} <> {1}", DbPrimaryKeyIDColumn, PrimaryKeyValue);
            }

            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sqlNew.ToString());
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("pNn]lvt tYofª\\s k|of]u e};s]sf] % È ", "", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Parameter MessageOff means message is not display only return true if data exists in tabes
        /// For any entry form validation checking without Message Dispaly
        /// </summary> this Function use In Bilding Permits
        /// <param name="e"></param>

        public bool DataAlreadyInTable(string TblName, string dBColName, string DbPrimaryKeyIDColumn, Control newField, bool MessageOff)
        {
            if (TblName.Length == 0)
                throw new Exception("Must Pass Table Name");
            if (dBColName.Length == 0)
                throw new Exception("Must Pass DataBase ColumnName");

            StringBuilder SQL = new StringBuilder();
            SQL.Remove(0, SQL.Length);
            SQL.Append("SELECT 1");
            SQL.Append("\nFROM");
            SQL.AppendFormat("\n\t{0}", TblName);
            SQL.Append("\nWHERE");
            SQL.AppendFormat("\n\t{0}='{1}'", dBColName, newField.Text.Replace("'", "''"));

            if (FormType == FormTypes.EditForm)
            {
                SQL.AppendFormat("AND {0} <> {1}", DbPrimaryKeyIDColumn, PrimaryKeyValue);
            }

            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            if (dt.Rows.Count > 0)
            {
                if (!MessageOff)
                {
                    MessageBox.Show("pNn]lvt tYofª\\s k|of]u e};s]sf] % È ", "", MessageBoxButtons.OK);
                }
                return true;
            }
            return false;
        }

        #endregion

        #region Event Handlers
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }

        protected override void OnActivated(EventArgs e)
        {
            if (IsFirstTime)
            {
                if (FormType == FormTypes.EditForm)
                {
                    this.Refresh();
                    LoadData();
                }
            }
            base.OnActivated(e);
            IsFirstTime = false;
        }

        /// <summary>
        /// Any Forms short cut keys.. 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            // base.OnKeyDown(e);
            if (e.KeyCode == Keys.Enter)
            {
                if (ActiveControl is RoundRectButton)
                {
                    //Nothing to do
                    //SendKeys.Send("{HOME}");
                    //ActiveControl.MouseHover = ((System.Drawing.Image)(resources.GetObject("EditButton.ButtonPressedImage")));
                    //this.EditButton.ButtonPressedImage = ((System.Drawing.Image)(resources.GetObject("EditButton.ButtonPressedImage")));
                }
                else if (ActiveControl is TextBox)
                {
                    TextBox MultiLine = (TextBox)ActiveControl;
                    if (MultiLine.Multiline)
                    {
                        return; //do noing
                    }
                    else
                    {
                        SendKeys.Send("{TAB}");
                    }
                }
                else if (ActiveControl is menuView)
                {
                    return;
                }
                else
                {

                    SendKeys.Send("{TAB}");
                }
            }
            //this keys Returning Any form Active Control Name and Form Name for Programmers..
            else if (e.Modifiers == Keys.Control && e.KeyValue == 192)
            {
                MessageBox.Show(this.Name + ": Control Name : " + this.ActiveControl.Name, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //this function working for all the forms required Overload the Save...
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                if (IsQuickSaveKey) //Atl + s hot keys not required the Entry Form properties IsQuickSaveKey= false set..
                {
                    base.IsSaveKey = true; //Compulsory required do not change without understanding...
                    Save();
                    base.IsSaveKey = false;//Compulsory required do not change without understanding...
                }
            }
            else if (e.KeyCode == Keys.Tab)
            {
                if (ActiveControl is TextBox)
                {
                    TextBox TxtBox = (TextBox)ActiveControl;
                    TxtBox.SelectAll(); //Text higlighted..
                }
            }
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (ActiveControl is TextBox || ActiveControl is ComboBox)
            {
                ActiveControl.BackColor = System.Drawing.SystemColors.Info;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            //base.OnLeave(e);
            if (ActiveControl is TextBox || ActiveControl is ComboBox)
            {
                ActiveControl.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        public override bool Focused
        {
            get
            {
                return base.Focused;
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //disabled  due to every entry form condition id differents
            //if (e.KeyChar == 19)//Ctrl+S
            //{
            //    Save(); 
            //}
            //Key board events
            base.OnKeyPress(e);
            if (e.KeyChar == 1) //Ctrl + A for Text box text selected and deleted...
            {
                if (ActiveControl is TextBox)
                {
                    TextBox TxtBox = (TextBox)ActiveControl;
                    TxtBox.SelectAll(); //Text higlighted..
                }
            }
        }

        #endregion
    }
}


