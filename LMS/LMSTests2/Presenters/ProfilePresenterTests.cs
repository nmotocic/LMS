using Microsoft.VisualStudio.TestTools.UnitTesting;
using LMS.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Domain.Repositories;
using LMS.Persistence.Repositories;
using LMS.Domain.Models;

namespace LMS.Presenters.Tests
{
    [TestClass()]
    public class ProfilePresenterTests
    {
        private readonly IUserRepository userRepository;
        private readonly IBookRepository bookRepository;
        private readonly ILoanRepository loanRepository;
        private readonly IReservationRepository reservationRepository;

        private Book loanBook;
        private Book reservationBook;
        private Book returnBook;
        private Customer user;

        public ProfilePresenterTests()
        {
            userRepository = UserRepository.getInstance();
            bookRepository = BookRepository.getInstance();
            loanRepository = LoanRepository.getInstance();
            reservationRepository = ReservationRepository.getInstance();

            loanBook = new Book()
            {
                SerialNumber = 2000,
                Title = "The Hobbit",
                Author = "J. R. R. Tolkein",
                Publisher = "Penguin Books",
                YearOfPublishing = 2005,
                Genre = "Fantasy",
                Status = "Avaliable"
            };


            loanBook = new Book()
            {
                SerialNumber = 2001,
                Title = "Unfinished Tales",
                Author = "J. R. R. Tolkein",
                Publisher = "Penguin Books",
                YearOfPublishing = 2006,
                Genre = "Fantasy",
                Status = "Avaliable"
            };


            reservationBook = new Book()
            {
                SerialNumber = 2002,
                Title = "The Silmarillion",
                Author = "J. R. R. Tolkein",
                Publisher = "Penguin Books",
                YearOfPublishing = 2009,
                Genre = "Fantasy",
                Status = "Avaliable"
            };

            returnBook = new Book()
            {
                SerialNumber = 2003,
                Title = "The Childer of Hurin",
                Author = "J. R. R. Tolkein",
                Publisher = "Penguin Books",
                YearOfPublishing = 2007,
                Genre = "Fantasy",
                Status = "Avaliable"
            };

            user = new Customer()
            {
                Id = 152,
                Name = "Ferko",
                Surname = "Feric",
                Email = "ferko.feric@fer.hr",
                Username = "fferic",
                Password = "javolimfer",
                Phone = "123-4567"
            };

        }



        [TestMethod()]
        public void CancelReservationTest()
        {
            bool success = false;
            var adminController = new AdminPresenter();
            var bookController = new BookPresenter();

            var successfullAdd = adminController.AddBook(reservationBook);

            bookController.Reserve(reservationBook.SerialNumber, user.Username);
            var reservation = reservationRepository.GetByBookId(reservationBook.SerialNumber);
            var book = bookRepository.GetByID(reservationBook.SerialNumber);

            if (book.Status.Equals("Reserved"))
            {
                var successfullCancellation = adminController.CancelReservation(reservation.Id);
                success = successfullCancellation;

            }

            var successfulDelete = adminController.RemoveBook(reservationBook);
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public void RenewLoanTest()
        {
            bool success = false;
            var adminController = new AdminPresenter();
            var bookController = new BookPresenter();
            var successfullAdd = adminController.AddBook(loanBook);

            bookController.Loan(loanBook.SerialNumber, user.Username);
            var loan = loanRepository.GetByBookId(loanBook.SerialNumber);
            var book = bookRepository.GetByID(loanBook.SerialNumber);

            if (book.Status.Equals("Unavaliable"))
            {
                var successfullLoanRenewal = adminController.RenewLoan(loan.Id);
                success = successfullLoanRenewal;

            }
            var successfulDelete = adminController.RemoveBook(loanBook);
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public void ReturnBookTest()
        {
            bool success = false;
            var adminController = new AdminPresenter();
            var bookController = new BookPresenter();
            var profileController = new ProfilePresenter();

            var successfullAdd = adminController.AddBook(returnBook);

            bookController.Loan(returnBook.SerialNumber, user.Username);
            var loan = loanRepository.GetByBookId(returnBook.SerialNumber);
            var book = bookRepository.GetByID(returnBook.SerialNumber);

            if (book.Status.Equals("Unavaliable"))
            {
                var successfullReturn = profileController.ReturnBook(loan.Id);
                success = successfullReturn;
                
            }
            var successfulDelete = adminController.RemoveBook(returnBook);
            
            Assert.IsTrue(success);

        }

    }  
}