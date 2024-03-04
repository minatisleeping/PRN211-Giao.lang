namespace ActionGenericDelegate
{
    // C#6: Viết hàm nhận vào 1 số nguyên dương, in ra bình phương của nó
    //      Viết hàm lẻ có sẵn ở ngoài kia
    //      Anonymous func, LAMBDA EXPRESSION => Xài DELEGATE ÒI

    // C#7: Viết hàm nhận vào 1 số nguyên dương =>  Xài DELEGATE òi
    //      Dùng ANONYMOUS

    // C#8: Viết hàm nhận vào 1 số nguyên dương, in ra bình phương của nó
    //      Dùng LAMBDA

    // MICROSOFT bảo rằng: hàm mà k trả ra gì cả, gọi là hành động, ACTION
    //Tuy nhiên có loại hành động/hàm có cần đầu vào, 1 đầu, 2 đầu, 3 đầu vào..
    //N đầu vào -> cũng là hành động, cũng là action
    //Tuy thế 1 đầu vào có thể INT, LONG, STUDENT, FLOAT
    //        2 đầu vào có thể là INT|INT, INT|LONG, STRING|STRING, STRING|INT..

    // Hàm nhiều tham số | tham số khác nhau về DATA TYPE, THỨ TỰ DATA TYPE !!!
    // VÔ CHỪNG LOẠI HÀM NHƯ THẾ NÀY ?
    // GENERIC xuất hiện, dù bạn INT, LONG, CHAR, PERSON, STUDENT, bạn là DATA TYPE <T> mà thôi,
    //lúc nào cần dùng, thay <T> bằng DATA TYPE cụ thể

    public delegate void OneInputNoOutputDelegate(int x);

    class Program
    {
        static void Main(string[] args)
        {
            //OneInputNoOutputDelegate f1 = ComputeExponent;
            //Action<int> f2 = ComputeExponent;
            //Console.WriteLine("C#9: using ACTION<> GENERIC on the method with up to 16 params!");
            //f2(1000);

            // C#10: Dùng ACTION<> tính mũ 3 của 1 con số và in ra. Dùng luôn
            //anonymous lambda ex
            //Action<int> f3 = delegate (int x) { };
            //Action<int> f4 = delegate (int xxx) {Console.WriteLine($"{xxx}^3: {Math.Pow(xxx, 3)}");};
            //f4(3);

            // C#11: Viết hàm in ra diện tích hcn - width, length
            //Action<double, double> f7 = (double width, double length) => Console.WriteLine($"Area: ({width}x{length}) = {width * length}");

            //Action<double, double> f8 = (width, length) => { Console.WriteLine($"Area: ({width}x{length}) = {width * length}"); };

            //Action<double, double> f9 = (haiTu, baoTram) => { Console.WriteLine($"Area: ({haiTu}x{baoTram}) = {haiTu * baoTram}"); };

            //Action<double, double> f10 = (haiTu, baoTram) => Console.WriteLine($"Area: ({haiTu}x{baoTram}) = {haiTu * baoTram}");

            //Console.WriteLine("C#11: using ACTION<> GENERIC on the method with up to 16 params - AREA OF RECTANGLE!");
            //f10(5, 11);

            Action<int> printEvens = n =>
            {
                int count = 0;
                if (n < 1) return;
                Console.WriteLine($"The list of even numbers from 1 to {n}..");
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                        if (i == n) Console.Write("\n");
                        count++;
                    }
                }
                Console.Write($"Count: {count}\n");
            };
            Console.WriteLine("C#12 !");
            printEvens(50);
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("C#6: Call method as normal");
        //    ComputeExponent(5);

        //    Console.WriteLine("C#7: Call method using ANONYMOUS FUNC");
        //    OneInputNoOutputDelegate f1 = ComputeExponent; // đc quyền hàm cùng style, bằng tên hàm nào đó
        //    //ngoài kia, hàm có 2 tên, thêm nick

        //    OneInputNoOutputDelegate f2 = delegate (int xxx) {
        //        Console.WriteLine($"{xxx}^2 = {xxx * xxx}");
        //        Console.WriteLine($"{xxx}^2 = {Math.Pow(xxx, 2)}");
        //    };

        //    f2(11);
        //    f2.Invoke(50);
        //}

        static void ComputeRectangleArea(double width, double length) => Console.WriteLine($"Area: ({width}x{length}) = {width * length}");
        
        static void ComputeExponent(int x) => Console.WriteLine($"{x}^2 = {x * x}");
      
        static void ComputeExponentV2(int x)
        {
            double result = Math.Pow(x, 2);
            Console.WriteLine($"{x}^2 = {result}\n");
            Console.WriteLine($"{x}^2 = {x * x}\n");
            Console.WriteLine($"{x}^2 = {Math.Pow(x,2)}\n");
        }


    }
}


