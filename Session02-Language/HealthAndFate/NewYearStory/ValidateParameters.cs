using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearStory
{
    public class ValidateParameters
    {
        public Boolean CheckBMI(double height, double weight)
        {
            if (height > 3 || height < 0.5 || weight < 15 || weight > 400)
            {
                return false;
            }
            return true;
        }

        public Boolean CheckDayAndMonth(int day, int month)
        {
            Boolean check = false;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day > 0 && day < 32) return check = true;
                    return check;
                case 2:
                    if (day > 0 && day < 29) return check = true;
                    return check;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 0 && day < 31) return check = true;
                    return check;
                default:
                    Console.WriteLine($"The {month}th month does not exist in the year ");
                    break;
            }
            return check;
        }
    }
}
