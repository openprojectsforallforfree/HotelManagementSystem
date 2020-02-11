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
        public void JoinDb()
        {


            if (!GlobalResources.DbStruct.DoesTableExists("NGO_Objective"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE NGO_Objective(
Id Integer primary key autoincrement , 
fk_NGO Integer,
fk_Objective Integer,CONSTRAINT FK_NGO_fk_NGO FOREIGN KEY (fk_NGO) REFERENCES NGO (Id), 
CONSTRAINT FK_Objective_fk_Objective FOREIGN KEY (fk_Objective) REFERENCES Objective (Id))");
            }

            if (!GlobalResources.DbStruct.DoesTableExists("NGO_Document"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE NGO_Document(
Id Integer primary key autoincrement , 
fk_RenualOfRegistraion Integer,
fk_Document Integer,CONSTRAINT FK_RenualOfRegistraion_fk_RenualOfRegistraion FOREIGN KEY (fk_RenualOfRegistraion) REFERENCES RenualOfRegistraion (Id), 
CONSTRAINT FK_Document_fk_Document FOREIGN KEY (fk_Document) REFERENCES Document (Id))");
            }

            if (!GlobalResources.DbStruct.DoesTableExists("NGO_AffiliationOrganization"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE NGO_AffiliationOrganization(
Id Integer primary key autoincrement , 
fk_NGO Integer,
fk_AffiliationOrganization Integer,
RegistrationDate varchar(15),
AffiliationDate varchar(15),
RedgeNo varchar(15),
LastRenualDate varchar(15),
RenualDuration varchar(15),CONSTRAINT FK_NGO_fk_NGO FOREIGN KEY (fk_NGO) REFERENCES NGO (Id), 
CONSTRAINT FK_AffiliationOrganization_fk_AffiliationOrganization FOREIGN KEY (fk_AffiliationOrganization) REFERENCES AffiliationOrganization (Id))");
            }

            if (!GlobalResources.DbStruct.DoesTableExists("NGO_HelpingOrganization"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE NGO_HelpingOrganization(
Id Integer primary key autoincrement , 
fk_NGO Integer,
fk_HelpingOrganization Integer,CONSTRAINT FK_NGO_fk_NGO FOREIGN KEY (fk_NGO) REFERENCES NGO (Id), 
CONSTRAINT FK_HelpingOrganization_fk_HelpingOrganization FOREIGN KEY (fk_HelpingOrganization) REFERENCES HelpingOrganization (Id))");
            }


            if (!GlobalResources.DbStruct.DoesTableExists("NGO_Budget"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE NGO_Budget(
Id Integer primary key autoincrement , 
fk_NGO Integer,
FiscalYearId Integer,
fk_FinancialSource Integer,
Amount float(20,2)
,  UserIDEntry varchar, 
  DT_DataEntry varchar, 
  UserIDEdit varchar, 
  DT_DataEdit varchar 
,CONSTRAINT FK_NGO_fk_NGO FOREIGN KEY (fk_NGO) REFERENCES NGO (Id), 
CONSTRAINT FK_FiscalYear_FiscalYearId FOREIGN KEY (FiscalYearId) REFERENCES FiscalYear (Id), 
CONSTRAINT FK_FinancialSource_fk_FinancialSource FOREIGN KEY (fk_FinancialSource) REFERENCES FinancialSource (Id))");
            }


            if (!GlobalResources.DbStruct.DoesTableExists("NGO_Member"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE NGO_Member(
ID Integer primary key autoincrement , 
fk_NGO Integer,
fk_Person Integer,
fk_Person_Role Integer,
CONSTRAINT FK_NGO_fk_NGO FOREIGN KEY (fk_NGO) REFERENCES NGO (Id), 
CONSTRAINT FK_IndividualPerson_fk_Person FOREIGN KEY (fk_Person) REFERENCES IndividualPerson (Id), 
CONSTRAINT FK_Person_Role_fk_Person_Role FOREIGN KEY (fk_Person_Role) REFERENCES Person_Role (Id))");
            }

            if (!GlobalResources.DbStruct.DoesTableExists("NGO_YearlyReport"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE NGO_YearlyReport(
Id integer primary key autoincrement , 
fk_NGO Integer,
fk_WorkDone Integer
,  UserIDEntry varchar, 
  DT_DataEntry varchar, 
  UserIDEdit varchar, 
  DT_DataEdit varchar 
,CONSTRAINT FK_NGO_fk_NGO FOREIGN KEY (fk_NGO) REFERENCES NGO (Id), 
CONSTRAINT FK_WorkDone_fk_WorkDone FOREIGN KEY (fk_WorkDone) REFERENCES WorkDone (Id))");
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
RenewBy Integer)");
}


if (!GlobalResources.DbStruct.DoesTableExists("YearlyReport"))
{
   DbHelpers.CreateATable (@" 
CREATE TABLE YearlyReport(
Id Integer primary key autoincrement , 
fk_NGO Integer,
FiscalYearId Integer,
AuthorisedAmount float(20,2),
RecievedAmount float(20,2),
SpentAmount float(20,2),
SignedBy Integer,
D_Date varchar(15),CONSTRAINT FK_NGO_fk_NGO FOREIGN KEY (fk_NGO) REFERENCES NGO (Id), 
CONSTRAINT FK_FiscalYears_FiscalYearId FOREIGN KEY (FiscalYearId) REFERENCES FiscalYears (Id))");
}

            if (!GlobalResources.DbStruct.DoesTableExists("Tasks"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE Tasks(
Id Integer primary key autoincrement , 
fk_WorkDone Integer,
Title varchar(150),
ExpensedBudget float(20,2),
Male_Adv Integer,
Female_Adv Integer,
TG_Adv Integer,
Dalit_Adv Integer,
Janjati_Adv Integer,
Other_Adv Integer,CONSTRAINT FK_WorkDone_fk_WorkDone FOREIGN KEY (fk_WorkDone) REFERENCES WorkDone (Id))");
            }






            if (!GlobalResources.DbStruct.DoesTableExists("WorkDone"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE WorkDone(
Id Integer primary key autoincrement , 
fk_OBJECTIVE Integer,
fk_YearlyReport Integer,
fk_Address Integer,
TaskDate varchar(15),
Remarks varchar,
RFU varchar,
CONSTRAINT FK_YearlyReport_fk_YearlyReport FOREIGN KEY (fk_YearlyReport) REFERENCES YearlyReport (Id), 
CONSTRAINT fk_OBJECTIVEfk_OBJECTIVE FOREIGN KEY (fk_OBJECTIVE) REFERENCES Objective (Id), 
CONSTRAINT FK_Address_fk_Address FOREIGN KEY (fk_Address) REFERENCES Address (Id))");
            }



            if (!GlobalResources.DbStruct.DoesTableExists("SubjectiveWrk_NGO"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE SubjectiveWrk_NGO(
Id Integer primary key autoincrement , 
fk_NGO Integer,
fk_SubjectiveWrk Integer,CONSTRAINT FK_NGO_fk_NGO FOREIGN KEY (fk_NGO) REFERENCES NGO (Id), 
CONSTRAINT FK_SubjectiveWrk_fk_SubjectiveWrk FOREIGN KEY (fk_SubjectiveWrk) REFERENCES SubjectiveWrk (Id))");
            }

            if (!GlobalResources.DbStruct.DoesTableExists("TargetAudienceText_NGO"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE TargetAudienceText_NGO(
Id Integer primary key autoincrement , 
fk_NGO Integer,
fk_TargetAudience Integer,CONSTRAINT FK_NGO_fk_NGO FOREIGN KEY (fk_NGO) REFERENCES NGO (Id), 
CONSTRAINT FK_TargetAudience_fk_TargetAudience FOREIGN KEY (fk_TargetAudience) REFERENCES TargetAudience (Id))");
            }

            if (!GlobalResources.DbStruct.DoesTableExists("WorkDone_NGO"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE WorkDone_NGO(
Id Integer primary key autoincrement , 
fk_NGO Integer,
fk_WorkDone Integer,CONSTRAINT FK_NGO_fk_NGO FOREIGN KEY (fk_NGO) REFERENCES NGO (Id), 
CONSTRAINT FK_WorkDone_fk_WorkDone FOREIGN KEY (fk_WorkDone) REFERENCES WorkDone (Id))");
            }

            if (!GlobalResources.DbStruct.DoesTableExists("NGO_WorkingArea"))
            {
                DbHelpers.CreateATable(@" 
CREATE TABLE NGO_WorkingArea(
Id Integer primary key autoincrement , 
fk_NGO Integer,
fk_Address Integer,CONSTRAINT FK_NGO_fk_NGO FOREIGN KEY (fk_NGO) REFERENCES NGO (Id), 
CONSTRAINT FK_Address_fk_Address FOREIGN KEY (fk_Address) REFERENCES Address (Id))");
            }


        }
    }
}
