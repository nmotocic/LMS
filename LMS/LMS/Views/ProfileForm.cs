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
    public partial class ProfileForm : Form
    {
        ProfilePresenter profilePresenter;
        string username;

        public ProfileForm(string username)
        {
            profilePresenter = new ProfilePresenter();
            this.username = username;
            InitializeComponent();
        }

        private void returnListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BookCatalogForm(username).Show();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadLoans();
            LoadReservations();
            ShowUserDetails();
        }


        private void LoadLoans()
        {
            var loanList = profilePresenter.ShowLoans(username);
            foreach (LoanViewModel loan in loanList.Loans)
            {
                ListViewItem item = new ListViewItem();
                item.Text = loan.Loan_ID.ToString();
                item.SubItems.Add(loan.BookTitle);
                item.SubItems.Add(loan.LoanDate.ToString());
                item.SubItems.Add(loan.ReturnDate.ToString());
                LoanListView.Items.Add(item);
            }
        }

        private void LoadReservations()
        {
            var reservationList = profilePresenter.ShowReservations(username);
            foreach (ReservationViewModel reservation in reservationList.Reservations)
            {
                ListViewItem item = new ListViewItem();
                item.Text = reservation.Reservation_ID.ToString();
                item.SubItems.Add(reservation.Book.Title);
                item.SubItems.Add(reservation.ReservationDate.ToString());
                ReservationLV.Items.Add(item);
            }
        }
        private void ShowUserDetails()
        {
            var user = profilePresenter.UserDetails(username);
            NameAddLbl.Text = user.Name;
            addSurnameLbl.Text = user.Surname;
            addPhoneLbl.Text = user.Phone;
            addMailLbl.Text = user.Email;
            addUsernameLbl.Text = user.Username;
        }

        private void CancelReservationBtn_Click(object sender, EventArgs e)
        {
            int reservationID = 0;
            var selectedItem = ReservationLV.SelectedItems;
            if (selectedItem.Count == 1)
            {
                reservationID = Convert.ToInt32(selectedItem[0].SubItems[0].Text);
            }
            profilePresenter.CancelReservation(reservationID);
            MessageBox.Show("Reservation successfully cancelled!");
            LoadReservations();
        }

        private void renewLoanBtn_Click(object sender, EventArgs e)
        {
            int loanId = 0;
            var selectedItem = LoanListView.SelectedItems;
            if (selectedItem.Count == 1)
            {
                loanId = Convert.ToInt32(selectedItem[0].SubItems[0].Text);
            }
            profilePresenter.RenewLoan(loanId);
            MessageBox.Show("Loan successfully renewed!");
            LoanListView.Refresh();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            int loanId = 0;
            var selectedItem = LoanListView.SelectedItems;
            if (selectedItem.Count == 1)
            {
                loanId = Convert.ToInt32(selectedItem[0].SubItems[0].Text);
            }
            profilePresenter.ReturnBook(loanId);
            MessageBox.Show("Book successfully returned!");
            LoadLoans();
        }
    }
}
