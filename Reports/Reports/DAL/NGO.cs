using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UEMS.BLL;

namespace Reports.DAL
{
    public static class NGO
    {
        public static DataTable GetNGOData(String id)
        {
            string query =string .Format (@"
SELECT
	t1.Id t1_Id,
    t2.District District,
	t1.Name NepaliName,
	t1.EnglishName EnglishName,
	t1.Acronym Acronym,
    t2.Tole || ' ' || LocalBody || ' ' || District || ' ' || Zone || ' ' || Country Address,

t3.Phone Phone,
		t3.Fax Fax,
t3.Email Email,
t3.WebSite Website,
t3.MobileNo MobileNo,

t1.D_Established IshtablishDate,
	t1.D_LastAgm lastagmdate,
	t1.D_LastAudit lastauditdate,
t1.Parikalpana parikalpana,
	t1.Dhyaye dhaye,
	t1.Lakshya lakshya,
	t1.Udeshya udeshya,

t1.SubjectiveWrkText bisayagat,
	t1.Challenges chalanges,

	t1.DDCCode t1_DDCCode,
	t1.D_Registration t1_D_Registration,
	
	t1.WorkingAreaText t1_WorkingAreaText,

	
	
	t1.TargetAudienceText t1_TargetAudienceText,
	t1.WorkDoneText t1_WorkDoneText,
	t1.GoalPlan t1_GoalPlan,
	t1.FiscalPlan t1_FiscalPlan,
	t1.HrPlan t1_HrPlan,
	t1.BudgetPlan t1_BudgetPlan,
	t1.Achievements t1_Achievements,

	t1.fk_FormFillBy t1_fk_FormFillBy,
	t1.fk_RegisterBy t1_fk_RegisterBy,
	t1.Remarks t1_Remarks,
	t1.fk_Address t1_fk_Address,
	
	t1.fk_ContactInformation t1_fk_ContactInformation,
	
	t1.fk_ContactPerson t1_fk_ContactPerson,
	t4.FirstName || ' ' || LastName ContanctPersonName ,
    t1.UserIDEntry UserIDEntry
FROM NGO t1

	 left join Address t2 on t1.fk_Address = t2.id 
	 left join ContactInformation t3 on t1.fk_ContactInformation = t3.id 
	 left join IndividualPerson t4 on t1.fk_ContactPerson = t4.id   

WHERE t1.id ='{0}'
", id);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(query);
            return dt;
        }

         public static DataTable  GetAffiliations(string id)
        { 
              string query =string .Format (@"
        SELECT
	t1.Id t1_Id,
	t1.fk_NGO t1_fk_NGO,
	t1.RegistrationDate DartaMiti,
	t1.AffiliationDate AbadataMiti,
	t1.RedgeNo DartaNumber,
	t1.LastRenualDate LastRenewDate,
	t1.RenualDuration RenewDuration,
	t1.fk_AffiliationOrganization t1_fk_AffiliationOrganization,
	t2.Title Nikaye 
FROM NGO_AffiliationOrganization t1
left join AffiliationOrganization t2 on t1.fk_AffiliationOrganization = t2.Id   WHERE 1=1  AND 
t1.fk_NGO = '{0}' 
", id);
              DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(query);
              return dt;
        }

    }
}
