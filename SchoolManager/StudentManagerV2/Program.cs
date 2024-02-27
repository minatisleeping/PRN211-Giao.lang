using StudentManagerV2.Services;

namespace StudentManagerV2;
class Program
{
    static void Main(string[] args)
    {
        Cabinet seBox = new Cabinet();
        Cabinet bizBox = new Cabinet();

        seBox.AddNewStudent("SE161567", "Nhật", "an@...", 2002, 6.7);
        seBox.AddNewStudent("SE171111", "Huy", "huy@...", 2003, 6.88);

        bizBox.AddNewStudent("SE152111", "Trung", "trung@...", 2001, 8.12);
        bizBox.AddNewStudent("SE191233", "Khải", "khai@...", 2002, 9.8);

        Console.WriteLine("The SE students: ");
        seBox.ShowStudentList();
        Console.WriteLine("The BIZ students: ");
        bizBox.ShowStudentList();

        Console.ReadLine();
    }
}

