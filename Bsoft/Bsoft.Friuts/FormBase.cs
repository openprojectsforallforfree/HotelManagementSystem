using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

//using TPPIMS.AppClass;
using Bsoft.Controls;
using Bsoft;

using Bsoft.Common;
using Bsoft.Data;
using Bsoft.Common.Language;
using Bsoft.Forms;
using System.Reflection;
namespace Friuts
{
    public enum FormTypes
    {
        /// <summary>
        /// Will perform on only Inserting of new data.
        /// </summary>
        EntryForm = 0,
        /// <summary>
        /// Will perform on only Editing of existing data.
        /// </summary>
        EditForm,
        /// <summary>
        /// For listing or records. Can perform delete of data too.
        /// </summary>
        ListingForm,
        SelectionForm,
        MultipleSelect,
        Report,
        Others
    }

    [System.ComponentModel.DesignerCategory("code")]
    public class FormBase : Bsoft.Design.FormDesginBase
    {
        #region Member Variables


        public string _insertSQL = string.Empty;
        public string _updateSQL = string.Empty;
        public string _deleteSQL = string.Empty;
        public string _selectSQL = string.Empty;

        private TableColumnCollection _columnList = new TableColumnCollection();
        private string _confirmationMsg = string.Empty;
        private FormTypes _formType = FormTypes.Others;
        protected string _tableName = string.Empty;
        private object _primaryKeyValue = new object();
        public StringBuilder queryBulilder = new StringBuilder();
        public StringBuilder queryBulilder2 = new StringBuilder();

        protected DataTable _formDataTable = null;
        private bool _isSaveKey = false;
        public bool ConfirmationRequired = true;
        #endregion

        #region Constructor
        public FormBase(FormTypes formType, string tableName, string connectionString)
            : base()
        {
            //  BackgroundImage = Properties.Resources.body ;

            _formType = formType;
            _tableName = tableName;


        }
        public FormBase()
            : this(FormTypes.Others, string.Empty, string.Empty)
        {
        }

        public FormBase(string connectionString)
            : this(FormTypes.Others, string.Empty, connectionString)
        {
        }

        public FormBase(FormTypes formType, string tableName)
            : this(formType, tableName, string.Empty)
        {
        }

        #endregion

        #region Properties

        public string InsertSQL
        {
            get { return _insertSQL; }
            set { _insertSQL = value; }
        }


        public string UpdateSQL
        {
            get { return _updateSQL; }
            set { _updateSQL = value; }
        }


        public string DeleteSQL
        {
            get { return _deleteSQL; }
            set { _deleteSQL = value; }
        }


        public string SelectSQL
        {
            get { return _selectSQL; }
            set { _selectSQL = value; }
        }


        public TableColumnCollection ColumnList
        {
            get { return _columnList; }
            set { _columnList = value; }
        }


        public string ConfirmationMsg
        {
            get { return _confirmationMsg; }
            set { _confirmationMsg = value; }
        }


        public virtual string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }


        public FormTypes FormType
        {
            get { return _formType; }
            set
            {
                _formType = value;
                if (value == FormTypes.MultipleSelect)
                {
                    MakeMultiSelect();
                }
            }
        }


        public virtual void MakeMultiSelect() { }

        public object PrimaryKeyValue
        {
            get { return _primaryKeyValue; }
            set { _primaryKeyValue = value; }
        }


        public DataTable FormDataTable
        {
            get { return _formDataTable; }
            set { _formDataTable = value; }
        }



        /// <summary>
        /// this Property is Used for Shortcut keys ALT + S..
        /// </summary>
        public bool IsSaveKey
        {
            get { return _isSaveKey; }
            set { _isSaveKey = value; }
        }

        private Control _FirstControl = null;
        /// <summary>
        /// Entry Form When user Press Ctrl + S then Focus move the first controls
        /// </summary>
        public Control FirstControl
        {
            get
            {
                return _FirstControl;
            }
            set
            {

                _FirstControl = value;
                if (_FirstControl is bsoftcontrols.fsButton)
                {
                    ((bsoftcontrols.fsButton)_FirstControl).ThemeColor = _FocusButoonTheme;
                }
                _FirstControl.BackColor = _Focuscolor;
                _FirstControl.Focus();
                _FirstControl.Select();
            }
        }

        private bool _isFirstTime = true;

        public bool IsFirstTime
        {
            get { return _isFirstTime; }
            set { _isFirstTime = value; }
        }

        protected override void OnActivated(EventArgs e)
        {
            _isFirstTime = false;
            base.OnActivated(e);
        }

        #endregion

        #region Methods
        /// <summary>
        /// Checks if the entered data are valid or not.
        /// </summary>
        /// <returns>Returns true if valid else returns false.</returns>
        public virtual bool ValidateData()
        {
            bool isValid = true;
            switch (_formType)
            {
                case FormTypes.EntryForm:
                case FormTypes.EditForm:
                    isValid = _columnList.AreAllFieldsValid();
                    break;
                default:
                    isValid = true;
                    break;

            }
            return isValid;
        }

        /// <summary>
        /// Asks the user for the confirmation if the specific task is to be performed or not.
        /// </summary>
        /// <returns>Returns true or false.</returns>
        public virtual bool GetConfirmation()
        {
            if (!ConfirmationRequired)
            {
                return true;
            }
            //set the confirmation message to be displayed to the user.
            //if custom confirmation message exists then display the custom confirmation message else use the default.
            string msg = _confirmationMsg;
            if (msg.Trim().Length == 0)
            {
                if (!IsSaveKey)
                {
                    if (_formType == FormTypes.EntryForm)
                    {
                        msg = Messeges.Save_Msg;  //do you want to save message dis..
                    }
                    else if (_formType == FormTypes.EditForm)
                    {
                        msg = Messeges.Edit_Msg; //edited data save
                    }
                    else
                    {
                        //msg = string.Format("Do you want to perform the task : {0} ? ", _formType.ToString());
                        msg = Messeges.Delete_Msg;
                    }
                }
            }

            //ask the confirmation with the use.
            //if user clicks on YES  then return true.

            if (MessageBoxMy.Show(msg, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }
            //if (MessageBox.Show(ActiveForm, msg, Application.ProductName
            //    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    return true;
            //}
            return false;
        }
        /// <summary>
        /// Generates the where clause required for Select query.
        /// </summary>
        /// <returns>Returns the where clause.</returns>
        public virtual string GetWhereClauseForSelect()
        {
            return string.Empty;
        }

        /// <summary>
        /// Generates the where clause required for Update and Delete.
        /// </summary>
        /// <returns>Returns the where clause.</returns>
        public virtual string GetWhereClauseForUpdate()
        {
            //first clear the string builder.
            queryBulilder2.Remove(0, queryBulilder2.Length);

            queryBulilder2.Append(" WHERE ");
            bool isFirst = true;
            //checking for the primary key using which data is to be deleted.
            foreach (TableColumn col in ColumnList)
            {
                if (col.IsPrimaryKeyColumn)
                {
                    if (!isFirst)
                        queryBulilder2.Append(" AND");
                    isFirst = false;
                    queryBulilder2.AppendFormat(" {0} = {1} ", col.DbColumnName, TableColumn.GetDBValue(col.Type, PrimaryKeyValue));
                }
            }
            return queryBulilder2.ToString();
        }

        /// <summary>
        /// Generates the where clause required for Delete.
        /// </summary>
        /// <returns>Returns the where clause.</returns>
        public virtual string GetWhereClauseForDelete()
        {
            return string.Empty;
        }
        /// <summary>
        /// Generates the SQL to be executed into the DB for performing CRUD operation.
        /// </summary>
        /// <returns>Returns true if SQL is created else false.</returns>
        public virtual bool GenerateSelectSQL()
        {
            _selectSQL += GetWhereClauseForSelect();

            return true;
        }

        /// <summary>
        /// Checks if all the field values of compulsory field are set or not.
        /// </summary>
        /// <returns>Returns true or false.</returns>
        //public bool CheckCompulsoryField()
        //{
        //    return true;
        //}

        /// <summary>
        /// Performs the Insert operation.
        /// </summary>
        /// <returns></returns>
        public virtual bool GenerateInsertSQL()
        {
            return true;
        }

        /// <summary>
        /// Performs the update operation.
        /// </summary>
        /// <returns></returns>
        public virtual bool GenerateUpdateSQL()
        {
            _updateSQL += " " + GetWhereClauseForUpdate();
            return true;
        }

        public virtual bool GenerateDeleteSQL()
        {
            //_deleteSQL = string.Empty;
            //queryBulilder.Remove(0, queryBulilder.Length);

            //queryBulilder.AppendFormat("DELETE FROM {0} (1)", TableName, GetWhereClauseForUpdate());
            //_deleteSQL = queryBulilder.ToString();
            return true;
        }

        public virtual bool LoadData()
        {
            return true;
        }

        public virtual DataTable ExecuteSelectSQL()
        {

            try
            {
                DataGeneral.DisposeObject(_formDataTable);
                if (GlobalResources.SelectDBConnection.Open())
                {
                    _formDataTable = GlobalResources.SelectDBConnection.ExecuteDataTable(_selectSQL);
                }
            }
            catch (Exception ex)
            {
                LogTrace.WriteErrorLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex.ToString());
            }
            finally
            {
                //_con.Close();
            }

            return _formDataTable;
        }

        public bool PeformDML(ref string commandText)
        {
            bool status = false;

            try
            {
                if (GlobalResources.SelectDBConnection.Open())
                {
                    if (GlobalResources.SelectDBConnection.ExecuteNonQuery(commandText) > 0)
                        status = true;
                    else
                        status = false;
                }
            }
            catch (Exception ex)
            {
                MessageBoxMy.Show(ex.Message);
            }
            finally
            {
                //_con.Close();
            }

            return status;
        }

        //public bool ConnectDB()
        //{
        //    if (GlobalResources.SelectDBConnection == null)
        //        _con = new DBConnect(_connectionString);
        //    else
        //    {
        //        if (_con.ConnectionString.Trim().Length == 0)
        //            _con.ConnectionString = _connectionString;
        //    }
        //    if (!_con.IsConnected)
        //        return _con.Open(_connectionString);
        //    return _con.IsConnected;
        //}
        public virtual bool Save()
        {
            return Save(true);
        }
        /// <summary>
        /// Saves the data and return the status.
        /// If all tasks are performed without any error then returns true.
        /// </summary>
        /// <returns>Returns true if the data is saved successfully.</returns>
        /// 
        ///Three types of save to be added by -Dhiraj
        ///1.Save and close form
        ///2.Save and continue with save data(pk) - esp use ful for long data entry forms
        ///3.Save and get new data (new pk)
        ///In all cases get confirmation .
        public virtual bool Save(bool closeForm)
        {


            bool status;
            try
            {
                status = basicSave();//validates generates sql saves
            }
            catch
            {
                throw;
            }
            // add more records or close

            if (status)
            {
                //use for ask Message Add More Records case..
                if (!IsSaveKey)
                {//change by dhiraj 
                    //earlier code
                    //DialogResult = DialogResult.OK;
                    //if (closeForm)
                    //    this.Hide();
                    //new code

                    if (closeForm)
                    {
                        DialogResult = DialogResult.OK;
                        this.Hide();
                    }
                }
                else
                {
                    addmorerecord(closeForm);
                }
            }
            return status;
        }

        /// <summary>
        /// Saves the data and return the status.
        /// If all tasks are performed without any error then returns true.
        /// </summary>
        /// <returns>Returns true if the data is saved successfully.</returns>
        public virtual bool Save_old(bool closeForm)
        {
            bool status = true;
            //1st step Check for compulsory field and validation.
            if (!ValidateData())
            {
                DisplayErrorMessage(_columnList.ErrorMsg);

                return false;
            }

            //Step 2: Ask confirmation
            //Step 2:1 Ask Add More Records 
            DialogResult Add_More_Record = DialogResult.None;
            if (!IsSaveKey)
            {
                if (!GetConfirmation())
                {
                    return false;
                }
            }
            else
            {
                string AskMsg = Messeges.Add_More_Record_Msg;
                Add_More_Record = MessageBox.Show(AskMsg, "Message", MessageBoxButtons.YesNoCancel);

                if (Add_More_Record == DialogResult.Ignore)
                {
                    return false;
                }
            }
            //Step 3 Generate SQL
            StringBuilder msg = new StringBuilder();

            if (_formType == FormTypes.EntryForm
                || _formType == FormTypes.EditForm)
            {
                if (_formType == FormTypes.EntryForm)
                    status = GenerateInsertSQL();

                else
                    status = GenerateUpdateSQL();

                if (!status)
                {
                    //MessageBox.Show(ActiveForm, "Problem while generating sql.", Application.ProductName);
                    msg.Remove(0, msg.Length);
                    msg.Append("sDKo'^<df pTkGg k|fljlws ;d:ofn] ubf{ of] tYofÍ");
                    msg.Append("\n;'<lIft ug{ ;lsPg M s[kof k'gŸ k|of; ug'{xf];\\ M");
                    MessageBox.Show(msg.ToString());
                    //MsgBoxNepali.Show(msg.ToString(), MessageBoxButtons.OK);
                    return false;
                }
            }
            else
            {
                MessageBox.Show(ActiveForm, "Form type must be either Entry or Edit.", Application.ProductName);
                // MsgBoxNepali.Show(@"of] ;'ljwf s]jn k|ljli^ < ;'wf< ug]{ :""yfgdf dfq % M", MessageBoxButtons.OK);
                return false;
            }

            //step 4: save the data
            if (_formType == FormTypes.EntryForm)
            {
                status = PeformDML(ref _insertSQL);
            }
            else
            {
                status = PeformDML(ref _updateSQL);
            }

            if (status)
            {
                //use for ask Message Add More Records case..
                if (!IsSaveKey)
                {//change by dhiraj 
                    //earlier code
                    //DialogResult = DialogResult.OK;
                    //if (closeForm)
                    //    this.Hide();

                    //new code
                    if (closeForm)
                    {
                        DialogResult = DialogResult.OK;
                        this.Hide();
                    }
                    else
                    {
                        //DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (Add_More_Record == DialogResult.Yes)
                    {
                        //first Records Save add After Next Records add
                        DialogResult = DialogResult.None;
                        foreach (TableColumn col in ColumnList)
                        {
                            if (col.Control == null)
                                continue;
                            if (col.Control is TextBox)
                            {
                                //if (col.Control.Visible == true || col.Control.Enabled == true || col.Control.Text.Trim().ToUpper() !="DEFAULT")
                                //Be carefull.
                                if (col.Control.Visible == true)
                                {
                                    if (col.Control.Tag == null)
                                    {
                                        col.Control.Text = "";
                                    }
                                    else if (col.Control.Tag.ToString() != "DEFAULT")
                                    {
                                        col.Control.Text = "";
                                    }
                                }
                            }
                            else if (col.Control is VtextBox )
                            {
                                if (col.Control.Visible == true)
                                {
                                    if (col.Control.Tag == null)
                                    {
                                        col.Control.Text = "0";
                                    }
                                    else if (col.Control.Tag.ToString() != "DEFAULT")
                                    {
                                        col.Control.Text = "0";
                                    }
                                }
                            }
                           
                            else if (col.Control is CheckedListBox)
                            {
                                CheckedListBox CheckList = (CheckedListBox)col.Control;
                                for (int i = 0; i < CheckList.Items.Count; i++)
                                {
                                    CheckList.SetItemChecked(i, false);
                                }
                            }
                        }

                        //set form type Entry..
                        FormType = FormTypes.EntryForm;
                        this.FormType = FormTypes.EntryForm;
                        PrimaryKeyValue = 0; //set Primarykeyvalue zero entry purpose
                        if (FirstControl != null)
                        {
                            this.FirstControl.Focus(); //set focus is first contrls
                            this.FirstControl.Select();
                            //  this.FirstControl.BackColor = System.Drawing.SystemColors.Info;

                        }
                    }
                    else if (Add_More_Record == DialogResult.No)
                    {
                        DialogResult = DialogResult.OK;
                        if (closeForm)
                            this.Hide();
                    }
                }
            }
            else
            {
                //  MessageBox.Show(ActiveForm, "Error while executing the sql.", Application.ProductName);
                //msg.Remove(0, msg.Length);
                //msg.Append("sDKo'^<df pTkGg k|fljlws ;d:ofn] ubf{ of] tYofÍ");
                //msg.Append("\n;'<lIft ug{ ;lsPg M s[kof k'gŸ k|of; ug'{xf];\\ M");
                //MsgBoxNepali.Show(msg.ToString(), MessageBoxButtons.OK);
            }
            return status;
        }

        public virtual bool Delete()
        {
            bool status = false;
            //Step 1: Get confirmation from user
            if (!GetConfirmation())
            {
                return false;
            }

            //step 2: Generate Delete sql
            GenerateDeleteSQL();

            //step 3: delete the data by executing the sql.
            status = PeformDML(ref _deleteSQL);

            //if (status)
            //{
            //    //DialogResult = DialogResult.OK;
            //    //this.Hide();
            //}
            //else
            //    DisplayErrorMessage("Error while executing the sql.");


            return status;
        }



        public void DisplayErrorMessage(string msg)
        {
            if (_formType == FormTypes.EditForm || _formType == FormTypes.EntryForm)
            {
                //MsgBoxNepali.Show(msg, MessageBoxButtons.OK);
                //MessageBox.Show(ActiveForm, msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBoxMy.Show(ActiveForm, msg, MessageBoxButtons.OK);
            }
            else
            {
                MessageBoxMy.Show(ActiveForm, msg, MessageBoxButtons.OK);
                //MessageBox.Show(ActiveForm, msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DialogResult GetConfirmation(string msg)
        {
            return MessageBox.Show(ActiveForm, msg, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        #endregion

        #region EventHandlers
        protected override void OnKeyPress(KeyPressEventArgs e)
        {//Key board events
            // MessageBox.Show(((int)e.KeyChar).ToString ());//To find

            if (e.KeyChar == 27)//Ctrl+N
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }





        #endregion

        #region Combo Related
        public bool SelectComboValue(ComboBox cbo, string key)
        {
            if (cbo.DropDownStyle == ComboBoxStyle.DropDown)
            {
                cbo.Text = key;
                return true;
            }

            int indx = -1;
            indx = GetComboIndex(cbo, key);
            if (indx > -1)
            {
                cbo.SelectedIndex = indx;
                return true;
            }
            return false;
        }

        public int GetComboIndex(ComboBox cbo, string key)
        {
            int indx = -1;


            foreach (ComboItem cboItem in cbo.Items)
            {
                indx++;
                if (cboItem.Key.Equals(key.Trim()))
                {
                    return indx;
                }
            }
            return -1;
        }
        #endregion


        DialogResult Add_More_Record = DialogResult.None;



        private bool basicSave()
        {
            bool status = false;
            //1st step Check for compulsory field and validation.
            if (!ValidateData())
            {
                DisplayErrorMessage(_columnList.ErrorMsg);
                return false;
            }

            //Step 2: Ask confirmation
            //Step 2:1 Ask Add More Records 

            if (!IsSaveKey)
            {
                if (!GetConfirmation())
                {
                    return false;
                }
            }
            else
            {
                string AskMsg = Messeges.Add_More_Record_Msg;
                //Add_More_Record = MessageBox.Show(AskMsg, "Message", MessageBoxButtons.YesNoCancel);
                Add_More_Record = MessageBoxMy.Show(AskMsg, MessageBoxButtons.YesNo);
                if (Add_More_Record == DialogResult.No) { return false; }
            }
            //Step 3 Generate SQL
            StringBuilder msg = new StringBuilder();

            if (_formType == FormTypes.EntryForm
                || _formType == FormTypes.EditForm)
            {
                if (_formType == FormTypes.EntryForm)
                    status = GenerateInsertSQL();

                else
                    status = GenerateUpdateSQL();

                if (!status)
                {
                    //MessageBox.Show(ActiveForm, "Problem while generating sql.", Application.ProductName);
                    msg.Remove(0, msg.Length);
                    msg.Append("sDKo'^<df pTkGg k|fljlws ;d:ofn] ubf{ of] tYofÍ");
                    msg.Append("\n;'<lIft ug{ ;lsPg M s[kof k'gŸ k|of; ug'{xf];\\ M");
                    MessageBox.Show(msg.ToString());
                    //MsgBoxNepali.Show(msg.ToString(), MessageBoxButtons.OK);
                    return false;
                }
            }
            else
            {
                MessageBox.Show(ActiveForm, "Form type must be either Entry or Edit.", Application.ProductName);
                // MsgBoxNepali.Show(@"of] ;'ljwf s]jn k|ljli^ < ;'wf< ug]{ :""yfgdf dfq % M", MessageBoxButtons.OK);
                return false;
            }

            //step 4: save the data
            if (_formType == FormTypes.EntryForm)
            {
                status = PeformDML(ref _insertSQL);
            }
            else
            {
                status = PeformDML(ref _updateSQL);
            }
            return status;
        }

        private void addmorerecord(bool closeForm)
        {

            if (Add_More_Record == DialogResult.Yes)
            {
                //first Records Save add After Next Records add
                DialogResult = DialogResult.None;
                foreach (TableColumn col in ColumnList)
                {
                    if (col.Control == null)
                        continue;

                    if (col.Control is VtextBox)
                    {
                        if (col.Control.Visible == true)
                        {
                            if (col.Control.Tag == null)
                            {
                                col.Control.Text = "";
                            }
                            else if (col.Control.Tag.ToString() != "DEFAULT")
                            {
                                col.Control.Text = "";
                            }
                        }
                    }
                    else if (col.Control is TextBox)
                    {
                        //if (col.Control.Visible == true || col.Control.Enabled == true || col.Control.Text.Trim().ToUpper() !="DEFAULT")
                        //Be carefull.
                        if (col.Control.Visible == true)
                        {
                            if (col.Control.Tag == null)
                            {
                                col.Control.Text = "";
                            }
                            else if (col.Control.Tag.ToString() != "DEFAULT")
                            {
                                col.Control.Text = "";
                            }
                        }
                    }
                    else if (col.Control is NumericUpDown)
                    {
                        if (col.Control.Visible == true)
                        {
                            if (col.Control.Tag == null)
                            {
                                col.Control.Text = "0";
                            }
                            else if (col.Control.Tag.ToString() != "DEFAULT")
                            {
                                col.Control.Text = "0";
                            }
                        }
                    }
                    else if (col.Control is VtextBox)
                    {
                        if (col.Control.Visible == true)
                        {
                            if (col.Control.Tag == null)
                            {
                                col.Control.Text = "";
                            }
                            else if (col.Control.Tag.ToString() != "DEFAULT")
                            {
                                col.Control.Text = "";
                            }
                        }
                    }
                    else if (col.Control is CheckedListBox)
                    {
                        CheckedListBox CheckList = (CheckedListBox)col.Control;
                        for (int i = 0; i < CheckList.Items.Count; i++)
                        {
                            CheckList.SetItemChecked(i, false);
                        }
                    }
                    else if (col.Control is DateTimePicker)
                    {

                    }
                    else if (col.Control is Panel)
                    {
                        RadioButton rb = new RadioButton();
                        rb.TabIndex = 10000;
                        foreach (Control ct in ((Panel)col.Control).Controls)
                        {
                            if (ct is RadioButton)
                            {
                                if (ct.TabIndex < rb.TabIndex)
                                {
                                    rb = (RadioButton)ct;
                                }
                            }
                        }
                        rb.Checked = true;
                    }
                    else if (col.Control is CheckBox)
                    {
                        if (col.Control.Visible == true)
                        {
                            if (col.Control.Tag == null)
                            {
                                ((CheckBox)col.Control).Checked = false;
                            }
                            else if (col.Control.Tag.ToString() != "DEFAULT")
                            {
                                ((CheckBox)col.Control).Checked = false;
                            }
                        }
                    }

                    else if (col.Control is ComboBox)
                    {
                        if (col.Control.Visible == true)
                        {

                            ((ComboBox)col.Control).SelectedIndex = -1;

                        }
                    }

                    else
                    {

                    }
                }

                //set form type Entry..
                FormType = FormTypes.EntryForm;
                this.FormType = FormTypes.EntryForm;
                PrimaryKeyValue = 0; //set Primarykeyvalue zero entry purpose
                if (FirstControl != null)
                {
                    this.FirstControl.Focus(); //set focus is first contrls
                    this.FirstControl.Select();
                    // this.FirstControl.BackColor = System.Drawing.SystemColors.Info;

                }
            }
            else if (Add_More_Record == DialogResult.No)
            {
                //old code
                DialogResult = DialogResult.OK;
                if (closeForm)
                    this.Hide();
                //new code
                if (closeForm)
                {
                    DialogResult = DialogResult.OK;
                    this.Hide();
                }
            }
        }


        /// <summary>
        /// Gives the id of the latest record inserted.
        /// </summary>
        /// <param name="PrimaryKeyFieldName">field of pk</param>
        /// <returns>pk </returns>
        public int getLatestIdFromSQL(string PrimaryKeyFieldName)
        {
            if (FormType == FormTypes.EntryForm)
            {
                return getLatestIdFromSQL(_insertSQL, PrimaryKeyFieldName);
            }
            else
            {
                return Conversion.ToInt32(PrimaryKeyValue.ToString());
            }
        }
        public int getLatestIdFromSQL(string insertSQL, string primaryKey)
        {
            string[] parse = insertSQL.Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string tablename = parse[2];
            int startofopBrac = 0;
            startofopBrac = insertSQL.IndexOf('(');
            int endofopBrac = 0;
            endofopBrac = insertSQL.IndexOf(')');
            string fields = insertSQL.Substring(startofopBrac + 1, endofopBrac - startofopBrac - 1);
            int startOfValues = 0;
            startOfValues = insertSQL.IndexOf('(', endofopBrac, insertSQL.Length - endofopBrac);
            int endOfValues = 0;
            endOfValues = insertSQL.IndexOf(')', startOfValues, insertSQL.Length - startOfValues);
            string values = insertSQL.Substring(startOfValues + 1, endOfValues - startOfValues - 1);

            string[] cols = fields.Split(',');
            string[] vals = values.Split(',');
            string sql = "SELECT max(" + primaryKey + ") FROM " + tablename + " WHERE ";
            for (int i = 0; i < cols.Length - 1; i++)
            {
                if (vals[i].Trim().ToUpper() != "NULL" & vals[i].Trim() != "" & vals[i].Trim() != "''")
                {
                    sql += cols[i] + " = " + vals[i] + " AND ";
                }
            }
            sql = sql.Substring(0, sql.Length - 5);
            int Id = 0;
            try
            {

                if (GlobalResources.SelectDBConnection.Open())
                {
                    Id = Conversion.ToInt32(GlobalResources.SelectDBConnection.ExecuteScalar(sql));
                }
            }
            catch
            { }
            return Id;
        }

    }




}
