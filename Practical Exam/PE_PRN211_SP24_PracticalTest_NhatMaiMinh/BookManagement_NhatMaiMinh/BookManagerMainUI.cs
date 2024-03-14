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
    }
}
