using LMS.Domain.Repositories;
using LMS.Domain.ViewModels;

namespace LMS.Presenters
{
    public class BookPresenter
    {
        private readonly IBookRepository _bookRepository;

        public BookPresenter()
        { }


        public BookPresenter(IBookRepository bookRepository) {
            _bookRepository = bookRepository;
        }

        public BooksViewModel ShowBooks()
        {
            return _bookRepository.GetAll();
        }

        public void Loan(int bookID) {
            var book = _bookRepository.GetByID(bookID);
            _bookRepository.Loan(book);
        }

        public void Reserve(int bookId)
        {


        }
    }
}
