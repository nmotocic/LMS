using LMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Services
{
    public interface IReservationService
    {
        
        bool ReserveBook(int bookID, string username);
        void CancelReservation(int reservationID);
    }
}
