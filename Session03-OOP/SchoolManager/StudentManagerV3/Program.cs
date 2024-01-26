using StudentManagerV3.Entities;

namespace StudentManagerV3;
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        //the tool offers you multiple ways to create an object
        //there are 3 ways in this case to create an object

        //update an existing object by using setting
        //and show it by using getting
        //via using PROPERTY INSTEAD OF GET() SET()

        s1.Yob = 2002;
        s1.Gpa = 8.6;
        s1.Email = "minat@2002";
        

        Console.WriteLine($"{s1.GetId()} {s1.GetName()} {s1.GetEmail()}");

        //NEW  WAY TO CREATE AN EMPTY OBJECT AND USING
        Student s2 = new Student() { Yob = 2001, Gpa = 6.72, Email = "xp@2k1" };
        //CREATE OBJECT USING PROPERTY INITIATION
        Console.WriteLine($"{s2.GetId()} {s2.GetName()} {s2.GetEmail()}");

        Console.ReadLine();
    }
}

