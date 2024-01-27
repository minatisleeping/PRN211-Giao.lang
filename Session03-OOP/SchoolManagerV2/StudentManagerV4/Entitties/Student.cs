using System;
namespace StudentManagerV4.Entitties
{
	public class Student
	{
        private string _id;
        private string _name;
        private string _email;
        private int _yob;
        private double _gpa;

        //câu chuyên Get() Set()
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetEmail() => _email;
        public void SetEmail(string email) => _email = email;

        //GetX() và SetX() bản chất là đang thao tác trên X
        //C# đưa ra cách viết gộm, quy 2 hàm về chung 1 tên gọi
        //X thay thế bằng Name, Email, Yob tuỳ property

        public int Yob
        {
            get { return _yob; }
            set { _yob = value; }
        }

        public double Gpa
        {
            get => _gpa; 
            set => _gpa = value;
        }

        //Kĩ thuật viết Get() Set() kiểu này
        //Gọi là full property vì nó chứa đầy đủ tên hàm Get() Set()
        //và 1 Field _ để lưu Info Get Set
        //Field _ được gọi tên mới là: BACKING FIELD, EM CHỐNG LƯNG CHO GET VÀ SET
        //NẾU BẠN LỠ QUÊN CÚ PHÁP THÌ SAO, HÃY GÕ
        //PROPFULL TAB TAB
        private int _phone;
        public int Phone
        {
            get => _phone;
            set => _phone = value;
        }
    }
}

