using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using DISA360Automation.util;

namespace DISA360Automation.pages
{
	class HomePage
	{

		private IWebDriver driver = null;
		private Util util = null;
		public HomePage(IWebDriver d)
		{
			this.driver = d;
			util = new Util(d);
		}


		//Locators
		string newOrderButtonXpath = "//H4[text()='New Order']";


		public bool clickOnNewOrder(){
		driver.FindElement(By.XPath(newOrderButtonXpath)).Click();
		return true;
		}
	}
}

