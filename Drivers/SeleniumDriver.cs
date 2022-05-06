using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISA360Automation.Drivers
{
    public class SeleniumDriver
    {
        private IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

        public SeleniumDriver(ScenarioContext scenarioContext) {
            _scenarioContext = scenarioContext;
        }

        public IWebDriver Setup() {
            //Hardcoded ChromeOption
            var chromeOptions = new ChromeOptions();
            driver = new RemoteWebDriver(new Uri("http://localhost:9515"),chromeOptions.ToCapabilities());
            _scenarioContext.Set(driver, "WebDriver");
            driver.Manage().Window.Maximize();
            return driver;

        }
    }
}
