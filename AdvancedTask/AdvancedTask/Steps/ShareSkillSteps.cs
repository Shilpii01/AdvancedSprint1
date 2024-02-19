using AdvancedTask.AssertHelpers;
using AdvancedTask.Pages.Components.ProfileOverview;
using AdvancedTask.Test_Model;
using AdvancedTask.Utilities;

namespace AdvancedTask.Steps
{
    public class ShareSkillSteps:BaseClass
    {
        ProfileTabComponents ProfileTabComponentsObj;
       
        ShareSkillComponent ShareSkillComponentObj;
        ShareSkillAssertion ShareSkillAssertionObj;

        public ShareSkillSteps()
        {
            ProfileTabComponentsObj = new ProfileTabComponents();
            
            ShareSkillComponentObj = new ShareSkillComponent();
            ShareSkillAssertionObj = new ShareSkillAssertion();
        }
        public void AddShareSkill()
        {
            List<ShareSkill> ShareSkillData = JsonReader.ReadTestDataFromJson<ShareSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddShareSkill.json");
            
                ProfileTabComponentsObj.ClickShareSkillButton();

            ShareSkillComponentObj.AddShareSkill(ShareSkillData[0].Title, ShareSkillData[0].Description, ShareSkillData[0].Category, ShareSkillData[0].Subcategory, ShareSkillData[0].Tagone, ShareSkillData[0].Tagtwo,  ShareSkillData[0].EndDate, ShareSkillData[0].StartTime, ShareSkillData[0].EndDate, ShareSkillData[0].Charge);
                    
                ShareSkillAssertionObj.AssertAddedSkillTitle();
            
        }
        public void AddInvalidShareSkill()
        {
            List<ShareSkill> ShareSkillData = JsonReader.ReadTestDataFromJson<ShareSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddInvalidShareSkill.json");
           
                ProfileTabComponentsObj.ClickShareSkillButton();

                ShareSkillComponentObj.AddShareSkillWithoutRequirdFeilds(null, null, ShareSkillData[0].Category, ShareSkillData[0].Subcategory, ShareSkillData[0].Tagone, ShareSkillData[0].Tagtwo,  ShareSkillData[0].EndDate, ShareSkillData[0].StartTime, ShareSkillData[0].EndDate, ShareSkillData[0].Charge);

                ShareSkillAssertionObj.AssertInvalidShareSkill();
            
        }
        public void AddDestructiveShareSkill()
        {
            List<ShareSkill> ShareSkillData = JsonReader.ReadTestDataFromJson<ShareSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddDestructiveShareSkill.json");
            
                ProfileTabComponentsObj.ClickShareSkillButton();

                ShareSkillComponentObj.AddShareSkill(ShareSkillData[0].Title, ShareSkillData[0].Description, ShareSkillData[0].Category, ShareSkillData[0].Subcategory, ShareSkillData[0].Tagone, ShareSkillData[0].Tagtwo,  ShareSkillData[0].EndDate, ShareSkillData[0].StartTime, ShareSkillData[0].EndDate, ShareSkillData[0].Charge);

                ShareSkillAssertionObj.AssertDestructiveSkill();
            //ShareSkillData[0].StartDate,
        }
        public void UpdateShareSkill()
        {

            List<ShareSkill> ShareSkillData = JsonReader.ReadTestDataFromJson<ShareSkill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\UpdateShareSkill.json");
            
                ShareSkillComponentObj.ClickonUpdateShareSkill();

                ShareSkillComponentObj.UpdateShareSkill(ShareSkillData[0].Title, ShareSkillData[0].Description, ShareSkillData[0].Category, ShareSkillData[0].Subcategory, ShareSkillData[0].Tagone, ShareSkillData[0].Tagtwo,  ShareSkillData[0].EndDate, ShareSkillData[0].StartTime, ShareSkillData[0].EndDate, ShareSkillData[0].Charge);
                Thread.Sleep(5000);
               ShareSkillAssertionObj.AssertUpdatedSkillTitle();
            
        }
        public void DeleteShareSkill()
        {
            ShareSkillComponentObj.DeleteShareSkill();
            string Message = ShareSkillComponentObj.GetPopUpMessageText();
            Console.WriteLine(Message);
            ShareSkillAssertionObj.AssertDeletedShareSkill();
        }
    }
}
