using System;
namespace StudentManager.Entities
{
	public class Student
	{
        public string Id { get; set; }      
        public string Name { get; set; }    
        public string Email { get; set; }   
        public int Yob { get; set; }        
        public double Gpa { get; set; }

        //no constructor means we are using empty/default constructor
        //and using object initializer to create an object with the properties are filled in
        //Student s = new Student() { Id = ??, Name = ?? };

    }
}

