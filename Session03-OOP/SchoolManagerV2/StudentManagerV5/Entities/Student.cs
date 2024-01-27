using System;
namespace StudentManagerV5.Entities
{
	public class Student
	{
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //lỡ k nhớ cú pháp thì gõ prop tab tab

        //khi biên dịch, runtime, SDK tự chèn _ tương ứng ở hậu trường
        //Kĩ thuật viết code kiểu này gọi là
        //Auto-implemented property

        //Java ko có cách này một cách chính thức mà phải xài thư viện của bên thứ ba - Lombok dependency

        //DATABASE FIRST, SAU TẾT GÕ 1 LỆNH, 50 TABLE TRONG DB
        //SẼ TỰ ĐỘNG CONVERT THÀNH CLASS XÀI AUTO PROP NHƯ TRÊN
    }
}

