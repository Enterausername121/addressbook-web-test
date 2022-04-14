using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_test
{
    internal class GroupData
    {
        private string name;
        private string header = "";
        private string footer = "";

        public GroupData(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public  GroupData(string name, string header, string footer) 
        {
            this.name = name;  
            this.header = header;
            this.footer = footer;
        }
        public string Header
        { 
            get { return this.header; }
            set { this.header = value; }
        }

        public string Footer
        {
            get { return this.footer; }
            set { this.footer = value; }
        }
    }
}
