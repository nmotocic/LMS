using LMS.Domain.Models;
using LMS.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Repositories
{
    public interface IReservationRepository
    {
        Reservation GetById(int id);
        ReservationsViewModel GetAll();

        void Add(Reservation newReservation);
        void Update(Reservation reservation);
        void Remove(Reservation reservation);
        void CancelReservation(Reservation reservation);
        List<Reservation> GetByUsername(string username);
        Reservation GetByBookId(int bookId);
    }
}
