using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Persistence.Repositories
{
    public class LoanRepository : BaseRepository, ILoanRepository
    {
        public LoanRepository(LibraryContext context) : base(context)
        {
        }

        public void Add(Loan newLoan)
        {
            _context.Loan.Add(newLoan);
            _context.SaveChanges();
        }

        public void Delete(Loan loan)
        {
            _context.Loan.Remove(loan);
        }

        public IEnumerable<Loan> GetAll()
        {
            return _context.Loan;
        }

        public Loan GetById(int loanID)
        {
            return GetAll().FirstOrDefault(l => l.Id == loanID); ;
        }
        
        public void Update(Loan loan)
        {
            _context.Loan.Update(loan);
        }
        
    }
}
