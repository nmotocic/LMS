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
    public partial class EditBookForm : Form
    {
        AdminPresenter adminPresenter = new AdminPresenter();
        ListViewItem _item;

        public EditBookForm(ListViewItem item)
        {
            InitializeComponent();
            _item = item;
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            FillForm();

        }

        private void FillForm()
        {
            SerialNumLLbl.Text = _item.SubItems[0].Text;
            titleTB.Text = _item.SubItems[1].Text;
            authorTB.Text = _item.SubItems[2].Text;
            publisherTB.Text = _item.SubItems[3].Text;
            yopTB.Text = _item.SubItems[4].Text;
            genreTB.Text = _item.SubItems[5].Text;
            statusTB.Text = _item.SubItems[6].Text;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Book editedBook = new Book();

            editedBook.SerialNumber = Convert.ToInt32(SerialNumLLbl.Text);
            editedBook.Title = titleTB.Text;
            editedBook.Author = authorTB.Text;
            editedBook.Publisher = publisherTB.Text;
            editedBook.YearOfPublishing = Convert.ToInt32(yopTB.Text);
            editedBook.Genre = genreTB.Text;
            editedBook.Status = statusTB.Text;

            adminPresenter.EditBook(editedBook);
            MessageBox.Show("Book successfully edited!");
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new AdminForm()).Show();
        }
    }
}
