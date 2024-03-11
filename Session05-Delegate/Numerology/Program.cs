namespace Numerology
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. In hết dãy số trong NUMBER SERVICE
            //NumberService.PrintNumbers(number => Console.WriteLine(number));

            //2. In các số âm trong kho
            NumberService.PrintNumbers(number =>
            {
                if (number < 0) Console.WriteLine(number);
            });
        }
    }
}


