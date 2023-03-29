using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Угрюмова_ЛИНК
{
    class Employ
    {
        string name;
        string department;
        public Employ(string name, string department)
        {
            this.name = name;
            this.department = department;
        }
        public string Name { get =>name; set=>name = value; }
        public string Department { get =>department; set =>department = value; }
    }
}
