using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using Bsoft.Common;
using Bsoft.Data;
using Bsoft.AppCom;

namespace UEMS.BLL
{
    public partial class ChangeDBStructure
    {
        public void BasicDb()
        {


            if (!GlobalResources.DbStruct.DoesTableExists("Address"))
            {
                DbHelpers.CreateATable (@" 
CREATE TABLE Address(
Id Integer primary key Autoincrement , 
Tole varchar(15),
LocalBody varchar(15),
District varchar(15),
Zone varchar(15),
Country varchar(15))

");
            }

            if (!GlobalResources.DbStruct.DoesTableExists("ContactInformation"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE ContactInformation(
Id Integer primary key Autoincrement , 
Phone varchar(50),
Fax varchar(50),
Email varchar(50),
WebSite varchar(50),
MobileNo varchar(50))");
            }


            if (!GlobalResources.DbStruct.DoesTableExists("IndividualPerson"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE IndividualPerson(
Id Integer primary key autoincrement , 
FirstName varchar(50),
LastName varchar(50),
fk_Gender Integer,
DateofBirth Integer,
fk_Ethnicity Integer,
DifferentlyAbled varchar(1),
fk_Specialization Integer,
SocialWorkExp Varchar,
fk_HighestEducation Integer,
fk_Position Integer,
fk_Address Integer,
fk_ContactInformation Integer,
fk_Master_Profession Integer,CONSTRAINT FK_Master_Sex_fk_Gender FOREIGN KEY (fk_Gender) REFERENCES Master_Sex (Id), 
CONSTRAINT FK_Master_Ethnicity_fk_Ethnicity FOREIGN KEY (fk_Ethnicity) REFERENCES Master_Ethnicity (Id), 
CONSTRAINT FK_Master_Specialization_fk_Specialization FOREIGN KEY (fk_Specialization) REFERENCES Master_Specialization (Id), 
CONSTRAINT FK_Master_Education_fk_HighestEducation FOREIGN KEY (fk_HighestEducation) REFERENCES Master_Education (Id), 
CONSTRAINT FK_Master_Position_fk_Position FOREIGN KEY (fk_Position) REFERENCES Master_Position (Id), 
CONSTRAINT FK_Address_fk_Address FOREIGN KEY (fk_Address) REFERENCES Address (Id), 
CONSTRAINT FK_ContactInformation_fk_ContactInformation FOREIGN KEY (fk_ContactInformation) REFERENCES ContactInformation (Id), 
CONSTRAINT FK_Master_Profession_fk_Master_Profession FOREIGN KEY (fk_Master_Profession) REFERENCES Master_Profession (Id))");
            }



            


        }
    }
}
