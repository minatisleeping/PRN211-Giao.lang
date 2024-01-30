using System;
namespace StudentManagerV4.Entities
{
    public class Student
    {
        public string Id { get; set; }      //Id, Name, .. is so called PROPERTY
        public string Name { get; set; }    //A PROPERTY GOES ALONG WITH TWO METHODS
        public string Email { get; set; }   //GET() SET(), THINK IT AS VARIABLE ALSO
        public int Yob { get; set; }        //TO GET() ITS VALUE, TO ASSIGN IT A VALUE
        public double Gpa { get; set; }     //.Id = ???;    .Id

        public void ShowAll() => Console.WriteLine("{0} | {1} | {2} | {3} | {4}", Id, Name, Yob, Email, Gpa);

        //Java: @Override
        //C#: override, new
        public override string ToString() => $"{Id} | {Name} | {Yob} | {Email} | {Gpa}";

        //THE BACKING FIELDS AUTOMATICALLY GENERATED IN THE RUNTIME
        //NOT CODING TIME TO KEEP THE SOURCE CODE MORE CLEAN

        //AUTO-IMPLEMENTED PROPERTY

        //JAVA: U HAVE TO USE THIRD PARTY LIB/DEPENDENCY
        //TO GET THE SAME: LOMBOK
    }
}

// Class formula: Step to create a class
// 1. Create a class with a name (Noun, Pascal Case)
// 2. Declare attribute/field/backing fiels with _ convenion
//  profull tab  tab
//  * USING AUTO GENERATED-IMPLEMENTED PROPERTY (DONT NEED TO DECLARE BACKING  FIELDS)
//  prop tab tab
// 3. DECLARE the CONSTRUCTOR BOTH EMPTY CONSTRUCTOR (EXPLICIT - TƯỜNG MINH, CHỦ ĐỘNG) &
//PARAMETER CONSTRUCTOR
//  OR DONT DECLARE ANY CONSTRUCTOR - COMPILER/RUNTIME WILL CREATE A DEFAULT ONE FOR YOU
// 4. CREATEA TOSTRING() METHOD TO SHOW ALL (MOST OF) INFORMATION OF AN OBJECT
//  OR SHOWPROFILE() SHOWALL() METHOD TO CHECK THE INTERNAL STATE OF AN OBJECT
//  *TOString() is A STANDARD NAME YOU SHOULD FOLLOW

//  5. DEFINE THE OTHER METHODS TO PROCESS ANY THING WITHIN AN OBJECT
