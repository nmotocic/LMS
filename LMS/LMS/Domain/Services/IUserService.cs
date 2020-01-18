using LMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Services
{
    interface IUserService
    {
        
        IEnumerable<Loan> GetLoans(int customerID);
        IEnumerable<Reservation> GetReservations(int customerID);
    }
}
