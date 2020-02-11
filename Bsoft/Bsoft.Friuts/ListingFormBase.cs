using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Bsoft.Controls;
using Bsoft;

using Bsoft.Common;
using Bsoft.Forms;
using Bsoft.Data;
namespace Friuts
{   //can sort multiple cols pressing ctrl key and clicking
    //seting pk is required to focus on given row while sorting
    //If primary key is not set then current row focus will not work
    //march 7 grid empty row corrected
    // mulit select implemented use formtype= multiselect and call addSelectCol("colselect","Select", 1,true );
    public class ListingFormBase : Friuts.FormBase
    {
        #region Member variables.
        private Fruits.Controls.bsoftDgvControler ctrlControler;
        private int pageSize_ = 100;
        private TableColumnCollection _dataTableColumns = new TableColumnCollection();
        private DataGridView _dataGridView = null;
        private ToolStrip _toolstrip = null;
        private EntryFormBase _entryForm = null;

        private TableRelationCollection _relationList = new TableRelationCollection(string.Empty);
        private SearchConditionCollection _searchConditionList = new SearchConditionCollection();

        private object _selectedValue = null;
        private bool _displayRowSerialNo = true;

        private DataGridViewCellStyle dataGridRowStyle = new DataGridViewCellStyle();
        private DataGridViewCellStyle dataGridColumnHeaderCellStyle = new DataGridViewCellStyle();
        private DataGridViewCellStyle dataGridCellStyle = new DataGridViewCellStyle();
        private DataGridViewCellStyle dataGridViewRowHeaderCellStyle = new DataGridViewCellStyle();

        //Global===
        public bool _isRefreshData = false;
        public int _isEditedRow = 0;
        //===================

        private bool _loadDataInFormLoad = true;

        private bool _IsMultiplegridSort = false;

        //Dhiraj
        public int Limit = -1;

        #endregion

        #region Constructors & Finalizers.
        public ListingFormBase()
            : base()
        {
            InitializeClass();

        }

        public ListingFormBase(FormTypes formType, string tableName, DataGridView dataGrid)
            : base(formType, tableName)
        {
            _dataGridView = dataGrid;

            InitializeClass();
        }

        private void InitializeClass()
        {
            this.ctrlControler = new Fruits.Controls.bsoftDgvControler();
            this.ctrlControler.BackColor = System.Drawing.Color.Transparent;
            this.ctrlControler.Name = "ctrlControler";
            this.Controls.Add(this.ctrlControler);
            ctrlControler.Visible = false;

            this.dataFilled += new dataFilledEventHandler(bsoftPageGrid1_dataFilled);
            ctrlControler.btnFirst.Click += new System.EventHandler(btnFirst_Click);
            ctrlControler.btnLast.Click += new System.EventHandler(btnLast_Click);
            ctrlControler.btnNext.Click += new System.EventHandler(btnNext_Click);
            ctrlControler.btnPrevious.Click += new System.EventHandler(btnPrevious_Click);
            txtPageNo = ctrlControler.txtPgNo;
            txtPagesz = ctrlControler.txtpageSize;
            _searchConditionList.TableAliasHash = _relationList.TableAliasHash;
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            first();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            previous();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            next();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            last();
        }
        private Component _txtPageNo;
        private Component txtPageNo
        {
            get { return _txtPageNo; }
            set
            {
                _txtPageNo = (Component)value;
                try
                {
                    ((TextBox)_txtPageNo).KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTpAGENO_KeyDown);
                }
                catch
                {
                    ((ToolStripControlHost)_txtPageNo).KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTpAGENO_KeyDown);

                }

            }
        }
        private Component _txtPagesz;
        private Component txtPagesz
        {
            get { return _txtPagesz; }
            set
            {
                _txtPagesz = (Component)value;
                try
                {
                    ((TextBox)_txtPagesz).KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPgSize_KeyDown);
                }
                catch
                {
                    ((ToolStripControlHost)_txtPagesz).KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPgSize_KeyDown);

                }

            }
        }

        void bsoftPageGrid1_dataFilled(int currentpage, int totalPage, int totalRowcount)
        {
            //lblPageSize.Text = totalPage.ToString();
            //txtPage.Text = currentpage.ToString();
            //try
            //{
            //    ((Control)_txtPageNo).Text = currentpage.ToString() + " / " + totalPage.ToString();
            //}
            //catch { ((ToolStripControlHost)_txtPageNo).Text = currentpage.ToString() + " / " + totalPage.ToString(); }
            try
            {
                ctrlControler.setData(currentpage, totalPage, totalRowcount, pageSize_);
            }
            catch {
                throw;
            }
        }

        private void TXTpAGENO_KeyDown(object sender, KeyEventArgs e)
        {

            int pgno = 0;
            string pgnum = "";
            try
            {
                pgnum = ((Control)_txtPageNo).Text;
            }
            catch { pgnum = ((ToolStripControlHost)_txtPageNo).Text; }

            if (e.KeyCode == Keys.Enter & int.TryParse(pgnum, out  pgno))
            {
                setPage(pgno);
            }
        }
        private void txtPgSize_KeyDown(object sender, KeyEventArgs e)
        {

            int pgsz = 0;
            string pgsize = "";
            try
            {
                pgsize = ((Control)_txtPagesz).Text;
            }
            catch { pgsize = ((ToolStripControlHost)_txtPagesz).Text; }

            if (e.KeyCode == Keys.Enter & int.TryParse(pgsize, out  pgsz))
            {
                pageSize = pgsz;
            }
        }
        #endregion

        #region Nested Enums, Structs, and Classes.
        #endregion

        #region Properties

        public override string TableName
        {
            get
            {
                return base.TableName;
            }
            set
            {
                _relationList.DefaultMasterTable = value;
                _searchConditionList.DefaultMasterTable = value;
                base.TableName = value;
            }
        }

        /// <summary>
        /// Gets or Sets the Data Table column list in which the data is to be displayed.
        /// </summary>
        public TableColumnCollection DataTableColumns
        {
            get { return _dataTableColumns; }
            set { _dataTableColumns = value; }
        }

        /// <summary>
        /// Sets grid Default properties. 
        /// </summary>
        public DataGridView ListingDataGridView
        {
            get { return _dataGridView; }
            set
            {
                _dataGridView = value;

                SetDataGridViewProperties();

                AttachDataGridViewEvents();
                AttachDataGridViewEventsForContextMenu();

            }
        }

        /// <summary>
        /// Sets toolstrim Default properties. 
        /// </summary>
        public ToolStrip toolstrip
        {
            get { return _toolstrip; }
            set
            {
                _toolstrip = value;

                // _toolstrip.AutoSize = false;
                //  _toolstrip.BackColor = System.Drawing.Color.Transparent;
                _toolstrip.Font = MainFont; //new System.Drawing.Font("Verdana", 8F, FontStyle.Regular);
                _toolstrip.GripMargin = new System.Windows.Forms.Padding(0);
                _toolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
                // _toolstrip.ImageScalingSize = new System.Drawing.Size(32, 32);
                // _toolstrip.Height = 50;
                _toolstrip.Dock = DockStyle.Top;
                _toolstrip.TabStop = true;


            }
        }

        /// <summary>
        /// Gets or Sets the form which will be used for performing the Entry and Edit task.
        /// </summary>
        public EntryFormBase EntryForm
        {
            get { return _entryForm; }
            set { _entryForm = value; }
        }


        public TableRelationCollection RelationList
        {
            get { return _relationList; }
            set { _relationList = value; }
        }


        public SearchConditionCollection SearchConditionList
        {
            get { return _searchConditionList; }
            set { _searchConditionList = value; }
        }

        /// <summary>
        /// Gets or sets the value which has to be returned to its owner form
        /// </summary>
        public object SelectedValue
        {
            get { return _selectedValue; }
            set { _selectedValue = value; }
        }

        /// <summary>
        /// Gets or Sets where to display Grid Row serial no or not.
        /// </summary>
        public bool DisplayDataGridRowSerialNo
        {
            get { return _displayRowSerialNo; }
            set { _displayRowSerialNo = value; }
        }


        public bool LoadDataInFormLoad
        {
            get { return _loadDataInFormLoad; }
            set { _loadDataInFormLoad = value; }
        }



        //Use for Multipe Grid off the Sorting
        public bool IsMultiplegridSort
        {
            get { return _IsMultiplegridSort; }
            set { _IsMultiplegridSort = value; }
        }

        #endregion

        #region Methods

        #region openform



        /// <summary>
        /// Opens the Form either in Entrymode and return if the Task performed in that form is successful or not.
        /// </summary>        
        /// <returns></returns>
        public virtual bool OpenNewForm()
        {
            throw new Exception("Please override this function so that new form can be opened.");
        }

        /// <summary>
        /// Opens the Form either in Entry  mode and return if the Task performed in that form is successful or not.
        /// </summary>        
        /// <returns></returns>
        public virtual bool OpenNewForm(EntryFormBase form)
        {
            return OpenForm(FormTypes.EntryForm, form);
        }

        public virtual Form OwnerForm
        {
            get { return this; }
        }

        /// <summary>
        /// Opens the Form either in Entry or Edit mode and return if the Task performed in that form is successful or not.
        /// </summary>
        /// <param name="formType">The type of the form which to be opened.</param>
        /// <param name="form">The form to be processed</param>
        /// <returns>Returns true if the task performed in the form is successful else false.</returns>
        public virtual bool OpenForm(FormTypes formType, EntryFormBase form)
        {
            bool status = false;
            //toedit Dhiraj
            int currentRowIndex = _dataGridView.Rows.Count == 0 ? -1 : _dataGridView.CurrentCell.RowIndex;
            currentCellIndex = _dataGridView.Rows.Count == 0 ? -1 : _dataGridView.CurrentCell.ColumnIndex;
            form.FormType = formType;
            if (form.TableName.Length == 0)
            {
                form.TableName = TableName;
            }


            form.ShowDialog(OwnerForm);

            //using for Edited Data Refresh's Enabled Bool variables
            //if (formType == FormTypes.EditForm)
            if (form.FormType == FormTypes.EditForm) // 
            {
                //  _isRefreshData = true; removed by Dhiraj for pagination
                _isEditedRow = currentRowIndex;


            }
            if (form.FormType == FormTypes.EntryForm) // 
            {
                try
                {
                    int rowindex = 0;
                    rowindex = _formDataTable.Rows.Count == 0 ? -1 : _formDataTable.Rows.Count;
                    currentPage_ = getPageNo(rowindex, pageSize_);
                    currentRowIndex = getGridRowNo(rowindex, pageSize_);
                }
                catch { }
            }

            //check if the form is properly closed or not.
            // if the form is closed after performing all the tasks properly then DialogResult will return OK.
            if (form.DialogResult == DialogResult.OK)
                status = true;

            form.Dispose();

            //if the data is updates successfully then refresh the list.
            if (status)
            {
                LoadData();

                if (_dataGridView.Rows.Count > 0 && currentRowIndex > -1)
                {
                    _dataGridView.CurrentCell = _dataGridView.Rows[currentRowIndex].Cells[currentCellIndex];
                }
            }



            //using for Edited Data Refreshing after bool variable disabled..
            if (formType == FormTypes.EditForm)  //Warning: Compulsory required other wise Data Refresh problems..
            {

                _isRefreshData = false;
                _isEditedRow = 0;
            }
            return status;
        }

        /// <summary>
        /// Opens the Form either in Edit mode and return if the Task performed in that form is successful or not.
        /// </summary>        
        /// <returns>Returns true if the task performed in the form is successful else false.</returns>
        public virtual bool OpenEditForm()
        {
            throw new Exception("Please override this function so that new form can be opened.");
        }

        /// <summary>
        /// Opens the Form either in Edit mode and return if the Task performed in that form is successful or not.
        /// </summary>
        /// <param name="form">The form to be processed</param>
        /// <returns>Returns true if the task performed in the form is successful else false.</returns>
        public virtual bool OpenEditForm(EntryFormBase form)
        {
            if (_dataGridView.Rows.Count < 1)
            {
                return false;
            }

            //set the primary key of the EntryEdit form before opening the form for edit.
            //it will dispaly the record which hold the value stored in "PrimaryKeyValue" property.
            SetPrimaryKeyValue();
            if (PrimaryKeyValue == null)
                return false;

            form.PrimaryKeyValue = PrimaryKeyValue;
            return OpenForm(FormTypes.EditForm, form);
        }

        #endregion

        #region navigation
        /// <summary>
        /// Defines the size of page
        /// </summary>
        public int pageSize
        {
            get { return pageSize_; }
            set
            {
                pageSize_ = value;
                currentPage_ = 1; currentRowIndex = 0;
                currentPage = currentPage_;
            }
        }
        public bool next()
        {
            currentRowIndex = 0;
            currentPage = currentPage + 1;
            return true;
        }
        public bool previous()
        {
            currentRowIndex = 0;
            currentPage = currentPage - 1;
            return true;
        }
        public bool first()
        {
            currentRowIndex = 0;
            currentPage = 1;
            return true;
        }
        public bool last()
        {
            currentRowIndex = 0;
            currentPage = TotalPage_;
            return true;
        }
        public bool setPage(int pageno)
        {
            currentRowIndex = 0;
            currentPage = pageno;
            return true;
        }
        /// <summary>
        /// Total number of pages 
        /// </summary>
        int TotalPage_ = 0;
        public int TotalPage
        {
            get
            {
                if (_formDataTable != null)
                {
                    int TotalRowCount = _formDataTable.Rows.Count;
                    //If the rows per page are less than the total row count do the following:
                    if (pageSize < TotalRowCount)
                    {
                       
                        //If the Modulus returns > 0 then there should be another page.
                        if ((TotalRowCount % pageSize) > 0)
                        {
                            TotalPage_ = ((TotalRowCount / pageSize) + 1);
                        }
                        else
                        {
                            //There is nothing left after the Modulus, so the pageRows divide exactly...
                            //...into TotalRowCount leaving no rest, thus no extra page needs to be addd.
                            TotalPage_ = TotalRowCount / pageSize;
                        }
                        showGridController(true);
                    }
                    else
                    {
                        //If the rows per page are more than the total row count, we will obviously only ever have 1 page
                        TotalPage_ = 1;
                        showGridController(false);
                    }
                }

                return TotalPage_;
            }
        }

        private int getPageNo(int dtRowNo, int pageSize)
        {
            double pageNo = 0;
            ////  =IF(A2=0,-2,TRUNC((A2-1)/5,0))+1
            //if (dtRowNo <= 0)
            //{ return -1; }
            //else
            //{
            //    return pageNo = ((dtRowNo - 1) / pageSize) + 1;
            //}

            pageNo = dtRowNo / pageSize;
            return (int)Math.Truncate(pageNo) + 1;
        }
        private void showGridController(bool show)
        {
            if (show)
            {
                //  ctrlControler.Location = _dataGridView .Location;
                //  ctrlControler.Width = _dataGridView.Width;

                
                if (!ctrlControler.Visible)
                {
                    _dataGridView.Top = ctrlControler.Top + ctrlControler.tlControler.Height + 1;
                    _dataGridView.Height = _dataGridView.Height - ctrlControler.tlControler.Height;
                }
                ctrlControler.Parent = _dataGridView.Parent;
                ctrlControler.Visible = true;
            }
            else
            {
                if (ctrlControler.Visible)
                {
                    _dataGridView.Height = _dataGridView.Height + ctrlControler.tlControler.Height;
                    _dataGridView.Top = ctrlControler.Top;
                }
                ctrlControler.Visible = false;


            }
        }
        private int getGridRowNo(int dtRowNo, int pageSize)
        {
            //int gridRowNo = 0;
            ////  =IF(A2=0,-1,IF(MOD(A2,5)=0,5,MOD(A2,5)))
            //if (dtRowNo <= 0)
            //{ return -1; }
            //else
            //{
            //    gridRowNo = dtRowNo % pageSize;
            //    if (gridRowNo == 0)
            //    { return pageSize-1; }
            //    else { return gridRowNo-1; }
            //}
            return dtRowNo % pageSize;
        }


        int currentPage_ = 1;
        public int currentPage
        {
            get
            {
                return currentPage_;
            }
            set
            {
                loadPage(value, currentRowIndex);
            }
        }



        private void loadPage(int page, int focusRow)
        {//MULTIPAGE
            if (page > 0 & page <= TotalPage_)
            {
                currentPage_ = page;

                fillDataGrid(currentPage_);
                lastSuccesfulPageShown = currentPage_;

                //_dataGridView.Rows[currentRowIndex].Selected = true;
                //_dataGridView.Rows[currentRowIndex].Cells[1].Selected = true;

                if (_dataGridView.Rows.Count > 0 && currentRowIndex > -1)
                {

                    try
                    {
                        _dataGridView.CurrentCell = _dataGridView.Rows[currentRowIndex].Cells[currentCellIndex];
                        _dataGridView.Rows[currentRowIndex].Selected = true;
                    }

                    catch
                    {

                    }
                }
            }
            else//SINGLE PAGE
            {
                try
                {
                    int TotalRowCount = _formDataTable.Rows.Count;
                    dataFilled(currentPage_, TotalPage, TotalRowCount);
                }
                catch { }
            }
        }
        public delegate void dataFilledEventHandler(int currentPage, int totalPage, int totalRows);
        public event dataFilledEventHandler dataFilled;
        private void fillDataGrid(int CurrentPage)
        {
            try
            {
                int TotalRowCount = _formDataTable.Rows.Count;

                Cursor = Cursors.WaitCursor;

                //We now need to determine the LowerBoundary and UpperBoundary in order to correctly...
                int LowerBoundary = 0;
                int UpperBoundary = 0;

                //We now need to know what button was clicked, if any (First, Last, Next, Previous)
                LowerBoundary = ((pageSize * CurrentPage) - (pageSize));
                //Find upper boundary
                if (currentPage == TotalPage_)//Last Page
                {
                    UpperBoundary = TotalRowCount;
                }
                else
                {
                    //If the rows per page are less than the total row count do the following:
                    if (pageSize < TotalRowCount)
                    {
                        UpperBoundary = (pageSize * CurrentPage);
                    }
                    else
                    {
                        UpperBoundary = TotalRowCount;
                    }
                }
                ////Remember, .NET is 0 based, so subtract 1 from both boundaries
                //string RecordID1 = _formDataTable.Rows[LowerBoundary - 1]["Col_count_ran_name"].ToString();
                //string RecordID2 = _formDataTable.Rows[UpperBoundary - 1]["Col_count_ran_name"].ToString();

                ////Now that we have the boundaries, filter the bindingsource.
                ////This has the following effect as the following Query:
                ////select * from [LogTable] where RecordID >= 10 and RecordID <= 12
                //// bindingSource1.Filter = "Col_count_ran_name >= " + RecordID1 + " and Col_count_ran_name <= " + RecordID2;
                ////Set the Grid's DataSource to the BindingSource. This populates the grid with data.

                ////populate data
                ////  DataSource = bindingSource1;
                //int st = Convert.ToInt16(RecordID1);
                //int en = Convert.ToInt16(RecordID2);
                setdata(LowerBoundary, UpperBoundary);

                currentPage_ = CurrentPage;
                try
                {

                    dataFilled(currentPage_, TotalPage, TotalRowCount);
                }
                catch { }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void setdata(int startrow, int endrow)
        {
            _dataGridView.Rows.Clear();
            _dataGridView.Rows.Add(endrow - startrow);//NO PAGE

            _dataGridView.Refresh();

            for (int i = startrow; i < endrow; i++)
            {
                DataRow row = _formDataTable.Rows[i];
                setRowData(row, i - startrow);
                // rowcount++;
            }

            //    _dataGridView.  Rows.Clear();
            //Columns.Clear();
            //foreach (DataColumn dc in dt_.Columns)
            //{
            //    Columns.Add(dc.ColumnName, dc.Caption);
            //}

            //for (int i = 0; i < endrow - startrow; i++)
            //{
            //    Rows.Add();
            //    foreach (DataColumn dc in dt_.Columns)
            //    {
            //        Rows[i].Cells[dc.ColumnName].Value = dt_.Rows[startrow + i][dc.ColumnName];
            //    }
            //}
        }
        public int lastSuccesfulPageShown = 1;



        int currentCellIndex = 0;
        int currentRowIndex = 0;
        #endregion

        #region loadData

        /// <summary>
        /// Sets the cell value of the GridView row as primary column of is the currently selected.
        /// This function searchs for the _dataTableColumns list if any primary key column exists or not.
        /// </summary>
        /// <returns>Returns true if primary key value is set else returns false.</returns>
        public virtual bool SetPrimaryKeyValue()
        {
            //bool status = false;
            foreach (TableColumn col in _dataTableColumns)
            {
                if (col.IsPrimaryKeyColumn)
                {
                    if (col.DisplayColumnAlias.Trim() == "")
                    {
                        _formDataTable.PrimaryKey = new DataColumn[] { _formDataTable.Columns[col.DbColumnName] };//Dhiraj
                    }
                    else
                    {
                        _formDataTable.PrimaryKey = new DataColumn[] { _formDataTable.Columns[col.DisplayColumnAlias] };//Dhiraj
                    }
                    return SetPrimaryKeyValue(col.DataTableColumn, _dataGridView);
                }
            }

            //  throw new Exception("Primary Key column not set.");
            return false;
        }

        /// <summary>
        /// Sets the cell value of the GridView row as primary column of is the currently selected.
        /// </summary>
        /// <param name="primaryKeyColumn">DataGridView column of which value is to be used as primary key value.</param>
        /// <param name="dataGridView">DataGridView from which primary key value will be extracted.</param>
        /// <returns>Returns true if primary key value is set else returns false.</returns>
        public virtual bool SetPrimaryKeyValue(string primaryKeyColumn, DataGridView dataGridView)
        {


            //bool status = false;
            PrimaryKeyValue = null;

            if (dataGridView == null)
            {
                throw new NullReferenceException("Invalid dataGridView object.");
            }

            if (primaryKeyColumn.Trim().Length == 0)
            {
                throw new Exception("primaryKeyColumn must be passed.");
            }

            if (!dataGridView.Columns.Contains(primaryKeyColumn))
            {
                throw new Exception("Invalid primaryKeyColumn be passed.");
            }

            //set the primary key value.
            if (dataGridView.CurrentRow == null)
                return false;

            PrimaryKeyValue = dataGridView.CurrentRow.Cells[primaryKeyColumn].Value;

            return true;
        }

        private bool LoadData_Datatable()
        {
            bool status = false;
            base.LoadData();
            //validation Message..

            if (!GenerateSelectSQL())
            {
                DisplayErrorMessage("Errro while generating Select SQL.");
                return false;
            }


            //For Limit top etc
            if (Limit >= 0)
            {
                switch (ConversionSql.dbKind)
                {
                    case databaseKind.SQLite:
                        SelectSQL = SelectSQL + " LIMIT " + Limit.ToString();
                        break;
                    case databaseKind.SQLServer:
                        //not yet need top 
                        break;
                }
            }

            ExecuteSelectSQL();


            int totpgdummy = TotalPage;

            return status;
        }

        public override bool LoadData()
        {
            bool status = false;
            status = LoadData_Datatable();
            //if data is not found the Validation Message Displaying..
            if (!_loadDataInFormLoad)
            {
                if (_formDataTable.Rows.Count < 1)
                {
                    _dataGridView.Rows.Clear();

                    MessageBox.Show(ActiveForm, "Data Couldnot be found", "Message", MessageBoxButtons.OK);

                    return false;
                }
                else if (_formDataTable.Rows.Count >= 500)
                {
                    DialogResult result = MessageBox.Show("It will take some time.", "Message", MessageBoxButtons.YesNo);
                    this.Refresh();
                    if (result == DialogResult.No)
                    {
                        _isRefreshData = false; //required compulsory..
                        return false;
                    }
                }
            }
            //====================================
            currentPage_ = 1;
            
            status = LoadDataIntoDataGrid();
            // code to set the current row in dgv
            // for the case of delete and add only
            // for the case of edit its same
            return status;
        }

        public virtual bool LoadDataIntoDataGrid()
        {
            if (!setInitialPrpoertyForDataGrid())
                return false;
            int totpgdummy = TotalPage;

            currentPage = currentPage_;
            //foreach (DataRow row in _formDataTable.Rows)
            //{
            //    setRowData(row, rowcount);
            //    rowcount++;
            //}
            _dataGridView.Visible = true;
            //_dataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            return true;
        }

        private void setRowData(DataRow row, int rowCnt)
        {
            string rowValue = string.Empty; string tmpColName = string.Empty;
            //For Cols
            try
            {
                foreach (TableColumn col in _dataTableColumns)
                {
                    try
                    {
                        //get Col name
                        if (col.IsCaseStatement)
                        { tmpColName = col.CaseStatementColumnAlias; }
                        else
                        { tmpColName = col.DisplayColumnAlias.Trim().Length == 0 ? col.DbColumnName : col.DisplayColumnAlias; }
                        tmpColName = tmpColName.Replace(" ", string.Empty);
                        //Get Row Value
                        //better handle row null in getdisplay value so that it can be properly formated
                        //if (row.IsNull(tmpColName))
                        //    rowValue = "";
                        //else
                        rowValue = col.GetDisplayValue(row[tmpColName]);
                    }
                    catch { }
                    if (_isRefreshData)
                    { rowCnt = _isEditedRow; }//Refresh edited data                        
                    //Fro Check Box columns
                    if (_dataGridView.Rows[rowCnt].Cells[col.DataTableColumn] is DataGridViewCheckBoxCell)
                    {
                        DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)_dataGridView.Rows[rowCnt].Cells[col.DataTableColumn];
                        cell.Value = rowValue.Trim() == "1" ? true : false;
                    }
                    else
                    {//For normal columns
                        _dataGridView.Rows[rowCnt].Cells[col.DataTableColumn].Value = rowValue;
                    }
                }
                //All cols for relations list
                foreach (TableRelation rel in _relationList)
                {
                    try
                    {
                        tmpColName = rel.DisplayColumnAlias.Trim().Length == 0 ? rel.DisplayColumn : rel.DisplayColumnAlias;
                        _dataGridView.Rows[rowCnt].Cells[rel.GridColumn].Value = row[tmpColName.Replace(" ", string.Empty)];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                //display the row No or serial no.
                if (_displayRowSerialNo)
                {
                    try
                    {
                        _dataGridView.Rows[rowCnt].HeaderCell.Value = Convert.ToString((pageSize * (currentPage_ - 1)) + rowCnt + 1);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }//required sometime occur errors..
                }

            }
            catch (Exception ex) { throw new Exception(tmpColName.ToString() + " grid Column mismatch" + ex.Message + " " + ex.StackTrace); }
        }

        #endregion

        #region dgvProperties

        /// <summary>
        /// Clearing , header rows, refreshing , col alignment
        /// </summary>
        /// <returns></returns>
        private bool setInitialPrpoertyForDataGrid()
        {
            if (!_isRefreshData)
            {
                if (_dataGridView.Rows != null)
                    _dataGridView.Rows.Clear();
            }

            if (_displayRowSerialNo)
            {
                _dataGridView.RowHeadersVisible = true;
                _dataGridView.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            if (_formDataTable == null || _formDataTable.Rows.Count <= 0)
            {
                //No data found
                return false;
            }
            if (!_isRefreshData)
            {
                if (FormType != FormTypes.EditForm)
                {
                    this.Refresh();
                }
                _dataGridView.Visible = false;

                // _dataGridView.Rows.Add(pageSize);
            }
            //right align grid columns...
            try
            {
                foreach (TableColumn col in _dataTableColumns)
                {
                    if (_dataGridView.Columns[col.DataTableColumn] is DataGridViewCheckBoxColumn)
                        _dataGridView.Columns[col.DataTableColumn].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    else
                    {
                        if (col.Type == ColumnTypes.Number
                            || col.Type == ColumnTypes.Amount
                            || col.Type == ColumnTypes.AmountRound2
                            || col.Type == ColumnTypes.AmountRound
                            || col.Type == ColumnTypes.Integer)
                        {
                            _dataGridView.Columns[col.DataTableColumn].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        }
                    }

                    //_dataGridView.Columns[col.DataTableColumn].SortMode = DataGridViewColumnSortMode.Programmatic;
                }
            }
            catch
            {
            }
            return true;
        }

        public virtual void SetDataGridViewProperties()
        {
            SetDataGridViewProperties(_dataGridView);
        }
        public virtual void SetDataGridViewProperties(DataGridView dataGridView)
        {
            ctrlControler.Location = dataGridView.Location;
            ctrlControler.Width = dataGridView.Width;

            dataGridView.ColumnHeadersHeight = 35;
            dataGridView.RowHeadersWidth = 54;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = true;
            dataGridView.MultiSelect = false;
            dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(224)))));
            //dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Removed EditProgrammatically since this will render multi select unusable
            if (FormType !=FormTypes .MultipleSelect)
            {
                dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            
            //dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;makes slow
            dataGridView.StandardTab = true; //required...
            ////Column Header Style
            dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridColumnHeaderCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridColumnHeaderCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            dataGridColumnHeaderCellStyle.Font = dataGridView.ColumnHeadersDefaultCellStyle.Font;
            dataGridColumnHeaderCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridColumnHeaderCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridColumnHeaderCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridColumnHeaderCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridColumnHeaderCellStyle;

            ////Cell Style
            dataGridCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(224)))));
            dataGridCellStyle.Font = dataGridView.DefaultCellStyle.Font;
            dataGridCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridCellStyle.NullValue = string.Empty;
            dataGridView.DefaultCellStyle = dataGridCellStyle;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridRowStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            //dataGridRowStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridRowStyle;

            //Row Header Style
            dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewRowHeaderCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewRowHeaderCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            //dataGridViewRowHeaderCellStyle.Font = dataGridView.RowHeadersDefaultCellStyle.Font;
            //dataGridViewRowHeaderCellStyle.Font = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewRowHeaderCellStyle.Font = Bsoft.Design.FormDesginBase.DigitFont;
            dataGridViewRowHeaderCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridViewRowHeaderCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewRowHeaderCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewRowHeaderCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewRowHeaderCellStyle;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        #endregion

        #region sqlrelated
        public override bool GenerateSelectSQL()
        {
            //bool status = false;            
            if (_relationList.Count > 0)
            {
                GenerateSelectSQLWithRelation();
            }
            else
            {
                GenerateSelectSQLWithOutRelation();
            }


            return base.GenerateSelectSQL();
        }

        /// <summary>
        /// Generates the Select SQL without relation join and sets it in SelectSQL property.
        /// </summary>
        private void GenerateSelectSQLWithOutRelation()
        {
            SelectSQL = string.Empty;
            queryBulilder.Remove(0, queryBulilder.Length);

            queryBulilder.Append("SELECT");

            //adding the filelds in which data are to be udpated.
            foreach (TableColumn col in _dataTableColumns)
            {
                //queryBulilder.AppendFormat("{0},", col.DbColumnName);
                queryBulilder.Append(string.Format("\n\t{0},", col.DbColumnName));
            }

            //remove the ending comma(,)
            queryBulilder.Replace(",", " ", queryBulilder.Length - 1, 1);
            queryBulilder.Append("\nFROM");
            queryBulilder.Append(string.Format("\n\t{0} ", TableName));

            SelectSQL = queryBulilder.ToString();
        }

        /// <summary>
        /// Generates the Select SQL with relation join and sets it in SelectSQL property.
        /// </summary>
        private void GenerateSelectSQLWithRelation()
        {
            SelectSQL = string.Empty;
            queryBulilder.Remove(0, queryBulilder.Length);

            queryBulilder.Append("SELECT");
            //adding the filelds in which data are to be udpated.
            foreach (TableColumn col in _dataTableColumns)
            {
                if (col.IsCaseStatement)
                {
                    queryBulilder.Append(string.Format("\n\t{0},", col.DbColumnName));
                }
                else
                {
                    col.DisplayColumnAlias = string.Format("{0}_{1}", _relationList.GetTableAlias(TableName), col.DbColumnName);
                    if (col.DisplayColumnAlias.Trim().Length > 30)//if lenght Exceeds 30,identifier will be too long
                    {
                        col.DisplayColumnAlias = string.Format("{0}_{1}", _relationList.GetTableAlias(TableName), col.DbColumnName.Substring(0, 25));
                    }
                    queryBulilder.Append(string.Format("\n\t{0}.{1} {2},", _relationList.GetTableAlias(TableName), col.DbColumnName, col.DisplayColumnAlias));
                    col.DbColumnSearchAlias = string.Format("\n\t{0}.{1}", _relationList.GetTableAlias(TableName), col.DbColumnName);
                }
            }

            //adding the relational columns in the select list.
            queryBulilder.Append(_relationList.GetSelectList());

            //adding the from table clause.//changed by dhiraj 
            queryBulilder.Append(_relationList.GetTableSource());
            //now joins added
            queryBulilder.Append(_relationList.GetJoinCriteria());

            SelectSQL = queryBulilder.ToString();
        }

        public override string GetWhereClauseForSelect()
        {
            return GetWhereClauseForSelect(false);
        }

        public string GetWhereClauseForSelect(bool forCrystalReport)
        {
            string tmp = string.Empty;

            if (!forCrystalReport)
            {
                //Purpose For Edited Data Refreshing..
                if (_isRefreshData)
                {
                    foreach (TableColumn col in _dataTableColumns)
                    {

                        if (DataTableColumns[col.DbColumnName].IsPrimaryKeyColumn)
                        {
                            if (_relationList.Count > 0)
                            {
                                tmp = "";// _relationList.GetJoinCriteria(); dhiraj
                                if (tmp.Length > 0)
                                {
                                    tmp += String.Format("AND {0} = {1}", col.DbColumnSearchAlias, this.PrimaryKeyValue);
                                    return tmp;
                                }
                                else
                                {
                                    tmp = String.Format("WHERE {0} = {1}", col.DbColumnSearchAlias, this.PrimaryKeyValue);
                                    return tmp;
                                }
                            }
                            else
                            {
                                tmp = String.Format("WHERE  {0} = {1}", col.DbColumnName, this.PrimaryKeyValue);
                                return tmp;
                            }
                        }
                    }
                }
                else
                {

                    if (_relationList.Count > 0)
                    {
                        tmp = _searchConditionList.GetSearchCriteria();
                        if (tmp.Trim().Length == 0)
                        {
                            return tmp;
                        }
                        if (!tmp.Contains("where"))
                        {

                            return " WHERE 1=1  AND " + tmp;
                        }
                        else
                        {
                            return tmp;
                        }
                        //return (tmp.Length > 0 ? " WHERE 1=1  AND " + tmp : string.Empty);//dhiraj
                        //return _relationList.GetJoinCriteria() + (tmp.Length > 0 ? " AND " + tmp : string.Empty);
                    }
                }
            }

            if (_searchConditionList.Count > 0)
            {
                tmp = _searchConditionList.GetSearchCriteria(forCrystalReport);
                if (tmp.Length > 0)
                {
                    return forCrystalReport ? tmp : "\nWHERE " + tmp;
                }
                return base.GetWhereClauseForSelect();
            }
            else
            {
                return base.GetWhereClauseForSelect();
            }
        }

        /// <summary>
        /// Generates the where clause required for Update and Delete.
        /// </summary>
        /// <returns>Returns the where clause.</returns>
        public override string GetWhereClauseForDelete()
        {
            //first clear the string builder.
            queryBulilder2.Remove(0, queryBulilder2.Length);

            queryBulilder2.Append(" WHERE ");
            bool isFirst = true;
            //checking for the primary key using which data is to be deleted.
            foreach (TableColumn col in _dataTableColumns)
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
        /// Generates the Delete SQL and return the status.
        /// </summary>
        /// <returns>Return true if SQL is generated successfully else false.</returns>
        public override bool GenerateDeleteSQL()
        {
            DeleteSQL = string.Empty;
            queryBulilder.Remove(0, queryBulilder.Length);
            queryBulilder.AppendFormat("DELETE FROM {0} {1}", TableName, GetWhereClauseForDelete());

            DeleteSQL = queryBulilder.ToString();
            return true;
        }
        /// <summary>
        /// Checks if a data can be deleted
        /// </summary>
        /// <param name="pk"></param>
        /// <param name="ReferencingTable">The table where TableName id is foreign key</param>
        /// <param name="ReferencingField">The field name</param>
        /// <param name="FormTitle">Just for displaying message</param>
        /// <returns>true if can be deleted</returns>
        public bool CheckExist(String ReferencingTable, string ReferencingField, string FormTitle)
        {
            SetPrimaryKeyValue();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Select count(0) FROM {0} WHERE {1} = {2}", ReferencingTable, ReferencingField, PrimaryKeyValue.ToString());

            string str = sb.ToString();
            string count = "0";
            count += GlobalResources.SelectDBConnection.ExecuteScalar(str).ToString();
            int cnt = Convert.ToInt16(count);
            if (cnt > 0)
            {
                MessageBoxMy.Show("This data cannot be deleted as it is being used in " + FormTitle);
                return false;
            }
            else
            {
                return true;
            }

        }
        /// <summary>
        /// Sets the primary key value and then deletes the data.
        /// </summary>
        /// <returns>Return true if record is deleted else false</returns>
        public override bool Delete()
        {
            if (_dataGridView.Rows.Count < 1) //if delete rows is not found the Return...
            {
                return false;
            }

            //set the primary key value of which data is being deleted.
            SetPrimaryKeyValue();


            //int currentCellIndex = _dataGridView.Rows.Count == 0 ? -1 : _dataGridView.CurrentCell.ColumnIndex;
            if (base.Delete())
            {


                object oldPk = PrimaryKeyValue;
                SetPrimaryKeyValue();

                DataRow foundRow = _formDataTable.Rows.Find(oldPk);

                int rowindex = _formDataTable.Rows.IndexOf(foundRow);
                if (rowindex >= _formDataTable.Rows.Count - 1)
                {
                    rowindex--;
                }
                currentPage_ = getPageNo(rowindex, pageSize_);
                currentRowIndex = getGridRowNo(rowindex, pageSize_);

                return LoadData(); //TODO:20-Jun-2009 this Loaddata it will take time..
                //so that here is need to remove only selected row...
                int cnt = 0;
                int selRow = 0;
                if (_dataGridView.CurrentRow != null)
                {
                    selRow = _dataGridView.CurrentRow.Index;
                }
                if (selRow >= 0)
                    _dataGridView.Rows.RemoveAt(selRow);

                //Serioal No. Res-Set compulosry required...
                foreach (DataGridViewRow row in _dataGridView.Rows)
                {
                    row.HeaderCell.Value = Convert.ToString(++cnt); ;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Before the any data delete Dependent tble data exist or not checking..
        /// Must pass the all the paramater other wise occur error..
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="TblName"></param>
        /// <param name="IDColumnName"></param>
        /// <param name="gridIdcol"></param>
        /// <returns></returns>
        public bool DeleteDependentTableExists(DataGridView grid, string TblName, string dbColName, string gridIdcol)
        {
            if (grid == null)
                throw new Exception("Must pass the grid Name");
            if (TblName.Length == 0)
                throw new Exception("Must pass the table Name.");
            if (dbColName.Length == 0)
                throw new Exception("Must pass the database Column Name");
            if (gridIdcol.Length == 0)
                throw new Exception("Must pass the grid id Column Name");
            if (grid.Rows.Count < 1)
                return false;

            try
            {

                if (grid.CurrentRow.Cells[gridIdcol].Value.ToString().Trim() == "")
                {
                    return false;
                }
            }
            catch  
            {
                return true;
            }

            string ID = grid.CurrentRow.Cells[gridIdcol].Value.ToString().Trim();

            StringBuilder Sql = new StringBuilder();
            Sql.Append("SELECT");
            Sql.Append("\n 1 FROM");
            Sql.AppendFormat(" {0}", TblName);
            Sql.Append("\nWHERE ");
            Sql.AppendFormat("\n {0}", dbColName);
            Sql.AppendFormat("\n = {0}", ID.ToString());
            DataTable dt = null;
            dt = GlobalResources.SelectDBConnection.ExecuteDataTable(Sql.ToString());
            if (dt.Rows.Count > 0)
            {
                //  MsgBoxNepali.Show("k|of]u ul<Psf] tYofª\\sx?nfO{ d]^fpg lgif]w ul<Psf] % È", MessageBoxButtons.OK);
                MessageBox.Show("k|of]u ul<Psf] tYofª\\sx?nfO{ d]^fpg lgif]w ul<Psf] % È", "", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }



        #endregion

        #region "For context menu on grid -By Dhiraj"

        private void MenuItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem menuItem = e.ClickedItem as ToolStripMenuItem;

            if (menuItem == null)
                return;

            switch (menuItem.Text)
            {
                //case EXPORT_TO_EXCEL:
                //    ToExcel();
                //    break;

                //case EXPORT_TO_CSV:
                //    ToCsv();
                //    break;

                //case SEARCH:
                //    ShowSearch();
                //    break;

                default:
                    if (!menuItem.Checked || _dataGridView.Columns.GetColumnCount(DataGridViewElementStates.Visible) > 1)
                    {
                        DataGridViewColumn column = (DataGridViewColumn)menuItem.Tag;
                        column.Visible = !menuItem.Checked;
                        menuItem.Checked = column.Visible;
                    }
                    break;
            }
        }
        ContextMenuStrip menuColumnHeader;
        string GetColumnText(DataGridViewColumn column)
        {
            if (column.HeaderText == "" && column is DataGridViewButtonColumn)
                return ((DataGridViewButtonColumn)column).Text;

            return column.HeaderText;
        }

        private void AttachDataGridViewEventsForContextMenu()
        {
            //added by Dhiraj
            menuColumnHeader = new ContextMenuStrip();
            menuColumnHeader.ItemClicked += MenuItemClicked;
            setMenuforColumns(_dataGridView);

        }
        private void setMenuforColumns(DataGridView dataGridView1)
        {
            foreach (DataGridViewColumn dc in dataGridView1.Columns)
            {
                if (dc.Visible)
                {
                    dc.HeaderCell.ContextMenuStrip = menuColumnHeader;
                    // menuColumnHeader.Items.Clear();
                    // menuColumnHeader.Items.Add(new ToolStripSeparator());
                }
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Visible)
                {
                    ToolStripMenuItem newItem = new ToolStripMenuItem(GetColumnText(column));
                    if (ModifierKeys == Keys.Shift)
                        newItem.Text += string.Format(" - ({0} px)", column.Width);
                    newItem.Checked = column.Visible;
                    newItem.Visible = newItem.Text != "";
                    newItem.Tag = column;
                    menuColumnHeader.Items.Add(newItem);
                }
            }
        }
        #endregion

        #region selected values



        /// <summary>
        /// Sets the current row to the SelectedValue property and set the DailogResult to OK
        /// </summary>
        /// <returns></returns>
        public virtual bool SetSelectedValue()
        {
            if (FormType != FormTypes.SelectionForm)
                return false;

            bool status = false;

            //this form will set the selected row of the default grid to the [SelectedValue] property.
            if (ListingDataGridView != null)
            {
                if (ListingDataGridView.Rows.Count > 0)
                {
                    _selectedValue = ListingDataGridView.CurrentRow;

                    DialogResult = DialogResult.OK;
                    return true;
                }
            }

            return status;
        }
        public delegate void ValueSelected(object sender, string SelectedPrimaryKey);
        public event ValueSelected valueSelected;
        /// <summary>
        /// This functions sets the SelectedValue and return it. 
        /// </summary>
        /// <returns>Returns the status as true if success else false.</returns>
        public bool ReturnSelectedValue()
        {
            //if (FormType != FormTypes.SelectionForm)
            //    return false;
            // to be called by selection form only
            //set the selected row (by default) or other objects 
            // for non row the SetSelectedValue function has to be overriden.
            SetSelectedValue();
            //raise event ValueSelected 
            string Pk = GetSelectedRowPrimaryKey();

            if (Pk == null)
            {
                Pk = "";
            }
            try
            {
                valueSelected(this, Pk);
            }
            catch
            {
                // throw;
            }
            //this.Hide();//Do this in main from after the event implemented
            return false;
        }

        /// <summary>
        /// Retruns the value form the selected row for given column Name
        /// </summary>
        /// <returns></returns>
        public string GetSelectedRowValue(string colName)
        {
            string selectedValue = "";
            try
            {

                if (_dataGridView.Rows.Count <= 0)
                {
                    MessageBoxMy.Show("The list is Empty ,Please add some Data First.");
                    return "";
                }
                DataGridViewRow row = _dataGridView.CurrentRow;
                if (row == null)
                {
                    MessageBoxMy.Show("Please Select a Row First.");
                    return "";
                }
                selectedValue = row.Cells[colName].Value.ToString();
            }
            catch
            {

            }
            return selectedValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Primary Key of the table</returns>
        private string GetPrimaryKeyColumn()
        {
            //bool status = false;
            foreach (TableColumn col in _dataTableColumns)
            {
                if (col.IsPrimaryKeyColumn)
                {
                    _formDataTable.PrimaryKey = new DataColumn[] { _formDataTable.Columns[col.DisplayColumnAlias] };//Dhiraj
                    return col.DataTableColumn;
                }
            }

            throw new Exception("Primary Key column not set.");
            //return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Primary key of selected row</returns>
        public string GetSelectedRowPrimaryKey()
        {
            return GetSelectedRowValue(GetPrimaryKeyColumn());
        }
        #endregion

        #region search related


        private void PerformKeyPrressSearch(KeyPressEventArgs e)
        {
            //if escape key is pressed the clear all the data in keyPressData.
            if (e.KeyChar == 27)
            {
                _keyPressData = string.Empty;
                _lastKeyPressDateTime = DateTime.Now;
                e.KeyChar = new char();
                e.Handled = true;
                return;
            }

            if (_lastKeyPressDateTime.AddSeconds(2) < DateTime.Now)
            {
                _keyPressData = string.Empty;
            }

            _keyPressData += Convert.ToString((char)e.KeyChar);

            _lastKeyPressDateTime = DateTime.Now;
            string columnData = string.Empty;
            Console.WriteLine("Pressed key = {0}", _keyPressData);
            //first perform the search from current row to that last row
            //then perform search from 1st row to the current row.

            //performing search from current row to the last row.
            if (_dataGridView.CurrentRow == null)
                return;
            int i = _dataGridView.CurrentRow.Index + 1;
            i = (i >= _dataGridView.Rows.Count) ? 0 : i;
            bool status = false;
            status = KeyPressSearchGridViewColumn(i, _dataGridView.Rows.Count - 1, _dataGridView.CurrentCell.ColumnIndex, _keyPressData);
            if (status) return;
            //now perform search from 1st row to current row.
            if (i > 0)
            {
                status = KeyPressSearchGridViewColumn(0, _dataGridView.CurrentRow.Index, _dataGridView.CurrentCell.ColumnIndex, _keyPressData);
                if (status) return;
            }

            //same key press search.
            //for eg. suppose first key pressed is "s" and the user again pressess "s" as so now the composite text is "ss"
            //          if there is no string started from "ss" then it moves the cursor to the next cell in which the first character is "s"
            if (_keyPressData.Length == 2
                && _keyPressData.Substring(0).Equals(Convert.ToString((char)e.KeyChar)))
            {
                _keyPressData = Convert.ToString((char)e.KeyChar);

                //performing search from current row to the last row.
                i = _dataGridView.CurrentRow.Index + 1;
                i = (i >= _dataGridView.Rows.Count) ? 0 : i;
                status = KeyPressSearchGridViewColumn(i, _dataGridView.Rows.Count - 1, _dataGridView.CurrentCell.ColumnIndex, _keyPressData);
                if (status) return;
                //now perform search from 1st row to current row.
                if (i > 0)
                {
                    status = KeyPressSearchGridViewColumn(0, _dataGridView.CurrentRow.Index, _dataGridView.CurrentCell.ColumnIndex, _keyPressData);
                    if (status) return;
                }
            }
        }

        private bool KeyPressSearchGridViewColumn(int startRowIndex, int toRowIndex, int searchColumnIndex, string searchString)
        {
            string columnData = string.Empty;
            for (int i = startRowIndex; i <= toRowIndex; i++)
            {
                //acquire the column data.
                if (_dataGridView.Rows[i].Cells[searchColumnIndex].Value == null)
                    columnData = string.Empty;
                else
                    columnData = _dataGridView.Rows[i].Cells[searchColumnIndex].Value.ToString();

                if (searchString.Length <= columnData.Length)
                {
                    if (columnData.Substring(0, searchString.Length).Equals(searchString))
                    {
                        if (_dataGridView.Rows[i].Cells[searchColumnIndex].Visible)
                        {
                            _dataGridView.CurrentCell = _dataGridView.Rows[i].Cells[searchColumnIndex];
                            return true;
                        }
                    }
                }
            }
            return false;

        }

        #endregion

        #region other


        public double GridValueCalculate(DataGridView Grid, string gColName)
        {
            int row = 0;
            double val = 0;
            if (Grid.Rows.Count > 0)
            {
                for (row = 0; row < Grid.Rows.Count; row++)
                {
                    if (Grid.Rows[row].Cells[gColName].Value != null)
                    {
                        if (Grid.Rows[row].Cells[gColName].Value.ToString().Trim() != string.Empty)
                        {
                            //replace if comma 
                            val = val + Convert.ToDouble(Grid.Rows[row].Cells[gColName].Value.ToString().Trim().Replace(",", ""));
                        }
                    }
                }
                return val;
            }
            return val;
        }

        private bool ColumnSortable(string ColsName)
        {
            foreach (TableColumn col in _dataTableColumns)
            {
                try
                {
                    if (_dataGridView.Columns[col.DataTableColumn].Name.ToUpper().Trim() == ColsName.ToUpper().Trim())
                    {
                        if (DataTableColumns[col.DbColumnName].Type == ColumnTypes.Number || DataTableColumns[col.DbColumnName].Type == ColumnTypes.Amount
                            || DataTableColumns[col.DbColumnName].Type == ColumnTypes.AmountRound2
                            || DataTableColumns[col.DbColumnName].Type == ColumnTypes.AmountRound) //All the Number colun soring
                        {
                            if (!DataTableColumns[col.DbColumnName].isSortable) //columnType num,amout etc. isSortale true then not required...
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (DataTableColumns[col.DbColumnName].isSortable)
                            {
                                return true;

                            }
                        }
                    }
                }
                catch
                {
                    //error occurs do nothing...
                }
            }

            return false;
        }

        //private void PerformNumericComparision(DataGridViewSortCompareEventArgs e)
        //{
        //    if (e.Column.Name != "")
        //    {

        //        if (e.CellValue1 == null && e.CellValue2 == null)
        //        {
        //            e.SortResult = 0;
        //        }
        //        else if (e.CellValue1 == null && e.CellValue2 != null)
        //        {
        //            e.SortResult = -1;
        //        }
        //        else if (e.CellValue1 != null && e.CellValue2 == null)
        //        {
        //            e.SortResult = 1;
        //        }
        //        else
        //        {
        //            decimal d1 = 0, d2 = 0;
        //            d1 = Conversion.ToDecimal(e.CellValue1.ToString().Replace(",", ""));
        //            d2 = Conversion.ToDecimal(e.CellValue2.ToString().Replace(",", ""));

        //            if (d1 > d2)
        //                e.SortResult = 1;
        //            else if (d1 < d2)
        //                e.SortResult = -1;
        //            else
        //                e.SortResult = 0;
        //            e.Handled = true;
        //        }
        //    }
        //}

        #endregion
        #endregion

        #region Event Handlers
        #region Events
        private void AttachDataGridViewEvents()
        {
            //_dataGridView.DoubleClick += new EventHandler(dataGridView_DoubleClick);
            _dataGridView.KeyDown += new KeyEventHandler(dataGridView_KeyDown);
            _dataGridView.KeyPress += new KeyPressEventHandler(dataGridView_KeyPress);
            _dataGridView.Sorted += new EventHandler(dataGridView_Sorted);
            _dataGridView.MouseDoubleClick += new MouseEventHandler(dataGridView_MouseDoubleClick);
            //_dataGridView.SortCompare += new DataGridViewSortCompareEventHandler(dataGridView__SortCompare);
            _dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(dataGridView_ColumnHeaderMouseClick);
            _dataGridView.SelectionChanged += new EventHandler(_dataGridView_SelectionChanged);
        }
        void _dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //if (blnTakeSelectionChange)
            //{
            //    currentRowIndex = _dataGridView.Rows.Count == 0 ? -1 : _dataGridView.CurrentCell.RowIndex;
            currentCellIndex = _dataGridView.Rows.Count == 0 ? -1 : _dataGridView.CurrentCell.ColumnIndex;
            //    System.Diagnostics.Debug.WriteLine(currentRowIndex.ToString());
            //}
        }

        #endregion
        protected override void OnActivated(EventArgs e)
        {
            if (IsFirstTime)
            {
                if (_loadDataInFormLoad)
                {
                    if (FormType == FormTypes.ListingForm
                        || FormType == FormTypes.SelectionForm
                        || FormType == FormTypes.MultipleSelect
                        )
                    {
                        this.Refresh();
                        LoadData();
                    }
                }
            }
            base.OnActivated(e);
        }

        private DateTime _lastKeyPressDateTime = DateTime.Now;
        private string _keyPressData = string.Empty;
        void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                _keyPressData = string.Empty;
                e.Handled = true;

                ////dataGridView_DoubleClick(sender, new EventArgs());
                switch (FormType)
                {

                    case FormTypes.MultipleSelect:
                        //_dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                        if (ListingDataGridView != null)
                        {
                            if (ListingDataGridView.Rows.Count > 0)
                            {
                                ListingDataGridView.CurrentRow.Cells[0].Value = true;

                            }
                        } //ms
                        break;

                    case FormTypes.SelectionForm:
                        ReturnSelectedValue();
                        break;
                    case FormTypes.ListingForm:
                        OpenEditForm();
                        break;
                    default:
                        throw new Exception(string.Format("Feature not supported by the FormType =>{0}", FormType.ToString()));
                }
            }
            else
            {
                PerformKeyPrressSearch(e);
            }
        }

        void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (this.KeyPreview)
                {
                    if (!this.IsMultiplegridSort)
                        Delete();
                }
            }

            //throw new Exception("The method or operation is not implemented.");

        }

        void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            ////when the user presses enter key open the edit form
            ////SetPrimaryKeyValue();
            ////DataGridView.HitTestInfo hitTest = _dataGridView.HitTest(_dataGridView.Columnh
            ////MessageBox.Show(_dataGridView.HitTest().RowIndex);
            //switch(FormType)
            //{
            //    case FormTypes.SelectionForm:
            //        ReturnSelectedValue();
            //        break;
            //    case FormTypes.ListingForm:
            //        OpenEditForm();
            //        break;
            //    default:
            //        throw new Exception(string.Format("Feature not supported by the FormType =>{0}", FormType.ToString()));
            //}
        }

        void dataGridView_Sorted(object sender, EventArgs e)
        {
            //After sorting is completed resuffle the Row serial No if exists any.
            if (_displayRowSerialNo)
            {
                int cnt = 0;
                foreach (DataGridViewRow row in _dataGridView.Rows)
                {
                    row.HeaderCell.Value = Convert.ToString(++cnt); ;
                    //_dataGridView.AutoResizeRowHeadersWidth(cnt - 1, DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);
                }
            }

        }

        private string getdbColName(string dgvColName)
        {
            foreach (TableColumn col in _dataTableColumns)
            {
                string s = _dataTableColumns[1].DbColumnName;
                if (col.DataTableColumn == dgvColName)
                {
                    return col.DbColumnName;
                }
            }
            return "";
        }
        private string GetDisplayColumnAlias(string dgvColName)
        {
            foreach (TableColumn col in _dataTableColumns)
            {
                string s = _dataTableColumns[1].DbColumnName;
                if (col.DataTableColumn == dgvColName)
                {
                    return col.DisplayColumnAlias;
                }
            }
            return "";
        }
        Dictionary<string, string> Sortorder = new Dictionary<string, string>();
        object oldPk;
        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_dataGridView .Rows .Count <1)
            {
                return;
            }
            string sortoderstring = "";
            string dgvcolname = "";
            string colname = "";
            bool clear = true;
            System.Diagnostics.Debug.Print("nowpk = = = " + PrimaryKeyValue.ToString());
            //
            //Track the row
            // int currentRowIndex = _dataGridView.Rows.Count == 0 ? -1 : _dataGridView.CurrentCell.RowIndex;
            SetPrimaryKeyValue();

            oldPk = PrimaryKeyValue;
            System.Diagnostics.Debug.Print("oldpk = = = " + oldPk.ToString());
            //
            dgvcolname = _dataGridView.Columns[e.ColumnIndex].Name.ToString();
            // colname = getdbColName(dgvcolname);
            colname = GetDisplayColumnAlias(dgvcolname);
            if (colname.Trim() == "")
                return;
            if (Sortorder.ContainsKey(colname) & Sortorder.Count == 1)
            {
                clear = false;
            }
            else
            {
                clear = true;
            }
            if (ModifierKeys != Keys.Control & clear)
            {
                Sortorder.Clear();
            }
            //if (ModifierKeys != Keys.Control)
            //{
            //    string j = "";
            //}
            if (Sortorder.ContainsKey(colname))
            {
                if (Sortorder[colname].ToString() == "ASC")
                {
                    Sortorder[colname] = "DESC";
                }
                else
                {
                    Sortorder[colname] = "ASC";
                }

            }
            else
            {
                Sortorder.Add(colname, "ASC");
            }


            foreach (string sortorde in Sortorder.Keys)
            {
                sortoderstring = sortoderstring + sortorde + " " + Sortorder[sortorde].ToString() + ",";

            }
            sortoderstring = sortoderstring.Remove(sortoderstring.Length - 1, 1);

            //            _formDataTable.DefaultView.Sort = sortoderstring;

            DataView v = new DataView(_formDataTable);
            v.Sort = sortoderstring;
            _formDataTable = v.ToTable();
            //find row index from pk 

            SetPrimaryKeyValue();

            DataRow foundRow = _formDataTable.Rows.Find(oldPk);

            int rowindex = _formDataTable.Rows.IndexOf(foundRow);

            currentPage_ = getPageNo(rowindex, pageSize_);
            currentRowIndex = getGridRowNo(rowindex, pageSize_);

            System.Diagnostics.Debug.Print("pgn= " + currentPage_.ToString() + "gri: " + currentRowIndex.ToString() + " dtri: " + rowindex.ToString() + " pkv: " + PrimaryKeyValue.ToString());


            currentPage = currentPage_;
            System.Diagnostics.Debug.Print("--------------------------after:" + PrimaryKeyValue.ToString());
        }

        //void dataGridView__SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        //{
        //    //if (ColumnSortable(e.Column.Name))
        //    //{
        //    //    if (_IsMultiplegridSort)
        //    //    {
        //    //        return;
        //    //    }
        //    //    PerformNumericComparision(e);
        //    //}
        //}

        void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_dataGridView.HitTest(e.X, e.Y).RowY < 5)
                return;

            if (e.Button != MouseButtons.Left)
                return;
            //when the user presses enter key open the edit form
            //SetPrimaryKeyValue();
            //DataGridView.HitTestInfo hitTest = _dataGridView.HitTest(_dataGridView.Columnh
            //MessageBox.Show(_dataGridView.HitTest().RowIndex);
            switch (FormType)
            {
                case FormTypes.MultipleSelect:
                    //_dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                    if (ListingDataGridView != null)
                    {
                        if (ListingDataGridView.Rows.Count > 0)
                        {
                            ListingDataGridView.CurrentRow.Cells[0].Value = true;
                        }
                    } //ms
                    break;
                case FormTypes.SelectionForm:
                    ReturnSelectedValue();
                    break;
                case FormTypes.ListingForm:
                    OpenEditForm();
                    break;
                default:
                    break;
                //  throw new Exception(string.Format("Feature not supported by the FormType =>{0}", FormType.ToString()));
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            //base.OnKeyDown(e);
            if (e.KeyCode == Keys.F5)
            {
                if (!_dataGridView.Focus())
                {
                    _dataGridView.Focus();
                }
                else
                {
                    SendKeys.Send("{BKSP}");
                    ActiveControl.Select();
                    ActiveControl.Focus();
                }
            }
            //this keys Returning Any form Active Control Name and Form Name for Programmers..
            else if (e.Modifiers == Keys.Control && e.KeyValue == 49) //Ctrl + 1
            {
                MessageBox.Show(this.Name + ": Control Name : " + this.ActiveControl.Name + "Control TabIndex : " + this.ActiveControl.TabIndex, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {  //Key board events
            base.OnKeyPress(e);
            if (e.KeyChar == 14)//Ctrl+N
            {
                OpenNewForm();
            }
            else if (e.KeyChar == 5)//Ctrl+E
            {
                OpenEditForm();
            }
            else if (e.KeyChar == 4)//Ctrl+D
            {
                if (this.KeyPreview)
                {
                    if (!this.IsMultiplegridSort)
                        Delete();
                }
            }
            else if (e.KeyChar == 1) //Ctrl + A for Text box text selected and deleted...
            {
                if (ActiveControl is TextBox)
                {
                    TextBox TxtBox = (TextBox)ActiveControl;
                    TxtBox.SelectAll(); //Text higlighted..
                }
            }

        }
        #endregion


        #region Checkbox Col
        private bool _selectAll = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chekBoxColumn">the chekbox column in datagridveiw that gives checked unchecked</param>
        /// <returns>datatable</returns>
        private DataTable datagridviewTodatatable(string chekBoxColumn)
        {
            DataGridView dgv = _dataGridView;
            DataTable dt = new DataTable();
            int rcnt = -1;
            foreach (DataGridViewColumn dgvc in dgv.Columns)
            {
                if (dgvc.Name != chekBoxColumn)
                {
                    dt.Columns.Add(dgvc.Name);
                }

            }
            foreach (DataGridViewRow oRow in dgv.Rows)
            {
                if (oRow.Cells[chekBoxColumn].Value != null)
                {
                    if (oRow.Cells[chekBoxColumn].Value.ToString().ToLower() == "true")
                    {
                        rcnt++;
                        dt.Rows.Add();
                        foreach (DataGridViewColumn dgvc in dgv.Columns)
                        {
                            if (dgvc.Name != chekBoxColumn)
                            {
                                dt.Rows[rcnt][dgvc.Name] = oRow.Cells[dgvc.Name].Value;
                            }
                        }
                    }
                }
            }
            return dt;
        }

        private bool addSelectCol(string name, string Header, int index, bool defaultValue)
        {
            try
            {
                DataGridViewCheckBoxColumn dgvc = new DataGridViewCheckBoxColumn();
                dgvc.Name = name;
                dgvc.HeaderText = Header;

                //dgvc.DisplayIndex = index;
                ListingDataGridView.Columns.Insert(0, dgvc);
                this.ListingDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
                this.ListingDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender,
          DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                _selectAll = !_selectAll;
                for (int i = 0; i < _dataGridView.Rows.Count; i++)
                {
                    _dataGridView.Rows[i].Cells[0].Value = _selectAll;
                }
            }
        }

        public void MultiSelectSelectAll()
        {
            _selectAll = !_selectAll;
            for (int i = 0; i < _dataGridView.Rows.Count; i++)
            {
                _dataGridView.Rows[i].Cells[0].Value = _selectAll;
            }
        }


        public DataTable GetMultiSelectDataTable()
        {
            return datagridviewTodatatable("colselect");
        }
        public override void MakeMultiSelect()
        {
            addSelectCol("colselect", "Select", 1, false);
            base.MakeMultiSelect();
        }


        private void dataGridView1_CellPainting(object sender,
            DataGridViewCellPaintingEventArgs e)
        {
            //Is this the checkbox column header?
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                try
                {
                    //Erase the cell
                    using (Brush backColorBrush =
                        new SolidBrush(e.CellStyle.BackColor))
                    {
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                    }

                    //Draw 1 bottom line...
                    e.Graphics.DrawLine(Pens.DarkGray, e.CellBounds.Left,
                        e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                    //Draw 2 top lines...
                    e.Graphics.DrawLine(Pens.DarkGray, e.CellBounds.Left,
                        e.CellBounds.Top, e.CellBounds.Right, e.CellBounds.Top);
                    e.Graphics.DrawLine(Pens.White, e.CellBounds.Left,
                        e.CellBounds.Top + 1, e.CellBounds.Right, e.CellBounds.Top + 1);
                    //Draw right line...
                    e.Graphics.DrawLine(Pens.DarkGray, e.CellBounds.Right - 1,
                        e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                    //Draw left line...
                    e.Graphics.DrawLine(Pens.White, e.CellBounds.Left,
                        e.CellBounds.Top, e.CellBounds.Left, e.CellBounds.Bottom);

                    //Get the image from the resource file
                    Image imgChecked = global::Friuts.Properties.Resources._checked;// ; (Image)Resourc._checked;
                    Image imgUnchecked = global::Friuts.Properties.Resources._unchecked;//.previous; (Image)Resource1._unchecked;

                    //Determine paint coordinates
                    int X = e.CellBounds.Left +
                        ((e.CellBounds.Width - imgChecked.Width) / 2) - 1;
                    int Y = e.CellBounds.Top +
                        ((e.CellBounds.Height - imgChecked.Height) / 2) - 1;

                    //Draw checkbox in header
                    if (_selectAll)
                        e.Graphics.DrawImage(imgChecked, X, Y);
                    else
                        e.Graphics.DrawImage(imgUnchecked, X, Y);

                    //Set event as handled
                    e.Handled = true;
                }
                catch
                {
                    throw;
                    //Handle exception
                }
            }
        }


        #endregion

        public void LoadDataTable(DataTable dt)
        {
            LoadDataInFormLoad = false;
            FormDataTable = dt;
            LoadDataIntoDataGrid();
        }

        public decimal GetSum(string ColumnName)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in _dataGridView.Rows)
            {
                total += Conversion.ToDecimal(row, ColumnName);
            }
            return total;
        }

        public decimal GetCheckedSum(string ColumnName)
        {
            string chekBoxColumn = "colselect";
            DataGridView dgv = _dataGridView;
            decimal total = 0;
            foreach (DataGridViewRow oRow in dgv.Rows)
            {
                if (oRow.Cells[chekBoxColumn].Value != null)
                {
                    if (oRow.Cells[chekBoxColumn].Value.ToString().ToLower() == "true")
                    {
                        total += Conversion.ToDecimal(oRow, ColumnName);
                    }
                }
            }


            return total;
        }
    }
}

