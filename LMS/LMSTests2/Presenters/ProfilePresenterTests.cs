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

        private Book book;
        private Customer user;

        public ProfilePresenterTests()
        {
            userRepository = UserRepository.getInstance();
            bookRepository = BookRepository.getInstance();
            loanRepository = LoanRepository.getInstance();
            reservationRepository = ReservationRepository.getInstance();

            book = new Book()
            {
                SerialNumber = 2000,
                Title = "The Hobbit",
                Author = "J. R. R. Tolkein",
                Publisher = "Penguin Books",
                YearOfPublishing = 2005,
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
            var adminController = new AdminPresenter();
            var bookController = new BookPresenter();

            //var successfullAdd = adminController.AddBook(book);

            bookController.Reserve(book.SerialNumber, user.Username);
            var reservation = reservationRepository.GetByBookId(book.SerialNumber);

            var successfullCancellation = adminController.CancelReservation(reservation.Id); ;
            Assert.IsTrue(successfullCancellation);
        }

        [TestMethod()]
        public void RenewLoanTest()
        {
            var adminController = new AdminPresenter();
            var bookController = new BookPresenter();
            //var successfullAdd = adminController.AddBook(book);

            bookController.Loan(book.SerialNumber, user.Username);
            var loan = loanRepository.GetByBookId(book.SerialNumber);

            var successfullLoanRenewal = adminController.RenewLoan(loan.Id);
            Assert.IsTrue(successfullLoanRenewal);
        }

    }  
}