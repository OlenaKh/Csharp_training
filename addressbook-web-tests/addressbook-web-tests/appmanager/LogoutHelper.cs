using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class LogoutHelper : HelperBase
    {
        public LogoutHelper(ApplicationManager manager) 
            : base(manager)
        {
        }

        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

    }
}
