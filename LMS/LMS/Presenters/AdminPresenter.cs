using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Domain.ViewModels;
using LMS.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Presenters
{
    public class AdminPresenter
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILoanRepository _loanRepository;
        private readonly IReservationRepository _reservationRepository;

        public AdminPresenter() {
            _bookRepository = BookRepository.getInstance();
            _loanRepository = LoanRepository.getInstance();
            _reservationRepository = ReservationRepository.getInstance();
        }

        public BooksViewModel ShowBooks() {
            return _bookRepository.GetAll();
        }

        public LoansViewModel ShowLoans() {
            return _loanRepository.GetAll();
        }

        public ReservationsViewModel ShowReservations() {
            return _reservationRepository.GetAll();
        }

        public bool AddBook(Book newBook) {
            _bookRepository.Add(newBook);
            return true;
        }

        public bool EditBook(Book book) {
            _bookRepository.Update(book);
            return true;
        }

        public bool RemoveBook(Book book) {
            _bookRepository.Delete(book.SerialNumber);
            return true;
        }

        public bool CancelReservation(int reservationID)
        {
            var reservation = _reservationRepository.GetById(reservationID);
            _reservationRepository.CancelReservation(reservation);
            return true;
        }

        public bool RenewLoan(int loanId) {
            var loan = _loanRepository.GetById(loanId);
            _loanRepository.RenewLoan(loan);
            return true;
        }
    }
}
