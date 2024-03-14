using Repositories.Entities;

namespace Services
{
    //3-layer Architecture:
    //UI-Forms ----  Services -------- Repositories -------------- DB
    //MainUI   ---- BookService   BookRepository(Book Entity)   Book Table
    //  request/response
    //  đưa data xuống db
    //  lấy data từ db show                          CRUD table thực sự
    //  RAM                                          DB ĐĨA CỨNG HDD/SSD
    public class BookService
    {
        // Class này trung chuyển dữ liệu giữa Forms UI và CSDL
        // Nó chữa data trong RAM, xử  lí mọi thứ thuật toán nếu cần rồi đẩy lên UI
        //or cất xuống db
        //chứa list các Book đọc từ db và show lên UI
        //chứa info cuốn sách lấy từ màn hình UI dự định update xún db

        // Thường sẽ chứa các hàm CRUD nhưng chỉ trong RAM - LINQQ có thể nhảy vào

        //giả bộ đã đọc data từ db lên rồi, giờ show ra màn hình UI
        //tạm thời hard-codede danh sách các cuốn sách trong RAM
        // bữa tới học cách lấy từ db thực sự
        //lấy xong thì cũng phải có n cuốn sách trả về trong RAM

        public List<Book> GetAllBooks()
        {
            // gọi Repository, chính xác là gọi Class BookRepository trả về sách từ db
            List<Book> list = new List<Book>();
            list.Add(new Book() { BookId = 1, BookName = "Đời ngắn thì tranh thủ ngủ đi", Author = "Mai Minh Nhật"});
            list.Add(new Book() { BookId = 2, BookName = "Đời là bể khổ - qua được bể khổ là qua đời", Author = "minattt" });
            list.Add(new Book() { BookId = 3, BookName = " Tủi trẻ chưa trải sự đời ", Author = "himinat" });
            return list;
        }
    }
}
