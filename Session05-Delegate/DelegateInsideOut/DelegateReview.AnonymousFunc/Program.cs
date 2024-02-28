namespace DelegateReview.AnonymousFunc;

// viết hàm in ra các sớ tự nhiên từ 1..100
// dùng delegate

delegate void NoInputNoOutput(); //void F()

class Program
{
    static void Main(string[] args)
    {
        NoInputNoOutput f = PrintNumber;
        f();


        f = delegate ()
        {
            Console.WriteLine("The list of numbers from 1..100");

            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
                //Console.Write("{0} ", i);
                //Console.Write($"{i}");
            }
        };


        Console.WriteLine("Anonymous function");
        f();
        Console.WriteLine("\n");

        //THÁCH THỨC: VIẾT VÀ IN RA CÁC SÔ CHẴN
        f = delegate ()
        {
            Console.WriteLine("The list even number from 1..100");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }
        };
        f();
        Console.WriteLine("\n");
        // in ra số lẻ từ 1..100

        f = delegate ()
        {
            Console.WriteLine("The list odd number from 1..100");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0) Console.Write(i + " ");
            }
        };
        f();
        Console.WriteLine("\n");


        Console.ReadLine();
    }

    static void PrintEvenNumbers()
    {
        Console.WriteLine("The list even number from 1..100");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0) Console.Write(i + " ");
        }
    }

    static void PrintNumber()
    {
        Console.WriteLine("The list of numbers from 1..100");

        for (int i = 1; i <= 100; i++)
        {
            Console.Write(i + " ");
            //Console.WriteLine("{0} ", i);
            //Console.WriteLine($"{i}");
        }
        Console.WriteLine(); // in xong nguyên con thì xuống hàng
    }
}

