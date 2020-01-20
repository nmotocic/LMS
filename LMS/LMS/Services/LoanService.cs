using LMS.Domain.Enums;
using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Domain.Services;
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

        public IEnumerable<Loan> ListAll()
        {
            return _loanRepository.GetAll();
        }

        //Check in the book
        public void CheckInBook(int bookId)
        {
            var now = DateTime.Now;
            var book = _bookRepository.GetByID(bookId);

            var currentStatus = _loanRepository.GetAll().Where(l => l.Book.Status == EStatus.UNAVALIABLE);

            //TO DO: figure this out
            if (currentStatus.Any()) {

                return;
            }

            UpdateBookStatus(bookId, "Avaliable");
           
        }

        private void UpdateBookStatus(int bookId, string newStatus)
        {
            var book = _bookRepository.GetByID(bookId);
           // _bookRepository.Update(book);
            switch (newStatus)
            {
                case "Avaliable":
                    book.Status = EStatus.AVALIABLE;
                    break;
                case "Unavaliable":
                    book.Status = EStatus.UNAVALIABLE;
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
            return _loanRepository.GetAll().Any();
        }

        


        //TODO
        public void RenewLoan(int loanID)
        {
            throw new NotImplementedException();
        }

       
    }
}