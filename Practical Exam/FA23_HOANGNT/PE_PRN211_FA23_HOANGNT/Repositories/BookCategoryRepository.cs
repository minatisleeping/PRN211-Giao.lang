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
        private BookManagement2023DbContext _context;

        public List<BookCategory> GetAll()
        {
            _context = new();
            return _context.BookCategories.ToList();
        }
    }
}
