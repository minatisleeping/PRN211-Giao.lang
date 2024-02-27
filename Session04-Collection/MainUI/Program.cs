using Repositories.Entities;
using Services;

namespace MainUI;
class Program
{
    public static void Main(string[] args)
    {
        Cabinet<Student> seList = new Cabinet<Student>();

        Cabinet<Student> bizList = new Cabinet<Student>();

        Cabinet<Lecturer> seLecList = new Cabinet<Lecturer>();

        //2 SE
        seList.AddItem(new Student() { Id = "SE1", Name = "Lê Điệp", Gpa = 9.6 });
        seList.AddItem(new Student() { Id = "SE2", Name = "Tân Trần", Gpa = 1.45 });

        //2 Biz
        bizList.AddItem(new Student() { Id = "SS3", Name = "Quyền", Gpa = 8.9 });
        bizList.AddItem(new Student() { Id = "SS4", Name = "Minh Cao", Gpa = 8.875 });

        //2 GV
        seLecList.AddItem(new Lecturer() { Id = "00000001", Name = "Giáo Làng", Salary = 150000000 });
        seLecList.AddItem(new Lecturer() { Id = "00000002", Name = "Nguyễn Thế Hoàng", Salary = 150000000 });

        // in all info
        Console.WriteLine("The SE student list");
        seList.PrintAll();

        Console.WriteLine("The Biz student list");
        bizList.PrintAll();

        Console.WriteLine("The GV student list");
        seLecList.PrintAll();

        Console.ReadLine();
    }
}

