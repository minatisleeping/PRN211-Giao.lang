namespace Students
{
    // THÁCH THỨC DANH HÀI: TA CÓ DANH SÁCH SINH VIÊN..
    //List<Student> arr = new List<Student>() {new Student() {Id = "SE1", Name = "An"},
    //                                         new Student(){},
    //                                         new Student(){},
    //                                         new Student(){}
    //                                         };

    // Ta in toàn bộ SV, ta in sv ở tỉnh này, in điểm GPA >= 8 ở Bình Dương
    // Đưa LAMBDA vào arr.WHERE(s => { s.Id s.Gpa });
    // Tao là hàm .WHERE() của list arr, và tao có rất nhiều SV trong tay
    // Tao thảy từng SV tên là S cho hàm của mày đưa vào, mày mún làm gì với S thì mày làm
    // 2 cơ chế xử lí: Tao list đưa từng đứa, từng object, con số cho hàm ngoài, bên ngoài làm gì thì làm -> Action<>: FOREACH..
    //                 Tao list đưa từng đứa cho chúng mày hàm ngoài, hàm ngoài báo tao ku đó có valid hay k, tao list kiểm soát trở lại: sum, count, where..

    // LINQ: language Intergrated Query: Kĩ thuật truy vấn data trong RAM theo 2 style
    //hàm lambda - gốc          - METHOD SYNTAX
    //CÂU "SQL" VIẾT NGƯỢC      - QUERY SYNTAX
    //MERGE
    // XÀI CHUỖI ... BẢN CHẤT LÀ TRẢ VỀ OBJECT CHẤM TIẾP ĐƯỢC

    //Java: Stream API, đầu vào của hàm trai bao() sẽ là OBJECT xuất phát từ interface
    //chỉ có duy nhất 1 hàm - interface chỉ cho phép có tối đa 1 hàm abstract
    //                          FUNCTIONAL INTERFACE
    //@Functional Interface
    //public interface DeathRacer
    //Lambda Java -> C# =>
    //LINQ ~ STREAM API (k nhầm lẫn với I/0 STREAM - TẬP TIN)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


