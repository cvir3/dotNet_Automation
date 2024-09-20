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
    public static class SeleniumCustomMethod
    {
        public static void ClickLink(IWebElement locator)
        {
            locator.Click();
        }
        public static void Submit(this IWebElement locator)
        {
            locator.Submit();
        }

        public static void EnterText(this IWebElement locator, string text)
        {
            locator.Clear();
            locator.SendKeys(text);
        }

        public static void SelectDropDownByText(this IWebElement locator, string value)
        {
            SelectElement selectElement = new SelectElement(locator);
            selectElement.SelectByText(value);
        }

        public static void MultiSelectElements(IWebElement locator, string[] values)
        {
            SelectElement multiSelect = new SelectElement(locator);
            foreach (var value in values)
            {
                multiSelect.SelectByValue(value);
            }
        }

        public static List<string> GetAllSelectedLists(IWebElement locator)
        {
            List<string> options = new List<string>();
            SelectElement multiSelect = new SelectElement(locator);
            IList<IWebElement> selectedOption = multiSelect.AllSelectedOptions;
            foreach (IWebElement option in selectedOption)
            {
                options.Add(option.Text);
            }
            return options;
        }
        
    }
}
