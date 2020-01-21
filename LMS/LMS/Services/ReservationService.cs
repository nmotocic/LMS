
using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Domain.Services;
using LMS.Persistence.Context;
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

        public ReservationService(IReservationRepository resevrationRepository, IBookRepository bookRepository)
        {
            _reservationRepository = resevrationRepository;
            _bookRepository = bookRepository;
        }

       
        
        public void ReserveBook(int bookID)
        {
            var book = _bookRepository.GetByID(bookID);
            UpdateBookStatus(bookID, "Reserved");
            var date = DateTime.Now;
            var reservation = new Reservation
            {
                BookId = bookID,
                Book = book,
                
                ReservationDate = date
            };
            _reservationRepository.Add(reservation);
            
        }

        private void UpdateBookStatus(int bookID, string newStatus)
        {
            var book = _bookRepository.GetByID(bookID);
            _bookRepository.Update(book);

            switch (newStatus)
            {
                case "Avaliable":
                    book.Status.Equals("AVALIABLE");
                    break;
                case "Reserved":
                    book.Status.Equals("RESERVED");
                    break;
            }
        }

        public void CancelReservation(int reservationID)
        {
            var reservation = _reservationRepository.GetById(reservationID);
            UpdateBookStatus(reservation.BookId, "Avaliable");

            _reservationRepository.Remove(reservation);
            
        }
    }
}