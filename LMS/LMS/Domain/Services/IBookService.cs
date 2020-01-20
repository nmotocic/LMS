using LMS.Domain.Enums;
using LMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Domain.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();



        String GetAuthor(int id);
        String GetTitle(int id);
        String GetGenre(int id);
        String GetPublisher(int id);
        int? GetYOP(int id);
        EStatus GetStatus(int id);
    }
}