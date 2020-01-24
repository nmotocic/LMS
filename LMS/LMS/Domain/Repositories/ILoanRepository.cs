using LMS.Domain.Models;
using LMS.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Repositories
{
    public interface ILoanRepository
    {
        Loan GetById(int loanID);
        LoansViewModel GetAll();

        void Add(Loan newLoan);
        void Update(Loan loan);
        void Delete(Loan loan);

        void RenewLoan(Loan loan);
        Loan GetByBookId(int bookId);
        List<Loan> GetByUsername(string username);
    }
}
