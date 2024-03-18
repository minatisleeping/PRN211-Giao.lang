using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Entities;
using System.Net.Http.Headers;

namespace TestManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HoangNgocTrinhContext context = new HoangNgocTrinhContext();
            List<Book> arr = context.Books.ToList(); // convert toàn bộ sách về dạng List
            //1. In ra tất cả sách
            //arr.ForEach(x => Console.WriteLine(x.BookId + " | " + x.BookName + " | " + x.PublicationDate));

            //2. In ra tất cả sách thuộc chủ đề 5
            arr.ForEach(x =>
            {
                if (x.BookCategoryId == 5)
                {
                    Console.WriteLine(x.BookId + " | " + x.BookName + " | " + x.PublicationDate);
                }
            });
        }
    }
}
