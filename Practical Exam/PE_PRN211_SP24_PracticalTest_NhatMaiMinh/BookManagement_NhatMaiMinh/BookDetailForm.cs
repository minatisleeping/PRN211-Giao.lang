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

namespace BookManagement_NhatMaiMinh
{
    public partial class BookDetailForm : Form
    {
        //vì BookDetailForm cũng là 1 class nên nó có prop như bt là nó là class có thể render
        //(Bố/Cha class Form của SDK lo phần render - mối quan hệ kế thừa)
        //public int Yob = 2003;
        public Book SelectedBook { get; set; } = null;
        // mặc định Formm này mở lên thì k có book nào cả
        // nếu muốn có Book thì phải .SelectedBook = cuốn mún gán vào !!!
        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            // Mở màn hình detail thì ta sẽ:
            // 1. Fill đầy Category DROPDOWN - lấy data từ table Category
            // 2. Nếu là edit 1 cuốn sách thì fill data của cuốn sách muốn edit vào các ô tương ứng
            // 3. Nếu là tạo mới cuốn sách thì cứ để màn hình trống, chờ user nhập thêm info
            BookCategoryService cat = new BookCategoryService();
            
            // đổ full data vào cbo
            cboBookCategoryId.DataSource = cat.GetAllCategories();
            
            // chọn cột để hiển thị
            cboBookCategoryId.DisplayMember = "BookGenreType";

            // chọn cợt để lấy value thực sự cần dùng - what u see is not what u get
            // chọn Sefl Help dễ cho user -> code map sang value 5 của cột BookCategory, dùng FK dayy693 vào table BOOK
            cboBookCategoryId.ValueMember = "BookCategoryId";

            //vi diệu
            //nhảy đến giá trị bất kì nào mình thích trong cbo
            //mặc định là đầu danh sách xổ
            cboBookCategoryId.SelectedValue = 5; //default với mình là sách Self Help

            // Check hjang2 có phải là edit hay k
            // Check biến SelectedBox coi có đc set != null ko
            // nếu có sách thì fill vào các ô
            if (SelectedBook != null)
            {
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookName.Text = SelectedBook.BookName;
                txtDescription.Text = SelectedBook.Description;
                txtAuthor.Text = SelectedBook.Author;
                txtPrice.Text = SelectedBook.Price.ToString();
                //..
                cboBookCategoryId.SelectedValue = SelectedBook.BookCategoryId; //1 2 3 4 5
                //tùy sách
            }
        }

        private void lblBookDescription_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
