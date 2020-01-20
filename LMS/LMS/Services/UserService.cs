using LMS.Domain.Models;
using LMS.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using LMS.Domain.Services;

namespace LMS.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public IEnumerable<Loan> GetLoans(int customerID)
        {
            return _userRepository.GetByID(customerID).Loan.OrderByDescending(r => r.LoanDate);
        }

        public IEnumerable<Reservation> GetReservations(int customerID)
        {
            return _userRepository.GetByID(customerID).Reservation.OrderByDescending(r => r.ReservationDate);
        }
    }
}