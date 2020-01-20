using LMS.Domain;
using LMS.Domain.Models;
using LMS.Domain.Repositories;
using LMS.Domain.Services;
using LMS.Domain.ViewModels;
using LMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Presenters
{
    public class BookPresenter : IBookPresenter
    {
        private readonly IBookRepository _bookRepository;
       
        public BookPresenter()
        {}
        

        public BookPresenter(IBookRepository bookRepository) {
            _bookRepository = bookRepository;
        }

        public BooksViewModel ShowBooks()
        {
            return _bookRepository.GetAll();
        }
    }
}
