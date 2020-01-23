﻿
using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Domain.Services;
using LMS.Domain.ViewModels;
using LMS.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Services
{
    public class LoanService : ILoanService
    {
        private ILoanRepository _loanRepository;
        private IBookRepository _bookRepository;

        public LoanService(ILoanRepository loanRepository, IBookRepository bookRepository)
        {
            _loanRepository = loanRepository;
            _bookRepository = bookRepository;
        }

        public LoanService() { }

        public IEnumerable<LoanViewModel> ListAll()
        {
            var list = _loanRepository.GetAll();
            return list.Loans;
        }

        //Check in the book
        public void CheckInBook(int bookId)
        {
            var now = DateTime.Now;
            var book = _bookRepository.GetByID(bookId);
            var list = _loanRepository.GetAll().Loans;

            var currentStatus = list.Where(l => l.Book.Status.Equals("UNAVALIABLE"));

            //TO DO: figure this out
            if (currentStatus.Any()) {

                return;
            }

            UpdateBookStatus(bookId, "Avaliable");
            _bookRepository.Update(book);
        }

        private void UpdateBookStatus(int bookId, string newStatus)
        {
            var book = _bookRepository.GetByID(bookId);
           
            switch (newStatus)
            {
                case "Avaliable":
                    book.Status.Equals("AVALIABLE");
                    break;
                case "Unavaliable":
                    book.Status.Equals("UNAVALIABLE");
                    break;
            }

            
        }

        public void CheckOutBook(int bookId)
        {
            //Is the book borrowed?
            if (IsCheckedOut(bookId)) {
                //send message
                return;
            }
            //if not...
            var item = _bookRepository.GetByID(bookId);
            UpdateBookStatus(bookId, "Unavaliable");

            var now = DateTime.Now;
            var loan = new Loan
            {
                BookId = bookId,
                Book = item,

                LoanDate = now,
                ReturnDate = GetDefaultLoanTime(now)
            };
            _loanRepository.Add(loan);

            
           
        }

        private DateTime? GetDefaultLoanTime(DateTime now)
        {
            return now.AddDays(30);
        }

        private bool IsCheckedOut(int bookId)
        {
            return _loanRepository.GetAll().Loans.Any();
        }


        //TODO
        public void RenewLoan(int loanID)
        {
            var loan = _loanRepository.GetById(loanID);
            var newDate = GetDefaultLoanTime((DateTime)loan.ReturnDate);
            loan.ReturnDate = newDate;
            _loanRepository.Update(loan);
        }

       
    }
}