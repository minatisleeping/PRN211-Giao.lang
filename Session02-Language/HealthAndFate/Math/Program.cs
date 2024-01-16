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
        //svm + tab to create a Main()  == in Java(psvm + tab)
        public static void Main(string[] args)
        {
            int sumAll;
            int sumO = 2024;
            //you must initialize a value, a default value
            //for the ref variable before using it
            //because the method doesnot promise to produce a
            //value of reference variable since the assign statement
            //for this ref var is not mandatory
            sumAll = SumOddList(ref sumO);
            //check the sum()
            Console.WriteLine($"Sum odd: {sumO}");
            //1 3 5 7 9 = 25

        }
        //svm tab -> to get the Main() == psvm in JAVA
        //public static void Main(string[] args)
        //{
        //    //CheckTheReadOnlyPara(10);
        //    //Console.WriteLine($"The sum of all: {SumIntegerList()}");

        //    int sumA;
        //    int sumE;
        //    sumA = SumIntegerList(out sumE);
        //    Console.WriteLine($"Sum all: {sumA} | Sum even: {sumE}");
        //}
        //OVERLOAD, OVERLOADING - QUÁ TẢI HÀM

        //OVERLOAD/OVERLOADING VS OVERRIDE/OVERRIDING

        //OVERLOAD CAN OCCUR/HAPPEND IN ANY CLASS WHERE
        //THERE ARE MULTIPLE METHODS USE/SHARE THE SAME NAME
        //BUT DIFFERING IN THE PARAMETERS BY DATA TYPE
        //WE FOCUS ON THE DIFFERENCE OF PARAMETER DATA TYPE
        //WE DON'T CARE ABOUT THE DIFFERENCE OF PARAMETER NAME

        // OVERRIDE: OCCURS ONLY ON INHERITANCE, IN CHILD CLASS
        //WHERE THE CHILD CLASS HAS THE METHOD TITH THE SAME SIGNATURE
        //WITH PARENT (SIGNATURE OF A METHOD: THE NAME + PARAMETERS)
        //100% METHOD NAME IS EQUALS WITH PARENT

        //okie

        public static int SumOddList(ref int sumOdd)
        {
            int sumAll = 0, sumO = 0;

            //for tab twice in quickly
            for (int i = 0; i <= 10; i++)
            {
                sumAll += i; //calculate sumAll
                if (i % 2 != 0) //even number
                    sumO += i;
            }
            //with "ref" keyword, it doesn't reqire to assign
            //the ref variable, it is optional

            sumOdd = sumO; // not mandatory, but you should do this
            //to throw/return the value outside

            return sumAll;
        }

        //USING REF, OUT, WILL MAKE A VARIABLE OUTSIDE CHANGING
        //UPDATE INSIDE A METHOD, A VARIABLE OUTSIDE THE CHANGE
        //THIS IS SO CALL: PASS BY REFERENCE
        //MODIFY SOME WHERE, BUT THE OTHER SOME WHERE IS AFFECTED


        ////wrong
        //void FRight(int n) {} // this method requires an integer
        //void FRight(double a) {} // this method also requires an integer

        //2 + 4 + 6 + 8 + 10 = 30
        //1 + 2 + 3 + ... + 10 = 55
        public static int SumIntegerList(out int sumEven)
        {
            int sumAll = 0, sumE = 0;

            //for tab twice in quickly
            for (int i = 0; i <= 10; i++)
            {
                sumAll += i; //calculate sumAll
                if (i % 2 == 0) //even number
                    sumE += i;
            }

            //if a para has "out" keyword, int the method
            //MUST HAVE A STATEMENT TO ASSIGN THE VALUE FOR THIS PARAM
            //I PROMISE TO SEND OUT A VALUE, SEND A VALUE OUTSIDE
            //A MUST HAVE STATEMENT

            //return sumE;
            sumEven = sumE; //a must have

            return sumAll;
        }

        //work with "ref" and "out" keyword, used on method parameter

        //write method to calculate the sum of an integer list
        //1 + 2 + 3 + 4 + 5 + ... + 10
        // 11 x 5 = 55
        //public static int SumIntegerList()
        //{
        //    int sumAll = 0;

        //    //for tab twice in quickly
        //    for (int i = 0; i <= 10; i++)
        //        sumAll += i;
            
        //    return sumAll;
        //}

        //mantra: static plays with static
        //in means: read only variable
        //TODO AT HOME: static void CheckTheReadOnlyPara(in Student s)
        static void CheckTheReadOnlyPara(in int n)
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

    

