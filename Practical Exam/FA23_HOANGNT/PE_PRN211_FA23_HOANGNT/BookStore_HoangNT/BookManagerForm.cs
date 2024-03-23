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

namespace BookStore_HoangNT
{
    public partial class BookManagerForm : Form
    {
        private BookService _bookService = new();
        private BookCategoryService _cateService = new();

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
            var rs = _bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = rs;
            // kĩ thuật giấu tên cột
            dgvBookList.Columns["BookCategory"].Visible = false;

            cboCategory.DataSource = null;
            cboCategory.DataSource = _cateService.GetAllCategories();
            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                txtId.Text = selected.BookId.ToString();
                txtName.Text = selected.BookName;
                txtDescription.Text = selected.Description;
                dtpReleasedDate.Value = selected.ReleaseDate;
                txtQuantity.Text = selected.Quantity.ToString();
                txtPrice.Text = selected.Price.ToString();
                txtAuthor.Text = selected.Author;
                cboCategory.SelectedValue = selected.BookCategoryId;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                MessageBox.Show("The search keyword is required!", "Search keyword required!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rs = _bookService.SearchBook(txtKeyword.Text.Trim());
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = rs;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int.TryParse(txtId.Text, out int id);
            int id;
            if (string.IsNullOrWhiteSpace(txtId.Text) || !(int.TryParse(txtId.Text, out id)))
            {
                MessageBox.Show("The BookId is required!", "BookId required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _bookService.Delete(id);
            RefreshData();
        }

        private void RefreshData()
        {
            var rs = _bookService.SearchBook(txtKeyword.Text.Trim());
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = rs;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtId.Text) || !(int.TryParse(txtId.Text, out id)))
            {
                MessageBox.Show("The BookId is invalid! Pls select a row in the grid to edit!", "Invalid BookId", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BookForm bookForm = new();
            bookForm.BookId = int.Parse(txtId.Text);
            bookForm.ShowDialog();
            RefreshData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new();
            bookForm.BookId = null;
            bookForm.ShowDialog();
            RefreshData();
        }

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
