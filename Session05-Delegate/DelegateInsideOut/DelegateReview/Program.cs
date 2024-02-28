namespace DelegateReview;

// 1 namespace sẽ có nhiều class. Các class có thể để triêng từng file or để chung trong 1 tập tin đều ok
//đề mang ý nghĩa là 1 NS có nhiều class

// delegate là 1 loại class đặc biệt, thay vì bình thường Lecturer Student dùng lưu info của các object dạng phức tạp
// Thì DELEGATE là 1 Class chuyên đi lưu trữ tên các hàm theo cùng style nào đó
// ta coi tên hàm là VALUE 
/*
    Danh từ đại diễn cho nhiều VALUE ==> GỌI LÀ DATA TYPE
    1 2 3 10 1000  ==> INT
    F1() F2() F3() ==> F() - DATA TYPE
*/
/*
public class F() [void F()] : Delegate
{
    list các name của các hàm

    public F(đưa tên hàm cụ thể ở ngaoi2 vào đâu lưu trữ) //ctor

    public void  Invoke() { gọi các hàm đã lưu tên ở trên run() }
}
*/

// 3 thằng ngang cơ nhau:
// 1. Class bình thường
// 2. INTERFACE
// 3. DELEGATE

public delegate void NoInputNoOutputDelegate();
// nhóm hàm void F() k vào k ra
// ngầm sau lưng chính là 1 Class tên là NoInputNoOutputDelegate ~ Student


public class Lecturer
{
    // info của GV

}

public class Student
{
    // info của SV
    public static void TellHerMessage3() => Console.WriteLine("3. Chúng ta của tương lai!");

}

internal class Program
{
    static void Main(string[] args)
    {
        //int                               yob             =       2004;
        //NoInputNoOutputDelegate()          f              =   1 hàm cụ thể

        NoInputNoOutputDelegate f = new NoInputNoOutputDelegate(TellHerMessage1);

        // f là nickname của TellHeerMessage
        //luật sư               thân chủ
        //1 hàm lúc này có 2 tên: f          TellHerMessage
        //                      gọi f()  ~   TellHerMessage() ca3 2 đều là run hàm

        f(); //delegate là gọi hàm gián tiếp, k gọi hàm gốc trực tiếp
        //luật sư hành xử cũng là  thân chủ  hành xử

        f.Invoke();


        f = TellHerMessage2; // new ngầm
        f();

        Console.WriteLine("Check hàng phép gán delegate");
        f += Student.TellHerMessage3;

        f();



        Console.ReadLine();
    }

    // cần các hàm cùng style void F() để chơi với biến f ở trên
    static void TellHerMessage1()
    {
        Console.WriteLine("1. Cuộc sống em ổn không?");
    }

    static void TellHerMessage2() => Console.WriteLine("2. Xa anh em phải hạnh phúc!");
    // expression body - đừng nhầm lẫn với LAMBDA EXPRESSION


}

