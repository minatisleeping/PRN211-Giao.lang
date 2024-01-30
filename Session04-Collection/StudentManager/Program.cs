using StudentManager.Entities;

namespace StudentManager;
class Program
{
    static void Main(string[] args)
    {
        PlayWithValueTypeArray();





        Console.ReadLine();
    }
    //work with multiple values, multiple objects
    //how to manage manage objects/values in an effectively way
    //ARRAY                  | COLLECTION
    //EASY TO USE             - EASY TO USE (A LITTLE TECHNIQUE REQUIRED)
    //SOME LIMITATION         - EFFETIVE
    //Java: there are two different data type - the way we store datatype
    //1. PRIMITIVE DATA TYPE: int, long, double, char, float, boolean,..
    // TAKE ONLY ONE RAM/MEMORY BLOCK TO STORE VALUE

    //2. OBJECT DATA TYPE/REFERENCE DATA TYPE/"POINTER"
    //      TAKE/CONSUME TWO MEM. BLOCK TO STORE VALUE
    //      one: variable/pointer
    //      one: object, hte new segment to store actual value of an object
    // String, File, Math, Random, Exception, Statement, ArrayList,..

    // ==================================

    //C# offers two way to store value, two data type like Java
    //1. VALUE TYPE (~~~ PRIMITIVE): int, long, double, char, float, bool,..
    //2. REFERENCE DATA TYPE - THE SAME WITH JAVA:
    // String, string, File, Math, Random, Exception, Statement, ArrayList,..
    static void PlayWithValueTypeArray()
    {
        //I want to store 10, or 100, 1000 numebers, how??
        //I want to compute the sum of them ??

        //1st answer: declare abitrary/concrete variables, KHAI BÁO BIẾN LẺ
        //            RETAILES: BÁN LẺ
        int a1 = 5, a2 = 10, a3 = 15, a4 = 20, a5 = 25, b = 30, c = 35, d = 40, e = 45, f = 50;

        //how to store 1000 numbers?? you have to manually declare variables
        int sum = a1 + a2 + a3 + a4 + a5 + b + c + d + e + f;

        //2nd answer: DECLARE AN ARRAY, KHAI BÁO SỈ - 1 LẦN ĐƯỢC NHIỀU
        //A SET OF, A LIST OF, A BLOCK OF - 1 DÃY   WHOLE SALES: BÁN SỈ

        int[] arr = new int[10];
        //we have 10 variables already
        //arr[0]        arr[1]  arr[2]  arr[3] arr[4] ... arr[8] arr[9]
        //a1            a2      a3      a4     a5         e      f

        //THE ANME OF A VARIABLE FOR NOW A LITTLE COMPLEX WITH []
        //[INDEX, THE ORDER OF EACH VARIABLE, WE COUNT THE ORDER OF EACH VAR FROM 0, 1, 2]
        //[0]: 1st var
        //[1]: 2nd var
        //...

        arr[0] = 5;     //a1 = 5
        arr[1] = 10;    //a2 = 5
        arr[2] = 15;    //a3 = 5
        arr[3] = 20;    //a4 = 5
        arr[4] = 25;    //a5 = 5

        Console.WriteLine("The array has values of: ");
        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} ", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9]);

        Console.WriteLine($"{arr[0]} {arr[1]} {arr[2]} {arr[3]} {arr[4]} {arr[5]} {arr[6]} {arr[7]} {arr[8]} {arr[9]} ");

        Console.WriteLine("The array printed by using traditional for");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
            //Console.Write("{0} ", arr[i]);
            //Console.Write($"{arr[i]} ");
        }

        //NEXT CLASS: DELEGATE, fore/each
        //generic ArrayList<Student>
    }
}

