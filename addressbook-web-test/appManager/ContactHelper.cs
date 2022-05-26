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

        public ContactHelper ContactCreate(ContactData contact)
        {
            GoToNewContactPage();
            FillContactForm(contact);
            SubmitCreateContact();
            //applicationManager.Navigator.GoToHomePage();
            return this;
        }

        public ContactHelper ContactModification(int v, ContactData contact)
        {
            //applicationManager.Navigator.GoToHomePage();
            InitContactModification("1");
            FillContactForm(contact);
            UpdateContactDown();
            //applicationManager.Navigator.GoToHomePage();
            return this;
        }

        public void Delete() 
        {
            //applicationManager.Navigator.GoToHomePage();
            SelectContact("1");
            DeleteContact();
            CloseAlertWindow();
            //applicationManager.Navigator.GoToHomePage();

        }

        


        public ContactHelper FillContactForm(ContactData contact)
        {
            
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("lastname"), contact.Lastname);                      
            return this;
        }

        public void GoToNewContactPage()
        {
            if (driver.Url == baseURL + "edit.php"
                && IsElementPresent(By.XPath("//*[@id='content']/form/input[7]")))
            {
                return;
            }
            driver.FindElement(By.LinkText("add new")).Click();
        }

        public void Type(By locator, string text)
        {
            if (text != null)
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);

            }

        }

        public ContactHelper SubmitCreateContact()
        {
            driver.FindElement(By.XPath("//*[@id='content']/form/input[21]")).Click();
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
