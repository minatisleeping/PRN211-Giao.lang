using StudentV1.Entities;

namespace StudentV1;
class Program
{
    static void Main(string[] args)
    {
        CreateAStudentObjectV4();
        Console.ReadLine();
    }

    static void CreateAStudentObjectV4()
    {
        // style new kiểu mới!!!
        Student nhat = new (gpa: 8.8, yob: 2001, name: "NhatMM", id: "SE1", email: "nhatmm@fpt.edu.vn" );

        nhat.ShowProfile();
    }//chủ động dưa value vào hàm lộn xộn thứ tự, miễn là đi kèm tên biến máy runtime biết để map value cho đúng!!!
    //NAMED-ARGUMENT, ĐƯA VALUE KÈM TÊN THAM SỐ

    static void CreateAStudentObjectV3()
    {
        // style new kiểu mới nữa!!!
        // bỏ kiểu dữ liệu sau new vì đã có data type

        Student nhat = new("SE1", "NhatMM", "nhatmm@fpt.edu.vn", 2002, 8.8);

        nhat.ShowProfile();
    }//tự suy luận nhat là Student do value gán vào

    static void CreateAStudentObjectV2()
    {
        // style new kiểu mới!!!
        var nhat = new Student("SE1", "NhatMM", "nhatmm@fpt.edu.vn", 2002, 8.8);
       
        nhat.ShowProfile();
    }//tự suy luận nhat là Student do value gán vào

    static void CreateAStudentObjectV1()
    {
        // tạo mới 1 obj sv, 1 sv cụ thể, 1 thing complex, style truyền thống
        // con người luôn có xu hướng đặt tên cho mọi thứ quanh họ, sau khi đã mô tả chúng!!
        // name: Leonardo... nick: Messi, goals: 800
        // ta gọi obj này là Messi!
        // 3.14 -> PI, 300.000km/s -> c
        // 9.8 m/s -> g
        // 10%, 8% -> VAT
        //s = v * t

        //ta sẽ gọi 1 bạn sv nào đó = nick name gọn gàng kiểu như
        // nhat = { id = SE1, name: NhatMM, yob: 2002... }
        Student nhat = new Student("SE1", "NhatMM", "nhatmm@fpt.edu.vn", 2002, 8.8);
        //nhat -> biến obj
        //new Student(...) là 1 thing cụ thể, thứ phức tạp
        // OBJECT

        nhat.ShowProfile();
    }
}

