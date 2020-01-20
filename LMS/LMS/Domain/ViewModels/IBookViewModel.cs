using LMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.ViewModels
{
    public interface IBookViewModel
    {
        int Serial_Number { get; set; }
        string BookTitle { get; set; }
        string BookAuthor { get; set; }
        string Publisher { get; set; }
        int Year_Of_Publishing { get; set; }
        string Genre { get; set; }
        EStatus Status { get; set; }
    }
}
