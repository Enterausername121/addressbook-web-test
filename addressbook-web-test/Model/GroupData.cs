using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_test
{
    public class GroupData 
    {
        public string name;
        public string header = "";
        public string footer = "";

        public GroupData(string name, string header, string footer)
        {
            this.name = name;
            this.header = header;
            this.footer = footer;
        }
        public GroupData(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
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
