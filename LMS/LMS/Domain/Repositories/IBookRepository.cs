using LMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Repositories
{
    public interface IBookRepository
    {
        Book GetByID(int id);
        IEnumerable<Book> GetAll();

        void Add(Book newBook);
        void Update(Book book);
        void Delete(Book book);
    }
}
