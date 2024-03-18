namespace Giaolang.LINQ.V2.StudentMgt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CheckMyListWithGpa();
            //CheckMyListWithGpaAndYob();
            //GetStudentsByAnyCondition();
            //GetStudentsByAddress();
            SearchStudents();
        }

        static void SearchStudents()
        {
            MyList myList = new MyList();
            //List<Student> result = myList.GetStudents(x => x.Address == "Bình Dương");
            
            List<Student> result = myList.GetStudents(x => x.Name.ToLower().Contains("dương") 
                                     || x.Address.ToLower().Contains("dương"));
            
            Console.WriteLine("The list of students contain 'Dương'");
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

        } 


        //hàm lẻ để query sinh viên
        static bool CheckStudentGpa8(Student x)
        {
            if (x.Gpa >= 8)
                return true;
            return false;
        }

        //hàm lẻ query student theo năm sinh và gpa
        //static bool CheckStudentGpa8AndYob2005(Student x)
        //{
        //    if (x.Gpa >= 8 && x.Yob >= 2005)
        //        return true;
        //    return false;
        //}

        //static bool CheckStudentGpa8AndYob2005(Student x) 
        //{
        //    return x.Gpa >= 8 && x.Yob >= 2005;              
        //}   //đằng nào biểu thức cũng trả true/false thì return luôn khỏi 
        //    //if vì if cũng chỉ để return true false

        static bool CheckStudentGpa8AndYob2005(Student x) =>       
                                                x.Gpa >= 8 && x.Yob >= 2005;
       


        //tui mún in danh sách sv ở BD
        static void GetStudentsByAddress()
        {
            MyList myList = new MyList();
            //List<Student> result = myList.GetStudents(x => x.Address == "Bình Dương");
            List<Student> result = myList.GetStudents(x => x.Address == "Bình Dương" || x.Address == "Long An");
            Console.WriteLine("The list of students is at BD & LA");
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

        }


        static void GetStudentsByAnyCondition()
        {
            MyList myList = new MyList();

            List<Student> result = myList.GetStudents(CheckStudentGpa8);

            Console.WriteLine("The list of students with gpa >= 8");
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("The list of students with gpa >= 8 & yob >= 2k5");
            foreach (var x in myList.GetStudents(CheckStudentGpa8AndYob2005))
            {
                Console.WriteLine(x);
            }

        }


        static void CheckMyListWithGpaAndYob()
        {
            MyList myList = new MyList();

            //List<Student> r = myList.GetStudentsByGpa();
            //for trực tiếp trên kq trả về thay vì for biến r cx vậy

            Console.WriteLine("The list of students with gpa >= 8 & yob >= 2005");
            foreach (var x in myList.GetStudentsByGpaAndYob())
            {
                Console.WriteLine(x);
            }
        }

        static void CheckMyListWithGpa()
        {
            MyList myList = new MyList();

            //List<Student> r = myList.GetStudentsByGpa();
            //for trực tiếp trên kq trả về thay vì for biến r cx vậy

            Console.WriteLine("The list of students with gpa >= 8");
            foreach (var x in myList.GetStudentsByGpa()) {
                Console.WriteLine(x);
            }
        }

    }
}