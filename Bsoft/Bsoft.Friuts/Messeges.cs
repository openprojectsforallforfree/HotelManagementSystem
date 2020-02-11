using System;
using System.Collections.Generic;
using System.Text;
using Bsoft.Common.Language;
using Bsoft.Languages;
namespace Friuts
{
    public static class Messeges
    {
        #region Member variables.
        private static string _EMPTY_FIELD_ERR_MSG = Bsoft.Languages.Language.LanguageString.ShouldNotBeEmpty;
        private static string _INVALID_NUMBER_ERR_MSG = Language.LanguageString.CorrectNumber ;
        private static string _INVALID_DATE_ERR_MSG = Language.LanguageString.CorrectDate ;
        private static string _INVALID_FISCAL_YEAR_ERR_MSG = "Invalid fiscal year.";
        private static string _INVALID_CODE_MSG = "Code no doesnot exists. \n Please enter a valid code.";
        private static string _Save_Msg = Language.LanguageString.DoYouWantToSave ;
        private static string _Edit_Msg = Language.LanguageString.DoYouWantToUpdate ;
        private static string _Delete_Msg = Language.LanguageString.DoYouWantToDelete ;
        private static string _Add_More_Record_Msg = Language.LanguageString.DoYouWantToAddMoreRecords ;

        //private static string _EMPTY_FIELD_ERR_MSG = "{0} field can't be left blank.";
        //private static string _INVALID_NUMBER_ERR_MSG = "Enter a valid number in {0}.";
        //private static string _INVALID_DATE_ERR_MSG = "Enter a valid date in {0}.";
        //private static string _INVALID_FISCAL_YEAR_ERR_MSG = "Invalid fiscal year.";
        //private static string _INVALID_CODE_MSG = "Code no doesnot exists. \n Please enter a valid code.";
        //private static string _Save_Msg = "Do you want to save Data";
        //private static string _Edit_Msg = "Do you want to update Data";
        //private static string _Delete_Msg = "Do you want to Delete Data ";
        //private static string _Add_More_Record_Msg = "Do you want to add more records ";
        #endregion

        #region Constructors & Finalizers.
        #endregion

        #region Nested Enums, Structs, and Classes.
        //public enum MessageType
        //{ 
            
        
        //}
        #endregion

        #region Properties

        public static string INVALID_CODE_MSG
        {
            get { return Messeges._INVALID_CODE_MSG; }
            set { Messeges._INVALID_CODE_MSG = value; }
        }

        public static string EMPTY_FIELD_ERR_MSG
        {
            get { return Messeges._EMPTY_FIELD_ERR_MSG; }
            set { Messeges._EMPTY_FIELD_ERR_MSG = value; }
        }


        public static string INVALID_NUMBER_ERR_MSG
        {
            get { return Messeges._INVALID_NUMBER_ERR_MSG; }
            set { Messeges._INVALID_NUMBER_ERR_MSG = value; }
        }


        public static string INVALID_DATE_ERR_MSG
        {
            get { return Messeges._INVALID_DATE_ERR_MSG; }
            set { Messeges._INVALID_DATE_ERR_MSG = value; }
        }


        public static string INVALID_FISCAL_YEAR_ERR_MSG
        {
            get { return Messeges._INVALID_FISCAL_YEAR_ERR_MSG; }
            set { Messeges._INVALID_FISCAL_YEAR_ERR_MSG = value; }
        }

        public static string Save_Msg
        {
            get { return Messeges._Save_Msg; }
            set { Messeges._Save_Msg = value; }
        }

        public static String Edit_Msg
        {
            get { return Messeges._Edit_Msg; }
            set { Messeges._Edit_Msg = value; }
        }

        public static string Delete_Msg
        {
            get { return Messeges._Delete_Msg; }
            set { Messeges._Delete_Msg = value; }
        }

        public static string Add_More_Record_Msg
        {
            get { return Messeges._Add_More_Record_Msg; }
            set { Messeges._Add_More_Record_Msg = value; }
        }
        #endregion

        #region Methods
        public static bool LoadMessage()
        {
            return true;
        }
        #endregion
    }
}
