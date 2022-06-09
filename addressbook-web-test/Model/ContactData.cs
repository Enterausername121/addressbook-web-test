using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_test
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        public string firstname;
        public string lastname;

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            if (Lastname == other.Lastname)
            {
                return Firstname == other.Firstname;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Lastname.GetHashCode() + Firstname.GetHashCode();
        }

        public override string ToString()
        {
            return "lastname=" + Lastname + "/n" + "firstname=" + Firstname;
        }
        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            if (Firstname.CompareTo(other.Firstname) == 0)
            {
                return Lastname.CompareTo(other.Lastname);
            }

            else
            {
                return Lastname.CompareTo(other.Lastname);
            }
            
        }

       

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




