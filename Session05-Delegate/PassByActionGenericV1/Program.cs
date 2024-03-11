namespace PassByActionGenericV1
{
    // CHALLENGE #1: Viết hàm nhận vào 1 con số, in ra con số đó là số chẵn
    //               Viết hàm nhận vào 1 con số, in ra con số đó là số lẻ
    //               Viết hàm nhận vào 1 con số, in ra con số đó >= 50
    //               Viết hàm nhận vào 1 con số, in ra con số đó là số nguyên tố
    class Program
    {
        //static void Main(string[] args)
        //{
        //    // gọi lẻ 4 hàm là style truyền thống, k thèm nói
        //    //PrintEvenNumber(5);
        //    //PrintOddNumber(5);
        //    //PrintPrimeNumber(5);
        //    //PrintNumbergtEq50(5);
        //    //Console.WriteLine(" --- Round 2 ---");
        //    //PrintEvenNumber(10);
        //    //PrintOddNumber(11);
        //    //PrintPrimeNumber(13);
        //    //PrintNumbergtEq50(50);
        //    //Console.WriteLine(" --- Round 3 ---");
        //    //PrintOnDemand(PrintEvenNumber);
        //}

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Print even number from 5 10 15 20: ");
        //    PrintOnDemand(PrintEvenNumber);

        //    Console.WriteLine("Print odd number from 5 10 15 20: ");
        //    PrintOnDemand(PrintOddNumber);

        //    Console.WriteLine("Print number >= 50 from 5 10 15 20: ");
        //    PrintOnDemand(PrintNumbergtEq50); //nothing

        //    Console.WriteLine("Print prime number from 5 10 15 20: ");
        //    PrintOnDemand(PrintPrimeNumber);

        //    //C#2: THÁCH THỨC DANH HÀI: IN RA CÁC SỐ CHIA HẾT CHO 5
        //    Console.WriteLine("Print divisable by 5 numbers from 2 10 15 20 25 26 29: ");
        //    PrintOnDemand(number =>
        //    {
        //        if (number % 5 == 0) Console.Write(number + " ");
        //    });
        //    //C#3: IN HẾT
        //    Console.WriteLine();
        //    Console.Write("Print ALL: ");
        //    PrintOnDemand(number => Console.Write(number + " "));
        //}

        public static void Main(string[] args)
        {
            PrintOnDemandV2(PrintNumbergtEq50);
        }

        static void PrintOnDemandV2(Action<int> f)  // = PrintEvenNumber === lambda
        {
            // Nếu ta có nhiều data cần sàng lọc theo nhu cầu bên ngoài, đưa data vào mảng
            List<int> list = new List<int> { 5, 10, 15, 20, 1, 3, 5, 7, 100, 101 };
            foreach (var i in list)
            {
                f(i);
            }
        }

        static void PrintOnDemand(Action<int> f) // = PrintEvenNumber === lambda
        {
            // đầu vào lấy ở đâu mà dau79 cho f
            // giả sử mình có sẵn data 5 10 15 20 25
            f(5);   //f đại diện - luật sư của nhiều hàm khác cùng style void F(int x)
            //data bên trong class mình viết chứa hàm TraiBao() sẽ gửi cho hàm đâu đó
            //bên ngoài, outsource xử lí data ra ngoài
            f(10);
            f(15);
            f(20);
            f(25);
            f(26);
            f(29);
            // Nhờ bên ngoài filter data theo cách của họ
            // Tập data  5 10 15 20 .. trong nội tại sẽ đc cung ứng ra bên ngoài
            //bên ngoài xem xét data phù hợp hay ko sẽ dùng
            //cung ứng dịch vụ xử lí data theo nhu cầu
            //bác nào muốn xử lí, em đưa data bác lo xử lí
        }

        static void PrintEvenNumber(int number)
        {
            if (number % 2 == 0) Console.WriteLine(number);
        }

        static void PrintOddNumber(int number)
        {
            if (number % 2 != 0) Console.WriteLine(number);
        }

        static void PrintNumbergtEq50(int number)
        {
            if (number >= 50) Console.WriteLine(number);
        }

        static void PrintPrimeNumber(int number)
        {
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0) return;
            }
            if (number >= 2) Console.WriteLine(number);
        }
    }
}


