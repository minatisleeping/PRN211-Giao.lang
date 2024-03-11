namespace LambdaExpression
{

    delegate void PlayNumberDelegate(int x);  //nhóm hàm nhận vào 1 con x, muốn làm gì với x thì làm
    //3 cách chơi hàm:
    //C1: làm 1 hàm tường minh - explicit, nhận x, làm gì đó, in ra kq - CÓ GHẾ TRONG QUÁN
    //C2: làm 1 hàm ẩn danh - anonymous method/function - implicit, éo thèm đặt tên hàm
    //                       éo thèm viết code riêng, tất cả gom cho thằng delegate, nick name, mày lấy code của tao, khỏi cần tên tao
    //C3: TỪ CÁCH 2 CẮT BỚT CODE DƯ THỪA!!! => LAMBDA EXPRESSION (CODE KHÁ GIỐNG EXPRESSION BODY KHI CÙNG XÀI => NHƯNG COI CHỪNG, KHÁC ĐẤY

    //CÓ CÂU: HÀM VÔ DANH RÚT GỌN CHỈ CÒN CÁI DÂY NỊT => BIẾN THÀNH BIỂU THỨC LAMDA 
    //        BIỂU THỨC LAMBDA LÀ HÀM VÔ DANH TRONG DELEGATE
    //        HÀM VÔ DANH KO HẲN LÀ LAMBDA NẾU VẪN VIẾT FULL {}
    //        LAMBDA GIỐNG EXPRESSION BODY VỀ KÍ HIỆU -=> VÀ SỰ LƯỢC BỚT
    //                     NHƯNG EXPRESSION BODY PHẢI FULL CẢ TÊN HÀM TỬ TẾ 

    internal class Program
    {
        static void Main(string[] args)
        {
            PlayNumberDelegate playNumber = MakeTriple; //hợp đồng luật sư - thân chủ
            playNumber(3);   //action gián tiếp

            //C2: LÀM BIẾNG ĐẶT CHỖ 1 HÀM TƯỜNG MINH, VÀO QUÁN KO NGỒI LẤY CAFE HOY
            //    TAKE AWAY, HỢP ĐỒNG LUẬT SƯ - THÂN CHỦ KO ĐỂ LẠI TÊN
            //    HÀM VÔ DANH ANONYMOUS FUNCTION/METHOD

            playNumber = delegate (int x)
                         {
                             Console.WriteLine($"{x}{x}{x}{x}");
                         }; //đừng quên chấm phẩy kết thúc lệnh gán hợp đồng

            playNumber(9);  //VÀNG 4 SỐ 9

            //C3: CHỈ CÒN CÁI DÂY NỊT. GHÉP 5 LẦN ĐẦU VÀO!!! BIỂU THỨC LAMDA
            playNumber = (int xxx) => Console.WriteLine($"{xxx} {xxx} {xxx} {xxx} {xxx}");
            playNumber(10);   //5 con 10 ghép qua dấu cách

            //C3: CÒN CÁI DÂY NỊT MỎNG
            playNumber = (a) => Console.WriteLine($"{a} {a} {a} {a} {a}");  //vòng lên định nghĩa ở delegate biết ngay (kiểu int, ko cần ghi kiểu, ghi tên biến đc òi)

            playNumber(68);   //5 con 68 ghép qua dấu cách

            //C3: CÒN CÁI DÂY NỊT MỎNG HƠN NỮA!!!

            playNumber = a => Console.WriteLine($"{a}-{a}-{a}-{a}-{a}-{a}");  //vòng lên định nghĩa ở delegate biết ngay (kiểu int, ko cần ghi kiểu, ghi tên biến đc òi)

            playNumber(6789);   //6 con 6789 ghép qua dấu -

            //VIẾT 1 HÀM IN RA MŨ 3 CỦA 1 CON SỐ ĐƯA VÀO, KO CHƠI HÀM LẺ, RỜI, KO CHƠI ANONYMOUS FULL MÀ CHƠI ANONYMOUS GIẢN LƯỢC ĐẾN TẬN CÙNG - LAMBDA EXPRESSION

            playNumber = ngocTrinh => Console.WriteLine($"{ngocTrinh}^3 = {Math.Pow(ngocTrinh, 3)}");
            playNumber(56);  //56^3 = 175.616 
            

        }
        //C1: HÀM TƯỜNG MINH
        static void MakeTriple(int n) => Console.WriteLine($"{n}{n}{n}");
        //                           expression body: hàm có 1 lệnh duy nhất, ko cần ngoặc hay return
        // 
    }
}
