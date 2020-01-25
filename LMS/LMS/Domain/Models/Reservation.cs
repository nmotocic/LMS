using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Domain.Models
{
    public partial class Reservation
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        public DateTime? ReservationDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual Customer User { get; set; }
    }
}
