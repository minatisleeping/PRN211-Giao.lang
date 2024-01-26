using System;
namespace StudentManagerV2.Entities
{
	public class Student
	{
        private string _id;   
        private string _name; 
        private int _yob;     
        private string _email;
        private double _gpa;

        public Student()
		{
		}

        public Student(string id, string name, int yob, string email, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _email = email;
            _gpa = gpa;
        }

        public void SetId(string id) => _id = id;
        public void SetName(string name) => _name = name;
        public void SetYob(int yob) => _yob = yob;
        public void SetEmail(string email) => _email = email;
        public void SetGpa(double gpa) => _gpa = gpa;

        public void ShowProfile() => Console.WriteLine($"{_id} | {_name} | {_yob} | {_email} | {_gpa} | ");

    }
}

