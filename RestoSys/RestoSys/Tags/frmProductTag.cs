using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bsoft.Data;
using Friuts;

namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmProductTag : Friuts.ListingFormBase
    {
        public frmProductTag()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            TableName = "Tag";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            //DataTableColumns.Add( "TagGroupId",ColumnTypes.Number,"colTagGroupId");
            RelationList.Add("TagGroupId", "TagGroup", "Id", "Title", "colTagGroupId", TableJoinTypes.LEFT_JOIN);
            DataTableColumns.Add("Value", ColumnTypes.String, "colValue");
        }

        private void frmProductTag_Load(object sender, EventArgs e)
        {
            //  tagsTabs.TabPages.Clear();
            string sql = "select * from taggroup";
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql);
            flwControls.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                Button btn = new Button();
                btn.Click += btnTagGrp_Click;
                btn.Text = dr["Title"].ToString();
                btn.Size = btnTagGrp.Size;
                btn.Font = btnTagGrp.Font;
                btn.TextAlign = btnTagGrp.TextAlign;
                btn.FlatStyle = btnTagGrp.FlatStyle;
                btn.Tag = dr["id"].ToString();
                flwControls.Controls.Add(btn);
                if (GrpId.Trim() == "")
                {
                    GrpId = btn .Tag.ToString ();
                }
            }
        }
       
        private void btnTagGrp_Click(object sender, EventArgs e)
        {
            GrpId = ((Button)sender).Tag.ToString();
            
        }
        private string _GrpId = string.Empty;
        public string GrpId
        {
            set 
            {
                _GrpId = value;
                string detail = GlobalResources.SelectDBConnection.ExecuteScalar("Select Remarks from taggroup where id = " + value ).ToString();
                if (detail.Trim() == "")
                {
                      detail = GlobalResources.SelectDBConnection.ExecuteScalar("Select Title from taggroup where id = " + value).ToString();
                }
                grid.Columns[2].HeaderText = detail;
                LoadData();
            }
            get {
                return _GrpId;
            }
        }

        public override bool LoadData()
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Integer, "TagGroupId", GrpId);
            return base.LoadData();
        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }
        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new Tag_Ent(TableName, GrpId));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new Tag_Ent(TableName, GrpId));
        }
    }
}
