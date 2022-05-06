using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using DISA360Automation.util;

namespace DISA360Automation.pages
{
    class LoginPage
    {
        private IWebDriver driver = null;
        private Util util = null;

        public LoginPage(IWebDriver d)
        {
            this.driver = d;
            util = new Util(d);
        }

        //Locators
        string userNameXpath = "//*[@Name='UserName']";
        string passwordXpath = "//*[@Name='Password']";
        string loginButtonXpath = "//*[contains(text(),'Login')]";


        public bool loginUser(string username, string password)
        {
            driver.FindElement(By.XPath(userNameXpath)).SendKeys(username);
            driver.FindElement(By.XPath(passwordXpath)).SendKeys(password);
            driver.FindElement(By.XPath(loginButtonXpath)).Click();
            return true;
        }
    }
}
