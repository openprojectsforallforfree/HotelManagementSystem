using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.Data;

namespace RestoSys.BLL
{
    class TagsDML
    {
        public void createTagDataStructure()
        {
            if (!GlobalResources.DbStruct.DoesTableExists("TagType"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE TagType(
Id int primary key autoincrement , 
Title varchar(25) unique,
Remarks varchar(150))");

                GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO TagType (Title)  VALUES('Weight')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO TagType (Title)  VALUES('Length')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO TagType (Title)  VALUES('Volume')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO TagType (Title)  VALUES('Color')");
                GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO TagType (Title)  VALUES('Date')");

            }
            if (!GlobalResources.DbStruct.DoesTableExists("TagGroup"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE TagGroup(
Id int primary key autoincrement , 
Title varchar(25) unique,
TagTypeId varchar(15),
Remarks varchar(150),CONSTRAINT FK_TagType_TagTypeId FOREIGN KEY (TagTypeId) REFERENCES TagType (Id))");

                GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO TagGroup (Title,TagTypeId)  VALUES('Weight',1)");
                GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO TagGroup (Title,TagTypeId)  VALUES('Size',2)");
                GlobalResources.DbStruct.Con.ExecuteNonQuery("INSERT INTO TagGroup (Title,TagTypeId)  VALUES('Color',4)");
            }
            if (!GlobalResources.DbStruct.DoesTableExists("Tag"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE Tag(
Id int primary key autoincrement , 
TagGroupId int,
Value varchar(150),CONSTRAINT FK_TagGroup_TagGroupId FOREIGN KEY (TagGroupId) REFERENCES TagGroup (Id))");
            }


//            if (!GlobalResources.DbStruct.DoesTableExists("Item"))
//            {
//                DbHelpers.CreateATable(@" 
//CREATE TABLE Item(
//Id int primary key autoincrement , 
//TagId int,CONSTRAINT FK_Tag_TagId FOREIGN KEY (TagId) REFERENCES Tag (Id))");
//            }


            if (!GlobalResources.DbStruct.DoesTableExists("Item_Tag"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE Item_Tag(
Id int primary key autoincrement , 
TagId int,
ItemId int,
CONSTRAINT FK_Tag_TagId FOREIGN KEY (TagId) REFERENCES Tag (Id), 
CONSTRAINT FK_Master_Product_ItemId FOREIGN KEY (ItemId) REFERENCES Master_Product (Id))");
            }


        }
    }
}