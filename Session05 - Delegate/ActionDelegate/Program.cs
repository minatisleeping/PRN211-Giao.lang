namespace ActionDelegate
{
    //CHALLENGE #1: Viết hàm in ra câu thông báo: "NAM EM đã ra viện rồi !!!"
    //              Viết theo style truyền thống, nhớ run hàm

    //CHALLENGE #2: Viết hàm in ra câu thông báo: "NAM EM và 35 TRIỆU :))"
    //              DÙNG DELEGATE & ANONYMOUS FUNCTION

    //CHALLENGE #3: Viết hàm in ra câu thông báo: "08/03/24: CHÚNG TA CỦA TƯƠNG LAI"
    //              DÙNG DELEGATE & LAMBDA FUNCTION

    //CHALLENGE #4: Dùng lại hàm C#1 kết hợp với DELEGATE

    //CHALLENGE #5: K dùng DELEGATE do ta tạo ra, NoInputNoOuputDelegate() any more
    //MICROSOFT, .NET SDK cung cấp sẵn cho ta 1 DELEGATE style void F()
    //gọi là: Action, làm đi, run đi, vậy thoy, k cần vào, k cần ra
    // Nếu sau này mình cần làm việc với hàm KO-VÀO-KO-RA thì ta k cần tạo DELEGATE mà xài luôn
    //Action  và chỉ việc khai báo biến con trỏ đến hàm nào là xong


    delegate void NoInputNoOuputDelegate();
    //          void F() style

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("C#5: Xài Action");
            Action f = ShowNotification;    // truyền thống hàm có sẵn ngoài kia
            f();

            Action f1 = delegate {
                Console.WriteLine("08/03/23: CHÚNG TA CỦA TƯƠNG LAI | SƠN TÙNG M-TP vs Hủ Tái vs Thầm Bảo Triêu\n");
        	};
            f1();

            Action f2 = () => Console.WriteLine("08/03/23: CHÚNG TA CỦA TƯƠNG LAI | SƠN TÙNG M-TP vs Hủ Tái vs Thầm Bảo Triêu\n");
            f2.Invoke();
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("CHALLENGE #1 - CALL METHOD AS NORMAL");
        //    ShowNotification();

        //    Console.WriteLine("CHALLENGE #2 - CALL METHOD USING ANONYMOUS FUNC");
        //    NoInputNoOuputDelegate f1 = delegate {
        //        Console.WriteLine("02/03/24:NAM EM và 35 TRIỆU :))\n");
        //	};
        //    f1.Invoke();

        //    Console.WriteLine("CHALLENGE #3 - CALL METHOD USING LAMBDA");
        //    NoInputNoOuputDelegate f2 = () =>
        //    {
        //        Console.WriteLine("08/03/24: CHÚNG TA CỦA TƯƠNG LAI\n");
        //    };
        //    f2();

        //    NoInputNoOuputDelegate f3 = () => Console.WriteLine("08/03/24: CHÚNG TA CỦA TƯƠNG LAI\n");
        //    f3.Invoke();

        //    Console.WriteLine("CHALLENGE #4 - CALL METHOD USING DELEGATE & EXPLICIT METHOD");
        //    NoInputNoOuputDelegate f4 = ShowNotification; //gán bằng hàm có sẵn
        //    f4();
        //}

        static void ShowNotification() => Console.WriteLine("02/03/23: Nam Em đã ra viện rồi !!!\n");
        // Hàm full tên, xài => Đích thị mày là EXPRESSTION BODY
        

    }
}


