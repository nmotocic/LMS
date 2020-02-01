using LMS.Domain.ViewModels;
using LMS.Presenters;
using System;
using System.Windows.Forms;

namespace LMS.Views
{
    public partial class BookCatalogForm : Form
    {
        private BookPresenter _bookPresenter;
        private string _username;

        public BookCatalogForm(string username)
        {
            _bookPresenter = new BookPresenter();
            _username = username;
            InitializeComponent();
        }



        private void BookCatalogForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            
        }

        private void BookCatalogLV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoanBtn_Click(object sender, EventArgs e)
        {
            int bookId = 0;
            var selectedItem = BookCatalogLV.SelectedItems;
            if (selectedItem.Count == 1)
            {
                bookId = Convert.ToInt32(selectedItem[0].SubItems[0].Text);
            }
            var success = _bookPresenter.Loan(bookId, _username);
            if (success)
            {
                MessageBox.Show("Book successfully loaned");
            }
            else {
                MessageBox.Show("Book has been borrowed or reserved!");
            }
            BookCatalogLV.Refresh();
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            int bookId = 0;
            var selectedItem = BookCatalogLV.SelectedItems;
            if (selectedItem.Count == 1)
            {
                bookId = Convert.ToInt32(selectedItem[0].SubItems[0].Text);
            }
             var success = _bookPresenter.Reserve(bookId, _username);
            if (success)
            {
                MessageBox.Show("Book successfully loaned");
            }
            else
            {
                MessageBox.Show("Book has been borrowed or reserved!");
            }
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProfileForm(_username).Show();
        }

        private void LoadBooks() {
            var bookList = _bookPresenter.ShowBooks();

            foreach (BookViewModel book in bookList.Books)
            {
                ListViewItem item = new ListViewItem();
                item.Text = book.Serial_Number.ToString();
                item.SubItems.Add(book.BookTitle);
                item.SubItems.Add(book.BookAuthor);
                item.SubItems.Add(book.Publisher);
                item.SubItems.Add(book.Year_Of_Publishing.ToString());
                item.SubItems.Add(book.Genre);
                item.SubItems.Add(book.Status.ToString());
                BookCatalogLV.Items.Add(item);
            }
        }
    }
}
