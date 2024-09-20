using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotNetSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            IWebElement webElement = driver.FindElement(By.Name("q"));
            webElement.SendKeys("Selenium");
            webElement.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void Test2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in/ap/signin?openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.in%2F%3Fref_%3Dnav_custrec_signin&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=inflex&openid.mode=checkid_setup&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0");
            driver.Manage().Window.Maximize();
            SeleniumCustomMethod.Click(driver, By.LinkText("Create your Amazon account"));
            SeleniumCustomMethod.EnterText(driver, By.Name("customerName"), "HelloUser");
            SeleniumCustomMethod.EnterText(driver, By.Name("email"), "9898098985");
            SeleniumCustomMethod.EnterText(driver, By.Name("password"), "HelloPassword");
            IWebElement btnSubmit = driver.FindElement(By.Id("continue"));
            btnSubmit.Click();
            Thread.Sleep(1000);
            driver.Quit();
        }
        [Test]
        public void Test_Dropdown()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.letskodeit.com/practice");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            SeleniumCustomMethod.SelectDropDownByText(driver, By.Id("carselect"), "Benz");
            Thread.Sleep(1000);
            SeleniumCustomMethod.MultiSelectElements(driver, By.Id("multiple-select-example"), ["peach", "orange"]);
            Thread.Sleep(1000);
            var getSelectedOptions = SeleniumCustomMethod.GetAllSelectedLists(driver, By.Id("multiple-select-example"));
            getSelectedOptions.ForEach(Console.WriteLine);
            driver.Quit();
        }
    }
}