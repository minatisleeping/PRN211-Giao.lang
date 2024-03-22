using Microsoft.EntityFrameworkCore;
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
        private BookManagement2023DbContext _context;
         public Book? GetBook(int id)
        {
            _context = new();
            //return _context.Books.FirstOrDefault(b => b.BookId == id);
            return _context.Books.Find(id);
        }

        public List<Book> GetAll()
        {
            _context = new();
            
            return _context.Books.Include(cat => cat.BookCategory).ToList();
        }

        public void Create(Book book) 
        {
            _context = new();
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public void Update(Book book) 
        {
            _context = new();
            _context.Books.Update(book);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            _context = new();
            var book = _context.Books.FirstOrDefault(b => b.BookId == id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        public List<Book>? Search(string keyword)
        {
            return null;
        }
    }
}
