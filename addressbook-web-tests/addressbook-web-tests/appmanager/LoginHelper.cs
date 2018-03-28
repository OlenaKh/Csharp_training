using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class LoginHelper : HelperBase
    {

        public LoginHelper(ApplicationManager manager) 
            : base(manager)
        {
        }

        public LoginHelper Login(AccountData account)
        {
            TypeValue(By.Name("user"), account.Username);
            TypeValue(By.Name("pass"), account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            return this;
        }
    }
}
