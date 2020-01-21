using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Domain.ViewModels;
using LMS.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Persistence.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        protected static LibraryContext _context = new LibraryContext();
        private static ReservationRepository instance; 

        public ReservationRepository(LibraryContext context) 
        {
            _context = context;
        }

        public static ReservationRepository getInstance()
        {
            return instance ?? (instance = new ReservationRepository(_context));
        }


        public void Add(Reservation newReservation)
        {
            _context.Reservation.Add(newReservation);
            _context.SaveChanges();
        }

        public ReservationsViewModel GetAll()
        {
            var query = _context.Reservation.AsNoTracking();
            var reservations = query.Select(reservation => new ReservationViewModel
            {
                Reservation_ID = reservation.Id,
                User = reservation.User.Username,
                Book = reservation.Book.Title,
                ReservationDate = reservation.ReservationDate

            }).ToList();
            var model = new ReservationsViewModel { Reservations = reservations };
            return model;
        }

        public Reservation GetById(int id)
        {
            return _context.Reservation.AsNoTracking().Where(r => r.Id == id).SingleOrDefault();
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
