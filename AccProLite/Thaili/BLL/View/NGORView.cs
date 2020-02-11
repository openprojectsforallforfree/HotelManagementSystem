using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.Data;
using Bsoft.Common;
using System.Reflection;

namespace UEMS.BLL.View
{
    class NGORView
    {
         
         
        StringBuilder SQL = new StringBuilder();

        private void createAView(string viewName, string SelectQuery)
        {
            StringBuilder SQLCreateView = new StringBuilder();

            int Rslt = 0;
            SQLCreateView.Remove(0, SQLCreateView.Length);
            SQLCreateView.Append(" CREATE view " + viewName + " as  ");
            SQLCreateView.Append(SelectQuery);
            Rslt = GlobalResources.SelectDBConnection .ExecuteNonQuery(SQLCreateView.ToString());
            if (Rslt != -1)
                LogTrace.WriteInfoLog(this.GetType().Name, MethodBase.GetCurrentMethod().Name, viewName + " view created Successfully. ");
            //else
            //    MessageBoxMy.Show(viewName + " could not be created");

        }

        public void createViewsForNGOR()
        {
            if (!GlobalResources.DbStruct.DoesViewExists("PersonView"))
            {
                createAView("PersonView", @"
                         


select 
n.id NgoMemberId,
n.fk_NGO,
p.Id PersonId,
r.Title Role,
p.FirstName || ' ' || p.LastName as Name ,
p.DifferentlyAbled DifferentlyAbled,
s.title Gender,
pos.title as Position ,
edu.title as education,
SocialWorkExp,
sp.Title as Specialization,
addr.LocalBody || ' ' || addr.district as address, 
info.Phone as Phone,
info.Email as Email,
n.fk_Person_Role as fk_Person_Role ,
n.fk_NGO as fk_NGO 
from ngo_member n 
left join individualperson p on n.fk_person= p.id
left join person_role r on n.fk_person_role = r.id
left join master_sex s on s.id  = p.fk_Gender 
left join master_position pos on pos.id = p.fk_Position 
left join master_education edu on edu.id = p.fk_HighestEducation 
left join contactinformation info on info.id = p.fk_ContactInformation 
left join Master_Specialization sp on sp.id = p.fk_Specialization  
left join address addr on addr.id = p.fk_Address 


 ");
            }


            if (!GlobalResources.DbStruct.DoesViewExists("NGO_ObjectiveView"))
            {
                createAView("NGO_ObjectiveView", @"
            SELECT 
NGO_Objective.Id AS Id,
NGO_Objective.fk_NGO AS fk_NGO,
NGO_Objective.fk_Objective AS fk_Objective,
Objective.Title AS Objective_Title
FROM NGO_Objective
 Left join Objective on Objective.Id = NGO_Objective.fk_Objective
");
            }



        }
        public void createViewsForSchool()
        {
            if (!GlobalResources.DbStruct.DoesViewExists("PersonView"))
            {
                createAView("PersonView", @"select person.id, firstname+ ' ' + Middlename + ' ' + lastname as Name,master_gender.title as Gender, dateofbirth as DOB,fathername ,grandfathername from person
left join master_gender on master_gender.id= person.gender ");
            }
            if (!GlobalResources.DbStruct.DoesViewExists("YearCourseModuleView"))
            {
                createAView("YearCourseModuleView", @"SELECT 
YearCourseModule.Id AS Id,YearCourseModule.CourseStartYearId AS CourseStartYearId,YearCourseModule.CourseId AS CourseId,YearCourseModule.ModuleId AS ModuleId,YearCourseModule.Date AS Date,
Module.Id AS Module_Id,Module.Title AS Module_Title,Module.Remarks AS Module_Remarks,
Course.Id AS Course_Id,Course.Title AS Course_Title,Course.Remarks AS Course_Remarks,
CourseStartYear.Id AS CourseStartYear_Id,CourseStartYear.Title AS CourseStartYear_Title,CourseStartYear.Remarks AS CourseStartYear_Remarks
FROM YearCourseModule
 Left join Module on Module.Id = YearCourseModule.ModuleId 
 Left join Course on Course.Id = YearCourseModule.CourseId 
 Left join CourseStartYear on CourseStartYear.Id = YearCourseModule.CourseStartYearId ");
            }

            if (!GlobalResources.DbStruct.DoesViewExists("SubjectDetailView"))
            {
                createAView("SubjectDetailView", @"SELECT 
SubjectDetail.Id AS Id,SubjectDetail.YearCourseModuleId AS YearCourseModuleId,SubjectDetail.Remarks AS Remarks,
Subject.Id AS Subject_Id,Subject.Title AS Subject_Title,
Course.Id AS Course_Id,Course.Title AS Course_Title, 
Module.Id AS Module_Id,Module.Title AS Module_Title, 
CourseStartYear.Id AS CourseStartYear_Id,CourseStartYear.Title AS CourseStartYear_Title
FROM SubjectDetail
 Left join Subject on Subject.Id = SubjectDetail.SubjectId 
 Left join YearCourseModule on YearCourseModule.Id = SubjectDetail.YearCourseModuleId 
 Left join Course on Course.Id = YearCourseModule.CourseId 
 Left join Module on Module.Id = YearCourseModule.ModuleId 
 Left join CourseStartYear on CourseStartYear.Id = YearCourseModule.CourseStartYearId  ");
            }
            if (!GlobalResources.DbStruct.DoesViewExists("ExamMarksView"))
            {
                createAView("ExamMarksView", @"select 
examid,exammarks.Id,ExamSubjects.Id as examsubjects_id ,StudentId,SubjectDetailView.Subject_Title || '___' || ExamType.title as subject_examtype,Marks,exammarks.Remarks,Subject_Title as subject,ExamType.Title as Examtype, Formula from exammarks
left join ExamSubjects on ExamSubjects.id = exammarks.ExamSubjectsId 
left join  SubjectDetailView on ExamSubjects.SubjectDetailId = SubjectDetailView.Id
left join  ExamType on ExamSubjects.ExamTypeId = ExamType.Id
left join  grading on ExamSubjects.GradingId  = grading.Id");
            }


            if (!GlobalResources.DbStruct.DoesViewExists("ExamSubjectsView"))
            {
                createAView("ExamSubjectsView", @"SELECT ExamSubjects.id as ExamSubjects_id  , ExamSubjects.ExamId as ExamId,SubjectDetailView.Subject_Title as SubjectTitle, ExamType.title  as ExamType ,
SubjectDetailView.Subject_Title || ' ' || ExamType.title  as ExamSubject_Type ,grading.Formula as gradingFormula 
from ExamSubjects
left join  SubjectDetailView on ExamSubjects.SubjectDetailId = SubjectDetailView.Id
left join  ExamType on ExamSubjects.ExamTypeId = ExamType.Id
left join  grading on ExamSubjects.GradingId  = grading.Id;;");
            }

            if (!GlobalResources.DbStruct.DoesViewExists("StudentPerson"))
            {
                createAView("StudentPerson", @" SELECT 
Student.Id AS Student_Id,Student.PersonId AS Student_PersonId,Student.RegisgrationNumber AS Student_RegisgrationNumber,Student.PreviousEducationIsntitureName AS Student_PreviousEducationIsntitureName,Student.PreviousEducationIsntitureAddress AS Student_PreviousEducationIsntitureAddress,Student.Remarks AS Student_Remarks,
Person.Id AS Person_Id,
Person.FirstName || ' ' || Person.MiddleName || ' ' || Person.LastName as Person_Name,
Person.FirstName AS Person_FirstName,Person.MiddleName AS Person_MiddleName,Person.LastName AS Person_LastName,Person.Gender AS Person_Gender,Person.Maritalstatus AS Person_Maritalstatus,Person.Education AS Person_Education,Person.DateofBirth AS Person_DateofBirth,Person.Ethnicity AS Person_Ethnicity,Person.PermanentAddress AS Person_PermanentAddress,Person.TemporaryAddress AS Person_TemporaryAddress,Person.PhoneNo AS Person_PhoneNo,Person.MobileNo AS Person_MobileNo,Person.Email AS Person_Email,Person.PrimaryProfession AS Person_PrimaryProfession,Person.SecondaryProfession AS Person_SecondaryProfession,Person.FatherName AS Person_FatherName,Person.GrandFatherName AS Person_GrandFatherName,Person.ContactPerson AS Person_ContactPerson,Person.Photo AS Person_Photo,Person.CitizenShipNo AS Person_CitizenShipNo,Person.pHouseNo AS Person_pHouseNo,Person.pTole AS Person_pTole,Person.pWardNo AS Person_pWardNo,Person.pMunicipality_Vdc AS Person_pMunicipality_Vdc,Person.pDistrict AS Person_pDistrict,Person.pZone AS Person_pZone,Person.pCountry AS Person_pCountry,Person.tHouseNo AS Person_tHouseNo,Person.tTole AS Person_tTole,Person.tWardNo AS Person_tWardNo,Person.tMunicipality_Vdc AS Person_tMunicipality_Vdc,Person.tDistrict AS Person_tDistrict,Person.tZone AS Person_tZone,Person.tCountry AS Person_tCountry,Person.Remarks AS Person_Remarks,
CourseStartYear.Id AS CourseStartYear_Id,CourseStartYear.Title AS CourseStartYear_Title,CourseStartYear.Remarks AS CourseStartYear_Remarks,
Course.Id AS Course_Id,Course.Title AS Course_Title,Course.Remarks AS Course_Remarks
FROM Student
 Left join Person on Person.Id = Student.PersonId 
 Left join CourseStartYear on CourseStartYear.Id = Student.CourseId
 Left join Course on Course.Id = Student.CourseId");
            }


            if (!GlobalResources.DbStruct.DoesViewExists("YearCourseView"))
            {
                createAView("YearCourseView", @"SELECT 
YearCourse.Id AS YearCourse_Id,YearCourse.CourseId AS YearCourse_CourseId,YearCourse.CourseStartYearId AS YearCourse_CourseStartYearId,
CourseStartYear.Title AS CourseStartYear_Title,
Course.Id AS Course_Id,Course.Title AS Course_Title
FROM YearCourse
 Left join CourseStartYear on CourseStartYear.Id = YearCourse.CourseStartYearId 
 Left join Course on Course.Id = YearCourse.CourseId ");
            }
            if (!GlobalResources.DbStruct.DoesViewExists("CourseModuleView"))
            {
                createAView("CourseModuleView", @"SELECT 
CourseModule.Id AS CourseModule_Id,CourseModule.ModuleId AS CourseModule_ModuleId,CourseModule.CourseId AS CourseModule_CourseId,
Course.Title AS Course_Title,
Module.Title AS Module_Title
FROM CourseModule
 Left join Course on Course.Id = CourseModule.CourseId 
 Left join Module on Module.Id = CourseModule.ModuleId  ");
            }





        }
    }
}
