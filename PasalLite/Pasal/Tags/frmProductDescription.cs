using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bsoft.Data;
using Bsoft.Controls;
using Friuts;
using System.Reflection;
using Bsoft.Common;
namespace Pasal.Tags
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmProductDescription : EntryFormBase
    {
        private string _ItemId = string.Empty;
        public string ItemID
        {
            get { return _ItemId; }
            set
            {
                _ItemId = value;
                SetData();
            }
        }


        public void LoadTags()
        {
            DataTable dtTagGroups = clsDataAccess.TagGroups;
            flwTags.Controls.Clear();
            //For each tag group add a control in flow layout
            foreach (DataRow drTagGroups in dtTagGroups.Rows)
            {
                LblGeneric cntrl = new LblGeneric();
                cntrl.Lable = drTagGroups["Title"].ToString();
                string grpid = drTagGroups["Id"].ToString();
                string tagType = drTagGroups["Type"].ToString();
                cntrl.Tag = grpid;
                cntrl.comboBox .Tag = grpid;
                switch (tagType)
                {
                    case "Date":
                        cntrl.ControlType = LblGeneric.ControlTypes.DateTimePicker;
                        cntrl.dateTimePicker.ShowCheckBox = true;
                        cntrl.dateTimePicker.Format = DateTimePickerFormat.Custom;
                        cntrl.dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
                        if (cntrl.dateTimePicker.Checked)
                        {
                            cntrl.dateTimePicker.CustomFormat = "dd-MMM-yyyy";
                        }
                        else
                        {
                            cntrl.dateTimePicker.CustomFormat = " ";
                        }

                        break;
                    case "Color":
                        cntrl.ControlType = LblGeneric.ControlTypes.ComboBox;
                        cntrl.comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                        cntrl.comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cntrl.comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        cntrl.comboBox.DrawMode = DrawMode.OwnerDrawFixed;
                        cntrl.comboBox.FlatStyle = FlatStyle.Standard;
                        cntrl.comboBox.DrawItem += cmbboxClr_DrawItem;
                        //Add color items in the combo
                        Type colorType = typeof(System.Drawing.Color);
                        PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
                        cntrl.comboBox.Items.Add("No Color");
                        foreach (PropertyInfo c in propInfoList)
                        {
                            cntrl.comboBox.Items.Add(c.Name);
                        }
                        cntrl.comboBox.DrawItem += cmbboxClr_DrawItem;

                        break;
                    default:
                        cntrl.ControlType = LblGeneric.ControlTypes.ComboBox;
                        // Add all Entry that are entered
                        //Load combo
                        ComboBoxDataLoader loader = new ComboBoxDataLoader();
                        ComboLoadInfo cload = new ComboLoadInfo("ID", "Value", "tag", cntrl.comboBox, false, ColumnTypes.String, "TagGroupId = " + grpid);
                        cload.AddItem = true;
                        cload.AddNew += new ComboLoadInfo.AddNewHandler(cload_AddNew);
                        loader.ComboLoadinfoItems.Add(cload);
                        loader.LoadDataInComboBoxes();

                        break;
                }
                flwTags.Controls.Add(cntrl);

                //DataTable tags = clsDataAccess.tags(grpid);
            }
        }

        private void SetData()
        {
            DataTable dtcurrentlySavedTags = clsDataAccess.GetTags(_ItemId);
            DataTable dtTagGroups = clsDataAccess.TagGroups;

            //For each tag group add a control in flow layout

            foreach (Control cntrl in flwTags.Controls)
            {
                if (cntrl is LblGeneric)
                {
                    LblGeneric lblcntrl = (LblGeneric)cntrl;
                    string grpId = lblcntrl.Tag.ToString();
                    //string tagType=
                    switch (lblcntrl.ControlType)
                    {
                        case LblGeneric.ControlTypes.TextBox:
                            if (lblcntrl.textBox.Text.Trim() != "")
                            {

                            }
                            break;
                        case LblGeneric.ControlTypes.DateTimePicker:

                            string iTAg2 = "";
                            iTAg2 = (from DataRow dr in dtcurrentlySavedTags.Rows
                                     where dr["Taggroupid"].ToString() == grpId
                                     select dr["value"].ToString()).FirstOrDefault();
                            if (iTAg2 != null)
                            {
                                lblcntrl.dateTimePicker.Checked = true;
                                lblcntrl.dateTimePicker.CustomFormat = "dd-MMM-yyyy";
                                int year = iTAg2.Substring(0, 4).ToInt();
                                int mnth = iTAg2.Substring(4, 2).ToInt();
                                int Day = iTAg2.Substring(6, 2).ToInt();
                                lblcntrl.dateTimePicker.Value = new DateTime(year, mnth, Day);
                            }
                            else
                            {
                                lblcntrl.dateTimePicker.Checked = false;
                                lblcntrl.dateTimePicker.CustomFormat = " ";
                            }
                            break;

                        case LblGeneric.ControlTypes.ComboBox:
                            
                            //select value
                            string iTAg1 = "";
                            iTAg1 = (from DataRow dr in dtcurrentlySavedTags.Rows
                                     where dr["Taggroupid"].ToString() == grpId
                                     select dr["value"].ToString()).FirstOrDefault();
                            if (iTAg1 != null)
                            {
                                ComboUtilities.SelectComboBoxItemUsingValue(lblcntrl.comboBox, iTAg1, false);
                            }
                            break;
                        default:
                            break;
                    }

                }

          


            }
        }

        private void LoadDatadepricate()
        {
            DataTable dtcurrentlySavedTags = clsDataAccess.GetTags(_ItemId);
            DataTable dtTagGroups = clsDataAccess.TagGroups;
            flwTags.Controls.Clear();
            //For each tag group add a control in flow layout
            foreach (DataRow drTagGroups in dtTagGroups.Rows)
            {
                LblGeneric cntrl = new LblGeneric();
                cntrl.Lable = drTagGroups["Title"].ToString();
                string grpid = drTagGroups["Id"].ToString();
                string tagType = drTagGroups["Type"].ToString();
                cntrl.Tag = grpid;
                cntrl.comboBox.Tag = grpid;
                switch (tagType)
                {
                    case "Date":
                        cntrl.ControlType = LblGeneric.ControlTypes.DateTimePicker;
                        cntrl.dateTimePicker.ShowCheckBox = true;
                        cntrl.dateTimePicker.Format = DateTimePickerFormat.Custom;
                        cntrl.dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
                        if (cntrl.dateTimePicker.Checked)
                        {
                            cntrl.dateTimePicker.CustomFormat = "dd-MMM-yyyy";
                        }
                        else
                        {
                            cntrl.dateTimePicker.CustomFormat = " ";
                        }
                        //Select the saved item
                        string iTAg2 = "";
                        iTAg2 = (from DataRow dr in dtcurrentlySavedTags.Rows
                                 where dr["Taggroupid"].ToString() == grpid
                                 select dr["value"].ToString()).FirstOrDefault();
                        if (iTAg2 != null)
                        {
                            cntrl.dateTimePicker.Checked = true;
                            cntrl.dateTimePicker.CustomFormat = "dd-MMM-yyyy";
                            int year = iTAg2.Substring(0, 4).ToInt();
                            int mnth = iTAg2.Substring(4, 2).ToInt();
                            int Day = iTAg2.Substring(6, 2).ToInt();
                            cntrl.dateTimePicker.Value = new DateTime(year, mnth, Day);
                        }
                        else
                        {
                            cntrl.dateTimePicker.Checked = false;
                            cntrl.dateTimePicker.CustomFormat = " ";
                        }
                        break;
                    case "Color":
                        cntrl.ControlType = LblGeneric.ControlTypes.ComboBox;
                        cntrl.comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                        cntrl.comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cntrl.comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        cntrl.comboBox.DrawMode = DrawMode.OwnerDrawFixed;
                        cntrl.comboBox.FlatStyle = FlatStyle.Standard;
                        //Add color items in the combo
                        Type colorType = typeof(System.Drawing.Color);
                        PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
                        cntrl.comboBox.Items.Add("No Color");
                        foreach (PropertyInfo c in propInfoList)
                        {
                            cntrl.comboBox.Items.Add(c.Name);
                        }
                        cntrl.comboBox.DrawItem += cmbboxClr_DrawItem;
                        //select value
                        string iTAg1 = "";
                        iTAg1 = (from DataRow dr in dtcurrentlySavedTags.Rows
                                 where dr["Taggroupid"].ToString() == grpid
                                 select dr["value"].ToString()).FirstOrDefault();
                        if (iTAg1 != null)
                        {
                            ComboUtilities.SelectComboBoxItemUsingValue(cntrl.comboBox, iTAg1, false);
                            // SelectComboValue(cntrl.comboBox, iTAg1);
                        }

                        break;
                    default:
                        cntrl.ControlType = LblGeneric.ControlTypes.ComboBox;
                        // Add all Entry that are entered
                        //Load combo
                        ComboBoxDataLoader loader = new ComboBoxDataLoader();
                        ComboLoadInfo cload = new ComboLoadInfo("ID", "Value", "tag", cntrl.comboBox, false, ColumnTypes.String, "TagGroupId = " + grpid);
                        cload.AddItem = true;
                        cload.AddNew += new ComboLoadInfo.AddNewHandler(cload_AddNew);
                        loader.ComboLoadinfoItems.Add(cload);
                        loader.LoadDataInComboBoxes();
                        //Select the saved item
                        string iTAg = "";
                        iTAg = (from DataRow dr in dtcurrentlySavedTags.Rows
                                where dr["Taggroupid"].ToString() == grpid
                                select dr["tagid"].ToString()).FirstOrDefault();
                        if (iTAg != null)
                        {
                            SelectComboValue(cntrl.comboBox, iTAg);
                        }

                        break;
                }
                flwTags.Controls.Add(cntrl);

                //DataTable tags = clsDataAccess.tags(grpid);
            }
        }
        public frmProductDescription()
        {
            InitializeComponent();

            ComboLoadInfo.AddItemString = "Add new";


        }

        void cload_AddNew(object sender, string message)
        {
            ComboLoadInfo cli;
            cli = (ComboLoadInfo)sender;
            string grpid = cli.ComboBox.Tag.ToString();
            //UEMS.Tag_Lst a = new UEMS.Tag_Lst(grpid);
            //a.FormType = FormTypes.Selcttionform ;
            //a.ShowDialog();

            UEMS.Tag_Ent a = new UEMS.Tag_Ent("Tag", grpid);
            a.FormType = FormTypes.EntryForm;

            if (a.ShowDialog() == DialogResult.OK)
            {
                string newValue = a.txtValue.Text;
                //load data
                ComboBoxDataLoader loader = new ComboBoxDataLoader();
                ComboLoadInfo cload = new ComboLoadInfo("ID", "Value", "tag", cli.ComboBox, false, ColumnTypes.String, "TagGroupId = " + grpid);
                cload.AddItem = true;
                cload.AddNew += new ComboLoadInfo.AddNewHandler(cload_AddNew);
                loader.ComboLoadinfoItems.Add(cload);
                loader.LoadDataInComboBoxes();
                //ComboUtilities.SelectComboBoxItemUsingIndex(cli.ComboBox, cli.ComboBox.Items.Count - 2);
                ComboUtilities.SelectComboBoxItemUsingValue(cli.ComboBox, newValue);
            }
            else
            {
                //get back the old value
                DataTable dtcurrentlySavedTags = clsDataAccess.GetTags(_ItemId);
                string iTAg = "";
                iTAg = (from DataRow dr in dtcurrentlySavedTags.Rows
                        where dr["Taggroupid"].ToString() == grpid
                        select dr["tagid"].ToString()).FirstOrDefault();
                if (iTAg != null)
                {
                    SelectComboValue(cli.ComboBox, iTAg);
                }
                else
                {
                    cli.ComboBox.SelectedIndex = 0;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        public override bool Save()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TagGrpId");
            dt.Columns.Add("TagId");
            dt.Columns.Add("TagValue");

            foreach (Control cntrl in flwTags.Controls)
            {
                if (cntrl is LblGeneric)
                {
                    LblGeneric lblcntrl = (LblGeneric)cntrl;
                    string grpId = lblcntrl.Tag.ToString();
                    switch (lblcntrl.ControlType)
                    {
                        case LblGeneric.ControlTypes.TextBox:
                            if (lblcntrl.textBox.Text.Trim() != "")
                            {

                            }
                            break;
                        case LblGeneric.ControlTypes.DateTimePicker:
                            if (lblcntrl.dateTimePicker.Checked)
                            {
                                dt.Rows.Add(grpId, "", lblcntrl.dateTimePicker.Value.ToString("yyyyMMdd"));
                            }
                            break;
                        case LblGeneric.ControlTypes.ComboBox:
                            if (lblcntrl.comboBox.Text.Trim() != "")
                            {
                                dt.Rows.Add(grpId, "", lblcntrl.comboBox.SelectedItem.ToString());
                            }
                            break;
                        default:
                            break;
                    }

                }
            }
            clsDataAccess.SaveData(_ItemId, dt);
            return true;
        }

        private void cmbboxClr_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = ((DateTimePicker)sender);
            if (dtp.Checked)
            {
                dtp.CustomFormat = "dd-MMM-yyyy";
            }
            else
            {
                dtp.CustomFormat = " ";
            }

        }
    }
}
