using LMS.Domain.Models;
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
        IEnumerable<Loan> GetAll();

        void Add(Loan newLoan);
        void Update(Loan loan);
        void Delete(Loan loan);
    }
}
