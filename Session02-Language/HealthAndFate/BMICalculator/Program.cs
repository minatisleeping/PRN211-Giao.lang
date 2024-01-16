namespace Bmi; // IN JAVA, NAMESPACE CAN BE CONSIDERED AS PACKAGE
                         // IN JAVA package bmicalculator;

internal class Program  //internal means no one/no outside class 
{                       //(in another namespace) can access this class
                        //to make a class (inside a namespace) available
                        //to be accessed outside, tou have to set this
                        //class as PUBLIC
                        //internal, no internal means: this class is used
                        //by another class but they must be in the same namespace
                        //ENCAPSULATION REGARDING TO NAMESPACE LEVEL
                        //BY DEFAULT, ENCAPSULATION TIGHTS WITH CLASS

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        double bmi = GetBmi(75, 1.75);
        Console.WriteLine("1. Your BMI is: " + bmi);    //CONCATENATE: (ghép chuỗi) by using + operator
        Console.WriteLine("2. Your BMI is: {0}", bmi);  //place holder
        Console.WriteLine("3. Your BMI is: {0} | {1}", bmi, 2024);    // start with 0, 1, 2
        Console.WriteLine($"4. Your BMI is: {bmi}");    //interpolation
                                                        //runtime try to find out where is the variable

        // call a method in another class
        Console.WriteLine($"5. Your BMI is: {BmiCalculator.GetBmi(75, 1.75)}");

        // String, string are the same meaning
        string weightStatus = BmiCalculator.EvaluateHealthStatus(bmi);
        //Console.WriteLine("You are in 70kg an for now, your weight status:\n{0}", weightStatus);
        Console.WriteLine($"You are in 70kg and for now, your weight status:\n{weightStatus}");

        //raw string
        //@ in a leading string will ask the runtime to
        //who the string as it appears in the code
        //what you type is what you see in the end-user screen
        //TECHNIQUE: VERBATIM
        Console.WriteLine(@$"You are in 75kg, 1.75
and for now,
<html>
    <head>

    </...>
        your weight status: {weightStatus}");
    




        Console.WriteLine("Press any key to exit..");
        Console.ReadLine();
    }






    //METHOD HERE
    public static double GetBmi(double weight, double height) => weight / (height * height);
    // for a method that has ONLY ONE STATEMENT
    //we can shorten the method by using  => keyword
    //without return
    //don't make a mistake ths with LAMDA EXPRESSION. BOTH OF THEM SHARE THE SAME SYNTAX
    //BUT IN DEFFERENT CONTEXT

    //=> IN THIS CASE IS SO CALLED: BODY EXPRESSION

    //public static double GetBmi(double weight, double height)
    //{
    //    return weight / (height * height);
    //}
}


