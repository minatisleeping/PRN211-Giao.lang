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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BookStore_HoangNT
{
    public partial class BookForm : Form
    {
        public int? BookId { get; set; }
        private BookService _bookService = new();
        private BookCategoryService _cateService = new();

        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            cboCategory.DataSource = _cateService.GetAllCategories();
            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";

            if (this.BookId != null) //update mode
            {
                var book = _bookService.GetABook((int)BookId);

                txtId.Text = book.BookId.ToString();
                txtName.Text = book.BookName;
                txtDescription.Text = book.Description;
                dtpReleasedDate.Value = book.ReleaseDate;
                txtQuantity.Text = book.Quantity.ToString();
                txtPrice.Text = book.Price.ToString();
                txtAuthor.Text = book.Author;
                cboCategory.SelectedValue = book.BookCategoryId;
                lblFormTitle.Text = "Updating a book...";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book book = new()
            {
                BookId = int.Parse(txtId.Text.Trim()),
                BookName = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                ReleaseDate = dtpReleasedDate.Value.Date,
                Author = txtAuthor.Text.Trim(),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                Price = double.Parse(txtPrice.Text.Trim()),
                BookCategoryId = int.Parse(cboCategory.SelectedValue.ToString())
            };

            if (BookId != null) //mode update
                _bookService.UpdateABook(book);
            else
                _bookService.AddABook(book);

            Close();
        }

    }
}
