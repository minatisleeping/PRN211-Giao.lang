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

        public List<Book> SearchBook(string keyword)
        {
            return _repo.GetAll().Where(b => b.BookName.ToLower().Contains(keyword.ToLower()) ||
                                             b.Description.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public Book? GetABook(int id) 
        {
            return _repo.GetBook(id);
        }

        public void AddABook(Book b)
        {
            _repo.Create(b);
        }

        public void UpdateABook(Book b)
        {
            _repo.Update(b);
        }
    }
}
