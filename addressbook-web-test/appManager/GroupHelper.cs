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

        internal void Remove()
        {
            applicationManager.Navigator.GoToGroupsPage();
            SelectGroup();
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
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            return this;
        }
        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }
        public GroupHelper RemoveGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[" + index + "]")).Click();
            return this;
        }
        public GroupHelper SelectGroup()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[4]/input")).Click();
            return this;
        }
    }
}
