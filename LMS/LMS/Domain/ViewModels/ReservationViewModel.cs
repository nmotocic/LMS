﻿using LMS.Domain.Models;
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
        public string User { get; set; }
        public string Book { get; set; }
        public DateTime? ReservationDate { get; set; }
    }
}