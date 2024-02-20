using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Test_Model
{
    public class Language
    {
        public string LanguageName;
        public string LanguageLevel;

        public String getLanguageName()
        {
            return LanguageName;
        }

        public void setLanguageName(String LanguageName)
        {
            this.LanguageName = LanguageName;
        }

        public String getLanguageLevel()
        {
            return LanguageLevel;
        }

        public void setLanguageLevel(String LanguageLevel)
        {
            this.LanguageLevel = LanguageLevel;
        }
    }
}
