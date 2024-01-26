using System;
namespace StudentManagerV3.Entities
{
	public class Student
	{
        private string _id;
        private string _name;
        private string _email;
        private int _yob;
        private double _gpa;

        //we can create an empty constructor by our self
        //explicitly empty construcotr - chủ động tường minh
        //na we can even create multiple constructors
        //there are multiple way to create an object depending
        //on how many info you want to fill in first

        //You visit a registration page
        //name:      _____
        //email:     _____
        //dob:       _____
        //address:   _____
        //phone:     _____
        //zip code:  _____
        //education: _____

        public Student()
        {

        }// ctor + tab

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public Student(string id, string name, string email, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _email = email;
            _yob = yob;
            _gpa = gpa;
        }

        public string GetId() { return _id; }
        public void SetId(string id) => _id = id;

        //public string GetName() { return _name; }
        //public void SetName(string name) => _name = name;

        //public string GetEmail() { return _email; }
        //public void SetEmail(string email) => _email = email;

        //public int GetYob() { return _yob; }
        //public void SetYob(int yob) => _yob = yob;
        public int Yob //Yob: PROPERTY
        {              //     PROPERTY IS NEW FEATURE OF C# TO MAKE OUR PROJECT APPERING
                       //     MORE AND MORE NATURAL LIKE IN  THE REAL LIFE
                       //     IT IS A COMBINATION OF GET/SET METHOD
                       //     IN DEEPER, IT STILL USE BACKING FIELD TO STORE
                       //     THE ACTUAL VALUE/ATTRIBUTE OF AN OBJECT

                       // A "FULL-PROPERTY" TECHNIQUE
            get { return _yob; }
            set { _yob = value; }
        }
        //USAGE: .YOB, CW(S.YOB) -> CALL GETYOB()
        //                       -> TAKE THE VALUE OF YOB, A VARIABLE AS NORMAL
        //             .YOB = 2003 -> LIKE SET()
        //                      ASSIGN A NEW VALUE FOR YOB

        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        // u can use get or set in a separately way
        //or both ofthem

        //if you forget the format to write Get() Set()
        //type fullprop tab tab




    }
}

