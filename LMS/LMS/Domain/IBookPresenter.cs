﻿using LMS.Domain.Models;
using LMS.Domain.Services;
using LMS.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain
{
    interface IBookPresenter
    {
        BooksViewModel ShowBooks();
    }
}
