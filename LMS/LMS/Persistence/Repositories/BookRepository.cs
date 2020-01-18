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
    public class BookRepository : BaseRepository, IBookRepository
    {
        public BookRepository(LibraryContext context) : base(context)
        {
        }

        public void Add(Book newBook)
        {
            _context.Book.Add(newBook);
            _context.SaveChanges();
        }

        public void Delete(Book book)
        {
            _context.Book.Remove(book);
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Book;
        }

        public Book GetByID(int id)
        {
            return GetAll().FirstOrDefault(book => book.SerialNumber == id);
        }
        
        public void Update(Book book)
        {
            _context.Book.Update(book);
        }
        
    }
}
