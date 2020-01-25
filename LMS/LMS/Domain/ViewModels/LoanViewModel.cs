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
        public Customer User { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Book Book { get; set; }
        public string BookTitle { get; set; }
        public DateTime? LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
