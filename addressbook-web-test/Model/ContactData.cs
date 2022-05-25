using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_test
{
    public class ContactData
    {
        public string firstname;
        public string lastname;
                

        public ContactData(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;           
        }

        public string Firstname
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }

        public string Lastname
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        public ContactData(string firstname)
        {
            this.firstname = firstname;
        }

    }
}




