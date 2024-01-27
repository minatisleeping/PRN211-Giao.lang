using StudentManagerV2.Entities;
//import bên Java
//#include <stdio.h> bên C

namespace StudentManagerV2;
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        //toàn bộ info bên trong object ko đc đổ gì cả, default value
        //chứng minh có default value

        s1.ShowProfile();

        s1.SetGpa(8.6);
        Console.WriteLine("After upgrading the gpa:");
        s1.ShowProfile();

        //new thì gọi phễu để tạo mới ibj
        //get set thì chỉnh sửa thao tác trên obj đã đc new
        //ko tạo ra thêm obj mới. Y chang cách bạn update FB profile


        Console.ReadLine();
    }
}

