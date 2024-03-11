namespace PassByDelegateV1
{
    //C#1: Viết hàm in ra các bài hát của Taylor Swift. Mỗi bài 1 hàm
    //Solution: Dùng hàm lẻ bình thường

    class Program
    {
        static void Main(string[] args)
        {
            //PrintLyricsThe1();
            //PrinLyricsAsLongAsULoveMe();
            // 2 hàm cùng style là void F() -> thuộc nhóm Action

            //C#2:
            Console.WriteLine("C#2: The song lyrics printed by using delegate");
            Action f = PrintLyricsThe1;
            f += PrinLyricsAsLongAsULoveMe;
            f();

            //C#3: In ra bài hát thứ 3 của Taylor - Dùng ANONYMOUS | LAMBDA
            f = delegate ()
            {
                Console.WriteLine("Thuỷ Triều - Hùng MasterD");
                Console.WriteLine(@"Trao em tình yêu, trao đi hết luôn cho nàng
Chìm đắm say khung trời hai ta giữa chốn mơ màng
Mắt nhắm, tay đan, tan trong nỗi nhớ vô vàn
Nhớ em dù cho cạnh bên, anh lại càng yêu thêm
Á-a-a
M-m-m-màu mắt môi em, anh chìm sâu
Lắng nghe thêm khi ta chạm nhau
Vầng trăng ghé thăm, thủy triều lên
Hai ta ước đêm nay khó quên\n");
            };
            f.Invoke();

            f += () =>
            {
                Console.WriteLine("Ngày ấy (Yesterday) -  Em Ellata");
                Console.WriteLine(@"Ngày ấy

Em cứ vô tư vồ lấy

Ánh nắng ôm trên gò má em tươi sáng thơ ngây

Và tiếng yêu thương vẫn ở đây

Ngày ấy

Khi gió đua len vào tay

Khi em chưa đưa mình cuốn trong cơn sóng loay hoay

Bừng sáng khi nghe lá lung lay

Ùa về, gió mênh mang

Hôn nhẹ vào mơ màng

Để em thêm chút an lòng

Làm ấm êm phút mơ mộng

Lùi về phía sau lưng

Cho mình nhìn thấy rằng lần cuối khi em nở nụ cười

Vòng xoay thời gian cuốn em về ngày hôm qua

Để nhìn đôi mi em dịu dàng cười cong cong

Để dù một giây phút em tôi nhận ra trong lòng

Một em bé lang thang kiếm tìm mình
");
            };

            f();
        }

        static void PrinLyricsAsLongAsULoveMe()
        {
            Console.WriteLine("The song As Long as You Love Me - by Justin Bieber\n");
            Console.WriteLine(@"As long as you love me
We could be starving
We could be homeless
We could be broke
As long as you love me
I'll be your platinum
I'll be your silver
I'll be your gold");
            Console.WriteLine();
        }

        static void PrintLyricsThe1() 
        {
            Console.WriteLine("The song The 1 - by Taylor Swift\n");
            Console.WriteLine(@"I'm doing good, I'm on some new shit
Been saying ""yes"" instead of ""no""
I thought I saw you at the bus stop, I didn't though
I hit the ground running each night
I hit the Sunday matinée
You know the greatest films of all time were never made");
            Console.WriteLine();
        }

    }
}



