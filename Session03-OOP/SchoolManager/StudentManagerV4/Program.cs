using StudentManagerV4.Entities;
//import student.entities.*; in Java

namespace StudentManagerV4;
class Program
{
    static void Main(string[] args)
    {
        CreateAnObjectV3UsingAnonymousType();
        Console.ReadLine();
    }

    //Assume that te Student table has 10 columns
    //Student(Id | LastName | FirstName | Dob | Email | Province | Address | MajorId | Gpa | Status ...)
    //SQL statements
    //SELECT * FROM STUDENT ==> TAKE AL COLUMNS, ALL ROWS
    //SELECT * FROM STUDENT WHERE <CONDITION TO FILTER ROWS> => TAKE ALL COLUIMNS, SOME ROWS

    //SELECT Id, LastName, FirstName, Dob, Email FROM STUDENT
    //A PROJECTION QUERY - PHÉP CHIẾU, DÙNG ỐNG NHÒM ĐỂ NHÌN 1 KHU  VỰC
    //                   - USE SCOPE TO SEE A NARROW AREA

    // A WEB PAGE TO SHOW A LIST OF STUDENTS WITH MOST POPULAR COULMNS LIKE ID | NAME | EMAIL.
    //THERE IS A BUTTON NEXT EACH STUDENT TO ASK USER TO CLICK TO OPEN A FULL DETAILED SCREEN WITH TEN COLUMNS

    static void CreateAnObjectV3UsingAnonymousType()
    {
        Student s1 = new Student() { Id = "SE113", Name = "An Nguyễn", Email = "ann@@fpt.edu.vn", Gpa = 8.6, Yob = 2003 };
        Student s2 = new () { Id = "SE113", Name = "An Nguyễn", Email = "ann@@fpt.edu.vn", Gpa = 8.6, Yob = 2003 };
        var s3 = new Student() { Id = "SE113", Name = "An Nguyễn", Email = "ann@@fpt.edu.vn", Gpa = 8.6, Yob = 2003 };

        //CREATE A NEW OBJECT BUT USING A  LITTLE PROPERTY
        //A FLEXIBLE WAY TO CREATE A SMALL OBJECT FROM A BIG ONE
        var newObj = new {Code = "DRK001", Name = "BONCHA", Price = 10_000 }; //_ in a number to separate the 000 000 thousand part

        Console.WriteLine(newObj); //gọi thầm tên em - call ToString() implicitly
        //a ToString() is automatically created for you  to use
        Console.WriteLine($"{newObj.Code} | {newObj.Name} | {newObj.Price}");

        Console.WriteLine("Make a projection selet on the student object");
        var smallObj = new { s1.Id, s1.Name }; //take a part of existing object s1
        Console.WriteLine(smallObj); //ToString() implicitly

        //  var smallObj1 = new { s1.Id, s1.Name };

        //               { Id = "SE1", Name = "An Nguyễn" }
    }

    static void CreateAnObjectV2()
    {
        Student s = new Student() {Id = "SE113", Name = "An Nguyễn", Email = "ann@@fpt.edu.vn", Gpa = 8.6, Yob = 2003};
        //s.ShowAll();
        //create an object and assign the properties at them same time
        //KEYWORD: OBJECT INITIALIZER
        Console.WriteLine(s.ToString()); //pro guy never calls ToString() explicitly
        // pro guy just calls the object variable and the ToString() will be called impicitly - gọi thầm tên em ToString()
        Console.WriteLine("Call ToString() implicitly");
        Console.WriteLine(s);
    }

    static void CreateAnObjectV1()
    {   //we create an object using the traditional way
        //using empty constructor, and set the propetry later
        //in a seperately statement
        Student s = new Student();
        Console.WriteLine("Check the default value of an empty/default object");
        s.ShowAll();
        Console.WriteLine(s.ToString());

        //we will use Set() method via Usig Property
        s.Id = "SE1";
        s.Name = "An Nguyễn";
        s.Yob = 2003;
        s.Email = "ann@fpt.edu.vn";
        s.Gpa = 8.6;

        Console.WriteLine("Check the object after settings");
        s.ShowAll();
        Console.WriteLine(s.ToString());
    }
    

}

