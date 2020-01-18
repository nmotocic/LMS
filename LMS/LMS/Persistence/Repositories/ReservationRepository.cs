using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Persistence.Repositories
{
    public class ReservationRepository : BaseRepository, IReservationRepository
    {
        public ReservationRepository(LibraryContext context) : base(context)
        {
        }

        public void Add(Reservation newReservation)
        {
            _context.Reservation.Add(newReservation);
            _context.SaveChanges();
        }

        public IEnumerable<Reservation> GetAll()
        {
            return _context.Reservation;
        }

        public Reservation GetById(int id)
        {
            return GetAll().FirstOrDefault(r => r.Id == id);
        }

        public void Remove(Reservation reservation)
        {
            _context.Reservation.Remove(reservation);
        }

        
        public void Update(Reservation reservation)
        {
            _context.Reservation.Update(reservation);
        }
        
    }
}
