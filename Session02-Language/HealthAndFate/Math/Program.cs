using Bmi;  //import java.util. ...;

namespace Math
{
    //internal or without internal eman you don't want to show
    //this class outside
    //to public this class for  external used, use public assessor
    //private/public/protected, no-mention - default,  internal
    // -> ACCESSOR, ACCESS MODIFIER, ACCESS SPECIFIER

    public class Program
    {
        //svm tab -> to get the Main() == psvm in JAVA
        public static void Main(string[] args)
        {
            checkTheReadOnlyPara(10);
        }

        //mantra: static plays with static
        //in means: read only variable
        //TODO AT HOME: static void CheckTheReadOnlyPara(in Student s)
        static void checkTheReadOnlyPara(in int n)
        {
            // pass a number to the method, print it, change it
            Console.WriteLine($"Before modification, n is {n}");
            //n = 2024;
            Console.WriteLine($"After changing, n for now is {n}");
            Console.ReadLine();
        }

        


        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //    double bmi = BmiCalculator.GetBmi(80, 1.75);
        //    String healthStatus = BmiCalculator.EvaluateHealthStatus(bmi);
        //    Console.WriteLine("Your health status: {0}", healthStatus);

        //    Console.WriteLine("Press any key to exit!");
            //Console.ReadLine();
        //}
    }
}

    

