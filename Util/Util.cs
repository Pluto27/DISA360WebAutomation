using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using System.Diagnostics;
using System.Drawing;

namespace DISA360Automation.util
{
    class Util
    {
        private IWebDriver driver = null;
        public Util(IWebDriver d)
        {
            driver = d;
        }
        public string captureScreenshot()
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string screenshot = ss.AsBase64EncodedString;
            byte[] screenshotAsByteArray = ss.AsByteArray;
            string screenshotPath = "C:\\" + "Step" + GetTimestamp(DateTime.Now) + ".jpeg";
            ss.SaveAsFile(screenshotPath, OpenQA.Selenium.ScreenshotImageFormat.Jpeg);
            return screenshotPath;
            //Console.WriteLine("Screenshot captured in file " + "E:\\code\\CSharpe\\" + "Step" + GetTimestamp(DateTime.Now) + ".jpeg");
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
    }
}
