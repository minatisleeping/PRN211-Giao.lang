using StudentManager.Entities;
using StudentManager.Services;

//in Java: import studentmanager.entities.*; 
using System.Net.Http.Headers;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cabinet seBox = new Cabinet();
            Cabinet bizBox = new Cabinet();

            seBox.AddNewProfile("SE1", "An", "an@", 2003, 8.6);
            seBox.AddNewProfile("SE2", "Binh", "binh@", 2004, 6.8);

            bizBox.AddNewProfile("SS1", "Cuong", "cuong@", 2005, 8.8);
            bizBox.AddNewProfile("SS2", "Dung", "dung@", 2006, 6.6);

            Console.WriteLine("The Biz students");
            bizBox.PrintStudentList();

            Console.WriteLine("The SE students");
            seBox.PrintStudentList();

            //<Student>   <Lecture>

            //PlayWithObjectArray();
            Console.ReadLine();
        }

        //CHALLENGE AT HOME:
        //PRINT OUT THE STUDENT LIST BY NAME IN ASCENDING ORDER
        //PRINT OUT THE STUDENT LIST BY GPA IN DESCENDING ORDER
        //PRINT OUT THE STUDENT LIST BY YOB IN ASCENDING ORDER 
        static void PlayWithObjectArray() {
            //WE WILL STORE MUTPLE STUDENT PROFILES
            //there are two ways to store multiple objects
            //1. Declare concrete variable/pointer - khai báo biến lẻ
            //Student s1, s2, s3, s4, s5...;
            //assign the value for each variable by using new Student(...)
            //s1 = new Student() {Id = "SE1", Name = "An"};
            //s2 = new Student() ...

            //2. Using Array, Collection (List, ArrayList, Set, Map...)
            //int[] arr = new int[10];
            Student[] arr = new Student[10]; //[] to declare multiple variables, not actual value to store

            //arr[0] ~~~~ Student s1;
            //arr[1] ~~~~ Student s2;

            //store the Student value, new Student(...) {...}
            arr[0] = new Student();
            arr[1] = new Student() { Id = "SE10", Name = "An", Email = "an@...", Yob = 2000, Gpa = 10.0}; //object initializer
            //named arg: (id : ???, name : ???) -> must use with parameter-contructor - constructor with parameters 
            arr[2] = new Student() { Id = "SE50", Name = "Binh", Email = "binh@...", Yob = 2005, Gpa = 5.0 };

            arr[3] = new Student() { Id = "SE40", Name = "Dung", Email = "dung@...", Yob = 2004, Gpa = 4.0 };

            arr[4] = new Student() { Id = "SE80", Name = "Cuong", Email = "cuong@...", Yob = 1998, Gpa = 8.0 };

            Console.WriteLine("The student list printed by using traditional for");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]); //call ToString() in background
            }


        }
        static void PlayWithValueTypeArrayV2()
        {
            //we define an array and init all of its values at the same time
            //Student s = new Student() {Id = "SE1", Name = "An"...};

            int[] arr = { 5,    10,    15,    20, 25, 30, 35, 40, 45, 50 };
            //we have an array, we have declared 10 int variables
            //         arr[0] arr[1] arr[2] arr[3]...
            //we init, assign the value for each int variable within the array
            //khai báo biến, gán luôn giá trị cho 10 biến int trong mảng
            //arr: general variable to manage all of its members, its members also are variables, a list of variables as normal

            //arr: biến má mì, biến mama tổng quản quản lí 10 đứa dưới quyền

            //using for each like in the Math subject (in highschool) to scan the whole of the array,
            //what ever you declare an array, i dont care how you declare an array, i know that an array is a set of values, i use for each for the array in overall
            Console.WriteLine("The array has values of");
            foreach (int x in arr) 
            {       //int x = arr[0], x = arr[1],  x = arr[2], ...     
                Console.WriteLine(x); //x will take each of value in array
            }
            foreach (var x in arr)
            {       //int x = arr[0], x = arr[1],  x = arr[2], ...     
                //Console.Write(x + " "); //x will take each of value in array
                //Console.Write($"{x} ");
                Console.Write("{0} ", x);
            }

        }

        //work with multiple values, multiple objects
        //how to manage many objects/values in an effectively way
        //ARRAY                      | COLLECTION 
        //EASY TO USE                //EASY TO USE (A LITTLE TECHNIC REQUIRED
        //SOME LIMITATION            //EFFECTIVE 
        //Java: there are two different data type - the way we store data
        //1. PRIMITIVE DATA TYPE: int, long, double, char, float, boolean...
        //      TAKE/CONSUME ONLY ONE RAM/MEMORY BLOCK TO STORE VALUE


        //2. OBJECT DATA TYPE/REFERENCE DATA TYPE/"POINTER"
        //          TAKE/CONSUME TWO MEM. BLOCKS TO STORE VALUE
        //          one: variable/pointer
        //          one: object, the new segment to store actual value of an object
        // String, File, Math, Random, Exception, Statement, ArrayList, Dog, Cat, Person, Student....

        //============================

        //C# OFFERS TWO WAY TO STORE VALUE, TWO DATA TYPE LIKE JAVA
        //1. VALUE DATA TYPE (~~~ PRIMITIVE): int, long, double, char, float, bool...
        //2. REFERENCE DATA TYPE - THE SAME WITH JAVA:
        // String, string, File, Math, Random, Exception, Statement, ArrayList....
        static void PlayWithValueTypeArray()
        {
            //i want to store 10, or 100, 1000 numbers, how???
            //i want to compute the sum of them???

            //1st answer: declare abitrary/concrete variables, KHAI BÁO BIẾN LẺ
            //            RETAILS - BÁN LẺ
            int a1 = 5, a2 = 10, a3 = 15, a4 = 20, a5 = 25, b = 30, c = 35, d = 40, e = 45, f = 50;
            //how to store 1000 numbers??? you have to manually declare variables
            int sum = a1 + a2 + a3 + a4 + a5 + b + c + d + e + f;

            //2nd answer: DECLARE AN ARRAY, KHAI BÁO SỈ - 1 LẦN ĐC NHIỀU
            //A SET OF, A LIST OF, A BLOCK OF - 1 DÃY      WHOLE SALES: BÁN SỈ

            int[]      arr = new int[100];
            //Student  s   = new Student();
            //         s.Id { get; set; }    
            //we have 10 variables already
            //arr[0]        arr[1]   arr[2]   arr[3]  arr[4] .... arr[8]  arr[9]
            // a1            a2        a3       a4                  e       f

            //THE NAME OF A VARIABLE FOR NOW A LITTLE COMPLEX, WITH []
            //[INDEX, THE ORDER OF EACH VARIABLE, WE COUNT THE ORDER OF EACH VAR
            //FROM 0, 1, 2]
            //[0]: 1st var
            //[1]: 2nd var
            //...
            
            arr[0] = 5;   //a1 = 5
            arr[1] = 10;  //a2 = 10
            arr[2] = 15;  //a3 = 15
            arr[3] = 20;  //a4 = 20
            arr[4] = 25;

            Console.WriteLine("The array has values of: ");

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9]);

            Console.WriteLine($"{arr[0]} {arr[1]} {arr[2]} {arr[3]} {arr[4]} {arr[5]} {arr[6]} {arr[7]} {arr[8]} {arr[9]}");

            Console.WriteLine("The array printed by using traditional for");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                //Console.Write("{0} ", arr[i]);
                //Console.Write($"{arr[i]} ");
            }

            //for each, delegate!!!! 
            //generic ArrayList<Student>







        }


    }
}
