using LMS.Domain.Models;
using LMS.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Domain.Services
{
    public interface ILoanService
    {
        IEnumerable<LoanViewModel> ListAll();
        void CheckInBook(int bookId);
        void CheckOutBook(int bookId, string username);

        void RenewLoan(int loanID);
    }
}