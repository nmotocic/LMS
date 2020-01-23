﻿using LMS.Domain.Models;
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
        private readonly IReservationRepository _reservationRepostory;

        public AdminPresenter() {
            _bookRepository = BookRepository.getInstance();
            _loanRepository = LoanRepository.getInstance();
            _reservationRepostory = ReservationRepository.getInstance();
        }

        public BooksViewModel ShowBooks() {
            return _bookRepository.GetAll();
        }

        public LoansViewModel ShowLoans() {
            return _loanRepository.GetAll();
        }

        public ReservationsViewModel ShowReservations() {
            return _reservationRepostory.GetAll();
        }

        public void AddBook(Book newBook) {
            _bookRepository.Add(newBook);
        }

        public void EditBook(Book book) {
            _bookRepository.Update(book);
        }

        public void RemoveBook(Book book) {
            _bookRepository.Delete(book.SerialNumber);
        }

        public void CancelReservation(int reservationID)
        {
            var reservation = _reservationRepostory.GetById(reservationID);
            _reservationRepostory.CancelReservation(reservation);
        }

        public void RenewLoan(int loanId) {
            var loan = _loanRepository.GetById(loanId);
            _loanRepository.RenewLoan(loan);
        }
    }
}
