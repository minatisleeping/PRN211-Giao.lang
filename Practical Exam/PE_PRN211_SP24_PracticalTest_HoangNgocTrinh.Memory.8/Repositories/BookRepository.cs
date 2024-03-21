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
        // class này chơi trực tiếp với SQL Server qua DBContext (có sẵn CS)
        //Class này sẽ bị gọi bởi Class BookService
        // UI <--> BookService <--> BookRepository <--> DbContext <--> TABLE
        // [1]        [2]                [3]
        //UI phải khai báo Service
        // Service phải khai báo Repo
        // Service khai báo Repo
        // Repo khai báo DBContext
        // DBContext khai báo ConnectionString

        // ta ở đây bị SERVICE gọi
        // ta ở đây đi gọi DBContext
        // ta cung cấp các hàm CRUD TABLE BOOK cơ bản
        // AddBook() UpdateBook() DeleteBook() GetBooks() Get() lấy 1 cuốn

        private BookManagementTrialTestSp24Context _context; // (*/để ý chỗ này)

        public List<Book> GetBooks()
        {
            _context = new BookManagementTrialTestSp24Context(); // ở trên mới khai báo chưa new nên giờ phải new, quên là ăn l
            return _context.Books.ToList();
        }
    }
}
