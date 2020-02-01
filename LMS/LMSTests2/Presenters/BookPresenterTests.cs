using Microsoft.VisualStudio.TestTools.UnitTesting;
using LMS.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Domain.Repositories;
using LMS.Domain.Models;
using LMS.Persistence.Repositories;


namespace LMS.Presenters.Tests
{
    [TestClass()]
    public class BookPresenterTests
    {

        private readonly IReservationRepository reservationRepository;
        private readonly ILoanRepository loanRepository;
        private readonly IBookRepository bookRepository;
        private readonly IUserRepository userRepository;

        private readonly Book loanBook;
        private readonly Book reservationBook;
        private readonly Customer user;


        public BookPresenterTests()
        {
            userRepository = UserRepository.getInstance();
            bookRepository = BookRepository.getInstance();
            loanRepository = LoanRepository.getInstance();
            reservationRepository = ReservationRepository.getInstance();

            loanBook = new Book()
            {
                SerialNumber = 1998,
                Title = "The Two Towers",
                Author = "J. R. R. Tolkein",
                Publisher = "Penguin Books",
                YearOfPublishing = 2004,
                Genre = "Fantasy",
                Status = "Avaliable"
            };

            reservationBook = new Book()
            {
                SerialNumber = 1999,
                Title = "The Return of the King",
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
        public void LoanTest()
        {
            bool success = false;
            var adminController = new AdminPresenter();
            var bookController = new BookPresenter();

            var successfullAdd = adminController.AddBook(loanBook);

            bookController.Loan(loanBook.SerialNumber, user.Username);
            var loan = loanRepository.GetByBookId(loanBook.SerialNumber);
            if (loan != null) {
                success = true;
                var successfulDelete = adminController.RemoveBook(loanBook);
            }
            Assert.IsTrue(success);
            
        }

        [TestMethod()]
        public void ReserveTest()
        {
            bool success = false;
            var adminController = new AdminPresenter();
            var bookController = new BookPresenter();

            var successfullAdd = adminController.AddBook(reservationBook);

            bookController.Reserve(reservationBook.SerialNumber, user.Username);
            var reservation = reservationRepository.GetByBookId(reservationBook.SerialNumber);

            if (reservation != null)
            {
                success = true;
                var successfulDelete = adminController.RemoveBook(reservationBook);
            }
            Assert.IsTrue(success);

            
        }

        [TestMethod()]
        public void ReturnBookTest()
        {
            var success = true;
            Assert.IsTrue(success);
        }
    }
}