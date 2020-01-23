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
    public partial class LoansForm : Form
    {
        private AdminPresenter _adminPresenter = new AdminPresenter();

        public LoansForm()
        {
            InitializeComponent();
        }

        private void LoansForm_Load(object sender, EventArgs e)
        {
            var loanList = _adminPresenter.ShowLoans();
            foreach (LoanViewModel loan in loanList.Loans) {
                ListViewItem item = new ListViewItem();
                item.Text = loan.Loan_ID.ToString();
                item.SubItems.Add(loan.Book.Title);
                item.SubItems.Add(loan.User.Username);
                item.SubItems.Add(loan.User.Email);
                item.SubItems.Add(loan.LoanDate.ToString());
                item.SubItems.Add(loan.ReturnDate.ToString());
                LoanLV.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Renew loan
            int loanId = 0;
            var selectedItem = LoanLV.SelectedItems;
            if (selectedItem.Count == 1) {
                loanId = Convert.ToInt32(selectedItem[0].SubItems[0].Text);
            }
            _adminPresenter.RenewLoan(loanId);
            LoanLV.Refresh();
        }
    }
}
