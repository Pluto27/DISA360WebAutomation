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
    class DISA360BasePage
    {
        public IWebDriver driver = null;
        public Util util = null;


		public DISA360BasePage(IWebDriver d)
		{
			this.driver = d;
			util = new Util(d);
		}
		public void startBrowser(string url)
		{
			driver.Navigate().GoToUrl(url);
			driver.Manage().Window.Maximize();
		}

		public void cleanup()
		{
			driver.Quit();
		}
	}
}
