using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookService
    {
        private BookRepository _repo = new();

        public List<Book> GetAllBooks()
        {
            return _repo.GetAll();
        }
    }
}
