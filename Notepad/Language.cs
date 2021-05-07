using System.Collections.Generic;

namespace Notepad
{
    public enum Lang { EN, GE };
    class Language
    {
        public static Dictionary<Lang, Dictionary<string, string>> Locale { get; set; } = new Dictionary<Lang, Dictionary<string, string>>
        {
            {Lang.EN, new Dictionary<string, string>() },
            {Lang.GE, new Dictionary<string, string>() }
        };
        static Language()
        {
            var lang = Lang.EN;
            #region EN
            Locale[lang].Add("fileMI", "File");
            Locale[lang].Add("editMI", "Edit");
            Locale[lang].Add("viewMI", "View");
            Locale[lang].Add("toolsMI", "Tools");
            Locale[lang].Add("languageMI", "Language");
            Locale[lang].Add("aboutMI", "About");
            #endregion

            lang = Lang.GE;
            #region GE
            Locale[lang].Add("fileMI", "ფაილი");
            Locale[lang].Add("editMI", "რედაქტირება");
            Locale[lang].Add("viewMI", "ხედვა");
            Locale[lang].Add("toolsMI", "ინსტრუმენტები");
            Locale[lang].Add("languageMI", "ენა");
            Locale[lang].Add("aboutMI", "შესახებ");
            #endregion
        }
    }
}