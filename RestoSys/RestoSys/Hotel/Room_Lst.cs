using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using RestoSys.DAl;
using RestoSys.Hotel;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class Room_Lst : Friuts.ListingFormBase
    {
        public Room_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            pageSize = 15;
        }

        private DataGridViewCellStyle bookedRoomRowStyle = new DataGridViewCellStyle();
        private DataGridViewCellStyle occupiedRoomRowStyle = new DataGridViewCellStyle();

        private void List_Load(object sender, EventArgs e)
        {
            lblBookedRoom.BackColor = bookedRoomRowStyle.BackColor = System.Drawing.Color.Yellow ;
            lblOccupiedRoom.BackColor = occupiedRoomRowStyle.BackColor = System.Drawing.Color.Red;
            bookedRoomRowStyle.SelectionBackColor = System.Drawing.Color.Fuchsia;
            occupiedRoomRowStyle.SelectionBackColor = System.Drawing.Color.Fuchsia;

            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.FormName = this;
            loader.ComboLoadinfoItems.Add("ID", "Title", "Hotel_RoomType", cboroomType, false);
            loader.LoadDataInComboBoxes();


            //<Listing>
            TableName = "Hotel_Master_Room";
            DataTableColumns.Add("id", ColumnTypes.Number, "colid", true, true);
            DataTableColumns.Add("Name", ColumnTypes.String, "colName");
            DataTableColumns.Add("CASE WHEN isDormitory = '1' THEN 'Yes'  Else 'No' END u", ColumnTypes.String, "colDormitory", false, true, true, "u");
            RelationList.Add("fk_Hotel_RoomType", "Hotel_RoomType", "id", "Title", "colRoomType");

            //DataTableColumns.Add("isDormitory", ColumnTypes.AmountRound, "colDormitory");
            DataTableColumns.Add("perRoomRate", ColumnTypes.AmountRound, "colPerRoomRate");
            DataTableColumns.Add("perPersonRate", ColumnTypes.AmountRound, "colPerPersonRate");
            DataTableColumns.Add("facilities", ColumnTypes.String, "colfacilities");
            DataTableColumns.Add("maxnos", ColumnTypes.Number, "colmaxnos");
            DataTableColumns.Add("remarks", ColumnTypes.String, "colremarks");
            if (FormType == FormTypes.SelectionForm)
            {
                this.Text = "Double click required room to select it";
                toolStrip1.Visible = false;
                panel.Height = panel.Bottom - toolStrip1.Top;
                panel.Top = toolStrip1.Top;
            }
        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }
        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new Room_Ent());
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new Room_Ent());
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }


        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, grid);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cboroomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public override bool LoadData()
        {
            bool b = base.LoadData();
            //DataTable dtBooked = HotelDAL.GetNotFreeRoomsIds(DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("yyyyMMdd"));
            DataTable dtBooked = HotelDAL.GetRoomsIds(DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("yyyyMMdd"), BookingStatus.Booked);
            DataTable dtOccupied = HotelDAL.GetRoomsIds(DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("yyyyMMdd"), BookingStatus.Occupied);

            foreach (DataGridViewRow item in grid.Rows)
            {
                if (dtBooked.Select("fk_Hotel_Master_Room = '" + item.Cells["colId"].Value.ToString() + "'").Length > 0)
                {
                    item.DefaultCellStyle = bookedRoomRowStyle;
                }
                else if (dtOccupied.Select("fk_Hotel_Master_Room = '" + item.Cells["colId"].Value.ToString() + "'").Length > 0)
                {
                    item.DefaultCellStyle = occupiedRoomRowStyle;
                }

            }
            return b;
        }

        public override string GetWhereClauseForSelect()
        {
            StringBuilder SQL = new StringBuilder();
            ComboItem citem;
            SQL.AppendLine("WHERE 1=1 ");
            if (cboroomType.Text != "")
            {
                citem = (ComboItem)cboroomType.SelectedItem;

                SQL.Append(" \n AND  fk_Hotel_RoomType=" + citem.Key.ToString());
            }

            if (txtName.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND Name like '%{0}%'", txtName.Text.Trim());
            }

            return SQL.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ReturnSelectedValue();
            DialogResult = DialogResult.OK;
        }
    }
}
