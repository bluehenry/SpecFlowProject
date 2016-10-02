using TechTalk.SpecFlow;

namespace GameCore.Specs
{
    [Binding]
    public class Hooks : Steps
    {
        [BeforeScenario]
        //[BeforeScenario("elf")]
        public void BeforeScenario()
        {
            //ScenarioContext.ScenarioInfo: Tags, Title
        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}
