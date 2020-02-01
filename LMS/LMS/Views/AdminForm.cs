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
    public partial class AdminForm : Form
    {
        private AdminPresenter _adminPresenter = new AdminPresenter();

        public AdminForm(AdminPresenter adminPresenter)
        {
            _adminPresenter = adminPresenter;
            InitializeComponent();
            CreateListView();
        }

        public AdminForm() {
            
            InitializeComponent();
            CreateListView();
        }

        

        private void AdminForm_Load(object sender, EventArgs e)
        {
            var bookList = _adminPresenter.ShowBooks();

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

        private void CreateListView()
        {
            BookCatalogLV.Columns.Add("BookID", 50, HorizontalAlignment.Center);
            BookCatalogLV.Columns.Add("Title", 135, HorizontalAlignment.Center);
            BookCatalogLV.Columns.Add("Author", 135, HorizontalAlignment.Center);
            BookCatalogLV.Columns.Add("Publisher", 60, HorizontalAlignment.Center);
            BookCatalogLV.Columns.Add("Year of publishing", 95, HorizontalAlignment.Center);
            BookCatalogLV.Columns.Add("Genre", 100, HorizontalAlignment.Center);
            BookCatalogLV.Columns.Add("Status", 100, HorizontalAlignment.Center);
        }

        private void ReturnBtn1_Click(object sender, EventArgs e)
        {

        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddBookForm().Show();
            
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var bookList = BookCatalogLV.Items;
            foreach (ListViewItem item in bookList) {
                if (item.Selected)
                {
                    this.Hide();
                    new EditBookForm(item).Show();
                }
                
            }
            
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            var selectedItems = BookCatalogLV.SelectedItems;

            if (selectedItems.Count == 1) {
                book = itemToBook(selectedItems[0]);
            }
            _adminPresenter.RemoveBook(book);
            MessageBox.Show("Book successfully removed!");
            BookCatalogLV.Refresh();
            
        }

        private Book itemToBook(ListViewItem item)
        {
            Book book = new Book();
            book.SerialNumber = Convert.ToInt32(item.SubItems[0].Text);
            book.Title = item.SubItems[1].Text;
            book.Author = item.SubItems[2].Text;
            book.Publisher = item.SubItems[3].Text;
            book.YearOfPublishing = Convert.ToInt32(item.SubItems[4].Text);
            book.Genre = item.SubItems[5].Text;
            book.Status = item.SubItems[6].Text;

            return book;
        }

        private void LoansBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoansForm().Show();
        }

        private void ReservationsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReservationForm().Show();
        }
    }
}
