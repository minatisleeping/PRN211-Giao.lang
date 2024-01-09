using System;
namespace Bmi
{

    //SINGLETON PATTERN
	public class BmiCalculator
	{
        public static double GetBmi(double weight, double height) => weight / (height * height);
    }
}

