using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsoft.Languages
{
    public static class Language
    {
        public static Bsoft.Languages.LangInterface LanguageString = new Bsoft.Languages.LangEnglish();
        public static LanguageChoice _lang;
        public static LanguageChoice currentLanguage
        {
            get { return _lang; }
            set
            {
                _lang = value;
                switch (_lang)
                {
                    case LanguageChoice.Nepali:
                        LanguageString = new Bsoft.Languages.LangNepali();
                        break;
                    case LanguageChoice.Newari:
                        break;
                    case LanguageChoice.English:
                        LanguageString = new Bsoft.Languages.LangEnglish();
                        break;
                    default:
                        break;
                }
            }
        }
    }
    public enum LanguageChoice
    {
        Nepali,
        Newari,
        English
    }
}
