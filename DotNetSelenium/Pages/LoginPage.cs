﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver; 
        }

        IWebElement LoginLink => driver.FindElement(By.LinkText("Create your Amazon account"));
        IWebElement TxtUserName => driver.FindElement(By.Name("customerName"));
        IWebElement TxtEmail => driver.FindElement(By.Name("email"));
        IWebElement TxtPassword => driver.FindElement(By.Name("password"));
        IWebElement BtnSubmit => driver.FindElement(By.Id("continue"));
        
        public void ClickLogin()
        {
            LoginLink.Click();
        }

        public void LoginDetails(string username, string email, string password)
        {
            TxtUserName.EnterText(username);
            TxtEmail.EnterText(email);
            TxtPassword.EnterText(password);
            BtnSubmit.Submit();
        }
    }
}
