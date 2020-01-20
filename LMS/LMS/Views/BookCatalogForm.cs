using LMS.Domain;
using LMS.Domain.Models;
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
    public partial class BookCatalogForm : Form
    {
        private BookPresenter _bookPresenter;
        

        public BookCatalogForm(BookPresenter bookPresenter)
        {
            _bookPresenter = bookPresenter;
            InitializeComponent();
        }

        private void BookCatalogForm_Load(object sender, EventArgs e)
        {
            var bookList = _bookPresenter.ShowBooks();

            foreach (BookViewModel book in bookList.Books) {
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
    }
}
