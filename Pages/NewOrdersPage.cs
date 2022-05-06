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
    class NewOrdersPage
    {
        private IWebDriver driver = null;
        private Util util = null;
        public NewOrdersPage(IWebDriver d)
        {
            this.driver = d;
            util = new Util(d);
        }


		//Locators
		string productDropdownXpath = "//*[@id='ProductID']";
		string usageDropdownXpath = "//*[@id='drUsage']";
		string urgencyDropdownXpath = "//*[@id='drUrgency']";
		string temperatureDropdownXpath = "//*[@id='drTemperature']";
		string quantityValueTextXpath = "//*[@id='numQuantity']/div/div/input";
		string quantityValuedropdownXpath = "//*[@id='txtQuantityUnit']";
		string noOfPackingXpath = "//*[@id='numNoofPacking']/div/div/input";
		string packingXpath = "//*[@id='drPacking']";
		string saveButtonXpath = "//span[contains(text(),'Save')]";
		string countinueButtonXpath = "//span[contains(text(),'Continue with this order')]";


		public bool selectProductOnOrder(String productName){
			driver.Navigate().Refresh();
			
			driver.FindElement(By.XPath(productDropdownXpath)).Click();
			
			driver.FindElement(By.XPath("//div[contains(text(),'"+ productName +"')]")).Click();
			return true;
		}

	public bool selectUsageOnOrder(String usageName){
		driver.FindElement(By.XPath(usageDropdownXpath)).Click();
		
		driver.FindElement(By.XPath("//div[contains(text(),'"+ usageName +"')]")).Click();
		return true;
	}

	public bool selectUrgencyOnOrder(String urgencyName){
		driver.FindElement(By.XPath(urgencyDropdownXpath)).Click();
		
		driver.FindElement(By.XPath("//div[contains(text(),'"+ urgencyName +"')]")).Click();
		return true;
	}

	public bool selectTemperatureOnOrder(String tempName){
		driver.FindElement(By.XPath(temperatureDropdownXpath)).Click();
		
		driver.FindElement(By.XPath("//div[contains(text(),'"+ tempName +"')]")).Click();
		return true;
	}

	public bool enterQauntityOnOrder(String qtyValue){
		driver.FindElement(By.XPath(quantityValueTextXpath)).Click();
		
		driver.FindElement(By.XPath(quantityValueTextXpath)).SendKeys(qtyValue);
		return true;
	}

	public bool selectUnitOnOrder(String unitName){
		driver.FindElement(By.XPath(quantityValuedropdownXpath)).Click();
		
		driver.FindElement(By.XPath("//div[contains(text(),'"+ unitName +"')]")).Click();
		return true;
	}

	public bool enterPackingOnOrder(String packingName)
	{
		driver.FindElement(By.XPath(noOfPackingXpath)).SendKeys(packingName);
		return true;
	}

	public bool selectPackingOnOrder(String packingName)
	{
		driver.FindElement(By.XPath(packingXpath)).Click();
		
		driver.FindElement(By.XPath("//div[contains(text(),'"+ packingName +"')]")).Click();
		return true;
	}

	public bool clickSaveOnOrder()
	{
		
		driver.FindElement(By.XPath(saveButtonXpath)).Click();
		return true;
	}

	public bool clickContinueOnOrder()
	{
		driver.FindElement(By.XPath(countinueButtonXpath)).Click();
		return true;
	}
}
}
