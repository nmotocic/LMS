﻿using LMS.Domain.Models;
using LMS.Domain.ViewModels;
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
        BooksViewModel GetAll();

        void Add(Book newBook);
        void Update(Book book);
        void Delete(Book book);
    }
}
