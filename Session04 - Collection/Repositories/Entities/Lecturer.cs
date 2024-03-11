using System;
namespace Repositories.Entities
{
	public class Lecturer
	{
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int Yob { get; set; }

        public double Salary { get; set; }

        public override string ToString() => $"Lecturer: {Id} | {Name} | {Salary}";
    }
}

