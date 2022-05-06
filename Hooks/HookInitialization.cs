using DISA360Automation.Drivers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DISA360Automation.Hooks
{
    [Binding]
    public sealed class HookInitialization
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly ScenarioContext _scenarioContext;
        public HookInitialization(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping
            SeleniumDriver seleniumDriver = new SeleniumDriver(_scenarioContext);
            _scenarioContext.Set(seleniumDriver, "SeleniumDriver");
            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Selenium webdriver quit");
            _scenarioContext.Get<IWebDriver>("WebDriver").Quit();
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}