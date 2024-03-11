namespace PassByActionGenericV2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tính tổng chẵn
            Console.WriteLine("Sum of even");
            SumOnDemand(CheckEvent);

            // Tính tổng lẻ
            Console.WriteLine("Sum of odd");
            SumOnDemand(x => x % 2 != 0);

            // Tính tổng tất cả
            Console.WriteLine("Sum of list");
            SumOnDemand(x => true);
            
        }

        static bool CheckEvent(int n) => n % 2 == 0; // expression body

        //static bool CheckEvent(int n)
        //{
        //    if (n % 2 == 0) return true; // nó mang đúng sai, true false
        //    return false;
        //}


        // CHALLENGE: Viết hàm tính tổng cảu 1 dãy số cho trước
        //            Vẫn dãy số đó, tính tổng của số chẵn
        //            Vẫn dãy số đó, đếm các số lẻ
        //            5 10 15 20 2 4 6 8 1 3 5 7 9

        static void SumOnDemand(Func<int, bool> f) // = hàm bool F(int x)
        {                                         // CheckEvent(int x) -> true false
            List<int> arr = new List<int> { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };

            int result = 0;

            foreach (var i in arr)
            {
                if (f(i)) result += i;
            }
            Console.WriteLine("Sum: " + result);
        }

        // Tính toán theo điều kiện đưa vào:
        // Sum: sum cái gì
        // count
        static void DoOnDemand()
        {
            List<int> arr = new List<int> { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
            int result = 0;
            foreach (var i in arr)
            {
                result += i;
            }
        }
    }
}


