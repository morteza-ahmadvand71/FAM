using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Automation
{
    public class Language
    {
        public static bool SetFarsiLanguage()
        {
            bool bolResultLoc = false;

            InputLanguageCollection ilcLanguages = InputLanguage.InstalledInputLanguages;
            foreach (InputLanguage ilLanguage in ilcLanguages)
            {
                if (ilLanguage.Culture.Name == "fa-IR")
                {
                    InputLanguage.CurrentInputLanguage = ilLanguage;
                    bolResultLoc = true;
                }
            }

            return bolResultLoc;
        }

        public static bool SetEnglishLanguage()
        {
            bool bolResultLoc = false;

            InputLanguageCollection ilcLanguages = InputLanguage.InstalledInputLanguages;
            foreach (InputLanguage ilLanguage in ilcLanguages)
            {
                if (ilLanguage.Culture.Name == "en-US")
                {
                    InputLanguage.CurrentInputLanguage = ilLanguage;
                    bolResultLoc = true;
                }
            }

            return bolResultLoc;
        }
        public static string GetEnglishText(string strNumberArg)
        {
            strNumberArg = strNumberArg.Trim();

            strNumberArg = strNumberArg.Replace('۰', '0');
            strNumberArg = strNumberArg.Replace('۱', '1');
            strNumberArg = strNumberArg.Replace('۲', '2');
            strNumberArg = strNumberArg.Replace('۳', '3');
            strNumberArg = strNumberArg.Replace('۴', '4');
            strNumberArg = strNumberArg.Replace('۵', '5');
            strNumberArg = strNumberArg.Replace('۶', '6');
            strNumberArg = strNumberArg.Replace('۷', '7');
            strNumberArg = strNumberArg.Replace('۸', '8');
            strNumberArg = strNumberArg.Replace('۹', '9');
            strNumberArg = strNumberArg.Replace('/', '.');

            return strNumberArg;
        }      
    }
}
