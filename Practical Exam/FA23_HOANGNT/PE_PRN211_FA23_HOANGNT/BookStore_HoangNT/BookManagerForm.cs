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

namespace BookStore_HoangNT
{
    public partial class BookManagerForm : Form
    {
        private BookService _service = new();
        public BookManagerForm()
        {
            InitializeComponent();
        }

        private void mtbQuantity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BookManagerForm_Load(object sender, EventArgs e)
        {
            //load danh sách Book vào grid
            var rs = _service.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = rs;
            // kĩ thuật giấu tên cột
            dgvBookList.Columns["BookCategory"].Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
