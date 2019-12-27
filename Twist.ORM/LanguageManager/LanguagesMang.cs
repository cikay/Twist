using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading;




namespace Twist.ORM
{
    public class LanguagesMang
    {
        //public static List<Languages> AvailableLanguages = new List<Languages> {

        //    new Languages { LanguageFullName = "Turkish", LanguageCultureName = "tr-TR" },
        //    new Languages { LanguageFullName = "English", LanguageCultureName = "en" },
            
        //};


        //public static bool IsLanguageAvailable(string lang)
        //{
        //    return AvailableLanguages.Where(a => a.LanguageCultureName.Equals(lang)).FirstOrDefault() != null ? true : false;
        //}

        public static string GetDefaultLanguage()
        {
            return Thread.CurrentThread.CurrentUICulture.Name;
        }

        public static void GetLanguageInfo<T>(string resourePath ) where T: class
        {

        }

        
    }
    
   
}
