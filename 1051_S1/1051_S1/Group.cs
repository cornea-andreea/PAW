using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1051_S1
{
    class Group
    {
        private int number;
        private string name;
        internal string test;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Name {
            get { return name; }
            set { if (value != "a") name = value; }
        }

        public Group (int nr, string value)
        {
            number = nr;
            name = value;
        }

        public Group()
        {
            this.number = 0;
            this.name = "";
            
        }

        public override string ToString()
        {
            return "Grupul " + this.name + " are numarul " + this.number;
        }

        public string afisare()
        {
            return "Grupul " + this.name + " are numarul " + this.number;
        }
    }
}
