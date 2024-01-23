using Zodiac;

namespace NewYearStory;
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Methods method = new Methods();
        int choice = 0;
        do
        {
            menu.ListMenu(ref choice);
            switch (choice)
            {
                case 1:
                    method.ComputeBMI();
                    break;
                case 2:
                    method.FindZodiac();
                    break;
                case 3:
                    Console.WriteLine("Have a good day guys!!!");
                    return;
                default:
                    Console.WriteLine("Comming soon.....");
                    break;
            }
        } while (choice != 3);

        //Console.ReadLine();
    }
}


//ASSIGNMENT #2:
// DO NOT NEED TO CREATE A NEW SOLUTION/PROJECT
//JUST UPDATE THIS CLASS TO DO THE FOLLOWING FEATURE FOR 
//NEWYEARSTORY APP
//WHEN RUNNING THIS APP, IT SHOWS A MENU
//1. Compute the BMI indicator
//2. Get the Zodiac sign in (VI, EN, FR, JP..)
//3. Quit
//Input your choice (1..3):
//if user choose 1, the  app will ask  to input weight, height
//and print the weight status
//if user choose 2, the app will ask to input day, month
//and print out the Zodiac in VI, EN..
//3 to quit app

//TAKE YOUR TIME TO DO THE VALIDATION IN INPUT VALUE
//LIKE: MONTH MUST BE IN BETWEEN 1..12
//    : WEIGHT MUST BE IN BETWEEN 18..
//TRY WITH THE VALIDATION YOU THINK THAT IT IS IMPORTANT
//30 FEBRUARY AHIHIHI


//CLEAN THE SOLUTION, COMPRESS IT UNDER .ZIP .RAR
//DEADLINE: TUESDAY 23/1 9:30

//hint: USE DO-WHILE: TO MAKE A MENU
/*
 * do {
 *      print menu
 *      
 *      switch(choice) {
            case 1:
                //call the mothod from library or project
                //break;
            ...
        }
 * } while (exit gate - choice != 3);
 * 
 * hot to get the input from keyboard
 * Console.ReadLine() -> string -> convert to number
 * 
 * int.
 * double.              ~Integer.ParseInt()
*/

