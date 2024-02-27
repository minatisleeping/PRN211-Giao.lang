using System;
namespace Repositories.Entities
{
	public class Student
	{
		public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int Yob { get; set; }

        public double Gpa { get; set; }

        public override string ToString() => $"Student: {Id} | {Name} | {Gpa}";
    }
}

