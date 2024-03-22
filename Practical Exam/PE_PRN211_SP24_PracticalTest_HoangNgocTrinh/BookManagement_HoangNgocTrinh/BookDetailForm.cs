using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_HoangNgocTrinh
{
    public partial class BookDetailForm : Form
    {
        //vì DetailForm cx là 1 class, nên nó có prop như bt. Hơn bt là nó là class có thể render (Bố/Cha clas Form của SDK lo phần render - mối quan hệ kế thừa 

        //public int     Yob { get; set; } = 2003;
        //               .Yob = ???
        public Book SelectedBook { get; set; } = null;
        //mặc định form này mở lên, ko có book nào cả
        //nếu mún có book thì phải
        //.SelectedBook = cuốn muốn gán vào!!!


        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //MỞ MÀN HÌNH DETAIL THÌ TA SẼ:
            //1. FILL ĐẦY CATEGORY DROPDOWN - LẤY DATA TỪ TABLE CATEGORY
            //2. NẾU LÀ EDIT 1 CUỐN SÁCH THÌ FILL DATA CỦA CUỐN SÁCH MÚN
            //   EDIT VÀO CÁC Ô TƯƠNG ỨNG
            //3. NẾU LÀ TẠO MỚI CUỐN SÁCH, THÌ CỨ ĐỂ MÀN HÌNH TRỐNG CHỜ USER NHẬP INFO - KO CẦN LÀM GÌ THÊM

            BookCategoryService cat = new BookCategoryService();

            //đổ full data vào cbo
            cboBookCategoryId.DataSource = cat.GetAllCategories(); //hàm số II

            //chọn cột để hiển thị trên cbo
            cboBookCategoryId.DisplayMember = "BookGenreType";

            //chọn cột để lấy value thực sự cần dùng - what you see is not what you get
            //Chọn Self Help dễ cho user -> code map sang value 5 của cột BookCategoryId, dùng làm FK đẩy vào table BOOK
            cboBookCategoryId.ValueMember = "BookCategoryId";

            //vi diệu
            //nhảy đến giá trị bất kì nào mình thích trong cbo
            //mặc định là đầu danh sách xổ 1 
            //cboBookCategoryId.SelectedValue = 5; //default với mình là sách Self Help  

            //CHECK HÀNG, CÓ PHẢI LÀ EDIT HAY KO
            //CHECK BIẾN SELECTEDBOOK COI CÓ ĐC SET KHÁC NULL KO
            //NẾU CÓ SÁCH THÌ FILL VÀO CÁC Ô
            if (SelectedBook != null)
            {
                //disable BookID
                txtBookId.Enabled = false; // cấm sửa Id ở mode Edit
                lblHeader.Text = "UPDATE A BOOK..";
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookName.Text = SelectedBook.BookName;
                txtDescription.Text = SelectedBook.Description;
                dtpPublicationDate.Text = SelectedBook.PublicationDate.ToString();
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtPrice.Text = SelectedBook.Price.ToString();
                txtAuthor.Text = SelectedBook.Author.ToString();
                cboBookCategoryId.SelectedValue = SelectedBook.BookCategoryId;  //1 2 3 4 5
                //tuỳ sách có cate gì thì jump đến số đó!!!

            } 
            else
            {
                lblHeader.Text = "ADD A NEW BOOK..";
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //logic: ta phải tạo ra 1 object Book rồi gửi cho Service
            //Service chuyển cho Repo
            //nhớ check mode: edit hay mode new để gọi đúng hàm repo
            //save xong thì phải đóng cửa sổ này lại
            //Refresh cái lưới bên kia để thấy data đã xuống db
            Book b = new Book() 
            {
                BookId = int.Parse(txtBookId.Text),
                BookName = txtBookName.Text,
                Description = txtDescription.Text,
                PublicationDate = dtpPublicationDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Price = double.Parse(txtPrice.Text),
                Author = txtAuthor.Text,
                BookCategoryId = int.Parse(cboBookCategoryId.SelectedValue.ToString())
            };

            BookService service = new();

            if (SelectedBook != null)
                service.UpdateBook(b);
            else
                service.CreateBook(b);

            Close();
            //sang kia refresh lưới
        }
    }
}
