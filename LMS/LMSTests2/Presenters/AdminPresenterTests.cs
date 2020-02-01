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
using LMS.Services;
using Moq;

namespace LMS.Presenters.Tests
{
    [TestClass()]
    public class AdminPresenterTests
    {
        private readonly IUserRepository userRepository;
        private readonly IBookRepository bookRepository;
        private readonly ILoanRepository loanRepository;
        private readonly IReservationRepository reservationRepository;


        private static readonly Book book = new Book()
        {
            SerialNumber = 1997,
            Title = "The Fellowship of the Ring",
            Author = "J. R. R. Tolkein",
            Publisher = "Penguin Books",
            YearOfPublishing = 2003,
            Genre = "Fantasy",
            Status = "Avaliable"
        };
        

        private static readonly Customer customer = new Customer()
        {
            Id = 152,
            Name = "Ferko",
            Surname = "Feric",
            Email = "ferko.feric@fer.hr",
            Username = "fferic",
            Password = "javolimfer",
            Phone = "123-4567"
        };


        public AdminPresenterTests()
        {
            userRepository = UserRepository.getInstance();
            bookRepository = BookRepository.getInstance();
            loanRepository = LoanRepository.getInstance();
            reservationRepository = ReservationRepository.getInstance();

        }

        [TestMethod()]
        public void AddBookTest()
        {
            var controller = new AdminPresenter();
            var success = controller.AddBook(book);

            Assert.IsTrue(success);

        }

        [TestMethod()]
        public void EditBookTest()
        {
            var controller = new AdminPresenter();
            //var successfulAdd = controller.AddBook(book);

            book.Title = "The Two Towers";
            book.YearOfPublishing = 2005;
            
            var successfulEdit = controller.EditBook(book);
            Assert.IsTrue(successfulEdit);
            
        }

        
        [TestMethod()]
        public void RemoveBookTest()
        {
            var controller = new AdminPresenter();
           // var successfulAdd = controller.AddBook(book);
            
            var successfulDelete = controller.RemoveBook(book);

            Assert.IsTrue(successfulDelete);
        }
        
        
       

        
        
        
    }
}