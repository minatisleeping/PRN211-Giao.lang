using Repositories.Entities;
using Services;

namespace BookManagement_NhatMaiMinh
{
    public partial class BookManagerMainUI : Form
    {
        public BookManagerMainUI()
        {
            InitializeComponent();
        }

        private void BookManagerMainUI_Load(object sender, EventArgs e)
        {
            // gọi Services để cung cấp data vào grid/table
            BookService service = new BookService();

            dgvBookList.DataSource = null; // xóa trắng grid
            dgvBookList.DataSource = service.GetAllBooks();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // gọi  màn hình Detail len6, Màn hình này bản caht61 là class BookDetailForm
            //khác truyền thống là nó có phần render bề mặt!!!
            // Nó 1 class nên nó sẽ có _field, prop, methods như bình thường
            //khai báo biến, show như bình thường
            BookDetailForm form = new BookDetailForm();
            form.ShowDialog(); //render đi em
            form.Show(); //nguy hiểm nhen, vì cứ new là có object, cửa sổ mới !!!
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            // user có thể chọn 1 dòng hay nhiều dòng, cho nên ta sẽ lấy dòng đầu tiên đc chọn nếu ngta
            //chọn nhiều dòng
            if (dgvBookList.SelectedRows.Count > 0)
            {
                //nếu chọn ít nhất 1 dòng, thì cứ dòng đầu tiên được chọn là bốc nó ra
                //, đẩy sang màn hình detail
                Book selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem; // lấy 1 dòng chính là kiểu object tổng quát,
                //nhưng bản chất là Book do lúc đầu .DataSource = List<Book> của hàm GetAllBooks()

                //đẩy sang Form Detail
                //khai biến, new, gán prop, show dialog
                //thằng  form detail: mở lên, check selected khác null hong? khác thì mode EDIT, SHOW DATA đc gửi sang
                BookDetailForm f = new BookDetailForm();

                //đưa sách sang
                f.SelectedBook = selected;
                f.ShowDialog();
            }
        }
    }
}
