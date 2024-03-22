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

        public void CreateBook(Book b) //new Book ở đâu đó rồi đẩy xuống đây - do EF chơi với object
        {
            _hoangNgocTrinhContext = new();
            _hoangNgocTrinhContext.Books.Add(b); //thêm mới là Add(b)
            _hoangNgocTrinhContext.SaveChanges(); // insert  into Book values(..)
            //có thể bắt thêm lỗi trùng key
            //ChatGPT: how to handle/capture primary key duplication when using Entity Framework core in C#
            //in case create new Book in Book Management app
        }

        public void RemoveBook(Book b) //new Book ở đâu đó rồi đẩy xuống đây - do EF chơi với object
        {
            _hoangNgocTrinhContext = new();
            _hoangNgocTrinhContext.Books.Remove(b); //thêm mới là Add(b)
            _hoangNgocTrinhContext.SaveChanges(); // == DELETE FROM BOOK WHERE BookId
        }
    }
}
