using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public string PublicationDate { get; set; }

        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public int BookCategoryId { get; set; }

        // ENTITY CLASS map trực tiếp xuống table
        // Java: POJO - Plain Old Java Object
        // C#  : POCO - Plain Old CSharp Object
        // Object thuần chủng nguyên bản chi3 chữa info và get/set

        //1. Style CODE FIRST, gõ Class này xong, dùng OR-MAPPING framework
        //HIBERNATE, EF CORE - ENTITY FRAMEWORK CORE
        //JAVA
        // ĐỂ TỰ ĐỘNG TẠO RA DB VÀ TABLE

        // 2. Style DATABASE FIRST: K càn gõ  Class này, dùng OR-MAPPING
        //framework HIBERNATE, EF CORE suy ngược  từ Table ra Class - ENTITY

        // Bài thi Pe, mình dùng style2 - tức là có sẵn db .sql => suy ra Class
    }
}
