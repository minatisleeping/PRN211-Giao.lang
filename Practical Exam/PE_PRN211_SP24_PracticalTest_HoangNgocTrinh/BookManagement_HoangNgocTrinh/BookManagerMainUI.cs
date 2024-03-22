using Repositories.Entities;
using Services;

namespace BookManagement_HoangNgocTrinh
{
    public partial class BookManagerMainUI : Form
    {

        //backing field
        private BookService _service = new();

        private Book _selected = null; // chờ ai đó nhấn chọn 1 dòng trong grid/table
                                       //thì nó đc gán = cuốn sách đang chọn
                                       //đẩy cuống sách đc chọn sang màn hình update
        public BookManagerMainUI()
        {
            InitializeComponent();
        }
        //hàm private - helper trợ giúp cho các hàm khác
        //hàm này đổ data  vào grid
        private void FillDataGridView()
        {
            //chắc chắn phải cần có _service gọi hàm của _service, đến lượt Service
            //gọi Repo | Repo gọi DbContext
            dgvBookList.DataSource = null; //xoá trắng grid
            dgvBookList.DataSource = _service.GetAllBooks();
        }
        public void BookManagerMainUI_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }//bad smells Clean Code - Robert C. Martin

        private void grbSearchCriteria_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //gọi màn hình Detail lên. Màn hình này bản chất là class BookDetailFrom, khác truyền thống là nó có phần render bề mặt!!!
            //Nó 1 class nên nó sẽ có _field, prop, methods như bt
            //khai báo biến, new như bt
            //thêm phần render
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog(); //render đi em 
            //f.Show(); //nguy hiểm nhen, vì cứ new là có object, cửa sổ mới!!!
            FillDataGridView();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            //người dùng có thể chọn 1 dòng hay nhiều dòng - chìm chuột, cho nên ta sẽ lấy dòng đầu tiên đc chọn nếu người ta chọn nhiều dòng
            if (dgvBookList.SelectedRows.Count > 0)
            {
                //nếu chọn ít nhất 1 dòng, thì cứ dòng đầu tiên đc chọn là bốc nó ra, đẩy sang màn hình detail
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                //lấy 1 dòng chính là kiểu object tổng quát, nhưng bản chất là Book do lúc đầu
                //.DataSource = List<Book> của hàm GetAllBooks()
            }
            // nếu user chọn Cell thay vì chọn nguyên dòng, reset biến _selected về null
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //đẩy sang Form Detail
            //khai biến, new, gán prop, show dialog
            //thằng form detail: mở lên, check selected khác null hem? khác null mode EDIT, SHOW DATA ĐC GỬI SANG
            if (_selected != null)
            {
                BookDetailForm f = new BookDetailForm();

                //đưa sách sang
                f.SelectedBook = _selected;
                f.ShowDialog();
                //F5 lưới
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("Pls select a certain book to edit!", "WARNING: SELECT BOOK",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // ta sẽ lấy ra 2 chuỗi đang nằm trong txtBookName & txtDescription
            //và ta where trên cái danh sách books đang có
            var books = new BookService().GetAllBooks();
            dgvBookList.DataSource = null;
            //dgvBookList.DataSource = books.Where(x => false).ToList();
            //dgvBookList.DataSource = books.Where(
            //    delegate (Book x)
            //    {
            //        return x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) ||
            //               x.Description.ToLower().Contains(txtDescription.Text.ToLower());
            //    }
            //).ToList();

            dgvBookList.DataSource = books.Where(
                x => x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) ||
                     x.Description.ToLower().Contains(txtDescription.Text.ToLower())
            ).ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                DialogResult answer = MessageBox.Show("Do u really wanna delete this book!?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.No)
                {
                    return;
                }
                _service.DeleteBook(_selected);
                FillDataGridView();
                _selected = null;
            }
            else
                MessageBox.Show("pls select a certain book to delete!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }
    }
}
