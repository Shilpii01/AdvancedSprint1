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
    public class SkillSteps:BaseClass
    {
        SkillComponent SkillComponentObj;
        SkillMethodComponents SkillMethodComponentsObj;
        SkillAssertion SkillAssertionObj;
        public SkillSteps()
        {

            SkillComponentObj = new SkillComponent();
            SkillMethodComponentsObj = new SkillMethodComponents();
            SkillAssertionObj = new SkillAssertion();
        }

        public void SkillStateReset()
        {
            SkillMethodComponentsObj.ClearExistingSkills();

        }
        public void AddSkillDetails()
        {

            List<Skill> SkillData = JsonReader.ReadTestDataFromJson<Skill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddSkill.json");
            
                
                SkillComponentObj.ClickAddSkill();
                SkillMethodComponentsObj.AddSkill(SkillData[0].SkillName, SkillData[0].SkillLevel);

                Thread.Sleep(2000);
                SkillAssertionObj.AssertAddedSkill();
            
        }
        public void AddInvalidSkillDetails()
        {
            List<Skill> SkillData = JsonReader.ReadTestDataFromJson<Skill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddInvalidSkill.json");

            SkillComponentObj.ClickAddSkill();
            SkillMethodComponentsObj.AddNewSkillRecordWithoutRequirdFeilds(null, SkillData[0].SkillLevel);

            SkillAssertionObj.AssertInvalidSkill();
        }

        public void AddDestructiveSkillDetails()
        {
            List<Skill> SkillData = JsonReader.ReadTestDataFromJson<Skill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\AddDestructiveSkill.json");
            Thread.Sleep(2000);
            SkillComponentObj.ClickAddSkill();
            SkillMethodComponentsObj.AddSkill(SkillData[0].SkillName, SkillData[0].SkillLevel);
            Thread.Sleep(2000);
            SkillAssertionObj.AssertDestructiveSkill();

        }

        public void UpdateSkillDetails()
        {

            List<Skill> SkillData = JsonReader.ReadTestDataFromJson<Skill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\UpdatedSkill.json");
            
                SkillComponentObj.ClickUpdateSkill();
            SkillMethodComponentsObj.UpdateSkill(SkillData[0].SkillName, SkillData[0].SkillLevel);
               //string Message = SkillMethodComponentsObj.GetPopUpMessageText();
                
                SkillAssertionObj.AssertUpdatedSkill();
            
        }
        public void DeleteSkillDetails()
        {
            List<Skill> SkillData = JsonReader.ReadTestDataFromJson<Skill>("A:\\Industry Connect\\AdvancedSprint1\\AdvancedTask\\AdvancedTask\\Json Test Data\\DeleteSkill.json");

            SkillMethodComponentsObj.DeleteSkill(SkillData[0].SkillName, SkillData[0].SkillLevel);
                //string Message = SkillMethodComponentsObj.GetPopUpMessageText();
                //Console.WriteLine(Message);
                SkillAssertionObj.AssertDeletedSkill();
            

        }
    }
}
