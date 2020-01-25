
using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Domain.Services;
using LMS.Persistence.Context;
using LMS.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Services
{
    public class ReservationService : IReservationService
    {
        private IReservationRepository _reservationRepository;
        private IBookRepository _bookRepository;
        private IUserRepository _userRepository;

        public ReservationService()
        {
            _reservationRepository = ReservationRepository.getInstance();
            _bookRepository = BookRepository.getInstance();
            _userRepository = UserRepository.getInstance();
        }

        //public ReservationService() { }

       
        
        public void ReserveBook(int bookID, string username)
        {
            var book = _bookRepository.GetByID(bookID);
            var user = _userRepository.GetByUsername(username);
            UpdateBookStatus(bookID, "Reserved");
            var date = DateTime.Now;
            var reservation = new Reservation
            {
                Id = RandomNumber(10000, 100000),
                BookId = bookID,
                Book = book,
                User = user,
                ReservationDate = date
            };
            _reservationRepository.Add(reservation);
            
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void UpdateBookStatus(int bookID, string newStatus)
        {
            var book = _bookRepository.GetByID(bookID);

            switch (newStatus)
            {
                case "Avaliable":
                    book.Status.Equals("Avaliable");
                    break;
                case "Reserved":
                    book.Status.Equals("Reserved");
                    break;
            }
            _bookRepository.Update(book);
        }

        public void CancelReservation(int reservationID)
        {
            var reservation = _reservationRepository.GetById(reservationID);
            UpdateBookStatus(reservation.BookId, "Avaliable");

            _reservationRepository.Remove(reservation);
            
        }
    }
}