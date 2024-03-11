using Bmi;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zodiac;

namespace NewYearStory
{
    public class Methods
    {
        public void ComputeBMI()
        {
            ValidateParameters validation = new ValidateParameters();
            Boolean check = false;
            double height = 0;
            double weight = 0;

            do
            {
                Console.Write("\nPlease.. input your height (meter/m): ");
                height = double.Parse(Console.ReadLine());
                Console.Write("\nPlease.. input your weight (kilogram/kg): ");
                weight = double.Parse(Console.ReadLine());
                check = validation.CheckBMI(height, weight);
                if (!check)
                {
                    Console.WriteLine("It's impossible");
                    Console.WriteLine("\nPlease input againt!!!");
                }
            } while (!check);
            double resultBMI = BmiCalculator.GetBmi(weight, height);
            Console.WriteLine($"Your BMI is: {resultBMI}");
            Console.WriteLine($"Your BMI belongs to the {BmiCalculator.EvaluateHealthStatus(resultBMI)} level \n\n");

        }

        public void FindZodiac()
        {
            ValidateParameters validation = new ValidateParameters();
            Boolean check = false;
            int day = 0;
            int month = 0;
            do
            {
                Console.Write("\nPlease.. input your day: ");
                day = int.Parse(Console.ReadLine());
                Console.Write("\nPlease.. input your month: ");
                month = int.Parse(Console.ReadLine());
                check = validation.CheckDayAndMonth(day, month);
                if (!check)
                {
                    Console.WriteLine($"The {day}th day in the {month}th month does not exist in the year");
                    Console.WriteLine("\nPlease input againt!!!");
                }
            } while (!check);
            string resultZodiacByEnglish = ZodiacCalculator.GetZodiacSign(month, day);
            string resultZodiacByVietnamese = ZodiacCalculator.GetZodiacVietnamese(resultZodiacByEnglish);
            Console.WriteLine($"Your zodiac by English is {resultZodiacByEnglish} and by Vietnamese is {resultZodiacByVietnamese}\n\n");

        }
    }
}
