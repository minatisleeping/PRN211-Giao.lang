namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
	double bmi = BMICalculator.GetBMI(60, 1.62);
	Console.WriteLine("Your bmi is: " + bmi);

    }
}

