using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookCategoryRepository
    {
        // vì chơi trực tiếp với db nên phải gọi thằng DbContext
        private HoangNgocTrinhContext _context;

        public List<BookCategory> GetBookCategories()
        {
            //hàm select * from BookCategory
            _context = new();
            return _context.BookCategories.ToList();
        }
    }
}
