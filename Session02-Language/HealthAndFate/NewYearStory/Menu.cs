using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearStory
{
    public class Menu
    {
        public void ListMenu(ref int choice)
        {
            int choiceMenu = 0;
            while (true)
            {
                Console.WriteLine("--------------------MENU---------------------");
                Console.WriteLine("1. Compute the BMI indicator");
                Console.WriteLine("2. Get the zodiac sign in (VI, EN, FR, JP....)");
                Console.WriteLine("3. Quit");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Input your choice: ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out choiceMenu))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.\n");
                }
            }
            choice = choiceMenu;
        }
    }
}
//1.Conpute the BMI indicator
//2. get the zodiac sign in (VI, EN, FR, JP....)
//3 quit
// input your choice: