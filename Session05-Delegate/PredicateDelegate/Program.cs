namespace PredicateDelegate
{

    // MICROSOFT bảo rằng: nếu hàm nhận vào đúng 1 đầu vào, chỉ có 1 đầu vào và hàm trả về đúng sai
    // Mở rộng thêm: Toán logic, toán mệnh đề - câu phát biểu đúng sai
    // Có hàm mệnh đề - hàm nhận vào 1 đầu vào sau đó trả về 1 câu phát biểu đúng sai
    //hàm này đc gọi lạ hàm tiên đoán, hàm dự đoán, hàm mệnh đề, hàm đánh giá, hàm lượng giá, predicate - LOGIC vị tự

    class Program
    {
        static void Main(string[] args)
        {
            // Viết hàm nhận vào 1 con số gpa, trả về nó lớn hơn hay bằng 8
            Func<double, bool> check8V1 = gpa => gpa >= 8;

            Predicate<double> check8Final = gpa => gpa >= 8;
            //                  hàm         nhận vào
            //                              con gpa trả ra có đúng là nó lớn hơn 8 hay k

            Console.WriteLine("Final fantasy: " + check8Final(8));

            // LINQ trong COLLECTION, LIST toàn xài LAMBDA ! Filter DATA

            //LỆNH CUỐI CÙNG
            var x = 2004.715;

            var fx = (double a, double b, double c, double d) => a + b + c;
        }
    }
}


