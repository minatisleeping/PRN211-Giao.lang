using Repositories.Entities;

namespace Services
{
    public class Cabinet<T> //Type - data type as a parameter - GENERIC
        //Java: List<Student> list = new ArrayList<Studen>();
        //Cabinet<Student> seBox = new Cabinet();
        //Cabinet<Lecturer> seBox = new Cabinet();
        //
    {
        //private Student[] _list1 = new Student[300];
        //private Lecturer[] _list2 = new Lecturer[300];
        //private int _count1 = 0;
        //private int _count2 = 0;

        private T[] _list1 = new T[300];

    }
}
