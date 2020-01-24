using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Domain.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Loan = new HashSet<Loan>();
            Reservation = new HashSet<Reservation>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
