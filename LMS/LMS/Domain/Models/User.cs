using System;
using System.Collections.Generic;

namespace LMS.Domain.Models
{
    public partial class User
    {
        public User()
        {
            Loan = new HashSet<Loan>();
            Reservation = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Loan> Loan { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
