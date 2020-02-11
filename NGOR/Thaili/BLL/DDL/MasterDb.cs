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


        public void createNgorMasterDataStructure()
        {
            createNgorMasterDataStructureSample("Objective");
            createNgorMasterDataStructureSample("Document");
            createNgorMasterDataStructureSample("AffiliationOrganization");
            createNgorMasterDataStructureSample("SubjectiveWrk");
            createNgorMasterDataStructureSample("TargetAudience");
            createNgorMasterDataStructureSample("MajorTaskAchieved");
            createNgorMasterDataStructureSample("Master_Specialization");
            createNgorMasterDataStructureSample("Master_Position");
            createNgorMasterDataStructureSample("Master_Sex");
            createNgorMasterDataStructureSample("Master_Education");
            createNgorMasterDataStructureSample("Master_MaritalStatus");
            createNgorMasterDataStructureSample("Master_Ethnicity");
            createNgorMasterDataStructureSample("Master_Profession");
            createNgorMasterDataStructureSample("Person_Role");




        }
        private void createNgorMasterDataStructureSample(string tableName)
        {
            if (!GlobalResources .DbStruct  .DoesTableExists(tableName))
            {
                Bsoft.Data.DbHelpers.CreateATable(string.Format(@" 
CREATE TABLE {0}(
Id Integer primary key AUTOINCREMENT , 
Title varchar)", tableName));

                if (tableName == "Person_Role")
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("insert into Person_Role  (Title) values ('साधारण सदस्य ')");
                    GlobalResources.SelectDBConnection .ExecuteNonQuery(sb.ToString()); sb.Remove(0, sb.Length);
                    sb.AppendLine("insert into Person_Role  (Title) values ('कार्य समिति ')");
                    GlobalResources.SelectDBConnection.ExecuteNonQuery(sb.ToString()); sb.Remove(0, sb.Length);
                    sb.AppendLine("insert into Person_Role  (Title) values ('कर्मचारी ')");
                    GlobalResources.SelectDBConnection.ExecuteNonQuery(sb.ToString()); sb.Remove(0, sb.Length);
                    sb.AppendLine("insert into Person_Role  (Title) values ('स्वयंसेवक ')");
                    GlobalResources.SelectDBConnection.ExecuteNonQuery(sb.ToString());
                }

                if (tableName == "Master_Ethnicity")
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("insert into Master_Ethnicity  (Title) values ('जनजाती ')");
                    GlobalResources.SelectDBConnection .ExecuteNonQuery(sb.ToString()); sb.Remove(0, sb.Length);
                    sb.AppendLine("insert into Master_Ethnicity  (Title) values ('दलित ')");
                    GlobalResources.SelectDBConnection .ExecuteNonQuery(sb.ToString()); sb.Remove(0, sb.Length);
                    sb.AppendLine("insert into Master_Ethnicity  (Title) values ('अन्य ')");
                    GlobalResources.SelectDBConnection .ExecuteNonQuery(sb.ToString()); sb.Remove(0, sb.Length);

                }
                if (tableName == "Master_Sex")
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("insert into Master_Sex  (Title) values ('पुरुष ')");
                    GlobalResources.SelectDBConnection .ExecuteNonQuery(sb.ToString()); sb.Remove(0, sb.Length);
                    sb.AppendLine("insert into Master_Sex  (Title) values ('महिला ')");
                    GlobalResources.SelectDBConnection .ExecuteNonQuery(sb.ToString()); sb.Remove(0, sb.Length);
                    sb.AppendLine("insert into Master_Sex  (Title) values ('तेश्रो लिङ ')");
                    GlobalResources.SelectDBConnection .ExecuteNonQuery(sb.ToString());
                }

                if (tableName == "AffiliationOrganization")
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Remove(0, sb.Length);
                    sb.AppendLine("insert into AffiliationOrganization  (Title) values ('जिल्ला प्रशासन कार्यालय ')");
                    GlobalResources.SelectDBConnection .ExecuteNonQuery(sb.ToString());
                    sb.Remove(0, sb.Length);
                    sb.AppendLine("insert into AffiliationOrganization  (Title) values ('समाज कल्याण परिषद ')");
                    GlobalResources.SelectDBConnection .ExecuteNonQuery(sb.ToString()); sb.Remove(0, sb.Length);
                    sb.AppendLine("insert into AffiliationOrganization  (Title) values ('गैसस महासंघ नेपाल ')");
                    GlobalResources.SelectDBConnection .ExecuteNonQuery(sb.ToString()); sb.Remove(0, sb.Length);
                    sb.AppendLine("insert into AffiliationOrganization  (Title) values ('जि.वि.स. NGO  Desk ')");
                    GlobalResources.SelectDBConnection .ExecuteNonQuery(sb.ToString()); sb.Remove(0, sb.Length);
                    sb.AppendLine("insert into AffiliationOrganization  (Title) values ('स्थायी लेखा नम्बर (PAN) ')");
                    GlobalResources.SelectDBConnection .ExecuteNonQuery(sb.ToString());

                }
            }

        }


        public  void otherMaster()
        {


            if (!GlobalResources.DbStruct .DoesTableExists("HelpingOrganization"))
            {
                DbHelpers.CreateATable(@" 

CREATE TABLE HelpingOrganization(
Id Integer primary key autoincrement , 
Name varchar(50),
TypeLocal varchar(1),
fk_Address Integer,
Objective varchar(150)
,  UserIDEntry varchar, 
  DT_DataEntry varchar, 
  UserIDEdit varchar, 
  DT_DataEdit varchar 
,CONSTRAINT FK__fk_Address FOREIGN KEY (fk_Address) REFERENCES Address (Id))  
 
");


            }


            if (!GlobalResources.DbStruct.DoesTableExists("FinancialSource"))
{
 DbHelpers.CreateATable(@" 
CREATE TABLE FinancialSource(
Id Integer primary key autoincrement , 
Name varchar(50),
TypeLocal varchar(1),
fkHelpingOrganization Integer
,  UserIDEntry varchar, 
  DT_DataEntry varchar, 
  UserIDEdit varchar, 
  DT_DataEdit varchar 
,CONSTRAINT FK_HelpingOrganization_fkHelpingOrganization FOREIGN KEY (fkHelpingOrganization) REFERENCES HelpingOrganization (Id))");
}

          

   

        }
    }
}
