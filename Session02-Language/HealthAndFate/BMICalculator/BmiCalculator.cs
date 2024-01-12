using System;
namespace Bmi
{

    //SINGLETON PATTERN
	public class BmiCalculator
	{
        public static double GetBmi(double weight, double height) => weight / (height * height);

        public static string EvaluateHealthStatus(double bmi)
        {
            //quick way to evaluate your weight depends on height
            //1.73(m) = 173 - 100 = 73(kg) => 73 is perject!
            if (bmi < 18.5)
                return "Underweight!";
            // bmi at  this place may be >= 18.5
            if (bmi < 25)
                return "You are perfect on in body shape!";
            //bmi >= 25
            if (bmi < 30)
                return "Overweight!";   
            return "Obese!!!";  // bí phèo
        }
    }
}

