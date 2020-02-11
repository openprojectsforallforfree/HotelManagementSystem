using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Bsoft.CrystalReport;
using CrystalDecisions.Shared;


namespace NGOReports
{
   public static  class QuestionsReport
    {
        public static void GetReport(string ReportName,string pk)
        {
            DataTable dt = Reports.DAL.NGO.GetNGOData(pk);
            DataRow dr = dt.Rows[0];
            

            ReportBase rb = new ReportBase();
            rb.LoadReport(ReportName);

            rb.SetFieldValue(dr, "District", "District", FieldTypes.String);
            rb.SetFieldValue(dr, "NepaliName", "NepaliName", FieldTypes.String);
            rb.SetFieldValue(dr, "EnglishName", "EnglishName", FieldTypes.String);
            rb.SetFieldValue(dr, "Acronym", "Acronym", FieldTypes.String);
            rb.SetFieldValue(dr, "Address", "Address", FieldTypes.String);
            rb.SetFieldValue(dr, "ContanctPersonName", "ContanctPersonName", FieldTypes.String);
            rb.SetFieldValue(dr, "PresidentName", "PresidentName", FieldTypes.String);
            rb.SetFieldValue(dr, "Phone", "Phone", FieldTypes.String);
            rb.SetFieldValue(dr, "Fax", "Fax", FieldTypes.String);
            rb.SetFieldValue(dr, "Email", "Email", FieldTypes.String);
            rb.SetFieldValue(dr, "Website", "Website", FieldTypes.String);
            rb.SetFieldValue(dr, "MobileNo", "MobileNo", FieldTypes.String);

            rb.SetFieldValue(dr, "IshtablishDate", "IstablishDate", FieldTypes.String);
            rb.SetFieldValue(dr, "lastagmdate", "lastagmdate", FieldTypes.String);
            rb.SetFieldValue(dr, "lastauditdate", "lastauditdate", FieldTypes.String);
            rb.SetFieldValue(dr, "parikalpana", "parikalpana", FieldTypes.String);
            rb.SetFieldValue(dr, "dhaye", "dhyaye", FieldTypes.String);
            rb.SetFieldValue(dr, "lakshya", "lakshya", FieldTypes.String);
            rb.SetFieldValue(dr, "udeshya", "udeshya", FieldTypes.String);

            rb.SetFieldValue(dr, "bisayagat", "bisayagat", FieldTypes.String);
            rb.SetFieldValue(dr, "chalanges", "chalanges", FieldTypes.String);


            rb.SetFieldValue(dr, "t1_GoalPlan", "rananitiYesNo", FieldTypes.String);
            rb.SetFieldValue(dr, "t1_FiscalPlan", "arthiknitiYesNo", FieldTypes.String);
            rb.SetFieldValue(dr, "t1_HrPlan", "HrNitiYesNo", FieldTypes.String);
            rb.SetFieldValue(dr, "t1_BudgetPlan", "BudgetNitiYesNo", FieldTypes.String);

            rb.SetFieldValue(dr, "t1_Achievements", "MainAchivementsWithPhysical", FieldTypes.String);
            rb.SetFieldValue(dr, "chalanges", "MainChallenges", FieldTypes.String);

            //rb.SetFieldValue(dr, "udeshya", "udeshya", FieldTypes.String);
            //rb.SetFieldValue(dr, "bisayagat", "bisayagat", FieldTypes.String);
            //rb.SetFieldValue(dr, "t1_TargetAudienceText", "t1_TargetAudienceText", FieldTypes.String);

            DataTable affiliation = Reports.DAL.NGO.GetAffiliations(pk);
            DataTable physycalWorkArea = Reports.DAL.NGO.GetPhysicalWorkingAreas (pk);

            DataTable dataFororgStr = Reports.DAL.NGO.GetOrgStructureBasedonSex_Ethnicity(pk);
            DataTable dataForDiffAbled = Reports.DAL.NGO.GetOrgStructureBasedonDifferentlyAbled(pk);
            DataTable dtForHelpingOrt = Reports.DAL.NGO.GetHelpingOrgDetails(pk);
            DataTable dtForWrokingComitee = Reports.DAL.NGO.GetWorkingComitieeMembers(pk);

            rb.LoadDataTableInReport("Affiliation", affiliation);
            rb.LoadDataTableInReport("PhysicalWorkingArea", physycalWorkArea);
            rb.LoadDataTableInReport("OrgStructure", dataFororgStr);
            rb.LoadDataTableInReport("DifferentlyAbled", dataForDiffAbled);
            rb.LoadDataTableInReport("HelpingOrg", dtForHelpingOrt);
            rb.LoadDataTableInReport("WorkingComitee", dtForWrokingComitee);
            
            // Papers Size, Orientiation and Zoom Setting
            rb.PrinterProperties.PaperSize = PaperSize.PaperA4;
            rb.PrinterProperties.PaperOrientiation = PaperOrientation.Portrait;
            rb.PrinterProperties.ZoomPercentage = 80;

            rb.DisplayReport(ReportName, string.Empty, false, ReportSourceType.DataSetType);
        }
    }
}
