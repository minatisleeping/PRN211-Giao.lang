using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepository
    {
        // gọi DBContext để chơi trực tiếp DB
        //Class này chứa các hàm CRUD cơ bản với table Book
        //sum, avg,.. để cho Services lo

        private HoangNgocTrinhContext _hoangNgocTrinhContext;

        public List<Book> GetBooks()
        {
            //hàm select * from Book
            _hoangNgocTrinhContext = new(); //new viết ngắn gọn
            return _hoangNgocTrinhContext.Books.ToList();
        }

       public void UpdateBook(Book b) //new Book ở đâu đó rồi đẩy xuống đây - do EF chơi với object
        {
            _hoangNgocTrinhContext = new();
            _hoangNgocTrinhContext.Books.Update(b); //thêm mới là Add(b)
            _hoangNgocTrinhContext.SaveChanges(); // sách đã vào csdl rồi
        }
    }
}
