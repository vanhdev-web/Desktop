using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05_31231021860.Modules
{
    public class Department
    {
        private string name;
        public Classs[] classes;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public Department(string name, Classs[] classses)
        {
            this.name = name;
            this.classes = classses;
        }
    }
}
