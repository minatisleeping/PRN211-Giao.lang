namespace PassByAction
{

    //CHALLENGE: VIẾT HÀM THẦU CÁC HÀNH ĐỒNG NÀO ĐÓ BÊN NGOÀI ĐƯA VÀO
    // hàm thầu các dịch vụ in ấn nào đó: in bài hát, in số, in dãy số..
    class Program
    {
        static void Main(string[] args)
        {
            DoOnDemand(delegate () {
                Console.WriteLine("Cầm tay anh, dựa vai anh");
                Console.WriteLine("Code cùng anh, nơi này có C#");
            });
            DoOnDemand(() => {
                Console.WriteLine("Chúng ta không thuộc về nhau");
                Console.WriteLine("C# chắc có là của nhau???");
            });
        }

        static void DoOnDemand(Action f) // = hàm nào đó có style void F()
        {                                // = hàm ẩn danh hay hàm lambda
            Console.WriteLine("Do - while - for - code as normal");

            //later, callback f
            f();
        }
    }
}

