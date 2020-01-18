using LMS.Domain.Models;
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
        IEnumerable<Reservation> GetAll();

        void Add(Reservation newReservation);
        void Update(Reservation reservation);
        void Remove(Reservation reservation);
    }
}
