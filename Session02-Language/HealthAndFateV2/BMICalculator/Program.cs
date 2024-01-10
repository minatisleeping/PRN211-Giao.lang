namespace Bmi; // ~tương đương với 1 package bên Java, thư mục/ngăn tủ chứa các class
               //theo 1 tiêu chí phân loại
                       
internal class Program  
{                                        
    static void Main(string[] args)
    {
        Console.WriteLine("Heloo world!");
        double bmi = GetBmi(69, 1.73);
        Console.WriteLine("1. Your BMI is: " + bmi);    //in chuỗi/ghép chuỗi kiểu truyền thống
                                                        //dùng toán tử + chuỗi - CONCATENATED
        Console.WriteLine("2. Your BMI is: {0}", bmi);  //PLACE-HOLDER
                                                        //CHỪA CHỖ SẴN TRONG CHUỖI, FILL VALUE TỪ BIẾN VÀO SAU
                                                        //NẾU CÓ NHIỀU BIẾN THÌ CHỪA CHỖ ĐẾM TỪ 0, 1, 2
        Console.WriteLine("3. Your BMI is: {0} | {1}", bmi, 2024);
        Console.WriteLine($"4. Your BMI is: {bmi}");    //INTERPOLATION - NỘI SUY
                                                        //RÁNG SUY NGHĨ, TÌM TRONG CHUỖI
                                                        //NẾU THẤY BIẾN THÌ ĐIỀN VALUE VÀO
        Console.WriteLine("5. Your BMI is: {0}", BmiCalculator.GetBmi(69, 1.73));
        Console.WriteLine($"6. Your BMI is: {BmiCalculator.GetBmi(69, 1.73)}");


        Console.WriteLine("Press any key to exit..");
        Console.ReadLine();

        
    }

    // các hàm nằm trong class
    static double GetBmi(double weihgt, double height) => weihgt / (height * height);
    // nếu hàm có duy nhất 1 câu lệnh thì cho phép rút gọn
    // ko cần dùng {} return, dẹp hết, lấy đúng phần xử lí của hàm
    // đặt sau tên hàm và dấu =>
    // KĨ THUẬT NÀY GỌI LÀ: BODY EXPRESSION, THÂN HÀM NHƯ 1 BIỂU THỨC 
    //CẤM KO ĐƯỢC NHẦM LẪN VỚI BIỂU THỨC LAMDA - CŨNG XÀI CHUNG DẤU =>
    //NHƯNG LÀ KIẾN THỨC KHÁC, CỰC HAY, SẼ HỌC SAU!!!

    // Ctrl K C là comment lại 1 block of code - nhóm lệnh
    // Ctrl K U là uncomment
    // Ctrl D: format code
}
//class khác được quyền khai báo ở đây
//1 không gian tên - 1 căn phòng - 1 package
//chứa nhiều class có liên quan
//kĩ thuật tổ chức lưu trữ các class mà thôi


