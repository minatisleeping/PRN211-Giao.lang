namespace DelegateReview.LambdaExpressionV2;

delegate void OneInputNoOutputDelegate(int n);


class Program
{
    static void Main(string[] args)
    {
        OneInputNoOutputDelegate f = (int n) =>
        {
            if (n < 1)
            {
                Console.WriteLine("Invalid n. N must be > 0");
                return;
            }

            Console.WriteLine("The list of number from 1.." + n);
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
        }; // lambda v1
        f.Invoke(1000);
        Console.WriteLine("\n");

        f = (n) =>
        {
            if (n < 1)
            {
                Console.WriteLine("Invalid n. N must be > 0");
                return;
            }

            Console.WriteLine("The list of number from 1.." + n);
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
        }; // lambda v2

        f = n =>
        {
            if (n < 1)
            {
                Console.WriteLine("Invalid n. N must be > 0");
                return;
            }

            Console.WriteLine("The list of number from 1.." + n);
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
        }; // lambda v3

        f = minat =>
        {
            if (minat < 1)
            {
                Console.WriteLine("Invalid n. N must be > 0");
                return;
            }

            Console.WriteLine("The list of number from 1.." + minat);
            for (int i = 0; i < minat + 1; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
        }; // lambda v4 - dây nịt, biến đặt tên gì cũng được
        f(50);

        // THÁCH THỨC: IN RA CÁC SỐ CHẴN TỪ 1 .. n
        // k dùng lại biến f


        //OneInputNoOutputDelegate handle = delegate (int n) { }; // anonymous
        //OneInputNoOutputDelegate handle = (int n) => { }; //lambda
        //OneInputNoOutputDelegate handle = (n) => { }; //lambda
        //OneInputNoOutputDelegate handle = n => { }; //

        OneInputNoOutputDelegate handle = x => Console.WriteLine("The input is: " + x);
        handle(15);
        Console.WriteLine("\n");


        //PrintTriple(3);
        //handle = PrintTriple;
        //handle(3);

        handle = delegate (int n)
        {
            Console.WriteLine($"{n}{n}{n}");
        };

        handle = n => Console.WriteLine($"{n}{n}{n}");

        Console.ReadLine();
    }

    static void PrintTriple(int n) => Console.WriteLine($"{n}{n}{n}");
    

    static void PrintNumbers(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("Invalid n. N must be > 0");
            return;
        }

        Console.WriteLine("The list of number from 1.." + n);
        for (int i = 0; i < n + 1; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");
    }
}

