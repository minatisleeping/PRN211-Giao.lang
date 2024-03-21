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
        //CUNG CẤP DATA CHO FORM, THỰC RA LÀ CUNG CẤP DATA CHO CÁI DROPDOWN, BẤM XỔ, COMBOX
        //LẼ RA PHẢI LẤY TẤT CẢ CATEGORY TỪ DB - NHƯNG TẠM THỜI HARD-CODED TRƯỚC, ĐỂ MAI TÍNH...
        public List<BookCategory> GetAllCategories()
        {

            ////TODO: Gọi class BookCategoryRepository để lấy toàn bộ danh mục phân loại sách từ DB
            ////Call class BookCategoryRepository to retrieve all book categories from DB

            List<BookCategory> arr = new List<BookCategory>();

            arr.Add(new BookCategory()
            {
                BookCategoryId = 1,
                BookGenreType = "Fiction",
                Description = "Fiction is any creative work, chiefly any narrative work, portraying individuals, events, or places that are imaginary, or in ways that are imaginary."
            });

            arr.Add(new BookCategory()
            {
                BookCategoryId = 2,
                BookGenreType = "Science",
                Description = "Science fiction is a genre of speculative fiction, which typically deals with imaginative and futuristic concepts such as advanced science and technology, space exploration, time travel, parallel universes, and extraterrestrial life."
            });

            arr.Add(new BookCategory()
            {
                BookCategoryId = 3,
                BookGenreType = "Historical Fiction",
                Description = "Historical fiction is a literary genre in which the plot takes place in a setting related to the past events, but is fictional."
            });

            arr.Add(new BookCategory()
            {
                BookCategoryId = 4,
                BookGenreType = "Finance",
                Description = "Finance is a field that deals with the study of investments. It includes the dynamics of assets and liabilities over time under conditions of different degrees of uncertainty and risk. Finance can also be defined as the science of money management. Finance aims to price assets based on their risk level and their expected rate of return."
            });

            arr.Add(new BookCategory()
            {
                BookCategoryId = 5,
                BookGenreType = "Self Help",
                Description = "The one that is written with the intention to instruct its readers on solving personal problems"
            });

            return arr;
        }
    }
}
