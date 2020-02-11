using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Friuts;

namespace RestoSys.Reports
{
    public partial class HotelSearchPanel : UserControl
    {
        public delegate void  serchNow();
        public event serchNow searchnow;
        public HotelSearchPanel()
        {
            InitializeComponent();
        }

        private void chkcheckedOut_CheckedChanged(object sender, EventArgs e)
        {
            searchnow();
        }

        private void chkCanceled_CheckedChanged(object sender, EventArgs e)
        {
            searchnow();
        }

        private void chkBooked_CheckedChanged(object sender, EventArgs e)
        {
            searchnow();
        }

        private void chkOccupied_CheckedChanged(object sender, EventArgs e)
        {
            searchnow();
        }

        private void cboDue_CheckedChanged(object sender, EventArgs e)
        {
            searchnow();
        }

        private void cboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchnow();
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchnow();
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchnow();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            searchnow();
        }

         
        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            dtFrom.MaxDate = dtTo.Value;
            searchnow();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            dtTo.MinDate = dtFrom.Value;
            searchnow();
        }

        private void HotelSearchPanel_Load(object sender, EventArgs e)
        {
            try
            {
                ComboBoxDataLoader loader = new ComboBoxDataLoader();
                loader.ComboLoadinfoItems.Add("ID", "EngName", "SuperAdmin_Rights_Users", cboUser, false);
                loader.LoadDataInComboBoxes();

                ComboBoxDataLoader loader1 = new ComboBoxDataLoader();

                loader1.ComboLoadinfoItems.Add("ID", "Title", "Hotel_RoomType", cboRoomType, false, ColumnTypes.Number, string.Empty);
                loader1.ComboLoadinfoItems.AddDependent("Id", "Name", "Hotel_Master_Room", cboRoom, false, ColumnTypes.Number, cboRoomType, "fk_Hotel_RoomType");
                loader1.LoadDataInComboBoxes();
            }
            catch { }
        }
    }
}
