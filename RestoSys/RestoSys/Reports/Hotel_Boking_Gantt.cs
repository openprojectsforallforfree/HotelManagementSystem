using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestoSys.DAl;
using Bsoft.Controls;
using Friuts;


namespace RestoSys.Reports
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class Hotel_Boking_Gantt : Friuts.ListingFormBase
    {
        public Hotel_Boking_Gantt()
        {
            InitializeComponent();
            dateFromTo21.dtFrom.ValueChanged += new EventHandler(dtFrom_ValueChanged);
            dateFromTo21.dtTo.ValueChanged += new EventHandler(dtTo_ValueChanged);
            ComboBoxDataLoader loader = new ComboBoxDataLoader();

            loader.ComboLoadinfoItems.Add("ID", "Title", "Hotel_RoomType", cboRoomType, false, ColumnTypes.Number, string.Empty);
            //loader.ComboLoadinfoItems.Add("ID", "Title", "Hotel_RoomType", cboRoomType , false);
            loader.ComboLoadinfoItems.AddDependent("Id", "Name", "Hotel_Master_Room", cboRoom, false, ColumnTypes.Number, cboRoomType, "fk_Hotel_RoomType");
            loader.LoadDataInComboBoxes();

        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void Hotel_Boking_Gantt_Load(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void DrawChart()
        {
            // this.Invalidate();
            DataTable dt = new DataTable();
            //if ((ComboItem)cboRoom.SelectedItem == null || ((ComboItem)cboRoom.SelectedItem).Key=="" )
            //{
            //    dt = HotelDAL.GetBookingTable(dateFromTo21.dtFrom.Value.ToString("yyyyMMdd"), dateFromTo21.dtTo.Value.ToString("yyyyMMdd"));
            //}
            //else
            //{

            string roomid = "";
            string roomtypeid = "";
           
            if ((ComboItem)cboRoom.SelectedItem!=null)
            {
                roomid = ((ComboItem)cboRoom.SelectedItem).Key; ;
            }
            if ((ComboItem)cboRoomType.SelectedItem != null)
            {
                roomtypeid = ((ComboItem)cboRoomType.SelectedItem).Key;
            }
           

            dt = HotelDAL.GetBookingTable(dateFromTo21.dtFrom.Value.ToString("yyyyMMdd"), dateFromTo21.dtTo.Value.ToString("yyyyMMdd"), roomtypeid , roomid);
            //}

            if (dt.Rows.Count < 1)
            {
                lblMessage.Visible = true;
                ganttChart1.Visible = false;
                ganttChart1.ClearChart();
            }
            else
            {
                ganttChart1.ClearChart();
                ganttChart1.RemoveBars();
                lblMessage.Visible = false;
                ganttChart1.Visible = true;
                DateTime dtFrm = new DateTime(dateFromTo21.dtFrom.Value.Year, dateFromTo21.dtFrom.Value.Month, dateFromTo21.dtFrom.Value.Day);
                DateTime dtt = new DateTime(dateFromTo21.dtTo.Value.Year, dateFromTo21.dtTo.Value.Month, dateFromTo21.dtTo.Value.Day);
                ganttChart1.DrawGanttChart(dt, dtFrm, dtt);
            }
        }

        private void ganttChart1_MouseMove(object sender, MouseEventArgs e)
        {

            List<string> toolTipText = new List<string>();

            if (ganttChart1.MouseOverRowText != null && ganttChart1.MouseOverRowText.Length > 0)
            {
                BarInformation val = (BarInformation)ganttChart1.MouseOverRowValue;
                toolTipText.Add("[b]Date:");
                toolTipText.Add("From ");
                toolTipText.Add(val.FromTime.ToShortDateString());
                toolTipText.Add("To ");
                toolTipText.Add(val.ToTime.ToShortDateString());
            }
            else
            {
                toolTipText.Add("");
            }

            ganttChart1.ToolTipTextTitle = ganttChart1.MouseOverRowText;
            ganttChart1.ToolTipText = toolTipText;

        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawChart();
        }
    }
}
