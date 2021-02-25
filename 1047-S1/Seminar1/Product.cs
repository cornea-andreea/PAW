using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    class Product
    {
        string name;
        int number;

        public string Name
        {
            get { return name; }
            set {
                if (value != "coffee") name = value;
            }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
