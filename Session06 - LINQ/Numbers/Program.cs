namespace Numbers
{
    // CHALENGE #1: LƯU TRỮ 1 DANH SÁCH SỐ NGUYÊN CHO TRƯỚC
    //              SAU ĐÓ IN RA: CÁC SỐ DƯƠNG
    //                            CÁC SỐ ÂM
    //                            IN RA TOÀN BỘ
    //                            IN RA CÁC SỐ CHIA HẾT CHO 5
    class Program
    {
        static void Main(string[] args)
        {
         
            PrintWithBuildInOnDemandMethodsV2();
        }

        static void PrintWithBuildInOnDemandMethodsV2()
        {
            List<int> arr = new List<int> { -10, -100, 50, 2, 1, 5, 10, 13, -2 };

            var result = from x in arr  // với mọi x thuộc tập arr
                         where x > 0    // xem x nào > 0
                         select x;      //thì lấy x đó
            //câu query giống SQL dùng để truy vấn  data trong RAM - LINQ theo style query syntax
            // RUNTIME  chayy5 thì convert về LAMBDA như đã viết, .WHERE(x => x > 0)
            //method syntax

            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Diviabke by 2");
            result = from x in arr
                     where x % 2 == 0
                     select x;
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }

            static void PrintWithBuildInOnDemandMethods()
        {
            List<int> arr = new List<int> { -10, -100, 50, 2, 1, 5, 10, 13, -2 };
            // tui mún in tất cả dayy4 số
            // arr có sẵn 1 loạt các hàm để xử lí data mà nó cất trữ, thayy vì ta phải tự làm. Hàm style in demand cũng cần Action, Action<>
            //, Func<>, Predicate<> tuỳ loại hàm: in, tính tổng, count, trung bình..

            //1. In toàn bộ con số
            Console.WriteLine("ALL");
            arr.ForEach(x => Console.WriteLine(x));

            //2. In số âm
            Console.WriteLine("< 0 ");
            arr.ForEach(x => { if (x < 0) Console.WriteLine(x); });


            //3. Trả về các dương cho tui 50, 2, 1, 5, 10, 13
            // Hàm demand trả về list để ta dùng tiếp thay vì chỉ in ra

            Console.WriteLine("> 0");
            List<int> result = arr.Where(x => x > 0).ToList();
            result.ForEach(x => Console.WriteLine(x));
        }

        static void PrintListOnDemand(Predicate<int> f)
        {
            List<int> arr = new List<int> { -10, -100, 50, 2, 1, 5, 10, 13, -2 };

            foreach (var x in arr)
            {
                //2 cách: giao khoán hết ra ngoài in Action<int>
                //        chủ dộng in, nhưng nhờ bên ngoài check giá trị Predicate<int>
                if (f(x))               // f(x) == true
                    Console.WriteLine(x);
            }
        }
    }

}

