
using LMS.Domain.Models;
using LMS.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Domain.Services
{
    public interface IBookService
    {
        BooksViewModel GetAll();

        String GetAuthor(int id);
        String GetTitle(int id);
        String GetGenre(int id);
        String GetPublisher(int id);
        int? GetYOP(int id);
        string GetStatus(int id);
    }
}