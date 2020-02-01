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
    public class ProfilePresenter
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILoanRepository _loanRepository;
        private readonly IReservationRepository _reservationRepository;
        private readonly IUserRepository _userRepository;

        public ProfilePresenter() {
            _bookRepository = BookRepository.getInstance();
            _loanRepository = LoanRepository.getInstance();
            _reservationRepository = ReservationRepository.getInstance();
            _userRepository = UserRepository.getInstance();
        }

        public UserViewModel UserDetails(string username)
        {
            UserViewModel user = new UserViewModel();
            var findUser = _userRepository.GetByUsername(username);
            user.Name = findUser.Name;
            user.Surname = findUser.Surname;
            user.User_ID = findUser.Id;
            user.Email = findUser.Email;
            user.Username = findUser.Username;
            user.Phone = findUser.Phone;
            return user;
        }

        public LoansViewModel ShowLoans(string username) {
            var list = _loanRepository.GetByUsername(username);
            List<LoanViewModel> lmvList = new List<LoanViewModel>();

            foreach (Loan loan in list) {
                LoanViewModel lmv = ToModelView(loan);
                lmvList.Add(lmv);
            }

            return new LoansViewModel { Loans = lmvList };
        }


        public ReservationsViewModel ShowReservations(string username) {
            var list = _reservationRepository.GetByUsername(username);
            List<ReservationViewModel> rmvList = new List<ReservationViewModel>();

            foreach (Reservation reservation in list)
            {
                ReservationViewModel rmv = ToModelView(reservation);
                rmvList.Add(rmv);
            }

            return new ReservationsViewModel { Reservations = rmvList };
        }

        public void CancelReservation(int reservationID) {
            var reservation = _reservationRepository.GetById(reservationID);
            _reservationRepository.CancelReservation(reservation);
        }

        public void RenewLoan(int loanId) {
            var loan = _loanRepository.GetById(loanId);
            _loanRepository.RenewLoan(loan);
        }

        private ReservationViewModel ToModelView(Reservation reservation)
        {
            ReservationViewModel rmv = new ReservationViewModel();
            rmv.Reservation_ID = reservation.Id;
            rmv.User =_userRepository.GetByID(reservation.CustomerId);
            rmv.Book = _bookRepository.GetByID(reservation.BookId);
            rmv.BookTitle = _bookRepository.GetByID(reservation.BookId).Title;

            rmv.ReservationDate = reservation.ReservationDate;
            return rmv;
        }

        private LoanViewModel ToModelView(Loan loan)
        {
            LoanViewModel lmv = new LoanViewModel();
            lmv.Loan_ID = loan.Id;
            lmv.User = _userRepository.GetByID(loan.CustomerId);
            lmv.Book = _bookRepository.GetByID(loan.BookId);
            lmv.BookTitle = _bookRepository.GetByID(loan.BookId).Title;
            lmv.LoanDate = loan.LoanDate;
            lmv.ReturnDate = loan.ReturnDate;
            return lmv;
        }

        public void ReturnBook(int loanId)
        {
            var loan = _loanRepository.GetById(loanId);
            _loanRepository.ReturnBook(loan);
        }
    }
}
