
using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Domain.Services;
using LMS.Domain.ViewModels;
using LMS.Persistence.Context;
using LMS.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Services
{
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IUserRepository _userRepository;

        public LoanService()
        {
            _loanRepository = LoanRepository.getInstance();
            _bookRepository = BookRepository.getInstance();
            _userRepository = UserRepository.getInstance();
        }

       // public LoanService() { }

        public IEnumerable<LoanViewModel> ListAll()
        {
            var list = _loanRepository.GetAll();
            return list.Loans;
        }

        //Check in the book
        public void CheckInBook(int bookId)
        {
           
            var book = _bookRepository.GetByID(bookId);
            var list = _loanRepository.GetAll().Loans;
           
            var loan = _loanRepository.GetByBookId(bookId);
           
            UpdateBookStatus(bookId, "Avaliable");
            _bookRepository.Update(bookId);
            _loanRepository.Delete(loan);
        }

        private void UpdateBookStatus(int bookId, string newStatus)
        {
            var book = _bookRepository.GetByID(bookId);
           
            switch (newStatus)
            {
                case "Avaliable":
                    book.Status = "Avaliable";
                    break;
                case "Unavaliable":
                    book.Status = "Unavaliable";
                    break;
            }
            _bookRepository.Update(book);

        }

        public bool CheckOutBook(int bookId, string username)
        {
            //Is the book borrowed?
            if (IsCheckedOut(bookId)) {
                Console.WriteLine("Book has been borrowed or reserved!");
                return false;
            }
            //if not...
            var book = _bookRepository.GetByID(bookId);
            var user = _userRepository.GetByUsername(username);

            UpdateBookStatus(bookId, "Unavaliable");
           

            var now = DateTime.Now;
            var loan = new Loan
            {
                Id = RandomNumber(1000,10000),
                BookId = bookId,
                CustomerId = user.Id,
                Book = book,
                User = user,
                LoanDate = now,
                ReturnDate = GetDefaultLoanTime(now)
            };
            _loanRepository.Add(loan);
           
            return true;

        }

        private DateTime? GetDefaultLoanTime(DateTime now)
        {
            return now.AddDays(30);
        }

        private bool IsCheckedOut(int bookId)
        {
            var book = _bookRepository.GetByID(bookId);
            string currentStatus = book.Status;

            if (currentStatus.Equals("Unavaliable") || currentStatus.Equals("Reserved")) {
                return true;
            }
            return false;
        }


        //TODO
        public void RenewLoan(int loanID)
        {
            var loan = _loanRepository.GetById(loanID);
            var newDate = GetDefaultLoanTime((DateTime)loan.ReturnDate);
            loan.ReturnDate = newDate;
            _loanRepository.Update(loan);
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


    }
}