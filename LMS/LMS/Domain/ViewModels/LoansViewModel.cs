using LMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.ViewModels
{
    public class LoansViewModel
    {
        public IEnumerable<LoanViewModel> Loans { get; set; }
    }
}
