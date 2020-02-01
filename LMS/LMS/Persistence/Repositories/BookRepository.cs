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
using System.Windows.Forms;

namespace LMS.Persistence.Repositories
{
    public class BookRepository :  IBookRepository
    {
        protected static LibraryContext _context = new LibraryContext();
        private static BookRepository instance;
        

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }


        public static BookRepository getInstance() {
            return instance ?? (instance = new BookRepository(_context));
        }

        public bool Add(Book newBook)
        {
            _context.Add(newBook);
            _context.SaveChanges();
            return true;
        }

        public void Delete(int bookId)
        {
            var book = GetByID(bookId);
            
            using ( var context = new LibraryContext()) {
                context.Remove(book);
                context.SaveChanges();
            }
           
        }

        public BooksViewModel GetAll()
        {
           
            var query = _context.Book.AsNoTracking();
            var books = query.Select(book => new BookViewModel {
                Serial_Number = book.SerialNumber,
                BookTitle = book.Title,
                BookAuthor = book.Author,
                Publisher = book.Publisher,
                Year_Of_Publishing = book.YearOfPublishing,
                Genre = book.Genre,
                Status = book.Status
            }).ToList();

            var model = new BooksViewModel { Books = books };
            return model;
        }

        
        public Book GetByID(int id)
        {
            var book = _context.Book.AsNoTracking().Where(bk => bk.SerialNumber == id).FirstOrDefault();
            return book;
       }
        

        public void Update(Book book)
        {
            if (book == null) {
                MessageBox.Show("Book can't be updated!");
            }

            using (var context = new LibraryContext()) {
                /*
                var local = _context.Book.Local.FirstOrDefault(b => b.SerialNumber == book.SerialNumber);
                if (local != null)
                {
                    _context.Entry(book).State = EntityState.Detached;
                }
                */
                /*
                bool checkID = _context.Book.AsNoTracking().Any(b => b.SerialNumber == book.SerialNumber);
                if (!checkID) {
                    MessageBox.Show("Book can't be updated!");
                }
                */

                //_context.Entry(book).State = EntityState.Modified;
                context.Book.Update(book);
                context.SaveChanges();
            }

                
        }

        public void Update(int bookID)
        {
            var book = GetByID(bookID);
            Update(book);
        }

        public bool Loan(Book book, string username) {
            LoanService loanService = new LoanService();
            return loanService.CheckOutBook(book.SerialNumber, username);

        }

        public bool Reserve(Book book, string username) {
            ReservationService reservationService = new ReservationService();
            return reservationService.ReserveBook(book.SerialNumber, username);
        }

       
    }
}
