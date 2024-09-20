using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium
{
    public class SeleniumCustomMethod
    {
        public static void Click(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Click();
        }

        public static void EnterText(IWebDriver driver, By locator, string text)
        {
            driver.FindElement(locator).Clear();
            driver.FindElement(locator).SendKeys(text);
        }

        public static void SelectDropDownByText(IWebDriver driver, By locator, string value)
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(locator));
            selectElement.SelectByText(value);
        }

        public static void MultiSelectElements(IWebDriver driver, By locator, string[] values)
        {
            SelectElement multiSelect = new SelectElement(driver.FindElement(locator));
            foreach (var value in values)
            {
                multiSelect.SelectByValue(value);
            }
        }

        public static List<string> GetAllSelectedLists(IWebDriver driver, By locator)
        {
            List<string> options = new List<string>();
            SelectElement multiSelect = new SelectElement(driver.FindElement(locator));
            IList<IWebElement> selectedOption = multiSelect.AllSelectedOptions;
            foreach (IWebElement option in selectedOption)
            {
                options.Add(option.Text);
            }
            return options;
        }
        
    }
}
