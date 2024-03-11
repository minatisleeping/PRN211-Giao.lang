namespace PassByDelegateV4
{

    // C#8: Viết hàm nhận vào 1 con số, in ra con số đó
    // C#9: Viết hàm nhận vào 1 con số, in ra con số đó nếu là số chẵn
    // C#10: Viết hàm nhận vào 1 con số, in ra con số đó nếu là số lẻ

    class Program
    {
        static void Main(string[] args)
        {
            //Action<int> f = PrintEvenNumber;

            //PrintNumbers(PrintOddNumber);

            //C#12: dãy 5 10 15 20; tui muốn in các số > 20
            //mà lại phải xài PrintNumbers() ở trên
            Console.WriteLine("C#12");
            PrintNumbers((int x) =>
            {
                if (x > 10) Console.WriteLine(x);
            });


        }

        //C#11: Viết hàm in ra các số chẵn, lẻ dựa theo giá trị đưa vào
        static void PrintNumbers(Action<int> f)
        {
            // cần có thêm đầu vào cho f(số nào đó) do f thuộc style cần con số nguyên
            // nếu ta có 1 mảng số, nhồi từng con [i] vào là ngon
            //ta in đc 1 mảng các số chẵn trong những con sớ đưa vào

            //chưa có mảng thì ta hard-code, code cứng value có sẵn
            f(5);
            f(10);
            f(15);
            f(20);
        }

        static void PrintNumber(int number) => Console.Write(number + " ");

        static void PrintEvenNumber(int number)
        {
            if (number % 2 == 0) Console.Write(number + " ");
        }

        static void PrintOddNumber(int number)
        {
            if (number % 2 == 1) Console.Write(number + " ");
        }
    }
}


