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

        public void Add(Book newBook)
        {
            _context.Add(newBook);
            
            _context.SaveChanges();
        }

        public void Delete(Book book)
        {
            _context.Remove(book);
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
            var book = _context.Book.AsNoTracking().Where(bk => bk.SerialNumber == id).SingleOrDefault();
            return book;
        }
        

        public void Update(Book book)
        {
            _context.Book.Update(book);
        }
        
    }
}
