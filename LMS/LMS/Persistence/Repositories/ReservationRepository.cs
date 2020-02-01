using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Domain.ViewModels;
using LMS.Persistence.Context;
using LMS.Services;
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
            newReservation.Book = new Book() { SerialNumber = newReservation.BookId };
            newReservation.User = new Customer() { Id = newReservation.CustomerId };
            _context.Book.Attach(newReservation.Book);
            _context.Customer.Attach(newReservation.User);

            _context.Reservation.Add(newReservation);
            _context.SaveChanges();
        }

        public void CancelReservation(Reservation reservation)
        {
            ReservationService reservationService = new ReservationService();
            reservationService.CancelReservation(reservation.Id);
        }

        public ReservationsViewModel GetAll()
        {
            var query = _context.Reservation.AsNoTracking();
            var reservations = query.Select(reservation => new ReservationViewModel
            {
                Reservation_ID = reservation.Id,
                User = reservation.User,
                Book = reservation.Book,
                ReservationDate = reservation.ReservationDate

            }).ToList();
            var model = new ReservationsViewModel { Reservations = reservations };
            return model;
        }

        public Reservation GetById(int id)
        {
            return _context.Reservation.AsNoTracking().Where(r => r.Id == id).FirstOrDefault();
        }

        public List<Reservation> GetByUsername(string username)
        {
            return _context.Reservation.AsNoTracking().Where(r => r.User.Username.Equals(username)).ToList();
        }

        public Reservation GetByBookId(int bookId) {
            return _context.Reservation.AsNoTracking().FirstOrDefault(r => r.BookId == bookId);
        }

        public void Remove(Reservation reservation)
        {
            using (var context = new LibraryContext()) {
                context.Reservation.Remove(reservation);
                context.SaveChanges();
            }
           
        }

        
        public void Update(Reservation reservation)
        {
            _context.Reservation.Update(reservation);
            _context.SaveChanges();
        }
        
    }
}
