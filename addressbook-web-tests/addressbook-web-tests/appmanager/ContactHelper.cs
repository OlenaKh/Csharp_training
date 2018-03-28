using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) 
            : base(manager)
        {
        }

        public ContactHelper Create(ContactData contact)
        {
            InitNewContactCreation();
            FillContactForm(contact);
            SubmitContactCreation();
            return this;
        }

        public ContactHelper Remove(int id)
        {
            SelectContact(id);
            RemoveContact();
            return this;
        }

        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public ContactHelper SelectContact(int id)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])["+id+"]")).Click();
            return this;
        }

        public ContactHelper Modify(int id, ContactData contactUpd)
        {
            InitContactModification(id);
            FillContactForm(contactUpd);
            SubmitContactModification();
            return this;
        }

        public ContactHelper InitContactModification(int id)
        {
            driver.FindElement(By.XPath("(//img[@alt='Edit'])[" + id + "]")).Click();
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper InitNewContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ContactHelper FillContactForm(ContactData contact)
        {
            TypeValue(By.Name("firstname"), contact.Firstname);
            TypeValue(By.Name("lastname"), contact.Lastname);
            TypeValue(By.Name("middlename"), contact.Middlename);
            TypeValue(By.Name("nickname"), contact.Nickname);
            TypeValue(By.Name("company"), contact.Company);
            TypeValue(By.Name("title"), contact.Title);
            TypeValue(By.Name("address"), contact.Address);
            TypeValue(By.Name("address2"), contact.Address2);
            TypeValue(By.Name("home"), contact.Homephone);
            TypeValue(By.Name("phone2"), contact.Homephone2);
            TypeValue(By.Name("mobile"), contact.Mobilephone);
            TypeValue(By.Name("work"), contact.Workphone);
            TypeValue(By.Name("fax"), contact.Fax);
            TypeValue(By.Name("email"), contact.Email);
            TypeValue(By.Name("email2"), contact.Email2);
            TypeValue(By.Name("email3"), contact.Email3);
            TypeValue(By.Name("homepage"), contact.Homepage);
            SelectValue(By.Name("bday"), contact.Bday);
            SelectValue(By.Name("bmonth"), contact.Bmonth);
            TypeValue(By.Name("byear"), contact.Byear);
            SelectValue(By.Name("aday"), contact.Aday);
            SelectValue(By.Name("amonth"), contact.Amonth);
            TypeValue(By.Name("ayear"), contact.Ayear);
            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
    }
}
