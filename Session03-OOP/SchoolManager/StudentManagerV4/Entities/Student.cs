using System;
namespace StudentManagerV4.Entities
{
	public class Student
	{
		public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //THE BACKING FIELDS AUTOMATICAL GENERATED IN THE RUNTIME
        //NOT CODING TIME TO KEEP THE SOURCE CODE MORE CLEAN

        //AUTO-IMPLEMENTED PROPERTY

        //JAVA: U HAVE TO USE THIRD PARTY LIB/DEPENDENCY
        //TO GET THE SAME: LOMBOK
    }
}

