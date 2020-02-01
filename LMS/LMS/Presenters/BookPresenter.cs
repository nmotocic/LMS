using LMS.Domain.Repositories;
using LMS.Domain.ViewModels;
using LMS.Persistence.Repositories;

namespace LMS.Presenters
{
    public class BookPresenter
    {
        private readonly IBookRepository _bookRepository;

        //public BookPresenter() { }


        public BookPresenter() {
            _bookRepository = BookRepository.getInstance();
        }

        public BooksViewModel ShowBooks()
        {
            return _bookRepository.GetAll();
        }

        public bool Loan(int bookID, string username) {
            var book = _bookRepository.GetByID(bookID);
            return _bookRepository.Loan(book, username);
        }

        public void Reserve(int bookID, string username)
        {
            var book = _bookRepository.GetByID(bookID);
            _bookRepository.Reserve(book, username);

        }
    }
}
