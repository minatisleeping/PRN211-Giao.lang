namespace Delegate;

//DELEGATE sẽ khai báo ở  bên ngoài class khác, và nằm dưới namespace/package
//Solution có hiều Project
//Project co nhiều Namespace
//Namespace có nhiều Class

// tao - delegate là 1 data type cho nhóm object phức tạp là cái d am91 hàm tao trỏ/quản lí bình đẳng

public delegate void X(); // X: tui là class X đại diện cho 1 đám hàm ở dưới hay đâu đó có chung style là void ???
//x f = value là tên hàm ở dưới, al2 nick name cho tên hàm nào đó ở dưới
//  f là tên gọi khác cho cái hàm ở dưới cùng style
// int x = value

public class Person
{
    
}

internal class Program
{
    static void Main(string[] args)
    {
        
        X f1 = new X(TellHer);

        X f2 = NhanEm;

        //TellHer();
        f1();
        f2();

        // Cách gọi khác: gọi qua hàm Invoke() đc tạo sẵn, giống ToString()
        Console.WriteLine("Call message by using Invoke() method inside the X class");
        f1.Invoke(); // X là class có nhiều hàm bên trong như class Student
        f2.Invoke(); // bên trong còn chứa cả tên hàm!!
                     // có quyền gọi hàm từ bên trong hay gọi tắt



        Console.ReadLine();
    }

    static void TellHer() => Console.WriteLine("Cuộc sống em ổn k? Xa anh em phải hạnh phúc!!!");

    static void NhanEm() => Console.WriteLine("Chúc em hạnh phúc bên người");

    static void SayHelloToSweetHeart() => Console.WriteLine("Bánh mì k? Hai ta về chung một nhà heng? Chúng ta của tương lai");

    // còn nhiều hàm nữa trong tương lai ở đây, mà có thể ở Project khác, .DLL khác
    static void HelloWorld() => Console.WriteLine("Heloo Delegate!");

}

