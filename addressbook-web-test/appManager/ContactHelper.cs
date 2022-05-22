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
            applicationManager.Contacts.InitContactModification("1");
            applicationManager.Contacts.FillContactForm(contact);
            applicationManager.Contacts.UpdateContactDown();
            return this;
        }

        public ContactHelper Delete() 
        {
            applicationManager.Contacts.SelectContact("1");
            applicationManager.Contacts.DeleteContact();
            applicationManager.Contacts.CloseAlertWindow();
            return this;
        }


        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("lastname"), contact.Lastname);
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            
            return this;
        }

        public ContactHelper UpdateContactDown()
        {
            driver.FindElement(By.XPath("//*[@id='content']/form[1]/input[1]")).Click();
            return this;
        }

        public ContactHelper SelectContact(string index)
        {
            driver.FindElement(By.XPath("//tr[@name='entry'][" + index + "]//input[@type='checkbox']")).Click();
            return this;
        }

        public ContactHelper InitContactModification(string index)
        {
            driver.FindElement(By.XPath("//tr[@name='entry'][" + index + "]//img[@title='Edit']")).Click();
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
