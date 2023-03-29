using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Угрюмова_ЛИНК
{
    public class Department
    {
        string name;
        string reg;
        public Department(string name, string reg)
        {
            this.name = name;
            this.reg = reg;
        }
        public string Name { get => name; set=>name= value; }
        public string Reg { get => reg; set=>reg = value; }
    }
}
