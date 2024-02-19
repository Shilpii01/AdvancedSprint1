using AdvancedTask.AssertHelpers;
using AdvancedTask.Pages.Components.ProfileOverview;
using AdvancedTask.Test_Model;
using AdvancedTask.Utilities;

namespace AdvancedTask.Steps
{
    public class SearchSkillSteps:BaseClass
    {
        SearchSkillComponent SearchSkillComponentObj;
        SearchSkillAssertion SearchSkillAssertionObj;
        ProfileTabComponents ProfileTabComponentsObj;

        public SearchSkillSteps()
        {
            ProfileTabComponentsObj = new ProfileTabComponents();
            SearchSkillComponentObj = new SearchSkillComponent();
            SearchSkillAssertionObj = new SearchSkillAssertion();
        }

        public void SearchBySkill()
        {
            List<SearchSkill> SearchSkillData = JsonReader.ReadTestDataFromJson<SearchSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\SearchSkill.json");
           // ProfileTabComponentsObj.ClickSearchSkillIcon();
            SearchSkillComponentObj.SkillToBeSearched(SearchSkillData[0].Skill);
            Thread.Sleep(2000);
            SearchSkillAssertionObj.SearchSkillAssert();
            
        }
        public void SearchByInvalidSkill()
        {
            List<SearchSkill> SearchSkillData = JsonReader.ReadTestDataFromJson<SearchSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\SearchSkillByInvalidData.json");
            //ProfileTabComponentsObj.ClickSearchSkillIcon();
            SearchSkillComponentObj.SkillToBeSearched(SearchSkillData[0].Skill);
            Thread.Sleep(2000);
            SearchSkillAssertionObj.SearchInvalidSkillAssert();
            
        }


        public void SearchByUserName()
        {
            List<SearchSkill> SearchSkillData = JsonReader.ReadTestDataFromJson<SearchSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\SearchSkillByUsername.json");
            
                ProfileTabComponentsObj.ClickSearchSkillIcon();
                SearchSkillComponentObj.SearchUser(SearchSkillData[0].Username);
            Thread.Sleep(2000);
            SearchSkillAssertionObj.SearchUserNameAssert();
            
        }
        public void SearchByCategoryclicked()
        {
            List<SearchSkill> SearchSkillData = JsonReader.ReadTestDataFromJson<SearchSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\SearchSkillByCategoryData.json");
            
            ProfileTabComponentsObj.ClickSearchSkillIcon();
            SearchSkillComponentObj.SearchByCategory(SearchSkillData[0].Category, SearchSkillData[0].Subcategory);
            Thread.Sleep(2000);
            SearchSkillAssertionObj.SearchCategoryAssert();
            
        }
        public void SearchByFilterclicked()
        {
            List<SearchSkill> SearchSkillData = JsonReader.ReadTestDataFromJson<SearchSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\SearchSkillByFilterData.json");
            
               ProfileTabComponentsObj.ClickSearchSkillIcon();
                SearchSkillComponentObj.SearchByFilter(SearchSkillData[0].FilterOption);
            Thread.Sleep(2000);
            SearchSkillAssertionObj.SearchFilterAssert();
            
        }
    }
}
