using StudentManagerV2.Entities;

namespace StudentManagerV2.Services

{
    
    public class Cabinet
	{
        const int MAX = 100;
        const int MIN = 0;
        // tương tự Cái Tủ đựng hồ sơ ngoài đời
        // nó có đặc tính, thông tin là: 1 mảng, 1 ko gian rộng rãi để cất trữ đồ gì đó
        // nó sẽ có các hành động: CRUD CREATE, RETRIEVE(READ), UPDATE, DELETE

        // Mở ngăn tủ, nhét 1 bộ hồ sơ vào: ADD/CREATE
        // Mở ngăn tủ, tìm lấy ra 1 bộ, chỉnh sửa thêm ảnh, giấy A4 ghi chú, cất trở lại: UPDATE
        // Mở ngăn tủ, tìm 1 bộ hồ sơ, thấy rồi, sao chụp lại, rồi cất vào chỗ cũ: SEARCH, READ/RETRIEVE ONE
        // Mở ngăn tủ, sắp xếp cho gọn gàng theo tiêu chí, ngày tháng năm, tên (nghi phạm): SORT/RETRIEVE
        private Student[] _list = new Student[MAX];
        private int _count = MIN;
        // tại sao lại là _list?? Baking field mà ko chơi với property/ẩn packing, chỉ Get(), Set()


        // TƯ DUY THIẾT KẾ KIỂU SOLID (OOP: 4 + 5)
        // S: SINGLE RESPONSIBILITY - THIẾT KẾ 1 CLASS ĐỪNG LÀM NHIỀU VIỆC QUÁ KHÁC BIỆT
        // Hàm này cất hồ sơ vào đúng vị trí, việc đó ổn vì đó là việc của cái tủ

        public void AddNewStudent(string id, string name, string email, int yob, double gpa)
        {
            _list[_count] = new Student() {Id = id, Name = name, Email = email, Yob = yob, Gpa = gpa };
            _count++;
        }

        public void ShowStudentList()
        {
            Console.WriteLine($"There is/are {_count} student(s) in the cabinet");
            for (int i = 0; i < _list.Length; i++)
            {
                Console.WriteLine(_list[i] + " ");
            }
        }
    }
}

