using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using DISA360Automation.util;

namespace DISA360WebAutomation.Pages
{
    class SelectCollectionSitePage
    {
        private IWebDriver driver = null;
        private Util util = null;

        public SelectCollectionSitePage(IWebDriver d)
        {
            this.driver = d;
            util = new Util(d);
        }
    }
}
