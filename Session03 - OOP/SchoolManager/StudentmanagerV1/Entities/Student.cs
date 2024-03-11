using System;

//in Java: com.mycompany.my project.mymodule
//		   com.microsoft.sqlserver.jdbc
namespace StudentmanagerV1.Entities
{
	internal class Student
	{
		//inside a class is attributes and behaviours of objects that belong to this class
		// Class likes a mold, a template, a form that need to be filled to get a copy/an object
		private string _id;   // _______ like a place holder of a form
        private string _name; // _______ like a place holder of a form 
        private int _yob;     // _______ place holder
        private string _email;
        private double _gpa;  // _ for  naming convention of attributes;;

        public Student(string id, string name, int yob, string email, double gpa)
        {
            _id = id;       // no need to add "this." before param e.g: this._id
            _name = name;
            _yob = yob;
            _email = email;
            _gpa = gpa;
        }
        //we have mold, next we need a funnel -  PHỄU
        //to take the ouside meterial to fill-in inside the mold
        //to get the object at the final
        // THE FUNNEL HELPS US TO CREATE/CONSTRUCT AN OBJECT/BỨC TƯỢNG
        //THE FUNNEL IS SO CALL CONSTRUCTOR - A METHOD TO RECEIVE THE
        //PARAMETERS TO FILL IN

        //IN A MOLD.CLASS.OBJECT, THE ATTRIBUTE IS SET A PRIVATE
        //NO ONE OUTSIDE CAN SEE IT
        //I MEET YOU I KNOW THAT YOU HAVE A NAME (PRIVATE)
        //AND WE EXCAHNGE, WE COMMUNICATE, I ASK YOU ABOUT YOUR NAME
        //AND YOU TELL ME THE NAME
        //RETURN YOUR NAME TO ME!!!
        //THAT ACTION IS SO CALL GET(): I TELL YOU SOMETHING INSIDE ME

        public string GetName()
        {
            return _name;
        }   //traditional method

        public int GetYob() => _yob;    //expression body

        public double GetGpa() => _gpa;    //expression body

        public string GetId() => _id;    //expression body

        public string GetEmail() => _email;    //expression body

        //sometimes we will show full of/most of out internal profile
        //like your profile section in FB
        //this Get() is so called ToString()
        //show many information in a long sentense

        public void ShowProfile()
        {
            Console.WriteLine(@$"Here is my profile:
Id: {_id}
Name: {_name}
Yob: {_yob}
Gpa: {_gpa}
Email: {_email}");
            Console.ReadLine();
        }











    }
}

