using AdvancedTask.AssertHelpers;
using AdvancedTask.Pages.Components.ProfileOverview;
using AdvancedTask.Test_Model;
using AdvancedTask.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask.Steps
{
    public class LanguageSteps:BaseClass
    {
        LanguageComponent LanguageComponentObj;
        LanguageMethodComponents LanguageMethodComponentsObj;
        LanguageAssertion LanguageAssertionObj;
        public LanguageSteps()
        {
            LanguageComponentObj = new LanguageComponent();
            LanguageMethodComponentsObj = new LanguageMethodComponents();
            LanguageAssertionObj = new LanguageAssertion();
        }

        public void LanguageStateReset()
        {
            LanguageMethodComponentsObj.ClearExistingLanguages();   

        }
        public void AddLanguageDetails()
        {
            List<Language> AddLanguageData = JsonReader.ReadTestDataFromJson<Language>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddValidLanguage.json");
            
            
                LanguageComponentObj.ClickAddLanguage();

            LanguageMethodComponentsObj.AddNewLanguage(AddLanguageData[0].LanguageName, AddLanguageData[0].LanguageLevel);
                        
                LanguageAssertionObj.AssertAddedLanguage();
            
        }

        public void AddInvalidLanguageDetails()
        {
            List<Language> LanguageData = JsonReader.ReadTestDataFromJson<Language>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddInvalidLang.json");
           
            LanguageComponentObj.ClickAddLanguage();
            LanguageMethodComponentsObj.AddNewLanguageRecordWithoutRequirdFeilds(null, LanguageData[0].LanguageLevel); 

            LanguageAssertionObj.AssertInvalidLanguage();
        }

        public void AddDestructiveLanguageDetails()
        {
            List<Language> LanguageData = JsonReader.ReadTestDataFromJson<Language>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddDestructiveLang.json");
            Thread.Sleep(2000);
            LanguageComponentObj.ClickAddLanguage();
            LanguageMethodComponentsObj.AddNewLanguage(LanguageData[0].LanguageName, LanguageData[0].LanguageLevel);
            Thread.Sleep(2000);
            LanguageAssertionObj.AssertDestructiveLanguage();

        }


        public void UpdateLanguageDetails()
        {
            List<Language> LanguageData = JsonReader.ReadTestDataFromJson<Language>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\UpdatedLanguage.json");
            
                LanguageComponentObj.ClickUpdateLanguage();
            LanguageMethodComponentsObj.UpdateLanguage(LanguageData[0].LanguageName, LanguageData[0].LanguageLevel);
               
                   
              
                LanguageAssertionObj.AssertUpdatedLanguage();
            
        }
        public void DeleteLanguageDetails()
        {
            LanguageMethodComponentsObj.DeleteLanguage();
           
            LanguageAssertionObj.AssertDeletedLanguage();
        }

    }
}
