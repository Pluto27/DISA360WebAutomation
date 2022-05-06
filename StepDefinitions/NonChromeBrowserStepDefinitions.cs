using DISA360Automation.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace DISA360Automation.StepDefinitions
{
    [Binding]
    public class NonChromeBrowserStepDefinitions
    {
        IWebDriver driver;
        String itemName = "Adding item to the list";
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext _scenarioContext;
        public NonChromeBrowserStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Navigate to App")]
        public void GivenNavigateToApp()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Url = "https://lambdatest.github.io/sample-todo-app/";
        }
        [Given(@"I select the first item")]
        public void GivenISelectTheFirstItem()
        {
            // Click on First Check box
            IWebElement firstCheckBox = driver.FindElement(By.Name("li1"));
            firstCheckBox.Click();
        }

        [Given(@"I select the second item")]
        public void GivenISelectTheSecondItem()
        {
            // Click on Second Check box
            IWebElement secondCheckBox = driver.FindElement(By.Name("li2"));
            secondCheckBox.Click();
        }

        [Given(@"I enter the new value in textbox")]
        public void GivenIEnterTheNewValueInTextbox()
        {
            // Enter Item name
            Thread.Sleep(5000);
            IWebElement textfield = driver.FindElement(By.Id("sampletodotext"));
            textfield.SendKeys(itemName);
        }

        [When(@"I click the submit button")]
        public void WhenIClickTheSubmitButton()
        {
            // Click on Add button
            Thread.Sleep(5000);
            IWebElement addButton = driver.FindElement(By.Id("addbutton"));
            addButton.Click();
        }

        [Then(@"I verify whether the item is addded to the list")]
        public void ThenIVerifyWhetherTheItemIsAdddedToTheList()
        {
            // Verified Added Item name
            IWebElement itemtext = driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[6]/span"));
            String getText = itemtext.Text;

            // Check if the newly added item is present or not using
            // Condition constraint (Boolean)
            Assert.That((itemName.Contains(getText)), Is.True);

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Chrome - Test 1 Passed");
        }

    }
}
