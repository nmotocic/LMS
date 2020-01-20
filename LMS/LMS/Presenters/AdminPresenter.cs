using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Domain.ViewModels;
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

        public AdminPresenter() { }

        public AdminPresenter(IBookRepository bookRepository, ILoanRepository loanRepository, IReservationRepository reservationRepository) {
            _bookRepository = bookRepository;
            _loanRepository = loanRepository;
            _reservationRepostory = reservationRepository;
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
    }
}
