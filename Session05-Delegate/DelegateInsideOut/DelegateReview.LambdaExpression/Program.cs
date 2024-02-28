namespace DelegateReview.LambdaExpression;

delegate void NoInputNoOutput();

class Program
{
    static void Main(string[] args)
    {
        NoInputNoOutput f = delegate ()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of numbers from 1..100: " + sum);
        };
        //f();
        //Console.WriteLine("\n");

        // tính tổng chẵn từ 1..10
        //f = delegate ()
        //{
        //    Console.WriteLine("Sum of even number from 1..10");
        //    int sum = 0;
        //    for (int i = 1; i < 11; i++)
        //    {
        //        if (i % 2 == 0) sum += i;
        //    }
        //    Console.WriteLine("The sum of even numbers from 1..100: " + sum);
        //};
        //f();
        //Console.WriteLine("\n");


        f = () =>
        {
            Console.WriteLine("Sum of even number from 1..10");
            int sum = 0;
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0) sum += i;
            }
            Console.WriteLine("The sum of even numbers from 1..100: " + sum);
        }; // biểu thức lambda: sự rút gọn của hàm ẩn danh, bỏ đi từ khoá
        // DELEGATE , thêm kí hiệu =>
        //Biểu thức lambda là hàm ẩn danh mà đã bị rút gọn chữ DELEGATE
        //Nhưng hàm ẩn danh k chắc là biểu thức lambda nếu vẫn còn chữ DELEGATE
        f();
        Console.WriteLine("\n");




        Console.ReadLine();
    }

    static void Sum()
    {
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        Console.WriteLine("The sum of numbers from 1..100: " + sum);
    }
}

