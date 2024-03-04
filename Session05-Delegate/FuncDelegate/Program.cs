namespace FuncDelegate
{

    // C#13: Viết hàm nhận vào 1 con số, sau đó trả về bình phương của nó
    //có return, k in ra trong hàm

    //MS lại bảo rằng, nếu hàm có trả về giá trị, int, long, char, Student, Car, Pet..
    //và hàm có thể có đầu vào hay k, kệ, thì hãy xài 1 DELEGATE style GENERIC
    //Tên là func
    //Func<int> -> hàm k đầu vào, trả về int
    //Func<long> -> hàm k đầu vào, trả về long
    //Func<string> -> hàm k đầu vào, trả về string
    //Func<Dog> -> hàm k đầu vào, trả về Dog
    //Func<int, int> -> hàm có đầu vào int, trả về int
    //Func<double, double, double> -> hàm có 2 đầu vào double double, trả về double
    // => Bên phải nhất là đầu ra, còn lại là đầu vào, chơi GENERIC cả đám
    // Hàm 5 đầu vào ++ 1 đầu ra -> 6 GENERIC
    // Hàm có tối đa 16 đầu vào T1 T2 T3 ... T16 cộng vớ thằng đầu ra result
    // Hàm có k đầu vào ==> 17 loại hàm

    //Func<int, int, long, char, Student, float, Pet, Lecturer,.. int>
    //                  đầu vào                                   đầu ra

    //

    delegate double OneInputOneOutputDelegate(double n);

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("C#13: METHOD RETURN VALUE");
            //OneInputOneOutputDelegate f1 = ComputeExponent;
            //f1(5); // 25 k có vì chưa in ra, nó vẫn tính nhưng k in thoi
            //var result = f1(5);
            //Console.WriteLine($"5^2 = {result}");
            //Console.WriteLine($"5^2 = {f1(5)}");

            //C#14: Tính bình phương của 1 con số rồi trả về kq
            //Func<int, double> f2 = x => x * x;
            //Console.WriteLine("C#14 - method returns VALUE USING FUNC<>");
            //Console.WriteLine("1000^2 = " + f2(1000)); //1 triệu

            //C#15: Tính chu vi của tam giác
            //Func<double, double, double, double> f3 = (double a, double b, double c) => a + b + c;

            //Func<double, double, double, double> f4 = (a, b, c) => a + b + c;
            //Console.WriteLine("C#15 - TRIANGLE FUNC<>");
            //Console.WriteLine("3 + 4 + 5 = " + f4(3, 4, 5)); // 12

            //C#16: Thách thức danh hài: Viết hàm trả về 1 con số bất kì (ngẫu nhiên)
            //Func<int> getRandomNumber = () => 678; // 21 nút :)) 
            //Console.WriteLine("C#16 - RANDOM NUMBER<>");
            //Console.WriteLine("My own number: " + getRandomNumber());

            //C#17: Viết hàm nhận vào 1 con số double GPA - điểm trung bình
            // trả về true nếu GPA >= 8 và ngược lại
            Console.WriteLine("Check hàng");
            Console.WriteLine("10 >= 8 ? " + CheckGrade(10));

            Func<double, bool> checkHang = grade => grade >= 8;
        }

        static bool CheckGrade(double gpa) => gpa >= 8;

        static double ComputeExponent(double n) => Math.Pow(n, 2);
    }
}

