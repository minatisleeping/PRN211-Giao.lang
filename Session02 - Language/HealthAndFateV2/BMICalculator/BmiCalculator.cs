using System;
namespace Bmi
{
	public class BmiCalculator
	{
        public static double GetBmi(double weihgt, double height) => weihgt / (height * height);
    }
}

