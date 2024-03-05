namespace PassByDelegateV3
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //C#5: gọi 2 hàm in 2 bài hát qua tham số hàm ! NEW !!
        //    PrintSongLyricALAYLM();
        //    PrintSongLyricThe1();   //style Action cho cả 2

        //    Action f = PrintSongLyricThe1;
        //    f = PrintSongLyricALAYLM;
        //    f = () => { };

        //    // BIẾN DELEGATE = HÀM NÀO ĐÓ CỤ THỂ CÓ SẴN, = 1 BIỂU THỨC LAMBDA
        //    //               = 1 ĐOẠN CODE NÀO ĐÓ
        //    // ĐIỀU GÌ XẢY RA NẾU, KHAI BÁO THAM SỐ CỦA HÀM LÀ 1 DELEGATE??
        //    // tên hàm & code tương ứng đc pass vào 1 hàm khác !!!

        //    // int a = 10; void f(int a)
        //    //                             Đưa vào 1 con giá trị để gán cho a
        //    //                             do a là con số nguyên

        //    //                      void F(Action )

        //    f();
        //}

        public static void Main(string[] args)
        {
            Action f = PrintSongLyricThe1;
            f += PrintSongLyricALAYLM;
            PrintSongs(f);

            //C#5: hãy in tiếp bài hát August, in 1 mình cũng được
            // Cấm chơi hàm lẻ, hãy xài PrintSongs()

            f = () =>
            {
                Console.WriteLine("The song August - by Taylor Swift");
                Console.WriteLine("I never needed anything more..\n");
            };
            Console.WriteLine("C#5: PASS DELEGATE AS PARAMETER");
            PrintSongs(f);

            //C#6: In bài hát Is it over now?
            //Console.WriteLine("C#6: PASS DELEGATE AS PARAMETER DIRECTLY IN ()");
            //PrintSongs(() => { });
            //PrintSongs(delegate () {
            //    Console.WriteLine("The song Is it over now? - by Taylor Swift");
            //    Console.WriteLine("The slept all alone (uh-huh)");
            //});

            //C#7: Viết và in ra các số từ 1 ... 1000

            // DÙng hàm PrintSongs() vãi !
            PrintSongs(delegate () {
                Console.WriteLine("The list of numbers from 1..1000");
                for (int i = 1; i < 1001; i++)
                {
                    Console.WriteLine(i + " ");
                    if (i == 1000) Console.WriteLine();
                }
            });
        }

        static void PrintSongs()
        {
            PrintSongLyricALAYLM();
            PrintSongLyricThe1();
        }

        static void PrintSongs(Action f)
        {
            f();    // run hàm f() nào đó, LUẬT SƯ đang nói
                    // nói cho thân chủ nào, thì lúc chạy PrintSongs(đưa vào THÂN CHỦ)
            //PrintSongLyricALAYLM();
            //PrintSongLyricThe1();
        }

        public static void PrintSongLyricThe1()
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

        public static void PrintSongLyricALAYLM()
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
    }
}


