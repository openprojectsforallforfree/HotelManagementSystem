using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bsoft.Data;


namespace Reports.DAL
{
    public static class NGO
    {
        public static DataTable GetNGOData(String id)
        {
            string query = string.Format(@"
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
		t4.FirstName || ' ' || t4.LastName ContanctPersonName ,
	t5.FirstName || ' ' || t5.LastName PresidentName ,
    t1.UserIDEntry UserIDEntry
FROM NGO t1

	 left join Address t2 on t1.fk_Address = t2.id 
	 left join ContactInformation t3 on t1.fk_ContactInformation = t3.id 
	 left join IndividualPerson t4 on t1.fk_ContactPerson = t4.id   
     left join IndividualPerson t5 on t1.fk_President = t5.id     

WHERE t1.id ='{0}'
", id);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(query);
            ReportHelperFunctions.PutYesNo(dt, "t1_GoalPlan", "t1_FiscalPlan", "t1_HrPlan", "t1_BudgetPlan");
            return dt;
        }


        public static DataTable GetAffiliations(string id)
        {
            string query = string.Format(@"
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


        public static DataTable GetPhysicalWorkingAreas(string id)
        {
            string query = string.Format(@"
                                        SELECT
                                        t1.Id Id,
                                        '' as Sno,
                                        t1.fk_NGO t1_fk_NGO,
                                        t2.District as District,
                                        t2.LocalBody  as LocalBody
                                        FROM NGO_WorkingArea t1
                                        left join Address t2 on t1.fk_Address = t2.Id   WHERE 1=1  AND 
                                        t1.fk_NGO = '{0}' 
", id);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(query);
            //Add serial no 
            int i = 1;
            foreach (DataRow dr in dt.Rows)
            {
                dr["Sno"] = i.ToString(); i++;
            }
            return dt;
        }

        private static int GetCountforDifferentAbled(string ngodi, string personRoleId, string genderid)
        {
            string qry = string.Format(@"select count(*) from ngo_member n 
left  join personview p on p.personid= n.fk_person
where n.fk_ngo='{0}' and p.fk_person_role={1} and genderid={2}
 and p.DifferentlyAbled =1", ngodi, personRoleId, genderid);

            string counst = GlobalResources.SelectDBConnection.ExecuteScalar(qry).ToString();
            int count = 0;
            try { count = int.Parse(counst); }
            catch { }
            return count;
        }

        private static int GetCountforDifferentAbledTotal(string ngodi, string personRoleId)
        {
            string qry = string.Format(@"select count(*) from ngo_member n 
left  join personview p on p.personid= n.fk_person
where n.fk_ngo='{0}' and p.fk_person_role={1}  
 and p.DifferentlyAbled =1", ngodi, personRoleId);

            string counst = GlobalResources.SelectDBConnection.ExecuteScalar(qry).ToString();
            int count = 0;
            try { count = int.Parse(counst); }
            catch { }
            return count;
        }

        private static int GetCountforStr(string ngodi, string personRoleId, string genderid, string ethnicityid)
        {
            string qry = string.Format(@"select count(*) from ngo_member n 
left  join personview p on p.personid= n.fk_person
where n.fk_ngo='{0}' and p.fk_person_role={1} and genderid={2}
 and fk_ethnicity={3}", ngodi, personRoleId, genderid, ethnicityid);

            string counst = GlobalResources.SelectDBConnection.ExecuteScalar(qry).ToString();
            int count = 0;
            try { count = int.Parse(counst); }
            catch { }
            return count;
        }

        private static int GetCountforStrTotal(string ngodi, string personRoleId, string ethnicityid)
        {
            string qry = string.Format(@"select count(*) from ngo_member n 
left  join personview p on p.personid= n.fk_person
where n.fk_ngo='{0}' and p.fk_person_role={1} 
 and fk_ethnicity={2}", ngodi, personRoleId, ethnicityid);

            string counst = GlobalResources.SelectDBConnection.ExecuteScalar(qry).ToString();
            int count = 0;
            try { count = int.Parse(counst); }
            catch { }
            return count;
        }

        public static DataTable GetOrgStructureBasedonSex_Ethnicity(string id)
        {
            string query = "select id,title as ethnicity  from master_ethnicity";
            DataTable dtEthnicity = GlobalResources.SelectDBConnection.ExecuteDataTable(query);
            dtEthnicity.Columns.Add("M_simple");
            dtEthnicity.Columns.Add("F_simple");
            dtEthnicity.Columns.Add("T_simple");
            dtEthnicity.Columns.Add("Tot_simple");

            dtEthnicity.Columns.Add("M_Work");
            dtEthnicity.Columns.Add("F_Work");
            dtEthnicity.Columns.Add("T_Work");
            dtEthnicity.Columns.Add("Tot_Work");

            dtEthnicity.Columns.Add("M_Emp");
            dtEthnicity.Columns.Add("F_Emp");
            dtEthnicity.Columns.Add("T_Emp");
            dtEthnicity.Columns.Add("Tot_Emp");

            foreach (DataRow drEthnicity in dtEthnicity.Rows)
            {
                string ethnicity = drEthnicity["Id"].ToString();

                drEthnicity["M_simple"] = GetCountforStr(id, "1", "1", ethnicity);
                drEthnicity["F_simple"] = GetCountforStr(id, "1", "2", ethnicity);
                drEthnicity["T_simple"] = GetCountforStr(id, "1", "3", ethnicity);
                drEthnicity["Tot_simple"] = GetCountforStrTotal(id, "1", ethnicity);

                drEthnicity["M_Work"] = GetCountforStr(id, "2", "1", ethnicity);
                drEthnicity["F_Work"] = GetCountforStr(id, "2", "2", ethnicity);
                drEthnicity["T_Work"] = GetCountforStr(id, "2", "3", ethnicity);
                drEthnicity["Tot_Work"] = GetCountforStrTotal(id, "2", ethnicity);

                drEthnicity["M_Emp"] = GetCountforStr(id, "3", "1", ethnicity);
                drEthnicity["F_Emp"] = GetCountforStr(id, "3", "2", ethnicity);
                drEthnicity["T_Emp"] = GetCountforStr(id, "3", "3", ethnicity);
                drEthnicity["Tot_Emp"] = GetCountforStrTotal(id, "31", ethnicity);
            }

            ReportHelperFunctions.AddTotal(dtEthnicity, "ethnicity", "जम्मा", "M_simple", "F_simple", "T_simple", "Tot_simple", "M_Work", "F_Work", "T_Work", "Tot_Work", "M_Emp", "F_Emp", "T_Emp", "Tot_Emp");



            //Add serial no 
            int i = 1;
            //foreach (DataRow dr in dt.Rows)
            //{
            //    dr["Sno"] = i.ToString(); i++;
            //}
            return dtEthnicity;
        }


        public static DataTable GetHelpingOrgDetails(string id)
        {
            string query = string.Format(@" select h.name,h.objective from NGO_HelpingOrganization nh 
left join ngo n on n.Id = nh.fk_NGO 
left join helpingorganization h on h.id = nh.fk_HelpingOrganization 
 where n.Id ='{0}'", id);
            DataTable HelpingOrgDetails = GlobalResources.SelectDBConnection.ExecuteDataTable(query);
           ReportHelperFunctions. AddSerialNo(HelpingOrgDetails);
            return HelpingOrgDetails;
        }


        public static DataTable GetOrgStructureBasedonDifferentlyAbled(string id)
        {
            DataTable dtEthnicity = new DataTable();
            try
            {


                dtEthnicity.Columns.Add("M_simple");
                dtEthnicity.Columns.Add("F_simple");
                dtEthnicity.Columns.Add("T_simple");
                dtEthnicity.Columns.Add("Tot_simple");

                dtEthnicity.Columns.Add("M_Work");
                dtEthnicity.Columns.Add("F_Work");
                dtEthnicity.Columns.Add("T_Work");
                dtEthnicity.Columns.Add("Tot_Work");

                dtEthnicity.Columns.Add("M_Emp");
                dtEthnicity.Columns.Add("F_Emp");
                dtEthnicity.Columns.Add("T_Emp");
                dtEthnicity.Columns.Add("Tot_Emp");


                DataRow drEthnicity = dtEthnicity.NewRow();

                drEthnicity["M_simple"] = GetCountforDifferentAbled(id, "1", "1");
                drEthnicity["F_simple"] = GetCountforDifferentAbled(id, "1", "2");
                drEthnicity["T_simple"] = GetCountforDifferentAbled(id, "1", "3");
                drEthnicity["Tot_simple"] = GetCountforDifferentAbledTotal(id, "1");

                drEthnicity["M_Work"] = GetCountforDifferentAbled(id, "2", "1");
                drEthnicity["F_Work"] = GetCountforDifferentAbled(id, "2", "2");
                drEthnicity["T_Work"] = GetCountforDifferentAbled(id, "2", "3");
                drEthnicity["Tot_Work"] = GetCountforDifferentAbledTotal(id, "2");

                drEthnicity["M_Emp"] = GetCountforDifferentAbled(id, "3", "1");
                drEthnicity["F_Emp"] = GetCountforDifferentAbled(id, "3", "2");
                drEthnicity["T_Emp"] = GetCountforDifferentAbled(id, "3", "3");
                drEthnicity["Tot_Emp"] = GetCountforDifferentAbledTotal(id, "31");

                dtEthnicity.Rows.Add(drEthnicity);
                //Add serial no 
                int i = 1;
                //foreach (DataRow dr in dt.Rows)
                //{
                //    dr["Sno"] = i.ToString(); i++;
                //}
            }
            catch
            {
                throw;
            }
            return dtEthnicity;
        }

        public static DataTable GetWorkingComitieeMembers(string id)
        {
            string query = string.Format(@"
select p.name,p.position,p.education,p.DateofBirth, '' as Age,p.Specialization,p.SocialWorkExp,p.Phone ,p.email   from ngo_member n 
left  join personview p on p.personid= n.fk_person
where n.fk_ngo='{0}' and p.fk_person_role='2' 
", id);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(query);
            //Add serial no 
            ReportHelperFunctions.GetAge(dt,"DateofBirth");
            ReportHelperFunctions.AddSerialNo (dt);
            
            return dt;
        }
      
    }

    public static class ReportHelperFunctions
    {
        public static void PutYesNo(DataTable dt, params string[] yesnoCols)
        {
            foreach (string str in yesnoCols)
            {
                if (dt.Rows[0][str].ToString().Trim() == "0")
                {
                    dt.Rows[0][str] = "छ";
                }
                else
                {
                    dt.Rows[0][str] = "छैन";
                }
            }
        }
        public static void AddTotal(DataTable dt, string totalCol, string totalstr, params string[] Columns)
        {
            try
            {
                string[] totals = Columns;
                int total = 0, i = 0;
                DataRow drTotal = dt.NewRow();
                drTotal[totalCol] = totalstr;
                foreach (string column in Columns)
                {
                    total = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        int val = 0;
                        try
                        {
                            val = int.Parse(dr[column].ToString());
                        }
                        catch { }
                        total = total + val;
                    }
                    drTotal[column] = total;
                }
                dt.Rows.Add(drTotal);
            }
            catch
            {
                string s = "";
            }
        }
        public static void AddSerialNo(DataTable dt)
        {
            dt.Columns.Add("Sno");
            int i = 1;
            foreach (DataRow dr in dt.Rows)
            {
                dr["Sno"] = i.ToString(); i++;
            }
        }

        public static void GetAge(DataTable  dt,string colName)
        {
            foreach (DataRow dr in dt.Rows)
            {
              string dob =  dr[colName].ToString ();
              Bsoft.Date.NepaliDate n = new Bsoft.Date.NepaliDate(dob ,"yyyymmdd",true );
              string age =(Math .Round ( ( Bsoft.Date.NepaliDate.Today -n).TotalDays/365)).ToString () ;
              age = age + " बर्ष";
              dr["Age"] = age;
            }
        }
    }
}
