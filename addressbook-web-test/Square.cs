using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_test
{
    internal class square : Figure
    {
        private int size;
        
        public square(int size)
        {
            this.size = size;
        }

        public int Size
        {
            get 
            {
               return size;
            }
            set
            {
                size = value;
            }
        }
               
    }
}
