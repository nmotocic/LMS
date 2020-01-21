using LMS.Domain.ViewModels;
using LMS.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views
{
    public partial class AdminForm : Form
    {
        private AdminPresenter _adminPresenter = new AdminPresenter();

        public AdminForm(AdminPresenter adminPresenter)
        {
            _adminPresenter = adminPresenter;
            InitializeComponent();
        }

        public AdminForm() {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            var bookList = _adminPresenter.ShowBooks();

            foreach (BookViewModel book in bookList.Books)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(book.Serial_Number.ToString());
                item.SubItems.Add(book.BookTitle);
                item.SubItems.Add(book.BookAuthor);
                item.SubItems.Add(book.Publisher);
                item.SubItems.Add(book.Year_Of_Publishing.ToString());
                item.SubItems.Add(book.Genre);
                item.SubItems.Add(book.Status.ToString());
                BookCatalogLV.Items.Add(item);
            }
        }

        private void ReturnBtn1_Click(object sender, EventArgs e)
        {

        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
