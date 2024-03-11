using StudentManagerV5.Entities;

namespace StudentManagerV5;
class Program
{
    static void Main(string[] args)
    {
        // CÓ THÊM 1 CÁCH NỮA ĐỂ NEW OBJECT

        Student s1 = new Student();   //ctor default
        s1.Name = "Ngọc Trinh";
        s1.Gpa = 4.0;

        Console.WriteLine($"{s1.Id} | {s1.Name} | {s1.Yob} | {s1.Email} | {s1.Gpa}");

        Student s2 = new Student() { Id = "SE1", Name = "Ngọc Trinh", Yob = 2003, Gpa = 4.0 };
        Console.WriteLine($"{s2.Id} | {s2.Name} | {s2.Yob} | {s2.Email} | {s2.Gpa}");

        //CREATE OBJECT USING PROPERTY INITATION
        //TẠO OBJECT VÀ KHỞI ĐỘNG LUÔN VIỆC KHỞI ĐỘNG VÀ GÁN GÁI TRỊ CHO CÁC ĐẶC TÍNH CỦA OBJECT
        //KO NHẦM LẪN VỚI NAMED-ARGUMENT
        Console.ReadLine();
    }
}

