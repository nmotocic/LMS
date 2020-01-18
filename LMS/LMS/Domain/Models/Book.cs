using LMS.Domain.Enums;
using System;
using System.Collections.Generic;

namespace LMS.Domain.Models
{
    public partial class Book
    {
        public Book()
        {
            Loan = new HashSet<Loan>();
            Reservation = new HashSet<Reservation>();
        }

        public int SerialNumber { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int? YearOfPublishing { get; set; }
        public string Genre { get; set; }
        public EStatus Status { get; set; }

        public virtual ICollection<Loan> Loan { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
