using System;
using System.Collections.Generic;
using System.Text;

namespace Bsoft.Languages
{
    public class LangNepali : LangInterface
    {
        #region LangInterface Members

        public string ok
        {
            get { return "हुन्छ"; }
        }

        #endregion

        #region LangInterface Members


        public string close
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion


        public string ShouldNotBeEmpty
        {
            get { return "{0} खाली हुनु भएन "; }
        }

        public string CorrectNumber
        {
            get { return "{0}मा सहि नम्बर हाल्नु होल  "; }
        }

        public string CorrectDate
        {
            get { return "{0}मा सहि मिति हाल्नु होल "; }
        }

        public string DoYouWantToLogOff
        {
            get { return "सन्चालनकर्ता बादल्ने हो ?"; }
        }

        public string DoYouWantToSave
        {
            get { return "तथ्यांक सदर गर्ने हो ?"; }
        }

        public string DoYouWantToUpdate
        {
            get { return "तथ्यांक सुधार गर्ने हो ?"; }
        }


        public string DoYouWantToDelete
        {
            get { return "तथ्यांक मेटाउने हो ?"; }
        }
        public string DoYouWantToAddMoreRecords
        {
            get { return "तथ्यांक थप्ने हो ?"; }
        }

        public string NewAdd { get { return "नयाँ थप्ने"; } }
        public string Edit { get { return "सुधार गर्ने"; } }
        public string Delete { get { return "मेटाउने"; } }
        public string Save { get { return "सदर गर्ने"; } }
        public string Search { get { return "खोज्नुस्"; } }
        public string ExporttoExcel { get { return "एक्सेलमा लैजाने"; } }
        public string ExporttoExcelSuccessFull { get { return "एक्सेलमा तथ्याँक संचयन भयो "; } }

        public string Ok { get { return "ठीक छ"; } }//हुन्छ";
        public string Yes { get { return "हो"; } }
        public string No { get { return "होइन"; } }
        public string Close { get { return "बाहिर फर्कने"; } }
        public string Cancel { get { return "फर्कने"; } }
        public string CancelGoBack { get { return "भैहाल्यो, फर्कने"; } }
        public string Date { get { return "मिति"; } }
        public string AttentionPlease { get { return "कृपया ध्यान दिनुहोस् !"; } }
        public string DoYouWantToClose { get { return "तपाईंले बन्द गर्न खोज्नु भएको हो ?"; } }
        public string LogOff { get { return "सन्चालनकर्ता बदल्ने"; } }

        public string Login { get { return "पहिचान प्रमाणिकरण"; } }
        public string OrganizationDetails { get { return "संस्थाका सूचकहरु"; } }

        public string changePassword { get { return "आफ्नो पासवर्ड बादलनुहोस्"; } }
        public string UserName { get { return "संचालानकर्ता "; } }
        public string UserId { get { return "सान्केतिक नाम "; } }
        public string OldPassWord { get { return "पुरानो पहिचान शब्द  "; } }
        public string PassWord { get { return "पहिचान शब्द  "; } }
        public string Active { get { return "सक्रीय"; } }
        public string LastLoginDate { get { return "अन्तिम पटक सन्चालित मिति"; } }
        public string LastLogoffDate { get { return "अन्तिम पटक बन्दगरेको मिति "; } }
        public string UserRoles { get { return "सुम्पिएका कामहरु "; } }

        public string FiscalYear { get { return "आर्थिक वर्ष "; } }
        public string Restore { get { return "तथ्याँक पुनर्लेखन "; } }
        public string Backup { get { return "तथ्याँक संचयन "; } }
        public string MasterEntry { get { return "आधारभुत विवरण "; } }//प्रबिष्टि / सुधार 



        public string Report { get { return "प्रतिवेदन"; } }
        public string Management { get { return "व्यवस्थापन"; } }
        public string System { get { return "प्रणाली"; } }
        public string Remarks { get { return "टिप्पणी / कैफियत"; } }


        public string District { get { return "जिल्ला"; } }
        public string Zone { get { return "अञ्चल"; } }
        public string LocalBody { get { return "गाविस / नगरपालिका"; } }
        public string Address { get { return "ठेगाना"; } }

        public string Phone { get { return "फोन"; } }
        public string Fax { get { return "फ्याक्स"; } }
        public string Email { get { return "इ-मेल"; } }
        public string WebSite { get { return "वेबसाईट"; } }

   
        public string Register { get { return "दर्ता प्रमाणिकरन "; } }
        public string OrganizationName { get { return "कार्यालयको नाम"; } }

        public string Start { get { return "सुरु"; } }
        public string End { get { return "अन्त्य"; } }
        public string Clear { get { return "खाली गर्ने"; } }

        public string InvalidUserName { get { return "प्रयोगकर्त मिलेन "; } }
        public string InvalidPassword { get { return "पहिचन शब्द मिलेन "; } }
        public string PasswordCannotbeEmpty { get { return "पहिचन शब्द खाली हुनु भएन "; } }
        public string UserNameCannotbeEmpty { get { return "सान्केतिक नाम खाली हुनु भएन "; } }

        public string Name { get { return "नाम"; } }


        #region LangInterface Members


        public string Details
        {
            get { return "विवरण"; }
        }

        #endregion
    }
}
