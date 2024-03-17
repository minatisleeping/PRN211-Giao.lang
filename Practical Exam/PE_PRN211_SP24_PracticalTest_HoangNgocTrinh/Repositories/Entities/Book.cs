using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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

        //ENTITY CLASS MAP TRỰC TIẾP XUỐNG TABLE
        //JAVA: POJO PLAIN OLD JAVA OBJECT
        //C#  : POCO PLAIN OLD CSHARP OBJECT
        //OBJECT THUẦN CHỦNG NGUYÊN BẢN CHỈ CHỨA INFO VÀ GET/SET

        //1. STYLE CODE FIRST, GÕ CLASS NÀY XONG, DÙNG OR-MAPPING FRAMEWORK
        //HIBERNATE, EF CORE - ENTITY FRAMEWORK CORE
        // JAVA                  C#
        //   ĐỂ TỰ ĐỘNG TẠO RA DB VÀ TABLE

        //2. STYLE DATABASE FIRST: KO CẦN GÕ CLASS NÀY, DÙNG OR-MAPPING FRAMEWORK HIBERNATE, EF CORE SUY NGƯỢC TỪ TABLE RA CLASS - ENTITY

        //BÀI THI PE, MÌNH DÙNG STYLE 2 - TỨC LÀ CÓ SẴN DB .SQL => SUY RA CLASS
        //THỨ 6 SẼ CÓ - CẤM VẮNG MẶT 

        public override string ToString() => $"{BookId} | {BookName} | {Description}";
        
    }
}
