using LMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.ViewModels
{
    public class LoanViewModel
    {
        public int Loan_ID { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
        public DateTime? LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
