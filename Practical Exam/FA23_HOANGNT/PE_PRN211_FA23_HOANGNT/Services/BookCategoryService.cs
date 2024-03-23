using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryService
    {
        BookCategoryRepository _repo;

        public List<BookCategory> GetAllCategories()
        {
            _repo = new();
            return _repo.GetAll();
        }
    }
}
