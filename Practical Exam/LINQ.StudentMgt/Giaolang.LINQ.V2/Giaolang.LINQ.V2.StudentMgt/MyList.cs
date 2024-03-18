using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaolang.LINQ.V2.StudentMgt
{
    //class này chứa danh sách các sv. Có thể lấy từ database lên, hoặc hard-code 

    //delegate tự tui
    public delegate bool CheckStudent(Student x);

    internal class MyList
    {

        List<Student> _ds = new List<Student>()
        {
            new Student() {Id = "SE1", Name = "An", Address = "Dĩ An", Gpa = 8.8, Yob = 2003},
            new Student() {Id = "SE2", Name = "Bình", Address = "Bình Dương", Gpa = 9.0, Yob = 2008},
            new Student() {Id = "SE5", Name = "Dương", Address = "Tân Bình", Gpa = 5.0, Yob = 2005},
            new Student() {Id = "SE4", Name = "Dũng", Address = "Châu Thành", Gpa = 5.0, Yob = 2006},
            new Student() {Id = "SE3", Name = "Thành", Address = "Long An", Gpa = 8.0, Yob = 2000},
        };  //danh sách sv khởi tạo sẵn luôn




        //tui lại muốn thống kê ở Bình Dương, 
        //code có câu if (x.Address == Binh Duong) thì...
        //CHỐT CHO 3 HÀM ĐÃ VIẾT, VÀ NHỮNG HÀM SẼ VIẾT ĐỀU CÓ CHUNG 1 
        //LOGIC LÀ:
        //DUYỆT QUA TỪNG BẠN SV, HỎI XEM BẠN SV X ĐÓ CÓ THOẢ ĐK NÀO ĐÓ
        //HAY KO, NẾU THOẢ THÌ DÙNG BẠN X ĐÓ 

        //hàm nhận vào 1 delegate chẳng qua là nhận vào 1 hàm bool nào đó
        //ta cứ gửi từng bạn sv cho hàm này, trả về đúng sai cho mình
        //đúng sai trên gpa, yob, cả gpa & năm sinh, hoặc tỉnh, hoặc vô chừng
        //hàm thực sự làm thì để ở đâu cũng đc, rồi truyền vào delegate 
        //là xong
        //TA ĐÃ GIẢM NHẸ GÁNH NẶNG CHO CLASS MYLIST, CHỈ NGỒI CHỜ NGƯỜI TA
        //ĐƯA ĐK VÀO ĐỂ XÉT GIÙM

        //bạn có quyền tạo delegate riêng mà ko cần dùng Func nhưng ko nên
        //vì bạn phải export cả tên delegate cho nơi xài biết mà khai báo theo
        //còn nếu dùng Func, cả thế giới đều biết

        //public List<Student> GetStudents(CheckStudent check)
        //{

        //}

        //check = hàm nào đó nhận vào sv trả về bool
        //      = CheckStudentByGpa
        //      = CheckStudentByGpaAndYob
        //      = CheckStudentByAddress
        //      = vô chừng
        //      = Lamda
        public List<Student> GetStudents(Func<Student, bool> check)
        {
            List<Student> result = new(); 

            //quét qua từng sv để dò xem sv có thoả check hay ko
            foreach (Student x in _ds)  //với mọi x thuộc tập hợp YYY
            {
                if (check(x))    //condition, điều kiện kiểm soát data
                    result.Add(x); //predicate, hàm, lệnh dự đoán đk có thoả ko
            }

            return result;
        }



        //CLASS NÀY CHỨA DANH SÁCH SINH VIÊN, VÀ NÓ CUNG CẤP CÁC METHOD ĐỂ IN RA DANH SÁCH 
        //THEO CÁC TIÊU CHÍ NÀO ĐÓ; VÍ DỤ
        //DS SV THEO TỈNH, THEO TỈNH MÀ GPA >= 8
        //DS SV GPA > = 8.0
        //DS SV CÓ NĂM SINH >= 2005
        //DS SV CÓ NĂM SINH <= 2000 & QUÊ Ở ???
        //SỐ ĐIỀU KIỆN THỐNG KÊ NÀY LÀ VÔ CHỪNG!!!, CHƯA KỂ AND OR
        //LÀM SAO THIẾT KẾ CLASS NÀY CÓ THỂ THOẢ MÃN BẤT KÌ TIÊU CHÍ THỐNG KÊ NÀO???
        //VÌ TA CHƯA, KO THỂ BIẾT ĐC CÓ BAO NHIÊU ĐK THỐNG KÊ, CHÍNH LÀ WHERE SQL

        //mỗi hàm ta làm thoả 1 câu if, và số hàm là VÔ CHỪNG

        //KĨ THUẬT THIẾT KẾ PHẢI LÀM SAO, CHẤP TẤT CẢ CÁC ĐK TRONG TƯƠNG LAI
        
        //THAY VÌ TA / CLASS NÀY PHẢI TỰ LÀM CÁC CÂU IF, VÔ CHỪNG IF

        //TA ĐỂ CÂU IF NÀY CHO BÊN NGOÀI, LÚC XÀI CLASS NÀY ĐƯA VÀO

        //DEPENDENCY INJECTION

        //BẢN CHẤT LÀ ĐƯA VÀO 1 DELEGATE, ĐƯA VÀO HÀM Ở XA, Ở NƠI XÀI CỦA AI ĐÓ
        //


        //hàm trả về danh sách có gpa >=8. Trong code phải có chỗ so sánh điểm của 
        //từng sv coi >= 8 hay ko
        //
        public List<Student> GetStudentsByGpa()
        {
            List<Student> result = new ();  //viết full new List<Student>()

            //quét qua từng sv để dò xem gpa có thoả hay ko
            foreach (Student x in _ds)  //với mọi x thuộc tập hợp YYY
            {
                if (x.Gpa >= 8)    //condition, điều kiện kiểm soát data
                    result.Add(x); //predicate, hàm, lệnh dự đoán đk có thoả ko
            }

            return result;
            
        }

        //các bạn sinh viên có gpa >= 8 & năm sinh >= 2005
        public List<Student> GetStudentsByGpaAndYob()
        {
            List<Student> result = new();  //viết full new List<Student>()

            //quét qua từng sv để dò xem gpa có thoả hay ko
            foreach (Student x in _ds)  //với mọi x thuộc tập hợp YYY
            {
                if (x.Gpa >= 8 && x.Yob >= 2005)    //condition, điều kiện kiểm soát data
                    result.Add(x); //predicate, hàm, lệnh dự đoán đk có thoả ko
            }

            return result;

        }





    }
}
