using LMS.Domain.Repositories;
using LMS.Domain.Services;
using LMS.Domain.ViewModels;
using System;

namespace LMS.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository) {
            _bookRepository = bookRepository;
        }

        

        public BooksViewModel GetAll() {

            return _bookRepository.GetAll();
        }

        public String GetAuthor(int id)
        {
            return _bookRepository.GetByID(id).Author;
        }

        public String GetGenre(int id)
        {
            return _bookRepository.GetByID(id).Genre;
        }

        public String GetPublisher(int id)
        {
            return _bookRepository.GetByID(id).Publisher;
        }

        public string GetStatus(int id)
        {
            return _bookRepository.GetByID(id).Status;
        }

        public String GetTitle(int id)
        {
            return _bookRepository.GetByID(id).Title;
        }

        public int? GetYOP(int id)
        {
            return _bookRepository.GetByID(id).YearOfPublishing;
        }
 
    }
}