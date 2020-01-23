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

        public ProfilePresenter() {
            _bookRepository = BookRepository.getInstance();
            _loanRepository = LoanRepository.getInstance();
            _reservationRepository = ReservationRepository.getInstance();
        }

        public UserViewModel UserDetails()
        {
            UserViewModel user = new UserViewModel();
            return user;
        }

        public LoansViewModel ShowLoans() {
            
        }

        public ReservationsViewModel ShowReservations() {

        }
        
    }
}
