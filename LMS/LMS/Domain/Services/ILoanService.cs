using LMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Domain.Services
{
    public interface ILoanService
    {
       
        void CheckInBook(int bookId);
        void CheckOutBook(int bookId);

        void RenewLoan(int loanID);
    }
}