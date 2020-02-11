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
        private void NgorprincpalDb()
        {

            if (!GlobalResources.DbStruct.DoesTableExists("NGO"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE NGO(
Id Integer primary key autoincrement , 
Name varchar(150),
EnglishName varchar(50),
Acronym varchar(50),
DDCCode varchar(15),
fk_Address Integer,
D_Registration varchar(15),
D_Established varchar(15),
WorkingAreaText varchar(250),
fk_ContactInformation Integer,
fk_President Integer,
fk_ContactPerson Integer,
D_LastAgm varchar(15),
D_LastAudit varchar(15),
Parikalpana varchar,
Dhyaye varchar,
Lakshya varchar,
Udeshya varchar,
SubjectiveWrkText varchar,
TargetAudienceText varchar,
WorkDoneText varchar,
GoalPlan varchar(1),
FiscalPlan varchar(1),
HrPlan varchar(1),
BudgetPlan varchar(1),
Achievements varchar,
Challenges varchar,
fk_FormFillBy Integer,
fk_RegisterBy Integer,
Remarks varchar
,  UserIDEntry varchar, 
  DT_DataEntry varchar, 
  UserIDEdit varchar, 
  DT_DataEdit varchar 
,CONSTRAINT FK_Address_fk_Address FOREIGN KEY (fk_Address) REFERENCES Address (Id), 
CONSTRAINT FK_ContactInformation_fk_ContactInformation FOREIGN KEY (fk_ContactInformation) REFERENCES ContactInformation (Id), 
CONSTRAINT FK_IndividualPerson_fk_President FOREIGN KEY (fk_President) REFERENCES IndividualPerson (Id), 
CONSTRAINT FK_IndividualPerson_fk_ContactPerson FOREIGN KEY (fk_ContactPerson) REFERENCES IndividualPerson (Id), 
CONSTRAINT FK_IndividualPerson_fk_FormFillBy FOREIGN KEY (fk_FormFillBy) REFERENCES IndividualPerson (Id), 
CONSTRAINT FK_IndividualPerson_fk_RegisterBy FOREIGN KEY (fk_RegisterBy) REFERENCES IndividualPerson (Id))");
            }


            if (!GlobalResources.DbStruct.DoesTableExists("RenualOfRegistraion"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE RenualOfRegistraion(
Id Integer primary key autoincrement , 
fk_NGO Integer,
FiscalyearId Integer,
D_RenalDate varchar(15),
D_RenualTill varchar(15),
RenewBy Integer
,  UserIDEntry varchar, 
  DT_DataEntry varchar, 
  UserIDEdit varchar, 
  DT_DataEdit varchar 
,CONSTRAINT FK_NGO_fk_NGO FOREIGN KEY (fk_NGO) REFERENCES NGO (Id), 
CONSTRAINT FK_FiscalYear_FiscalyearId FOREIGN KEY (FiscalyearId) REFERENCES FiscalYear (Id))
");
            }



            if (!GlobalResources.DbStruct.DoesTableExists("YearlyReport"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE YearlyReport(
Id Integer primary key autoincrement , 
fk_NGO Integer,
FiscalYearId Integer,
AuthorisedAmount float(20,2),
RecievedAmount float(20,2),
SpentAmount float(20,2),
SignedBy ,
D_Date ,CONSTRAINT FK_NGO_fk_NGO FOREIGN KEY (fk_NGO) REFERENCES NGO (Id), 
CONSTRAINT FK_FiscalYears_FiscalYearId FOREIGN KEY (FiscalYearId) REFERENCES FiscalYears (Id))"
                    );
            }



        }
    }
}
