﻿using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Domain.ViewModels;
using LMS.Persistence.Context;
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
        public LoanRepository(LibraryContext context) 
        {
            _context = context;
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

        public LoansViewModel GetAll()
        {
            var query = _context.Loan.AsNoTracking();
            var loans = query.Select(loan => new LoanViewModel
            {
                Loan_ID = loan.Id,
                User = loan.User.Username,
                Book = loan.Book.Title,
                LoanDate = loan.LoanDate,
                ReturnDate = loan.ReturnDate

            }).ToList();

            var model = new LoansViewModel { Loans = loans };
            return model;
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
