using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.Data;

namespace RestoSys.DML
{
    class HotelDML
    {
        public static void createtables()
        {


            if (!GlobalResources.DbStruct.DoesTableExists("Hotel_Account"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE Hotel_Account(
id integer primary key autoincrement , 
Amount money,
PaidAmount money,
TenderAmount money,
ReturnAmount money,
Date varchar(15),
UserID varchar(50),
fk_Master_Customer integer ,CONSTRAINT FK_Master_Customer_fk_Master_Customer FOREIGN KEY (fk_Master_Customer) REFERENCES Master_Customer (Id))");
            }


            if (!GlobalResources.DbStruct.DoesTableExists("Hotel_Sales"))
            {
                
                DbHelpers.CreateATable(@" 
CREATE TABLE Hotel_Sales(
Id integer primary key autoincrement , 
fk_Master_Customer integer,
fk_Product integer,
bookingstaus varchar(10),
Rate money,
Quantity money,
Amount money,
Discount money,
VAT money,
ServiceCharge money,
NetAmount money,
dueamt money,
AccID varchar(150)  NOT NULL DEFAULT '',
Remarks varchar(150),
Date varchar(15),
UserID varchar(15),
fk_purchage integer,
CostPrice money,
canceldate varchar(15),
indate varchar(15),
outDate varchar(15),
CONSTRAINT FK_Master_Customer_Hotel_Sales FOREIGN KEY (fk_Master_Customer) REFERENCES Master_Customer (Id), 
CONSTRAINT FK_Master_Product_fk_Product FOREIGN KEY (fk_Product) REFERENCES Master_Product (Id), 
CONSTRAINT FK__fk_purchage FOREIGN KEY (fk_purchage) REFERENCES Inv_Purchase (Id))");
            }


            if (!GlobalResources.DbStruct.DoesTableExists("Hotel_RoomType"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE Hotel_RoomType(
Id integer primary key autoincrement , 
Title varchar(50),
Remarks varchar(150))");
            }


            if (!GlobalResources.DbStruct.DoesTableExists("Hotel_Master_Room"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE Hotel_Master_Room(
id integer primary key autoincrement , 
fk_Hotel_RoomType int,
Name varchar(50),
isDormitory varchar(1),
PerRoomRate money,
perpersonrate money,
facilities varchar(50),
maxnos int,
remarks varchar(150),CONSTRAINT FK_Hotel_RoomType_fk_Hotel_RoomType FOREIGN KEY (fk_Hotel_RoomType) REFERENCES Hotel_RoomType (Id))");
            }

            //RateType =R =>room RateType =P =>Per person
            if (!GlobalResources.DbStruct.DoesTableExists("Hotel_Bookings"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE Hotel_Bookings(
id integer primary key autoincrement , 
fk_Master_Customer integer,
fk_Hotel_Master_Room integer,
bookingstaus varchar(10),
indate varchar(15),
outDate varchar(15),
cancelDate varchar(15),
Rate money,
RateType varchar(1),
Quantity money,
Amount money,
Discount money,
VAT money,
ServiceCharge money,
NetAmount money,
dueamt money,
NoOfPerson money,
AccID varchar(150)  NOT NULL DEFAULT '',
Remarks varchar(150),
Date varchar(15),
UserId varchar(15),CONSTRAINT FK_Master_Customer_fk_Hotel_Bookings FOREIGN KEY (fk_Master_Customer) REFERENCES Master_Customer (Id), 
CONSTRAINT fk_Hotel_Master_Room_fk_Hotel_Master_Room FOREIGN KEY (fk_Hotel_Master_Room) REFERENCES Hotel_Master_Room (Id))");
            }

           
        }

        public static void createViews()
        {

            if (!GlobalResources.DbStruct.DoesViewExists("Hotel_RoomView"))
            {
                DbHelpers.createAView("Hotel_RoomView", @"
            select 
r.id as id ,
rt.id as roomtypeId,
r.Name as name,
r.isDormitory as isDormitory,
r.PerRoomRate as PerRoomRate,
r.Perpersonrate as perpersonrate,
r.facilities as facilities,
r.maxnos as maxnos,
r.remarks as remarks,
rt.remarks as roomtype_remarks,
rt.title as roomType
 from Hotel_Master_Room r
left join hotel_roomtype rt on 
r.fk_Hotel_RoomType = rt.id ");
            }
            if (!GlobalResources.DbStruct.DoesViewExists("Hotel_RoomBookingView"))
            {
                DbHelpers.createAView("Hotel_RoomBookingView", @"
                      select  b.id as id ,
                        r.Name as RoomName ,
                        r.RoomType as RoomType,
                        r.id as fk_Hotel_Master_Room,
                        b.Rate as RoomRate,
                        c.Name || ' ' || c.LastName as CustomerName, 
                        c.Phone as Phone,
                        b.bookingstaus as status, 
                        b.dueamt as dueamt,
                        b.indate as indate ,
                        b.outDate  as outDate,
                        b.AccID as Accid,
                        b.DATE as BookinDate,
                        b.UserID as UserId
                        from Hotel_Bookings  b
                        left join Hotel_RoomView r on
                        b.fk_Hotel_Master_Room = r.id 
                        left join master_customer c on
                        b.fk_Master_Customer = c.Id
                        ");

            }
            if (!GlobalResources.DbStruct.DoesViewExists("Hotel_ProductSales_View"))
            {
                DbHelpers.createAView("Hotel_ProductSales_View", @"
                select 
                    s.id as id,
                    AccID,
                    fk_master_customer,
                    fk_product,
                    bookingstaus, 
                    s.rate rate,
                    s.Quantity Quantity ,
                    0 INDATE,
                    0 OUTDATE,
                    amount,
                    discount,
                    vat,
                    servicecharge ,
                    netamount,
                    dueamt,
                    date,
                    s.userID as userID,
                    'hotel_sales' as tablename,
                    c.Name || ' ' || c.LastName as CustomerName,
                    c.Phone as Phone,
                    r.Name as ProductName,
                    pg.Name as ProductType
                    from Hotel_Sales s left join Master_Customer c
                    on s.fk_Master_Customer = c.id
                    left join Master_Product r on 
                    s.fk_Product  = r.id 
                    left join Master_Product_Group pg on pg.id = r.fk_Group");
            }
            if (!GlobalResources.DbStruct.DoesViewExists("Hotel_RoomSales_View"))
            {
                DbHelpers.createAView("Hotel_RoomSales_View", @"
                select 
                    s.id as id,
                    AccID,
                    fk_master_customer,
                    fk_Hotel_Master_Room as fk_Product  ,
                     bookingstaus, 
                    s.rate rate,
                    s.Quantity Quantity ,
                    S.INDATE INDATE,
                    S.OUTDATE OUTDATE,
                    amount,
                    discount,
                    vat,
                    servicecharge ,
                    netamount,
                    dueamt,
                    date,
                    s.userId as userID,
                    'hotel_bookings' tablename,
                    c.Name || ' ' || c.LastName as CustomerName,
                    c.IdNumber as IdNumber,
                    r.Name as ProductName,
                    r.RoomType as ProductType
                    from Hotel_Bookings s left join Master_Customer c
                    on s.fk_Master_Customer = c.id
                    left join Hotel_Roomview r on 
                    s.fk_Hotel_Master_Room  =     r.id ");
            }
            if (!GlobalResources.DbStruct.DoesViewExists("Hotel_Sales_View"))
            {
                DbHelpers.createAView("Hotel_Sales_View", @"
                        select * from Hotel_RoomSales_View
                        union all
                        select * from Hotel_ProductSales_View
                        ");


            }
        }
    }
}

