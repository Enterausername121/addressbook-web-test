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
    public class GroupHelper : HelperBase
    {        
        public GroupHelper(ApplicationManager applicationManager) : base(applicationManager)
        {
            
        }

        public GroupHelper Modify(int v, GroupData newData)
        {
            applicationManager.Navigator.GoToGroupsPage();
            SelectGroup(1);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            return this;
        }               

        public void Remove()
        {
            applicationManager.Navigator.GoToGroupsPage();
            SelectGroup(1);
            RemoveGroup(1);
            
        }

        public GroupHelper Create(GroupData group) 
        {

            applicationManager.Navigator.GoToGroupsPage();
            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            return this;
        }
        public GroupHelper FillGroupForm(GroupData group)
        {
            
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }
        public void Type(By locator, string text)
        {
            if (text != null)
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);

            }
            
        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.XPath("//*[@id='content']/form/input[2]")).Click();
            return this;
        }
        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.XPath("//*[@id='content']/form/input[1]")).Click();
            return this;
        }
        public GroupHelper RemoveGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[" + index + "]")).Click();
            return this;
        }
        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[4]/input")).Click();
            return this;
        }
        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.XPath("//*[@id='content']/form/input[3]")).Click();
            return this;
        } 

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.XPath("//*[@id='content']/form/input[3]")).Click();
            return this;
        }

    }
}
