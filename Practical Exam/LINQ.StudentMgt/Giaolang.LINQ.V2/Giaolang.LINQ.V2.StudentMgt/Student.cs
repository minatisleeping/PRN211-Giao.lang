using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaolang.LINQ.V2.StudentMgt
{
    public class Student
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string? ToString()
        {
            return Id + " | " + Name + " | " + Address + " | " + Yob + " | " + Gpa;
        }
    }
}
