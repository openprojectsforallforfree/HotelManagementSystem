using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Bsoft.Common;
using Bsoft.Controls;
using Friuts;
using Bsoft.Data;
using UEMS.BLL;

namespace UEMS.BLL
{
    public class ChangeSpecificDBStructure
    {
        public void createPasalDataStructure()
        {
            StringBuilder SQLCreate = new StringBuilder();

            int Rslt = 0;
            if (!GlobalResources.DbStruct.DoesTableExists("Customer_Master"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Customer_Master( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, Name varchar(50) ");
                SQLCreate.Append(" \n, LastName varchar(50) ");
                SQLCreate.Append(" \n, Userid varchar(50) ");
                SQLCreate.Append(" \n, Email varchar(50) ");
                SQLCreate.Append(" \n, Phone varchar(50) ");
                SQLCreate.Append(" \n, Address varchar(150) ");
                SQLCreate.Append(" \n, Remarks varchar(150) )");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Customer_Master table created Successfully. ");

            }

            if (!GlobalResources.DbStruct.DoesTableExists("Product_Group_Master"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Product_Group_Master( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, Name varchar(50) unique ");
                SQLCreate.Append(" \n, Description varchar(150) ");
                SQLCreate.Append(" \n, Code varchar(15) unique not null)");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Product_Group_Master table created Successfully. ");

            }

            if (!GlobalResources.DbStruct.DoesTableExists("Product_Company_Master"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Product_Company_Master( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, Name varchar(50) unique");
                SQLCreate.Append(" \n, Address varchar(50) ");
                SQLCreate.Append(" \n, Phone varchar(50) ");
                SQLCreate.Append(" \n, Email varchar(50) )");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Product_Company_Master table created Successfully. ");

            }


            if (!GlobalResources.DbStruct.DoesTableExists("Vendor_Master"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Vendor_Master( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, Name varchar(50) ");
                SQLCreate.Append(" \n, Address varchar(50) ");
                SQLCreate.Append(" \n, Phone varchar(50) ");
                SQLCreate.Append(" \n, Email varchar(50) )");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Vendor_Master table created Successfully. ");
            }

            if (!GlobalResources.DbStruct.DoesTableExists("Unit_Master"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Unit_Master( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, Name varchar(50) unique");
                SQLCreate.Append(" \n, Symbol varchar(10) unique");
                SQLCreate.Append(" \n, Type varchar(15) )");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Unit_Master table created Successfully. ");


                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Unit_Master (Name,Symbol,Type)  VALUES('Na','N/A','Not Applicable')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Unit_Master (Name,Symbol,Type)  VALUES('Numbers','Nos.','Numbers')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Unit_Master (Name,Symbol,Type)  VALUES('Packet','Packets.','Packets')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Unit_Master (Name,Symbol,Type)  VALUES('Bora','Bora.','Bora')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Unit_Master (Name,Symbol,Type)  VALUES('Meter','m','Length')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Unit_Master (Name,Symbol,Type)  VALUES('Feet','ft','Length')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Unit_Master (Name,Symbol,Type)  VALUES('KiloGram','KG','Weight')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Unit_Master (Name,Symbol,Type)  VALUES('Gram','gm','Weight')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("INSERT INTO Unit_Master (Name,Symbol,Type)  VALUES('Pound','Pound','Weight')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());

            }

            if (!GlobalResources.DbStruct.DoesTableExists("Company"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Company( ");
                SQLCreate.Append(" \n id smallint primary key identity(1,1) ");
                SQLCreate.Append(" \n, Name nvarchar(50) ");
                SQLCreate.Append(" \n, Phone nvarchar(50) ");
                SQLCreate.Append(" \n, Fax nvarchar(50) ");
                SQLCreate.Append(" \n, Url nvarchar(50) ");
                SQLCreate.Append(" \n, Email nvarchar(50) ");
                SQLCreate.Append(" \n, AddressLine1 nvarchar(50) ");
                SQLCreate.Append(" \n, AddressLine2 nvarchar(50) ");
                SQLCreate.Append(" \n, AddressLine3 nvarchar(50) ");
                SQLCreate.Append(" \n, AddressLine4 nvarchar(50) )");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Company table created Successfully. ");

            }

            if (!GlobalResources.DbStruct.DoesTableExists("Product_Master"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(@"CREATE TABLE Product_Master(  
 Id INTEGER primary key AUTOINCREMENT  
, Name varchar(50)  
, fk_Group INTEGER  
, fk_Company INTEGER
, fk_sizeunit  INTEGER
, fk_weightunit INTEGER
, colour varchar(150)  
, weight decimal(20,3)  
, size decimal(20,3)  
, reorderpoint decimal(20,3)  
, Remarks nvarchar(150)  
, fk_MeasureUnit  
, Code nvarchar(15) not null 
, fk_User INTEGER 
, entrydate varchar 
,FOREIGN KEY (fk_Group) REFERENCES Product_Group_Master (id) 
,FOREIGN KEY (fk_Company) REFERENCES Product_Company_Master (id)  
,FOREIGN KEY (fk_sizeunit) REFERENCES Unit_Master (id) 
,FOREIGN KEY (fk_sizeunit) REFERENCES Unit_Master (id)  
,FOREIGN KEY (fk_sizeunit) REFERENCES Unit_Master (id) 
,FOREIGN KEY (fk_User) REFERENCES Rights_Users (id) 
  
)
                ");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Product_Master table created Successfully. ");

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

                SQLCreate.Append(" \n, quantity_damage money default 0");//added later on 28 nov
                SQLCreate.Append(" \n, quantity_sold money default 0");//added later on 28 nov
                SQLCreate.Append(" \n, purchaseReturn money default 0");//added later on 11 dec 2010
                SQLCreate.Append(" \n, salesReturn money default 0");//added later on 13 dec 2010
                SQLCreate.Append(" \n, Remarks varchar(150) ");

                SQLCreate.Append(" \n, fk_User int ");
                SQLCreate.Append(" \n, entrydate varchar, FOREIGN KEY (fk_User) REFERENCES Rights_Users (id) ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_Vendor) REFERENCES Vendor_Master (id) ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_Product) REFERENCES Product_Master (id)  )");

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
                if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Purchase", "quantity_damage"))
                {
                    string ssqa = "ALTER TABLE Inv_Purchase add quantity_damage money default 0";
                    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                }
                if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Purchase", "quantity_sold"))
                {
                    string ssqa = "ALTER TABLE Inv_Purchase add quantity_sold money default 0";
                    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                }
                if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Purchase", "purchaseReturn"))
                {
                    string ssqa = "ALTER TABLE Inv_Purchase add purchaseReturn money default 0";
                    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                }
                if (!GlobalResources.DbStruct.DoesColumnExists("Inv_Purchase", "salesReturn"))
                {
                    string ssqa = "ALTER TABLE Inv_Purchase add salesReturn money default 0";
                    Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(ssqa);
                }


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
                SQLCreate.Append(" \n, fk_Customer_Master int ");

                SQLCreate.Append(" \n, TenderAmount money default 0");
                SQLCreate.Append(" \n, ReturnAmount money default 0");
                SQLCreate.Append(" \n, Date varchar ");
                SQLCreate.Append(" \n, fk_User int, FOREIGN KEY (fk_User)REFERENCES Rights_Users (id) , FOREIGN KEY (fk_Customer_Master) REFERENCES  Customer_Master (id) )");
                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Acc_Sale table created Successfully. ");

            }

            if (!GlobalResources.DbStruct.DoesTableExists("Inv_Sale"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Inv_Sale( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, fk_Purchage int  ");
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
                SQLCreate.Append(" \n, fk_User int  ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_User) REFERENCES Rights_Users (id)  ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_sale) REFERENCES Acc_Sale (id)  ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_Purchage) REFERENCES Inv_Purchase (id)  )");

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

            }
            if (!GlobalResources.DbStruct.DoesTableExists("Inv_Damage_Loss_Return"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Inv_Damage_Loss_Return( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, fk_Purchage int ");
                SQLCreate.Append(" \n, Quantity decimal(20,3) ");
                SQLCreate.Append(" \n, Remarks varchar(150) ");
                SQLCreate.Append(" \n, Date  varchar");
                SQLCreate.Append(" \n, fk_User int ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_Purchage) REFERENCES Inv_Purchase (id)  ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_User) REFERENCES Rights_Users (id)  )");

                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Inv_Damage_Loss_Return table created Successfully. ");

            }
            if (!GlobalResources.DbStruct.DoesTableExists("Inv_Purchase_Return"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Inv_Purchase_Return( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, fk_Purchage int");
                SQLCreate.Append(" \n, Quantity decimal(20,3)  not null");
                SQLCreate.Append(" \n, Remarks varchar(150) ");
                SQLCreate.Append(" \n, Date  varchar");
                SQLCreate.Append(" \n, fk_User int ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_User) REFERENCES Rights_Users (id)  ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_Purchage)  REFERENCES Inv_Purchase (id)  )");

                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Inv_Purchase_Return table created Successfully. ");

            }
            if (!GlobalResources.DbStruct.DoesTableExists("Inv_Sales_Return"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Inv_Sales_Return( ");
                SQLCreate.Append(" \n Id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, fk_Purchage int ");
                SQLCreate.Append(" \n, Quantity decimal(20,3) not null ");
                SQLCreate.Append(" \n, Remarks varchar(150) ");
                SQLCreate.Append(" \n, Date  varchar");
                SQLCreate.Append(" \n, fk_User int ");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_User) REFERENCES Rights_Users (id)");
                SQLCreate.Append(" \n, FOREIGN KEY (fk_Purchage) REFERENCES Inv_Purchase (id)  )");


                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Inv_Sales_Return table created Successfully. ");

            }

            if (!GlobalResources.DbStruct.DoesTableExists("Acc_CreditPayBack"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE Acc_CreditPayBack( ");
                SQLCreate.Append(" \n id int primary key identity(1,1) ");
                SQLCreate.Append(" \n, fk_Acc_Sale int  ");
                SQLCreate.Append(" \n, fk_Customer_Master int  ");
                SQLCreate.Append(" \n, PayBackAmount money default 0");
                SQLCreate.Append(" \n, Remarks varchar(150) ");
                SQLCreate.Append(" \n, Date varchar ");
                SQLCreate.Append(" \n, fk_User int  ");
                SQLCreate.Append(" \n,  FOREIGN KEY (fk_Acc_Sale) REFERENCES Acc_Sale (id) ");
                SQLCreate.Append(" \n,  FOREIGN KEY (fk_Customer_Master) REFERENCES  Customer_Master (id) ");
                SQLCreate.Append(" \n,  FOREIGN KEY (fk_User) REFERENCES Rights_Users (id)  )");

                Rslt = GlobalResources.DbStruct.Con.ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, "Acc_CreditPayBack table created Successfully. ");

            }

        }

        public void createPasalViews()
        {
            if (!GlobalResources.DbStruct.DoesViewExists("productsall"))
            {
                DbHelpers.createAView("productsall", @"
SELECT 
Inv_Purchase.Id As Inv_PurchaseId, 
Product_Master.Name  AS ProductName, 
Inv_Purchase.PurchageDate  As purchagedate, 
Inv_Purchase.Quantity As purchageQuantity, 
Inv_Purchase.CostPrice as Cost,
IFNULL(Inv_Purchase.purchaseReturn,0) AS purchasereturn, 
IFNULL(Inv_Purchase.salesReturn ,0) AS salesreturn,
Inv_Purchase.SellingPrice AS MRP, 
IFNULL(Inv_Purchase.quantity_damage,0) AS DamageQuantity, 
IFNULL(Inv_Purchase.quantity_sold,0) AS SoldQuantity,  
Inv_Purchase.Quantity - IFNULL(Inv_Purchase.quantity_sold,0) -IFNULL( Inv_Purchase.quantity_damage,0) +IFNULL( Inv_Purchase.salesReturn,0) - IFNULL(Inv_Purchase.purchaseReturn ,0) AS Stock, 
Inv_Purchase.Quantity * Inv_Purchase.CostPrice AS totalPurchageCost, 
IFNULL(Inv_Purchase.purchaseReturn,0) * Inv_Purchase.CostPrice AS totalPRCost, 
IFNULL(Inv_Purchase.salesReturn,0) * Inv_Purchase.CostPrice AS totalSRCost, 
IFNULL(Inv_Purchase.quantity_damage,0) * Inv_Purchase.CostPrice AS totalDamageCost, 
IFNULL(Inv_Purchase.quantity_sold,0) * Inv_Purchase.CostPrice AS totalsoldCost,
Inv_Purchase.Quantity * Inv_Purchase.SellingPrice AS totalSP, 
IFNULL(Inv_Purchase.purchaseReturn,0) * Inv_Purchase.SellingPrice AS totalPRSP,
IFNULL(Inv_Purchase.salesReturn,0) * Inv_Purchase.SellingPrice AS totalSRSP, 
IFNULL(Inv_Purchase.quantity_damage,0) * Inv_Purchase.SellingPrice AS totalDamageSP, 
IFNULL(Inv_Purchase.quantity_sold,0) * Inv_Purchase.SellingPrice AS totalSoldSP, 
Inv_Purchase.entrydate AS Inv_Purchase_entrydate, 
Product_Group_Master.Id AS Product_Group_Master_id, 
Product_Group_Master.Code  || '.' ||  Product_Master.Code  AS Code,
Product_Company_Master.Name AS Company, 
Product_Group_Master.Name AS [Group], 
Vendor_Master.Id AS Vendor_Master_id,
Vendor_Master.Name AS VendorName,
Product_Company_Master.Id AS Product_Company_Master_id,
item_type_master.IncomeOrExpense  as itemtype
FROM         
Inv_Purchase 
LEFT OUTER JOIN Product_Master ON Product_Master.Id = Inv_Purchase.fk_Product 
LEFT OUTER JOIN Vendor_Master ON Vendor_Master.Id = Inv_Purchase.fk_Vendor 
LEFT OUTER JOIN Unit_Master ON Product_Master.fk_MeasureUnit = Unit_Master.Id 
LEFT OUTER JOIN Product_Company_Master ON Product_Master.fk_Company = Product_Company_Master.Id 
LEFT OUTER JOIN Product_Group_Master ON Product_Master.fk_Group = Product_Group_Master.Id
left outer join item_type_master on product_group_master.fk_ItemType = item_type_master.Id
WHERE     (1 = 1)
 
");
            }
        }

        public void UpdateStructure()
        {
            (new Pasal.BLL.General()).createGeneral_unit2();
            createPasalDataStructure();
            createPasalViews();
            (new Pasal.BLL.TagsDML()).createPasalDataStructure();
        }

    }
}





