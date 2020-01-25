using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Domain.ViewModels;
using LMS.Persistence.Context;
using LMS.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Persistence.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        protected static LibraryContext _context = new LibraryContext();
        private static LoanRepository instance;
        

        public LoanRepository(LibraryContext context) 
        {
            _context = context;
        }

        public static LoanRepository getInstance()
        {
            return instance ?? (instance = new LoanRepository(_context));
        }

        public void Add(Loan newLoan)
        {
            newLoan.Book = new Book() { SerialNumber = newLoan.BookId };
            newLoan.User = new Customer() { Id = newLoan.CustomerId };
            _context.Book.Attach(newLoan.Book);
            _context.Customer.Attach(newLoan.User);

            _context.Loan.Add(newLoan);
            _context.SaveChanges();
        }

        public void Delete(Loan loan)
        {
            _context.Loan.Remove(loan);
            _context.SaveChanges(); 
        }

        public LoansViewModel GetAll()
        {
            var query = _context.Loan.AsNoTracking();
            var loans = query.Select(loan => new LoanViewModel
            {
                Loan_ID = loan.Id,
                User = loan.User,
                Username = loan.User.Username,
                Email = loan.User.Email,
                Book = loan.Book,
                BookTitle = loan.Book.Title,
                LoanDate = loan.LoanDate,
                ReturnDate = loan.ReturnDate

            }).ToList();

            var model = new LoansViewModel { Loans = loans };
            return model;
        }

        public Loan GetByBookId(int bookId)
        {
            return _context.Loan.AsNoTracking().FirstOrDefault(l => l.BookId == bookId);
        }

        public Loan GetById(int loanID)
        {
            return _context.Loan.AsNoTracking().FirstOrDefault(l => l.Id == loanID); 
        }

        public List<Loan> GetByUsername(string username)
        {
            var list = _context.Loan.AsNoTracking().Where(l => l.User.Username.Equals(username)).ToList();
            return list;
        }

        public void RenewLoan(Loan loan)
        {
            LoanService loanService = new LoanService();
            loanService.RenewLoan(loan.Id);
        }

        public void Update(Loan loan)
        {
            _context.Loan.Update(loan);
            _context.SaveChanges();
        }
        
    }
}
