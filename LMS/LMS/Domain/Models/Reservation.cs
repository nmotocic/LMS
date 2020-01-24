using System;
using System.Collections.Generic;

namespace LMS.Domain.Models
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        public DateTime? ReservationDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual Customer User { get; set; }
    }
}
