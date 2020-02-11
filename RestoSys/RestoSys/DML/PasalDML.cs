using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Bsoft.Common;
using Bsoft.Controls;
using Friuts;
using Bsoft.Data;
using UEMS.BLL;
using System.Data;

namespace UEMS.BLL
{
    public class ChangeSpecificDBStructure
    {
        public void createRestoSysDataStructure()
        {
            StringBuilder SQLCreate = new StringBuilder();

            int Rslt = 0;

            if (!GlobalResources.DbStruct.DoesTableExists("OrderTables"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE OrderTables(
Id Integer primary key Autoincrement , 
Name varchar(15) UNIQUE,
Remarks varchar(50) 
)
");
            }

            if (!GlobalResources.DbStruct.DoesTableExists("Master_CustomerType"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE Master_CustomerType(
Id int primary key autoincrement , 
Title varchar(50),
DiscountPercent decimal(20,5),
Remarks varchar(50) )");
            }


            if (!GlobalResources.DbStruct.DoesTableExists("Master_Customer"))
            {
                DbHelpers.CreateATable(@" 
                CREATE TABLE Master_Customer(
                Id integer primary key autoincrement , 
                Name varchar(50),
                LastName varchar(50),
                IdNumber varchar(50),
                Email varchar(50),
                Phone varchar(50),
                Address varchar(150),
                Remarks varchar(150),
                fk_Master_CustomerType int, 
                CONSTRAINT FK__fk_Master_CustomerType FOREIGN KEY (fk_Master_CustomerType) REFERENCES Master_CustomerType (Id),
                unique (Name,LastName,IdNumber))
                ");
            }

            if (!GlobalResources.DbStruct.DoesColumnExists("Master_Customer", "IdNumber"))
            {
                string ssqa = "ALTER TABLE Master_Customer add IdNumber varchar(50) default ''";
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                GlobalResources.DbStruct.Con.ExecuteNonQuery("UPDATE Master_Customer set IdNumber =id ");
                GlobalResources.DbStruct.Con.ExecuteNonQuery("CREATE UNIQUE INDEX IF NOT EXISTS unique_users_articles ON Master_Customer (Name,LastName,IdNumber)");
            }

            //if (!GlobalResources.DbStruct.DoesTableExists("Master_Customer"))
            //{
            //    SQLCreate.Remove(0, SQLCreate.Length);
            //    SQLCreate.Append(" CREATE TABLE Master_Customer( ");
            //    SQLCreate.Append(" \n Id int primary key identity(1,1) ");
            //    SQLCreate.Append(" \n, Name varchar(50) ");
            //    SQLCreate.Append(" \n, LastName varchar(50) ");
            //    SQLCreate.Append(" \n, Userid varchar(50) ");
            //    SQLCreate.Append(" \n, Email varchar(50) ");
            //    SQLCreate.Append(" \n, Phone varchar(50) ");
            //    SQLCreate.Append(" \n, Address varchar(150) ");
            //    SQLCreate.Append(" \n, Remarks varchar(150) )");
            //    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
            //    LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Master_Customer table created Successfully. ");

            //}
            if (!GlobalResources.DbStruct.DoesTableExists("Dev_Item_Type"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Dev_Item_Type( ");
                SQLCreate.Append(" \n Id varchar(1) primary key ");
                SQLCreate.Append(" \n, Name varchar(50) unique");
                SQLCreate.Append(" \n, Remarks varchar(150))");

                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Dev_Item_Type table created Successfully. ");

                SQLCreate.Remove(0, SQLCreate.Length);

                //code is used to identify element hard codedly in code


                SQLCreate.Append("INSERT INTO Dev_Item_Type (id,Name,Remarks)  VALUES('R','Retail','Items that are purchased and sold as it is.')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Dev_Item_Type (ID,Name,Remarks)  VALUES('S','Service','These are services as fun park games,Rental etc' )");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                SQLCreate.Remove(0, SQLCreate.Length);
                //for manufacture
                SQLCreate.Append("INSERT INTO Dev_Item_Type (ID,Name,Remarks)  VALUES('M','Manufactured/Produced','These are produced items eg in Restaurant.' )");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Dev_Item_Type (ID,Name,Remarks)  VALUES('I','Ingredient','These are the ingredients for the manufacturing/Producing.' )");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                //SQLCreate.Remove(0, SQLCreate.Length);
                //SQLCreate.Append("INSERT INTO Dev_Item_Type (ID,Name,Remarks)  VALUES('C','Consumable' )");
                //GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                //SQLCreate.Remove(0, SQLCreate.Length);
                //SQLCreate.Append("INSERT INTO Dev_Item_Type (ID,Name,Remarks)  VALUES('H','Human Resource' )");
                //GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Dev_Item_Type (ID,Name,Remarks)  VALUES('L','Lend','These are the Rentable Items eg Rooms of Hotel,Motor Cycle ,Tents etc.' )");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
            }
            if (!GlobalResources.DbStruct.DoesTableExists("Master_Product_Group"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Master_Product_Group( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, Name varchar(50) unique ");
                SQLCreate.Append(" \n, Description varchar(150) ");
                SQLCreate.Append(" \n, fk_ItemType varchar(1) ");
                SQLCreate.Append(" \n, Code varchar(15) unique not null");
                SQLCreate.Append(" \n ,FOREIGN KEY (fk_ItemType) REFERENCES Dev_Item_Type (id))");

                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Master_Product_Group table created Successfully. ");

            }

            if (!GlobalResources.DbStruct.DoesTableExists("Master_Product_Company"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Master_Product_Company( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, Name varchar(50) unique");
                SQLCreate.Append(" \n, Address varchar(50) ");
                SQLCreate.Append(" \n, Phone varchar(50) ");
                SQLCreate.Append(" \n, Email varchar(50) )");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Master_Product_Company table created Successfully. ");

            }


            if (!GlobalResources.DbStruct.DoesTableExists("Master_Vendor"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Master_Vendor( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, Name varchar(50) ");
                SQLCreate.Append(" \n, Address varchar(50) ");
                SQLCreate.Append(" \n, Phone varchar(50) ");
                SQLCreate.Append(" \n, Email varchar(50) )");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Master_Vendor table created Successfully. ");
            }

            if (!GlobalResources.DbStruct.DoesTableExists("Master_Unit"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Master_Unit( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, Name varchar(50) unique");
                SQLCreate.Append(" \n, Symbol varchar(10) unique");
                SQLCreate.Append(" \n, Type varchar(15) )");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Master_Unit table created Successfully. ");


                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Master_Unit (Name,Symbol,Type)  VALUES('Na','N/A','Not Applicable')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Master_Unit (Name,Symbol,Type)  VALUES('Numbers','Nos.','Numbers')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Master_Unit (Name,Symbol,Type)  VALUES('Packet','Packets.','Packets')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Master_Unit (Name,Symbol,Type)  VALUES('Bora','Bora.','Bora')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Master_Unit (Name,Symbol,Type)  VALUES('Meter','m','Length')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Master_Unit (Name,Symbol,Type)  VALUES('Feet','ft','Length')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Master_Unit (Name,Symbol,Type)  VALUES('KiloGram','KG','Weight')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Master_Unit (Name,Symbol,Type)  VALUES('Gram','gm','Weight')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Master_Unit (Name,Symbol,Type)  VALUES('Pound','Pound','Weight')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

            }



            if (!GlobalResources.DbStruct.DoesTableExists("Master_Product"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(@"CREATE TABLE Master_Product(  
 Id INTEGER primary key AUTOINCREMENT  
, Name varchar(50)  
, fk_Group INTEGER  
, fk_Company INTEGER
, fk_sizeunit  INTEGER
, fk_weightunit INTEGER
, colour varchar(150)  
, weight decimal(20,3)  
, size decimal(20,3)  
, sellingPrice decimal(20,3)  
, costPrice decimal(20,3)  
, reorderpoint decimal(20,3)  
, Remarks nvarchar(150)  
, fk_MeasureUnit  INTEGER
, Code nvarchar(15) not null 
, BarCode varchar(30) default ''
, UserId varchar (15) 
, entrydate varchar (15)
,FOREIGN KEY (fk_Group) REFERENCES Master_Product_Group (id) 
,FOREIGN KEY (fk_Company) REFERENCES Master_Product_Company (id)  
,FOREIGN KEY (fk_sizeunit) REFERENCES Master_Unit (id) 
,FOREIGN KEY (fk_weightunit) REFERENCES Master_Unit (id)  
,FOREIGN KEY (fk_MeasureUnit) REFERENCES Master_Unit (id) 


)
                ");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Master_Product table created Successfully. ");

            }
            else
            {
                if (!GlobalResources.DbStruct.DoesColumnExists("Master_Product", "BarCode"))
                {
                    string ssqa = "ALTER TABLE Master_Product add BarCode varchar default ''";
                    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                }
            }

            if (!GlobalResources.DbStruct.DoesTableExists("Inv_Purchase"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Inv_Purchase( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, ManufactureDate varchar ");
                SQLCreate.Append(" \n, ExpiryDate varchar ");
                SQLCreate.Append(" \n, fk_Product int  ");
                SQLCreate.Append(" \n, fk_Vendor int  ");
                SQLCreate.Append(" \n, Quantity decimal(20,3) ");//Quantity Purchased
                SQLCreate.Append(" \n, CostPrice money default 0");//added later on 28 nov
                SQLCreate.Append(" \n, SellingPrice money default 0");//added later on 28 nov
                SQLCreate.Append(" \n, PurchageDate varchar ");//added later on 28 nov

                //SQLCreate.Append(" \n, quantity_damage money default 0");//added later on 28 nov
                //SQLCreate.Append(" \n, quantity_sold money default 0");//added later on 28 nov
                //SQLCreate.Append(" \n, purchaseReturn money default 0");//added later on 11 dec 2010
                //SQLCreate.Append(" \n, salesReturn money default 0");//added later on 13 dec 2010
                SQLCreate.Append(" \n, Remarks varchar(150) ");

                SQLCreate.Append(" \n, UserId varchar(15) ");
                SQLCreate.Append(" \n, entrydate varchar ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_Vendor) REFERENCES Master_Vendor (id) ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_Product) REFERENCES Master_Product (id)  )");

                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Inv_Purchase table created Successfully. ");

            }
            else
            {
                if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Purchase", "CostPrice"))
                {
                    string ssqa = "ALTER TABLE Inv_Purchase add CostPrice money default 0";
                    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                }

                if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Purchase", "SellingPrice"))
                {
                    string ssqa = "ALTER TABLE Inv_Purchase add SellingPrice money default 0";
                    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                }
                if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Purchase", "PurchageDate"))
                {
                    string ssqa = "ALTER TABLE Inv_Purchase add PurchageDate varchar ";
                    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                }
                //if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Purchase", "quantity_damage"))
                //{
                //    string ssqa = "ALTER TABLE Inv_Purchase add quantity_damage money default 0";
                //    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                //}
                //if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Purchase", "quantity_sold"))
                //{
                //    string ssqa = "ALTER TABLE Inv_Purchase add quantity_sold money default 0";
                //    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                //}
                //if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Purchase", "purchaseReturn"))
                //{
                //    string ssqa = "ALTER TABLE Inv_Purchase add purchaseReturn money default 0";
                //    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                //}
                //if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Purchase", "salesReturn"))
                //{
                //    string ssqa = "ALTER TABLE Inv_Purchase add salesReturn money default 0";
                //    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                //}


            }

            if (!GlobalResources.DbStruct.DoesTableExists("Acc_Sale"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Acc_Sale( ");
                SQLCreate.Append(" \n id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, Amount money default 0");
                SQLCreate.Append(" \n, Discount money default 0");

                SQLCreate.Append(" \n, DueAmount money default 0");
                SQLCreate.Append(" \n, CreditAmount money default 0");
                SQLCreate.Append(" \n, fk_Master_Customer int ");

                SQLCreate.Append(" \n, VAT money default 0");
                SQLCreate.Append(" \n, ServiceCharge money default 0");

                SQLCreate.Append(" \n, TenderAmount money default 0");
                SQLCreate.Append(" \n, ReturnAmount money default 0");
                SQLCreate.Append(" \n, Date varchar ");
                SQLCreate.Append(" \n, UserId varchar(15),  FOREIGN KEY (fk_Master_Customer) REFERENCES  Master_Customer (id) )");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Acc_Sale table created Successfully. ");

            }
            else
            {
                if (!GlobalResources.DbStruct.DoesColumnExists("Acc_Sale", "VAT"))
                {
                    string ssqa = "ALTER TABLE Acc_Sale add VAT money default 0";
                    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                }
                if (!GlobalResources.DbStruct.DoesColumnExists("Acc_Sale", "ServiceCharge"))
                {
                    string ssqa = "ALTER TABLE Acc_Sale add ServiceCharge money default 0";
                    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                }
            }

            if (!GlobalResources.DbStruct.DoesTableExists("Inv_Sale"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Inv_Sale( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, fk_Purchage int  ");
                SQLCreate.Append(" \n, fk_Product int  ");
                SQLCreate.Append(" \n, fk_sale int ");
                SQLCreate.Append(" \n, Quantity decimal(20,3) ");
                SQLCreate.Append(" \n, Rate money default 0");//selling price
                SQLCreate.Append(" \n, CostPrice money default 0");
                SQLCreate.Append(" \n, Amount money default 0");
                SQLCreate.Append(" \n, Discount money default 0");
                SQLCreate.Append(" \n, NetAmount money default 0");
                SQLCreate.Append(" \n, SalesReturn money default 0");//added 12 dec 2010
                SQLCreate.Append(" \n, Remarks varchar(150) ");
                SQLCreate.Append(" \n, Date  varchar");
                SQLCreate.Append(" \n, UserId varchar(15) ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_sale) REFERENCES Acc_Sale (id)  ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_Product) REFERENCES Master_Product (id) ) ");

                //Since there is no need of purchage for sales to occur so foreing key in here is removed.
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Inv_Sale table created Successfully. ");


                if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Sale", "SalesReturn"))
                {
                    string ssqa = "ALTER TABLE Inv_Sale add SalesReturn money default 0";
                    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                }

            }
            else
            {
                if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Sale", "CostPrice"))
                {
                    string ssqa = "ALTER TABLE Inv_Sale add CostPrice money default 0";
                    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                }
                if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Sale", "fk_Product"))
                {
                    string ssqa = "ALTER TABLE Inv_Sale add fk_Product integer ";
                    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                }

            }
            //if (!GlobalResources.DbStruct.DoesTableExists("Inv_Damage_Loss_Return"))
            //{
            //    SQLCreate.Remove(0, SQLCreate.Length);
            //    SQLCreate.Append(" CREATE TABLE Inv_Damage_Loss_Return( ");
            //    SQLCreate.Append(" \n Id int primary key identity(1,1) ");
            //    SQLCreate.Append(" \n, fk_Purchage int ");
            //    SQLCreate.Append(" \n, Quantity decimal(20,3) ");
            //    SQLCreate.Append(" \n, Remarks varchar(150) ");
            //    SQLCreate.Append(" \n, Date  varchar");
            //    SQLCreate.Append(" \n, UserId int ");
            //    SQLCreate.Append(" \n, FOREIGN KEY (fk_Purchage) REFERENCES Inv_Purchase (id)  ");
            //    SQLCreate.Append(" \n, FOREIGN KEY (UserId) REFERENCES SuperAdmin_Rights_Users (id)  )");

            //    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
            //    LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Inv_Damage_Loss_Return table created Successfully. ");

            //}
            //if (!GlobalResources.DbStruct.DoesTableExists("Inv_Purchase_Return"))
            //{
            //    SQLCreate.Remove(0, SQLCreate.Length);
            //    SQLCreate.Append(" CREATE TABLE Inv_Purchase_Return( ");
            //    SQLCreate.Append(" \n Id int primary key identity(1,1) ");
            //    SQLCreate.Append(" \n, fk_Purchage int");
            //    SQLCreate.Append(" \n, Quantity decimal(20,3)  not null");
            //    SQLCreate.Append(" \n, Remarks varchar(150) ");
            //    SQLCreate.Append(" \n, Date  varchar");
            //    SQLCreate.Append(" \n, UserId int ");
            //    SQLCreate.Append(" \n, FOREIGN KEY (UserId) REFERENCES SuperAdmin_Rights_Users (id)  ");
            //    SQLCreate.Append(" \n, FOREIGN KEY (fk_Purchage)  REFERENCES Inv_Purchase (id)  )");

            //    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
            //    LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Inv_Purchase_Return table created Successfully. ");

            //}
            //if (!GlobalResources.DbStruct.DoesTableExists("Inv_Sales_Return"))
            //{
            //    SQLCreate.Remove(0, SQLCreate.Length);
            //    SQLCreate.Append(" CREATE TABLE Inv_Sales_Return( ");
            //    SQLCreate.Append(" \n Id int primary key identity(1,1) ");
            //    SQLCreate.Append(" \n, fk_Purchage int ");
            //    SQLCreate.Append(" \n, Quantity decimal(20,3) not null ");
            //    SQLCreate.Append(" \n, Remarks varchar(150) ");
            //    SQLCreate.Append(" \n, Date  varchar");
            //    SQLCreate.Append(" \n, UserId int ");
            //    SQLCreate.Append(" \n, FOREIGN KEY (UserId) REFERENCES SuperAdmin_Rights_Users (id)");
            //    SQLCreate.Append(" \n, FOREIGN KEY (fk_Purchage) REFERENCES Inv_Purchase (id)  )");


            //    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
            //    LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Inv_Sales_Return table created Successfully. ");

            //}

            // All others will be removed and only this will be kept

            if (!GlobalResources.DbStruct.DoesTableExists("Dev_StockType_Code"))
            {

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.AppendLine(" CREATE TABLE Dev_StockType_Code( ");
                SQLCreate.AppendLine(" \n Id varchar(1) primary key ");
                SQLCreate.AppendLine(" \n, Title varchar(50) UNIQUE");
                SQLCreate.AppendLine(" \n, Remarks varchar(50) )");
                DbHelpers.CreateATable(SQLCreate.ToString());
                //Insert some default values
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO Dev_StockType_Code (Title,Id)  VALUES('Purchase','P')");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO Dev_StockType_Code (Title,Id)  VALUES('Sold','S')");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO Dev_StockType_Code (Title,Id)  VALUES('Purchase Retrun','N')");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO Dev_StockType_Code (Title,Id)  VALUES('Sales Return','R')");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO Dev_StockType_Code (Title,Id)  VALUES('Damaged','D')");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO Dev_StockType_Code (Title,Id)  VALUES('Lost','L')");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO Dev_StockType_Code (Title,Id)  VALUES('Ingredient Consumed','C')");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO Dev_StockType_Code (Title,Id)  VALUES('Stock Entry','E')");

            }
            if (!GlobalResources.DbStruct.DoesTableExists("Inv_Stock"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE Inv_Stock(
Id int primary key autoincrement , 
fk_Inv_Purchase int,
fk_Master_Product int,
fk_Inv_Sale int,
Quantity decimal(20,5),
fk_StockModfType_Code varchar(1),
Remarks varchar(150),
Date  varchar ,
UserId int,
CONSTRAINT FK_fk_StockModfType_Code_fk_fk_StockModfType_Code FOREIGN KEY (fk_StockModfType_Code) REFERENCES Dev_StockType_Code (Id))");
            }

            if (!GlobalResources.DbStruct.DoesTableExists("Acc_CreditPayBack"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Acc_CreditPayBack( ");
                SQLCreate.Append(" \n id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, fk_Acc_Sale int  ");
                SQLCreate.Append(" \n, fk_Master_Customer int  ");
                SQLCreate.Append(" \n, PayBackAmount money default 0");
                SQLCreate.Append(" \n, Remarks varchar(150) ");
                SQLCreate.Append(" \n, Date varchar ");
                SQLCreate.Append(" \n, UserId int  ");
                SQLCreate.Append(" \n,  FOREIGN KEY (fk_Acc_Sale) REFERENCES Acc_Sale (id) ");
                SQLCreate.Append(" \n,  FOREIGN KEY (fk_Master_Customer) REFERENCES  Master_Customer (id)) ");
               

                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Acc_CreditPayBack table created Successfully. ");

            }

        }

        public void createRestoSysViews()
        {
           
            //GlobalResources.SelectDBConnection.ExecuteNonQuery("DROP VIEW StockTypeView");
            //GlobalResources.SelectDBConnection.ExecuteNonQuery("DROP VIEW SalesView");
            //GlobalResources.SelectDBConnection.ExecuteNonQuery("DROP VIEW PurchaseView");
            //GlobalResources.SelectDBConnection.ExecuteNonQuery("DROP VIEW PurchaseRptView");
            //GlobalResources.SelectDBConnection.ExecuteNonQuery("DROP VIEW ProductFrmView");

            //GlobalResources.SelectDBConnection.ExecuteNonQuery("DROP VIEW StockModfView");
            //GlobalResources.SelectDBConnection.ExecuteNonQuery("DROP VIEW StockSumView");
            //GlobalResources.SelectDBConnection.ExecuteNonQuery("DROP VIEW StockReportView");
            //GlobalResources.SelectDBConnection.ExecuteNonQuery("DROP VIEW TransactionReportView");


            if (!GlobalResources.DbStruct.DoesViewExists("StockTypeView"))
            {
                DbHelpers.createAView("StockTypeView", @"
                    SELECT  FK_INV_PURCHASE,
                    SUM(QUANTITY) AS QUANTITY ,FK_STOCKMODFTYPE_CODE 
                    FROM INV_STOCK  
                    GROUP BY FK_INV_PURCHASE,FK_STOCKMODFTYPE_CODE
                        ");
            }

            if (!GlobalResources.DbStruct.DoesViewExists("SalesView"))
            {
                DbHelpers.createAView("SalesView", @"select  
    Purchase.name as productname,
    Purchase.code as Code,
    Purchase.fk_group Master_Product_Group_id,
--    Purchase.Master_Vendor_id,
    Purchase.fk_company Master_Product_Company_id ,
    InvSales.Rate t2_listprice , 
      IFNULL   ( InvSales.salesreturn ,0)as salesreturn ,
      IFNULL   (InvSales.Quantity,0) t1_Quantity, 
    InvSales.Amount t1_Amount, 
      IFNULL   ( InvSales.Discount,0) t1_Discount, 
      IFNULL   ( InvSales.Amount,0) + (   IFNULL   (InvSales.Amount,0) *   IFNULL   (InvSales.salesreturn,0)  /InvSales.Quantity)  as adjustedGrossAmount, 
    InvSales.CostPrice * ( InvSales.Quantity-   IFNULL   (InvSales.salesreturn,0))    as adjustedCostPrice, 
    InvSales.Discount - (InvSales.Discount *   IFNULL   (InvSales.salesreturn,0)  /InvSales.Quantity)  as adjustedDiscount, 
    InvSales.NetAmount - (InvSales.NetAmount *   IFNULL   (InvSales.salesreturn,0)  /InvSales.Quantity ) as adjustedAmount, 
    InvSales.NetAmount - (InvSales.NetAmount *   IFNULL   (InvSales.salesreturn,0)  /InvSales.Quantity)  - ((InvSales.Quantity-   IFNULL   (InvSales.salesreturn,0) ) * InvSales.CostPrice)  as Profit , 
    InvSales.NetAmount t1_NetAmount, 
    InvSales.Remarks t1_Remarks, 
    InvSales.Date t1_Date, 
    SuperAdmin_Rights_Users.engname t5_Name 
    from 
    Inv_Sale InvSales 
    left outer join  Master_Product Purchase on InvSales.fk_Product  = Purchase.id
    left outer join  SuperAdmin_Rights_Users   on SuperAdmin_Rights_Users.id  = InvSales.UserId  
");

            }





            if (!GlobalResources.DbStruct.DoesViewExists("PurchaseView"))
            {
                DbHelpers.createAView("PurchaseView", @"

              SELECT distinct
Inv_Purchase.Id As Inv_PurchaseId, 
Master_Product.Name  AS ProductName, 
Master_Product.id as ProductId,
Inv_Purchase.Remarks   As purchageRemarks,
Inv_Purchase.ManufactureDate as  ManufactureDate,
Inv_Purchase.ExpiryDate as  ExpiryDate,
Inv_Purchase.PurchageDate  As purchagedate, 
Inv_Purchase.Quantity As purchageQuantity, 
Inv_Purchase.CostPrice as Cost,
(SELECT  IFNULL (StockTypeView.quantity, 0)
        FROM   StockTypeView 
        WHERE  StockTypeView.fk_StockModfType_Code = 'N'
               AND fk_Inv_Purchase = Inv_Purchase.Id)  AS purchasereturn, 
(SELECT  IFNULL (StockTypeView.quantity, 0)
        FROM   StockTypeView 
        WHERE  StockTypeView.fk_StockModfType_Code = 'R'
               AND fk_Inv_Purchase = Inv_Purchase.Id)  AS salesreturn, 
(SELECT  IFNULL (StockTypeView.quantity, 0)
        FROM   StockTypeView 
        WHERE  StockTypeView.fk_StockModfType_Code = 'D'
               AND fk_Inv_Purchase = Inv_Purchase.Id)  AS DamageQuantity, 
(SELECT  IFNULL (StockTypeView.quantity, 0)
        FROM   StockTypeView 
        WHERE  StockTypeView.fk_StockModfType_Code = 'S'
               AND fk_Inv_Purchase = Inv_Purchase.Id)  AS SoldQuantity, 
(SELECT  IFNULL (StockTypeView.quantity, 0)
        FROM   StockTypeView 
        WHERE  StockTypeView.fk_StockModfType_Code = 'C'
               AND fk_Inv_Purchase = Inv_Purchase.Id)  AS ConsumedQuantity, 
Inv_Purchase.SellingPrice AS MRP, 
Inv_Purchase.entrydate AS Inv_Purchase_entrydate, 
Master_Product_Group.Id AS Master_Product_Group_id, 
Master_Product_Group.Code  || '.' ||  Master_Product.Code  AS Code,
Master_Product_Company.Name AS Company, 
Master_Product_Group.Name AS GroupName, 
Master_Vendor.Id AS Master_Vendor_id,
Master_Vendor.Name AS VendorName,
Master_Product_Company.Id AS Master_Product_Company_id,
Dev_Item_Type.ID ItemType
FROM         
Inv_Purchase 
LEFT OUTER JOIN Master_Product ON Master_Product.Id = Inv_Purchase.fk_Product 
LEFT OUTER JOIN Master_Vendor ON Master_Vendor.Id = Inv_Purchase.fk_Vendor 
LEFT OUTER JOIN Master_Unit ON Master_Product.fk_MeasureUnit = Master_Unit.Id 
LEFT OUTER JOIN Master_Product_Company ON Master_Product.fk_Company = Master_Product_Company.Id 
LEFT OUTER JOIN Master_Product_Group ON Master_Product.fk_Group = Master_Product_Group.Id
left outer join Dev_Item_Type on Dev_Item_Type.Id = Master_Product_Group.fk_ItemType
left outer join StockTypeView on StockTypeView.fk_Inv_Purchase  = Inv_Purchase.id 
WHERE     (1 = 1)
");

            }

            if (!GlobalResources.DbStruct.DoesViewExists("PurchaseRptView"))
            {
                DbHelpers.createAView("PurchaseRptView", @"
SELECT distinct
Inv_PurchaseId,
ProductId, 
ManufactureDate,
ExpiryDate,
purchageRemarks,
ProductName, 
purchagedate, 
purchageQuantity, 
Cost,
purchasereturn, 
salesreturn,
MRP, 
DamageQuantity, 
SoldQuantity,  
ConsumedQuantity,
  IFNULL  (purchageQuantity, 0)  -  IFNULL  (SoldQuantity, 0) -   IFNULL  (DamageQuantity, 0)+
  IFNULL  (salesreturn, 0)-  IFNULL  (purchasereturn, 0) -  IFNULL  (ConsumedQuantity, 0) as stock,
purchageQuantity * cost AS totalPurchageCost,
SoldQuantity * cost AS totalsoldCost,
DamageQuantity * cost AS totalDamageCost,
salesreturn * cost AS totalSRCost,
purchasereturn * cost AS totalPRCost,
purchageQuantity * MRP AS totalSP,
SoldQuantity * MRP AS totalSoldSP,
DamageQuantity * MRP AS totalDamageSP,
salesreturn * MRP AS totalSRSP,
purchasereturn * MRP AS totalPRSP,
Inv_Purchase_entrydate, 
Master_Product_Group_id, 
Code,
Company, 
GroupName, 
Master_Vendor_id,
VendorName,
Master_Product_Company_id,
ItemType
FROM         
PurchaseView 
WHERE (1 = 1)
 
");
            }


            if (!GlobalResources.DbStruct.DoesViewExists("ProductFrmView"))
            {
                DbHelpers.createAView("ProductFrmView", @"       
SELECT DISTINCT 
t1.Id Id, 
t1.Name t1_Name, 
t1.colour t1_colour,cast(t1.weight as nvarchar ) || ' ' || cast(t7.unit as nvarchar)  t1_weight, cast(t1.size as nvarchar ) || ' ' || cast(t6.unit as nvarchar)  t1_size,  
t1.reorderpoint t1_reorderpoint, 
t1.Remarks t1_Remarks, 
t1.entrydate t1_entrydate, 
t1.fk_Group t1_fk_Group, 
 cast(t2.Code as nvarchar ) || '.' || cast(t1.Code as nvarchar ) as t1_Code,
 t1.BarCode BarCode,  
 t3.Name companyname, 
 t1.sellingPrice sellingPrice, 
 t1.costPrice costPrice, 
t2.Name GroupName, 
t2.fk_ItemType ItemTypeCode,
t1.fk_Company t1_fk_Company, 
t1.fk_sizeunit t1_fk_sizeunit, 
t1.fk_weightunit t1_fk_weightunit, 
t7.unit t7_weightunit, 
t1.UserId t1_UserId, 
t5.ENGNAME t5_Name  
FROM 
Master_Product t1 
left outer join  
Master_Product_Group t2 on 
t1.fk_Group = t2.id  
left outer join  
Master_Product_Company  t3 on 
t1.fk_Company = t3.id   
left outer join  
SuperAdmin_Rights_Users t5 on 
t1.UserId = t5.id 
left outer join  
Master_Unit t6 on 
t1.fk_sizeunit = t6.id 
left outer join  
Master_Unit t7 on 
t1.fk_weightunit = t7.id 
left outer join  
Master_Unit mu on 
t1.fk_MeasureUnit = mu.id 
 where t1.id = t1.id
     ");
            }


            if (!GlobalResources.DbStruct.DoesViewExists("StockModfView"))
            {
                DbHelpers.createAView("StockModfView", @"       
select 
ProductFrmView.t1_Name ProductName,
ProductFrmView.ItemTypeCode ItemTypeCode,
productfrmview.GroupName  GroupName,
productfrmview.companyname CompanyName,
productfrmview.t1_fk_Group GroupId,
ProductFrmView.t1_Code ProductCode,
ProductFrmView.t1_fk_Company CompanyId,
inv_stock.Quantity Quantity,
inv_stock.fk_StockModfType_Code StockModfType ,
inv_stock.DATE ,
inv_stock.Remarks Remarks
from inv_stock
left join productfrmview on inv_stock .fk_Master_Product = ProductFrmView.Id

");




            }
            if (!GlobalResources.DbStruct.DoesViewExists("StockSumView"))
            {
                DbHelpers.createAView("StockSumView", @"       
/*select r,
SUM(CASE WHEN typ='s' THEN 0 ELSE id END) AS stk,-- no stk for services
abs(SUM(CASE WHEN nm='s' THEN  id  ELSE 0 END)) AS s,--sls
SUM(CASE WHEN nm='r' THEN id ELSE 0 END) AS r,--pret
SUM(CASE WHEN nm='c' THEN id ELSE 0 END) AS c--consu
from bt group by r*/

select  
fk_Master_Product,
sum(quantity) as Stock,
SUM(CASE WHEN fk_StockModfType_Code='P' THEN Quantity ELSE 0 END) AS Purchase,
SUM(CASE WHEN fk_StockModfType_Code='S' THEN Quantity ELSE 0 END) AS Sales,
SUM(CASE WHEN fk_StockModfType_Code='N' THEN Quantity ELSE 0 END) AS PurchaseReturn,
SUM(CASE WHEN fk_StockModfType_Code='R' THEN Quantity ELSE 0 END) AS SalesReturn,
SUM(CASE WHEN fk_StockModfType_Code='D' THEN Quantity ELSE 0 END) AS Damaged,
SUM(CASE WHEN fk_StockModfType_Code='L' THEN Quantity ELSE 0 END) AS Lost,
SUM(CASE WHEN fk_StockModfType_Code='C' THEN Quantity ELSE 0 END) AS Consumed,
SUM(CASE WHEN fk_StockModfType_Code='E' THEN Quantity ELSE 0 END) AS StockEntry
from Inv_Stock  
group by fk_Master_Product
");

            }

            if (!GlobalResources.DbStruct.DoesViewExists("StockReportView"))
            {
                DbHelpers.createAView("StockReportView", @"       
SELECT
t1.Id Id, 
t1.Name Name, 
t1.Remarks Remarks,  
t1.fk_Group GroupId, 
t2.Name GroupName,
cast(t2.Code as nvarchar ) || '.' || cast(t1.Code as nvarchar ) as Code, 
t3.Name CompanyName, 
t1.sellingPrice SellingPrice, 
t1.costPrice CostPrice, 
t2.fk_ItemType ItemTypeCode,
t1.fk_Company CompanyId,
(CASE WHEN t2.fk_ItemType IN ('S','L') THEN 0 else  stockSum.Stock END) AS Stock,
stockSum.Purchase Purchase,
stockSum.Sales Sales,
stockSum.PurchaseReturn PurchaseReturn,
stockSum.SalesReturn SalesReturn,
stockSum.Damaged Damaged,
stockSum.Lost Lost,
stockSum.Consumed Consumed,
stockSum.StockEntry StockEntry,
t1.entrydate Entrydate,  
t1.UserId UserId, 
t5.ENGNAME UserName  
FROM 
StockSumView stockSum  
left outer join 
Master_Product t1 on
t1.id=  stockSum.fk_Master_Product
left outer join  
Master_Product_Group t2 on 
t1.fk_Group = t2.id  
left outer join  
Master_Product_Company  t3 on 
t1.fk_Company = t3.id   
left outer join  
SuperAdmin_Rights_Users t5 on 
t1.UserId = t5.id
");

            }


            if (!GlobalResources.DbStruct.DoesViewExists("TransactionReportView"))
            {
                DbHelpers.createAView("TransactionReportView", @"    
select a.Date TransactionDate, 
a.Amount Amount,
a.Discount Discount,
a.ServiceCharge ServiceCharge,
a.VAT VAT,
u.Engname UserName,
u.id UserId,
  IFNULL  (c.Name || ' ' || c.LastName,'') Customer,
a.CreditAmount  Credit,
a.DueAmount Due,
a.TenderAmount Tender,
a.ReturnAmount ReturnAmt
from acc_sale a
left join SuperAdmin_Rights_Users u on a.UserId = u.id 
left join Master_Customer c on c.Id = a.fk_Master_Customer   
    ");

            }


        }


        //        select 
        //i.fk_purchage PurchaseId, 
        //i.Quantity StockQty,
        //c.Code StockCode
        // from Inv_Stock i
        //left join Dev_StockType_Code c
        //on i.fk_StockModificationType = c.id 


        public void UpdateStructure()
        {
            (new RestoSys.BLL.General()).createGeneral_unit2();
            createRestoSysDataStructure();
            createRestoSysViews();
            //(new RestoSys.BLL.TagsDML()).createTagDataStructure();

            RestoSys.DML.HotelDML.createtables();

            RestoSys.DML.HotelDML.createViews();
        }

    }
}





