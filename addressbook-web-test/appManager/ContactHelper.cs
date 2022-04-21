using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_test
{
    public class ContactHelper : HelperBase
    {

        public ContactHelper(ApplicationManager applicationManager) : base(applicationManager)
        {

        }
        public ContactHelper ContactModification(ContactData contact)
        {
            applicationManager.Contacts.InitContactModification();
            applicationManager.Contacts.FillContactForm(contact);
            applicationManager.Contacts.UpdateContactDown();
            return this;
        }

        public ContactHelper Delete() 
        {
            applicationManager.Contacts.SelectContact();
            applicationManager.Contacts.DeleteContact();
            applicationManager.Contacts.CloseAlertWindow();
            return this;
        }


        public ContactHelper FillContactForm(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            return this;
        }

        public ContactHelper UpdateContactDown()
        {
            driver.FindElement(By.XPath("//*[@id='content']/form[2]/div[2]/input")).Click();
            return this;
        }

        public ContactHelper SelectContact()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div[4]/form[2]/table/tbody/tr[3]/td[1]/input")).Click();
            return this;
        }

        public ContactHelper InitContactModification()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div[4]/form[2]/table/tbody/tr[4]/td[8]/a/img")).Click();
            return this;
        }

        public ContactHelper DeleteContact()
        {
            driver.FindElement(By.XPath("//*[@id='content']/form[2]/div[2]/input")).Click();
            return this;
        }

        public ContactHelper CloseAlertWindow()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }
    }
}
