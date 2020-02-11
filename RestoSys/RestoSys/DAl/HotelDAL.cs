using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bsoft.Data;
using Bsoft.Common;

namespace RestoSys.DAl
{
    class HotelDAL
    {
        /// <summary>
        /// Get current customers
        /// -- Active bookings, active occupancy , 
        /// Booking status can be active , canceled , taken
        /// Occupy status can be active , checkedout
        /// </summary>
        /// <returns></returns>
        public static DataTable GetBookingTable(string dtFrom, string dtTo)
        {
            StringBuilder SQL = new StringBuilder();
            SQL.AppendLine(@"select roomname as name ,
                           indate as dtfrom,
                           outdate  as dtto, 
                           customerName,
                           phone,
                           status  from Hotel_RoomBookingView
                           ");
            SQL.AppendFormat(@" where ((indate <= {0} and outdate >= {0}) 
                    or(indate <={1} and outdate >= {1} )
                    or(indate >={0} and outdate <= {1} ))", dtFrom, dtTo);

            DataTable dtbook = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            return dtbook;
        }

        //        public static DataTable GetBookingTable(string dtFrom, string dtTo,string roomId)
        //        {
        //            StringBuilder SQL = new StringBuilder();
        //            SQL.AppendLine(@"select roomname as name ,
        //                           indate as dtfrom,
        //                           outdate  as dtto, 
        //                           customerName,
        //                           phone,
        //                           status  from Hotel_RoomBookingView
        //                           ");
        //            SQL.AppendFormat(@" where fk_Hotel_Master_Room ={2} and ((indate <= {0} and outdate >= {0}) 
        //                    or(indate <={1} and outdate >= {1} )
        //                    or(indate >={0} and outdate <= {1} ))", dtFrom, dtTo,roomId );

        //            DataTable dtbook = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
        //            return dtbook;
        //        }

        public static DataTable GetBookingTable(string dtFrom, string dtTo, string roomTypeId, string roomId)
        {
            StringBuilder SQL = new StringBuilder();
            SQL.AppendLine(@"select roomname as name ,
                           indate as dtfrom,
                           outdate  as dtto, 
                           customerName,
                           phone,
                           status,
                           Hotel_RoomType.id as roomTypeId from Hotel_RoomBookingView left join Hotel_Master_Room on
                           Hotel_Master_Room.id = Hotel_RoomBookingView.fk_Hotel_Master_Room
                           left join Hotel_RoomType on Hotel_RoomType.id = Hotel_Master_Room.fk_Hotel_RoomType
                           ");
            SQL.AppendFormat(@" where ((indate <= {0} and outdate >= {0}) 
                    or(indate <={1} and outdate >= {1} )
                    or(indate >={0} and outdate <= {1} ))", dtFrom, dtTo);
            if (roomId.Length > 0)
            {
                SQL.AppendFormat(@" and fk_Hotel_Master_Room ={0}", roomId);
            }
            if (roomTypeId.Length > 0)
            {
                SQL.AppendFormat(@" and roomTypeId ={0} ", roomTypeId);
            }

            DataTable dtbook = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            return dtbook;
        }

        public static DataTable GetRoom(string id)
        {
            string SQL = string.Format(@"
                    select name As 'Room Name',
                    CASE WHEN isDormitory='1' THEN 'Dormitory' ELSE 'Normal Room' END as 'Room Type',
                    'Rs ' || PerPersonRate as 'Per Person Rate ',
                    'Rs ' || PerRoomRate as 'Per Room Rate' ,
                    maxnos as 'Maximum No',
                    remarks as Remarks    
                    from Hotel_Master_Room
                    where id = '{0}'", id);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());

            return dt;
        }

        public static string GetRoomName(string id)
        {
            string SQL = string.Format("select  name from Hotel_Master_Room where id = '{0}'", id);
            return GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
        }

        public static int GetMaxNoofPeople(string id)
        {

            string SQL = string.Format("select  maxnos from Hotel_Master_Room where id = '{0}'", id);
            return GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString().ToInt();
        }

        public static string GetPerPersonRate(string id)
        {

            string SQL = string.Format("select  PerPersonRate from Hotel_Master_Room where id = '{0}'", id);
            return GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
        }

        public static string GetPerRoomRate(string id)
        {

            string SQL = string.Format("select  PerRoomRate from Hotel_Master_Room where id = '{0}'", id);
            return GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
        }

        public static bool IsDormitory(string id)
        {
            string SQL = string.Format("select  isDormitory from Hotel_Master_Room where id = '{0}'", id);
            string isDormitory = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            if (isDormitory == "1")
            {
                return true;
            }
            return false;
        }

        public static string IsBookingApplicable(string customerID, string roomId, string indate, string outdate)
        {
            string SQL = string.Format(
                @"select * from Hotel_Bookings where fk_Hotel_Master_Room = {0} 
                    and ((indate <= {1} and indate >= {1}) 
                    or(indate <={2} and outdate >= {2} )
                    or(indate >={1} and outdate <= {2} ))
                    and fk_master_customer <> {3}", roomId, indate, outdate, customerID);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            if (dt.Rows.Count.ToInt() > 0)
            {
                return "This Date is booked";
            }
            else
            {
                return "";
            }
        }


        public static DataTable GetFreeRoomsId(string indate, string outdate)
        {
            string SQL = string.Format(
                @"select  id from Hotel_Master_Room 
where id not in (
SELECT
	fk_Hotel_Master_Room 
FROM Hotel_RoomBookingView   where 
 (  status = 'Booked' 
 OR status = 'Occupied' 
 )  and ((indate <= {0} and indate >= {0}) 
                    or(indate <={1} and outdate >= {1} )
                    or(indate >={0} and outdate <= {1} )))", indate, outdate);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            return dt;
        }

        public static DataTable GetNotFreeRoomsIds(string indate, string outdate)
        {
            string SQL = string.Format(
                @" 
SELECT
	fk_Hotel_Master_Room 
FROM Hotel_RoomBookingView   where 
(  status = 'Booked' 
 OR status = 'Occupied' 
 )
  and ((indate <= {0} and indate >= {0}) 
                    or(indate <={1} and outdate >= {1} )
                    or(indate >={0} and outdate <= {1} ))", indate, outdate);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            return dt;
        }

        public static DataTable GetRoomsIds(string indate, string outdate, string status)
        {
            string SQL = string.Format(
                @" 
SELECT
	fk_Hotel_Master_Room 
FROM Hotel_RoomBookingView   where 
status ='{2}'
  and ((indate <= {0} and indate >= {0}) 
                    or(indate <={1} and outdate >= {1} )
                    or(indate >={0} and outdate <= {1} ))", indate, outdate, status);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            return dt;
        }

        public static DataTable GetRoomsIds()
        {
                string SQL = @" SELECT * FROM Hotel_Master_Room  ";
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            return dt;
        }

        public static DataTable GetRoomsIds(List <string > freerooms)
        {

            //DataTableColumns.Add("id", ColumnTypes.Number, "colid", true, true);
            //DataTableColumns.Add("Name", ColumnTypes.String, "colName");
            //DataTableColumns.Add("CASE WHEN isDormitory = '1' THEN 'Yes'  Else 'No' END u", ColumnTypes.String, "colDormitory", false, true, true, "u");
            //RelationList.Add("fk_Hotel_RoomType", "Hotel_RoomType", "id", "Title", "colRoomType");

            ////DataTableColumns.Add("isDormitory", ColumnTypes.AmountRound, "colDormitory");
            //DataTableColumns.Add("perRoomRate", ColumnTypes.AmountRound, "colPerRoomRate");
            //DataTableColumns.Add("perPersonRate", ColumnTypes.AmountRound, "colPerPersonRate");
            //DataTableColumns.Add("facilities", ColumnTypes.String, "colfacilities");
            //DataTableColumns.Add("maxnos", ColumnTypes.Number, "colmaxnos");
            //DataTableColumns.Add("remarks", ColumnTypes.String, "colremarks");

            string SQL = @" SELECT Hotel_Master_Room.id as id,name,CASE WHEN isDormitory = '1' THEN 'Yes'  Else 'No' END u ,
 Title, perRoomRate,Perpersonrate,maxnos,Hotel_Master_Room.remarks as remarks
 FROM Hotel_Master_Room
left join Hotel_RoomType on Hotel_RoomType.id = Hotel_Master_Room.fk_Hotel_RoomType
where Hotel_Master_Room.id not in ({0}) ".With(string.Join(",", freerooms.ToArray()));
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            return dt;
        }
    }
}
