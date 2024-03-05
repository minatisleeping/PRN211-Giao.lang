namespace PassByDelegateV2
{
    // C#4: Hãy in ra các bài hát của taylor. Có 1 class lưu trữ các bài hát. Hãy gọi hàm từ Class
    //này để in. Dùng Delegate luôn

    public class Showbiz
    {

        //_backing fields, Properties, Ctor, Get/Set((), ToString() và các hàm khác
        //hàm và properties, _fields có thể là: public, private, protected. STATIC AND NON-STATIC
        public void PrintSongLyricThe1()
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

    //các Class ngang cơ nhau, ở chung namespace okie!
    //chung tập ti vật lí or khác tập tin vật lí ok luôn

    public class Program
    {
        static void Main(string[] args)
        {
            //C#4: gọi hàm từ class khác
            Console.WriteLine("C#4: call methods from another class");
            Action f = Showbiz.PrintSongLyricALAYLM;
            f();
            Showbiz song = new Showbiz();
            song.PrintSongLyricThe1();

        }
    }
}


