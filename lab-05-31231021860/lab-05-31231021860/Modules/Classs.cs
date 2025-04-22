using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05_31231021860.Modules
{
    public class Classs
    {
        private string name;
        public Student[] students;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Classs(string name, Student[] students)
        {
            this.name = name;
            this.students = students;
        }
    }
}
