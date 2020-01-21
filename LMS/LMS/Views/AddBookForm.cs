using LMS.Domain.Models;
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
    public partial class AddBookForm : Form
    {
        AdminPresenter adminPresenter = new AdminPresenter();

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.SerialNumber = Convert.ToInt32(serialNumTB.Text);
            book.Title = titleTB.Text;
            book.Author = authorTB.Text;
            book.Publisher = publisherTB.Text;
            book.YearOfPublishing = Convert.ToInt32(yopTB.Text);
            book.Genre = genreTB.Text;
            book.Status = statusTB.Text;

            adminPresenter.AddBook(book);
            MessageBox.Show("Book successfully added!");

            Clear();
        }

        private void Clear()
        {
            serialNumTB.Text = titleTB.Text = authorTB.Text = publisherTB.Text = yopTB.Text = genreTB.Text = statusTB.Text = "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminForm().Show();
        }
    }
}
