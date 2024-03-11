using System;

//Java java.util	com.mycompany.myproject.mymodule
namespace StudentV1.Entities
{
	public class Student
	{//  class chính là cái Khuôn bên trong chứa các place holder ứng với
	 //  các đặc điểm của mỗi object thuộc về Class/Nhóm này
	 //Để có đc 1 sản phẩ từ Khuôn clone ra object, ta cần phải đúc - hành động đổ
	 //vật liệu vào trong Khuôn
		private string _id;		//place holder _____
        private string _name;	//quy ước dùng cú pháp con lạc đà
        private string _email;	//và _ ở đầu từ _basicSalary
        private int _yob;
        private double _gpa;

        public Student(string id, string name, string email, int yob, double gpa)
        {
            _id = id;   // ko cần this. vì ko  có sự nhầm lẫn về tên gọi
            _name = name;
            _email = email;
            _yob = yob;
            _gpa = gpa;
        }

        // tạo phễu để hứng vật liệu đổ vào Khuôn
        // cũng giống như tạo hàm để hứng data đưa vào place holder
        // phễu dùng để hứng vật liệu đổ vào trong khuôn tạo object, PHỄU/CREATE/CONSTRUCT OBJECT
        // HÀM DÙNG ĐỂ HỨNG DATA BÊN NGOÀI ĐỔ VÀO ĐẶC ĐIỂM CỦA OBJECT, ĐỔ VÀO CÁC PLACE HOLDER
        // HÀM NÀY GỌI LÀ CONSTRUCTOR DÙNG ĐỂ CONSTRUCT/CREATE/CLONE OBJECT

        // mặc định info của ta là private cho sự riêng tư
        //khi cần giao tiếp ta  mới bung ra, khoe vừa đủ, hay khoe hết
        // hành động giao tiếp để thấy được info của nhau, lấy info của nhau, gọi là Get()

        public string GetName()
        {
            return _name;
        }

        public int GetYob()
        {
            return _yob;
        }   //traditional - truyền thống

        public double GetGpa() => _gpa; //body expression
        public string GetEmail() => _email;
        public string GetId() => _id;

        //hành động show hết info, show hết profile, show những thứ internal 1 lượt => ToString()
        //biến đổi mọi info đang có thành chuỗi dài show ra
        //1 phiên bản trả về chuỗi, 1 phiên bản in ra all

        public void ShowProfile()
        {
            Console.WriteLine(@$"Here is my profile:
Id: {_id}
Name: {_name}
Yob: {_yob}
Gpa: {_gpa}
Email: {_email}");
        }   //verbatim interpolation
    }
}

