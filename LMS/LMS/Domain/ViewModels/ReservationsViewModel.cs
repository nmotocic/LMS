using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.ViewModels
{
    public class ReservationsViewModel
    {
        public IEnumerable<ReservationViewModel> Reservations { get; set; }
    }
}
