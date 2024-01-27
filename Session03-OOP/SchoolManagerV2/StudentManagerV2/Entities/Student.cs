using System;
namespace StudentManagerV2.Entities
{
	public class Student
	{
        private string _id;		
        private string _name;	
        private string _email;	
        private int _yob;
        private double _gpa;

        //phễu nhận vật liệu vào và chảy vào bên trong các place holder
        //constructor có tham số
        //public Student(string id, string name, string email, int yob, double gpa)
        //{
        //    _id = id;
        //    _name = name;
        //    _email = email;
        //    _yob = yob;
        //    _gpa = gpa;
        //}

        //ĐIỀU GÌ XẢY RA NẾU 1 KHUÔN KO CÓ PHỄU, KO CÓ CHỖ ĐỂ ĐỔ VẬT LIỆU
        //VÀO BÊN TRONG. VỀ LÍ THUYẾT, TA SẼ CÓ 1 OBJECT FULL OF KHÔNG KHÍ
        //DO KHUÔN THÌ PHẢI RỖNG, NẾU KO ĐỔ VẬT LIỆU SẮT ĐỒNG THIẾC THÌ
        //RÕ RÀNG TRONG KHUÔN ĐANG CÓ KHÔNG KHÍ LẤP ĐẦY CÁC NGÓC NGHÁCH CỦA KHUÔN
        //.1 OBJECT K KHÍ, 1 OBJECT TỰ CÓ SẶN INFO, 1 OBJECT MANG GIÁ TRỊ DEFAULT

        //ĐÃ LÀM KHUÔN THÌ PHẢI ĐÚC ĐC, CHO DÙ LÀ OBJECT KHÔNG KHÍ
        //VẬY THÌ NẾU KHUÔN KO CÓ PHỄU/CONSTRUCTOR, THÌ MẶC ĐỊNH SDK TOOL
        //SẼ TỰ ĐỘNG TẠO RA CHO BẠN 1 CÁI PHỄU DO-NOTHING, KO NHẬN ĐẦU VÀO
        //KO XỬ LÍ  GÌ CẢ, GỐNG KHUÔN ĐÓNG NẮP CÓ SẴN KO KHÍ BÊN TRONG, KO CẦN LÀM GÌ CAR
        //SDK TỰ TẠO CHO BẠN PHỄU DẠNG NHƯ SAU
        //LCU1 THỰC THI APP
        //public Student() {ko cần lệnh nào bên trong}

        //giúp ta gõ new Student() k làm gì cả, chỉ điền default ko khí
        //khi đó các đặc điểm bên trong object mang giá trị default luôn chuỗi -> rỗng
        //số -> 0
        //0 -> false
        //bool -> false

        //mặc định object giấu thông tin. Show ra qua Get(), ai hỏi thì trả lời
        public string GetName()
        {
            return _name;
        }

        //public string GetEmail() => _email;
        //public int GetYob() => _yob;
        //public double GetGpa() => _gpa;

        //hàm ShowAll() ToString() -> rút CCCD show ra info
        public void ShowProfile() => Console.WriteLine($"{_id} | {_name} | {_email} | {_yob} | {_gpa}");

        //Giả sử OBJECT đã đc đúc xong, ta có nhu cầu chỉnh sửa nó

        public void SetGpa(double gpa)
        {
            _gpa = gpa;
        }

        public void SetYob(int yob) => _yob = yob;
    }
}

