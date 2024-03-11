using Repositories.Entities;

namespace Services
{
    public class Cabinet<T> // cái Tủ truyền thống có nhiều ko gian lưu trữ chính là mảng của gì đó: SV, GV, NV,..
                         // cái Tủ có CRUD trên data bên trong nó, mảng gì gì đó 
    {
        const int MAX = 300;
        const int MIN = 0;
        //private Student[] _listStu = new Student[MAX];
        //private Lecturer[] _listLec = new Lecturer[MAX];

        // T: Type nào đó mình muốn dùng
        // VD: Cabinet<Student> box = new Cabinet<Student>()
        // VD: Cabinet<Lecturer> box = new Cabinet<Lecturer>()
        // Kĩ thuật coi DATA TYPE là tham số, hàm, Class nhận vào tham số mà là 1 DATA TYPE
        // void F(int n)
        // void F(T x) -> F(<Dog> x)
        // DATA TYPE IS USED  AS A PARAMETER, KĨ THUẬT GENERIC NHƯ BÊN JAVA KHI XÀI LIST, ARRAYLIST
        // Class thiết kể tổng quát với nhiều lại DATA TYPE!!!

        private T[] _list = new T[MAX];
        private int _count = MIN;

        public void AddItem(T item)
        {
            // TODO: check tràn mảng
            // Mảng FIXED kích thược, cấm vượt biên
            if (_count >= MAX) {
                Console.WriteLine("Tràn mảng rùi bạn oiii :( ");
            }
            _list[_count] = item;
            _count++;
        }

        public void PrintAll()
        {
            // chơi với mảng k for đến cuối vì sẽ  gặp trống nếu mảng chưa đầy
            Console.WriteLine($"There is/are {_count} item(s)  in the list: ");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]);
            }
        }

    }
}

