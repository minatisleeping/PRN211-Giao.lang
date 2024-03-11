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

        public Student(string id, string name, string email, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _email = email;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }

        //để tạo ra constructor default/empty, ta có thể
        //chủ động tạo ra nó bằng cách gõ phím ctor tab

        //public Student()
        //{

        //}
        // có bao nhiêu constructor, thì có bấy nhiêu cách đúc Object!!!







        //constructor full tham số

    }
}

