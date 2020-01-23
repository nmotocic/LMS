using LMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.ViewModels
{
    public class ReservationViewModel
    {
        public int Reservation_ID { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
        public DateTime? ReservationDate { get; set; }
    }
}
