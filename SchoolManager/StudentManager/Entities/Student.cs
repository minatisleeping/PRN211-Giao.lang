using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Entities
{
    internal class Student
    {

        public string Id { get; set; }  //property
        public string Name { get; set; } //_name in background
        public string Email { get; set; } //_ in background
        public int Yob { get; set; }     //backing field will be generated/created in background
        public double Gpa { get; set; }

        //no constructor means we are using empty/default constructor
        //and using object ininitializer to create an object with properties are filled in
        //Student s = new Student() {Id = ???, Name = ???};

        public override string ToString() => $"{Id} | {Name} | {Email} | {Yob} | {Gpa}";
        

    }
}
