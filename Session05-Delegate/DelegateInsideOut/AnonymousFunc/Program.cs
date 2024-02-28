namespace AnonymousFunc
{
    //khai báo class Delegate map vào/đại diện cho đám hàm void F(int), có vào ko ra
    //đại diện cho 2 hàm ở dưới luôn dò phù hợp format style

    delegate void PlayNumberDelegate(int x);  //map, đại diện, luật sư, sứ giả

    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Play methods with an input and return nothing-void");
        //    PlayNumberDelegate playNumber = CloneNumbers;  //nhân bản 3 lần
        //    //mún gọi CloneNumbers(5) phải đưa vào data 
        //    //playNumber biến đại diện = tên hàm gốc, thì biến đại diện cx đưa data vào như bản gốc
        //    playNumber(5);
        //    playNumber.Invoke(3);
        //    //gọi hàm 2 lần, với 2 tham số 5, 3

        //    //muốn gọi hàm bình phương, gọi mình nó, hay nối tiếp với hàm đã uỷ quyền trước đó tuỳ; dùng =; hoặc += tuỳ bạn
        //    Console.WriteLine("In ra bình phương");
        //    playNumber = PowerBy2Number;  //tớ playNumber là tên khác của cậu, nick
        //                                  //cam kết kết nối, chưa run(); CẤM KO () HIỂU LÀ RUN, MỚI UỶ QUYỀN CHƯA THỰC THI, THỰC THI CẦN () PHẢI SAU KHI UỶ QUYỀN; MỜI LUẬT SƯ, ĐỒNG Ý RỒI MỚI ACTION

        //    playNumber.Invoke(10);  //100
        //    playNumber(5);          //25

        //    //CHƠI HỆ MULTICAST 
        //    Console.WriteLine("Hệ multicast...");
        //    playNumber += CloneNumbers;  //Power() trước rồi Clone() sau
        //    playNumber(6);  //màn hình có kết quả gì???  6^2 = 36;
        //                    //                           666



        //}
        //Hàm mà sẽ đem đi cho thằng khác gọi, đặt nick name, thì hàm để ở đâu cx đc, miễn là phải thuộc về class, nếu là static thì chấm trực tiếp
        //                                 nếu là non-static thì new rồi mới chấm
        //OOP CĂN BẢN, ÔN LẠI CHO CHẮC

        //SÁNG SỚM NAY, VÀ HỒI NÃY MÌNH CHỈ HỌC HÀM VOID F()
        //BI GIỜ HỌC THÊM HÀM CÓ THAM SỐ

        //hàm nhận vào 1 con số, in ra con số đó 3 lần sát nhau
        static void CloneNumbers(int n) => Console.WriteLine($"{n}{n}{n}");

        //hàm nhận vào 1 con số, in ra bình phương của nó
        static void PowerBy2Number(int x)
        {
            //Console.WriteLine($"The {x}^ 2 = {x * x}");         //interpolation
            //Console.WriteLine("The " + x + "^2 = " + (x * x));  //ghép chuỗi
            Console.WriteLine("The {0}^2 = {1}", x, (x * x));     //place holder  %d 
        }

        //TUI MÚN CÓ HÀM NHẬN VÀO 1 CON SỐ NGUYÊN NHƯNG: IN RA, LẶP LẠI THÀNH 4 SỐ
        //NHẬN VÀO 9 -> IN RA 9999
        //C1: TẠO HÀM 4 SỐ CHÍN NHƯ 3 SỐ Ở TRÊN - TẠO HÀM TƯỜNG MINH - EXPLICIT
        static void NgocTrinh(int n) => Console.WriteLine($"{n}{n}{n}{n}");

        //C2: DÙNG ANONYMOUS FUNCTION: THIẾT KẾ 1 HÀM KO THÈM CÓ TÊN, CHỈ CẦN ĐẦU VÀO TUÂN THEO ĐỊNH DẠNG CỦA DELEGATE ĐÃ KHAI BÁO; VIẾT CODE NGAY TRÊN CÂU LỆNH GÁN HỢP ĐỒNG UỶ QUYỀN

        //static void Main(string[] args)
        //{
        //    //   void F(int x)
        //    //PlayNumberDelegate playNumber = NgocTrinh; //{CODE Ở PHÍA TRÊN}
        //    //playNumber(9);
        //    PlayNumberDelegate playNumber = delegate (int n)
        //                                    {
        //                                        Console.WriteLine($"{n}{n}{n}{n}");
        //                                    };  //ĐEM CODE NGAY ĐÂY, LÀM BIẾNG LÀM HÀM RỜI CÓ
        //                                        //TRƯỚC | TÊN HÀM KO QUAN TRỌNG, ĐẶT LÀ GÌ CX ĐC
        //                                        //CODE LÀ QUAN TRỌNG VÌ DÍNH ĐẾN XỬ LÍ
        //                                        //CHỮ DELEGATE Ở LỆNH GÁN CHÍNH LÀ THAY CHO
        //                                        //CHO 1 TÊN HÀM LẼ RA VIẾT RIÊNG CHỖ KHÁC
        //                                        //
        //    playNumber(9); //HÀM KO CÓ TÊN, THÌ SAO GỌI ĐC, ĐƯA TÊN ĐÓ CHO THẰNG NICK DELEGATE GIỮ GIÙM; BẢN CHẤT HÀM VẪN CÓ TÊN, LẤY TÊN NICK NAME RA DÙNG
        //                   //HÀM KO CÓ TÊN, MAY QUÁ, CÓ NICK ĐỂ GỌI, GỌI HÀM TRỞ LẠI QUỸ ĐẠO BÌNH THƯỜNG, ÍT NHẤT PHẢI CÓ 1 TÊN, HOẶC 2 TÊN UỶ QUYỀN
        //                   //EM SINH RA ÉO CÓ TÊN, UỶ QUYỀN TÊN LUÔN - ANONYMOUS FUNCTION
        //                   //HÀM VÔ DANH, GỌI EM QUA NICK NAME - ON THE GO - TAKE A WAY
        //                   //HÀM CƠ ĐỘNG NGAY Ở CHỖ GÁN HỢP ĐỒNG UỶ QUYỀN


        //}

        static void Main(string[] args)
        {
            //TUI MÚN CÓ HÀM MŨ 5, 10^5 = 10X10X10X10X10 = 10.000
            //C1: LÀM HÀM BÌNH THƯỜNG, MUA CHỖ NGỒI TRONG QUÁN, CỐ ĐỊNH 1 HÀM NHƯ Ở TRÊN
            //C2: ANONYMOUS, VIẾT CODE GÁN LUÔN CHO NICK NAME
            //PlayNumberDelegate playNumber = delegate (int a)
            //                                {
            //                                    Console.WriteLine($"{a}^5 = {a * a * a * a * a}");
            //                                };

            PlayNumberDelegate playNumber = delegate (int a)
                                            {
                                                Console.WriteLine($"{a}^5 = {Math.Pow(a, 5)}");
                                            };
            playNumber(10); //10.000
        }

    }
}
